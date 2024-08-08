namespace C42_G02_ADV04
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            #region 1
            Employee emp = new Employee
            {
                EmployeeID = 1,
                BirthDate = new DateTime(1955, 5, 15), 
                VacationStock = -5
            };

            emp.EmployeeLayOff += (sender, e) =>
            {
                Console.WriteLine($"Employee laid off due to: {e.Cause}");
            };

            emp.EndOfYearOperation();
            #endregion
            Console.WriteLine("=====================");
            #region 2
            Department dept = new Department { DeptID = 1, DeptName = "HR" };
            Employee emp1= new Employee { EmployeeID = 1, BirthDate = new DateTime(1955, 5, 15), VacationStock = 5 };
            Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1970, 7, 25), VacationStock = -5 };
            dept.AddStaff(emp1);
            dept.AddStaff(emp2);
            emp1.EndOfYearOperation();
            emp2.EndOfYearOperation();
            #endregion
            Console.WriteLine("=====================");
            #region 3
            Club club = new Club { ClubID = 1, ClubName = "Chess Club" };

            Employee emp3 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1955, 5, 15), VacationStock = 5 };
            Employee emp4 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1970, 7, 20), VacationStock = -5 };
            club.AddMember(emp3);
            club.AddMember(emp4);
            emp3.EndOfYearOperation();
            emp4.EndOfYearOperation();
            #endregion
        }
    }
}

