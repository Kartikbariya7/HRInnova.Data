using System.Data.Entity;
using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;

namespace HRInnova.Data.Context
{
    public class OptionalHolidaysListContext : DbContext
    {
        [StoredProcAttributes.Name("Holidays_Optional")]
        [StoredProcAttributes.ReturnTypes(typeof(OptionalHolidayResult))]
        public StoredProc<OptionalHolidaysListParameter> OptionalHolidayList { get; set; }
        public OptionalHolidaysListContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
