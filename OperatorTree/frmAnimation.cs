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
    public delegate void StartAnimationStyle(string style);

    public partial class frmAnimation : Form
    {
        public string Style { get; set; }


        public event StartAnimationStyle StartAnimationStyleEvent;
        public frmAnimation()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (this.rbtn_prefix.Checked)
            {
                this.Style = "Prefix";
            }
            else if (this.rbtn_Infix.Checked)
            {
                this.Style = "Infix";
            }
            else if (this.rbtn_postfix.Checked)
            {
                this.Style = "Postfix";
            }

            StartAnimationStyleEvent(this.Style);
        }
    }
}
