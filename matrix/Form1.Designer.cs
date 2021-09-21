
namespace matrix
{
    partial class Form1
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
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.cmdP = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmdChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdChange);
            this.groupBox1.Controls.Add(this.rtxt);
            this.groupBox1.Controls.Add(this.cmdP);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Location = new System.Drawing.Point(792, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // rtxt
            // 
            this.rtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxt.Location = new System.Drawing.Point(7, 89);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(204, 333);
            this.rtxt.TabIndex = 2;
            this.rtxt.Text = "";
            // 
            // cmdP
            // 
            this.cmdP.Location = new System.Drawing.Point(6, 56);
            this.cmdP.Name = "cmdP";
            this.cmdP.Size = new System.Drawing.Size(205, 27);
            this.cmdP.TabIndex = 1;
            this.cmdP.Text = "Criar matriz";
            this.cmdP.UseVisualStyleBackColor = true;
            this.cmdP.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(109, 30);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(102, 20);
            this.txtColor.TabIndex = 1;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(6, 30);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(97, 20);
            this.txtSize.TabIndex = 0;
            // 
            // cmdChange
            // 
            this.cmdChange.BackColor = System.Drawing.SystemColors.Control;
            this.cmdChange.Location = new System.Drawing.Point(7, 428);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(203, 25);
            this.cmdChange.TabIndex = 3;
            this.cmdChange.Text = "Trocar célula";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 483);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button cmdP;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button cmdChange;
    }
}