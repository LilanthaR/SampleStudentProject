using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.Repositories.DB.EF
{
    public class StdMgtDbContext : DbContext, IStdMgtDbContext
    {
        public StdMgtDbContext() : base("LocalDBConnectionString")
        {

        }

        public StdMgtDbContext(IAppSettings appSettings) : base(appSettings.DbConnectionName) //base("StudentMgtConnectionString")
        {

        }

        public DbSet<Studnt> Student { get; set; }
        //DbSet<Teacher> Teacher { get; set; }
        //DbSet<Course> Course { get; set; }
        //DbSet<Subject> Subject { get; set; }
        //DbSet<Enrollment> Enrollment { get; set; }
        public DbContext GetDatabaseContext { get; set; }


    }
}
