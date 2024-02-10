namespace EmployeeManagement
{
    partial class EmployeeDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDataForm));
            lblEmployeeFirstName = new Label();
            txtEmployeeFirstName = new TextBox();
            txtEmployeeMiddleName = new TextBox();
            lblEmployeeMiddleName = new Label();
            txtEmployeeLastName = new TextBox();
            lblEmployeeLastName = new Label();
            txtEmployeeUcn = new TextBox();
            lblEmployeeUcn = new Label();
            cboDepartment = new ComboBox();
            cboProfession = new ComboBox();
            lblDepartment = new Label();
            lblProfession = new Label();
            dtpEmployeeStartDate = new DateTimePicker();
            lblEmployeeStartDate = new Label();
            txtSalary = new TextBox();
            lblSalary = new Label();
            btnSave = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblEmployeeFirstName
            // 
            lblEmployeeFirstName.AutoSize = true;
            lblEmployeeFirstName.Location = new Point(35, 44);
            lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            lblEmployeeFirstName.Size = new Size(47, 25);
            lblEmployeeFirstName.TabIndex = 0;
            lblEmployeeFirstName.Text = "Име";
            // 
            // txtEmployeeFirstName
            // 
            txtEmployeeFirstName.Location = new Point(35, 72);
            txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            txtEmployeeFirstName.Size = new Size(150, 31);
            txtEmployeeFirstName.TabIndex = 1;
            // 
            // txtEmployeeMiddleName
            // 
            txtEmployeeMiddleName.Location = new Point(223, 72);
            txtEmployeeMiddleName.Name = "txtEmployeeMiddleName";
            txtEmployeeMiddleName.Size = new Size(150, 31);
            txtEmployeeMiddleName.TabIndex = 3;
            // 
            // lblEmployeeMiddleName
            // 
            lblEmployeeMiddleName.AutoSize = true;
            lblEmployeeMiddleName.Location = new Point(223, 44);
            lblEmployeeMiddleName.Name = "lblEmployeeMiddleName";
            lblEmployeeMiddleName.Size = new Size(85, 25);
            lblEmployeeMiddleName.TabIndex = 2;
            lblEmployeeMiddleName.Text = "Презиме";
            // 
            // txtEmployeeLastName
            // 
            txtEmployeeLastName.Location = new Point(418, 72);
            txtEmployeeLastName.Name = "txtEmployeeLastName";
            txtEmployeeLastName.Size = new Size(150, 31);
            txtEmployeeLastName.TabIndex = 5;
            // 
            // lblEmployeeLastName
            // 
            lblEmployeeLastName.AutoSize = true;
            lblEmployeeLastName.Location = new Point(418, 44);
            lblEmployeeLastName.Name = "lblEmployeeLastName";
            lblEmployeeLastName.Size = new Size(85, 25);
            lblEmployeeLastName.TabIndex = 4;
            lblEmployeeLastName.Text = "Фамилия";
            // 
            // txtEmployeeUcn
            // 
            txtEmployeeUcn.Location = new Point(613, 72);
            txtEmployeeUcn.Name = "txtEmployeeUcn";
            txtEmployeeUcn.Size = new Size(150, 31);
            txtEmployeeUcn.TabIndex = 7;
            // 
            // lblEmployeeUcn
            // 
            lblEmployeeUcn.AutoSize = true;
            lblEmployeeUcn.Location = new Point(613, 44);
            lblEmployeeUcn.Name = "lblEmployeeUcn";
            lblEmployeeUcn.Size = new Size(42, 25);
            lblEmployeeUcn.TabIndex = 6;
            lblEmployeeUcn.Text = "ЕГН";
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(35, 153);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(338, 33);
            cboDepartment.TabIndex = 10;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // cboProfession
            // 
            cboProfession.FormattingEnabled = true;
            cboProfession.Location = new Point(418, 153);
            cboProfession.Name = "cboProfession";
            cboProfession.Size = new Size(338, 33);
            cboProfession.TabIndex = 11;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(35, 125);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(61, 25);
            lblDepartment.TabIndex = 12;
            lblDepartment.Text = "Отдел";
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Location = new Point(418, 125);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(95, 25);
            lblProfession.TabIndex = 13;
            lblProfession.Text = "Професия";
            // 
            // dtpEmployeeStartDate
            // 
            dtpEmployeeStartDate.Location = new Point(35, 246);
            dtpEmployeeStartDate.Name = "dtpEmployeeStartDate";
            dtpEmployeeStartDate.Size = new Size(338, 31);
            dtpEmployeeStartDate.TabIndex = 14;
            // 
            // lblEmployeeStartDate
            // 
            lblEmployeeStartDate.AutoSize = true;
            lblEmployeeStartDate.Location = new Point(35, 218);
            lblEmployeeStartDate.Name = "lblEmployeeStartDate";
            lblEmployeeStartDate.Size = new Size(166, 25);
            lblEmployeeStartDate.TabIndex = 15;
            lblEmployeeStartDate.Text = "Дата на посъпване";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(418, 248);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(150, 31);
            txtSalary.TabIndex = 17;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(418, 220);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(75, 25);
            lblSalary.TabIndex = 16;
            lblSalary.Text = "Заплата";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(223, 337);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 50);
            btnSave.TabIndex = 19;
            btnSave.Text = "Запази";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(418, 337);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 20;
            btnExit.Text = "Излез";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // EmployeeDataForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtSalary);
            Controls.Add(lblSalary);
            Controls.Add(lblEmployeeStartDate);
            Controls.Add(dtpEmployeeStartDate);
            Controls.Add(lblProfession);
            Controls.Add(lblDepartment);
            Controls.Add(cboProfession);
            Controls.Add(cboDepartment);
            Controls.Add(txtEmployeeUcn);
            Controls.Add(lblEmployeeUcn);
            Controls.Add(txtEmployeeLastName);
            Controls.Add(lblEmployeeLastName);
            Controls.Add(txtEmployeeMiddleName);
            Controls.Add(lblEmployeeMiddleName);
            Controls.Add(txtEmployeeFirstName);
            Controls.Add(lblEmployeeFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeDataForm";
            Text = "Данни на служителя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeFirstName;
        private Label lblEmployeeMiddleName;
        private Label lblEmployeeLastName;
        private Label lblEmployeeUcn;
        private Label lblDepartment;
        private Label lblProfession;
        private Label lblEmployeeStartDate;
        private Label lblSalary;
        public TextBox txtEmployeeFirstName;
        public TextBox txtEmployeeMiddleName;
        public TextBox txtEmployeeLastName;
        public TextBox txtEmployeeUcn;
        public ComboBox cboDepartment;
        public ComboBox cboProfession;
        public DateTimePicker dtpEmployeeStartDate;
        public TextBox txtSalary;
        public Button btnSave;
        public Button btnExit;
    }
}