using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetComics_Comics_Converter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbCompressionType.Text = cbCompressionType.Items[0].ToString();
            cbOutputType.Text = cbOutputType.Items[0].ToString();
        }

        private void cbContainersOther_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContainersOther.Enabled == false)
                txtContainersOther.Enabled = true;
            else
                txtContainersOther.Enabled = false;
        }

        private void cbWebpCompressionLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (txtWebpCompressionLevel.Enabled == false)
                txtWebpCompressionLevel.Enabled = true;
            else
                txtWebpCompressionLevel.Enabled = false;
        }
    }
}
