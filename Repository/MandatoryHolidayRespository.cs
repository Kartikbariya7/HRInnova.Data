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
    public class MandatoryHolidayRepository
    {
        public static List<MandatoryHolidayResult> GetMandatoryHolidayListDetails(int empId)
        {
            using (MandatoryHolidaysListContext ctx = new MandatoryHolidaysListContext())
            {
                string result = string.Empty;

                MandatoryHolidaysListParameter parameter = new MandatoryHolidaysListParameter()
                {
                    EmployeeID = empId,
                };

                var objResultSet = ctx.MandatoryHolidayList.CallStoredProc();

                var lstReportData = objResultSet.ToList<MandatoryHolidayResult>();

                var reportData = new List<MandatoryHolidayResult>();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.ToList();
                }

                return reportData;
            }
        }
    }
}
