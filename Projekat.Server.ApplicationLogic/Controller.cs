using Projekat.Common.Domain;
using Projekat.Server.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.ApplicationLogic
{
    public class Controller
    {
        private static Controller instance;

        private List<Admin> admini = new List<Admin>
        {
            new Admin
            {
                Id = 1,
                Username = "admin1",
                Password = "admin1"
            },
            new Admin
            {
                Id = 2,
                Username = "admin2",
                Password = "admin2"
            }
        };

        private Controller() { }

        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        public List<Admin> Admini => admini;

        public Admin Login(Admin admin)
        {
            Admin aktivanAdmin = admini.SingleOrDefault(a => a.Username == admin.Username && a.Password == admin.Password);
            if (aktivanAdmin != null)
            {
                aktivanAdmin.Status = "Aktivan";
            }
            return aktivanAdmin;
        }

        public List<PoslovniPartner> UcitajPoslovnePartnere()
        {
            OpstaSistemskaOperacija so = new UcitajPoslovnePartnereSO();
            so.Izvrsi();
            return ((UcitajPoslovnePartnereSO)so).Rezultat;
        }

        public List<Proizvod> UcitajProizvode()
        {
            OpstaSistemskaOperacija so = new UcitajProizvodeSO();
            so.Izvrsi();
            return ((UcitajProizvodeSO)so).Rezultat;
        }

        public void UnesiMagacinskiDokument(Dokument dokument)
        {
            OpstaSistemskaOperacija so = new UnesiMagacinskiDokumentSO();
            so.Izvrsi(dokument);
        }

        public List<Dokument> UcitajMagacinskeDokumente()
        {
            OpstaSistemskaOperacija so = new UcitajMagacinskeDokumenteSO();
            so.Izvrsi();
            return ((UcitajMagacinskeDokumenteSO)so).Rezultat;
        }

        public List<Dokument> PretraziMagacinskeDokumente(Dokument dokumentZaPretragu)
        {
            OpstaSistemskaOperacija so = new PretraziMagacinskeDokumenteSO();
            so.Izvrsi(dokumentZaPretragu);
            return ((PretraziMagacinskeDokumenteSO)so).Rezultat;
        }

        public Dokument UcitajMagacinskiDokument(Dokument izabraniDokument)
        {
            OpstaSistemskaOperacija so = new UcitajMagacinskiDokumentSO();
            so.Izvrsi(izabraniDokument);
            return ((UcitajMagacinskiDokumentSO)so).Rezultat;
        }

        public void IzmeniMagacinskiDokument(Dokument izabraniDokument)
        {
            OpstaSistemskaOperacija so = new IzmeniMagacinskiDokumentSO();
            so.Izvrsi(izabraniDokument);
        }

        public void StornirajMagacinskiDokument(Dokument izabraniDokument)
        {
            OpstaSistemskaOperacija so = new StornirajMagacinskiDokumentSO();
            so.Izvrsi(izabraniDokument);
        }

        public List<Proizvod> PretraziProizvode(Proizvod proizvodZaPretragu)
        {
            OpstaSistemskaOperacija so = new PretraziProizvodeSO();
            so.Izvrsi(proizvodZaPretragu);
            return ((PretraziProizvodeSO)so).Rezultat;
        }

        public Proizvod UcitajProizvod(Proizvod izabraniProizvod)
        {
            OpstaSistemskaOperacija so = new UcitajProizvodSO();
            so.Izvrsi(izabraniProizvod);
            return ((UcitajProizvodSO)so).Rezultat;
        }

        public void IzmeniProizvod(Proizvod izabraniProizvod)
        {
            OpstaSistemskaOperacija so = new IzmeniProizvodSO();
            so.Izvrsi(izabraniProizvod);
        }

        public void ObrisiProizvod(Proizvod izabraniProizvod)
        {
            OpstaSistemskaOperacija so = new ObrisiProizvodSO();
            so.Izvrsi(izabraniProizvod);
        }
    }
}
