using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class UnesiMagacinskiDokumentSO : OpstaSistemskaOperacija
    {
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Dokument dokument = (Dokument)obj;
            int dokumentId = repository.SacuvajIVratiId(dokument);

            foreach (StavkaDokumenta stavka in dokument.StavkeDokumenta)
            {
                stavka.DokumentId = dokumentId;
                repository.Sacuvaj(stavka);
            }
        }
    }
}
