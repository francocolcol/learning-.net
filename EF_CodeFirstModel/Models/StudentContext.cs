
using System.Data.Entity;

namespace EF_CodeFirstModel.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDatabase")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}