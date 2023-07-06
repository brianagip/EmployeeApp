using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApp.Models
{
    [NotMapped]
    public class Manager : Employee
    {
        public decimal AnnualSalary { get; set; }
        public decimal MaxExpenseAmount { get; set; }
    }
}
