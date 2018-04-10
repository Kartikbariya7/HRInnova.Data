using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.Projman.EFData.StoredProcedure.Parameters
{
    public class OptionalHolidaysListParameter
    {
        [StoredProcAttributes.Name("@EmployeeID")]
        [StoredProcAttributes.ParameterType(System.Data.SqlDbType.Int)]
        public int EmployeeID { get; set; }
    }
}
