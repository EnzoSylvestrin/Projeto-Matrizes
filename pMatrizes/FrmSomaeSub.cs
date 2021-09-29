using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class FrmSomaeSub : Form
    {
        public FrmSomaeSub()
        {
            InitializeComponent();
        }

        #region variaveis
        char mult = '*';
        char sub = '-';
        char soma = '+';
        char div = '/';
        MatchCollection collect;

        int contador = 0;
        int cont = 0;
        int ia = 0;
        int[] result = { 0, 0, 0 };
        int[] traco = { 0, 0, 0 };
        int[] tracoSec = { 0, 0, 0 };
        bool x = false;
        int click = 0;
        int a = 20;
        Point ponto;
        Point ponti;
        Point subs;
        Point grpzi;
        Point grpzi2;

        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.GroupBox grp2;
        #endregion

        #region consistir
        public bool consistir()
        {
            try
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
            try
            {
                click += 1;
                if (consistir() && click < 3)
                {
                    txtForm_Leave(sender, e);
                    lblEx.Visible = false;
                    errinho.Clear();
                    List<Match> listinha = new List<Match>();
                    string[] variavel = mskTabela.Text.Split(new char[] { '.' });
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
                        for (int s = 0; s < int.Parse(variavel[1]); s++)
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
                            novo.Text = returnName(createIntList(i + 1, j + 1, res), listinha);
                            if (cont == 0)
                            {
                                result[0] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                            }
                            else
                            {
                                result[1] += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
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
                            }
                            else
                            {
                                this.grp2.Controls.Add(novo);
                            }
                            
                            if (cont == 0)
                            {
                                ponto.X += 30;
                                grpzi.X += 30;
                            }
                            else
                            {
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
                        }
                        lblRes.Text = result[0].ToString();
                        lblTr.Location = new Point(20, grpzi.Y + 30);
                        lblTr.Visible = true;
                        lblTraco.Text = traco[0].ToString();
                        lblTrSec.Location = new Point(20, grpzi.Y + 50);
                        lblTrSec.Visible = true;
                        lblTracoSec.Text = tracoSec[0].ToString();
                        mskTabela.Enabled = false;
                        chxAlteração.Visible = true;
                    }
                    else
                    {
                        lblSomaE2.Location = new Point(grpzi2.X, grpzi2.Y + 10);
                        lblSomaE2.Visible = true;
                        lblRes2.Text = result[1].ToString();
                        if (int.Parse(variavel[1]) == 1 || int.Parse(variavel[1]) == 2)
                        {
                            lblRes2.Location = new Point(grpzi2.X + 33, grpzi2.Y + 10);
                            lblTraco2.Location = new Point(grpzi2.X + 33, grpzi2.Y + 30);
                            lblTracoSec2.Location = new Point(grpzi2.X + 56, grpzi2.Y + 50);
                        }
                        else
                        {
                            lblRes2.Location = new Point(grpzi2.X + 104, grpzi2.Y + 10);
                            lblTraco2.Location = new Point(grpzi2.X + 80, grpzi2.Y + 30);
                            lblTracoSec2.Location = new Point(grpzi2.X + 90, grpzi2.Y + 50);
                        }
                        lblTr2.Location = new Point(grpzi2.X, grpzi2.Y + 30);
                        lblTr2.Visible = true;
                        lblTraco2.Text = traco[1].ToString();
                        lblTrSec2.Location = new Point(grpzi2.X, grpzi2.Y + 50);
                        lblTrSec2.Visible = true;
                        lblTracoSec2.Text = tracoSec[1].ToString();
                        lblIgual.Location = new Point(subs.X + 5, grpzi2.Y - ia);
                        lblIgual.Visible = true;
                        btnResOp.Visible = true;
                        btnGerar.Enabled = false;
                    }
                    if (cont == 0)
                    {
                        cont += 1;
                    }
                    txtForm.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message);
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
        private void FrmSomaeSub_Load(object sender, EventArgs e)
        {
            lblSinal.Visible = false;
            lblIgual.Visible = false;
            chxAlteração.Visible = false;
            
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

        #region click Sinal
        private void lblSinal_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                lblSinal.Text = "-";
                contador += 1;
            }
            else if (contador == 1)
            {
                lblSinal.Text = "/";
                contador += 1;
            }
            else if (contador == 2)
            {
                lblSinal.Text = "+";
                contador = 0;
            }

            if (btnResOp.Visible)
            {
                btnResOp_Click(sender, e);
            }

        }
        #endregion

        #region Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblSinal.Visible = false;

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
            lblSinal.Text = "+";
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
            txtForm.Text = "";
            btnGerar.Enabled = true;
            btnResOp.Visible = false;
            this.Controls.Remove(grp);
            this.Controls.Remove(grp2);

            contador = 0;
            ia = 0;
            click = 0;
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
            
            if (cont > 0)
            {
                foreach (Control item in Controls.OfType<Field>().ToList())
                {
                    Controls.Remove(item);
                }
            }
            cont = 0;

            lblEx.Visible = true;
            mskTabela.Focus();


        }
        #endregion

        #region teclas
        private void mskTabela_KeyDown(object sender, KeyEventArgs e)
        {
            Teclas(sender, e);
        }

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
        }

        private void txtForm_KeyDown(object sender, KeyEventArgs e)
        {
            Teclas(sender, e);
        }
        #endregion

        #region Resultado click
        private void btnResOp_Click(object sender, EventArgs e)
        {
            traco[2] = 0;
            tracoSec[2] = 0;
            result[2] = 0;
            foreach (Control item in Controls.OfType<Field>().ToList())
            {
                Controls.Remove(item);
            }
            subs = new Point(lblIgual.Location.X + 50, 200);
            string[] variavel = mskTabela.Text.Split(new char[] { '.' });
            for (int i = 0; i < int.Parse(variavel[0]); i++)
            {
                for(int j = 0; j < int.Parse(variavel[1]); j++)
                {
                    Field novo = new Field();
                    novo.Click += (sender2, e2) => field_Click(novo);
                    novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1);
                    Control[] lbl = grp.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(j + 1), true);
                    Label lble = lbl[0] as Label;
                    Control[] lbl2 = grp2.Controls.Find(Convert.ToString(i + 1) + "." + Convert.ToString(j + 1) + " ", true);
                    Label lble2 = (Label)lbl2[0];
                    if (i == j && lblSinal.Text == "+")
                    {
                        traco[2] += int.Parse(lble.Text) + int.Parse(lble2.Text);
                    }
                    else if (i == j && lblSinal.Text == "-")
                    {
                        traco[2] += int.Parse(lble.Text) - int.Parse(lble2.Text);
                    }
                    else if (i == j && lblSinal.Text == "/")
                    {
                        if (int.Parse(lble2.Text) == 0)
                        {
                            foreach (Control item in Controls.OfType<Field>().ToList())
                            {
                                Controls.Remove(item);
                            }
                            traco[2] = 0;
                            tracoSec[2] = 0;
                            result[2] = 0;
                            MessageBox.Show("impossivel dividir por 0", "erro...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        traco[2] += int.Parse(lble.Text) / int.Parse(lble2.Text);
                    }
                    if (lblSinal.Text == "+")
                    {
                        novo.Text = Convert.ToString(int.Parse(lble.Text) + int.Parse(lble2.Text));
                        result[2] += int.Parse(lble.Text) + int.Parse(lble2.Text);
                    }
                    else if (lblSinal.Text == "-")
                    {
                        novo.Text = Convert.ToString(int.Parse(lble.Text) - int.Parse(lble2.Text));
                        result[2] += int.Parse(lble.Text) - int.Parse(lble2.Text);
                    }
                    else
                    {
                        novo.Text = Convert.ToString(float.Parse(lble.Text) / float.Parse(lble2.Text));
                        result[2] += int.Parse(lble.Text) / int.Parse(lble2.Text);
                    }
                    if (1 + i + j + 1 == int.Parse(variavel[1]) + 1 && lblSinal.Text == "+")
                    {
                        tracoSec[2] += int.Parse(lble.Text) + int.Parse(lble2.Text);
                    }
                    else if (1 + i + j + 1 == int.Parse(variavel[1]) + 1 && lblSinal.Text == "-")
                    {
                        tracoSec[2] += int.Parse(lble.Text) - int.Parse(lble2.Text);
                    }
                    if (1 + i + j + 1 == int.Parse(variavel[1]) + 1 && lblSinal.Text == "/")
                    {
                        tracoSec[2] += int.Parse(lble.Text) / int.Parse(lble2.Text);
                    }
                    novo.Size = new Size(30, 30);
                    novo.Location = subs;
                    novo.BorderStyle = BorderStyle.FixedSingle;
                    novo.Font = new Font("Arial", 8);
                    this.Controls.Add(novo);

                    subs.X += 30;
                }
                subs.Y += 30;
                subs.X = lblIgual.Location.X + 50;
            }
            lblSomaE3.Location = new Point(subs.X, subs.Y + 10);
            lblSomaE3.Visible = true;
            if (int.Parse(variavel[1]) == 1 || int.Parse(variavel[1]) == 2)
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
            lblRes3.Text = result[2].ToString();
            lblTr3.Location = new Point(subs.X, subs.Y + 30);
            lblTr3.Visible = true;       
            lblTraco3.Text = traco[2].ToString();
            lblTrSec3.Location = new Point(subs.X, subs.Y + 50);
            lblTrSec3.Visible = true;
            lblTracoSec3.Text = tracoSec[2].ToString();
            txtForm.Focus();
        }
        #endregion

        #region leave
        private void txtForm_Leave(object sender, EventArgs e)
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
        #endregion
    }
}

