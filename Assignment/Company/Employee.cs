using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Company
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
            set
            {
                vacationStock = value;
                if (vacationStock < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.VacationStockBelowZero));
                }
            }
        }

        public bool RequestVacation(DateTime From, DateTime To)
        {
             
            int requestedDays = (To - From).Days + 1;
            if (VacationStock >= requestedDays)
            {
                VacationStock -= requestedDays;
                return true;
            }
            return false;
        }

        public void EndOfYearOperation()
        {
            if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayOffCause.AgeAboveLimit));
            }
        }
    }
}
