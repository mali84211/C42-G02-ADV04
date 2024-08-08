using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            if (!Staff.Contains(E))
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
        }
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (employee != null && Staff.Contains(employee))
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from {DeptName} due to: {e.Cause}");
            }
        }
    }
}
