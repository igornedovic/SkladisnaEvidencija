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
        public List<Dokument> Rezultat { get; private set; }
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Dokument dokumentZaPretragu = (Dokument)obj;
            dokumentZaPretragu.WhereCondition = $"NazivMagacinskogDokumenta={(int)dokumentZaPretragu.NazivDokumenta} AND Datum='{dokumentZaPretragu.Datum}'";
            List<Dokument>  dokumenti = repository.Pretrazi(dokumentZaPretragu.WhereCondition, dokumentZaPretragu).OfType<Dokument>().ToList();

            foreach (Dokument dok in dokumenti)
            {
                dok.WhereCondition = $"PartnerId={dok.PoslovniPartner.PartnerId}";
                List<PoslovniPartner> pl = repository.PretraziJoin(dok.WhereCondition, new PravnoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList();

                if (pl.Count > 0)
                {
                    dok.PoslovniPartner = pl.First();
                }
                else
                {
                    dok.PoslovniPartner = (repository.PretraziJoin(dok.WhereCondition, new FizickoLice(), new PoslovniPartner()).OfType<PoslovniPartner>().ToList()).First();

                }
            }

            Rezultat = dokumenti;
        }
    }
}
