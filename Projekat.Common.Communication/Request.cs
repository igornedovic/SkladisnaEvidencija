using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Common.Communication
{
    public enum Operation
    {
        Login,
        UcitajPoslovnePartnere,
        UcitajProizvode,
        UnesiMagacinskiDokument,
        UcitajMagacinskeDokumente,
        PretraziMagacinskeDokumente,
        UcitajMagacinskiDokument,
        IzmeniMagacinskiDokument,
        StornirajMagacinskiDokument,
        PretraziProizvode,
        UcitajProizvod,
        IzmeniProizvod,
        ObrisiProizvod,
        End
    }


    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }

    }
}
