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
        private readonly Proizvod izabraniProizvod;

        public UcitajProizvodSO(Proizvod izabraniProizvod)
        {
            this.izabraniProizvod = izabraniProizvod;
        }

        public Proizvod Rezultat { get; set; }
        protected override void Execute()
        {
            izabraniProizvod.Criteria = $"ProizvodId={izabraniProizvod.ProizvodId}";
            Rezultat = (repository.PretraziJoin(izabraniProizvod.Criteria, izabraniProizvod, new JedinicaMere()).OfType<Proizvod>().ToList())[0];
        }
    }
}
