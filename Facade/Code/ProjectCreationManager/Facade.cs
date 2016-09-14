using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectCreationManager
{
    public class Facade
    {
        String visualStudioPath = "C:/Program Files (x86)/Microsoft Visual Studio 12.0/Common7/IDE/devenv.exe";
        String eclipsePath = "C:/Users/Mark/eclipse/java-neon/eclipse/eclipse.exe";
        String sublimeTextPath = "C:/Program Files/Sublime Text 3/sublime_text.exe";
        String bracketsPath = "C:/Program Files (x86)/Brackets/Brackets.exe";
        String netbeansPath = "C:/Program Files/NetBeans 8.1/bin/netbeans64.exe";
        String phpStormPath = "C:/Program Files (x86)/JetBrains/PhpStorm 10.0.3/bin/PhpStorm.exe";
        String chromePath = "C:/Program Files (x86)/Google/Chrome/Application/chrome.exe";
        String edgePath = "C:/Windows/SystemApps/Microsoft.MicrosoftEdge_8wekyb3d8bbwe/MicrosoftEdge.exe";
        String firefoxPath = "C:/Program Files (x86)/Mozilla Firefox/firefox.exe";
        String operaPath = "C:/Program Files (x86)/Opera/launcher.exe";
        String waterfoxPath = "C:/Program Files/Waterfox/waterfox.exe";
        String cyberduckPath = "C:/Program Files (x86)/Cyberduck/Cyberduck.exe";
        String xftpPath = "C:/Program Files (x86)/NetSarang/Xftp 5/Xftp.exe";
        String cmdPath = "C:/Windows/system32/cmd.exe";
        String powerShellPath = "C:/Windows/System32/WindowsPowerShell/v1.0/powershell.exe";
        String xshellPath = "C:/Program Files (x86)/NetSarang/Xshell 5/Xshell.exe";
        String githubDesktopPath = "C:/Users/Mark/AppData/Local/Apps/2.0/VYWTXCG6.7QZ/A3DMKXJL.EC1/gith..tion_317444273a93ac29_0003.0003_92b520eb113e6614/GitHub.exe";
        String mySQLServerPath = "C:/Program Files/MySQL/MySQL Workbench 6.3 CE/MySQLWorkbench.exe";
        String xamppPath = "C:/xampp/xampp-control.exe";
        Process ideProcess;
        int ideKillInt;
        Process browserProcess;
        int browserKillInt;
        Process ftpClientProcess;
        int ftpClientKillInt;
        Process shellInterfaceProcess;
        int shellInterfaceKillInt;
        Process githubDesktopProcess;
        int githubDesktopKillInt;
        Process mySQLServerProcess;
        int mySQLServerKillInt;
        Process xamppProcess;
        int xamppKillInt;
        public Facade()
        {

        }

        public Facade(String projectType, String ide, String browser, String ftpClient, String shellInterface, Boolean githubDesktop, Boolean mySQLServer, Boolean xampp)
        {
            if (ide == "Brackets")
            {
                ideProcess = Process.Start(bracketsPath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            else if (ide == "Eclipse")
            {
                ideProcess = Process.Start(eclipsePath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            else if (ide == "Netbeans")
            {
                ideProcess = Process.Start(netbeansPath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            else if (ide == "PHPStorm")
            {
                ideProcess = Process.Start(phpStormPath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            else if (ide == "Sublime Text")
            {
                ideProcess = Process.Start(sublimeTextPath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            else if (ide == "Visual Studio")
            {
                ideProcess = Process.Start(visualStudioPath);
                ideKillInt = Process.GetProcessesByName(ideProcess.ProcessName).Length;
            }
            if (browser == "Chrome")
            {
                browserProcess = Process.Start(chromePath);
                browserKillInt = Process.GetProcessesByName(browserProcess.ProcessName).Length;
            }
            else if (browser == "Edge")
            {
                browserProcess = Process.Start(edgePath);
                browserKillInt = Process.GetProcessesByName(browserProcess.ProcessName).Length;
            }
            else if (browser == "Firefox")
            {
                browserProcess = Process.Start(firefoxPath);
                browserKillInt = Process.GetProcessesByName(browserProcess.ProcessName).Length;
            }
            else if (browser == "Opera")
            {
                browserProcess = Process.Start(operaPath);
                browserKillInt = Process.GetProcessesByName(browserProcess.ProcessName).Length;
            }
            else if (browser == "Waterfox")
            {
                browserProcess = Process.Start(waterfoxPath);
                browserKillInt = Process.GetProcessesByName(browserProcess.ProcessName).Length;
            }
            if (ftpClient == "Cyberduck")
            {
                ftpClientProcess = Process.Start(cyberduckPath);
                ftpClientKillInt = Process.GetProcessesByName(ftpClientProcess.ProcessName).Length;
            }
            else if (ftpClient == "Xftp")
            {
                ftpClientProcess = Process.Start(xftpPath);
                ftpClientKillInt = Process.GetProcessesByName(ftpClientProcess.ProcessName).Length;
            }
            if (shellInterface == "Command Prompt")
            {
                shellInterfaceProcess = Process.Start(cmdPath);
                shellInterfaceKillInt = Process.GetProcessesByName(shellInterfaceProcess.ProcessName).Length;
            }
            else if (shellInterface == "Powershell")
            {
                shellInterfaceProcess = Process.Start(powerShellPath);
                shellInterfaceKillInt = Process.GetProcessesByName(shellInterfaceProcess.ProcessName).Length;
            }
            else if (shellInterface == "Xshell")
            {
                shellInterfaceProcess = Process.Start(xshellPath);
                shellInterfaceKillInt = Process.GetProcessesByName(shellInterfaceProcess.ProcessName).Length;
            }
            if (githubDesktop)
            {
                githubDesktopProcess = Process.Start(githubDesktopPath);
                githubDesktopKillInt = Process.GetProcessesByName(githubDesktopProcess.ProcessName).Length;
            }
            if (mySQLServer)
            {
                mySQLServerProcess = Process.Start(mySQLServerPath);
                mySQLServerKillInt = Process.GetProcessesByName(mySQLServerProcess.ProcessName).Length;
            }
            if (xampp)
            {
                xamppProcess = Process.Start(xamppPath);
                xamppKillInt = Process.GetProcessesByName(xamppProcess.ProcessName).Length;
            }
        }
        public void murder(){
            if (ideKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(ideProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
            if (ftpClientKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(ftpClientProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
            if (shellInterfaceKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(shellInterfaceProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
            if (githubDesktopKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(githubDesktopProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
            if (mySQLServerKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(mySQLServerProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
            if (xamppKillInt != 0)
            {
                foreach (Process proc in Process.GetProcessesByName(xamppProcess.ProcessName))
                {
                    proc.Kill();
                }
            }
        }
    }
}
