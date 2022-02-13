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
        private readonly Proizvod proizvodZaPretragu;

        public PretraziProizvodeSO(Proizvod proizvodZaPretragu)
        {
            this.proizvodZaPretragu = proizvodZaPretragu;
        }

        public List<Proizvod> Rezultat { get; set; }
        protected override void Execute()
        {
            proizvodZaPretragu.Criteria = $"LOWER(NazivProizvoda) LIKE LOWER('%{proizvodZaPretragu.Naziv}%')";
            Rezultat = repository.PretraziJoin(proizvodZaPretragu.Criteria, proizvodZaPretragu, new JedinicaMere()).OfType<Proizvod>().ToList();
        }
    }
}
