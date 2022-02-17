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

        public List<IDomainObject> VratiSveJoin(params IDomainObject[] obj)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();

            if (obj.Length == 2)
            {
                command.CommandText = $"SELECT * FROM {obj[0].TableName} t1 JOIN {obj[1].TableName} t2 ON (t1.{obj[0].ForeignKey} = t2.{obj[1].PrimaryKey})";
            }
            else if (obj.Length == 3)
            {
                command.CommandText = $"SELECT * FROM {obj[0].TableName} t1 JOIN {obj[1].TableName} t2 ON (t1.{obj[0].ForeignKey} = t2.{obj[1].PrimaryKey}) JOIN {obj[2].TableName} t3 ON (t2.{obj[1].ForeignKey} = t3.{obj[2].PrimaryKey})";
            }
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject objekat = obj[0].ReadObjectRow(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public List<IDomainObject> Pretrazi(string kriterijum, IDomainObject obj)
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

        public List<IDomainObject> PretraziJoin(string kriterijum, params IDomainObject[] obj)
        {
            List<IDomainObject> rezultat = new List<IDomainObject>();
            SqlCommand command = broker.KreirajKomandu();

            if (obj.Length == 2)
            {
                command.CommandText = $"SELECT * FROM {obj[0].TableName} t1 JOIN {obj[1].TableName} t2 ON (t1.{obj[0].ForeignKey} = t2.{obj[1].PrimaryKey}) WHERE {kriterijum}";
            }
            else if (obj.Length == 3)
            {
                command.CommandText = $"SELECT * FROM {obj[0].TableName} t1 JOIN {obj[1].TableName} t2 ON (t1.{obj[0].ForeignKey} = t2.{obj[1].PrimaryKey}) JOIN {obj[2].TableName} t3 ON (t2.{obj[1].ForeignKey} = t3.{obj[2].PrimaryKey}) WHERE {kriterijum}";
            }

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject objekat = obj[0].ReadObjectRow(reader);
                    rezultat.Add(objekat);
                }
            }

            return rezultat;
        }

        public int SacuvajIVratiId(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"INSERT INTO {obj.TableName} OUTPUT INSERTED.{obj.PrimaryKey} VALUES ({obj.InsertValues})";
            return (int)command.ExecuteScalar();
        }
        public void Sacuvaj(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"INSERT INTO {obj.TableName} VALUES ({obj.InsertValues})";
            command.ExecuteNonQuery();
        }

        public void Izmeni(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"UPDATE {obj.TableName} SET {obj.SetValues} WHERE {obj.WhereCondition}";
            command.ExecuteNonQuery();
        }

        public void Obrisi(IDomainObject obj)
        {
            SqlCommand command = broker.KreirajKomandu();
            command.CommandText = $"DELETE FROM {obj.TableName} WHERE {obj.WhereCondition}";
            command.ExecuteNonQuery();
        }
    }
}
