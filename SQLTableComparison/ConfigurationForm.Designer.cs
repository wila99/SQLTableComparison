namespace SQLTableComparison
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.SourceLabel = new MetroFramework.Controls.MetroLabel();
            this.TargetLabel = new MetroFramework.Controls.MetroLabel();
            this.DatabaseDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceServerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceDatabaseName = new MetroFramework.Controls.MetroLabel();
            this.TargetServerNameLabel = new MetroFramework.Controls.MetroLabel();
            this.TargetDatabaseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DatabaseConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.SourceConnectionLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceServerLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceServerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SourceUsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.SourcePasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.SourceUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SourcePasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.SourceTestConnection = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CompareTablesButton = new MetroFramework.Controls.MetroButton();
            this.SourceDatabaseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SourceTableComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TargetTableComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TargetDatabaseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TargetTestConnection = new MetroFramework.Controls.MetroButton();
            this.SourcePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.TargetUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TargetServerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.TargetServerLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DatabaseDetailsGroupBox.SuspendLayout();
            this.DatabaseConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SourceLabel.Location = new System.Drawing.Point(422, 16);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(70, 25);
            this.SourceLabel.TabIndex = 0;
            this.SourceLabel.Text = "Source";
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TargetLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TargetLabel.Location = new System.Drawing.Point(587, 16);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(66, 25);
            this.TargetLabel.TabIndex = 1;
            this.TargetLabel.Text = "Target";
            // 
            // DatabaseDetailsGroupBox
            // 
            this.DatabaseDetailsGroupBox.Controls.Add(this.pictureBox2);
            this.DatabaseDetailsGroupBox.Controls.Add(this.pictureBox1);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetServerNameLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetDatabaseNameLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceServerNameLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceDatabaseName);
            this.DatabaseDetailsGroupBox.Controls.Add(this.TargetLabel);
            this.DatabaseDetailsGroupBox.Controls.Add(this.SourceLabel);
            this.DatabaseDetailsGroupBox.Location = new System.Drawing.Point(23, 63);
            this.DatabaseDetailsGroupBox.Name = "DatabaseDetailsGroupBox";
            this.DatabaseDetailsGroupBox.Size = new System.Drawing.Size(1075, 136);
            this.DatabaseDetailsGroupBox.TabIndex = 2;
            this.DatabaseDetailsGroupBox.TabStop = false;
            // 
            // SourceServerNameLabel
            // 
            this.SourceServerNameLabel.AutoSize = true;
            this.SourceServerNameLabel.Location = new System.Drawing.Point(57, 83);
            this.SourceServerNameLabel.Name = "SourceServerNameLabel";
            this.SourceServerNameLabel.Size = new System.Drawing.Size(81, 19);
            this.SourceServerNameLabel.TabIndex = 3;
            this.SourceServerNameLabel.Text = "metroLabel1";
            // 
            // SourceDatabaseName
            // 
            this.SourceDatabaseName.AutoSize = true;
            this.SourceDatabaseName.Location = new System.Drawing.Point(57, 102);
            this.SourceDatabaseName.Name = "SourceDatabaseName";
            this.SourceDatabaseName.Size = new System.Drawing.Size(83, 19);
            this.SourceDatabaseName.TabIndex = 4;
            this.SourceDatabaseName.Text = "metroLabel2";
            // 
            // TargetServerNameLabel
            // 
            this.TargetServerNameLabel.AutoSize = true;
            this.TargetServerNameLabel.Location = new System.Drawing.Point(915, 83);
            this.TargetServerNameLabel.Name = "TargetServerNameLabel";
            this.TargetServerNameLabel.Size = new System.Drawing.Size(81, 19);
            this.TargetServerNameLabel.TabIndex = 5;
            this.TargetServerNameLabel.Text = "metroLabel1";
            // 
            // TargetDatabaseNameLabel
            // 
            this.TargetDatabaseNameLabel.AutoSize = true;
            this.TargetDatabaseNameLabel.Location = new System.Drawing.Point(913, 102);
            this.TargetDatabaseNameLabel.Name = "TargetDatabaseNameLabel";
            this.TargetDatabaseNameLabel.Size = new System.Drawing.Size(83, 19);
            this.TargetDatabaseNameLabel.TabIndex = 6;
            this.TargetDatabaseNameLabel.Text = "metroLabel2";
            // 
            // DatabaseConfigurationGroupBox
            // 
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetTableComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetDatabaseComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel4);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel5);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetTestConnection);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourcePasswordTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetUsernameTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel6);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel7);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetServerComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.TargetServerLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceTableComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceDatabaseComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel3);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel2);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.metroLabel1);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceTestConnection);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourcePasswordBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceUsernameTextBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourcePasswordLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceUsernameLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceServerComboBox);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceServerLabel);
            this.DatabaseConfigurationGroupBox.Controls.Add(this.SourceConnectionLabel);
            this.DatabaseConfigurationGroupBox.Location = new System.Drawing.Point(23, 205);
            this.DatabaseConfigurationGroupBox.Name = "DatabaseConfigurationGroupBox";
            this.DatabaseConfigurationGroupBox.Size = new System.Drawing.Size(1075, 382);
            this.DatabaseConfigurationGroupBox.TabIndex = 3;
            this.DatabaseConfigurationGroupBox.TabStop = false;
            // 
            // SourceConnectionLabel
            // 
            this.SourceConnectionLabel.AutoSize = true;
            this.SourceConnectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceConnectionLabel.Location = new System.Drawing.Point(6, 26);
            this.SourceConnectionLabel.Name = "SourceConnectionLabel";
            this.SourceConnectionLabel.Size = new System.Drawing.Size(211, 25);
            this.SourceConnectionLabel.TabIndex = 0;
            this.SourceConnectionLabel.Text = "Source Connection Details";
            // 
            // SourceServerLabel
            // 
            this.SourceServerLabel.AutoSize = true;
            this.SourceServerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SourceServerLabel.Location = new System.Drawing.Point(16, 81);
            this.SourceServerLabel.Name = "SourceServerLabel";
            this.SourceServerLabel.Size = new System.Drawing.Size(60, 25);
            this.SourceServerLabel.TabIndex = 1;
            this.SourceServerLabel.Text = "Server";
            // 
            // SourceServerComboBox
            // 
            this.SourceServerComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.SourceServerComboBox.FormattingEnabled = true;
            this.SourceServerComboBox.ItemHeight = 19;
            this.SourceServerComboBox.Location = new System.Drawing.Point(40, 109);
            this.SourceServerComboBox.Name = "SourceServerComboBox";
            this.SourceServerComboBox.Size = new System.Drawing.Size(384, 25);
            this.SourceServerComboBox.TabIndex = 2;
            this.SourceServerComboBox.UseSelectable = true;
            this.SourceServerComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceServerComboBox_SelectedIndexChanged);
            // 
            // SourceUsernameLabel
            // 
            this.SourceUsernameLabel.AutoSize = true;
            this.SourceUsernameLabel.Location = new System.Drawing.Point(40, 144);
            this.SourceUsernameLabel.Name = "SourceUsernameLabel";
            this.SourceUsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.SourceUsernameLabel.TabIndex = 3;
            this.SourceUsernameLabel.Text = "Username";
            // 
            // SourcePasswordLabel
            // 
            this.SourcePasswordLabel.AutoSize = true;
            this.SourcePasswordLabel.Location = new System.Drawing.Point(40, 173);
            this.SourcePasswordLabel.Name = "SourcePasswordLabel";
            this.SourcePasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.SourcePasswordLabel.TabIndex = 4;
            this.SourcePasswordLabel.Text = "Password";
            // 
            // SourceUsernameTextBox
            // 
            // 
            // 
            // 
            this.SourceUsernameTextBox.CustomButton.Image = null;
            this.SourceUsernameTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.SourceUsernameTextBox.CustomButton.Name = "";
            this.SourceUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourceUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourceUsernameTextBox.CustomButton.TabIndex = 1;
            this.SourceUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourceUsernameTextBox.CustomButton.UseSelectable = true;
            this.SourceUsernameTextBox.CustomButton.Visible = false;
            this.SourceUsernameTextBox.Lines = new string[0];
            this.SourceUsernameTextBox.Location = new System.Drawing.Point(114, 144);
            this.SourceUsernameTextBox.MaxLength = 32767;
            this.SourceUsernameTextBox.Name = "SourceUsernameTextBox";
            this.SourceUsernameTextBox.PasswordChar = '\0';
            this.SourceUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceUsernameTextBox.SelectedText = "";
            this.SourceUsernameTextBox.SelectionLength = 0;
            this.SourceUsernameTextBox.SelectionStart = 0;
            this.SourceUsernameTextBox.ShortcutsEnabled = true;
            this.SourceUsernameTextBox.Size = new System.Drawing.Size(310, 23);
            this.SourceUsernameTextBox.TabIndex = 5;
            this.SourceUsernameTextBox.UseSelectable = true;
            this.SourceUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourceUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourcePasswordBox
            // 
            // 
            // 
            // 
            this.SourcePasswordBox.CustomButton.Image = null;
            this.SourcePasswordBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.SourcePasswordBox.CustomButton.Name = "";
            this.SourcePasswordBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourcePasswordBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourcePasswordBox.CustomButton.TabIndex = 1;
            this.SourcePasswordBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourcePasswordBox.CustomButton.UseSelectable = true;
            this.SourcePasswordBox.CustomButton.Visible = false;
            this.SourcePasswordBox.Lines = new string[0];
            this.SourcePasswordBox.Location = new System.Drawing.Point(114, 173);
            this.SourcePasswordBox.MaxLength = 32767;
            this.SourcePasswordBox.Name = "SourcePasswordBox";
            this.SourcePasswordBox.PasswordChar = '\0';
            this.SourcePasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourcePasswordBox.SelectedText = "";
            this.SourcePasswordBox.SelectionLength = 0;
            this.SourcePasswordBox.SelectionStart = 0;
            this.SourcePasswordBox.ShortcutsEnabled = true;
            this.SourcePasswordBox.Size = new System.Drawing.Size(310, 23);
            this.SourcePasswordBox.TabIndex = 6;
            this.SourcePasswordBox.UseSelectable = true;
            this.SourcePasswordBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourcePasswordBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SourceTestConnection
            // 
            this.SourceTestConnection.Location = new System.Drawing.Point(114, 202);
            this.SourceTestConnection.Name = "SourceTestConnection";
            this.SourceTestConnection.Size = new System.Drawing.Size(103, 23);
            this.SourceTestConnection.TabIndex = 7;
            this.SourceTestConnection.Text = "Test Connection";
            this.SourceTestConnection.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(619, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Target Connection Details";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(16, 241);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Database";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(16, 297);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Table";
            // 
            // CompareTablesButton
            // 
            this.CompareTablesButton.Location = new System.Drawing.Point(934, 593);
            this.CompareTablesButton.Name = "CompareTablesButton";
            this.CompareTablesButton.Size = new System.Drawing.Size(164, 33);
            this.CompareTablesButton.TabIndex = 4;
            this.CompareTablesButton.Text = "Compare Tables";
            this.CompareTablesButton.UseSelectable = true;
            // 
            // SourceDatabaseComboBox
            // 
            this.SourceDatabaseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.SourceDatabaseComboBox.FormattingEnabled = true;
            this.SourceDatabaseComboBox.ItemHeight = 19;
            this.SourceDatabaseComboBox.Location = new System.Drawing.Point(40, 269);
            this.SourceDatabaseComboBox.Name = "SourceDatabaseComboBox";
            this.SourceDatabaseComboBox.Size = new System.Drawing.Size(384, 25);
            this.SourceDatabaseComboBox.TabIndex = 11;
            this.SourceDatabaseComboBox.UseSelectable = true;
            // 
            // SourceTableComboBox
            // 
            this.SourceTableComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.SourceTableComboBox.FormattingEnabled = true;
            this.SourceTableComboBox.ItemHeight = 19;
            this.SourceTableComboBox.Location = new System.Drawing.Point(40, 325);
            this.SourceTableComboBox.Name = "SourceTableComboBox";
            this.SourceTableComboBox.Size = new System.Drawing.Size(384, 25);
            this.SourceTableComboBox.TabIndex = 12;
            this.SourceTableComboBox.UseSelectable = true;
            // 
            // TargetTableComboBox
            // 
            this.TargetTableComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.TargetTableComboBox.FormattingEnabled = true;
            this.TargetTableComboBox.ItemHeight = 19;
            this.TargetTableComboBox.Location = new System.Drawing.Point(619, 325);
            this.TargetTableComboBox.Name = "TargetTableComboBox";
            this.TargetTableComboBox.Size = new System.Drawing.Size(384, 25);
            this.TargetTableComboBox.TabIndex = 23;
            this.TargetTableComboBox.UseSelectable = true;
            // 
            // TargetDatabaseComboBox
            // 
            this.TargetDatabaseComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.TargetDatabaseComboBox.FormattingEnabled = true;
            this.TargetDatabaseComboBox.ItemHeight = 19;
            this.TargetDatabaseComboBox.Location = new System.Drawing.Point(619, 269);
            this.TargetDatabaseComboBox.Name = "TargetDatabaseComboBox";
            this.TargetDatabaseComboBox.Size = new System.Drawing.Size(384, 25);
            this.TargetDatabaseComboBox.TabIndex = 22;
            this.TargetDatabaseComboBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(595, 297);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Table";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(595, 241);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 25);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Database";
            // 
            // TargetTestConnection
            // 
            this.TargetTestConnection.Location = new System.Drawing.Point(693, 202);
            this.TargetTestConnection.Name = "TargetTestConnection";
            this.TargetTestConnection.Size = new System.Drawing.Size(103, 23);
            this.TargetTestConnection.TabIndex = 19;
            this.TargetTestConnection.Text = "Test Connection";
            this.TargetTestConnection.UseSelectable = true;
            // 
            // SourcePasswordTextBox
            // 
            // 
            // 
            // 
            this.SourcePasswordTextBox.CustomButton.Image = null;
            this.SourcePasswordTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.SourcePasswordTextBox.CustomButton.Name = "";
            this.SourcePasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SourcePasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SourcePasswordTextBox.CustomButton.TabIndex = 1;
            this.SourcePasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SourcePasswordTextBox.CustomButton.UseSelectable = true;
            this.SourcePasswordTextBox.CustomButton.Visible = false;
            this.SourcePasswordTextBox.Lines = new string[0];
            this.SourcePasswordTextBox.Location = new System.Drawing.Point(693, 173);
            this.SourcePasswordTextBox.MaxLength = 32767;
            this.SourcePasswordTextBox.Name = "SourcePasswordTextBox";
            this.SourcePasswordTextBox.PasswordChar = '\0';
            this.SourcePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourcePasswordTextBox.SelectedText = "";
            this.SourcePasswordTextBox.SelectionLength = 0;
            this.SourcePasswordTextBox.SelectionStart = 0;
            this.SourcePasswordTextBox.ShortcutsEnabled = true;
            this.SourcePasswordTextBox.Size = new System.Drawing.Size(310, 23);
            this.SourcePasswordTextBox.TabIndex = 18;
            this.SourcePasswordTextBox.UseSelectable = true;
            this.SourcePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SourcePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TargetUsernameTextBox
            // 
            // 
            // 
            // 
            this.TargetUsernameTextBox.CustomButton.Image = null;
            this.TargetUsernameTextBox.CustomButton.Location = new System.Drawing.Point(288, 1);
            this.TargetUsernameTextBox.CustomButton.Name = "";
            this.TargetUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TargetUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TargetUsernameTextBox.CustomButton.TabIndex = 1;
            this.TargetUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TargetUsernameTextBox.CustomButton.UseSelectable = true;
            this.TargetUsernameTextBox.CustomButton.Visible = false;
            this.TargetUsernameTextBox.Lines = new string[0];
            this.TargetUsernameTextBox.Location = new System.Drawing.Point(693, 144);
            this.TargetUsernameTextBox.MaxLength = 32767;
            this.TargetUsernameTextBox.Name = "TargetUsernameTextBox";
            this.TargetUsernameTextBox.PasswordChar = '\0';
            this.TargetUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TargetUsernameTextBox.SelectedText = "";
            this.TargetUsernameTextBox.SelectionLength = 0;
            this.TargetUsernameTextBox.SelectionStart = 0;
            this.TargetUsernameTextBox.ShortcutsEnabled = true;
            this.TargetUsernameTextBox.Size = new System.Drawing.Size(310, 23);
            this.TargetUsernameTextBox.TabIndex = 17;
            this.TargetUsernameTextBox.UseSelectable = true;
            this.TargetUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TargetUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(619, 173);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(63, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Password";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(619, 144);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Username";
            // 
            // TargetServerComboBox
            // 
            this.TargetServerComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.TargetServerComboBox.FormattingEnabled = true;
            this.TargetServerComboBox.ItemHeight = 19;
            this.TargetServerComboBox.Location = new System.Drawing.Point(619, 109);
            this.TargetServerComboBox.Name = "TargetServerComboBox";
            this.TargetServerComboBox.Size = new System.Drawing.Size(384, 25);
            this.TargetServerComboBox.TabIndex = 14;
            this.TargetServerComboBox.UseSelectable = true;
            // 
            // TargetServerLabel
            // 
            this.TargetServerLabel.AutoSize = true;
            this.TargetServerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TargetServerLabel.Location = new System.Drawing.Point(595, 81);
            this.TargetServerLabel.Name = "TargetServerLabel";
            this.TargetServerLabel.Size = new System.Drawing.Size(60, 25);
            this.TargetServerLabel.TabIndex = 13;
            this.TargetServerLabel.Text = "Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 53);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 649);
            this.Controls.Add(this.CompareTablesButton);
            this.Controls.Add(this.DatabaseConfigurationGroupBox);
            this.Controls.Add(this.DatabaseDetailsGroupBox);
            this.Name = "ConfigurationForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SQL Table Comparison";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.DatabaseDetailsGroupBox.ResumeLayout(false);
            this.DatabaseDetailsGroupBox.PerformLayout();
            this.DatabaseConfigurationGroupBox.ResumeLayout(false);
            this.DatabaseConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel SourceLabel;
        private MetroFramework.Controls.MetroLabel TargetLabel;
        private System.Windows.Forms.GroupBox DatabaseDetailsGroupBox;
        private MetroFramework.Controls.MetroLabel SourceServerNameLabel;
        private MetroFramework.Controls.MetroLabel SourceDatabaseName;
        private MetroFramework.Controls.MetroLabel TargetServerNameLabel;
        private MetroFramework.Controls.MetroLabel TargetDatabaseNameLabel;
        private System.Windows.Forms.GroupBox DatabaseConfigurationGroupBox;
        private MetroFramework.Controls.MetroComboBox SourceServerComboBox;
        private MetroFramework.Controls.MetroLabel SourceServerLabel;
        private MetroFramework.Controls.MetroLabel SourceConnectionLabel;
        private MetroFramework.Controls.MetroTextBox SourcePasswordBox;
        private MetroFramework.Controls.MetroTextBox SourceUsernameTextBox;
        private MetroFramework.Controls.MetroLabel SourcePasswordLabel;
        private MetroFramework.Controls.MetroLabel SourceUsernameLabel;
        private MetroFramework.Controls.MetroButton SourceTestConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox TargetTableComboBox;
        private MetroFramework.Controls.MetroComboBox TargetDatabaseComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton TargetTestConnection;
        private MetroFramework.Controls.MetroTextBox SourcePasswordTextBox;
        private MetroFramework.Controls.MetroTextBox TargetUsernameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox TargetServerComboBox;
        private MetroFramework.Controls.MetroLabel TargetServerLabel;
        private MetroFramework.Controls.MetroComboBox SourceTableComboBox;
        private MetroFramework.Controls.MetroComboBox SourceDatabaseComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton CompareTablesButton;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

