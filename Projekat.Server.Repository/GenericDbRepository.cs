using Projekat.Common.Domain;
using Projekat.Server.DatabaseBroker;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {obj.TableName}";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject objekat = obj.ReadObjectRow(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public List<IDomainObject> VratiSve(IDomainObject obj, IDomainObject obj1 = null)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {obj.TableName} t1 JOIN {obj1.TableName} t2 ON ({obj.ForeignKey} = {obj1.PrimaryKey})";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject objekat = obj.ReadObjectRow(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
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
