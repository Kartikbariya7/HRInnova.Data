using CodeFirstStoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRInnova.Data.Results
{
    public class DimattendancemonthlyResult
    {
        [StoredProcAttributes.Name("EmpID")]
        public int EmpID { get; set; }
        [StoredProcAttributes.Name("PayrollMonth")]
        public string PayrollMonth { get; set; }
        [StoredProcAttributes.Name("CalenderDays")]
        public int CalenderDays { get; set; }
        [StoredProcAttributes.Name("WorkingDays")]
        public int WorkingDays { get; set; }
        [StoredProcAttributes.Name("FullDay")]
        public int FullDay { get; set; }
        [StoredProcAttributes.Name("HalfDay")]
        public int HalfDay { get; set; }
        [StoredProcAttributes.Name("Absent")]
        public decimal Absent { get; set; }
        [StoredProcAttributes.Name("LeavesFullDay")]
        public int LeavesFullDay { get; set; }
        [StoredProcAttributes.Name("LeavesHalfDay")]
        public decimal LeavesHalfDay { get; set; }
        [StoredProcAttributes.Name("SandwichLeave")]
        public int SandwichLeave { get; set; }
        [StoredProcAttributes.Name("TotalGrossHours")]
        public string TotalGrossHours { get; set; }
        [StoredProcAttributes.Name("TotalNetHours")]
        public string TotalNetHours { get; set; }
        [StoredProcAttributes.Name("TotalTimesheetHours")]
        public string TotalTimesheetHours { get; set; }
        [StoredProcAttributes.Name("TotalWOHHours")]
        public string TotalWOHHours { get; set; }
        [StoredProcAttributes.Name("TotalBreakHours")]
        public string TotalBreakHours { get; set; }
        [StoredProcAttributes.Name("AvgGrossHours")]
        public string AvgGrossHours { get; set; }
        [StoredProcAttributes.Name("AvgNetHours")]
        public string AvgNetHours { get; set; }
        [StoredProcAttributes.Name("AvgTimesheetHours")]
        public string AvgTimesheetHours { get; set; }
        [StoredProcAttributes.Name("PenaltyCount")]
        public int PenaltyCount { get; set; }
        [StoredProcAttributes.Name("LateComing")]
        public decimal LateComing { get; set; }
        [StoredProcAttributes.Name("EarlyLeaving")]
        public decimal EarlyLeaving { get; set; }
        [StoredProcAttributes.Name("MissPunch")]
        public int MissPunch { get; set; }

        [StoredProcAttributes.Name("WFHRequest")]
        public int WFHRequest { get; set; }
        [StoredProcAttributes.Name("WOHRequest")]
        public int WOHRequest { get; set; }
        [StoredProcAttributes.Name("TOURRequest")]
        public int TOURRequest { get; set; }
        [StoredProcAttributes.Name("LOPRequest")]
        public decimal LOPRequest { get; set; }
        [StoredProcAttributes.Name("LOP_Absent")]
        public decimal LOP_Absent { get; set; }
        [StoredProcAttributes.Name("LOPPenalty")]
        public decimal LOPPenalty { get; set; }
        [StoredProcAttributes.Name("WOHTimeSheetHrs")]
        public decimal WOHTimeSheetHrs { get; set; }
        [StoredProcAttributes.Name("WeekOff")]
        public decimal WeekOff { get; set; }
        [StoredProcAttributes.Name("PresentDays")]
        public decimal PresentDays { get; set; }



    }
}
