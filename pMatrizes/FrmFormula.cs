using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class FrmFormula : Form
    {
        char mult = '*';
        char sub = '-';
        char soma = '+';
        char div = '/';
        MatchCollection collect;

        int result = 0;
        int traco = 0;
        int tracoSec = 0;
        bool x = false;

        private static int SortByIndex(Match n1, Match n2)
        {
            return n1.Index.CompareTo(n2.Index);
        }

        public FrmFormula()
        {
            InitializeComponent();
        }

        public bool consistir()
        {
            try
            {
                string[] valv = mskTabela.Text.Split(new char[] { '.' });
                if (!mskTabela.MaskCompleted)
                {
                    errinho.SetError(mskTabela, "preencha o campo corretamente!!");
                    x = true;
                }
                if (int.Parse(valv[0]) > 15 || int.Parse(valv[1]) > 15)
                {
                    errinho.SetError(mskTabela, "O limite da matriz é 15 x 15!!");
                    x = true;
                }
                if (x)
                    return false;
                else
                    return true;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (consistir())
                {
                    leave();
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

                    Point ponto = new Point(10, 10);
                    foreach (Control item in Controls.OfType<Field>().ToList())
                    {
                        Controls.Remove(item);
                    }
                    for (int i = 0; i < int.Parse(variavel[0]); i++)
                    {
                        for (int j = 0; j < int.Parse(variavel[1]); j++)
                        {
                            if (i == j)
                            {
                                traco += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                            }
                            if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                            {
                                tracoSec += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                            }
                            Field novo = new Field();
                            novo.Click += (sender2, e2) => field_Click(novo);
                            novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1);
                            novo.Text = returnName(createIntList(i + 1, j + 1, res), listinha);
                            result += int.Parse(returnName(createIntList(i + 1, j + 1, res), listinha));
                            novo.Size = new Size(30, 30);
                            novo.Location = ponto;
                            novo.BorderStyle = BorderStyle.FixedSingle;
                            novo.Font = new Font("Arial", 8);
                            this.Controls.Add(novo);

                            ponto.X += 30;
                        }
                        ponto.Y += 30;
                        if (i != int.Parse(variavel[0]) - 1)
                        {
                            ponto.X = 10;
                        }
                    }
                    Point pontinho = new Point(ponto.X + 20, 10);
                    grpFormula.Location = pontinho;
                    lblSomaE.Location = new Point(ponto.X + 20, 110);
                    lblSomaE.Visible = true;
                    lblRes.Location = new Point(ponto.X + 124, 110);
                    lblRes.Text = result.ToString();
                    lblTr.Location = new Point(ponto.X + 20, 140);
                    lblTr.Visible = true;
                    lblTraco.Location = new Point(ponto.X + 100, 140);
                    lblTraco.Text = traco.ToString();
                    lblTrSec.Location = new Point(ponto.X + 20, 170);
                    lblTrSec.Visible = true;
                    lblTracoSec.Location = new Point(ponto.X + 110, 170);
                    lblTracoSec.Text = tracoSec.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro durante o processo erro: " + ex.Message);
            }
        }

        private void field_Click(Field field)
        {
            string[] i = field.Name.Split(new char[] {'.'});

            MessageBox.Show("Elemento: a" + i[0] + i[1], "Elemento...");
        }
        
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

        private void FrmFormula_Load(object sender, EventArgs e)
        {
            lblTrSec.Visible = false;
            lblSomaE.Visible = false;
            lblTr.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            mskTabela.Focus();
        }

        private void mskTabela_KeyDown(object sender, KeyEventArgs e)
        {
            if (mskTabela.MaskCompleted && e.KeyCode != Keys.Back)
            {
                txtForm.Focus();
            }
        }

        private void leave()
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
        
    }
}
