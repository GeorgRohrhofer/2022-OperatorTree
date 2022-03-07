using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    class OperatorTree
    {
        public const int PREFIX = 0;
        public const int INFIX = 1;
        public const int POSTFIX = 2;

        public const int DELAY = 1000;

        public List<Node> nodes;

        [NonSerialized] private Thread t;

        public event RepaintEvent Repaint;

        public Node root { set; get; }

        public OperatorTree()
        {
            nodes = new List<Node>();
        }

        public void Paint(Graphics g)
        {
            foreach (Node n in nodes)
            {
                if (n.GetType() == typeof(Operator))
                {
                    Operator op = (Operator)n;

                    if (op.Left != null)
                    {
                        g.DrawLine(Pens.Black, op.X, op.Y, op.Left.X, op.Left.Y);
                    }

                    if (op.Right != null)
                    {
                        g.DrawLine(Pens.Black, op.X, op.Y, op.Right.X, op.Right.Y);
                    }
                }
            }

            foreach (Node n2 in nodes)
            {
                n2.Paint(g);
            }
        }

        public Node getNode(int x, int y)
        {
            foreach (Node n in nodes)
            {
                if (n.InNode(x, y))
                {
                    return n;
                }
            }
            return null;
        }

        public void addNode(Node newNode)
        {
            foreach (Node n in nodes)
            {
                if (n.InNode(newNode.X, newNode.Y))
                {
                    return;
                }
            }
            if (root == null || newNode.Y < root.Y)
            {
                root = newNode;
            }

            nodes.Add(newNode);
            Console.WriteLine("Node added");

        }

        public void setChild(Node n1, Node n2)
        {
            Node parent;
            Node child;
            if (n1.Y < n2.Y)
            {
                parent = n1;
                child = n2;
            }
            else
            {
                parent = n2;
                child = n1;
            }

            if (parent.GetType() == typeof(Operand))
            {
                return;
            }

            else if (child.X < parent.X)
            {
                Operator p = (Operator)parent;
                if (p.Left == null && child.Parent == null)
                {
                    p.Left = child;
                    child.Parent = p;
                }

            }
            else if (child.X > parent.X)
            {
                Operator p = (Operator)parent;
                if (p.Right == null && child.Parent == null)
                {
                    p.Right = child;
                    child.Parent = p;
                }

            }

        }

        public bool testValid()
        {
            int counter = 0;
            foreach (Node n in nodes)
            {
                if (n.Parent == null)
                {
                    counter++;
                }
                if (n.GetType() == typeof(Operator))
                {
                    Operator op = (Operator)n;
                    if (op.Left == null || op.Right == null)
                        return false;
                }
            }

            return counter == 1;
        }

        public void clear()
        {
            this.nodes.Clear();
            this.root = null;
        }


        public string getInfix()
        {
            if (testValid())
                return getInfix(root);
            return "";
        }

        private string getInfix(Node n)
        {
            if (n.GetType() == typeof(Operand))
            {
                return ((Operand)n).Value.ToString() ?? "";
            }
            Operator @operator = (Operator)n;
            return "(" + getInfix(@operator.Left) + " " + @operator.OP + " " + getInfix(@operator.Right) + ")";
        }

        public string getPrefix()
        {
            if (testValid())
                return getPrefix(root);
            return "";
        }

        private string getPrefix(Node n)
        {
            if (n.GetType() == typeof(Operand))
            {
                return ((Operand)n).Value.ToString() ?? "";
            }
            Operator @operator = (Operator)n;
            return @operator.OP + " " + getPrefix(@operator.Left) + " " + getPrefix(@operator.Right);
        }

        public string getPostfix()
        {
            if (testValid())
                return getPostfix(root);
            return "";
        }

        private string getPostfix(Node n)
        {
            if (n.GetType() == typeof(Operand))
            {
                return ((Operand)n).Value.ToString() ?? "";
            }
            Operator @operator = (Operator)n;
            return getPostfix(@operator.Left) + " " + getPostfix(@operator.Right) + " " + @operator.OP;
        }

        public void run(int mode)
        {
            if (!this.testValid())
            {
                return;
            }

            if(mode == PREFIX)
            {
                t = new Thread(new ParameterizedThreadStart(GoPrefix));
            }
            else if (mode == INFIX)
            {
                t = new Thread(new ParameterizedThreadStart(GoInfix));
            }
            else if (mode == POSTFIX)
            {
                t = new Thread(new ParameterizedThreadStart(GoPostfix));
            }

            t.Start(root);
        }

        public void GoPrefix(object o)
        {
            Node node = (Node)o;
            if (node.GetType() == typeof(Operand))
            {
                ResetColor();
                node.Col = Color.Red;
                this.Repaint();
                Thread.Sleep(DELAY);
                ResetColor();
                this.Repaint();
            }
            else
            {
                ResetColor();
                node.Col = Color.Red;
                this.Repaint();
                Thread.Sleep(DELAY);
                GoPrefix(((Operator)node).Left);
                GoPrefix(((Operator)node).Right);
                ResetColor();
                this.Repaint();
            }
        }

        public void GoInfix(object o)
        {
            Node node = (Node)o;
            if (node.GetType() == typeof(Operand))
            {
                ResetColor();
                node.Col = Color.Red;
                this.Repaint();
                Thread.Sleep(DELAY);
                ResetColor();
                this.Repaint();
            }
            else
            {
                GoInfix(((Operator)node).Left);
                ResetColor();
                node.Col = Color.Red;
                this.Repaint(); 
                Thread.Sleep(DELAY);
                GoInfix(((Operator)node).Right);
                ResetColor();
                this.Repaint();
            }
        }

        public void GoPostfix(object o)
        {
            Node node = (Node)o;
            if (node.GetType() == typeof(Operand))
            {
                ResetColor();
                node.Col = Color.Red;
                this.Repaint();
                Thread.Sleep(DELAY);
                ResetColor();
                this.Repaint();
            }
            else
            {
                GoPostfix(((Operator)node).Left);
                ResetColor();
                this.Repaint();
                GoPostfix(((Operator)node).Right);
                ResetColor();
                node.Col = Color.Red;
                this.Repaint(); 
                Thread.Sleep(DELAY);
                ResetColor();
                this.Repaint();
            }
        }

        public void ResetColor()
        {
            foreach (Node node in nodes)
            {
                node.Col = Color.Black;
            }
        }
    }

}
