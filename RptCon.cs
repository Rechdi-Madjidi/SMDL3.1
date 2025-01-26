using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDL
{
    public partial class RptCon : Form
    {
        public RptCon()
        {
            InitializeComponent();
        }

        private void RptCon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SMDLDBDataSet.Consultaton' table. You can move, or remove it, as needed.
           // this.ConsultatonTableAdapter.Fill(this.SMDLDBDataSet.Consultaton);

            this.reportViewer1.RefreshReport();
        }
    }
}
