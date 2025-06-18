namespace PayrollSystem
{
    public class PayrollCalculator
    {
        public decimal CalculateNetSalary(Employee emp)
        {
            // Calculate base salary
            decimal baseSalary = emp.DailyRate * emp.WorkingDays;
            // Calculate overtime pay (assuming 8 hours per workday)
            decimal overtimePay = emp.Overtime * (emp.DailyRate / 8);
            // Calculate net salary
            decimal netSalary = baseSalary + overtimePay - emp.Deductions;
            return netSalary;
        }
    }
}
