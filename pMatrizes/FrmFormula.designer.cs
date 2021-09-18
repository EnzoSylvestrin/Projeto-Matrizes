namespace WindowsFormsApplication1
{
    partial class FrmFormula
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
            this.components = new System.ComponentModel.Container();
            this.grpFormula = new System.Windows.Forms.GroupBox();
            this.mskTabela = new System.Windows.Forms.MaskedTextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.errinho = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEx = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblSomaE = new System.Windows.Forms.Label();
            this.lblTraco = new System.Windows.Forms.Label();
            this.lblTr = new System.Windows.Forms.Label();
            this.lblTracoSec = new System.Windows.Forms.Label();
            this.lblTrSec = new System.Windows.Forms.Label();
            this.grpFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFormula
            // 
            this.grpFormula.Controls.Add(this.mskTabela);
            this.grpFormula.Controls.Add(this.lblTabela);
            this.grpFormula.Controls.Add(this.btnGerar);
            this.grpFormula.Controls.Add(this.txtForm);
            this.grpFormula.Location = new System.Drawing.Point(321, 29);
            this.grpFormula.Name = "grpFormula";
            this.grpFormula.Size = new System.Drawing.Size(239, 88);
            this.grpFormula.TabIndex = 24;
            this.grpFormula.TabStop = false;
            // 
            // mskTabela
            // 
            this.mskTabela.Location = new System.Drawing.Point(108, 14);
            this.mskTabela.Mask = "09,09";
            this.mskTabela.Name = "mskTabela";
            this.mskTabela.Size = new System.Drawing.Size(39, 20);
            this.mskTabela.TabIndex = 27;
            this.mskTabela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTabela_KeyDown);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(14, 21);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(98, 13);
            this.lblTabela.TabIndex = 26;
            this.lblTabela.Text = "Formato da tabela: ";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(108, 49);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(73, 25);
            this.btnGerar.TabIndex = 25;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(162, 14);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(63, 20);
            this.txtForm.TabIndex = 24;
            // 
            // errinho
            // 
            this.errinho.ContainerControl = this;
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(318, 147);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(206, 13);
            this.lblEx.TabIndex = 25;
            this.lblEx.Text = "Coloque apenas \"i\" e \"j\" para as variáveis";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(424, 179);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 33;
            // 
            // lblSomaE
            // 
            this.lblSomaE.AutoSize = true;
            this.lblSomaE.Location = new System.Drawing.Point(316, 134);
            this.lblSomaE.Name = "lblSomaE";
            this.lblSomaE.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE.TabIndex = 32;
            this.lblSomaE.Text = "Soma dos elementos:";
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(394, 179);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(0, 13);
            this.lblTraco.TabIndex = 35;
            // 
            // lblTr
            // 
            this.lblTr.AutoSize = true;
            this.lblTr.Location = new System.Drawing.Point(316, 179);
            this.lblTr.Name = "lblTr";
            this.lblTr.Size = new System.Drawing.Size(83, 13);
            this.lblTr.TabIndex = 34;
            this.lblTr.Text = "Traço da matriz:";
            // 
            // lblTracoSec
            // 
            this.lblTracoSec.AutoSize = true;
            this.lblTracoSec.Location = new System.Drawing.Point(407, 206);
            this.lblTracoSec.Name = "lblTracoSec";
            this.lblTracoSec.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec.TabIndex = 40;
            // 
            // lblTrSec
            // 
            this.lblTrSec.AutoSize = true;
            this.lblTrSec.Location = new System.Drawing.Point(318, 206);
            this.lblTrSec.Name = "lblTrSec";
            this.lblTrSec.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec.TabIndex = 39;
            this.lblTrSec.Text = "Traço secundário:";
            // 
            // FrmFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 429);
            this.ControlBox = false;
            this.Controls.Add(this.lblTracoSec);
            this.Controls.Add(this.lblTrSec);
            this.Controls.Add(this.lblTraco);
            this.Controls.Add(this.lblTr);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSomaE);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.grpFormula);
            this.Name = "FrmFormula";
            this.Text = "Formula...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFormula_Load);
            this.grpFormula.ResumeLayout(false);
            this.grpFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFormula;
        private System.Windows.Forms.MaskedTextBox mskTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.ErrorProvider errinho;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblSomaE;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.Label lblTr;
        private System.Windows.Forms.Label lblTracoSec;
        private System.Windows.Forms.Label lblTrSec;

    }
}

