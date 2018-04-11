using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using HRInnova.Data.Context;
using HRInnova.Data.Parameters;
using HRInnova.Data.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Repository
{
    public class DimattendancemonthlyRepository
    {
        public DimattendancemonthlyResult GetMonthlyAttendanceDetails(int empId)
        {
            using (DimattendancemonthlyContext ctx = new DimattendancemonthlyContext())
            {
                string result = string.Empty;

                DimattendancemonthlyParameter parameter = new DimattendancemonthlyParameter()
                {
                    empID = empId,
                };

                var objResult = ctx.dimattendancemonthly.CallStoredProc(parameter);

                var lstReportData = objResult.ToList<DimattendancemonthlyResult>();

                var reportData = new DimattendancemonthlyResult();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.FirstOrDefault();
                }

                return reportData;
            }
        }
    }
}
