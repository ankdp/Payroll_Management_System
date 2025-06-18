using System.Collections.Generic;

namespace PayrollSystem
{
    public class EmployeeDatabase
    {
        // List to store employees
        public List<Employee> Employees { get; set; }

        public EmployeeDatabase()
        {
            Employees = new List<Employee>();
        }

        // Add a new employee
        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        // Find an employee by ID
        public Employee GetEmployee(int id)
        {
            return Employees.Find(e => e.EmployeeId == id);
        }
    }
}
