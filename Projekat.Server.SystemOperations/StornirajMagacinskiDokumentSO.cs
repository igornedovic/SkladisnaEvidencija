using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class StornirajMagacinskiDokumentSO : OpstaSistemskaOperacija
    {
        private readonly Dokument dokument;

        public StornirajMagacinskiDokumentSO(Dokument dokument)
        {
            this.dokument = dokument;
        }
        protected override void Execute()
        {
            dokument.Criteria = $"MagacinskiDokumentId={dokument.DokumentId}";
            repository.Obrisi(dokument);
        }
    }
}
