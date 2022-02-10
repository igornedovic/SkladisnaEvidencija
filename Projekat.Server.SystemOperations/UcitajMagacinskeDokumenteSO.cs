using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UcitajMagacinskeDokumenteSO : OpstaSistemskaOperacija
    {
        public List<Dokument> Rezultat { get; private set; }
        protected override void Execute()
        {
            Rezultat = repository.VratiSve(new Dokument()).OfType<Dokument>().ToList();
        }
    }
}
