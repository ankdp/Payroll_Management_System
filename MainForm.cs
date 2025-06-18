using System;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class MainForm : Form
    {
        private EmployeeDatabase db = new EmployeeDatabase();
        private PayrollCalculator calculator = new PayrollCalculator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Read details from text boxes
            Employee emp = new Employee
            {
                EmployeeId = int.Parse(txtId.Text),
                Name = txtName.Text,
                DailyRate = decimal.Parse(txtDailyRate.Text),
                WorkingDays = int.Parse(txtWorkingDays.Text),
                Overtime = decimal.Parse(txtOvertime.Text),
                Deductions = decimal.Parse(txtDeductions.Text)
            };
            db.AddEmployee(emp);
            MessageBox.Show("Employee added!");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            Employee emp = db.GetEmployee(id);
            if (emp != null)
            {
                decimal netSalary = calculator.CalculateNetSalary(emp);
                MessageBox.Show($"Net Salary for {emp.Name}: {netSalary:C}");
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }
        }
    }
}
