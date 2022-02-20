using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    public enum NazivDokumenta
    {
        Prijemnica,
        Otpremnica
    }

    [Serializable]
    public class Dokument : IDomainObject
    {
        public int DokumentId { get; set; }
        public NazivDokumenta NazivDokumenta { get; set; }
        public DateTime Datum { get; set; }
        public double UkupanIznos { get; set; }
        public string Status { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public List<StavkaDokumenta> StavkeDokumenta { get; set; }

        public string TableName => "MagacinskiDokument";

        public string InsertValues => $"{(int)NazivDokumenta}, '{Datum}', {UkupanIznos}, '{Status}', {PoslovniPartner.PartnerId}";

        public string PrimaryKey => "MagacinskiDokumentId";

        public string ForeignKey => "PartnerId";

        public string SetValues { get; set; }
        public string WhereCondition { get; set; }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Dokument d = new Dokument();
            d.DokumentId = (int)reader["MagacinskiDokumentId"];
            d.NazivDokumenta = (NazivDokumenta)reader["NazivMagacinskogDokumenta"];
            d.Datum = (DateTime)reader["Datum"];
            d.UkupanIznos = (double)reader["UkupanIznos"];
            d.Status = (string)reader["Status"];
            d.PoslovniPartner = new PoslovniPartner
            {
                PartnerId = (int)reader["PartnerId"]          
            };
            return d;
        }
    }
}
