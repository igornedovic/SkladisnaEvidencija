using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UnesiMagacinskiDokumentSO : BaznaSistemskaOperacija
    {
        private readonly Dokument dokument;

        public UnesiMagacinskiDokumentSO(Dokument dokument)
        {
            this.dokument = dokument;
        }
        protected override void Execute()
        {
            int dokumentId = repository.SacuvajIVratiId(dokument);

            foreach (StavkaDokumenta stavka in dokument.StavkeDokumenta)
            {
                stavka.DokumentId = dokumentId;
                repository.Sacuvaj(stavka);
            }
        }
    }
}
