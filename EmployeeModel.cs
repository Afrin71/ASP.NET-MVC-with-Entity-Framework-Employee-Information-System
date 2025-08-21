namespace ModelViewController.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int EmpSalary { get; set; }

        public string Designation { get; set; }
    }

}
