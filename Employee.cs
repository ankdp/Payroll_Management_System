namespace PayrollSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public decimal DailyRate { get; set; }
        public int WorkingDays { get; set; }
        public decimal Overtime { get; set; }
        public decimal Deductions { get; set; }
    }
}
