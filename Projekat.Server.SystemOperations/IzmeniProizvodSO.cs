using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class IzmeniProizvodSO : OpstaSistemskaOperacija
    {
        private readonly Proizvod izabraniProizvod;

        public IzmeniProizvodSO(Proizvod izabraniProizvod)
        {
            this.izabraniProizvod = izabraniProizvod;
        }
        protected override void Execute()
        {
            izabraniProizvod.Set = $"NazivProizvoda='{izabraniProizvod.Naziv}', UkupnaKolicina={izabraniProizvod.UkupnaKolicina}, Opis='{izabraniProizvod.Opis}'";
            izabraniProizvod.Criteria = $"ProizvodId={izabraniProizvod.ProizvodId}";
            repository.Izmeni(izabraniProizvod);
        }
    }
}
