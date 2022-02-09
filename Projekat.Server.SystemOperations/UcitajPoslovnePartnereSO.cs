using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UcitajPoslovnePartnereSO : BaznaSistemskaOperacija
    {
        public List<PoslovniPartner> PravnaLica { get; private set; }
        public List<PoslovniPartner> FizickaLica { get; private set; }

        public List<PoslovniPartner> Rezultat { get; private set; }
        protected override void Execute()
        {
            PravnaLica = repository.VratiSve(new PravnoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();
            FizickaLica = repository.VratiSve(new FizickoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();

            Rezultat = PravnaLica.Concat(FizickaLica).ToList();
        }
    }
}
