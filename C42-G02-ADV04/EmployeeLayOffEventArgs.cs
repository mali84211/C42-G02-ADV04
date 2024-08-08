using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C42_G02_ADV04.Program;

namespace C42_G02_ADV04
{
    public enum LayOffCause
    {
        VacationStockNegative,
        AgeAboveSixty,
        FailedToAchieveSalesTarget,
        Resigned
    }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }

        public EmployeeLayOffEventArgs(LayOffCause cause)
        {
            Cause = cause;
        }
    }
}
