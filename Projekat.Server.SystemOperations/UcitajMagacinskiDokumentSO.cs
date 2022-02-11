using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UcitajMagacinskiDokumentSO : OpstaSistemskaOperacija
    {
        private readonly Dokument izabraniDokument;

        public UcitajMagacinskiDokumentSO(Dokument izabraniDokument)
        {
            this.izabraniDokument = izabraniDokument;
        }

        public List<StavkaDokumenta> Stavke { get; private set; }

        public Dokument Rezultat { get; set; }
        protected override void Execute()
        {
            izabraniDokument.Criteria = $"DokumentId={izabraniDokument.DokumentId}";
            Stavke = repository.Pretrazi(izabraniDokument.Criteria, new StavkaDokumenta()).OfType<StavkaDokumenta>().ToList();
            izabraniDokument.StavkeDokumenta = Stavke;

            foreach(StavkaDokumenta s in izabraniDokument.StavkeDokumenta)
            {
                s.Criteria = $"ProizvodId={s.Proizvod.ProizvodId}";
                s.Proizvod = (repository.PretraziJoin(s.Criteria, new Proizvod(), new JedinicaMere()).OfType<Proizvod>().ToList())[0];
            }

            Rezultat = izabraniDokument;
        }
    }
}
