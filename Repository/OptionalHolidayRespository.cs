using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using Cygnet.Projman.EFData.StoredProcedure.Results;
using HRInnova.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Repository
{
    public class OptionalHolidayRepository
    {
        public static List< OptionalHolidayResult> GetOptionalHolidayListDetails(int empId)
        {
            using (OptionalHolidaysListContext ctx = new OptionalHolidaysListContext())
            {
                string result = string.Empty;

                OptionalHolidaysListParameter parameter = new OptionalHolidaysListParameter()
                {
                    EmployeeID = empId,
                };

                var objResultSet = ctx.OptionalHolidayList.CallStoredProc();

                var lstReportData = objResultSet.ToList<OptionalHolidayResult>();

                var reportData = new List<OptionalHolidayResult>();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.ToList();
                }

                return reportData;
            }
        }
    }
}
