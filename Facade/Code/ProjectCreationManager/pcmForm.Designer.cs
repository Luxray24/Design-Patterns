namespace ProjectCreationManager
{
    partial class pcmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.preferencesBox = new System.Windows.Forms.GroupBox();
            this.extraSoftwareBox = new System.Windows.Forms.GroupBox();
            this.xamppCheck = new System.Windows.Forms.CheckBox();
            this.mySQLCheck = new System.Windows.Forms.CheckBox();
            this.githubCheck = new System.Windows.Forms.CheckBox();
            this.browserBox = new System.Windows.Forms.GroupBox();
            this.waterfoxRadio = new System.Windows.Forms.RadioButton();
            this.firefoxRadio = new System.Windows.Forms.RadioButton();
            this.edgeRadio = new System.Windows.Forms.RadioButton();
            this.operaRadio = new System.Windows.Forms.RadioButton();
            this.chromeRadio = new System.Windows.Forms.RadioButton();
            this.ftpBox = new System.Windows.Forms.GroupBox();
            this.xFTPRadio = new System.Windows.Forms.RadioButton();
            this.cyberduckRadio = new System.Windows.Forms.RadioButton();
            this.shellInterfaceBox = new System.Windows.Forms.GroupBox();
            this.powerShellRadio = new System.Windows.Forms.RadioButton();
            this.cmdRadio = new System.Windows.Forms.RadioButton();
            this.xShellRadio = new System.Windows.Forms.RadioButton();
            this.ideBox = new System.Windows.Forms.GroupBox();
            this.webIDEBox = new System.Windows.Forms.GroupBox();
            this.eclipseWebRadio = new System.Windows.Forms.RadioButton();
            this.phpStormRadio = new System.Windows.Forms.RadioButton();
            this.sublimeTextWebRadio = new System.Windows.Forms.RadioButton();
            this.netbeansWebRadio = new System.Windows.Forms.RadioButton();
            this.visualStudioWebRadio = new System.Windows.Forms.RadioButton();
            this.bracketsRadio = new System.Windows.Forms.RadioButton();
            this.javaIDEBox = new System.Windows.Forms.GroupBox();
            this.sublimeTextJavaRadio = new System.Windows.Forms.RadioButton();
            this.netbeansJavaRadio = new System.Windows.Forms.RadioButton();
            this.eclipseJavaRadio = new System.Windows.Forms.RadioButton();
            this.pythonBox = new System.Windows.Forms.GroupBox();
            this.bracketsPythonRadio = new System.Windows.Forms.RadioButton();
            this.sublimeTextPythonRadio = new System.Windows.Forms.RadioButton();
            this.cBox = new System.Windows.Forms.GroupBox();
            this.visualStudioCRadio = new System.Windows.Forms.RadioButton();
            this.eclipseCRadio = new System.Windows.Forms.RadioButton();
            this.sublimeTextCRadio = new System.Windows.Forms.RadioButton();
            this.projectBox = new System.Windows.Forms.GroupBox();
            this.cRadio = new System.Windows.Forms.RadioButton();
            this.cppRadio = new System.Windows.Forms.RadioButton();
            this.csRadio = new System.Windows.Forms.RadioButton();
            this.webRadio = new System.Windows.Forms.RadioButton();
            this.phpRadio = new System.Windows.Forms.RadioButton();
            this.jsRadio = new System.Windows.Forms.RadioButton();
            this.pythonRadio = new System.Windows.Forms.RadioButton();
            this.htmlRadio = new System.Windows.Forms.RadioButton();
            this.javaRadio = new System.Windows.Forms.RadioButton();
            this.pcButton = new System.Windows.Forms.Button();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectListBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.killButton = new System.Windows.Forms.Button();
            this.preferencesBox.SuspendLayout();
            this.extraSoftwareBox.SuspendLayout();
            this.browserBox.SuspendLayout();
            this.ftpBox.SuspendLayout();
            this.shellInterfaceBox.SuspendLayout();
            this.ideBox.SuspendLayout();
            this.webIDEBox.SuspendLayout();
            this.javaIDEBox.SuspendLayout();
            this.pythonBox.SuspendLayout();
            this.cBox.SuspendLayout();
            this.projectBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // preferencesBox
            // 
            this.preferencesBox.Controls.Add(this.extraSoftwareBox);
            this.preferencesBox.Controls.Add(this.ideBox);
            this.preferencesBox.Location = new System.Drawing.Point(12, 12);
            this.preferencesBox.Name = "preferencesBox";
            this.preferencesBox.Size = new System.Drawing.Size(342, 490);
            this.preferencesBox.TabIndex = 0;
            this.preferencesBox.TabStop = false;
            this.preferencesBox.Text = "Preferences";
            // 
            // extraSoftwareBox
            // 
            this.extraSoftwareBox.Controls.Add(this.xamppCheck);
            this.extraSoftwareBox.Controls.Add(this.mySQLCheck);
            this.extraSoftwareBox.Controls.Add(this.githubCheck);
            this.extraSoftwareBox.Controls.Add(this.browserBox);
            this.extraSoftwareBox.Controls.Add(this.ftpBox);
            this.extraSoftwareBox.Controls.Add(this.shellInterfaceBox);
            this.extraSoftwareBox.Location = new System.Drawing.Point(167, 19);
            this.extraSoftwareBox.Name = "extraSoftwareBox";
            this.extraSoftwareBox.Size = new System.Drawing.Size(169, 459);
            this.extraSoftwareBox.TabIndex = 3;
            this.extraSoftwareBox.TabStop = false;
            this.extraSoftwareBox.Text = "Extra Software";
            // 
            // xamppCheck
            // 
            this.xamppCheck.AutoSize = true;
            this.xamppCheck.Enabled = false;
            this.xamppCheck.Location = new System.Drawing.Point(6, 393);
            this.xamppCheck.Name = "xamppCheck";
            this.xamppCheck.Size = new System.Drawing.Size(63, 17);
            this.xamppCheck.TabIndex = 6;
            this.xamppCheck.Text = "XAMPP";
            this.xamppCheck.UseVisualStyleBackColor = true;
            this.xamppCheck.CheckedChanged += new System.EventHandler(this.xamppCheck_CheckedChanged);
            // 
            // mySQLCheck
            // 
            this.mySQLCheck.AutoSize = true;
            this.mySQLCheck.Enabled = false;
            this.mySQLCheck.Location = new System.Drawing.Point(6, 370);
            this.mySQLCheck.Name = "mySQLCheck";
            this.mySQLCheck.Size = new System.Drawing.Size(95, 17);
            this.mySQLCheck.TabIndex = 5;
            this.mySQLCheck.Text = "MySQL Server";
            this.mySQLCheck.UseVisualStyleBackColor = true;
            this.mySQLCheck.CheckedChanged += new System.EventHandler(this.mySQLCheck_CheckedChanged);
            // 
            // githubCheck
            // 
            this.githubCheck.AutoSize = true;
            this.githubCheck.Checked = true;
            this.githubCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.githubCheck.Location = new System.Drawing.Point(7, 347);
            this.githubCheck.Name = "githubCheck";
            this.githubCheck.Size = new System.Drawing.Size(100, 17);
            this.githubCheck.TabIndex = 4;
            this.githubCheck.Text = "Github Desktop";
            this.githubCheck.UseVisualStyleBackColor = true;
            this.githubCheck.CheckedChanged += new System.EventHandler(this.githubCheck_CheckedChanged);
            // 
            // browserBox
            // 
            this.browserBox.Controls.Add(this.waterfoxRadio);
            this.browserBox.Controls.Add(this.firefoxRadio);
            this.browserBox.Controls.Add(this.edgeRadio);
            this.browserBox.Controls.Add(this.operaRadio);
            this.browserBox.Controls.Add(this.chromeRadio);
            this.browserBox.Enabled = false;
            this.browserBox.Location = new System.Drawing.Point(6, 19);
            this.browserBox.Name = "browserBox";
            this.browserBox.Size = new System.Drawing.Size(157, 141);
            this.browserBox.TabIndex = 3;
            this.browserBox.TabStop = false;
            this.browserBox.Text = "Browser";
            // 
            // waterfoxRadio
            // 
            this.waterfoxRadio.AutoSize = true;
            this.waterfoxRadio.Location = new System.Drawing.Point(6, 111);
            this.waterfoxRadio.Name = "waterfoxRadio";
            this.waterfoxRadio.Size = new System.Drawing.Size(68, 17);
            this.waterfoxRadio.TabIndex = 4;
            this.waterfoxRadio.TabStop = true;
            this.waterfoxRadio.Text = "Waterfox";
            this.waterfoxRadio.UseVisualStyleBackColor = true;
            this.waterfoxRadio.CheckedChanged += new System.EventHandler(this.waterfoxRadio_CheckedChanged);
            // 
            // firefoxRadio
            // 
            this.firefoxRadio.AutoSize = true;
            this.firefoxRadio.Location = new System.Drawing.Point(6, 65);
            this.firefoxRadio.Name = "firefoxRadio";
            this.firefoxRadio.Size = new System.Drawing.Size(56, 17);
            this.firefoxRadio.TabIndex = 5;
            this.firefoxRadio.TabStop = true;
            this.firefoxRadio.Text = "Firefox";
            this.firefoxRadio.UseVisualStyleBackColor = true;
            this.firefoxRadio.CheckedChanged += new System.EventHandler(this.firefoxRadio_CheckedChanged);
            // 
            // edgeRadio
            // 
            this.edgeRadio.AutoSize = true;
            this.edgeRadio.Location = new System.Drawing.Point(6, 42);
            this.edgeRadio.Name = "edgeRadio";
            this.edgeRadio.Size = new System.Drawing.Size(50, 17);
            this.edgeRadio.TabIndex = 8;
            this.edgeRadio.TabStop = true;
            this.edgeRadio.Text = "Edge";
            this.edgeRadio.UseVisualStyleBackColor = true;
            this.edgeRadio.CheckedChanged += new System.EventHandler(this.edgeRadio_CheckedChanged);
            // 
            // operaRadio
            // 
            this.operaRadio.AutoSize = true;
            this.operaRadio.Checked = true;
            this.operaRadio.Location = new System.Drawing.Point(6, 88);
            this.operaRadio.Name = "operaRadio";
            this.operaRadio.Size = new System.Drawing.Size(54, 17);
            this.operaRadio.TabIndex = 6;
            this.operaRadio.TabStop = true;
            this.operaRadio.Text = "Opera";
            this.operaRadio.UseVisualStyleBackColor = true;
            this.operaRadio.CheckedChanged += new System.EventHandler(this.operaRadio_CheckedChanged);
            // 
            // chromeRadio
            // 
            this.chromeRadio.AutoSize = true;
            this.chromeRadio.Location = new System.Drawing.Point(6, 19);
            this.chromeRadio.Name = "chromeRadio";
            this.chromeRadio.Size = new System.Drawing.Size(61, 17);
            this.chromeRadio.TabIndex = 7;
            this.chromeRadio.TabStop = true;
            this.chromeRadio.Text = "Chrome";
            this.chromeRadio.UseVisualStyleBackColor = true;
            this.chromeRadio.CheckedChanged += new System.EventHandler(this.chromeRadio_CheckedChanged);
            // 
            // ftpBox
            // 
            this.ftpBox.Controls.Add(this.xFTPRadio);
            this.ftpBox.Controls.Add(this.cyberduckRadio);
            this.ftpBox.Enabled = false;
            this.ftpBox.Location = new System.Drawing.Point(6, 166);
            this.ftpBox.Name = "ftpBox";
            this.ftpBox.Size = new System.Drawing.Size(157, 68);
            this.ftpBox.TabIndex = 3;
            this.ftpBox.TabStop = false;
            this.ftpBox.Text = "FTP Client";
            // 
            // xFTPRadio
            // 
            this.xFTPRadio.AutoSize = true;
            this.xFTPRadio.Checked = true;
            this.xFTPRadio.Location = new System.Drawing.Point(6, 42);
            this.xFTPRadio.Name = "xFTPRadio";
            this.xFTPRadio.Size = new System.Drawing.Size(44, 17);
            this.xFTPRadio.TabIndex = 5;
            this.xFTPRadio.TabStop = true;
            this.xFTPRadio.Text = "Xftp";
            this.xFTPRadio.UseVisualStyleBackColor = true;
            this.xFTPRadio.CheckedChanged += new System.EventHandler(this.xFTPRadio_CheckedChanged);
            // 
            // cyberduckRadio
            // 
            this.cyberduckRadio.AutoSize = true;
            this.cyberduckRadio.Location = new System.Drawing.Point(6, 19);
            this.cyberduckRadio.Name = "cyberduckRadio";
            this.cyberduckRadio.Size = new System.Drawing.Size(76, 17);
            this.cyberduckRadio.TabIndex = 4;
            this.cyberduckRadio.TabStop = true;
            this.cyberduckRadio.Text = "Cyberduck";
            this.cyberduckRadio.UseVisualStyleBackColor = true;
            this.cyberduckRadio.CheckedChanged += new System.EventHandler(this.cyberduckRadio_CheckedChanged);
            // 
            // shellInterfaceBox
            // 
            this.shellInterfaceBox.Controls.Add(this.powerShellRadio);
            this.shellInterfaceBox.Controls.Add(this.cmdRadio);
            this.shellInterfaceBox.Controls.Add(this.xShellRadio);
            this.shellInterfaceBox.Enabled = false;
            this.shellInterfaceBox.Location = new System.Drawing.Point(6, 240);
            this.shellInterfaceBox.Name = "shellInterfaceBox";
            this.shellInterfaceBox.Size = new System.Drawing.Size(157, 100);
            this.shellInterfaceBox.TabIndex = 2;
            this.shellInterfaceBox.TabStop = false;
            this.shellInterfaceBox.Text = "Shell Interface";
            // 
            // powerShellRadio
            // 
            this.powerShellRadio.AutoSize = true;
            this.powerShellRadio.Location = new System.Drawing.Point(6, 42);
            this.powerShellRadio.Name = "powerShellRadio";
            this.powerShellRadio.Size = new System.Drawing.Size(81, 17);
            this.powerShellRadio.TabIndex = 5;
            this.powerShellRadio.TabStop = true;
            this.powerShellRadio.Text = "Power Shell";
            this.powerShellRadio.UseVisualStyleBackColor = true;
            this.powerShellRadio.CheckedChanged += new System.EventHandler(this.powerShellRadio_CheckedChanged);
            // 
            // cmdRadio
            // 
            this.cmdRadio.AutoSize = true;
            this.cmdRadio.Location = new System.Drawing.Point(6, 19);
            this.cmdRadio.Name = "cmdRadio";
            this.cmdRadio.Size = new System.Drawing.Size(108, 17);
            this.cmdRadio.TabIndex = 5;
            this.cmdRadio.TabStop = true;
            this.cmdRadio.Text = "Command Prompt";
            this.cmdRadio.UseVisualStyleBackColor = true;
            this.cmdRadio.CheckedChanged += new System.EventHandler(this.cmdRadio_CheckedChanged);
            // 
            // xShellRadio
            // 
            this.xShellRadio.AutoSize = true;
            this.xShellRadio.Checked = true;
            this.xShellRadio.Location = new System.Drawing.Point(6, 65);
            this.xShellRadio.Name = "xShellRadio";
            this.xShellRadio.Size = new System.Drawing.Size(53, 17);
            this.xShellRadio.TabIndex = 6;
            this.xShellRadio.TabStop = true;
            this.xShellRadio.Text = "Xshell";
            this.xShellRadio.UseVisualStyleBackColor = true;
            this.xShellRadio.CheckedChanged += new System.EventHandler(this.xShellRadio_CheckedChanged);
            // 
            // ideBox
            // 
            this.ideBox.Controls.Add(this.webIDEBox);
            this.ideBox.Controls.Add(this.javaIDEBox);
            this.ideBox.Controls.Add(this.pythonBox);
            this.ideBox.Controls.Add(this.cBox);
            this.ideBox.Location = new System.Drawing.Point(6, 19);
            this.ideBox.Name = "ideBox";
            this.ideBox.Size = new System.Drawing.Size(155, 459);
            this.ideBox.TabIndex = 3;
            this.ideBox.TabStop = false;
            this.ideBox.Text = "IDE Choices";
            // 
            // webIDEBox
            // 
            this.webIDEBox.Controls.Add(this.eclipseWebRadio);
            this.webIDEBox.Controls.Add(this.phpStormRadio);
            this.webIDEBox.Controls.Add(this.sublimeTextWebRadio);
            this.webIDEBox.Controls.Add(this.netbeansWebRadio);
            this.webIDEBox.Controls.Add(this.visualStudioWebRadio);
            this.webIDEBox.Controls.Add(this.bracketsRadio);
            this.webIDEBox.Enabled = false;
            this.webIDEBox.Location = new System.Drawing.Point(6, 292);
            this.webIDEBox.Name = "webIDEBox";
            this.webIDEBox.Size = new System.Drawing.Size(133, 156);
            this.webIDEBox.TabIndex = 3;
            this.webIDEBox.TabStop = false;
            this.webIDEBox.Text = "Web Developement";
            // 
            // eclipseWebRadio
            // 
            this.eclipseWebRadio.AutoSize = true;
            this.eclipseWebRadio.Checked = true;
            this.eclipseWebRadio.Location = new System.Drawing.Point(6, 42);
            this.eclipseWebRadio.Name = "eclipseWebRadio";
            this.eclipseWebRadio.Size = new System.Drawing.Size(59, 17);
            this.eclipseWebRadio.TabIndex = 5;
            this.eclipseWebRadio.TabStop = true;
            this.eclipseWebRadio.Text = "Eclipse";
            this.eclipseWebRadio.UseVisualStyleBackColor = true;
            this.eclipseWebRadio.CheckedChanged += new System.EventHandler(this.eclipseWebRadio_CheckedChanged);
            // 
            // phpStormRadio
            // 
            this.phpStormRadio.AutoSize = true;
            this.phpStormRadio.Location = new System.Drawing.Point(6, 88);
            this.phpStormRadio.Name = "phpStormRadio";
            this.phpStormRadio.Size = new System.Drawing.Size(74, 17);
            this.phpStormRadio.TabIndex = 3;
            this.phpStormRadio.TabStop = true;
            this.phpStormRadio.Text = "PHPStorm";
            this.phpStormRadio.UseVisualStyleBackColor = true;
            this.phpStormRadio.CheckedChanged += new System.EventHandler(this.phpStormRadio_CheckedChanged);
            // 
            // sublimeTextWebRadio
            // 
            this.sublimeTextWebRadio.AutoSize = true;
            this.sublimeTextWebRadio.Location = new System.Drawing.Point(6, 110);
            this.sublimeTextWebRadio.Name = "sublimeTextWebRadio";
            this.sublimeTextWebRadio.Size = new System.Drawing.Size(86, 17);
            this.sublimeTextWebRadio.TabIndex = 4;
            this.sublimeTextWebRadio.TabStop = true;
            this.sublimeTextWebRadio.Text = "Sublime Text";
            this.sublimeTextWebRadio.UseVisualStyleBackColor = true;
            this.sublimeTextWebRadio.CheckedChanged += new System.EventHandler(this.sublimeTextWebRadio_CheckedChanged);
            // 
            // netbeansWebRadio
            // 
            this.netbeansWebRadio.AutoSize = true;
            this.netbeansWebRadio.Location = new System.Drawing.Point(6, 65);
            this.netbeansWebRadio.Name = "netbeansWebRadio";
            this.netbeansWebRadio.Size = new System.Drawing.Size(71, 17);
            this.netbeansWebRadio.TabIndex = 4;
            this.netbeansWebRadio.TabStop = true;
            this.netbeansWebRadio.Text = "Netbeans";
            this.netbeansWebRadio.UseVisualStyleBackColor = true;
            this.netbeansWebRadio.CheckedChanged += new System.EventHandler(this.netbeansWebRadio_CheckedChanged);
            // 
            // visualStudioWebRadio
            // 
            this.visualStudioWebRadio.AutoSize = true;
            this.visualStudioWebRadio.Location = new System.Drawing.Point(6, 133);
            this.visualStudioWebRadio.Name = "visualStudioWebRadio";
            this.visualStudioWebRadio.Size = new System.Drawing.Size(86, 17);
            this.visualStudioWebRadio.TabIndex = 5;
            this.visualStudioWebRadio.TabStop = true;
            this.visualStudioWebRadio.Text = "Visual Studio";
            this.visualStudioWebRadio.UseVisualStyleBackColor = true;
            this.visualStudioWebRadio.CheckedChanged += new System.EventHandler(this.visualStudioWebRadio_CheckedChanged);
            // 
            // bracketsRadio
            // 
            this.bracketsRadio.AutoSize = true;
            this.bracketsRadio.Location = new System.Drawing.Point(6, 19);
            this.bracketsRadio.Name = "bracketsRadio";
            this.bracketsRadio.Size = new System.Drawing.Size(67, 17);
            this.bracketsRadio.TabIndex = 1;
            this.bracketsRadio.TabStop = true;
            this.bracketsRadio.Text = "Brackets";
            this.bracketsRadio.UseVisualStyleBackColor = true;
            this.bracketsRadio.CheckedChanged += new System.EventHandler(this.bracketsRadio_CheckedChanged);
            // 
            // javaIDEBox
            // 
            this.javaIDEBox.Controls.Add(this.sublimeTextJavaRadio);
            this.javaIDEBox.Controls.Add(this.netbeansJavaRadio);
            this.javaIDEBox.Controls.Add(this.eclipseJavaRadio);
            this.javaIDEBox.Enabled = false;
            this.javaIDEBox.Location = new System.Drawing.Point(6, 115);
            this.javaIDEBox.Name = "javaIDEBox";
            this.javaIDEBox.Size = new System.Drawing.Size(133, 95);
            this.javaIDEBox.TabIndex = 0;
            this.javaIDEBox.TabStop = false;
            this.javaIDEBox.Text = "Java";
            // 
            // sublimeTextJavaRadio
            // 
            this.sublimeTextJavaRadio.AutoSize = true;
            this.sublimeTextJavaRadio.Location = new System.Drawing.Point(6, 65);
            this.sublimeTextJavaRadio.Name = "sublimeTextJavaRadio";
            this.sublimeTextJavaRadio.Size = new System.Drawing.Size(86, 17);
            this.sublimeTextJavaRadio.TabIndex = 3;
            this.sublimeTextJavaRadio.TabStop = true;
            this.sublimeTextJavaRadio.Text = "Sublime Text";
            this.sublimeTextJavaRadio.UseVisualStyleBackColor = true;
            this.sublimeTextJavaRadio.CheckedChanged += new System.EventHandler(this.sublimeTextJavaRadio_CheckedChanged);
            // 
            // netbeansJavaRadio
            // 
            this.netbeansJavaRadio.AutoSize = true;
            this.netbeansJavaRadio.Location = new System.Drawing.Point(6, 42);
            this.netbeansJavaRadio.Name = "netbeansJavaRadio";
            this.netbeansJavaRadio.Size = new System.Drawing.Size(71, 17);
            this.netbeansJavaRadio.TabIndex = 4;
            this.netbeansJavaRadio.TabStop = true;
            this.netbeansJavaRadio.Text = "Netbeans";
            this.netbeansJavaRadio.UseVisualStyleBackColor = true;
            this.netbeansJavaRadio.CheckedChanged += new System.EventHandler(this.netbeansJavaRadio_CheckedChanged);
            // 
            // eclipseJavaRadio
            // 
            this.eclipseJavaRadio.AutoSize = true;
            this.eclipseJavaRadio.Checked = true;
            this.eclipseJavaRadio.Location = new System.Drawing.Point(6, 19);
            this.eclipseJavaRadio.Name = "eclipseJavaRadio";
            this.eclipseJavaRadio.Size = new System.Drawing.Size(59, 17);
            this.eclipseJavaRadio.TabIndex = 3;
            this.eclipseJavaRadio.TabStop = true;
            this.eclipseJavaRadio.Text = "Eclipse";
            this.eclipseJavaRadio.UseVisualStyleBackColor = true;
            this.eclipseJavaRadio.CheckedChanged += new System.EventHandler(this.eclipseJavaRadio_CheckedChanged);
            // 
            // pythonBox
            // 
            this.pythonBox.Controls.Add(this.bracketsPythonRadio);
            this.pythonBox.Controls.Add(this.sublimeTextPythonRadio);
            this.pythonBox.Enabled = false;
            this.pythonBox.Location = new System.Drawing.Point(6, 216);
            this.pythonBox.Name = "pythonBox";
            this.pythonBox.Size = new System.Drawing.Size(133, 70);
            this.pythonBox.TabIndex = 5;
            this.pythonBox.TabStop = false;
            this.pythonBox.Text = "Python";
            // 
            // bracketsPythonRadio
            // 
            this.bracketsPythonRadio.AutoSize = true;
            this.bracketsPythonRadio.Location = new System.Drawing.Point(6, 19);
            this.bracketsPythonRadio.Name = "bracketsPythonRadio";
            this.bracketsPythonRadio.Size = new System.Drawing.Size(67, 17);
            this.bracketsPythonRadio.TabIndex = 5;
            this.bracketsPythonRadio.TabStop = true;
            this.bracketsPythonRadio.Text = "Brackets";
            this.bracketsPythonRadio.UseVisualStyleBackColor = true;
            this.bracketsPythonRadio.CheckedChanged += new System.EventHandler(this.bracketsPythonRadio_CheckedChanged);
            // 
            // sublimeTextPythonRadio
            // 
            this.sublimeTextPythonRadio.AutoSize = true;
            this.sublimeTextPythonRadio.Checked = true;
            this.sublimeTextPythonRadio.Location = new System.Drawing.Point(6, 42);
            this.sublimeTextPythonRadio.Name = "sublimeTextPythonRadio";
            this.sublimeTextPythonRadio.Size = new System.Drawing.Size(86, 17);
            this.sublimeTextPythonRadio.TabIndex = 5;
            this.sublimeTextPythonRadio.TabStop = true;
            this.sublimeTextPythonRadio.Text = "Sublime Text";
            this.sublimeTextPythonRadio.UseVisualStyleBackColor = true;
            this.sublimeTextPythonRadio.CheckedChanged += new System.EventHandler(this.sublimeTextPythonRadio_CheckedChanged);
            // 
            // cBox
            // 
            this.cBox.Controls.Add(this.visualStudioCRadio);
            this.cBox.Controls.Add(this.eclipseCRadio);
            this.cBox.Controls.Add(this.sublimeTextCRadio);
            this.cBox.Enabled = false;
            this.cBox.Location = new System.Drawing.Point(6, 19);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(133, 90);
            this.cBox.TabIndex = 6;
            this.cBox.TabStop = false;
            this.cBox.Text = "C/C++";
            // 
            // visualStudioCRadio
            // 
            this.visualStudioCRadio.AutoSize = true;
            this.visualStudioCRadio.Checked = true;
            this.visualStudioCRadio.Location = new System.Drawing.Point(6, 65);
            this.visualStudioCRadio.Name = "visualStudioCRadio";
            this.visualStudioCRadio.Size = new System.Drawing.Size(86, 17);
            this.visualStudioCRadio.TabIndex = 9;
            this.visualStudioCRadio.TabStop = true;
            this.visualStudioCRadio.Text = "Visual Studio";
            this.visualStudioCRadio.UseVisualStyleBackColor = true;
            this.visualStudioCRadio.CheckedChanged += new System.EventHandler(this.visualStudioCRadio_CheckedChanged);
            // 
            // eclipseCRadio
            // 
            this.eclipseCRadio.AutoSize = true;
            this.eclipseCRadio.Location = new System.Drawing.Point(6, 19);
            this.eclipseCRadio.Name = "eclipseCRadio";
            this.eclipseCRadio.Size = new System.Drawing.Size(59, 17);
            this.eclipseCRadio.TabIndex = 5;
            this.eclipseCRadio.TabStop = true;
            this.eclipseCRadio.Text = "Eclipse";
            this.eclipseCRadio.UseVisualStyleBackColor = true;
            this.eclipseCRadio.CheckedChanged += new System.EventHandler(this.eclipseCRadio_CheckedChanged);
            // 
            // sublimeTextCRadio
            // 
            this.sublimeTextCRadio.AutoSize = true;
            this.sublimeTextCRadio.Location = new System.Drawing.Point(6, 42);
            this.sublimeTextCRadio.Name = "sublimeTextCRadio";
            this.sublimeTextCRadio.Size = new System.Drawing.Size(86, 17);
            this.sublimeTextCRadio.TabIndex = 5;
            this.sublimeTextCRadio.TabStop = true;
            this.sublimeTextCRadio.Text = "Sublime Text";
            this.sublimeTextCRadio.UseVisualStyleBackColor = true;
            this.sublimeTextCRadio.CheckedChanged += new System.EventHandler(this.sublimeTextCRadio_CheckedChanged);
            // 
            // projectBox
            // 
            this.projectBox.Controls.Add(this.cRadio);
            this.projectBox.Controls.Add(this.cppRadio);
            this.projectBox.Controls.Add(this.csRadio);
            this.projectBox.Controls.Add(this.webRadio);
            this.projectBox.Controls.Add(this.phpRadio);
            this.projectBox.Controls.Add(this.jsRadio);
            this.projectBox.Controls.Add(this.pythonRadio);
            this.projectBox.Controls.Add(this.htmlRadio);
            this.projectBox.Controls.Add(this.javaRadio);
            this.projectBox.Location = new System.Drawing.Point(360, 12);
            this.projectBox.Name = "projectBox";
            this.projectBox.Size = new System.Drawing.Size(113, 490);
            this.projectBox.TabIndex = 1;
            this.projectBox.TabStop = false;
            this.projectBox.Text = "Project Types";
            // 
            // cRadio
            // 
            this.cRadio.AutoSize = true;
            this.cRadio.Location = new System.Drawing.Point(6, 19);
            this.cRadio.Name = "cRadio";
            this.cRadio.Size = new System.Drawing.Size(32, 17);
            this.cRadio.TabIndex = 8;
            this.cRadio.TabStop = true;
            this.cRadio.Text = "C";
            this.cRadio.UseVisualStyleBackColor = true;
            this.cRadio.CheckedChanged += new System.EventHandler(this.cRadio_CheckedChanged);
            // 
            // cppRadio
            // 
            this.cppRadio.AutoSize = true;
            this.cppRadio.Location = new System.Drawing.Point(6, 42);
            this.cppRadio.Name = "cppRadio";
            this.cppRadio.Size = new System.Drawing.Size(44, 17);
            this.cppRadio.TabIndex = 7;
            this.cppRadio.TabStop = true;
            this.cppRadio.Text = "C++";
            this.cppRadio.UseVisualStyleBackColor = true;
            this.cppRadio.CheckedChanged += new System.EventHandler(this.cppRadio_CheckedChanged);
            // 
            // csRadio
            // 
            this.csRadio.AutoSize = true;
            this.csRadio.Checked = true;
            this.csRadio.Location = new System.Drawing.Point(6, 65);
            this.csRadio.Name = "csRadio";
            this.csRadio.Size = new System.Drawing.Size(39, 17);
            this.csRadio.TabIndex = 6;
            this.csRadio.TabStop = true;
            this.csRadio.Text = "C#";
            this.csRadio.UseVisualStyleBackColor = true;
            this.csRadio.CheckedChanged += new System.EventHandler(this.csRadio_CheckedChanged);
            // 
            // webRadio
            // 
            this.webRadio.AutoSize = true;
            this.webRadio.Location = new System.Drawing.Point(6, 203);
            this.webRadio.Name = "webRadio";
            this.webRadio.Size = new System.Drawing.Size(48, 17);
            this.webRadio.TabIndex = 5;
            this.webRadio.TabStop = true;
            this.webRadio.Text = "Web";
            this.webRadio.UseVisualStyleBackColor = true;
            this.webRadio.CheckedChanged += new System.EventHandler(this.webRadio_CheckedChanged);
            // 
            // phpRadio
            // 
            this.phpRadio.AutoSize = true;
            this.phpRadio.Location = new System.Drawing.Point(6, 157);
            this.phpRadio.Name = "phpRadio";
            this.phpRadio.Size = new System.Drawing.Size(47, 17);
            this.phpRadio.TabIndex = 4;
            this.phpRadio.TabStop = true;
            this.phpRadio.Text = "PHP";
            this.phpRadio.UseVisualStyleBackColor = true;
            this.phpRadio.CheckedChanged += new System.EventHandler(this.phpRadio_CheckedChanged);
            // 
            // jsRadio
            // 
            this.jsRadio.AutoSize = true;
            this.jsRadio.Location = new System.Drawing.Point(6, 134);
            this.jsRadio.Name = "jsRadio";
            this.jsRadio.Size = new System.Drawing.Size(75, 17);
            this.jsRadio.TabIndex = 3;
            this.jsRadio.TabStop = true;
            this.jsRadio.Text = "JavaScript";
            this.jsRadio.UseVisualStyleBackColor = true;
            this.jsRadio.CheckedChanged += new System.EventHandler(this.jsRadio_CheckedChanged);
            // 
            // pythonRadio
            // 
            this.pythonRadio.AutoSize = true;
            this.pythonRadio.Location = new System.Drawing.Point(6, 180);
            this.pythonRadio.Name = "pythonRadio";
            this.pythonRadio.Size = new System.Drawing.Size(58, 17);
            this.pythonRadio.TabIndex = 2;
            this.pythonRadio.TabStop = true;
            this.pythonRadio.Text = "Python";
            this.pythonRadio.UseVisualStyleBackColor = true;
            this.pythonRadio.CheckedChanged += new System.EventHandler(this.pythonRadio_CheckedChanged);
            // 
            // htmlRadio
            // 
            this.htmlRadio.AutoSize = true;
            this.htmlRadio.Location = new System.Drawing.Point(6, 88);
            this.htmlRadio.Name = "htmlRadio";
            this.htmlRadio.Size = new System.Drawing.Size(55, 17);
            this.htmlRadio.TabIndex = 1;
            this.htmlRadio.TabStop = true;
            this.htmlRadio.Text = "HTML";
            this.htmlRadio.UseVisualStyleBackColor = true;
            this.htmlRadio.CheckedChanged += new System.EventHandler(this.htmlRadio_CheckedChanged);
            // 
            // javaRadio
            // 
            this.javaRadio.AutoSize = true;
            this.javaRadio.Location = new System.Drawing.Point(6, 111);
            this.javaRadio.Name = "javaRadio";
            this.javaRadio.Size = new System.Drawing.Size(48, 17);
            this.javaRadio.TabIndex = 0;
            this.javaRadio.TabStop = true;
            this.javaRadio.Text = "Java";
            this.javaRadio.UseVisualStyleBackColor = true;
            this.javaRadio.CheckedChanged += new System.EventHandler(this.javaRadio_CheckedChanged);
            // 
            // pcButton
            // 
            this.pcButton.Location = new System.Drawing.Point(646, 42);
            this.pcButton.Name = "pcButton";
            this.pcButton.Size = new System.Drawing.Size(187, 142);
            this.pcButton.TabIndex = 2;
            this.pcButton.Text = "Start";
            this.pcButton.UseVisualStyleBackColor = true;
            this.pcButton.Click += new System.EventHandler(this.pcButton_Click);
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(559, 16);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.projectNameTextBox.TabIndex = 3;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(479, 19);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.projectNameLabel.TabIndex = 4;
            this.projectNameLabel.Text = "Project Name:";
            // 
            // projectListBox
            // 
            this.projectListBox.FormattingEnabled = true;
            this.projectListBox.Location = new System.Drawing.Point(479, 51);
            this.projectListBox.Name = "projectListBox";
            this.projectListBox.Size = new System.Drawing.Size(161, 446);
            this.projectListBox.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(646, 355);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(187, 142);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(646, 197);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(187, 142);
            this.killButton.TabIndex = 7;
            this.killButton.Text = "Erase Selected";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // pcmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 536);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.projectListBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.pcButton);
            this.Controls.Add(this.projectBox);
            this.Controls.Add(this.preferencesBox);
            this.Name = "pcmFrame";
            this.Text = "Programming Environments Manager";
            this.preferencesBox.ResumeLayout(false);
            this.extraSoftwareBox.ResumeLayout(false);
            this.extraSoftwareBox.PerformLayout();
            this.browserBox.ResumeLayout(false);
            this.browserBox.PerformLayout();
            this.ftpBox.ResumeLayout(false);
            this.ftpBox.PerformLayout();
            this.shellInterfaceBox.ResumeLayout(false);
            this.shellInterfaceBox.PerformLayout();
            this.ideBox.ResumeLayout(false);
            this.webIDEBox.ResumeLayout(false);
            this.webIDEBox.PerformLayout();
            this.javaIDEBox.ResumeLayout(false);
            this.javaIDEBox.PerformLayout();
            this.pythonBox.ResumeLayout(false);
            this.pythonBox.PerformLayout();
            this.cBox.ResumeLayout(false);
            this.cBox.PerformLayout();
            this.projectBox.ResumeLayout(false);
            this.projectBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox preferencesBox;
        private System.Windows.Forms.GroupBox extraSoftwareBox;
        private System.Windows.Forms.GroupBox browserBox;
        private System.Windows.Forms.RadioButton waterfoxRadio;
        private System.Windows.Forms.RadioButton firefoxRadio;
        private System.Windows.Forms.RadioButton operaRadio;
        private System.Windows.Forms.RadioButton chromeRadio;
        private System.Windows.Forms.RadioButton edgeRadio;
        private System.Windows.Forms.GroupBox shellInterfaceBox;
        private System.Windows.Forms.RadioButton powerShellRadio;
        private System.Windows.Forms.RadioButton cmdRadio;
        private System.Windows.Forms.RadioButton xShellRadio;
        private System.Windows.Forms.GroupBox ftpBox;
        private System.Windows.Forms.RadioButton cyberduckRadio;
        private System.Windows.Forms.RadioButton xFTPRadio;
        private System.Windows.Forms.GroupBox ideBox;
        private System.Windows.Forms.GroupBox pythonBox;
        private System.Windows.Forms.RadioButton bracketsPythonRadio;
        private System.Windows.Forms.RadioButton sublimeTextPythonRadio;
        private System.Windows.Forms.GroupBox webIDEBox;
        private System.Windows.Forms.RadioButton netbeansWebRadio;
        private System.Windows.Forms.RadioButton visualStudioWebRadio;
        private System.Windows.Forms.RadioButton sublimeTextWebRadio;
        private System.Windows.Forms.RadioButton bracketsRadio;
        private System.Windows.Forms.GroupBox javaIDEBox;
        private System.Windows.Forms.RadioButton sublimeTextJavaRadio;
        private System.Windows.Forms.RadioButton netbeansJavaRadio;
        private System.Windows.Forms.RadioButton eclipseJavaRadio;
        private System.Windows.Forms.RadioButton phpStormRadio;
        private System.Windows.Forms.CheckBox githubCheck;
        private System.Windows.Forms.RadioButton eclipseWebRadio;
        private System.Windows.Forms.CheckBox mySQLCheck;
        private System.Windows.Forms.GroupBox cBox;
        private System.Windows.Forms.RadioButton eclipseCRadio;
        private System.Windows.Forms.RadioButton sublimeTextCRadio;
        private System.Windows.Forms.GroupBox projectBox;
        private System.Windows.Forms.RadioButton cRadio;
        private System.Windows.Forms.RadioButton cppRadio;
        private System.Windows.Forms.RadioButton csRadio;
        private System.Windows.Forms.RadioButton webRadio;
        private System.Windows.Forms.RadioButton phpRadio;
        private System.Windows.Forms.RadioButton jsRadio;
        private System.Windows.Forms.RadioButton pythonRadio;
        private System.Windows.Forms.RadioButton htmlRadio;
        private System.Windows.Forms.RadioButton javaRadio;
        private System.Windows.Forms.Button pcButton;
        private System.Windows.Forms.RadioButton visualStudioCRadio;
        private System.Windows.Forms.CheckBox xamppCheck;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.ListBox projectListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button killButton;
    }
}

