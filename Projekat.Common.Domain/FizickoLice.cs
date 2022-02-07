using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class FizickoLice : PoslovniPartner
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

    }
}
