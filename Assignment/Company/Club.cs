using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Company
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee E)
        {
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;
        }

        private void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            Employee employee = sender as Employee;
            if (e.Cause == LayOffCause.VacationStockBelowZero)
            {
                Members.Remove(employee);
            }
        }
    }
}
