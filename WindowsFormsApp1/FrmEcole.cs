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
    public partial class FormEcole : Form
    {
        int i;
        OpenFileDialog ofd;
        public FormEcole()
        {
            InitializeComponent();
            button1.Text = "Save";
            lblPhoto.Visible = false;
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
                    string[] infos = new string[] { txtNom.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text, ofd.FileName };
                    string[] copie = new string[] { txtNom.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text };

                    Class1.l2.listView1.Items.Add(new ListViewItem(copie));
                    Class1.Tab2.Add(infos);

                    txtNom.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    pictureBox4.ImageLocation = null;
                    lblPhoto.Visible = true;

                    MessageBox.Show("Enregistrement réussi");

                    using (StreamWriter sw = new StreamWriter(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Ecole.json"))
                    {
                        using (JsonWriter jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Formatting.Indented;

                            JsonSerializer js = new JsonSerializer();

                            js.Serialize(jw, JsonConvert.DeserializeObject(JsonConvert.SerializeObject(Class1.Tab2)));
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Vous n'avez pas de photo");
                }
            }

            else
            {
                if (pictureBox4.Image != null)
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
                        Class1.Tab2[Class1.temp][0] = txtNom.Text;
                        Class1.Tab2[Class1.temp][1] = dateTimePicker1.Text;
                        Class1.Tab2[Class1.temp][2] = txtEmail.Text;
                        Class1.Tab2[Class1.temp][3] = txtContact.Text;
                        Class1.Tab2[Class1.temp][4] = pictureBox4.ImageLocation;

                        Class1.l.listView1.Items.Clear();

                        for (i = 0; i < Class1.Tab2.Count; i++)
                        {
                            Class1.l.listView1.Items.Add(new ListViewItem(Class1.Tab2[i]));
                        }

                        using (StreamWriter sw = new StreamWriter(@"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\DATA\Data_Ecole.json"))
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
