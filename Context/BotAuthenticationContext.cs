using CodeFirstStoredProcs;
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
    public class BotAuthenticationContext : DbContext
    {
        [StoredProcAttributes.Name("BotAuthentication")]
        [StoredProcAttributes.ReturnTypes(typeof(BotAuthenticationResults))]
        public StoredProc<BotAuthenticationParameter> botAuthentication { get; set; }
        public BotAuthenticationContext()
            : base("Name=Context")
        {
            this.InitializeStoredProcs();
        }
    }
}
