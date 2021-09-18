namespace WindowsFormsApplication1
{
    partial class FrmSomaeSub
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
            this.lblTracoSec = new System.Windows.Forms.Label();
            this.lblTrSec = new System.Windows.Forms.Label();
            this.lblTraco = new System.Windows.Forms.Label();
            this.lblTr = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblSomaE = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.grpFormula = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskTabela = new System.Windows.Forms.MaskedTextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.errinho = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblTracoSec2 = new System.Windows.Forms.Label();
            this.lblTrSec2 = new System.Windows.Forms.Label();
            this.lblTraco2 = new System.Windows.Forms.Label();
            this.lblTr2 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lblSomaE2 = new System.Windows.Forms.Label();
            this.lblIgual = new System.Windows.Forms.Label();
            this.btnResOp = new System.Windows.Forms.Button();
            this.lblTracoSec3 = new System.Windows.Forms.Label();
            this.lblTrSec3 = new System.Windows.Forms.Label();
            this.lblTraco3 = new System.Windows.Forms.Label();
            this.lblTr3 = new System.Windows.Forms.Label();
            this.lblRes3 = new System.Windows.Forms.Label();
            this.lblSomaE3 = new System.Windows.Forms.Label();
            this.chxAlteração = new System.Windows.Forms.CheckBox();
            this.grpFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTracoSec
            // 
            this.lblTracoSec.AutoSize = true;
            this.lblTracoSec.Location = new System.Drawing.Point(109, 412);
            this.lblTracoSec.Name = "lblTracoSec";
            this.lblTracoSec.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec.TabIndex = 48;
            // 
            // lblTrSec
            // 
            this.lblTrSec.AutoSize = true;
            this.lblTrSec.Location = new System.Drawing.Point(20, 412);
            this.lblTrSec.Name = "lblTrSec";
            this.lblTrSec.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec.TabIndex = 47;
            this.lblTrSec.Text = "Traço secundário:";
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(96, 385);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(0, 13);
            this.lblTraco.TabIndex = 46;
            // 
            // lblTr
            // 
            this.lblTr.AutoSize = true;
            this.lblTr.Location = new System.Drawing.Point(18, 385);
            this.lblTr.Name = "lblTr";
            this.lblTr.Size = new System.Drawing.Size(83, 13);
            this.lblTr.TabIndex = 45;
            this.lblTr.Text = "Traço da matriz:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(126, 385);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 44;
            // 
            // lblSomaE
            // 
            this.lblSomaE.AutoSize = true;
            this.lblSomaE.Location = new System.Drawing.Point(20, 366);
            this.lblSomaE.Name = "lblSomaE";
            this.lblSomaE.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE.TabIndex = 43;
            this.lblSomaE.Text = "Soma dos elementos:";
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(256, 138);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(206, 13);
            this.lblEx.TabIndex = 42;
            this.lblEx.Text = "Coloque apenas \"i\" e \"j\" para as variáveis";
            // 
            // grpFormula
            // 
            this.grpFormula.Controls.Add(this.btnLimpar);
            this.grpFormula.Controls.Add(this.mskTabela);
            this.grpFormula.Controls.Add(this.lblTabela);
            this.grpFormula.Controls.Add(this.btnGerar);
            this.grpFormula.Controls.Add(this.txtForm);
            this.grpFormula.Location = new System.Drawing.Point(19, 89);
            this.grpFormula.Name = "grpFormula";
            this.grpFormula.Size = new System.Drawing.Size(231, 88);
            this.grpFormula.TabIndex = 41;
            this.grpFormula.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(78, 49);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 25);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskTabela
            // 
            this.mskTabela.Location = new System.Drawing.Point(108, 14);
            this.mskTabela.Mask = "0,0";
            this.mskTabela.Name = "mskTabela";
            this.mskTabela.Size = new System.Drawing.Size(24, 20);
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
            this.btnGerar.Location = new System.Drawing.Point(140, 49);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(54, 25);
            this.btnGerar.TabIndex = 25;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(153, 14);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(63, 20);
            this.txtForm.TabIndex = 24;
            this.txtForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtForm_KeyDown);
            this.txtForm.Leave += new System.EventHandler(this.txtForm_Leave);
            // 
            // errinho
            // 
            this.errinho.ContainerControl = this;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(388, 121);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(39, 42);
            this.lblSinal.TabIndex = 49;
            this.lblSinal.Text = "+";
            this.lblSinal.Click += new System.EventHandler(this.lblSinal_Click);
            // 
            // lblTracoSec2
            // 
            this.lblTracoSec2.AutoSize = true;
            this.lblTracoSec2.Location = new System.Drawing.Point(445, 412);
            this.lblTracoSec2.Name = "lblTracoSec2";
            this.lblTracoSec2.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec2.TabIndex = 55;
            // 
            // lblTrSec2
            // 
            this.lblTrSec2.AutoSize = true;
            this.lblTrSec2.Location = new System.Drawing.Point(341, 412);
            this.lblTrSec2.Name = "lblTrSec2";
            this.lblTrSec2.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec2.TabIndex = 54;
            this.lblTrSec2.Text = "Traço secundário:";
            // 
            // lblTraco2
            // 
            this.lblTraco2.AutoSize = true;
            this.lblTraco2.Location = new System.Drawing.Point(432, 385);
            this.lblTraco2.Name = "lblTraco2";
            this.lblTraco2.Size = new System.Drawing.Size(0, 13);
            this.lblTraco2.TabIndex = 53;
            // 
            // lblTr2
            // 
            this.lblTr2.AutoSize = true;
            this.lblTr2.Location = new System.Drawing.Point(340, 385);
            this.lblTr2.Name = "lblTr2";
            this.lblTr2.Size = new System.Drawing.Size(83, 13);
            this.lblTr2.TabIndex = 52;
            this.lblTr2.Text = "Traço da matriz:";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(462, 385);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 13);
            this.lblRes2.TabIndex = 51;
            // 
            // lblSomaE2
            // 
            this.lblSomaE2.AutoSize = true;
            this.lblSomaE2.Location = new System.Drawing.Point(356, 366);
            this.lblSomaE2.Name = "lblSomaE2";
            this.lblSomaE2.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE2.TabIndex = 50;
            this.lblSomaE2.Text = "Soma dos elementos:";
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(506, 121);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(39, 42);
            this.lblIgual.TabIndex = 56;
            this.lblIgual.Text = "=";
            // 
            // btnResOp
            // 
            this.btnResOp.Location = new System.Drawing.Point(296, 132);
            this.btnResOp.Name = "btnResOp";
            this.btnResOp.Size = new System.Drawing.Size(111, 25);
            this.btnResOp.TabIndex = 51;
            this.btnResOp.Text = "Gerar Resultado";
            this.btnResOp.UseVisualStyleBackColor = true;
            this.btnResOp.Click += new System.EventHandler(this.btnResOp_Click);
            // 
            // lblTracoSec3
            // 
            this.lblTracoSec3.AutoSize = true;
            this.lblTracoSec3.Location = new System.Drawing.Point(666, 412);
            this.lblTracoSec3.Name = "lblTracoSec3";
            this.lblTracoSec3.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec3.TabIndex = 62;
            // 
            // lblTrSec3
            // 
            this.lblTrSec3.AutoSize = true;
            this.lblTrSec3.Location = new System.Drawing.Point(510, 412);
            this.lblTrSec3.Name = "lblTrSec3";
            this.lblTrSec3.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec3.TabIndex = 61;
            this.lblTrSec3.Text = "Traço secundário:";
            // 
            // lblTraco3
            // 
            this.lblTraco3.AutoSize = true;
            this.lblTraco3.Location = new System.Drawing.Point(653, 385);
            this.lblTraco3.Name = "lblTraco3";
            this.lblTraco3.Size = new System.Drawing.Size(0, 13);
            this.lblTraco3.TabIndex = 60;
            // 
            // lblTr3
            // 
            this.lblTr3.AutoSize = true;
            this.lblTr3.Location = new System.Drawing.Point(533, 385);
            this.lblTr3.Name = "lblTr3";
            this.lblTr3.Size = new System.Drawing.Size(83, 13);
            this.lblTr3.TabIndex = 59;
            this.lblTr3.Text = "Traço da matriz:";
            // 
            // lblRes3
            // 
            this.lblRes3.AutoSize = true;
            this.lblRes3.Location = new System.Drawing.Point(683, 385);
            this.lblRes3.Name = "lblRes3";
            this.lblRes3.Size = new System.Drawing.Size(0, 13);
            this.lblRes3.TabIndex = 58;
            // 
            // lblSomaE3
            // 
            this.lblSomaE3.AutoSize = true;
            this.lblSomaE3.Location = new System.Drawing.Point(577, 366);
            this.lblSomaE3.Name = "lblSomaE3";
            this.lblSomaE3.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE3.TabIndex = 57;
            this.lblSomaE3.Text = "Soma dos elementos:";
            // 
            // chxAlteração
            // 
            this.chxAlteração.AutoSize = true;
            this.chxAlteração.Location = new System.Drawing.Point(322, 105);
            this.chxAlteração.Name = "chxAlteração";
            this.chxAlteração.Size = new System.Drawing.Size(71, 17);
            this.chxAlteração.TabIndex = 63;
            this.chxAlteração.Text = "Alteração";
            this.chxAlteração.UseVisualStyleBackColor = true;
            // 
            // FrmSomaeSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.chxAlteração);
            this.Controls.Add(this.lblTracoSec3);
            this.Controls.Add(this.lblTrSec3);
            this.Controls.Add(this.lblTraco3);
            this.Controls.Add(this.lblTr3);
            this.Controls.Add(this.lblRes3);
            this.Controls.Add(this.lblSomaE3);
            this.Controls.Add(this.btnResOp);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.lblTracoSec2);
            this.Controls.Add(this.lblTrSec2);
            this.Controls.Add(this.lblTraco2);
            this.Controls.Add(this.lblTr2);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.lblSomaE2);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblTracoSec);
            this.Controls.Add(this.lblTrSec);
            this.Controls.Add(this.lblTraco);
            this.Controls.Add(this.lblTr);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSomaE);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.grpFormula);
            this.Name = "FrmSomaeSub";
            this.Text = "FrmSomaeSub";
            this.Load += new System.EventHandler(this.FrmSomaeSub_Load);
            this.grpFormula.ResumeLayout(false);
            this.grpFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTracoSec;
        private System.Windows.Forms.Label lblTrSec;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.Label lblTr;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblSomaE;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.GroupBox grpFormula;
        private System.Windows.Forms.MaskedTextBox mskTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.ErrorProvider errinho;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblTracoSec2;
        private System.Windows.Forms.Label lblTrSec2;
        private System.Windows.Forms.Label lblTraco2;
        private System.Windows.Forms.Label lblTr2;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblSomaE2;
        private System.Windows.Forms.Button btnResOp;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblTracoSec3;
        private System.Windows.Forms.Label lblTrSec3;
        private System.Windows.Forms.Label lblTraco3;
        private System.Windows.Forms.Label lblTr3;
        private System.Windows.Forms.Label lblRes3;
        private System.Windows.Forms.Label lblSomaE3;
        private System.Windows.Forms.CheckBox chxAlteração;
    }
}