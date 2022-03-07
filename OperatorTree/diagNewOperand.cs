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
    public partial class diagNewOperand : Form
    {

        public int Operand { get; private set; }
        public bool OK { get; private set; }
        public diagNewOperand()
        {
            InitializeComponent();
        }

        private void txtNewOperand_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(txtNewOperand.Text, out i))
            {
                this.btnOK.Enabled = true;
                this.Operand = i;
            }
            else
            {
                this.btnOK.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.OK = true;
            this.Operand = int.Parse(txtNewOperand.Text);
            this.Dispose();
            Console.WriteLine("Add Operand");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.OK = false;
            this.Dispose();
        }
    }
}
