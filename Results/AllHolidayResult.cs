﻿using CodeFirstStoredProcs;
using System;

namespace Cygnet.Projman.EFData.StoredProcedure.Results
{
    public class AllHolidayResult
    {

        [StoredProcAttributes.Name("HolidayName")]
        public string HolidayName { get; set; }

        [StoredProcAttributes.Name("ObservingDate")]
        public DateTime ObservingDate { get; set; }
    }
}
