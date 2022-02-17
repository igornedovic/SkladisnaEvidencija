using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UcitajPoslovnePartnereSO : OpstaSistemskaOperacija
    {
        public List<PoslovniPartner> Rezultat { get; private set; }
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            List<PoslovniPartner> PravnaLica = repository.VratiSveJoin(new PravnoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();
            List<PoslovniPartner> FizickaLica = repository.VratiSveJoin(new FizickoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();

            Rezultat = PravnaLica.Concat(FizickaLica).ToList();
        }
    }
}
