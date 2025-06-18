namespace PayrollSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.TextBox txtWorkingDays;
        private System.Windows.Forms.TextBox txtOvertime;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnCalculate;

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.txtWorkingDays = new System.Windows.Forms.TextBox();
            this.txtOvertime = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            // ... (set properties like Location, Size, Text, etc.)
            // Add controls to the form
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(this.txtWorkingDays);
            this.Controls.Add(this.txtOvertime);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnCalculate);

            // Set up event handlers
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
        }
    }
}
