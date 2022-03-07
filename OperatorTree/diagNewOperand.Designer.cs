namespace OperatorTree
{
    partial class diagNewOperand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewOperand = new System.Windows.Forms.TextBox();
            this.lblNewOperand = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewOperand
            // 
            this.txtNewOperand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewOperand.Location = new System.Drawing.Point(12, 21);
            this.txtNewOperand.Name = "txtNewOperand";
            this.txtNewOperand.Size = new System.Drawing.Size(173, 20);
            this.txtNewOperand.TabIndex = 0;
            this.txtNewOperand.TextChanged += new System.EventHandler(this.txtNewOperand_TextChanged);
            // 
            // lblNewOperand
            // 
            this.lblNewOperand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewOperand.AutoSize = true;
            this.lblNewOperand.Location = new System.Drawing.Point(45, 5);
            this.lblNewOperand.Name = "lblNewOperand";
            this.lblNewOperand.Size = new System.Drawing.Size(90, 13);
            this.lblNewOperand.TabIndex = 1;
            this.lblNewOperand.Text = "Operand erstellen";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(29, 65);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // diagNewOperand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 105);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewOperand);
            this.Controls.Add(this.txtNewOperand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "diagNewOperand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "diagNewOperand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewOperand;
        private System.Windows.Forms.Label lblNewOperand;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}