using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter an employee number")]
        [RegularExpression(@"^[A-Z]{3}-[0-9]{6}$", ErrorMessage = "Employee numbers must be in the format \"12-3456-AB\" - please try again.")]
        public string? EmployeeNumber { get; set; }
        [Required(ErrorMessage = "Please enter a first name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Please enter a last name")]
        public string? LastName { get; set; }

        public string? FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
        // FK:
        public int? ProjectId { get; set; }

        // And nav prop:
        public Project? Project { get; set; }
    }
}
