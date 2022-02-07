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

        string PrimaryKey { get; }
        string ForeignKey { get; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
