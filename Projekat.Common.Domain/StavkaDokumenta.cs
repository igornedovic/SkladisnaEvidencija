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

        public object Criteria { get; set; }
        public string Set { get; set; }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            StavkaDokumenta sd = new StavkaDokumenta();
            sd.DokumentId = (int)reader["DokumentId"];
            sd.RbStavke = (int)reader["RBStavke"];
            sd.Kolicina = (int)reader["Kolicina"];
            sd.Cena = (double)reader["Cena"];
            sd.Iznos = (double)reader["Iznos"];
            sd.Proizvod = new Proizvod
            {
                ProizvodId = (int)reader["ProizvodId"]
            };

            return sd;
        }

        public override bool Equals(object obj)
        {
            if (obj is StavkaDokumenta s)
            {
                return s.Proizvod.Naziv == Proizvod.Naziv;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
