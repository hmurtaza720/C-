namespace EMS_API_Murtaza.DTOs
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public decimal BaseSalary { get; set; }
        public bool IsActive { get; set; }
    }
}
