using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreationManager
{
    class ConcreteProduct:Product
    {
        public Product project;
        public ConcreteProduct(String projectName, String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp)
        {
            project = new Product(projectName, projectType, ide, browser, ftpClient, shellInterface, githubDesktop, mySQLServer, xampp);
            project.Visible = true;
        }
    }
}
