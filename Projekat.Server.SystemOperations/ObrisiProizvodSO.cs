using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class ObrisiProizvodSO : OpstaSistemskaOperacija
    {
        private readonly Proizvod izabraniProizvod;

        public ObrisiProizvodSO(Proizvod izabraniProizvod)
        {
            this.izabraniProizvod = izabraniProizvod;
        }
        protected override void Execute()
        {
            izabraniProizvod.Criteria = $"ProizvodId={izabraniProizvod.ProizvodId}";
            repository.Obrisi(izabraniProizvod);
        }
    }
}
