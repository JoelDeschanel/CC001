using Microsoft.Reporting.WinForms;
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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\dhout\Desktop\CC01\WindowsFormsApp1\Report1.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSet1", GetListe());
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        public List<Print> GetListe()
        {
            int i;

            List<Print> prints = new List<Print>();

            for(i = 0; i < Class1.l.listView1.Items.Count; i++)
            {
                prints.Add
                    (
                        new Print
                        {
                            Nom = Class1.Tab1[i][0],
                            Prenom = Class1.Tab1[i][1],
                            Identifiant = Class1.Tab1[i][2],
                            Birthday = DateTime.Parse(Class1.Tab1[i][3]),
                            Email = Class1.Tab1[i][4],
                            Contact = Class1.Tab1[i][5]
                        }
                    );
            }

            return prints;
        }
    }
}
