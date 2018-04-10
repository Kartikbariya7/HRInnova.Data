using System.Data.Entity;
using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;

namespace HRInnova.Data.Context
{
    public class AllHolidaysListContext : DbContext
    {
        [StoredProcAttributes.Name("Holidays_All")]
        [StoredProcAttributes.ReturnTypes(typeof(AllHolidayResult))]
        public StoredProc<AllHolidaysListParameter> AllHolidayList { get; set; }
        public AllHolidaysListContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
