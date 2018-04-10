using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Results
{
   public class Profile_Prob_JoinResult
    {
       
        [StoredProcAttributes.Name("ProbationPeriod")]
        public int ProbationPeriod { get; set; }
        [StoredProcAttributes.Name("joinDate")]
        public DateTime joinDate { get; set; }
        [StoredProcAttributes.Name("Experience")]
        public int Experience { get; set; }
        [StoredProcAttributes.Name("empCode")]
        public string empCode { get; set; }
        [StoredProcAttributes.Name("bloodGroup")]
        public string bloodGroup { get; set; }
        [StoredProcAttributes.Name("passportNumber")]
        public string passportNumber{ get; set; }
        [StoredProcAttributes.Name("incrementperiod")]
        public int incrementperiod { get; set; }
        [StoredProcAttributes.Name("DepartmentID")]
        public int DepartmentID { get; set; }
        [StoredProcAttributes.Name("BankName")]
        public string BankName { get; set; }

    }
}
