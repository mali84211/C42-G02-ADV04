using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            if (!Members.Contains(E))
            {
                Members.Add(E);
                E.EmployeeLayOff += RemoveMember;
            }
        }
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (employee != null && Members.Contains(employee))
            {
                if (e.Cause == LayOffCause.VacationStockNegative)
                {
                    Members.Remove(employee);
                    Console.WriteLine($"Employee {employee.EmployeeID} removed from {ClubName} due to: {e.Cause}");
                }
            }
        }
    }
}
