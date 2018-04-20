using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.Sql;

namespace SQLTableComparison
{
    public partial class ConfigurationForm : MetroFramework.Forms.MetroForm
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            SourceServerComboBox.Items.Add("Test");
            foreach (DataRow test in servers.Rows)
            {
                foreach (DataColumn item in servers.Columns)
                {
                    SourceServerComboBox.Items.Add(test[servers.Columns["Server Name"]].ToString());
                }
            }
        }

        private void SourceSesrverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceServerNameLabel.Text = SourceServerComboBox.Text;

        }

        private void DatabaseConfigurationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SourceServerNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


