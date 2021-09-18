using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmText : Form
    {
        bool x = false;
        int valor;
        public FrmText()
        {
            InitializeComponent();
        }

        private void FrmText_Load(object sender, EventArgs e)
        {
            txtCel.MaxLength = 3;
            txtCel.Focus();
        }

        private bool consistir()
        {
            errinho.Clear();
            x = false;
            if (string.IsNullOrEmpty(txtCel.Text))
            {
                errinho.SetError(txtCel, "Insira algum valor na caixa de texto");
                x = true;
            }
            if (!int.TryParse(txtCel.Text, out valor) && x == false)
            {
                errinho.SetError(txtCel, "Coloque apenas valores inteiros na caixa de texto");
                x = true;
            }
            if (x)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (consistir())
            {
                this.DialogResult = DialogResult.Yes;
            }
            
        }

        private void txtCel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar_Click(sender, e);
            }
        }
    }
}
