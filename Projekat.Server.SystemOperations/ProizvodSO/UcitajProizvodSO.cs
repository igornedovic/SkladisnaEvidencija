using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UcitajProizvodSO : OpstaSistemskaOperacija
    {
        public Proizvod Rezultat { get; set; }
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Proizvod izabraniProizvod = (Proizvod)obj;
            izabraniProizvod.WhereCondition = $"ProizvodId={izabraniProizvod.ProizvodId}";
            Rezultat = (repository.PretraziJoin(izabraniProizvod.WhereCondition, izabraniProizvod, new JedinicaMere()).OfType<Proizvod>().ToList()).First();
        }
    }
}
