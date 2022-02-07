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

        public string InsertValues => throw new NotImplementedException();

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
