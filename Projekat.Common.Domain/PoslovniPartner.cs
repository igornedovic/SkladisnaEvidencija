using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class PoslovniPartner
    {
        public int PartnerId { get; set; }
        public string Adresa { get; set; }

    }
}
