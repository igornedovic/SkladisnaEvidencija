using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class PretraziMagacinskeDokumenteSO : OpstaSistemskaOperacija
    {
        private readonly Dokument dokumentZaPretragu;

        public PretraziMagacinskeDokumenteSO(Dokument dokumentZaPretragu)
        {
            this.dokumentZaPretragu = dokumentZaPretragu;
        }
        public List<Dokument> Rezultat { get; private set; }
        protected override void Execute()
        {
            Rezultat = repository.Pretrazi(dokumentZaPretragu.Criteria, dokumentZaPretragu).OfType<Dokument>().ToList();
        }
    }
}
