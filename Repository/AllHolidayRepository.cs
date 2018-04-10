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
    public class AllHolidayRepository
    {
        public static List<AllHolidayResult> GetHolidayListDetails(int empId)
        {
            using (AllHolidaysListContext ctx = new AllHolidaysListContext())
            {
                string result = string.Empty;

                AllHolidaysListParameter parameter = new AllHolidaysListParameter()
                {
                      EmployeeID = empId,
                };

                var objResultSet = ctx.AllHolidayList.CallStoredProc();

                var lstReportData = objResultSet.ToList<AllHolidayResult>();
                var reportData = new List<AllHolidayResult>();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.ToList();
                }

                return reportData;
            }
        }
    }
}
