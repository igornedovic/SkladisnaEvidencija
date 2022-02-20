using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.Session
{
    public class SessionData
    {
        private static SessionData instance;
        private static object lockObject = new object();

        private SessionData() { }

        public static SessionData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SessionData();
                        }
                    }
                }

                return instance;
            }
        }

        public NazivDokumenta NazivDokumenta { get; set; }
        public Proizvod TrenutniProizvod { get; set; }
        public List<Proizvod> DodatiProizvodi { get; set; } = new List<Proizvod>();
        public BindingList<StavkaDokumenta> StavkeDokumenta { get; set; } = new BindingList<StavkaDokumenta>();
    }
}
