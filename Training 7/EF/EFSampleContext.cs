using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Globant.Java2Net.Demos.App.EF
{
    public class EFSampleContext : System.Data.Entity.DbContext
    {
        public EFSampleContext(string connectionString)
        {
            Database.SetInitializer<EFSampleContext>(new DropCreateDatabaseAlways<EFSampleContext>());
            this.Database.Connection.ConnectionString = connectionString;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
