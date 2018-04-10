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
    public class Profile_Prob_JoinRepository
    {
        public Profile_Prob_JoinResult GetProfileDetails(int empId)
        {
            using (Profile_Prob_JoinContext ctx = new Profile_Prob_JoinContext())
            {
                string result = string.Empty;

                Profile_Prob_JoinParameter parameter = new Profile_Prob_JoinParameter()
                {
                    empID = empId,
                };

                var objResult = ctx.profile_Prob_Join.CallStoredProc(parameter);

                var lstReportData = objResult.ToList<Profile_Prob_JoinResult>();

                var reportData = new Profile_Prob_JoinResult();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.FirstOrDefault();
                }

                return reportData;
            }
        }
    }
}
