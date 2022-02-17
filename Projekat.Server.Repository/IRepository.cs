
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> VratiSve(T obj);
        List<T> VratiSveJoin(params T[] obj);
        List<T> Pretrazi(string kriterijum, T obj);
        List<T> PretraziJoin(string kriterijum, params T[] obj);
        int SacuvajIVratiId(T obj);
        void Sacuvaj(T obj);
        void Izmeni(T obj);
        void Obrisi(T obj);
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
        void ZapocniTransakciju();
        void PotvrdiTransakciju();
        void PonistiTransakciju();

    }
}
