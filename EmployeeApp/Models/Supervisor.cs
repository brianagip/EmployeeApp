using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.Models
{
    [NotMapped]
    public class Supervisor : Employee
    {
        public decimal AnnualSalary { get; set; }
    }
}
