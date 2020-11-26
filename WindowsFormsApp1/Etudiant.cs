using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Zen.Barcode;

namespace WindowsFormsApp1
{
    public partial class FormEtudiant : Form
    {
        OpenFileDialog ofd;
        int i;
        public FormEtudiant()
        {
            InitializeComponent();
            button1.Text = "Save";
            button1.Name = "BtnSave";
            button2.Name = "BtnCancel";

        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Save")
            {
                if (pictureBox4.Image != null)
                {
                    //string[] infos = new string[] { txtNom.Text, txtPrenom.Text, txtIdentifiant.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text, ofd.FileName };
                    string[] copie = new string[] { txtNom.Text, txtPrenom.Text, txtIdentifiant.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text };
                    string[] copies = new string[] { txtNom.Text, txtPrenom.Text, txtIdentifiant.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text, ofd.FileName };

                    Class1.l.listView1.Items.Add(new ListViewItem(copie));
                    Class1.Tab1.Add(copies);

                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtIdentifiant.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    pictureBox4.ImageLocation = null;
                    lblPhoto.Visible = true;

                    MessageBox.Show("Enregistrement réussi");
                }

                else
                {
                    MessageBox.Show("Vous n'avez pas de photo");
                }


                using (StreamWriter sw = new StreamWriter(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Etudiant.json"))
                {
                    using (JsonWriter jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        JsonSerializer js = new JsonSerializer();

                        js.Serialize(jw, JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Class1.Tab1)));
                    }
                }
            }

            else
            {
                if
                    (
                        MessageBox.Show
                        (
                            "Souhaitez-vous enregistrer ces modifications?",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        ) == DialogResult.Yes
                    )
                {
                    if (pictureBox4.Image != null)
                    {
                        Class1.Tab1[Class1.temp][0] = txtNom.Text;
                        Class1.Tab1[Class1.temp][1] = txtPrenom.Text;
                        Class1.Tab1[Class1.temp][2] = txtIdentifiant.Text;
                        Class1.Tab1[Class1.temp][3] = dateTimePicker1.Text;
                        Class1.Tab1[Class1.temp][4] = txtEmail.Text;
                        Class1.Tab1[Class1.temp][5] = txtContact.Text;
                        Class1.Tab1[Class1.temp][6] = pictureBox4.ImageLocation;

                        Class1.l.listView1.Items.Clear();

                        for (i = 0; i < Class1.Tab1.Count; i++)
                        {
                            Class1.l.listView1.Items.Add(new ListViewItem(Class1.Tab1[i]));
                        }

                        using (StreamWriter sw = new StreamWriter(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Etudiant.json"))
                        {
                            using (JsonWriter jw = new JsonTextWriter(sw))
                            {
                                jw.Formatting = Formatting.Indented;

                                JsonSerializer js = new JsonSerializer();

                                js.Serialize(jw, JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Class1.Tab1)));
                            }
                        }

                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Vous n'avez pas de photo");
                    }
                }
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();

            ofd.Title = "Choose a picture";
            ofd.Filter = "Images files |*.jpg;*.jpeg;*.png;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.ImageLocation = ofd.FileName;
                lblPhoto.Visible = false;
            }

            else
            {
                pictureBox4.ImageLocation = null;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Save")
            {
                panel1.Visible = false;
            }

            else
            {
                this.Close();
            }
        }
    }
}
