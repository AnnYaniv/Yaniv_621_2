using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInterface
{
    // ToDo: #3 Control for ConfigReader(uses config files)
    public partial class ConfigControl : UserControl
    {
        public ConfigControl()
        {
            InitializeComponent();

            if(config.AllowAddWithFK) radioButton1.Checked = true;
            else radioButton2.Checked = true;

            if (config.AllowDeleteWithFK) radioButton4.Checked = true;
            else radioButton3.Checked = true;
        }

        private ConfigReader config = ConfigReader.getInstance();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowAddWithFK = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            config.AllowDeleteWithFK = radioButton4.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
