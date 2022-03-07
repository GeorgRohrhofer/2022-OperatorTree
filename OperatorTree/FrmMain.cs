using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTree
{
    public partial class FrmMain : Form
    {
        private OperatorTree opt = new OperatorTree();

        private Node currNode;
        private Node destNode;

        private int posx, posy;

        private bool isMoving = false;
        private bool isConnecting;

        private frmAnimation frma;


        public FrmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            opt.Repaint += Repaint;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.opt.clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Operator Tree File | *.otf";
            ofd.InitialDirectory = @"C:\Temp";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
                opt = (OperatorTree)formatter.Deserialize(stream);
                opt.Repaint += Repaint;
                stream.Close();
                opt.ResetColor();

                Invalidate();
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Operator Tree File | *.otf";
            sfd.InitialDirectory = @"C:\Temp";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                opt.Repaint -= Repaint;
                formatter.Serialize(stream, opt);
                opt.Repaint += Repaint;
                stream.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (isConnecting)
            {
                e.Graphics.DrawLine(Pens.Black, currNode.X, currNode.Y, posx, posy);
            }
            opt.Paint(e.Graphics);

            this.lblIsValid.Text = this.opt.testValid() + "";
            this.lblInfix.Text = this.opt.getInfix();
            this.lblPrefix.Text = this.opt.getPrefix();
            this.lblPostfix.Text = this.opt.getPostfix();
        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagNewOperator newOP = new diagNewOperator();
            newOP.ShowDialog();

            if (newOP.OK)
            {
                opt.addNode(new Operator(posx, posy, newOP.OP));
                Refresh();
            }
        }

        private void operandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagNewOperand newOP = new diagNewOperand();
            newOP.ShowDialog();

            if (newOP.OK)
            {
                opt.addNode(new Operand(posx, posy, newOP.Operand));
                Refresh();
            }
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {

                this.currNode.move(e.X - posx, e.Y - posy);

                this.posx = e.X;
                this.posy = e.Y;
            }

            if (isConnecting)
            {
                posx = e.X;
                posy = e.Y;
            }


            Refresh();


        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (isConnecting)
            {
                destNode = opt.getNode(e.X, e.Y);
                if(destNode != null)
                {
                    opt.setChild(currNode, destNode);
                }
            }
            if(isConnecting || isMoving)
            {
                this.isMoving = false;
                this.isConnecting = false;
                this.currNode = null;
                this.destNode = null;

                Refresh();
            }
            
        }

        private void animationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.animationToolStripMenuItem.Checked)
            {
                frma.Dispose();
                frma = null;
            }
            else
            {
                frma = new frmAnimation();
                frma.StartAnimationStyleEvent += new StartAnimationStyle(startAnimation);
                frma.Show();
            }
            Reposition();
            
        }

        private void startAnimation(string Style)
        {
            if(Style == "Prefix")
            {
                this.opt.run(0);
            }
            if (Style == "Infix")
            {
                this.opt.run(1);
            }
            if (Style == "Postfix")
            {
                this.opt.run(2);
            }
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
                posx = e.X;
                posy = e.Y;
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    Console.WriteLine("CTRL pressed");
                    currNode = opt.getNode(e.X, e.Y);

                    if (currNode != null)
                    {
                        isMoving = true;
                        posx = e.X;
                        posy = e.Y;
                    }
                    
                }
                else
                {
                    currNode = opt.getNode(e.X, e.Y);

                    if (currNode != null)
                    {
                        Console.WriteLine("Connecting");
                        isConnecting = true;
                        posx = e.X;
                        posy = e.Y;
                    }
                }
            }

        }

        private void Repaint()
        {
            this.Invalidate();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            Reposition();
        }

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {
            Reposition();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Reposition()
        {
            if (frma != null)
            {
                frma.Left = this.Left + this.Width;
                frma.Top = this.Top + this.Height / 2 - frma.Height / 2;
            }
        }
    }
}
