namespace EmployeeManagement
{
    public class Employee
    {
        public string Ucn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string ucn,
            string firstName, string middleName, string lastName,
            string profession, string department,
            decimal salary,
            DateTime startDate)
        {
            Ucn = ucn;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Profession = profession;
            Department = department;
            Salary = salary;
            this.StartDate = startDate;
        }

        public override string ToString()
        {
            return $"Employee: {FirstName} {LastName} from {Department}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee otherEmployee = (Employee)obj;
            return Ucn != null && Ucn.Equals(otherEmployee.Ucn, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Ucn.GetHashCode();
        }
    }
}
