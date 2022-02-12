using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class Proizvod : IDomainObject
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public int UkupnaKolicina { get; set; }
        public string Opis { get; set; }
        public JedinicaMere JedinicaMere { get; set; }

        public string TableName => "Proizvod";

        public string InsertValues => null;

        public string PrimaryKey => "ProizvodId";

        public string ForeignKey => "JmId";

        public object Criteria { get; set; }
        public string Set { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Proizvod p)
            {
                return p.ProizvodId == ProizvodId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ProizvodId.GetHashCode();
        }


        public override string ToString()
        {
            return $"{Naziv}";
        }
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Proizvod p = new Proizvod();
            p.ProizvodId = (int)reader["ProizvodId"];
            p.Naziv = (string)reader["NazivProizvoda"];
            p.UkupnaKolicina = (int)reader["UkupnaKolicina"];
            p.Opis = (string)reader["Opis"];
            p.JedinicaMere = new JedinicaMere
            {
                JedinicaMereId = (int)reader["JedinicaMereId"],
                Naziv = (string)reader["NazivJediniceMere"]
            };

            return p;
        }
    }
}
