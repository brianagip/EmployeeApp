using EmployeeApp.Data;
using EmployeeApp.Interfaces;
using EmployeeApp.Models;

namespace EmployeeApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Employee> GetEmployees() 
        { 
            return _context.Employee.OrderBy(e => e.EmployeeId).ToList();
        }

        public bool CreateEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
