﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class JedinicaMere : IDomainObject
    {
        public int JedinicaMereId { get; set; }
        public string Naziv { get; set; }

        public string TableName => "JedinicaMere";

        public string InsertValues => null;

        public string PrimaryKey => "JedinicaMereId";

        public string ForeignKey => null;

        public object Criteria => null;

        public override bool Equals(object obj)
        {
            if (obj is JedinicaMere jm)
            {
                return jm.JedinicaMereId == JedinicaMereId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return JedinicaMereId.GetHashCode();
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }

    }
}
