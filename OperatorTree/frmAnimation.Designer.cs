namespace OperatorTree
{
    partial class frmAnimation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_prefix = new System.Windows.Forms.RadioButton();
            this.rbtn_Infix = new System.Windows.Forms.RadioButton();
            this.rbtn_postfix = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_postfix);
            this.groupBox1.Controls.Add(this.rbtn_Infix);
            this.groupBox1.Controls.Add(this.rbtn_prefix);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation auswählen";
            // 
            // rbtn_prefix
            // 
            this.rbtn_prefix.AutoSize = true;
            this.rbtn_prefix.Location = new System.Drawing.Point(6, 19);
            this.rbtn_prefix.Name = "rbtn_prefix";
            this.rbtn_prefix.Size = new System.Drawing.Size(51, 17);
            this.rbtn_prefix.TabIndex = 0;
            this.rbtn_prefix.TabStop = true;
            this.rbtn_prefix.Text = "Prefix";
            this.rbtn_prefix.UseVisualStyleBackColor = true;
            // 
            // rbtn_Infix
            // 
            this.rbtn_Infix.AutoSize = true;
            this.rbtn_Infix.Location = new System.Drawing.Point(6, 42);
            this.rbtn_Infix.Name = "rbtn_Infix";
            this.rbtn_Infix.Size = new System.Drawing.Size(44, 17);
            this.rbtn_Infix.TabIndex = 1;
            this.rbtn_Infix.TabStop = true;
            this.rbtn_Infix.Text = "Infix";
            this.rbtn_Infix.UseVisualStyleBackColor = true;
            // 
            // rbtn_postfix
            // 
            this.rbtn_postfix.AutoSize = true;
            this.rbtn_postfix.Location = new System.Drawing.Point(6, 65);
            this.rbtn_postfix.Name = "rbtn_postfix";
            this.rbtn_postfix.Size = new System.Drawing.Size(56, 17);
            this.rbtn_postfix.TabIndex = 2;
            this.rbtn_postfix.TabStop = true;
            this.rbtn_postfix.Text = "Postfix";
            this.rbtn_postfix.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(10, 101);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(129, 32);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Animation starten";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // frmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 137);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnimation";
            this.Text = "frmAnimation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_postfix;
        private System.Windows.Forms.RadioButton rbtn_Infix;
        private System.Windows.Forms.RadioButton rbtn_prefix;
        private System.Windows.Forms.Button btn_start;
    }
}