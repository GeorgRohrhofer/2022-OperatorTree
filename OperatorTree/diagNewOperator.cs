using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTree
{
    public partial class diagNewOperator : Form
    {
        public bool OK { get; private set;}
        public string OP { get; private set; }


        public diagNewOperator()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.OK = true;
            this.OP = this.cmbNewOP.SelectedItem + "";
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.OK = false;
        }

        private void cmbNewOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnOk.Enabled = true;
        }
    }
}
