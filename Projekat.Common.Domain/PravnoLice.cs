using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class PravnoLice : PoslovniPartner
    {
        public string NazivFirme { get; set; }
        public string PIB { get; set; }
        public string Email { get; set; }

        public override string TableName => "PravnoLice";
        public override string PrimaryKey => "PartnerId";
        public override string ForeignKey => "PartnerId";

        public override bool Equals(object obj)
        {
            if (obj is PravnoLice pl)
            {
                return pl.PartnerId == PartnerId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return PartnerId.GetHashCode();
        }

        public override string ToString()
        {
            return $"{NazivFirme}";
        }
        public override IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            PravnoLice pl = new PravnoLice();
            pl.PartnerId = (int)reader["PoslovniPartnerId"];
            pl.Adresa = (string)reader["Adresa"];
            pl.NazivFirme = (string)reader["NazivFirme"];
            pl.PIB = (string)reader["PIB"];
            pl.Email = (string)reader["Email"];

            return pl;
        }
    }
}
