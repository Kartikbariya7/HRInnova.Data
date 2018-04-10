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
    public class BotAuthenticationRepository
    {
        public BotAuthenticationResults GetLoginDetails(string loginID, string password)
        {
            using (BotAuthenticationContext ctx = new BotAuthenticationContext())
            {
                string result = string.Empty;

                BotAuthenticationParameter parameter = new BotAuthenticationParameter()
                {
                    loginID = loginID,
                    password = password,
                };

                var objResultSet = ctx.botAuthentication.CallStoredProc(parameter);

                var lstReportData = objResultSet.ToList<BotAuthenticationResults>();

                var reportData = new BotAuthenticationResults();

                if (lstReportData != null && lstReportData.Any())
                {
                    reportData = lstReportData.FirstOrDefault();
                }

                return reportData;
            }

        }
    }
}
