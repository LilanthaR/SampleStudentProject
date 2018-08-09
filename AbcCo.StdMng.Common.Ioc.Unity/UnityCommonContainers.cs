using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Unity;

namespace AbcCo.StdMng.Common.Ioc.Unity
{
    public class UnityCommonContainers
    {

        public UnityContainer GetUnityContainer()
        {

            var container = new UnityContainer();
            //container.RegisterType<IStudentManager, StudentManager>();
            //container.RegisterType<IStudentRepository, StudentRepository>();
            //container.RegisterType<ILogger, Logger>();

            return container;
        }

        public UnityContainer GetLiveUnityContainer()
        {

            var container = new UnityContainer();
            //container.RegisterType<IStudentManager, StudentManager>();
            //container.RegisterType<IStudentRepository, StudentRepository>();
            //container.RegisterType<ILogger, Logger>();

            return container;
        }

        public UnityContainer GetTestUnityContainer()
        {

            var container = new UnityContainer();
            //container.RegisterType<IStudentManager, StudentManager>();
            //container.RegisterType<IStudentRepository, StudentRepository>();
            //container.RegisterType<ILogger, LoggerTest>();

            return container;
        }
    }
}
