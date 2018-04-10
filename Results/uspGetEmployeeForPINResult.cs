using CodeFirstStoredProcs;
using System;

namespace Cygnet.Projman.EFData.StoredProcedure.Results
{
    public class uspGetEmployeeForPINResult
    {

        [StoredProcAttributes.Name("empID")]
        public int EmpID { get; set; }

        [StoredProcAttributes.Name("EmployeeName")]
        public string EmployeeName { get; set; }
        [StoredProcAttributes.Name("Email")]
        public string Email { get; set; }

    }

}
