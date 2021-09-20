using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMatrizes : Form
    {
        #region Variaveis
        int somaRes = 0;
        double somaResDiv = 0;
        int traco = 0;
        int tracosec = 0;
        double tracosecDiv = 0;
        double tracoDiv = 0;
        #endregion

        public FrmMatrizes()
        {
            InitializeComponent();
        }

        #region Consistir
        public bool Consistir(string OP)
        {
            erro.Clear();
            int valor;
            bool x = false;
            bool y = false;
            string[] valv1;
            if (grpSS.Visible)
            {
                valv1 = mskTabela.Text.Split(new char[] { '.' });
                if (mskTabela.MaskCompleted == false)
                {
                    erro.SetError(mskTabela, "Preencha o campo com os valores corretos!!");
                    x = true;
                }
                if (!int.TryParse(txtConst.Text, out valor))
                {
                    erro.SetError(txtConst, "Coloque apenas valores inteiros neste campo!!");
                    y = true;
                }
                if (x == false && (int.Parse(valv1[0]) > 13 || int.Parse(valv1[1]) > 13 || int.Parse(valv1[0]) < 1 || int.Parse(valv1[1]) < 1))
                {
                    erro.SetError(mskTabela, "Coloque um valor entre 1 e 12!!");
                    x = true;
                }
                if (txtSinalSS.Text != "+" && txtSinalSS.Text != "-" && txtSinalSS.Text != "*")
                {
                    erro.SetError(txtSinalSS, "Coloque apenas positivo, negativo ou multiplicar nesse campo!!");
                    y = true;
                }
                if (x || y)
                    return false;
                else
                    return true;
            }
            else if (grpMD.Visible)
            {
                valv1 = mskTabela1.Text.Split(new char[] { '.' });
                if (OP == "Divisão" && txtj.Text == "0")
                {
                    erro.SetError(txtj, "Não é possivel dividir por 0!!");
                    y = true;
                }
                if (OP == "Divisão" && txti.Text == "0")
                {
                    erro.SetError(txti, "Não é possivel dividir por 0!!");
                    y = true;
                }
                if (mskTabela1.MaskCompleted == false)
                {
                    erro.SetError(mskTabela1, "Preencha o campo com os valores corretos!!");
                    x = true;
                }
                if (!int.TryParse(txti.Text, out valor))
                {
                    erro.SetError(txti, "Coloque apenas valores inteiros no campo!!");
                    y = true;
                }
                if (!int.TryParse(txtj.Text, out valor))
                {
                    erro.SetError(txtj, "Coloque apenas valores inteiros no campo!!");
                    y = true;
                }
                if (x == false && (int.Parse(valv1[0]) > 13 || int.Parse(valv1[1]) > 13 || int.Parse(valv1[0]) < 1 || int.Parse(valv1[1]) < 1))
                {
                    erro.SetError(mskTabela1, "Coloque um valor entre 1 e 13!!");
                    x = true;
                }
                if (txtSinalMD.Text != "+" && txtSinalMD.Text != "-" && txtSinalMD.Text != "*")
                {
                    erro.SetError(txtSinalSS, "Coloque apenas positivo, negativo ou multiplicar nesse campo!!");
                    y = true;
                }
                if (x || y)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        #endregion

        #region load
        private void FrmMatrizes_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            cmbOP.SelectedIndex = 1;

            txtConst.MaxLength = 3;
            txti.MaxLength = 2;
            txtj.MaxLength = 2;
            txtSinalSS.MaxLength = 1;
            txtSinalMD.MaxLength = 1;

            grpMD.Visible = false;
            lblTr.Visible = false;
            lblSomaE.Visible = false;
            lblTrSec.Visible = false;
        }
        #endregion

        #region Field Click
       
        private void field_Click(Field field, string OP, string Sinal, string Const, string A, string B)
        {
            string[] variavel = field.Name.Split(new char[] { '.' });
            if (grpSS.Visible)
            {
                if (Sinal == "+")
                {
                    switch (OP)
                    {
                        case "Somar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " + " + variavel[1] + " + " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Subtrair":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " + " + variavel[1] + " - " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
                else if (Sinal == "*")
                {
                    switch (OP)
                    {
                        case "Somar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " * " + variavel[1] + " + " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Subtrair":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " * " + variavel[1] + " - " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
                else if (Sinal == "-")
                {
                    switch (OP)
                    {
                        case "Somar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " - " + variavel[1] + " + " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Subtrair":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + variavel[0] + " - " + variavel[1] + " - " + Const, "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
            }
            else
            {
                if (Sinal == "+")
                {
                    switch (OP)
                    {
                        case "Multiplicar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " * " + A + ")" + " + " + "(" + variavel[1] + " * " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Divisão":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " / " + A + ")" + " + " + "(" + variavel[1] + " / " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
                else if (Sinal == "*")
                {
                    switch (OP)
                    {
                        case "Multiplicar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " * " + A + ")" + " * " + "(" + variavel[1] + " * " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Divisão":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " / " + A + ")" + " * " + "(" + variavel[1] + " / " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
                else if (Sinal == "-")
                {
                    switch (OP)
                    {
                        case "Multiplicar":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " * " + A + ")" + " - " + "(" + variavel[1] + " * " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                        case "Divisão":
                            MessageBox.Show("Elemento: a" + variavel[0] + variavel[1] + System.Environment.NewLine + "Cálculo: " + "(" + variavel[0] + " / " + A + ")" + " - " + "(" + variavel[1] + " / " + B + ")", "Elemento e cálculo", MessageBoxButtons.OK);
                            break;
                    }
                }
            }  
        }
        #endregion

        #region Click dos botões
        private void btnCriar_Click_1(object sender, EventArgs e)
        {
            Novo(sender);
            mskTabela.Focus();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Novo(sender);
            mskTabela1.Focus();
        }

        private void Novo(object sender)
        {
            try
            {
                string[] variavel;
                traco = 0;
                tracoDiv = 0;
                somaResDiv = 0;
                somaRes = 0;
                tracosec = 0;
                tracosecDiv = 0;
                bool ME = false;
                Button send = (Button)sender;
                switch (send.Text)
                {
                    case "Somar":
                    case "Subtrair":
                        variavel = mskTabela.Text.Split(new char[] { '.' });
                        break;
                    default:
                        variavel = mskTabela1.Text.Split(new char[] { '.' });
                        break;
                }
                if (Consistir(send.Text))
                {
                    erro.Clear();
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
                                if (grpSS.Visible)
                                {
                                    if (txtSinalSS.Text == "+")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                traco += (i + 1) + (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                traco += (i + 1) + (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                    else if (txtSinalSS.Text == "*")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                traco += (i + 1) * (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                traco += (i + 1) * (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                    if (txtSinalSS.Text == "-")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                traco += (i + 1) - (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                traco += (i + 1) - (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (txtSinalMD.Text == "+")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                traco += (i + 1) * int.Parse(txti.Text) + (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracoDiv += (i + 1) / double.Parse(txti.Text) + (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                    else if (txtSinalMD.Text == "*")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                traco += (i + 1) * int.Parse(txti.Text) * (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracoDiv += (i + 1) / double.Parse(txti.Text) * (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                    if (txtSinalMD.Text == "-")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                traco += (i + 1) * int.Parse(txti.Text) - (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracoDiv += (i + 1) / double.Parse(txti.Text) - (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                }
                            }
                            if (i + 1 + j + 1 == int.Parse(variavel[1]) + 1)
                            {
                                if (grpSS.Visible)
                                {
                                    if (txtSinalSS.Text == "+")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                tracosec += (i + 1) + (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                tracosec += (i + 1) + (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                    else if (txtSinalSS.Text == "*")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                tracosec += (i + 1) * (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                tracosec += (i + 1) * (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                    if (txtSinalSS.Text == "-")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Somar":
                                                tracosec += (i + 1) - (j + 1) + int.Parse(txtConst.Text);
                                                break;
                                            case "Subtrair":
                                                tracosec += (i + 1) - (j + 1) - int.Parse(txtConst.Text);
                                                break;
                                        }
                                    }
                                }
                                else
                                {
                                    if (txtSinalMD.Text == "+")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                tracosec += (i + 1) * int.Parse(txti.Text) + (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracosecDiv += (i + 1) / double.Parse(txti.Text) + (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                    else if (txtSinalMD.Text == "*")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                tracosec += (i + 1) * int.Parse(txti.Text) * (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracosecDiv += (i + 1) / double.Parse(txti.Text) * (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                    if (txtSinalMD.Text == "-")
                                    {
                                        switch (send.Text)
                                        {
                                            case "Multiplicar":
                                                tracosec += (i + 1) * int.Parse(txti.Text) - (j + 1) * int.Parse(txtj.Text);
                                                break;
                                            case "Divisão":
                                                tracosecDiv += (i + 1) / double.Parse(txti.Text) - (j + 1) / double.Parse(txtj.Text);
                                                break;
                                        }
                                    }
                                }  
                            }   
                            Field novo = new Field();
                            if (grpSS.Visible)
                                novo.Click += (sender2, e2) => field_Click(novo, send.Text, txtSinalSS.Text, txtConst.Text, "", "");
                            else
                                novo.Click += (sender2, e2) => field_Click(novo, send.Text, txtSinalMD.Text, "", txti.Text, txtj.Text);
                            novo.Name = Convert.ToString(i + 1) + "." + Convert.ToString(j + 1);
                            novo.Size = new Size(30, 30);
                            novo.Location = ponto;
                            if (grpSS.Visible)
                            {
                                if (txtSinalSS.Text == "+")
                                {
                                    switch (send.Text)
                                    {
                                        case "Somar":
                                            novo.Text = Convert.ToString((i + 1) + (j + 1) + int.Parse(txtConst.Text));
                                            somaRes += (i + 1) + (j + 1) + int.Parse(txtConst.Text);
                                            break;
                                        case "Subtrair":
                                            novo.Text = Convert.ToString((i + 1) + (j + 1) - int.Parse(txtConst.Text));
                                            somaRes += (i + 1) + (j + 1) - int.Parse(txtConst.Text);
                                            break;
                                    }
                                }
                                else if (txtSinalSS.Text == "*")
                                {
                                    switch (send.Text)
                                    {
                                        case "Somar":
                                            novo.Text = Convert.ToString((i + 1) * (j + 1) + int.Parse(txtConst.Text));
                                            somaRes += (i + 1) * (j + 1) + int.Parse(txtConst.Text);
                                            break;
                                        case "Subtrair":
                                            novo.Text = Convert.ToString((i + 1) * (j + 1) - int.Parse(txtConst.Text));
                                            somaRes += (i + 1) * (j + 1) - int.Parse(txtConst.Text);
                                            break;
                                    }
                                }
                                if (txtSinalSS.Text == "-")
                                {
                                    switch (send.Text)
                                    {
                                        case "Somar":
                                            novo.Text = Convert.ToString((i + 1) - (j + 1) + int.Parse(txtConst.Text));
                                            somaRes += (i + 1) - (j + 1) + int.Parse(txtConst.Text);
                                            break;
                                        case "Subtrair":
                                            novo.Text = Convert.ToString((i + 1) - (j + 1) - int.Parse(txtConst.Text));
                                            somaRes += (i + 1) - (j + 1) - int.Parse(txtConst.Text);
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                if (txtSinalMD.Text == "+")
                                {
                                    switch (send.Text)
                                    {
                                        case "Multiplicar":
                                            novo.Text = Convert.ToString((i + 1) * int.Parse(txti.Text) + (j + 1) * int.Parse(txtj.Text));
                                            somaRes += (i + 1) * int.Parse(txti.Text) + (j + 1) * int.Parse(txtj.Text);
                                            break;
                                        case "Divisão":
                                            novo.Text = Convert.ToString((i + 1) / double.Parse(txti.Text) + (j + 1) / double.Parse(txtj.Text));
                                            somaResDiv += (i + 1) / double.Parse(txti.Text) + (j + 1) / double.Parse(txtj.Text);
                                            break;
                                    }
                                }
                                else if (txtSinalMD.Text == "*")
                                {
                                    switch (send.Text)
                                    {
                                        case "Multiplicar":
                                            novo.Text = Convert.ToString((i + 1) * int.Parse(txti.Text) * (j + 1) * int.Parse(txtj.Text));
                                            somaRes += (i + 1) * int.Parse(txti.Text) * (j + 1) * int.Parse(txtj.Text);
                                            break;
                                        case "Divisão":
                                            novo.Text = Convert.ToString((i + 1) / double.Parse(txti.Text) * (j + 1) / double.Parse(txtj.Text));
                                            somaResDiv += (i + 1) / double.Parse(txti.Text) * (j + 1) / double.Parse(txtj.Text);
                                            break;
                                    }
                                }
                                if (txtSinalMD.Text == "-")
                                {
                                    switch (send.Text)
                                    {
                                        case "Multiplicar":
                                            novo.Text = Convert.ToString((i + 1) * int.Parse(txti.Text) - (j + 1) * int.Parse(txtj.Text));
                                            somaRes += (i + 1) * int.Parse(txti.Text) - (j + 1) * int.Parse(txtj.Text);
                                            break;
                                        case "Divisão":
                                            novo.Text = Convert.ToString((i + 1) / double.Parse(txti.Text) - (j + 1) / double.Parse(txtj.Text));
                                            somaResDiv += (i + 1) / double.Parse(txti.Text) - (j + 1) / double.Parse(txtj.Text);
                                            break;
                                    }
                                }
                            }  
                            novo.BorderStyle = BorderStyle.FixedSingle;
                            novo.Font = new Font("Arial", 8);
                            this.Controls.Add(novo);

                            ponto.X += 30;
                        }
                        ponto.Y += 30;
                        ponto.X = 10;
                    }
                    lblTr.Visible = true;
                    lblSomaE.Visible = true;
                    lblTrSec.Visible = true;
                    if (send.Text != "Divisão")
                    {
                        lblRes.Text = somaRes.ToString();
                        lblTraco.Text = traco.ToString();
                        lblTracoSec.Text = tracosec.ToString();
                    }
                    else
                    {
                        lblRes.Text = somaResDiv.ToString();
                        lblTraco.Text = tracoDiv.ToString();
                        lblTracoSec.Text = tracosecDiv.ToString();
                    }
                    if (cbxME.Checked)
                    {
                        if (int.Parse(variavel[0]) == 1)
                        {
                            MessageBox.Show("Essa é uma Matriz especial no caso uma Matriz coluna!!", "Matriz especial...", MessageBoxButtons.OK);
                            ME = true;
                        }
                        if (int.Parse(variavel[1]) == 1)
                        {
                            MessageBox.Show("Essa é uma Matriz especial no caso uma Matriz linha!!", "Matriz especial...", MessageBoxButtons.OK);
                            ME = true;
                        }
                        if (grpMD.Visible && txti.Text == "0" && txtj.Text == "0")
                        {
                            MessageBox.Show("Essa é uma Matriz especial no caso uma Matriz Nula!!", "Matriz especial...", MessageBoxButtons.OK);
                            ME = true;
                        }
                        if (int.Parse(variavel[0]) == int.Parse(variavel[1]))
                        {
                            MessageBox.Show("Essa é uma Matriz especial no caso uma Matriz quadrada!!", "Matriz especial...", MessageBoxButtons.OK);
                            ME = true;
                        }
                        if (ME == false)
                            MessageBox.Show("Essa não é uma Matriz especial :(", "Matriz especial...", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar a tabela erro: " + ex.Message);
            }
        }
        #endregion

        #region CMB SelectedValueChanged
        private void cmbOP_SelectedValueChanged(object sender, EventArgs e)
        {
            string op = cmbOP.Text;
            if (op == "Mult/Div")
            {
                grpMD.Visible = true;
                grpSS.Visible = false;
                mskTabela1.Focus();
            }
            else if (op == "Somar/Sub")
            {
                grpMD.Visible = false;
                grpSS.Visible = true;
                mskTabela.Focus();
            }
        }
        #endregion

        #region Formula click
        private void btnformula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adição e subtração:" + System.Environment.NewLine + "Definindo C como o valor da caixa de texto, temos para  a soma a fórmula i+j+C " + System.Environment.NewLine + "para a subtração i+j-C" + System.Environment.NewLine + "para a subtração i-j-C" + System.Environment.NewLine + System.Environment.NewLine + "Multiplicação e divisão:" + System.Environment.NewLine + "Definindo A e B como os valores das caixas de texto, sendo A a primeira da esquerda para a direita e B a segunda temos para a multiplicação a fórmula A.i + B.J" + System.Environment.NewLine + "para a divisão A/i + B/j" + System.Environment.NewLine + System.Environment.NewLine + "O sinal escolhido altera a operação entre os elementos i e j", "Fórmula...", MessageBoxButtons.OK);

            if (grpSS.Visible)
                mskTabela.Focus();
            else
                mskTabela1.Focus();
        }
        #endregion

        #region Teclas

        private void mskTabela_KeyDown(object sender, KeyEventArgs e)
        {
            Teclas(sender, e);
        }

        private void mskTabela1_KeyDown(object sender, KeyEventArgs e)
        {
            Teclas(sender, e);
        }

        private void Teclas(object sender, KeyEventArgs e = null)
        {
            string[] f;
            string[] v;
            string[] g;
            if (e != null)
            {
                if (e.KeyCode == Keys.F)
                {
                    btnformula_Click(sender, e);
                    f = txtConst.Text.Split(new char[] { 'f' });
                    txtConst.Text = f[0];
                    g = txti.Text.Split(new char[] { 'f' });
                    txti.Text = g[0];
                    v = txtj.Text.Split(new char[] { 'f' });
                    txtj.Text = v[0];
                }
                if (e.KeyCode == Keys.N)
                {
                    Atalhos_Click(sender, e);
                    f = txtConst.Text.Split(new char[] { 'n' });
                    txtConst.Text = f[0];
                    g = txti.Text.Split(new char[] { 'n' });
                    txti.Text = g[0];
                    v = txtj.Text.Split(new char[] { 'n' });
                    txtj.Text = v[0];
                }
                if (grpSS.Visible)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        cmbOP.SelectedIndex = 0;
                        mskTabela1.Focus();
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        f = txtConst.Text.Split(new char[] { 'r' });
                        txtConst.Text = f[0];
                        g = txti.Text.Split(new char[] { 'r' });
                        txti.Text = g[0];
                        v = txtj.Text.Split(new char[] { 'r' });
                        txtj.Text = v[0];
                        txtSinalSS.Focus();
                    }
                    if (e.KeyCode == Keys.F4)
                    {
                        Novo(new Button() { Text = "Somar" });
                    }
                    if (e.KeyCode == Keys.F3)
                    {
                        Novo(new Button() { Text = "Subtrair" });
                    }
                    if (mskTabela.MaskCompleted && e.KeyCode != Keys.Back && (txtConst.TextLength != 2 && txtConst.TextLength != 1))
                        txtConst.Focus();
                }
                else if (grpMD.Visible)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        cmbOP.SelectedIndex = 1;
                        mskTabela.Focus();
                    }
                    if (e.KeyCode == Keys.R)
                    {
                        f = txtConst.Text.Split(new char[] { 'r' });
                        txtConst.Text = f[0];
                        g = txti.Text.Split(new char[] { 'r' });
                        txti.Text = g[0];
                        v = txtj.Text.Split(new char[] { 'r' });
                        txtj.Text = v[0];
                        txtSinalMD.Focus();
                    }
                    if (e.KeyCode == Keys.F4)
                    {
                        Novo(new Button() { Text = "Multiplicar" });
                    }
                    if (e.KeyCode == Keys.F3)
                    {
                        Novo(new Button() { Text = "Divisão" });
                    }
                    if (mskTabela1.MaskCompleted && e.KeyCode != Keys.Back && (txti.TextLength != 2 && txti.TextLength != 1))
                        txti.Focus();
                    if (txti.TextLength == txti.MaxLength - 1 && e.KeyCode != Keys.Back && mskTabela1.MaskCompleted && (txtj.TextLength != 2 && txtj.TextLength != 1))
                        txtj.Focus();
                }
            }
            else
            {
                if (grpSS.Visible)
                    mskTabela.Focus();
                else
                    mskTabela1.Focus();
            }
               
        }

        private void cbxME_CheckedChanged(object sender, EventArgs e)
        {
            Teclas(sender, null);
        }

        #endregion

        #region Atalhos
        private void Atalhos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apertando a seta para baixo ↓ automaticamente irá trocar de soma/subtração para multiplicação/divisão e vice versa." + System.Environment.NewLine + System.Environment.NewLine +
            "Já com a tecla f4 ela irá acionar o botão somar ou o multiplicar, dessa forma a tecla f3 faz o contrário aciona o botão subtrair ou dividir." + System.Environment.NewLine + System.Environment.NewLine +
            "A tecla F aciona o botão de fórmulas e o N aciona o botão de atalhos.", "Atalhos...", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

            if (grpSS.Visible)
                mskTabela.Focus();
            else
                mskTabela1.Focus();
        }
        #endregion

    }
}
