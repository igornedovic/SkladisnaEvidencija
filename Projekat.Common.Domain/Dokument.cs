﻿using System;
using System.Collections.Generic;
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
    public class Dokument
    {
        public int DokumentId { get; set; }
        public NazivDokumenta NazivDokumenta { get; set; }
        public DateTime Datum { get; set; }
        public double UkupanIznos { get; set; }
        public string Status { get; set; }
        public PoslovniPartner PoslovniPartner { get; set; }
        public List<StavkaDokumenta> StavkeDokumenta { get; set; }

    }
}