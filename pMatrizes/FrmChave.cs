using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmChave : Form
    {
        #region variáveis
        bool l = true;
        TextBox[] txt = new TextBox[26];
        int cont = 0;
        #endregion

        #region Construtor
        public FrmChave(string aa = null)
        {
            InitializeComponent();
            if (aa != null)
            {
                btnConChave.Location = new Point(87, 167);
                btnCancel.Visible = true;
                l = false;
            }
        }
        #endregion

        #region Consistir
        public bool consistir()
        {
            for (int i = 0; i < 26; i++)
            {
                if (txt[i].Text == "")
                {
                    if (MessageBox.Show("Para continuar todos os campos precisam estar preenchidos! \n \n Deseja continuar mesmo assim?", "Alerta...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            }
            return true;
        }
        #endregion

        #region Load
        private void FrmChave_Load(object sender, EventArgs e)
        {
            if (l)
                btnConChave.Location = new Point(122, 162);
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                txt[cont] = text;
                text.MaxLength = 1;
                text.Name = cont.ToString();
                cont++;
            }
        }
        #endregion

        #region Confirmar Chave
        private void btnConChave_Click(object sender, EventArgs e)
        {
            cont = 0;
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                txt[cont] = text;
                cont++;
            }
            if (consistir())
            {
                this.DialogResult = DialogResult.Yes;
            }
        }
        #endregion

        #region Teclas
        private void Teclas(Object sender, KeyEventArgs e)
        {
            int con = Controle();
            if (e.KeyCode == Keys.Left)
            {
                if (con == 25)
                {
                    return;
                }
                else
                {
                    txt[con + 1].Focus();
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (con == 0)
                {
                    return;
                }
                else
                {
                    txt[con - 1].Focus();
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                if (MessageBox.Show("Deseja limpar os campos?", "limpar..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    btnLimpar_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                btnConChave_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5 && btnCancel.Visible)
            {
                btnCancel_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnGerarChave_Click(sender, e);
            }
            
        }
        #endregion

        #region Controle
        private int Controle()
        {
            cont = 0;
            Control ct = this.ActiveControl;
            List<TextBox> t = new List<TextBox>();
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                if (text.Location == ct.Location)
                {
                    return int.Parse(text.Name);
                }
                else if (cont == 25)
                {
                    return -1;
                }
            }
            return -1;
        }
        #endregion

        #region Click dos botões
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                txt[i].Clear();
            }
        }

        private void btnGerarChave_Click(object sender, EventArgs e)
        {
            int resul = 0;
            string simb = "";
            Random rd = new Random();
            List<int> lst = new List<int>();
            for (int i = 0; i < 26; i++)
            {
                resul = rd.Next(1, 27);
                while (lst.Contains(resul))
                {
                    resul = rd.Next(1, 27);
                }
                switch (resul)
                {
                    case 1:
                        simb = "A";
                        lst.Add(resul);
                        break;
                    case 2:
                        simb = "B";
                        lst.Add(resul);
                        break;
                    case 3:
                        simb = "C";
                        lst.Add(resul);
                        break;
                    case 4:
                        simb = "D";
                        lst.Add(resul);
                        break;
                    case 5:
                        simb = "E";
                        lst.Add(resul);
                        break;
                    case 6:
                        simb = "F";
                        lst.Add(resul);
                        break;
                    case 7:
                        simb = "G";
                        lst.Add(resul);
                        break;
                    case 8:
                        simb = "H";
                        lst.Add(resul);
                        break;
                    case 9:
                        simb = "I";
                        lst.Add(resul);
                        break;
                    case 10:
                        simb = "J";
                        lst.Add(resul);
                        break;
                    case 11:
                        simb = "K";
                        lst.Add(resul);
                        break;
                    case 12:
                        simb = "L";
                        lst.Add(resul);
                        break;
                    case 13:
                        simb = "M";
                        lst.Add(resul);
                        break;
                    case 14:
                        simb = "N";
                        lst.Add(resul);
                        break;
                    case 15:
                        simb = "O";
                        lst.Add(resul);
                        break;
                    case 16:
                        simb = "P";
                        lst.Add(resul);
                        break;
                    case 17:
                        simb = "Q";
                        lst.Add(resul);
                        break;
                    case 18:
                        simb = "R";
                        lst.Add(resul);
                        break;
                    case 19:
                        simb = "S";
                        lst.Add(resul);
                        break;
                    case 20:
                        simb = "T";
                        lst.Add(resul);
                        break;
                    case 21:
                        simb = "U";
                        lst.Add(resul);
                        break;
                    case 22:
                        simb = "V";
                        lst.Add(resul);
                        break;
                    case 23:
                        simb = "W";
                        lst.Add(resul);
                        break;
                    case 24:
                        simb = "X";
                        lst.Add(resul);
                        break;
                    case 25:
                        simb = "Y";
                        lst.Add(resul);
                        break;
                    case 26:
                        simb = "Z";
                        lst.Add(resul);
                        break;
                }
                txt[i].Text = simb;
            }
        }
        #endregion
    }
}

