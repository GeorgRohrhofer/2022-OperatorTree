namespace OperatorTree
{
    partial class diagNewOperator
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
            this.cmbNewOP = new System.Windows.Forms.ComboBox();
            this.lblNewOperatot = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNewOP
            // 
            this.cmbNewOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewOP.FormattingEnabled = true;
            this.cmbNewOP.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbNewOP.Location = new System.Drawing.Point(12, 25);
            this.cmbNewOP.Name = "cmbNewOP";
            this.cmbNewOP.Size = new System.Drawing.Size(252, 21);
            this.cmbNewOP.TabIndex = 0;
            this.cmbNewOP.SelectedIndexChanged += new System.EventHandler(this.cmbNewOP_SelectedIndexChanged);
            // 
            // lblNewOperatot
            // 
            this.lblNewOperatot.AutoSize = true;
            this.lblNewOperatot.Location = new System.Drawing.Point(79, 9);
            this.lblNewOperatot.Name = "lblNewOperatot";
            this.lblNewOperatot.Size = new System.Drawing.Size(122, 13);
            this.lblNewOperatot.TabIndex = 1;
            this.lblNewOperatot.Text = "Neuer Operator erstellen";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(107, 50);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // diagNewOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 77);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNewOperatot);
            this.Controls.Add(this.cmbNewOP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "diagNewOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "diagNewOperator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNewOP;
        private System.Windows.Forms.Label lblNewOperatot;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}