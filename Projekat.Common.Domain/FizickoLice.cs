using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class FizickoLice : PoslovniPartner
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public override string TableName => "FizickoLice";
        public override string PrimaryKey => "PartnerId";
        public override string ForeignKey => "PartnerId";

        public override bool Equals(object obj)
        {
            if (obj is FizickoLice fl)
            {
                return fl.PartnerId == PartnerId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return PartnerId.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
        public override IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            FizickoLice fl = new FizickoLice();
            fl.PartnerId = (int)reader["PoslovniPartnerId"];
            fl.Adresa = (string)reader["Adresa"];
            fl.Ime = (string)reader["Ime"];
            fl.Prezime = (string)reader["Prezime"];

            return fl;
        }
    }
}
