namespace WindowsFormsApplication1
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fórmulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMenu
            // 
            this.mnuMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fórmulaToolStripMenuItem,
            this.matrizesToolStripMenuItem,
            this.SomaToolStripMenuItem,
            this.MultToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(50, 20);
            this.mnuMenu.Text = "Menu";
            this.mnuMenu.Click += new System.EventHandler(this.mnuMenu_Click);
            // 
            // fórmulaToolStripMenuItem
            // 
            this.fórmulaToolStripMenuItem.Name = "fórmulaToolStripMenuItem";
            this.fórmulaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.fórmulaToolStripMenuItem.Text = "Fórmula";
            this.fórmulaToolStripMenuItem.Click += new System.EventHandler(this.fórmulaToolStripMenuItem_Click);
            // 
            // matrizesToolStripMenuItem
            // 
            this.matrizesToolStripMenuItem.Name = "matrizesToolStripMenuItem";
            this.matrizesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.matrizesToolStripMenuItem.Text = "Gerador de Matriz";
            this.matrizesToolStripMenuItem.Click += new System.EventHandler(this.matrizesToolStripMenuItem_Click);
            // 
            // SomaToolStripMenuItem
            // 
            this.SomaToolStripMenuItem.Name = "SomaToolStripMenuItem";
            this.SomaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SomaToolStripMenuItem.Text = "Soma, Subtração e divisão";
            this.SomaToolStripMenuItem.Click += new System.EventHandler(this.SomaToolStripMenuItem_Click);
            // 
            // MultToolStripMenuItem
            // 
            this.MultToolStripMenuItem.Name = "MultToolStripMenuItem";
            this.MultToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.MultToolStripMenuItem.Text = "Multiplicação";
            this.MultToolStripMenuItem.Click += new System.EventHandler(this.MultToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem fórmulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MultToolStripMenuItem;
    }
}