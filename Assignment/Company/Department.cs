using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Company
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }

        private void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (e.Cause == LayOffCause.AgeAboveLimit || e.Cause == LayOffCause.VacationStockBelowZero)
            {
                Staff.Remove(employee);
            }
        }
    }
}
