using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCreationManager
{
    public partial class Product : Form
    {
        public Product()
        {

        }
        public Product(String projectName, String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp)
        {
            InitializeComponent();
            Text = projectName;
            infoBox.Items.Add(projectName);
            infoBox.Items.Add(projectType);
            infoBox.Items.Add(ide);
            infoBox.Items.Add(browser);
            infoBox.Items.Add(ftpClient);
            infoBox.Items.Add(shellInterface);
            infoBox.Items.Add(Convert.ToString(githubDesktop));
            infoBox.Items.Add(Convert.ToString(mySQLServer));
            infoBox.Items.Add(Convert.ToString(xampp));
        }

        private void infoBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
