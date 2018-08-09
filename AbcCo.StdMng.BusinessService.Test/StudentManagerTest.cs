using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcCo.StdMng.BusinessService.Test
{
    [TestClass]
    public class StudentManagerTest
    {
        IOCUnityContainers unityContainer = new IOCUnityContainers();
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void StudentAgeValidation()
        {
            var container = unityContainer.GetBusinessServiceTestUnityContainer();
            container.RegisterType<IStudentRepository, StudentRepositoryDummy>();

            IStudentManager studentManager = container.Resolve<IStudentManager>();

            Student testStudent = new Student()
            {
                FirstName = "TestName",
                DOB = DateTime.Today //.AddYears(-24)
            };

            bool result = studentManager.AddStudent(testStudent);

            Assert.IsFalse(result);

            // return true;
        }
    }
}
