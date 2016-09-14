using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreationManager
{
    abstract class Factory
    {
        public abstract Product factoryMethod(String projectName, String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp);

        public void doSomething(String projectName, String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp)
        {
            Product product = factoryMethod(projectName,  projectType,  ide,  browser,  ftpClient,  shellInterface,  githubDesktop,  mySQLServer,  xampp);
        }
    }
}
