namespace EmployeeManagement
{
    public partial class frmEmployeeManagement : Form
    {
        private readonly int UCN_INDEX = 0;
        private readonly string UCN_PLACEHOLDER = "ЕГН:";

        private EmployeeManager employeeManager;
        public frmEmployeeManagement(EmployeeManager employeeManager)
        {
            InitializeComponent();

            this.employeeManager = employeeManager;

            SetEmployeesDataSource();
        }

        private void picAddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDataForm employeeDataForm = new();

            if (employeeDataForm.ShowDialog() == DialogResult.OK)
            {
                if (!TryParseSalary(employeeDataForm.txtSalary.Text, out decimal employeeSalary))
                {
                    return;
                }

                if (!ValidateInput(employeeDataForm))
                {
                    MessageBox.Show("Въведени са невалидни данни за служителя.");
                    return;
                }

                string ucn = employeeDataForm.txtEmployeeUcn.Text;

                if (employeeManager.HasEmployee(ucn))
                {
                    MessageBox.Show("Служителят вече съществува.");
                    return;
                }

                Employee employee = new(
                    ucn,
                    employeeDataForm.txtEmployeeFirstName.Text,
                    employeeDataForm.txtEmployeeMiddleName.Text,
                    employeeDataForm.txtEmployeeLastName.Text,
                    employeeDataForm.cboProfession.Text,
                    employeeDataForm.cboDepartment.Text,
                    employeeSalary,
                    DateTime.Parse(employeeDataForm.dtpEmployeeStartDate.Text));

                employeeManager.AddEmployee(employee);

                SetEmployeesDataSource();
            }
        }
        private void picModifyEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployeesData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvEmployeesData.SelectedRows[0];

                string ucn = ExtractUcn(selectedRow);
                Employee? targetEmployee = employeeManager.GetEmployee(ucn);

                if (targetEmployee != null)
                {
                    EmployeeDataForm employeeDataForm = new(targetEmployee);

                    if (employeeDataForm.ShowDialog() == DialogResult.OK)
                    {
                        if (TryParseSalary(employeeDataForm.txtSalary.Text, out decimal newSalary))
                        {
                            employeeManager.ModifyEmployee(ucn, newSalary);
                        }
                    }

                    SetEmployeesDataSource();
                }
            }
        }


        private void picRemoveEmployee_Click(object sender, EventArgs e)
        {
            for (int i = dgvEmployeesData.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow selectedRow = dgvEmployeesData.SelectedRows[i];

                string ucn = ExtractUcn(selectedRow);

                employeeManager.RemoveEmployee(ucn);
            }

            SetEmployeesDataSource();
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            AuthorInfoAboutBox aboutBox = new();
            aboutBox.ShowDialog();
        }

        private string ExtractUcn(DataGridViewRow selectedRow)
        {
            return selectedRow.Cells[UCN_INDEX].Value?.ToString() ?? "";
        }
        private bool ValidateInput(EmployeeDataForm employeeDataForm)
        {
            List<TextBox> requiredData =
            [
                employeeDataForm.txtEmployeeUcn,
                employeeDataForm.txtEmployeeFirstName,
                employeeDataForm.txtEmployeeLastName,
                employeeDataForm.txtSalary
            ];

            return requiredData.All(textBox => !string.IsNullOrWhiteSpace(textBox.Text));
        }

        private void SetEmployeesDataSource()
        {
            dgvEmployeesData.DataSource = employeeManager.GetEmployees();
        }
        private static bool TryParseSalary(string input, out decimal result)
        {
            if (decimal.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Невалидна заплата.");
                return false;
            }
        }

        private void txtSearchUcn_Enter(object sender, EventArgs e)
        {
            if (UCN_PLACEHOLDER.Equals(txtSearchUcn.Text.Trim()))
            {
                txtSearchUcn.Text = "";
                txtSearchUcn.ForeColor = Color.Black;
            }
        }

        private void txtSearchUcn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchUcn.Text))
            {
                txtSearchUcn.Text = UCN_PLACEHOLDER;
                txtSearchUcn.ForeColor = Color.Gray;
            }
        }

        private void txtSearchUcn_TextChanged(object sender, EventArgs e)
        {
            string targetUcn = txtSearchUcn.Text.Trim();

            if (UCN_PLACEHOLDER.Equals(targetUcn))
            {
                SetEmployeesDataSource();
            }
            else
            {
                List<Employee> filteredEmployees = FilterEmployees(targetUcn);

                dgvEmployeesData.DataSource = filteredEmployees;
            }
        }

        private List<Employee> FilterEmployees(string targetUcn)
        {
            return employeeManager.GetEmployees()
                .Where(employee => employee.Ucn.Contains(targetUcn, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
