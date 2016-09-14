using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreationManager
{
    class ConcreteFactory:Factory
    {
        public ConcreteProduct cp;
        public ConcreteFactory()
        {

        }
        public override Product factoryMethod(String projectName, String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp)
        {
            return cp = new ConcreteProduct(projectName, projectType, ide, browser, ftpClient, shellInterface, githubDesktop, mySQLServer, xampp);
        }
    }
}
