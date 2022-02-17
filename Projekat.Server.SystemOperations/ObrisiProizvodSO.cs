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
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Proizvod izabraniProizvod = (Proizvod)obj;
            izabraniProizvod.WhereCondition = $"ProizvodId={izabraniProizvod.ProizvodId}";
            repository.Obrisi(izabraniProizvod);
        }
    }
}
