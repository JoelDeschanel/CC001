using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace WindowsFormsApp1
{
    public partial class ListeEtudiant : Form
    {
        public int i;
        public int? a;

        public ListeEtudiant()
        {
            InitializeComponent();
            button2.Name = "BtnCancel";
            button3.Name = "BtnEdit";
            button4.Name = "BtnSupp";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (txtSearch.Text == "")
            {
                for (i = 0; i < Class1.Tab1.Count; i++)
                {
                    string[] copie = new string[] { Class1.Tab1[i][0], Class1.Tab1[i][1], Class1.Tab1[i][2], Class1.Tab1[i][3], Class1.Tab1[i][4], Class1.Tab1[i][5] };
                    listView1.Items.Add(new ListViewItem(copie));
                }
            }

            else if (txtSearch.Text.Length > 0)
            {
                for (i = 0; i < Class1.Tab1.Count; i++)
                {
                    if (Class1.Tab1[i][0].ToLower().Contains(txtSearch.Text.ToLower()) || Class1.Tab1[i][1].ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        string[] copie = new string[] { Class1.Tab1[i][0], Class1.Tab1[i][1], Class1.Tab1[i][2], Class1.Tab1[i][3], Class1.Tab1[i][4], Class1.Tab1[i][5] };
                        Thread.Sleep(90);

                        listView1.Items.Add(new ListViewItem(copie));
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("On ne peut modifier qu'un seul élément à la fois", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                FormEtudiant f = new FormEtudiant();
                f.FormBorderStyle = FormBorderStyle.FixedSingle;
                f.Show();
                f.button1.Text = "Edit";
                f.lblBarre.Visible = true;

                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        f.txtNom.Text = Class1.Tab1[i][0];
                        f.txtPrenom.Text = Class1.Tab1[i][1];
                        f.txtIdentifiant.Text = Class1.Tab1[i][2];
                        f.dateTimePicker1.Text = Class1.Tab1[i][3];
                        f.txtEmail.Text = Class1.Tab1[i][4];
                        f.txtContact.Text = Class1.Tab1[i][5];
                        f.pictureBox4.ImageLocation = Class1.Tab1[i][6];
                        CodeQrBarcodeDraw barcode = BarcodeDrawFactory.CodeQr;
                        f.pictureBox1.Image = barcode.Draw(Class1.Tab1[i][2], 50);
                        f.lblPhoto.Visible = false;

                        Class1.temp = i;
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if
               (
                   MessageBox.Show
                   (
                       "Voulez-vous supprimer ces " + listView1.SelectedItems.Count + " éléments définitivement ?",
                       "Question",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
                   ) == DialogResult.Yes
               )
            {
                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        a = 1;

                        listView1.Items[i].Remove();

                        Class1.Tab1.RemoveAt(i);

                        i = -1;
                    }
                }

                a = null;
            }

            else
            {
                a = 1;

                for (i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].Selected = false;
                }

                a = null;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Preview p = new Preview();

            p.Show();
        }
    }
}
