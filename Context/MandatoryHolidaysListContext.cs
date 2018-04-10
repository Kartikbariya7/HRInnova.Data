using System.Data.Entity;
using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;

namespace HRInnova.Data.Context
{
    public class MandatoryHolidaysListContext : DbContext
    {
        [StoredProcAttributes.Name("Holidays_Mandatory")]
        [StoredProcAttributes.ReturnTypes(typeof(MandatoryHolidayResult))]
        public StoredProc<MandatoryHolidaysListParameter> MandatoryHolidayList { get; set; }
        public MandatoryHolidaysListContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
