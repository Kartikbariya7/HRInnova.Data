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
    public class StoredProcedureRepository
    {
        public  uspGetEmployeeForPINResult GetEmployeeDetails(int empId)
        {
            using (StoredProcedureContext ctx = new StoredProcedureContext())
            {
                string result = string.Empty;

                UspGetEmployeeForPINParameter parameter = new UspGetEmployeeForPINParameter()
                {
                    EmployeeID = empId,
                };

                var objResultSet = ctx.uspGetEmployeeForPIN.CallStoredProc(parameter);

                var lstReportData = objResultSet.ToList<uspGetEmployeeForPINResult>();

                var reportData = new uspGetEmployeeForPINResult();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.FirstOrDefault();
                }

                return reportData;
            }
        }
    }
}
