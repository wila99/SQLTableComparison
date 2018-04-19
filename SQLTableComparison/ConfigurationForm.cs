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
            SqlDataSourceEnumerator sqlDataSource = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = sqlDataSource.GetDataSources();
     
        }

        private void SourceServerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
    
        }
    }
}
