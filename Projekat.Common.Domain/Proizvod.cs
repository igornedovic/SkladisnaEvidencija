using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Domain
{
    [Serializable]
    public class Proizvod
    {
        public int ProizvodId { get; set; }
        public string Naziv { get; set; }
        public int UkupnaKolicina { get; set; }
        public string Opis { get; set; }
        public JedinicaMere JedinicaMere { get; set; }
    }
}
