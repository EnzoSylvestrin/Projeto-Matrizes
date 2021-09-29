namespace WindowsFormsApplication1
{
    partial class FrmMatrizes
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
            this.grpMD = new System.Windows.Forms.GroupBox();
            this.txtSinalMD = new System.Windows.Forms.TextBox();
            this.txtj = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txti = new System.Windows.Forms.TextBox();
            this.btnMult = new System.Windows.Forms.Button();
            this.mskTabela1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSS = new System.Windows.Forms.GroupBox();
            this.txtSinalSS = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.txtConst = new System.Windows.Forms.TextBox();
            this.mskTabela = new System.Windows.Forms.MaskedTextBox();
            this.lblTabela = new System.Windows.Forms.Label();
            this.cmbOP = new System.Windows.Forms.ComboBox();
            this.btnformula = new System.Windows.Forms.Button();
            this.erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSomaE = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblTr = new System.Windows.Forms.Label();
            this.lblTraco = new System.Windows.Forms.Label();
            this.btnAtalhos = new System.Windows.Forms.Button();
            this.cbxME = new System.Windows.Forms.CheckBox();
            this.lblTrSec = new System.Windows.Forms.Label();
            this.lblTracoSec = new System.Windows.Forms.Label();
            this.grpMD.SuspendLayout();
            this.grpSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMD
            // 
            this.grpMD.Controls.Add(this.txtSinalMD);
            this.grpMD.Controls.Add(this.txtj);
            this.grpMD.Controls.Add(this.btnDiv);
            this.grpMD.Controls.Add(this.txti);
            this.grpMD.Controls.Add(this.btnMult);
            this.grpMD.Controls.Add(this.mskTabela1);
            this.grpMD.Controls.Add(this.label2);
            this.grpMD.Location = new System.Drawing.Point(405, 109);
            this.grpMD.Name = "grpMD";
            this.grpMD.Size = new System.Drawing.Size(264, 93);
            this.grpMD.TabIndex = 26;
            this.grpMD.TabStop = false;
            this.grpMD.Text = "Mult/Div";
            // 
            // txtSinalMD
            // 
            this.txtSinalMD.Location = new System.Drawing.Point(27, 61);
            this.txtSinalMD.Name = "txtSinalMD";
            this.txtSinalMD.Size = new System.Drawing.Size(12, 20);
            this.txtSinalMD.TabIndex = 34;
            this.txtSinalMD.Text = "+";
            this.txtSinalMD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // txtj
            // 
            this.txtj.Location = new System.Drawing.Point(224, 27);
            this.txtj.Name = "txtj";
            this.txtj.Size = new System.Drawing.Size(26, 20);
            this.txtj.TabIndex = 31;
            this.txtj.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(148, 61);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(64, 23);
            this.btnDiv.TabIndex = 30;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // txti
            // 
            this.txti.Location = new System.Drawing.Point(186, 27);
            this.txti.Name = "txti";
            this.txti.Size = new System.Drawing.Size(26, 20);
            this.txti.TabIndex = 29;
            this.txti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(67, 61);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(69, 23);
            this.btnMult.TabIndex = 28;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // mskTabela1
            // 
            this.mskTabela1.Location = new System.Drawing.Point(132, 27);
            this.mskTabela1.Mask = "09,09";
            this.mskTabela1.Name = "mskTabela1";
            this.mskTabela1.Size = new System.Drawing.Size(39, 20);
            this.mskTabela1.TabIndex = 27;
            this.mskTabela1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTabela1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Formato da tabela: ";
            // 
            // grpSS
            // 
            this.grpSS.Controls.Add(this.txtSinalSS);
            this.grpSS.Controls.Add(this.btnCriar);
            this.grpSS.Controls.Add(this.btnSub);
            this.grpSS.Controls.Add(this.txtConst);
            this.grpSS.Controls.Add(this.mskTabela);
            this.grpSS.Controls.Add(this.lblTabela);
            this.grpSS.Location = new System.Drawing.Point(405, 12);
            this.grpSS.Name = "grpSS";
            this.grpSS.Size = new System.Drawing.Size(264, 91);
            this.grpSS.TabIndex = 27;
            this.grpSS.TabStop = false;
            this.grpSS.Text = "Somar/Sub";
            // 
            // txtSinalSS
            // 
            this.txtSinalSS.Location = new System.Drawing.Point(27, 54);
            this.txtSinalSS.Name = "txtSinalSS";
            this.txtSinalSS.Size = new System.Drawing.Size(12, 20);
            this.txtSinalSS.TabIndex = 33;
            this.txtSinalSS.Text = "+";
            this.txtSinalSS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(89, 51);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(46, 23);
            this.btnCriar.TabIndex = 25;
            this.btnCriar.Text = "Somar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click_1);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(147, 51);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(64, 23);
            this.btnSub.TabIndex = 24;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnCriar_Click_1);
            // 
            // txtConst
            // 
            this.txtConst.Location = new System.Drawing.Point(185, 17);
            this.txtConst.Name = "txtConst";
            this.txtConst.Size = new System.Drawing.Size(26, 20);
            this.txtConst.TabIndex = 23;
            this.txtConst.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teclas);
            // 
            // mskTabela
            // 
            this.mskTabela.Location = new System.Drawing.Point(131, 17);
            this.mskTabela.Mask = "09,09";
            this.mskTabela.Name = "mskTabela";
            this.mskTabela.Size = new System.Drawing.Size(39, 20);
            this.mskTabela.TabIndex = 21;
            this.mskTabela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskTabela_KeyDown);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(37, 24);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(98, 13);
            this.lblTabela.TabIndex = 20;
            this.lblTabela.Text = "Formato da tabela: ";
            // 
            // cmbOP
            // 
            this.cmbOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOP.FormattingEnabled = true;
            this.cmbOP.Items.AddRange(new object[] {
            "Mult/Div",
            "Somar/Sub"});
            this.cmbOP.Location = new System.Drawing.Point(405, 224);
            this.cmbOP.Name = "cmbOP";
            this.cmbOP.Size = new System.Drawing.Size(144, 21);
            this.cmbOP.TabIndex = 28;
            this.cmbOP.SelectedValueChanged += new System.EventHandler(this.cmbOP_SelectedValueChanged);
            // 
            // btnformula
            // 
            this.btnformula.Location = new System.Drawing.Point(726, 76);
            this.btnformula.Name = "btnformula";
            this.btnformula.Size = new System.Drawing.Size(59, 27);
            this.btnformula.TabIndex = 29;
            this.btnformula.Text = "Fórmula!";
            this.btnformula.UseVisualStyleBackColor = true;
            this.btnformula.Click += new System.EventHandler(this.btnformula_Click);
            // 
            // erro
            // 
            this.erro.ContainerControl = this;
            // 
            // lblSomaE
            // 
            this.lblSomaE.AutoSize = true;
            this.lblSomaE.Location = new System.Drawing.Point(402, 268);
            this.lblSomaE.Name = "lblSomaE";
            this.lblSomaE.Size = new System.Drawing.Size(108, 13);
            this.lblSomaE.TabIndex = 30;
            this.lblSomaE.Text = "Soma dos elementos:";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(508, 268);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 31;
            // 
            // lblTr
            // 
            this.lblTr.AutoSize = true;
            this.lblTr.Location = new System.Drawing.Point(402, 293);
            this.lblTr.Name = "lblTr";
            this.lblTr.Size = new System.Drawing.Size(83, 13);
            this.lblTr.TabIndex = 32;
            this.lblTr.Text = "Traço da matriz:";
            // 
            // lblTraco
            // 
            this.lblTraco.AutoSize = true;
            this.lblTraco.Location = new System.Drawing.Point(480, 293);
            this.lblTraco.Name = "lblTraco";
            this.lblTraco.Size = new System.Drawing.Size(0, 13);
            this.lblTraco.TabIndex = 33;
            // 
            // btnAtalhos
            // 
            this.btnAtalhos.Location = new System.Drawing.Point(726, 109);
            this.btnAtalhos.Name = "btnAtalhos";
            this.btnAtalhos.Size = new System.Drawing.Size(59, 27);
            this.btnAtalhos.TabIndex = 35;
            this.btnAtalhos.Text = "Atalhos!";
            this.btnAtalhos.UseVisualStyleBackColor = true;
            this.btnAtalhos.Click += new System.EventHandler(this.Atalhos_Click);
            // 
            // cbxME
            // 
            this.cbxME.AutoSize = true;
            this.cbxME.Location = new System.Drawing.Point(569, 226);
            this.cbxME.Name = "cbxME";
            this.cbxME.Size = new System.Drawing.Size(115, 17);
            this.cbxME.TabIndex = 36;
            this.cbxME.Text = "Matrizes especiais ";
            this.cbxME.UseVisualStyleBackColor = true;
            this.cbxME.CheckedChanged += new System.EventHandler(this.cbxME_CheckedChanged);
            // 
            // lblTrSec
            // 
            this.lblTrSec.AutoSize = true;
            this.lblTrSec.Location = new System.Drawing.Point(402, 315);
            this.lblTrSec.Name = "lblTrSec";
            this.lblTrSec.Size = new System.Drawing.Size(93, 13);
            this.lblTrSec.TabIndex = 37;
            this.lblTrSec.Text = "Traço secundário:";
            // 
            // lblTracoSec
            // 
            this.lblTracoSec.AutoSize = true;
            this.lblTracoSec.Location = new System.Drawing.Point(491, 315);
            this.lblTracoSec.Name = "lblTracoSec";
            this.lblTracoSec.Size = new System.Drawing.Size(0, 13);
            this.lblTracoSec.TabIndex = 38;
            // 
            // FrmMatrizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 504);
            this.ControlBox = false;
            this.Controls.Add(this.lblTracoSec);
            this.Controls.Add(this.lblTrSec);
            this.Controls.Add(this.cbxME);
            this.Controls.Add(this.btnAtalhos);
            this.Controls.Add(this.lblTraco);
            this.Controls.Add(this.lblTr);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblSomaE);
            this.Controls.Add(this.btnformula);
            this.Controls.Add(this.cmbOP);
            this.Controls.Add(this.grpSS);
            this.Controls.Add(this.grpMD);
            this.Name = "FrmMatrizes";
            this.Text = "Matrizes...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMatrizes_Load);
            this.grpMD.ResumeLayout(false);
            this.grpMD.PerformLayout();
            this.grpSS.ResumeLayout(false);
            this.grpSS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMD;
        private System.Windows.Forms.TextBox txtj;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox txti;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.MaskedTextBox mskTabela1;
        private System.Windows.Forms.GroupBox grpSS;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox txtConst;
        private System.Windows.Forms.MaskedTextBox mskTabela;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.ComboBox cmbOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnformula;
        private System.Windows.Forms.ErrorProvider erro;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblSomaE;
        private System.Windows.Forms.Label lblTr;
        private System.Windows.Forms.Label lblTraco;
        private System.Windows.Forms.TextBox txtSinalSS;
        private System.Windows.Forms.Button btnAtalhos;
        private System.Windows.Forms.CheckBox cbxME;
        private System.Windows.Forms.TextBox txtSinalMD;
        private System.Windows.Forms.Label lblTracoSec;
        private System.Windows.Forms.Label lblTrSec;
    }
}

