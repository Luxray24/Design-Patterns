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
    public partial class pcmForm : Form
    {
        List<Facade> facade = new List<Facade>();
        List<Form> openForms = new List<Form>();
        ConcreteFactory fmp = new ConcreteFactory();
        String projectName = "";
        String projectType = "C#";
        String ide = "Visual Studio";
        String browser = "null";
        String ftpClient = "null";
        String shellInterface = "null";
        Boolean githubDesktop = true;
        Boolean mySQLServer = false;
        Boolean xampp = false;
        public pcmForm()
        {
            InitializeComponent();
            Name = "pcmForm";
        }

        private void pcButton_Click(object sender, EventArgs e)
        {
            projectName = projectNameTextBox.Text;
            projectListBox.Items.Add(projectName);
            if (projectListBox.Items.Count == 1)
            {
                projectListBox.SelectedIndex = projectListBox.FindString(projectName);
            }
            facade.Add(new Facade(projectType, ide, browser, ftpClient, shellInterface, githubDesktop, mySQLServer, xampp));
            fmp.doSomething(projectName, projectType, ide, browser, ftpClient, shellInterface, githubDesktop, mySQLServer, xampp);
            openForms.Add(fmp.cp.project);
        }

        private void cRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cRadio.Checked == true)
            {
                cBox.Enabled = true;
                projectType = "C";
                if (eclipseCRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (sublimeTextCRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioCRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                browser = "null";
                ftpClient = "null";
                shellInterface = "null";
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                mySQLServer = false;
                xampp = false;
            }
            else if (cRadio.Checked == false)
            {
                cBox.Enabled = false;
            }
        }

        private void cppRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cppRadio.Checked == true)
            {
                cBox.Enabled = true;
                projectType = "C++";
                if (eclipseCRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (sublimeTextCRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioCRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                browser = "null";
                ftpClient = "null";
                shellInterface = "null";
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                mySQLServer = false;
                xampp = false;
            }
            else if (cppRadio.Checked == false)
            {
                cBox.Enabled = false;
            }
        }

        private void csRadio_CheckedChanged(object sender, EventArgs e)
        {
            projectType = "C#";
            ide = "Visual Studio";
            browser = "null";
            ftpClient = "null";
            shellInterface = "null";
            if (githubCheck.Checked == true)
            {
                githubDesktop = true;
            }
            else
            {
                githubDesktop = false;
            }
            mySQLServer = false;
            xampp = false;
        }

        private void htmlRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (htmlRadio.Checked == true)
            {
                webIDEBox.Enabled = true;
                browserBox.Enabled = true;
                ftpBox.Enabled = true;
                shellInterfaceBox.Enabled = true;
                mySQLCheck.Enabled = true;
                xamppCheck.Enabled = true;
                projectType = "HTML";
                if (bracketsRadio.Checked == true)
                {
                    ide = "Brackets";
                }
                else if (eclipseWebRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (netbeansWebRadio.Checked == true)
                {
                    ide = "Netbeans";
                }
                else if (phpStormRadio.Checked == true)
                {
                    ide = "PHPStorm";
                }
                else if (sublimeTextWebRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioWebRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                if (chromeRadio.Checked == true)
                {
                    browser = "Chrome";
                }
                else if (edgeRadio.Checked == true)
                {
                    browser = "Edge";
                }
                else if (firefoxRadio.Checked == true)
                {
                    browser = "Firefox";
                }
                else if (operaRadio.Checked == true)
                {
                    browser = "Opera";
                }
                else if (waterfoxRadio.Checked == true)
                {
                    browser = "Waterfox";
                }
                if (cyberduckRadio.Checked == true)
                {
                    ftpClient = "Cyberduck";
                }
                else if (xFTPRadio.Checked == true)
                {
                    ftpClient = "Xftp";
                }
                if (cmdRadio.Checked == true)
                {
                    shellInterface = "Command Prompt";
                }
                else if (powerShellRadio.Checked == true)
                {
                    shellInterface = "Powershell";
                }
                else if (xShellRadio.Checked == true)
                {
                    shellInterface = "Xshell";
                }
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                if (mySQLCheck.Checked == true)
                {
                    mySQLServer = true;
                }
                else
                {
                    mySQLServer = false;
                }
                if (xamppCheck.Checked == true)
                {
                    xampp = true;
                }
                else
                {
                    xampp = false;
                }
            }
            else if (htmlRadio.Checked == false)
            {
                webIDEBox.Enabled = false;
                browserBox.Enabled = false;
                ftpBox.Enabled = false;
                shellInterfaceBox.Enabled = false;
                mySQLCheck.Enabled = false;
                xamppCheck.Enabled = false;
            }
        }

        private void javaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (javaRadio.Checked == true)
            {
                javaIDEBox.Enabled = true;
                projectType = "C++";
                if (eclipseJavaRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (netbeansJavaRadio.Checked == true)
                {
                    ide = "Netbeans";
                }
                else if (sublimeTextJavaRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                browser = "null";
                ftpClient = "null";
                shellInterface = "null";
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                mySQLServer = false;
                xampp = false;
            }
            else if (javaRadio.Checked == false)
            {
                javaIDEBox.Enabled = false;
            }
        }

        private void jsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (jsRadio.Checked == true)
            {
                webIDEBox.Enabled = true;
                browserBox.Enabled = true;
                ftpBox.Enabled = true;
                shellInterfaceBox.Enabled = true;
                mySQLCheck.Enabled = true;
                xamppCheck.Enabled = true;
                projectType = "JavaScript";
                if (bracketsRadio.Checked == true)
                {
                    ide = "Brackets";
                }
                else if (eclipseWebRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (netbeansWebRadio.Checked == true)
                {
                    ide = "Netbeans";
                }
                else if (phpStormRadio.Checked == true)
                {
                    ide = "PHPStorm";
                }
                else if (sublimeTextWebRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioWebRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                if (chromeRadio.Checked == true)
                {
                    browser = "Chrome";
                }
                else if (edgeRadio.Checked == true)
                {
                    browser = "Edge";
                }
                else if (firefoxRadio.Checked == true)
                {
                    browser = "Firefox";
                }
                else if (operaRadio.Checked == true)
                {
                    browser = "Opera";
                }
                else if (waterfoxRadio.Checked == true)
                {
                    browser = "Waterfox";
                }
                if (cyberduckRadio.Checked == true)
                {
                    ftpClient = "Cyberduck";
                }
                else if (xFTPRadio.Checked == true)
                {
                    ftpClient = "Xftp";
                }
                if (cmdRadio.Checked == true)
                {
                    shellInterface = "Command Prompt";
                }
                else if (powerShellRadio.Checked == true)
                {
                    shellInterface = "Powershell";
                }
                else if (xShellRadio.Checked == true)
                {
                    shellInterface = "Xshell";
                }
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                if (mySQLCheck.Checked == true)
                {
                    mySQLServer = true;
                }
                else
                {
                    mySQLServer = false;
                }
                if (xamppCheck.Checked == true)
                {
                    xampp = true;
                }
                else
                {
                    xampp = false;
                }
            }
            else if (jsRadio.Checked == false)
            {
                webIDEBox.Enabled = false;
                browserBox.Enabled = false;
                ftpBox.Enabled = false;
                shellInterfaceBox.Enabled = false;
                mySQLCheck.Enabled = false;
                xamppCheck.Enabled = false;
            }
        }

        private void phpRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (phpRadio.Checked == true)
            {
                webIDEBox.Enabled = true;
                browserBox.Enabled = true;
                ftpBox.Enabled = true;
                shellInterfaceBox.Enabled = true;
                mySQLCheck.Enabled = true;
                xamppCheck.Enabled = true;
                projectType = "PHP";
                if (bracketsRadio.Checked == true)
                {
                    ide = "Brackets";
                }
                else if (eclipseWebRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (netbeansWebRadio.Checked == true)
                {
                    ide = "Netbeans";
                }
                else if (phpStormRadio.Checked == true)
                {
                    ide = "PHPStorm";
                }
                else if (sublimeTextWebRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioWebRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                if (chromeRadio.Checked == true)
                {
                    browser = "Chrome";
                }
                else if (edgeRadio.Checked == true)
                {
                    browser = "Edge";
                }
                else if (firefoxRadio.Checked == true)
                {
                    browser = "Firefox";
                }
                else if (operaRadio.Checked == true)
                {
                    browser = "Opera";
                }
                else if (waterfoxRadio.Checked == true)
                {
                    browser = "Waterfox";
                }
                if (cyberduckRadio.Checked == true)
                {
                    ftpClient = "Cyberduck";
                }
                else if (xFTPRadio.Checked == true)
                {
                    ftpClient = "Xftp";
                }
                if (cmdRadio.Checked == true)
                {
                    shellInterface = "Command Prompt";
                }
                else if (powerShellRadio.Checked == true)
                {
                    shellInterface = "Powershell";
                }
                else if (xShellRadio.Checked == true)
                {
                    shellInterface = "Xshell";
                }
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                if (mySQLCheck.Checked == true)
                {
                    mySQLServer = true;
                }
                else
                {
                    mySQLServer = false;
                }
                if (xamppCheck.Checked == true)
                {
                    xampp = true;
                }
                else
                {
                    xampp = false;
                }
            }
            else if (phpRadio.Checked == false)
            {
                webIDEBox.Enabled = false;
                browserBox.Enabled = false;
                ftpBox.Enabled = false;
                shellInterfaceBox.Enabled = false;
                mySQLCheck.Enabled = false;
                xamppCheck.Enabled = false;
            }
        }

        private void pythonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pythonRadio.Checked == true)
            {
                pythonBox.Enabled = true;
                projectType = "Python";
                if (bracketsPythonRadio.Checked == true)
                {
                    ide = "Brackets";
                }
                else if (sublimeTextPythonRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                browser = "null";
                ftpClient = "null";
                shellInterface = "null";
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                mySQLServer = false;
                xampp = false;
            }
            else if (pythonRadio.Checked == false)
            {
                pythonBox.Enabled = false;
            }
        }

        private void webRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (webRadio.Checked == true)
            {
                webIDEBox.Enabled = true;
                browserBox.Enabled = true;
                ftpBox.Enabled = true;
                shellInterfaceBox.Enabled = true;
                mySQLCheck.Enabled = true;
                xamppCheck.Enabled = true;
                projectType = "Web";
                if (bracketsRadio.Checked == true)
                {
                    ide = "Brackets";
                }
                else if (eclipseWebRadio.Checked == true)
                {
                    ide = "Eclipse";
                }
                else if (netbeansWebRadio.Checked == true)
                {
                    ide = "Netbeans";
                }
                else if (phpStormRadio.Checked == true)
                {
                    ide = "PHPStorm";
                }
                else if (sublimeTextWebRadio.Checked == true)
                {
                    ide = "Sublime Text";
                }
                else if (visualStudioWebRadio.Checked == true)
                {
                    ide = "Visual Studio";
                }
                if (chromeRadio.Checked == true)
                {
                    browser = "Chrome";
                }
                else if (edgeRadio.Checked == true)
                {
                    browser = "Edge";
                }
                else if (firefoxRadio.Checked == true)
                {
                    browser = "Firefox";
                }
                else if (operaRadio.Checked == true)
                {
                    browser = "Opera";
                }
                else if (waterfoxRadio.Checked == true)
                {
                    browser = "Waterfox";
                }
                if (cyberduckRadio.Checked == true)
                {
                    ftpClient = "Cyberduck";
                }
                else if (xFTPRadio.Checked == true)
                {
                    ftpClient = "Xftp";
                }
                if (cmdRadio.Checked == true)
                {
                    shellInterface = "Command Prompt";
                }
                else if (powerShellRadio.Checked == true)
                {
                    shellInterface = "Powershell";
                }
                else if (xShellRadio.Checked == true)
                {
                    shellInterface = "Xshell";
                }
                if (githubCheck.Checked == true)
                {
                    githubDesktop = true;
                }
                else
                {
                    githubDesktop = false;
                }
                if (mySQLCheck.Checked == true)
                {
                    mySQLServer = true;
                }
                else
                {
                    mySQLServer = false;
                }
                if (xamppCheck.Checked == true)
                {
                    xampp = true;
                }
                else
                {
                    xampp = false;
                }
            }
            else if (webRadio.Checked == false)
            {
                webIDEBox.Enabled = false;
                browserBox.Enabled = false;
                ftpBox.Enabled = false;
                shellInterfaceBox.Enabled = false;
                mySQLCheck.Enabled = false;
                xamppCheck.Enabled = false;
            }
        }

        private void githubCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (githubCheck.Checked == true)
            {
                githubDesktop = true;
            }
            else
            {
                githubDesktop = false;
            }
        }

        private void mySQLCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (mySQLCheck.Checked == true)
            {
                mySQLServer = true;
            }
            else
            {
                mySQLServer = false;
            }
        }

        private void xamppCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (xamppCheck.Checked == true)
            {
                xampp = true;
            }
            else
            {
                xampp = false;
            }
        }

        private void eclipseCRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (eclipseCRadio.Checked == true)
            {
                ide = "Eclipse";
            }
        }

        private void sublimeTextCRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sublimeTextCRadio.Checked == true)
            {
                ide = "Sublime Text";
            }
        }

        private void visualStudioCRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (visualStudioCRadio.Checked == true)
            {
                ide = "Visual Studio";
            }
        }

        private void bracketsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (bracketsRadio.Checked == true)
            {
                ide = "Brackets";
            }
        }

        private void eclipseWebRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (eclipseWebRadio.Checked == true)
            {
                ide = "Eclipse";
            }
        }

        private void netbeansWebRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (netbeansWebRadio.Checked == true)
            {
                ide = "Netbeans";
            }
        }

        private void phpStormRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (phpStormRadio.Checked == true)
            {
                ide = "PHPStorm";
            }
        }

        private void sublimeTextWebRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sublimeTextWebRadio.Checked == true)
            {
                ide = "Sublime Text";
            }
        }

        private void visualStudioWebRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (visualStudioWebRadio.Checked == true)
            {
                ide = "Visual Studio";
            }
        }

        private void chromeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (chromeRadio.Checked == true)
            {
                browser = "Chrome";
            }
        }

        private void edgeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (edgeRadio.Checked == true)
            {
                browser = "Edge";
            }
        }

        private void firefoxRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (firefoxRadio.Checked == true)
            {
                browser = "Firefox";
            }
        }

        private void operaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (operaRadio.Checked == true)
            {
                browser = "Opera";
            }
        }

        private void waterfoxRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (waterfoxRadio.Checked == true)
            {
                browser = "Waterfox";
            }
        }

        private void cyberduckRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cyberduckRadio.Checked == true)
            {
                ftpClient = "Cyberduck";
            }
        }

        private void xFTPRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (xFTPRadio.Checked == true)
            {
                ftpClient = "Xftp";
            }
        }

        private void cmdRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cmdRadio.Checked == true)
            {
                shellInterface = "Command Prompt";
            }
        }

        private void powerShellRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (powerShellRadio.Checked == true)
            {
                shellInterface = "Powershell";
            }
        }

        private void xShellRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (xShellRadio.Checked == true)
            {
                shellInterface = "Xshell";
            }
        }

        private void eclipseJavaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (eclipseJavaRadio.Checked == true)
            {
                ide = "Eclipse";
            }
        }

        private void netbeansJavaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (netbeansJavaRadio.Checked == true)
            {
                ide = "Netbeans";
            }
        }

        private void sublimeTextJavaRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sublimeTextJavaRadio.Checked == true)
            {
                ide = "Sublime Text";
            }
        }

        private void bracketsPythonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (bracketsPythonRadio.Checked == true)
            {
                ide = "Brackets";
            }
        }

        private void sublimeTextPythonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sublimeTextPythonRadio.Checked == true)
            {
                ide = "Sublime Text";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            projectListBox.Items.Clear();

            foreach (Form f in openForms)
            {
                f.Close();
            }
            
            openForms.Clear();

            for (int i = 0; i < facade.Count; i++)
            {
                facade[i].murder();
                facade.Remove(facade[i]);
            }
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            int index_1 = projectListBox.SelectedIndex;
            
            openForms[index_1].Close();
            openForms.Remove(openForms[index_1]);
            facade[index_1].murder();
            facade.Remove(facade[index_1]);
            projectListBox.Items.Remove(projectListBox.SelectedItem);
        }
    }
}
