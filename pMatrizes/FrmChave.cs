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
            if (MessageBox.Show("Isso pode demorar alguns segundos deseja continuar?", "Alerta...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                while (Gerar() == "vorta")
                {
                    Gerar();
                }
            }
        }
        #endregion

        #region Gerar
        private string Gerar()
        {
            int resul = 0;
            string simb = "";
            Random rd = new Random();
            List<int> lst = new List<int>();
            List<string> lst2 = new List<string>();

            for (int i = 0; i < 26; i++)
            {
                resul = rd.Next(1, 26);
                if (resul == 1 && !lst.Contains(1))
                {
                    simb = "A";
                    lst.Add(1);
                }
                else if (resul == 1)
                {
                    resul = rd.Next(2, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(2, 26);
                        else
                            break;
                    }
                }
                if (resul == 2 && !lst.Contains(2))
                {
                    simb = "B";
                    lst.Add(2);
                }
                else if (resul == 2)
                {
                    resul = rd.Next(3, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(3, 26);
                        else
                            break;
                    }
                }
                if (resul == 3 && !lst.Contains(3))
                {
                    simb = "C";
                    lst.Add(3);
                }
                else if (resul == 3)
                {
                    resul = rd.Next(4, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(4, 26);
                        else
                            break;
                    }
                }
                if (resul == 4 && !lst.Contains(4))
                {
                    simb = "D";
                    lst.Add(4);
                }
                else if (resul == 4)
                {
                    resul = rd.Next(5, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(5, 26);
                        else
                            break;
                    }
                }
                if (resul == 5 && !lst.Contains(5))
                {
                    simb = "E";
                    lst.Add(5);
                }
                else if (resul == 5)
                {
                    resul = rd.Next(6, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(6, 26);
                        else
                            break;
                    }
                }
                if (resul == 6 && !lst.Contains(6))
                {
                    simb = "F";
                    lst.Add(6);
                }
                else if (resul == 6)
                {
                    resul = rd.Next(7, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(7, 26);
                        else
                            break;
                    }
                }
                if (resul == 7 && !lst.Contains(7))
                {
                    simb = "G";
                    lst.Add(7);
                }
                else if (resul == 7)
                {
                    resul = rd.Next(8, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(8, 26);
                        else
                            break;
                    }
                }
                if (resul == 8 && !lst.Contains(8))
                {
                    simb = "H";
                    lst.Add(8);
                }
                else if (resul == 8)
                {
                    resul = rd.Next(9, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(9, 26);
                        else
                            break;
                    }
                }
                if (resul == 9 && !lst.Contains(9))
                {
                    simb = "I";
                    lst.Add(9);
                }
                else if (resul == 9)
                {
                    resul = rd.Next(10, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(10, 26);
                        else
                            break;
                    }
                }
                if (resul == 10 && !lst.Contains(10))
                {
                    simb = "J";
                    lst.Add(10);
                }
                else if (resul == 10)
                {
                    resul = rd.Next(11, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(11, 26);
                        else
                            break;
                    }
                }
                if (resul == 11 && !lst.Contains(11))
                {
                    simb = "K";
                    lst.Add(11);
                }
                else if (resul == 11)
                {
                    resul = rd.Next(12, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(12, 26);
                        else
                            break;
                    }
                }
                if (resul == 12 && !lst.Contains(12))
                {
                    simb = "L";
                    lst.Add(12);
                }
                else if (resul == 12)
                {
                    resul = rd.Next(13, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(13, 26);
                        else
                            break;
                    }
                }
                if (resul == 13 && !lst.Contains(13))
                {
                    simb = "M";
                    lst.Add(13);
                }
                else if (resul == 13)
                {
                    resul = rd.Next(14, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(14, 26);
                        else
                            break;
                    }
                }
                if (resul == 14 && !lst.Contains(14))
                {
                    simb = "N";
                    lst.Add(14);
                }
                else if (resul == 14)
                {
                    resul = rd.Next(15, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(15, 26);
                        else
                            break;
                    }
                }
                if (resul == 15 && !lst.Contains(15))
                {
                    simb = "O";
                    lst.Add(15);
                }
                else if (resul == 15)
                {
                    resul = rd.Next(16, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(16, 26);
                        else
                            break;
                    }
                }
                if (resul == 16 && !lst.Contains(16))
                {
                    simb = "P";
                    lst.Add(16);
                }
                else if (resul == 16)
                {
                    resul = rd.Next(17, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(17, 26);
                        else
                            break;
                    }
                }
                if (resul == 17 && !lst.Contains(17))
                {
                    simb = "Q";
                    lst.Add(17);
                }
                else if (resul == 17)
                {
                    resul = rd.Next(18, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(18, 26);
                        else
                            break;
                    }
                }
                if (resul == 18 && !lst.Contains(18))
                {
                    simb = "R";
                    lst.Add(18);
                }
                else if (resul == 18)
                {
                    resul = rd.Next(19, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(19, 26);
                        else
                            break;
                    }
                }
                if (resul == 19 && !lst.Contains(19))
                {
                    simb = "S";
                    lst.Add(19);
                }
                else if (resul == 19)
                {
                    resul = rd.Next(20, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(20, 26);
                        else
                            break;
                    }
                }
                if (resul == 20 && !lst.Contains(20))
                {
                    simb = "T";
                    lst.Add(20);
                }
                else if (resul == 20)
                {
                    resul = rd.Next(21, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(21, 26);
                        else
                            break;
                    }
                }
                if (resul == 21 && !lst.Contains(21))
                {
                    simb = "U";
                    lst.Add(21);
                }
                else if (resul == 21)
                {
                    resul = rd.Next(22, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(22, 26);
                        else
                            break;
                    }
                }
                if (resul == 22 && !lst.Contains(22))
                {
                    simb = "V";
                    lst.Add(22);
                }
                else if (resul == 22)
                {
                    resul = rd.Next(23, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(23, 26);
                        else
                            break;
                    }
                }
                if (resul == 23 && !lst.Contains(23))
                {
                    simb = "W";
                    lst.Add(23);
                }
                else if (resul == 23)
                {
                    resul = rd.Next(24, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(24, 26);
                        else
                            break;
                    }
                }
                if (resul == 24 && !lst.Contains(24))
                {
                    simb = "X";
                    lst.Add(24);
                }
                else if (resul == 24)
                {
                    resul = rd.Next(25, 26);
                    for (int j = 0; j < 3; j++)
                    {
                        if (lst.Contains(resul))
                            resul = rd.Next(25, 26);
                        else
                            break;
                    }
                }
                if (resul == 25 && !lst.Contains(25))
                {
                    simb = "Y";
                    lst.Add(25);
                }
                else if (resul == 25)
                {
                    resul = 26;
                }
                if (resul == 26 && !lst.Contains(26))
                {
                    simb = "Z";
                    lst.Add(26);
                }
                if (!lst2.Contains(simb))
                {
                    txt[i].Text = simb;
                    lst2.Add(simb);
                }
                else
                    return "vorta";
            }
            return "certo";
        }
        #endregion
    }
}

