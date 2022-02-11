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

        public List<IDomainObject> VratiSveJoin(IDomainObject obj, IDomainObject obj1)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {obj.TableName} t1 JOIN {obj1.TableName} t2 ON (t1.{obj.ForeignKey} = t2.{obj1.PrimaryKey})";
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

        public int SacuvajIVratiId(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"INSERT INTO {obj.TableName} OUTPUT INSERTED.MagacinskiDokumentId VALUES ({obj.InsertValues})";
            return (int)command.ExecuteScalar();
        }
        public void Sacuvaj(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"INSERT INTO {obj.TableName} VALUES ({obj.InsertValues})";
            command.ExecuteNonQuery();
        }

        public List<IDomainObject> Pretrazi(object kriterijum, IDomainObject obj)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {kriterijum}";
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

        public List<IDomainObject> PretraziJoin(object kriterijum, IDomainObject obj, IDomainObject obj1)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"SELECT * FROM {obj.TableName} t1 JOIN {obj1.TableName} t2 ON (t1.{obj.ForeignKey} = t2.{obj1.PrimaryKey}) WHERE {kriterijum}";
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

        public void Izmeni(IDomainObject obj)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(IDomainObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
