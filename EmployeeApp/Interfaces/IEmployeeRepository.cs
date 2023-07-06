using EmployeeApp.Models;

namespace EmployeeApp.Interfaces
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
        bool CreateEmployee(Employee employee);
        bool Save();
    }
}
