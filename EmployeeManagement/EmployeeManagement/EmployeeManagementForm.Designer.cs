namespace EmployeeManagement
{
    partial class frmEmployeeManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManagement));
            picRemoveEmployee = new PictureBox();
            picAddEmployee = new PictureBox();
            picModifyEmployee = new PictureBox();
            pnlEmployeesData = new Panel();
            picSearchByUcn = new PictureBox();
            txtSearchUcn = new TextBox();
            picInfo = new PictureBox();
            dgvEmployeesData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picRemoveEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAddEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picModifyEmployee).BeginInit();
            pnlEmployeesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchByUcn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).BeginInit();
            SuspendLayout();
            // 
            // picRemoveEmployee
            // 
            picRemoveEmployee.Image = Properties.Resources.user_xmark_solid1;
            picRemoveEmployee.Location = new Point(191, 33);
            picRemoveEmployee.Name = "picRemoveEmployee";
            picRemoveEmployee.Size = new Size(35, 30);
            picRemoveEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picRemoveEmployee.TabIndex = 4;
            picRemoveEmployee.TabStop = false;
            picRemoveEmployee.Click += picRemoveEmployee_Click;
            // 
            // picAddEmployee
            // 
            picAddEmployee.Image = Properties.Resources.user_plus_solid1;
            picAddEmployee.Location = new Point(50, 33);
            picAddEmployee.Name = "picAddEmployee";
            picAddEmployee.Size = new Size(35, 30);
            picAddEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picAddEmployee.TabIndex = 3;
            picAddEmployee.TabStop = false;
            picAddEmployee.Click += picAddEmployee_Click;
            // 
            // picModifyEmployee
            // 
            picModifyEmployee.Image = Properties.Resources.user_pen_solid1;
            picModifyEmployee.Location = new Point(121, 33);
            picModifyEmployee.Name = "picModifyEmployee";
            picModifyEmployee.Size = new Size(35, 30);
            picModifyEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            picModifyEmployee.TabIndex = 2;
            picModifyEmployee.TabStop = false;
            picModifyEmployee.Click += picModifyEmployee_Click;
            // 
            // pnlEmployeesData
            // 
            pnlEmployeesData.Controls.Add(picSearchByUcn);
            pnlEmployeesData.Controls.Add(txtSearchUcn);
            pnlEmployeesData.Controls.Add(picInfo);
            pnlEmployeesData.Controls.Add(picRemoveEmployee);
            pnlEmployeesData.Controls.Add(dgvEmployeesData);
            pnlEmployeesData.Controls.Add(picAddEmployee);
            pnlEmployeesData.Controls.Add(picModifyEmployee);
            pnlEmployeesData.Dock = DockStyle.Fill;
            pnlEmployeesData.Location = new Point(0, 0);
            pnlEmployeesData.Name = "pnlEmployeesData";
            pnlEmployeesData.Size = new Size(1002, 520);
            pnlEmployeesData.TabIndex = 1;
            // 
            // picSearchByUcn
            // 
            picSearchByUcn.Image = Properties.Resources.search2;
            picSearchByUcn.Location = new Point(311, 33);
            picSearchByUcn.Name = "picSearchByUcn";
            picSearchByUcn.Size = new Size(35, 30);
            picSearchByUcn.SizeMode = PictureBoxSizeMode.StretchImage;
            picSearchByUcn.TabIndex = 7;
            picSearchByUcn.TabStop = false;
            // 
            // txtSearchUcn
            // 
            txtSearchUcn.ForeColor = Color.Gray;
            txtSearchUcn.Location = new Point(352, 32);
            txtSearchUcn.Name = "txtSearchUcn";
            txtSearchUcn.Size = new Size(150, 31);
            txtSearchUcn.TabIndex = 6;
            txtSearchUcn.Text = "ЕГН:";
            txtSearchUcn.TextChanged += txtSearchUcn_TextChanged;
            txtSearchUcn.Enter += txtSearchUcn_Enter;
            txtSearchUcn.Leave += txtSearchUcn_Leave;
            // 
            // picInfo
            // 
            picInfo.Image = Properties.Resources.info_11;
            picInfo.Location = new Point(917, 33);
            picInfo.Name = "picInfo";
            picInfo.Size = new Size(35, 30);
            picInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            picInfo.TabIndex = 5;
            picInfo.TabStop = false;
            picInfo.Click += picInfo_Click;
            // 
            // dgvEmployeesData
            // 
            dgvEmployeesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeesData.Location = new Point(38, 78);
            dgvEmployeesData.Name = "dgvEmployeesData";
            dgvEmployeesData.RowHeadersWidth = 62;
            dgvEmployeesData.Size = new Size(923, 393);
            dgvEmployeesData.TabIndex = 0;
            // 
            // frmEmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 520);
            Controls.Add(pnlEmployeesData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmEmployeeManagement";
            Text = "Мениджър на служители";
            ((System.ComponentModel.ISupportInitialize)picRemoveEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAddEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)picModifyEmployee).EndInit();
            pnlEmployeesData.ResumeLayout(false);
            pnlEmployeesData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSearchByUcn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlEmployeesData;
        private DataGridView dgvEmployeesData;
        private PictureBox picModifyEmployee;
        private PictureBox picRemoveEmployee;
        private PictureBox picAddEmployee;
        private PictureBox picInfo;
        private TextBox txtSearchUcn;
        private PictureBox picSearchByUcn;
    }
}
