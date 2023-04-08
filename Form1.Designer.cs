namespace Formule_za_trougao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtStranicaA = new System.Windows.Forms.TextBox();
            this.txtStranicaB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStranicaC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtResenje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // txtStranicaA
            // 
            this.txtStranicaA.Location = new System.Drawing.Point(56, 46);
            this.txtStranicaA.Name = "txtStranicaA";
            this.txtStranicaA.Size = new System.Drawing.Size(116, 23);
            this.txtStranicaA.TabIndex = 1;
            // 
            // txtStranicaB
            // 
            this.txtStranicaB.Location = new System.Drawing.Point(56, 95);
            this.txtStranicaB.Name = "txtStranicaB";
            this.txtStranicaB.Size = new System.Drawing.Size(116, 23);
            this.txtStranicaB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // txtStranicaC
            // 
            this.txtStranicaC.Location = new System.Drawing.Point(56, 139);
            this.txtStranicaC.Name = "txtStranicaC";
            this.txtStranicaC.Size = new System.Drawing.Size(116, 23);
            this.txtStranicaC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "c =";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtResenje
            // 
            this.txtResenje.Location = new System.Drawing.Point(26, 263);
            this.txtResenje.Name = "txtResenje";
            this.txtResenje.Size = new System.Drawing.Size(198, 23);
            this.txtResenje.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 312);
            this.Controls.Add(this.txtResenje);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtStranicaC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStranicaB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStranicaA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formule za trougao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtStranicaA;
        private TextBox txtStranicaB;
        private Label label2;
        private TextBox txtStranicaC;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox txtResenje;
    }
}