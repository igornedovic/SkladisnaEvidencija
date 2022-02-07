using Projekat.Common.Domain;
using Projekat.Server.DatabaseBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.Repository
{
    public class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        public void OtvoriKonekciju()
        {
            broker.OpenConnection();
        }

        public void ZatvoriKonekciju()
        {
            broker.CloseConnection();
        }

        public void ZapocniTransakciju()
        {
            broker.BeginTransaction();
        }
        public void PotvrdiTransakciju()
        {
            broker.Commit();
        }
        public void PonistiTransakciju()
        {
            broker.Rollback();
        }

        public List<IDomainObject> VratiSve(IDomainObject obj)
        {
            throw new NotImplementedException();
        }
        public void Sacuvaj(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public void Izmeni(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public List<IDomainObject> Pretrazi(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
