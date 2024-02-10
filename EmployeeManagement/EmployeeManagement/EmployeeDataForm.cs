namespace EmployeeManagement
{
    public partial class EmployeeDataForm : Form
    {

        private Dictionary<string, List<string>> departmentRoles;
        public EmployeeDataForm()
        {
            InitializeComponent();

            departmentRoles = new Dictionary<string, List<string>>
            {
                { "Финансов отдел", new List<string> { "Финансов анализатор", "Инвестиционен анализатор", "Счетоводител" } },

                { "Продажби и маркетинг", new List<string> { "Ръководител продажби", "Търговски представител" } },

                { "Клиентско обслужване", new List<string> { "Консултант" } }
            };

            cboDepartment.DataSource = departmentRoles.Keys.ToList();
        }

        public EmployeeDataForm(Employee employee) : this()
        {
            txtEmployeeUcn.Text = employee.Ucn;
            txtEmployeeFirstName.Text = employee.FirstName;
            txtEmployeeMiddleName.Text = employee.MiddleName;
            txtEmployeeLastName.Text = employee.LastName;
            cboProfession.Text = employee.Profession;
            cboDepartment.Text = employee.Department;
            txtSalary.Text = employee.Salary.ToString();
            dtpEmployeeStartDate.Value = employee.StartDate;
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = cboDepartment.SelectedItem?.ToString() ?? "";


            if (departmentRoles.TryGetValue(selectedDepartment, out List<string>? roles))
            {
                cboProfession.DataSource = roles.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
