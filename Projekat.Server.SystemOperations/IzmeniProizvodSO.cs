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
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Proizvod izabraniProizvod = (Proizvod)obj;
            izabraniProizvod.SetValues = $"NazivProizvoda='{izabraniProizvod.Naziv}', UkupnaKolicina={izabraniProizvod.UkupnaKolicina}, Opis='{izabraniProizvod.Opis}'";
            izabraniProizvod.WhereCondition = $"ProizvodId={izabraniProizvod.ProizvodId}";
            repository.Izmeni(izabraniProizvod);
        }
    }
}
