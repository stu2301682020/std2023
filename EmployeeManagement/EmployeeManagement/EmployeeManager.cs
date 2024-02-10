namespace EmployeeManagement
{
    public class EmployeeManager
    {
        private Dictionary<string, Employee> Employees { get; set; }

        public EmployeeManager()
        {
            Employees = new Dictionary<string, Employee>();

            InitializeEmployees();
        }

        private void InitializeEmployees()
        {
            List<Employee> employees = FileManager.LoadEmployees();

            foreach (Employee employee in employees)
            {
                Employees.Add(employee.Ucn, employee);
            }
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee.Ucn, employee);
            FileManager.SaveEmployees(GetEmployees());
        }

        public void ModifyEmployee(string ucn, decimal newSalary)
        {
            Employees.TryGetValue(ucn, out Employee? targetEmployee);

            if (targetEmployee != null)
            {
                targetEmployee.Salary = newSalary;
                FileManager.SaveEmployees(GetEmployees());
            }
        }

        public void RemoveEmployee(string ucn)
        {
            Employees.Remove(ucn, out Employee? targetEmployee);

            if (targetEmployee != null)
            {
                FileManager.SaveEmployees(GetEmployees());
            }
        }

        public bool HasEmployee(string ucn)
        {
            return Employees.ContainsKey(ucn);
        }

        public Employee? GetEmployee(string ucn)
        {
            Employees.TryGetValue(ucn, out Employee? targetEmployee);

            return targetEmployee;
        }

        public List<Employee> GetEmployees()
        {
            return Employees.Values.ToList();
        }
    }
}
