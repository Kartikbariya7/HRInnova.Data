﻿using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Parameters
{
  public class Profile_Prob_JoinParameter
    {
        [StoredProcAttributes.Name("id")]
        [StoredProcAttributes.ParameterType(System.Data.SqlDbType.VarChar)]
        public int empID { get; set; }
    }
}
