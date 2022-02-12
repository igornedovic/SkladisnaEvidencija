using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    public interface IDomainObject
    {
        string TableName { get; }
        string InsertValues { get; }

        string Set { get; set; }

        string PrimaryKey { get; }
        string ForeignKey { get; }

        object Criteria { get; set; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
