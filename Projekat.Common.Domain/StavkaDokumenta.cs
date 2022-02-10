using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class StavkaDokumenta : IDomainObject
    {
        public int DokumentId { get; set; }
        public int RbStavke { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public double Iznos { get; set; }

        public string TableName => "StavkaMagacinskogDokumenta";

        public string InsertValues => $"{DokumentId}, {RbStavke}, {Kolicina}, {Cena}, {Iznos}, {Proizvod.ProizvodId}";

        public string PrimaryKey => null;

        public string ForeignKey => null;

        public string Criteria => null;

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
