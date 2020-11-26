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
    public partial class ListeDesEcole : Form
    {
        int i;
        int? a;

        public ListeDesEcole()
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

        private void ListeEcole_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (txtSearch.Text == "")
            {
                for (i = 0; i < Class1.Tab2.Count; i++)
                {
                    string[] copie = new string[] { Class1.Tab2[i][0], Class1.Tab2[i][1], Class1.Tab2[i][2], Class1.Tab2[i][3] };
                    listView1.Items.Add(new ListViewItem(copie));
                }
            }

            else if (txtSearch.Text.Length > 0)
            {
                for (i = 0; i < Class1.Tab2.Count; i++)
                {
                    if (Class1.Tab2[i][0].ToLower().Contains(txtSearch.Text.ToLower()) || Class1.Tab2[i][1].ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        string[] copie = new string[] { Class1.Tab2[i][0], Class1.Tab2[i][1], Class1.Tab2[i][2], Class1.Tab2[i][3] };
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
                FormEcole f1 = new FormEcole();
                f1.FormBorderStyle = FormBorderStyle.FixedSingle;
                f1.Show();
                f1.button1.Text = "Edit";
                f1.lblBarre.Visible = true;

                for (i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        f1.txtNom.Text = Class1.Tab2[i][0];
                        f1.dateTimePicker1.Text = Class1.Tab2[i][1];
                        f1.txtEmail.Text = Class1.Tab2[i][2];
                        f1.txtContact.Text = Class1.Tab2[i][3];
                        f1.pictureBox4.ImageLocation = Class1.Tab2[i][4];
                        CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
                        f1.pictureBox1.Image = qrcode.Draw(Class1.Tab2[i][0], 50);
                        f1.lblPhoto.Visible = false;

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

                        Class1.Tab2.RemoveAt(i);

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
    }
}
