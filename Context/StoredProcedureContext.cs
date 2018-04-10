using System.Data.Entity;
using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;

namespace HRInnova.Data.Context
{
    public class StoredProcedureContext : DbContext
    {
        [StoredProcAttributes.Name("uspGetEmployeeForPIN")]
        [StoredProcAttributes.ReturnTypes(typeof(uspGetEmployeeForPINResult))]
        public StoredProc<UspGetEmployeeForPINParameter> uspGetEmployeeForPIN { get; set; }
        public StoredProcedureContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
