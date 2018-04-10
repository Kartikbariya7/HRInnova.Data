using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Results
{
   public class BotAuthenticationResults
    {
        [StoredProcAttributes.Name("loginID")]
        public string loginID { get; set; }

        [StoredProcAttributes.Name("password")]
        public string password { get; set; }
        [StoredProcAttributes.Name("empID")]
        public int empID { get; set; }

    }
}
