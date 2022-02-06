using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class StavkaDokumenta
    {
        public int DokumentId { get; set; }
        public int RbStavke { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public double Iznos { get; set; }


    }
}
