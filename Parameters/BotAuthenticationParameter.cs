using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Parameters
{
    public class BotAuthenticationParameter
    {
        [StoredProcAttributes.Name("@loginID")]
        [StoredProcAttributes.ParameterType(System.Data.SqlDbType.VarChar)]
        public string loginID { get; set; }

        [StoredProcAttributes.Name("@password")]
        [StoredProcAttributes.ParameterType(System.Data.SqlDbType.VarChar)]
        public string password { get; set; }
    }
}
