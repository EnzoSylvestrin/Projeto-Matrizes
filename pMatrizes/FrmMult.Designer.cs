namespace WindowsFormsApplication1
{
    partial class FrmMult
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
            this.chxAlteração = new System.Windows.Forms.CheckBox();
            this.lblTracoSec3 = new System.Windows.Forms.Label();
            this.lblTrSec3 = new System.Windows.Forms.Label();
            this.lblTraco3 = new System.Windows.Forms.Label();
            this.lblTr3 = new System.Windows.Forms.Label();
            this.lblRes3 = new System.Windows.Forms.Label();
            this.lblSomaE3 = new System.Windows.Forms.Label();
            this.btnResOp = new System.Windows.Forms.Button();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblTracoSec2 = new System.Windows.Forms.Label();
            this.lblTrSec2 = new System.Windows.Forms.Label();
            this.lblTraco2 = new System.Windows.Forms.Label();
            this.lblTr2 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.lblSomaE2 = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
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
            this.btnT1 = new System.Windows.Forms.Button();
            this.btnT2 = new System.Windows.Forms.Button();
            this.btnT3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).BeginInit();
            this.SuspendLayout();
            // 
            // chxAlteração
            // 
            this.chxAlteração.AutoSize = true;
            this.chxAlteração.Location = new System.Drawing.Point(322, 105);
            this.chxAlteração.Name = "chxAlteração";
            this.chxAlteração.Size = new System.Drawing.Size(71, 17);
            this.chxAlteração.TabIndex = 87;
            this.chxAlteração.Text = "Alteração";
            this.chxAlteração.UseVisualStyleBackColor = true;
            // 
            // lblTracoSec3
            // 
            this.lblTracoSec3.AutoSize = true;
            this.lblTracoSec3.Location = new System.Drawing.Point(672, 378);
            this.lblTracoSec3.Name = "lblTracoSec3";
            this.lblTracoSec3.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec3.TabIndex = 86;
            // 
            // lblTrSec3
            // 
            this.lblTrSec3.AutoSize = true;
            this.lblTrSec3.Location = new System.Drawing.Point(516, 378);
            this.lblTrSec3.Name = "lblTrSec3";
            this.lblTrSec3.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec3.TabIndex = 85;
            this.lblTrSec3.Text = "Traço secundário:";
            // 
            // lblTraco3
            // 
            this.lblTraco3.AutoSize = true;
            this.lblTraco3.Location = new System.Drawing.Point(659, 351);
            this.lblTraco3.Name = "lblTraco3";
            this.lblTraco3.Size = new System.Drawing.Size(0, 13);
            this.lblTraco3.TabIndex = 84;
            // 
            // lblTr3
            // 
            this.lblTr3.AutoSize = true;
            this.lblTr3.Location = new System.Drawing.Point(539, 351);
            this.lblTr3.Name = "lblTr3";
            this.lblTr3.Size = new System.Drawing.Size(83, 13);
            this.lblTr3.TabIndex = 83;
            this.lblTr3.Text = "Traço da matriz:";
            // 
            // lblRes3
            // 
            this.lblRes3.AutoSize = true;
            this.lblRes3.Location = new System.Drawing.Point(689, 351);
            this.lblRes3.Name = "lblRes3";
            this.lblRes3.Size = new System.Drawing.Size(0, 13);
            this.lblRes3.TabIndex = 82;
            // 
            // lblSomaE3
            // 
            this.lblSomaE3.AutoSize = true;
            this.lblSomaE3.Location = new System.Drawing.Point(583, 332);
            this.lblSomaE3.Name = "lblSomaE3";
            this.lblSomaE3.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE3.TabIndex = 81;
            this.lblSomaE3.Text = "Soma dos elementos:";
            // 
            // btnResOp
            // 
            this.btnResOp.Location = new System.Drawing.Point(296, 132);
            this.btnResOp.Name = "btnResOp";
            this.btnResOp.Size = new System.Drawing.Size(111, 25);
            this.btnResOp.TabIndex = 74;
            this.btnResOp.Text = "Gerar Resultado";
            this.btnResOp.UseVisualStyleBackColor = true;
            this.btnResOp.Click += new System.EventHandler(this.btnResOp_Click);
            this.btnResOp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgual.Location = new System.Drawing.Point(514, 122);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(39, 42);
            this.lblIgual.TabIndex = 80;
            this.lblIgual.Text = "=";
            // 
            // lblTracoSec2
            // 
            this.lblTracoSec2.AutoSize = true;
            this.lblTracoSec2.Location = new System.Drawing.Point(451, 378);
            this.lblTracoSec2.Name = "lblTracoSec2";
            this.lblTracoSec2.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec2.TabIndex = 79;
            // 
            // lblTrSec2
            // 
            this.lblTrSec2.AutoSize = true;
            this.lblTrSec2.Location = new System.Drawing.Point(347, 378);
            this.lblTrSec2.Name = "lblTrSec2";
            this.lblTrSec2.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec2.TabIndex = 78;
            this.lblTrSec2.Text = "Traço secundário:";
            // 
            // lblTraco2
            // 
            this.lblTraco2.AutoSize = true;
            this.lblTraco2.Location = new System.Drawing.Point(438, 351);
            this.lblTraco2.Name = "lblTraco2";
            this.lblTraco2.Size = new System.Drawing.Size(0, 13);
            this.lblTraco2.TabIndex = 77;
            // 
            // lblTr2
            // 
            this.lblTr2.AutoSize = true;
            this.lblTr2.Location = new System.Drawing.Point(346, 351);
            this.lblTr2.Name = "lblTr2";
            this.lblTr2.Size = new System.Drawing.Size(83, 13);
            this.lblTr2.TabIndex = 76;
            this.lblTr2.Text = "Traço da matriz:";
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(468, 351);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(0, 13);
            this.lblRes2.TabIndex = 75;
            // 
            // lblSomaE2
            // 
            this.lblSomaE2.AutoSize = true;
            this.lblSomaE2.Location = new System.Drawing.Point(362, 332);
            this.lblSomaE2.Name = "lblSomaE2";
            this.lblSomaE2.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE2.TabIndex = 73;
            this.lblSomaE2.Text = "Soma dos elementos:";
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(396, 122);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(37, 42);
            this.lblSinal.TabIndex = 72;
            this.lblSinal.Text = "*";
            // 
            // lblTracoSec
            // 
            this.lblTracoSec.AutoSize = true;
            this.lblTracoSec.Location = new System.Drawing.Point(115, 378);
            this.lblTracoSec.Name = "lblTracoSec";
            this.lblTracoSec.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec.TabIndex = 71;
            // 
            // lblTrSec
            // 
            this.lblTrSec.AutoSize = true;
            this.lblTrSec.Location = new System.Drawing.Point(26, 378);
            this.lblTrSec.Name = "lblTrSec";
            this.lblTrSec.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec.TabIndex = 70;
            this.lblTrSec.Text = "Traço secundário:";
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(102, 351);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(0, 13);
            this.lblTraco.TabIndex = 69;
            // 
            // lblTr
            // 
            this.lblTr.AutoSize = true;
            this.lblTr.Location = new System.Drawing.Point(24, 351);
            this.lblTr.Name = "lblTr";
            this.lblTr.Size = new System.Drawing.Size(83, 13);
            this.lblTr.TabIndex = 68;
            this.lblTr.Text = "Traço da matriz:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(132, 351);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 67;
            // 
            // lblSomaE
            // 
            this.lblSomaE.AutoSize = true;
            this.lblSomaE.Location = new System.Drawing.Point(26, 332);
            this.lblSomaE.Name = "lblSomaE";
            this.lblSomaE.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE.TabIndex = 66;
            this.lblSomaE.Text = "Soma dos elementos:";
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(256, 138);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(206, 13);
            this.lblEx.TabIndex = 65;
            this.lblEx.Text = "Coloque apenas \"i\" e \"j\" para as variáveis";
            // 
            // grpFormula
            // 
            this.grpFormula.Controls.Add(this.label1);
            this.grpFormula.Controls.Add(this.btnLimpar);
            this.grpFormula.Controls.Add(this.mskTabela);
            this.grpFormula.Controls.Add(this.lblTabela);
            this.grpFormula.Controls.Add(this.btnGerar);
            this.grpFormula.Controls.Add(this.txtForm);
            this.grpFormula.Location = new System.Drawing.Point(19, 72);
            this.grpFormula.Name = "grpFormula";
            this.grpFormula.Size = new System.Drawing.Size(236, 105);
            this.grpFormula.TabIndex = 64;
            this.grpFormula.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(65, 67);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 25);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskTabela
            // 
            this.mskTabela.Location = new System.Drawing.Point(75, 41);
            this.mskTabela.Mask = "0,0";
            this.mskTabela.Name = "mskTabela";
            this.mskTabela.Size = new System.Drawing.Size(24, 20);
            this.mskTabela.TabIndex = 27;
            this.mskTabela.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(7, 25);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(98, 13);
            this.lblTabela.TabIndex = 26;
            this.lblTabela.Text = "Formato da tabela: ";
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(130, 67);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(54, 25);
            this.btnGerar.TabIndex = 25;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtForm
            // 
            this.txtForm.Location = new System.Drawing.Point(130, 41);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(63, 20);
            this.txtForm.TabIndex = 24;
            this.txtForm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // errinho
            // 
            this.errinho.ContainerControl = this;
            // 
            // btnT1
            // 
            this.btnT1.Location = new System.Drawing.Point(642, 89);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(17, 21);
            this.btnT1.TabIndex = 88;
            this.btnT1.Text = "t";
            this.btnT1.UseVisualStyleBackColor = true;
            this.btnT1.Click += new System.EventHandler(this.btnT1_Click);
            // 
            // btnT2
            // 
            this.btnT2.Location = new System.Drawing.Point(586, 59);
            this.btnT2.Name = "btnT2";
            this.btnT2.Size = new System.Drawing.Size(17, 21);
            this.btnT2.TabIndex = 89;
            this.btnT2.Text = "t";
            this.btnT2.UseVisualStyleBackColor = true;
            this.btnT2.Click += new System.EventHandler(this.btnT2_Click);
            // 
            // btnT3
            // 
            this.btnT3.Location = new System.Drawing.Point(655, 59);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(17, 21);
            this.btnT3.TabIndex = 90;
            this.btnT3.Text = "t";
            this.btnT3.UseVisualStyleBackColor = true;
            this.btnT3.Click += new System.EventHandler(this.btnT3_Click);
            this.btnT3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Padrão:";
            // 
            // FrmMult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 456);
            this.Controls.Add(this.btnT3);
            this.Controls.Add(this.btnT2);
            this.Controls.Add(this.btnT1);
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
            this.Name = "FrmMult";
            this.Text = "Multiplicação...";
            this.Load += new System.EventHandler(this.FrmMult_Load);
            this.grpFormula.ResumeLayout(false);
            this.grpFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chxAlteração;
        private System.Windows.Forms.Label lblTracoSec3;
        private System.Windows.Forms.Label lblTrSec3;
        private System.Windows.Forms.Label lblTraco3;
        private System.Windows.Forms.Label lblTr3;
        private System.Windows.Forms.Label lblRes3;
        private System.Windows.Forms.Label lblSomaE3;
        private System.Windows.Forms.Button btnResOp;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblTracoSec2;
        private System.Windows.Forms.Label lblTrSec2;
        private System.Windows.Forms.Label lblTraco2;
        private System.Windows.Forms.Label lblTr2;
        private System.Windows.Forms.Label lblRes2;
        private System.Windows.Forms.Label lblSomaE2;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblTracoSec;
        private System.Windows.Forms.Label lblTrSec;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.Label lblTr;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblSomaE;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.GroupBox grpFormula;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.ErrorProvider errinho;
        private System.Windows.Forms.Button btnT2;
        private System.Windows.Forms.Button btnT1;
        private System.Windows.Forms.Button btnT3;
        private System.Windows.Forms.Label label1;
    }
}