namespace WindowsFormsApp1
{
    partial class Parent
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
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formEcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEcoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.formToolStripMenuItem.Text = "Form";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formEtudiantToolStripMenuItem,
            this.listeEtudiantToolStripMenuItem,
            this.formEcoleToolStripMenuItem,
            this.listeEcoleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // formEtudiantToolStripMenuItem
            // 
            this.formEtudiantToolStripMenuItem.Name = "formEtudiantToolStripMenuItem";
            this.formEtudiantToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.formEtudiantToolStripMenuItem.Text = "Form Etudiant";
            this.formEtudiantToolStripMenuItem.Click += new System.EventHandler(this.formEtudiantToolStripMenuItem_Click);
            // 
            // listeEtudiantToolStripMenuItem
            // 
            this.listeEtudiantToolStripMenuItem.Name = "listeEtudiantToolStripMenuItem";
            this.listeEtudiantToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listeEtudiantToolStripMenuItem.Text = "Liste Etudiant";
            this.listeEtudiantToolStripMenuItem.Click += new System.EventHandler(this.listeEtudiantToolStripMenuItem_Click);
            // 
            // formEcoleToolStripMenuItem
            // 
            this.formEcoleToolStripMenuItem.Name = "formEcoleToolStripMenuItem";
            this.formEcoleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.formEcoleToolStripMenuItem.Text = "Form Ecole";
            this.formEcoleToolStripMenuItem.Click += new System.EventHandler(this.formEcoleToolStripMenuItem_Click);
            // 
            // listeEcoleToolStripMenuItem
            // 
            this.listeEcoleToolStripMenuItem.Name = "listeEcoleToolStripMenuItem";
            this.listeEcoleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.listeEcoleToolStripMenuItem.Text = "ListeEcole";
            this.listeEcoleToolStripMenuItem.Click += new System.EventHandler(this.listeEcoleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 601);
            this.panel1.TabIndex = 2;
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParent";
            this.Text = "FormParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formEcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEcoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}