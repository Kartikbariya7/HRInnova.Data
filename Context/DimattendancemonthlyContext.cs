using System.Data.Entity;
using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;
using HRInnova.Data.Parameters;
using HRInnova.Data.Results;

namespace HRInnova.Data.Context
{
    public class DimattendancemonthlyContext : DbContext
    {
        [StoredProcAttributes.Name("Attendance_Workweek")]
        [StoredProcAttributes.ReturnTypes(typeof(DimattendancemonthlyResult))]
        public StoredProc<DimattendancemonthlyParameter> dimattendancemonthly { get; set; }
        public DimattendancemonthlyContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
