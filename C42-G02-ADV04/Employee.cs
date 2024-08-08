using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static C42_G02_ADV04.Program;

namespace C42_G02_ADV04
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        { 
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }
        public bool RequestVacation(DateTime from, DateTime to)
        {
            int requestedDays = (to - from).Days;
            if (requestedDays <= vacationStock)
            {
                vacationStock -= requestedDays;
                return true;
            }
            return false;
        }
        public void EndOfYearOperation()
        {
            
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.VacationStockNegative));
            }
            else if (GetAge() > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.AgeAboveSixty));
            }
        }
        private int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
                age--;
            return age;
        }
    }
}
