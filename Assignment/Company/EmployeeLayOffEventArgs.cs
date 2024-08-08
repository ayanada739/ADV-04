namespace Assignment.Company
{
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }

        public EmployeeLayOffEventArgs(LayOffCause cause)
        {
            Cause = cause;
        }
    }
}
