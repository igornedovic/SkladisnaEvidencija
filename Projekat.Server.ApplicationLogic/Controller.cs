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
            BaznaSistemskaOperacija so = new UcitajPoslovnePartnereSO();
            so.ExecuteTemplate();
            return ((UcitajPoslovnePartnereSO)so).Rezultat;
        }

        public List<Proizvod> UcitajProizvode()
        {
            BaznaSistemskaOperacija so = new UcitajProizvodeSO();
            so.ExecuteTemplate();
            return ((UcitajProizvodeSO)so).Rezultat;
        }

        public void UnesiMagacinskiDokument(Dokument dokument)
        {
            BaznaSistemskaOperacija so = new UnesiMagacinskiDokumentSO(dokument);
            so.ExecuteTemplate();
        }
    }
}
