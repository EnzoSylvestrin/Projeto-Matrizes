using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void fórmulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFormula FrmFormu = new FrmFormula();
            FrmFormu.MdiParent = this;
            FrmFormu.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FrmFormu.Show();
        }

        private void matrizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatrizes FrmMatriz = new FrmMatrizes();
            FrmMatriz.MdiParent = this;
            FrmMatriz.WindowState = FormWindowState.Maximized;
            FrmMatriz.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mnuMenu.ShowDropDown();
            }
            if (e.KeyCode == Keys.F)
            {
                fórmulaToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.M)
            {
                matrizesToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                SomaToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.U)
            {
                MultToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.C)
            {
                corzinhaToolStripMenuItem_Click(sender, e);
            }
            if (e.KeyCode == Keys.R)
            {
                criptografiaToolStripMenuItem_Click(sender, e);
            }
        }
        private void SomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmSomaeSub FrmSomaeSub = new FrmSomaeSub();
            FrmSomaeSub.MdiParent = this;
            FrmSomaeSub.WindowState = FormWindowState.Maximized;
            FrmSomaeSub.Show();
             
        }

        private void MultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMult frmMult = new FrmMult();
            frmMult.MdiParent = this;
            frmMult.WindowState = FormWindowState.Maximized;
            frmMult.Show();
        }

        private void corzinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix.Form1 form1 = new matrix.Form1();
            form1.MdiParent = this;
            form1.WindowState = FormWindowState.Maximized;
            form1.Show();
        }

        private void criptografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCripto frmCripto = new FrmCripto();
            frmCripto.MdiParent = this;
            frmCripto.WindowState = FormWindowState.Maximized;
            frmCripto.Show();
        }
    }
}
