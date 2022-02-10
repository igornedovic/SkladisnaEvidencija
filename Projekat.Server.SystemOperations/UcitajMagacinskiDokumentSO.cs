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

        public List<PravnoLice> PravnoLice { get; private set; }
        public List<FizickoLice> FizickoLice { get; private set; }
        public List<StavkaDokumenta> StavkeDokumenta { get; set; }
        public Dokument Rezultat { get; private set; }
        protected override void Execute()
        {
            izabraniDokument.Criteria = izabraniDokument.PoslovniPartner.PartnerId;
            PravnoLice = repository.PretraziJoin(izabraniDokument.Criteria, new PravnoLice(), new PoslovniPartner()).OfType<PravnoLice>().ToList();


        }
    }
}
