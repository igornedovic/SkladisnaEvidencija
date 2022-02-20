using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class PretraziProizvodeSO : OpstaSistemskaOperacija
    {
        public List<Proizvod> Rezultat { get; set; }
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Proizvod proizvodZaPretragu = (Proizvod)obj;
            proizvodZaPretragu.WhereCondition = $"LOWER(NazivProizvoda) LIKE LOWER('%{proizvodZaPretragu.Naziv}%')";
            Rezultat = repository.PretraziJoin(proizvodZaPretragu.WhereCondition, proizvodZaPretragu, new JedinicaMere()).OfType<Proizvod>().ToList();
        }
    }
}
