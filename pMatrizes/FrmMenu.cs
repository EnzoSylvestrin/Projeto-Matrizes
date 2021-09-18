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
                mnuMenu_Click(sender, e);
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
        }

        private void mnuMenu_Click(object sender, EventArgs e)
        {
            mnuMenu.Checked = true;
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
    }
}
