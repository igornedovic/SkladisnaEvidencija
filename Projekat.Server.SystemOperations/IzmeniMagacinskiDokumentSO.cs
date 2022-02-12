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
        private readonly Dokument dokument;

        public IzmeniMagacinskiDokumentSO(Dokument dokument)
        {
            this.dokument = dokument;
        }
        protected override void Execute()
        {
            dokument.Set = $"Datum='{dokument.Datum}', UkupanIznos={dokument.UkupanIznos}, Status='{dokument.Status}'";
            dokument.Criteria = $"MagacinskiDokumentId={dokument.DokumentId}";
            repository.Izmeni(dokument);

            StavkaDokumenta stavka = new StavkaDokumenta();
            stavka.Criteria = $"DokumentId={dokument.DokumentId}";
            repository.Obrisi(stavka);

            foreach (StavkaDokumenta s in dokument.StavkeDokumenta)
            {
                s.DokumentId = dokument.DokumentId;
                repository.Sacuvaj(s);
            }
        }
    }
}
