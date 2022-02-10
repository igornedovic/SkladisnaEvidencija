using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class PoslovniPartner : IDomainObject
    {
        public int PartnerId { get; set; }
        public string Adresa { get; set; }

        public virtual string TableName => "PoslovniPartner";

        public virtual string InsertValues => null;

        public virtual string PrimaryKey => "PoslovniPartnerId";

        public virtual string ForeignKey => null;

        public object Criteria => null;

        public virtual IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            PoslovniPartner pp = new PoslovniPartner();
            pp.PartnerId = (int)reader["PoslovniPartnerId"];
            pp.Adresa = (string)reader["Adresa"];
            return pp;
        }

    }
}
