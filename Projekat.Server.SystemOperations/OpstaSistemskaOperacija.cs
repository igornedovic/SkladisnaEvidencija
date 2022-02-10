using Projekat.Common.Domain;
using Projekat.Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Server.SystemOperations
{
    public abstract class OpstaSistemskaOperacija
    {
        protected IRepository<IDomainObject> repository = new GenericDbRepository();

        public void ExecuteTemplate()
        {
            try
            {
                repository.OtvoriKonekciju();
                repository.ZapocniTransakciju();
                Execute();
                repository.PotvrdiTransakciju();
            }
            catch (Exception ex)
            {
                repository.PonistiTransakciju();
                throw ex;
            }
            finally
            {
                repository.ZatvoriKonekciju();
            }
        }

        protected abstract void Execute();
    }
}
