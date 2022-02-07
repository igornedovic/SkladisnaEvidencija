using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class PravnoLice : PoslovniPartner
    {
        public string NazivFirme { get; set; }
        public string PIB { get; set; }
        public string Email { get; set; }

    }
}
