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
        public Dokument Rezultat { get; set; }
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Dokument izabraniDokument = (Dokument)obj;
            izabraniDokument.WhereCondition = $"DokumentId={izabraniDokument.DokumentId}";
            List<StavkaDokumenta> stavke = repository.PretraziJoin(izabraniDokument.WhereCondition, new StavkaDokumenta(), new Proizvod(), new JedinicaMere()).OfType<StavkaDokumenta>().ToList();
            izabraniDokument.StavkeDokumenta = stavke;

            Rezultat = izabraniDokument;
        }
    }
}
