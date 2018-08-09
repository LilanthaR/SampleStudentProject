using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.Repositories.DB.EF
{
    public class StudentRepository : Repository<Student>, IStudentRepository

    {

        public StudentRepository(IStdMgtDbContext context, IAppSettings appSettings, ILogger loggerr) : base( context,  appSettings,  logger)
        {

        }
        public bool CreateXYZ(Student obj)
        {
            throw new NotImplementedException();
        }

    }
}
