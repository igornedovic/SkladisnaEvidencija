using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class PretraziMagacinskeDokumenteSO : OpstaSistemskaOperacija
    {
        private readonly Dokument dokumentZaPretragu;

        public PretraziMagacinskeDokumenteSO(Dokument dokumentZaPretragu)
        {
            this.dokumentZaPretragu = dokumentZaPretragu;
        }

        public List<Dokument> Dokumenti { get; private set; }
        public List<Dokument> Rezultat { get; private set; }
        protected override void Execute()
        {
            dokumentZaPretragu.Criteria = $"NazivMagacinskogDokumenta={(int)dokumentZaPretragu.NazivDokumenta} AND Datum='{dokumentZaPretragu.Datum}'";  
            Dokumenti = repository.Pretrazi(dokumentZaPretragu.Criteria, dokumentZaPretragu).OfType<Dokument>().ToList();

            foreach (Dokument dok in Dokumenti)
            {
                dok.Criteria = $"PartnerId={dok.PoslovniPartner.PartnerId}";
                List<PoslovniPartner> pl = repository.PretraziJoin(dok.Criteria, new PravnoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();

                if (pl.Count > 0)
                {
                    dok.PoslovniPartner = (repository.PretraziJoin(dok.Criteria, new PravnoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList())[0];

                }
                else
                {
                    dok.PoslovniPartner = (repository.PretraziJoin(dok.Criteria, new FizickoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList())[0];

                }
            }

            Rezultat = Dokumenti;
        }
    }
}
