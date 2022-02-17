using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public class StornirajMagacinskiDokumentSO : OpstaSistemskaOperacija
    {
        protected override void IzvrsiOperaciju(IDomainObject obj)
        {
            Dokument dokument = (Dokument)obj;
            dokument.WhereCondition = $"MagacinskiDokumentId={dokument.DokumentId}";
            repository.Obrisi(dokument);
        }
    }
}
