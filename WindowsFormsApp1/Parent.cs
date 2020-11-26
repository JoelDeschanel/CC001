using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormEtudiant f = new FormEtudiant();

            f.panel1.Visible = true;
            panel1.Controls.Add(f.panel1);
        }

        private void listeEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Class1.l.panel1.Visible = true;
            panel1.Controls.Add(Class1.l.panel1);
        }

        private void formEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormEcole f = new FormEcole();

            f.panel1.Visible = true;
            panel1.Controls.Add(f.panel1);
        }

        private void listeEcoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Class1.l2.panel1.Visible = true;
            panel1.Controls.Add(Class1.l2.panel1);
        }
    }
}
