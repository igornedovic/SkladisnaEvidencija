using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class IzmeniMagacinskiDokumentSO : OpstaSistemskaOperacija
    {
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Dokument dokument = (Dokument)obj;
            dokument.SetValues = $"Datum='{dokument.Datum}', UkupanIznos={dokument.UkupanIznos}, Status='{dokument.Status}'";
            dokument.WhereCondition = $"MagacinskiDokumentId={dokument.DokumentId}";
            repository.Izmeni(dokument);

            StavkaDokumenta stavka = new StavkaDokumenta();
            stavka.WhereCondition = $"DokumentId={dokument.DokumentId}";
            repository.Obrisi(stavka);

            foreach (StavkaDokumenta s in dokument.StavkeDokumenta)
            {
                s.DokumentId = dokument.DokumentId;
                repository.Sacuvaj(s);
            }
        }
    }
}
