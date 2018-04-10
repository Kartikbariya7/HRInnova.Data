using CodeFirstStoredProcs;
using Cygnet.Projman.EFData.StoredProcedure.Parameters;
using HRInnova.Data.Parameters;
using HRInnova.Data.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Context
{
    public class Profile_Prob_JoinContext :DbContext
    {
        [StoredProcAttributes.Name("Profile_Probation_Period_Join_Date")]
        [StoredProcAttributes.ReturnTypes(typeof(Profile_Prob_JoinResult))]
        public StoredProc<Profile_Prob_JoinParameter> profile_Prob_Join { get; set; }
        public Profile_Prob_JoinContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
