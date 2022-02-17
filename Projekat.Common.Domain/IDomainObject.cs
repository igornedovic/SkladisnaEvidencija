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
        string SetValues { get; set; }
        string WhereCondition { get; set; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
