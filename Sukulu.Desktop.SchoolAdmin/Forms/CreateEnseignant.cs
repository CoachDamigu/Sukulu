using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using Sukulu.DataAccessLibrary.Repositories;
using Sukulu.Desktop.SchoolAdmin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Sukulu.Desktop.SchoolAdmin.Forms
{
    public partial class CreateEnseignant : Form
    {
        byte[] Photo;
        string _userName;
        public CreateEnseignant(string userName)
        {
            _userName = userName;
            InitializeComponent();
            // Add footer control
            SaveAddQuit ctrlSaveAddQuit = new SaveAddQuit();
            ctrlSaveAddQuit.Dock = DockStyle.Fill;
            pnlFooter.Controls.Add(ctrlSaveAddQuit);
            ctrlSaveAddQuit.SaveQuitClicked += new EventHandler(SaveAndQuitClicked);
            ctrlSaveAddQuit.SaveAddClicked += new EventHandler(SaveAndAddClicked);
            ctrlSaveAddQuit.QuitClicked += new EventHandler(QuitClicked);

            // Sexe enum binding

            cbSexe.Items.Add("Choisissez le sexe");
            Array genders = Enum.GetValues(typeof(Gender));
            foreach (Gender gender in genders)
            {
                cbSexe.Items.Add(gender);
            }
            cbSexe.SelectedIndex = 0;
        }


        private string GenerateEnseignantNumber(char LN, char FN)
        {
            EcoleFactory ecoleFactory = new EcoleFactory();
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "123456789";
            string matricule = "";
            do
            {
                string last5 = "";
                Random rd = new Random();
                for (int i = 1; i < 5; i++)
                {

                    int nb = rd.Next(0, 8);
                    char c = numbers[nb];
                    last5 = last5 + c;
                }
                string year = DateTime.Today.Date.Year.ToString();
                char middleChar = Alphabet[rd.Next(0, 25)];
                matricule = (year + LN + middleChar + FN + last5).ToUpper();
            }
            while (ecoleFactory.IsEnseignantMatriculeInUse(matricule));

            return matricule;
        }

        private void SaveRecord()
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrEmpty(tbLastName.Text) ||
                    string.IsNullOrWhiteSpace(tbFirstName.Text) || string.IsNullOrEmpty(tbFirstName.Text) ||
                cbSexe.SelectedIndex == 0)
            {
                MessageBox.Show("Il manque des données");
            }
            else
            {
                string eleveNumber = GenerateEnseignantNumber(tbLastName.Text.ToUpper()[0], tbFirstName.Text.ToUpper()[0]);
                EcoleFactory ecoleFactory = new EcoleFactory();
                long Id = ecoleFactory.CreateEnseignant(eleveNumber, tbFirstName.Text.Trim(), tbLastName.Text.Trim(), tbOtherNames.Text.Trim(),
                    (Gender)cbSexe.SelectedItem, dtpDOB.Value, tbEmail.Text.Trim(), tbPhone.Text.Trim(), tbNotes.Text.Trim(), Photo, _userName, DateTime.Now);
            }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbEnseignant.Image = new Bitmap(ofd.FileName);
                Photo = ImageToByteArray(pbEnseignant.Image);
            }
        }

        private void SaveAndQuitClicked(object sender, EventArgs e)
        {
            SaveRecord();
            this.Close();
        }

        private void SaveAndAddClicked(object sender, EventArgs e)
        {
            SaveRecord();
            tbLastName.Text = null;
            tbFirstName.Text = null;
            tbOtherNames.Text = null;
            pbEnseignant.Image = null;
            dtpDOB.Value = DateTime.Today;
            cbSexe.SelectedIndex = 0;
            tbNotes.Text = null;
            tbNotes.Text = null;
        }

        private void QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
