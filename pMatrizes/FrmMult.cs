﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMult : Form
    {
        public FrmMult()
        {
            InitializeComponent();
        }

        #region variaveis
        char mult = '*';
        char sub = '-';
        char soma = '+';
        char div = '/';
        MatchCollection collect;

        int resul1 = 0;
        int ia = 0;
        int conte = 0;
        int[] result = { 0, 0, 0 };
        int[] traco = { 0, 0, 0 };
        int[] tracoSec = { 0, 0, 0 };
        int[] resu;
        bool x = false;
        int click = -1;
        int a = 20;
        string j1;
        string i1;
        string[] variavel;

        Point ponto;
        Point ponti;
        Point subs;
        Point grpzi;
        Point grpzi2;

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.GroupBox grp3;
        #endregion

        #region consistir
        public bool consistir(string ee)
        {
            try
            {
                if (ee == null)
                {
                    errinho.Clear();
                    x = false;
                    string[] valv = mskTabela.Text.Split(new char[] { '.' });
                    if (!mskTabela.MaskCompleted)
                    {
                        errinho.SetError(mskTabela, "preencha o campo corretamente!!");
                        x = true;
                    }
                    if (string.IsNullOrEmpty(txtForm.Text))
                    {
                        errinho.SetError(txtForm, "preencha o campo!!");
                        x = true;
                    }
                    if (valv[0] == "0" || valv[1] == "0")
                    {
                        errinho.SetError(mskTabela, "Não existe matriz com linha ou coluna 0!!");
                        x = true;
                    }
                    if (x)
                        return false;
                    else
                        return true;
                }
                else return true;
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region btnGerar
        private static int SortByIndex(Match n1, Match n2)
        {
            return n1.Index.CompareTo(n2.Index);
        }
        private void btnGerar_Click(object sender, EventArgs e)
        {
            click++;
            if (click < 3)
            Novo(sender, e, click);
        }

        public void Novo(object sender, EventArgs e, int cont, string ee = null)
        {
            try
            {
                if (consistir(ee))
                {
                    a = 20;
                    conte = 0;
                    txtForm_Leave();
                    lblEx.Visible = false;
                    errinho.Clear();
                    List<Match> listinha = new List<Match>();
                    string[] comeco = new string[2];
                    if (ee == null)
                    {
                        comeco = mskTabela.Text.Split(new char[] { '.' });
                        variavel = new string[] { comeco[0], comeco[1] };
                    }
                    else
                    {
                        comeco[0] = variavel[0];
                        variavel[0] = variavel[1];
                        variavel[1] = comeco[0];
                        if (cont == 0)
                        {
                            traco[0] = 0;
                            tracoSec[0] = 0;
                            result[0] = 0;
                        }
                        else
                        {
                            traco[1] = 0;
                            tracoSec[1] = 0;
                            result[1] = 0;
                        }
                        
                    }
                    if (cont == 0)
                    {
                        i1 = variavel[0];
                        j1 = variavel[1];
                    }
                    string[] res = txtForm.Text.Split(new char[] { mult, sub, soma, div });

                    Regex regexinho = new Regex(@"\+");
                    collect = regexinho.Matches(txtForm.Text);
                    foreach (Match i in collect)
                    {
                        listinha.Add(i);
                    }

                    regexinho = new Regex(@"\*");
                    collect = regexinho.Matches(txtForm.Text);
                    foreach (Match i in collect)
                    {
                        listinha.Add(i);
                    }

                    regexinho = new Regex(@"\-");
                    collect = regexinho.Matches(txtForm.Text);
                    foreach (Match i in collect)
                    {
                        listinha.Add(i);
                    }

                    regexinho = new Regex(@"\/");
                    collect = regexinho.Matches(txtForm.Text);
                    foreach (Match i in collect)
                    {
                        listinha.Add(i);
                    }

                    listinha.Sort(SortByIndex);

                    if (cont == 0)
                    {
                        grpzi = new Point(20, 200);
                        ponto = new Point(0, 0);
                        this.grp = new System.Windows.Forms.GroupBox();
                        grp.Name = "grp1";
                        grp.Location = grpzi;
                        int size = int.Parse(variavel[0]) * 30;
                        int size2 = int.Parse(variavel[1]) * 30;
                        grp.Size = new Size(size2, size);
                        grp.Visible = true;
                        this.Controls.Add(grp);
                    }
                    else
                    {
                        for (int s = 0; s < int.Parse(j1); s++)
                        {
                            a += 30;
                        }
                        grpzi2 = new Point(a + 55, 200);
                        ponti = new Point(0, 0);
                        this.grp2 = new System.Windows.Forms.GroupBox();
                        grp2.Name = "grp2";
                        grp2.Location = grpzi2;
                        int size = int.Parse(variavel[0]) * 30;
                        int size2 = int.Parse(variavel[1]) * 30;
                        grp2.Size = new Size(size2, size);
                        grp2.Visible = true;
                        this.Controls.Add(grp2);

                    }
                    for (int i = 0; i < int.Parse(variavel[0]); i++)
                    {
                        for (int j = 0; j < int.Parse(variavel[1]); j++)
                        {
                            if (ee == null)
                            {
                                if (i == j && cont == 0)
                                {
                                    traco[0] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }
                                else if (i == j)
                                {
                                    traco[1] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }

                                if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1 && cont == 0)
                                {
                                    tracoSec[0] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }
                                else if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                                {
                                    tracoSec[1] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }
                            }
                            else
                            {
                                if (i == j && cont == 0)
                                {
                                    traco[0] += resu[j * int.Parse(variavel[0]) + i];
                                }
                                else if (i == j)
                                {
                                    traco[1] += resu[j * int.Parse(variavel[0]) + i];
                                }

                                if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1 && cont == 0)
                                {
                                    tracoSec[0] += resu[j * int.Parse(variavel[0]) + i];
                                }
                                else if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                                {
                                    tracoSec[1] += resu[j * int.Parse(variavel[0]) + i];
                                }
                            }
                            Field novo = new Field();
                            novo.Click += (sender2, e2) => field_Click(novo);
                            if (cont == 0)
                            {
                                novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1);
                            }
                            else
                            {
                                novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1) + " ";
                            }
                            if (ee == null)
                            {
                                novo.Text = returnName(createIntList(i + 1, j + 1, res), listinha);
                                if(cont == 0)
                                {
                                    result[0] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }
                                else
                                {
                                    result[1] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                                }
                            }
                            else
                            {
                                novo.Text = resu[j * int.Parse(variavel[0]) + i].ToString();
                                if (cont == 0)
                                {
                                    result[0] += resu[j * int.Parse(variavel[0]) + i];
                                }
                                else
                                {
                                    result[1] += resu[j * int.Parse(variavel[0]) + i];
                                }
                            }
                            
                            novo.Size = new Size(30, 30);
                            if (cont == 0)
                            {
                                novo.Location = ponto;
                            }
                            else
                            {
                                novo.Location = ponti;
                            }
                            novo.BorderStyle = BorderStyle.FixedSingle;
                            novo.Font = new Font("Arial", 8);
                            this.Controls.Add(novo);
                            if (cont == 0)
                            {
                                this.grp.Controls.Add(novo);
                                ponto.X += 30;
                                grpzi.X += 30;
                            }
                            else
                            {
                                this.grp2.Controls.Add(novo);
                                ponti.X += 30;
                                grpzi2.X += 30;
                            }
                        }
                        if (cont == 0)
                        {
                            ponto.Y += 30;
                            grpzi.Y += 30;
                        }
                        else
                        {
                            ponti.Y += 30;
                            grpzi2.Y += 30;
                            if (i == int.Parse(variavel[0]) - 1)
                            {
                                subs = new Point(grpzi2.X, 10);
                            }
                            if (int.Parse(variavel[0]) == 1 && int.Parse(variavel[1]) == 1)
                            {
                                subs = new Point(130, 10);
                            }
                            ponti.X = 0;
                            grpzi2.X = grpzi.X + 46;
                        }
                        if (i != int.Parse(variavel[0]) - 1 && cont == 0)
                        {
                            ponto.X = 0;
                            grpzi.X = 30;
                        }
                    }
                    if (cont == 0)
                    {
                        if (int.Parse(variavel[0]) == 1)
                            ia = (int.Parse(variavel[0]) * 40);
                        else if (int.Parse(variavel[0]) == 2)
                            ia = (int.Parse(variavel[0]) / 2) * 63;
                        else if (int.Parse(variavel[0]) == 3)
                            ia = (int.Parse(variavel[0]) / 2) * 67;
                        else if (int.Parse(variavel[0]) == 4)
                            ia = (int.Parse(variavel[0]) / 2) * 45;
                        else if (int.Parse(variavel[0]) == 5)
                            ia = (int.Parse(variavel[0]) / 2) * 50;
                        else
                            ia = (int.Parse(variavel[0]) / 2) * 40;
                        lblSinal.Location = new Point(grpzi.X, grpzi.Y - ia);
                        lblSinal.Visible = true;
                        btnT1.Location = new Point(grpzi.X - 20, 177);
                        btnT1.Visible = true;
                        lblSomaE.Location = new Point(20, grpzi.Y + 10);
                        lblSomaE.Visible = true;
                        if (int.Parse(variavel[1]) == 1 || int.Parse(variavel[1]) == 2)
                        {
                            lblRes.Location = new Point(52, grpzi.Y + 10);
                            lblTraco.Location = new Point(52, grpzi.Y + 30);
                            lblTracoSec.Location = new Point(76, grpzi.Y + 50);
                            lblSomaE.Text = "Soma";
                            lblSomaE2.Text = "Soma";
                            lblSomaE3.Text = "Soma";
                            lblTr.Text = "Traço";
                            lblTr2.Text = "Traço";
                            lblTr3.Text = "Traço";
                            lblTrSec.Text = "Secundario";
                            lblTrSec2.Text = "Secundario";
                            lblTrSec3.Text = "Secundario";
                        }
                        else
                        {
                            lblRes.Location = new Point(124, grpzi.Y + 10);
                            lblTraco.Location = new Point(100, grpzi.Y + 30);
                            lblTracoSec.Location = new Point(110, grpzi.Y + 50);
                            lblSomaE.Text = "Soma dos elementos:";
                            lblSomaE2.Text = "Soma dos elementos:";
                            lblSomaE3.Text = "Soma dos elementos:";
                            lblTr.Text = "Traço da matriz:";
                            lblTr2.Text = "Traço da matriz:";
                            lblTr3.Text = "Traço da matriz:";
                            lblTrSec.Text = "Traço secundario:";
                            lblTrSec2.Text = "Traço secundario:";
                            lblTrSec3.Text = "Traço secundario:";
                        }
                        lblRes.Text = result[0].ToString();
                        lblTr.Location = new Point(20, grpzi.Y + 30);
                        lblTr.Visible = true;
                        lblTraco.Text = traco[0].ToString();
                        lblTrSec.Location = new Point(20, grpzi.Y + 50);
                        lblTrSec.Visible = true;
                        lblTracoSec.Text = tracoSec[0].ToString();
                        chxAlteração.Visible = true;
                        mskTabela.Text = j1.ToString();
                        mskTabela.Focus();
                        cont++;
                    }
                    else
                    {
                        btnT1.Visible = false;
                        lblSomaE2.Location = new Point(grpzi2.X, grpzi2.Y + 10);
                        lblSomaE2.Visible = true;
                        lblRes2.Text = result[1].ToString();
                        if (int.Parse(j1) == 1 || int.Parse(j1) == 2 || int.Parse(variavel[1]) == 1 || int.Parse(variavel[1]) == 2)
                        {
                            lblRes2.Location = new Point(grpzi2.X + 33, grpzi2.Y + 10);
                            lblTraco2.Location = new Point(grpzi2.X + 33, grpzi2.Y + 30);
                            lblTracoSec2.Location = new Point(grpzi2.X + 56, grpzi2.Y + 50);
                            lblSomaE2.Text = "Soma";
                            lblTr2.Text = "Traço";
                            lblTrSec2.Text = "Secundario";
                        }
                        else
                        {
                            lblRes2.Location = new Point(grpzi2.X + 104, grpzi2.Y + 10);
                            lblTraco2.Location = new Point(grpzi2.X + 80, grpzi2.Y + 30);
                            lblTracoSec2.Location = new Point(grpzi2.X + 90, grpzi2.Y + 50);
                            lblSomaE2.Text = "Soma dos elementos:";
                            lblTr2.Text = "Traço da matriz:";
                            lblTrSec2.Text = "Traço secundario:";
                        }
                        lblTr2.Location = new Point(grpzi2.X, grpzi2.Y + 30);
                        lblTr2.Visible = true;
                        lblTraco2.Text = traco[1].ToString();
                        lblTrSec2.Location = new Point(grpzi2.X, grpzi2.Y + 50);
                        lblTrSec2.Visible = true;
                        lblTracoSec2.Text = tracoSec[1].ToString();
                        btnT2.Location = new Point(subs.X + 5, 177);
                        btnT2.Visible = true;
                        lblIgual.Location = new Point(subs.X + 5, lblSinal.Location.Y);
                        lblIgual.Visible = true;
                        btnResOp.Visible = true;
                        btnGerar.Enabled = false;
                        mskTabela.Enabled = false;
                        txtForm.Enabled = false;
                        btnResOp.Focus();
                    }
                }
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpar_Click(sender, e);
            }
        }

        #region formula
        public List<int> createIntList(int i, int j, string[] res)
        {
            try
            {
                List<int> lst = new List<int>();

                foreach (string it in res)
                {
                    switch (it)
                    {
                        case "i":
                            lst.Add(i);
                            break;
                        case "j":
                            lst.Add(j);
                            break;
                        default:
                            lst.Add(int.Parse(it));
                            break;
                    }
                }

                return lst;
            }
            catch (Exception ex) { throw ex; }

        }

        string returnName(List<int> lres, List<Match> listinha)
        {
            try
            {
                List<string> temp = new List<string>();

                foreach (Match val in listinha)
                {
                    temp.Add(val.Value);
                }

                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i] == "*")
                    {
                        lres[i + 1] = lres[i] * lres[i + 1];
                        lres.Remove(lres[i]);
                        temp.Remove(temp[i]);
                    }
                    else if (temp[i] == "/")
                    {
                        lres[i + 1] = lres[i] / lres[i + 1];
                        lres.Remove(lres[i]);
                        temp.Remove(temp[i]);
                    }

                }


                while (lres.Count > 0 && temp.Count > 0)
                {
                    switch (temp[0])
                    {
                        case "+":
                            lres[1] = lres[0] + lres[1];
                            break;
                        case "-":
                            lres[1] = lres[0] - lres[1];
                            break;
                    }

                    lres.Remove(lres[0]);
                    temp.Remove(temp[0]);
                }

                return lres[0].ToString();
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #endregion

        #region field click
        private void field_Click(Field field)
        {
            FrmText txt = new FrmText();

            string[] i = field.Name.Split(new char[] { '.' });

            if (!chxAlteração.Checked)
            {
                if (MessageBox.Show("Elemento: a" + i[0] + i[1] + System.Environment.NewLine + System.Environment.NewLine + "Você gostaria de alterar o valor da célula?", "Elemento...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    txt.ShowDialog();
                    if (txt.DialogResult != DialogResult.Cancel)
                    {
                        field.Text = txt.txtCel.Text;
                    }

                }
            }
            else
            {
                txt.ShowDialog();
                if (txt.DialogResult != DialogResult.Cancel)
                {
                    field.Text = txt.txtCel.Text;
                }
            }
        }
        #endregion

        #region Load
        private void FrmMult_Load(object sender, EventArgs e)
        {
            lblSinal.Visible = false;
            lblIgual.Visible = false;
            chxAlteração.Visible = false;

            btnT1.Visible = false;
            btnT2.Visible = false;
            btnT3.Visible = false;
            btnDeterminante.Visible = false;
            btnResOp.Visible = false;
            lblTrSec.Visible = false;
            lblSomaE.Visible = false;
            lblTr.Visible = false;
            lblTrSec2.Visible = false;
            lblSomaE2.Visible = false;
            lblTr2.Visible = false;
            lblTrSec3.Visible = false;
            lblSomaE3.Visible = false;
            lblTr3.Visible = false;

            txtForm.MaxLength = 8;

            this.WindowState = FormWindowState.Maximized;

            mskTabela.Focus();
        }
        #endregion
    
        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            errinho.Clear();
            lblSinal.Visible = false;

            btnT1.Visible = false;
            btnT2.Visible = false;
            btnT3.Visible = false;
            lblTrSec.Visible = false;
            lblSomaE.Visible = false;
            lblTr.Visible = false;
            lblRes.Text = "";
            lblTraco.Text = "";
            lblTracoSec.Text = "";
            lblTrSec2.Visible = false;
            lblSomaE2.Visible = false;
            lblTr2.Visible = false;
            lblRes2.Text = "";
            lblTraco2.Text = "";
            lblTracoSec2.Text = "";
            lblTrSec3.Visible = false;
            lblSomaE3.Visible = false;
            lblTr3.Visible = false;
            lblRes3.Text = "";
            lblTraco3.Text = "";
            lblTracoSec3.Text = "";
            lblIgual.Visible = false;
            lblTrSec.Text = "Traço secundário:";
            lblTr.Text = "Traço da matriz:";
            lblSomaE.Text = "Soma dos elementos:";
            lblTrSec2.Text = "Traço secundário:";
            lblTr2.Text = "Traço da matriz:";
            lblSomaE2.Text = "Soma dos elementos:";
            lblTrSec3.Text = "Traço secundário:";
            lblTr3.Text = "Traço da matriz:";
            lblSomaE3.Text = "Soma dos elementos:";

            mskTabela.Text = "";
            chxAlteração.Visible = false;
            mskTabela.Enabled = true;
            txtForm.Enabled = true;
            txtForm.Text = "";
            btnGerar.Enabled = true;
            btnResOp.Visible = false;
            btnResOp.Enabled = true;
            btnDeterminante.Visible = false;
            this.Controls.Remove(grp);
            this.Controls.Remove(grp2);
            this.Controls.Remove(grp3);

            ia = 0;
            result[0] = 0;
            result[1] = 0;
            result[2] = 0;
            traco[0] = 0;
            traco[1] = 0;
            traco[2] = 0;
            tracoSec[0] = 0;
            tracoSec[1] = 0;
            tracoSec[2] = 0;
            x = false;
            a = 20;
            click = -1;


            lblEx.Visible = true;
            mskTabela.Focus();


        }
        #endregion

        #region teclas
        private void Teclas(object sender, KeyEventArgs e)
        {
            if (mskTabela.MaskCompleted && e.KeyCode != Keys.Back)
            {
                txtForm.Focus();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnGerar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnLimpar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5 && btnResOp.Visible)
            {
                btnResOp_Click(sender, e);
            }
            if (e.KeyCode == Keys.Right)
            {
                txtForm.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                mskTabela.Focus();
            }
            if (e.KeyCode == Keys.F6)
            {
                if (chxAlteração.Visible)
                {
                    if (chxAlteração.Checked)
                    {
                        chxAlteração.Checked = false;
                    }
                    else
                    {
                        chxAlteração.Checked = true;
                    }
                }
            }
            if (e.KeyCode == Keys.T)
            {
                if (txtForm.Focused)
                {
                    string[] t = txtForm.Text.Split(new char[] { 't' });
                    txtForm.Text = t[0];
                }
                if (btnT1.Visible)
                {
                    btnT1_Click(sender, e);
                }
                else if (btnT2.Visible)
                {
                    btnT2_Click(sender, e);
                }
                else if (btnT3.Visible)
                {
                    btnT3_Click(sender, e);
                }
            }
        }
        #endregion

        #region Resultado click
        private void btnResOp_Click(object sender, EventArgs e)
        {
            Novo2(sender, e);
        }

        private void Novo2(object sender, EventArgs e, string ee = null)
        {
            try
            {
                if (j1 != variavel[0])
                {
                    if (MessageBox.Show("Não é possivel realizar a multiplicação dessas matrizes!!" + System.Environment.NewLine + System.Environment.NewLine + "Deseja reiniciar?", "erro...", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        btnLimpar_Click(sender, e);
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                this.Controls.Remove(grp3);
                if (ee != null)
                {
                    string x = i1;
                    i1 = variavel[1];
                    variavel[1] = x;
                }
                btnT2.Visible = false;
                traco[2] = 0;
                tracoSec[2] = 0;
                result[2] = 0;
                grpzi = new Point(lblIgual.Location.X + 50, 200);
                ponto = new Point(0, 0);
                this.grp3 = new System.Windows.Forms.GroupBox();
                grp3.Name = "grp1";
                grp3.Location = grpzi;
                int size = int.Parse(i1) * 30;
                int size2 = int.Parse(variavel[1]) * 35;
                grp3.Size = new Size(size2, size);
                grp3.Visible = true;
                this.Controls.Add(grp3);
                subs = new Point(lblIgual.Location.X + 50, 200);
                for (int i = 0; i < int.Parse(i1); i++)
                {
                    for (int j = 0; j < int.Parse(variavel[1]); j++)
                    {
                        Field novo = new Field();
                        novo.Click += (sender2, e2) => field_Click(novo);
                        novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1);
                        novo.Size = new Size(35, 30);
                        if (ee == null)
                        {
                            for (int t = 0; t < int.Parse(j1); t++)
                            {
                                Control[] lbl = grp2.Controls.Find(Convert.ToString(t + 1) + "." + Convert.ToString(j + 1) + " ", true);
                                Label lble = (Label)lbl[0];
                                Control[] lbl2 = grp.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(t + 1), true);
                                Label lble2 = (Label)lbl2[0];
                                resul1 += int.Parse(lble.Text) * int.Parse(lble2.Text);
                                result[2] += int.Parse(lble.Text) * int.Parse(lble2.Text);
                                if (i == j)
                                {
                                    traco[2] += int.Parse(lble.Text) * int.Parse(lble2.Text);
                                }
                                if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                                {
                                    tracoSec[2] += int.Parse(lble.Text) * int.Parse(lble2.Text);
                                }
                            }
                            novo.Text = resul1.ToString();
                            resul1 = 0;
                        }
                        else
                        {
                            if (i == j)
                            {
                                traco[2] += resu[j * int.Parse(i1) + i];
                            }
                            if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                            {
                                tracoSec[2] += resu[j * int.Parse(i1) + i];
                            }
                            result[2] += resu[j * int.Parse(i1) + i];
                            novo.Text = resu[j * int.Parse(i1) + i].ToString();
                        }
                        novo.Location = ponto;
                        novo.BorderStyle = BorderStyle.FixedSingle;
                        novo.Font = new Font("Arial", 8);
                        this.Controls.Add(novo);
                        this.grp3.Controls.Add(novo);
                        ponto.X += 35;
                        grpzi.X += 35;
                    }
                    ponto.Y += 30;
                    subs.Y += 30;
                    ponto.X = 0;
                    if (i != int.Parse(i1) - 1)
                    {
                        grpzi.X = lblIgual.Location.X + 50;
                    }
                }
                lblSomaE3.Location = new Point(subs.X, subs.Y + 10);
                lblSomaE3.Visible = true;
                if (int.Parse(variavel[0]) == 1 || int.Parse(variavel[0]) == 2)
                {
                    lblRes3.Location = new Point(subs.X + 33, subs.Y + 10);
                    lblTraco3.Location = new Point(subs.X + 33, subs.Y + 30);
                    lblTracoSec3.Location = new Point(subs.X + 56, subs.Y + 50);
                }
                else
                {
                    lblRes3.Location = new Point(subs.X + 104, subs.Y + 10);
                    lblTraco3.Location = new Point(subs.X + 80, subs.Y + 30);
                    lblTracoSec3.Location = new Point(subs.X + 90, subs.Y + 50);
                }
                btnT3.Location = new Point(grpzi.X, 177);
                btnT3.Visible = true;
                lblRes3.Text = result[2].ToString();
                lblTr3.Location = new Point(subs.X, subs.Y + 30);
                lblTr3.Visible = true;
                lblTraco3.Text = traco[2].ToString();
                lblTrSec3.Location = new Point(subs.X, subs.Y + 50);
                lblTrSec3.Visible = true;
                lblTracoSec3.Text = tracoSec[2].ToString();
                if (ee != null)
                {
                    btnResOp.Enabled = false;
                    btnT3.Focus();
                }
                txtForm.Focus();
                btnDeterminante.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpar_Click(sender, e);
            }
        }
        #endregion

        #region leave
       
        private void txtForm_Leave()
        {
            try
            {
                string[] res1;
                string[] res2;
                if (txtForm.Text.IndexOf('i') > -1)
                {
                    res1 = txtForm.Text.Split(new char[] { 'i' });
                    if (res1[0] != "" && res1[0].IndexOf(mult, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(div, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(soma, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(sub, res1[0].Length - 1, 1) == -1)
                    {
                        txtForm.Text = res1[0] + "*" + "i" + res1[1];
                    }
                }
                if (txtForm.Text.IndexOf('j') > -1)
                {
                    res2 = txtForm.Text.Split(new char[] { 'j' });
                    if (res2[0] != "" && res2[0].IndexOf(mult, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(div, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(soma, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(sub, res2[0].Length - 1, 1) == -1)
                    {
                        txtForm.Text = res2[0] + "*" + "j" + res2[1];
                    }
                }
                if (txtForm.Text.IndexOf('j') > -1 && txtForm.Text.IndexOf('i') > -1)
                {
                    res1 = txtForm.Text.Split(new char[] { 'i' });
                    res2 = txtForm.Text.Split(new char[] { 'j' });
                    if (res1[0].IndexOf('j') > -1)
                    {
                        if (res1[0].IndexOf(soma, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(sub, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(mult, res1[0].Length - 1, 1) == -1 && res1[0].IndexOf(div, res1[0].Length - 1, 1) == -1)
                        {
                            txtForm.Text = res1[0] + "*" + "i" + res1[1];
                        }
                    }
                    if (res2[0].IndexOf('i') > -1)
                    {
                        if (res2[0].IndexOf(soma, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(sub, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(mult, res2[0].Length - 1, 1) == -1 && res2[0].IndexOf(div, res2[0].Length - 1, 1) == -1)
                        {
                            txtForm.Text = res2[0] + "*" + "j" + res2[1];
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }
            
        }
        #endregion

        #region Transposta
        private void btnT1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Remove(grp);
                conte = 0;
                resu = new int[int.Parse(i1) * int.Parse(j1)];
                Control[] lbl = new Control[int.Parse(i1) * int.Parse(j1)];
                for (int i = 0; i < int.Parse(i1); i++)
                {
                    for (int j = 0; j < int.Parse(j1); j++)
                    {
                        lbl = grp.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(j + 1), true);
                        Label lbl2 = (Label)lbl[0];
                        resu[conte] = int.Parse(lbl2.Text);
                        conte++;
                    }
                }
                Novo(sender, e, 0, "aa");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpar_Click(sender, e);
            }
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Remove(grp2);
                conte = 0;
                resu = new int[int.Parse(variavel[0]) * int.Parse(variavel[1])];
                Control[] lbl = new Control[int.Parse(variavel[0]) * int.Parse(variavel[1])];
                for (int i = 0; i < int.Parse(variavel[0]); i++)
                {
                    for (int j = 0; j < int.Parse(variavel[1]); j++)
                    {
                        lbl = grp2.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(j + 1) + " ", true);
                        Label lble = (Label)lbl[0];
                        resu[conte] = int.Parse(lble.Text);
                        conte++;
                    }
                }
                Novo(sender, e, 1, "aa");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpar_Click(sender, e);
            }
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Remove(grp3);
                conte = 0;
                resu = new int[int.Parse(i1) * int.Parse(variavel[1])];
                Control[] lbl = new Control[int.Parse(i1) * int.Parse(variavel[1])];
                for (int i = 0; i < int.Parse(i1); i++)
                {
                    for (int j = 0; j < int.Parse(variavel[1]); j++)
                    {
                        lbl = grp3.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(j + 1), true);
                        Label lble = (Label)lbl[0];
                        resu[conte] = int.Parse(lble.Text);
                        conte++;
                    }
                }
                Novo2(sender, e, "aa");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message, "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLimpar_Click(sender, e);
            }

        }
        #endregion

        #region Determinante
        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            if (int.Parse(i1) != int.Parse(variavel[1]))
            {
                MessageBox.Show("Não é possivel realizar o calculo de uma matriz não quadrada", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (int.Parse(i1) == 1 && int.Parse(variavel[1]) == 1)
                {
                    Control[] lb = grp3.Controls.Find(1 + "." + 1, true);
                    Label lbz = (Label)lb[0];
                    MessageBox.Show("O determinante é: " + lbz.Text, "Determinante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(i1) == 2 && int.Parse(variavel[1]) == 2)
                {
                    List<int> tracos = new List<int>();
                    for (int i = 1; i < 3; i++)
                    {
                        Control[] lb = grp3.Controls.Find(i.ToString() + "." + i.ToString(), true);
                        tracos.Add(int.Parse(lb[0].Text));
                    }
                    int traco1 = tracos[0] * tracos[1];
                    tracos.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        int val = 2;
                        Control[] lb = grp3.Controls.Find(Convert.ToString(val - (i + 1) + i * 2) + "." + Convert.ToString(val - i), true);
                        tracos.Add(int.Parse(lb[0].Text));
                    }
                    int traco2 = tracos[0] * tracos[1];
                    MessageBox.Show("O determinante é: " + Convert.ToString(traco1 - traco2), "Determinante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(i1) == 3 && int.Parse(variavel[1]) == 3)
                {
                    int[] trs = { 1, 1, 1, 1, 1, 1 };
                    int cont = 0;
                    int deter = 0;
                    int[] matriz = new int[15];
                    foreach (Label lb in grp3.Controls)
                    {
                        if (cont == 3 || cont == 8)
                            cont += 2;
                        matriz[cont] = (int.Parse(lb.Text));
                        if (cont != 2 && cont != 7 && cont != 12)
                            matriz[cont + 3] = int.Parse(lb.Text);
                        cont++;
                    }
                    for (int t = 0; t < 6; t++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            if (t < 3)
                                trs[t] *= matriz[(c * 6) + t];
                            else
                                trs[t] *= matriz[(c * 4) + (t - 1)];
                        }
                        if (t < 3)
                            deter += trs[t];
                        else
                            deter -= trs[t];
                    }
                    MessageBox.Show("O determinante é: " + deter.ToString(), "Determinante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(i1) == 4 && int.Parse(variavel[1]) == 4)
                {
                    // formula é: a11.c11 + a21.c21 + a31.c31 + a41.c41
                    // cij = (-1)^i+j . Dij
                    int cont = 0;
                    int[] trs = { 1, 1, 1, 1, 1, 1 };
                    int[] deter = new int[4];
                    int deterall = 0;
                    int[] c = new int[4];
                    int[,] matriz = new int[15, 4];
                    int[] a = new int[4];

                    for (int t = 0; t < 4; t++)
                    {
                        cont = 0;
                        for (int k = 0; k < 6; k++)
                        {
                            trs[k] = 1;
                        }
                        foreach (Label lb in grp3.Controls)
                        {
                            string[] i = lb.Name.Split(new char[] { '.' });
                            if (i[1] == "1")
                            {
                                if (t == 0)
                                {
                                    a[int.Parse(i[0]) - 1] = int.Parse(lb.Text);
                                }
                                continue;
                            }
                            if (i[0].IndexOf(Convert.ToString(t + 1)) != -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (cont == 3 || cont == 8)
                                    cont += 2;
                                matriz[cont, t] = (int.Parse(lb.Text));
                                if (cont != 2 && cont != 7 && cont != 12)
                                    matriz[cont + 3, t] = int.Parse(lb.Text);
                                cont++;
                            }
                        }
                        for (int u = 0; u < 6; u++)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (u < 3)
                                    trs[u] *= matriz[(l * 6) + u, t];
                                else
                                    trs[u] *= matriz[(l * 4) + (u - 1), t];
                            }
                            if (u < 3)
                                deter[t] += trs[u];
                            else
                                deter[t] -= trs[u];
                        }
                        if (t % 2 == 0)
                        {
                            c[t] = deter[t];
                        }
                        else
                        {
                            c[t] = deter[t] * -1;
                        }
                    }
                    deterall = (a[0] * c[0]) + (a[1] * c[1]) + (a[2] * c[2]) + (a[3] * c[3]);
                    MessageBox.Show("O determinante é: " + deterall.ToString(), "Determinante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O calculo para matrizes maiores que 3 ainda está em desenvolvimento", "Erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        #endregion
    }
}
