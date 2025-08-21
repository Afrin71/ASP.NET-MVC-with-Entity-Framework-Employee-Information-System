namespace ModelViewController.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext(): base("DefaultConnection")
        {
        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
