using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using CipherLib;

namespace Cryptograph
{
    public partial class FormStart : Form
    {
        Alphabets alphabets = new Alphabets(new List<Alphabet>());
        public FormStart()
        {
            if (!File.Exists("Alphabets.xml"))
                ResetSettings(null, null);

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
            }

            InitializeComponent();

            this.Width = Properties.Settings.Default.Width;
            this.Height = Properties.Settings.Default.Height;

            LoadAlphabets();
        }

        private void LoadAlphabets()
        {
            cbCaesarAlphabet.Items.Clear();
            cbVigenereAlphabet.Items.Clear();

            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
                alphabets = (Alphabets)serializer.Deserialize(fs);

            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                cbCaesarAlphabet.Items.Add(alphabet.Name);
                cbVigenereAlphabet.Items.Add(alphabet.Name);
            }

            cbCaesarAlphabet.SelectedIndex = 0;
            cbVigenereAlphabet.SelectedIndex = 0;
        }

        private void CaesarEncrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbCaesarAlphabet.Text)
                {
                    int Shift = Convert.ToInt32(cbShift.Text);
                    try
                    {
                        tbCaesar.Text = CaesarCipher.Encrypt(tbCaesar.Text, Shift, alphabet.Letters);
                    }
                    catch (CipherLib.Exceptions.InputIsEmptyException)
                    {
                        MessageBox.Show(Properties.MyStrings.CaesarInputIsEmptyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void CaesarDecrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbCaesarAlphabet.Text)
                {
                    int Shift = Convert.ToInt32(cbShift.Text);
                    try
                    {
                        tbCaesar.Text = CaesarCipher.Decrypt(tbCaesar.Text, Shift, alphabet.Letters);
                    }
                    catch (CipherLib.Exceptions.InputIsEmptyException)
                    {
                        MessageBox.Show(Properties.MyStrings.CaesarInputIsEmptyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void VigenereCrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbVigenereAlphabet.Text)
                {
                    try
                    {
                        tbVigenere.Text = VigenereCipher.Encrypt(tbVigenere.Text, tbKey.Text, alphabet.Letters);
                    }
                    catch (CipherLib.Exceptions.InputIsEmptyException)
                    {
                        MessageBox.Show(Properties.MyStrings.VigenereInputIsEmptyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    catch (CipherLib.Exceptions.InvalidKeyException)
                    {
                        MessageBox.Show(Properties.MyStrings.InvalidKeyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void VigenereDecrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbVigenereAlphabet.Text)
                {
                    try
                    {
                        tbVigenere.Text = VigenereCipher.Decrypt(tbVigenere.Text, tbKey.Text, alphabet.Letters);
                    }
                    catch (CipherLib.Exceptions.InputIsEmptyException)
                    {
                        MessageBox.Show(Properties.MyStrings.VigenereInputIsEmptyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    catch (CipherLib.Exceptions.InvalidKeyException)
                    {
                        MessageBox.Show(Properties.MyStrings.InvalidKeyException,
                            Properties.MyStrings.mbCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void AlphabetChanged(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbCaesarAlphabet.SelectedItem.ToString())
                {
                    cbShift.Items.Clear();
                    for (int i = 0; i < alphabet.Letters.Length - 1; i++)
                    {
                        cbShift.Items.Add((i + 1).ToString());
                    }
                    cbShift.SelectedIndex = 0;
                    break;
                }
            }
        }

        private void OpenSettings(int TabControlIndex)
        {
            FormSettings settings = new FormSettings();

            settings.cbAlphabet = this.cbCaesarAlphabet;
            settings.cbAlphabet2 = this.cbVigenereAlphabet;
            settings.cbShift = this.cbShift;
            settings.alphabets = this.alphabets;
            settings.tabControl.SelectedIndex = TabControlIndex;

            settings.ShowDialog();
        }

        private void OpenAlphabetSettings(object sender, EventArgs e)
        {
            OpenSettings(0);
        }

        private void OpenLanguageSettings(object sender, EventArgs e)
        {
            OpenSettings(1);
        }

        private void ResetSettings(object sender, EventArgs e)
        {
            string Culture = System.Globalization.CultureInfo.CurrentUICulture.Name;

            if (Culture.Length > 2)
                Culture = Culture.Remove(2);

            switch (Culture)
            {
                case "ru":
                    Properties.Settings.Default.Language = "ru";
                    break;
                
                default:
                    Properties.Settings.Default.Language = "en";
                    break;
            }

            Properties.Settings.Default.Save();



            Alphabets alphabets = new Alphabets(new List<Alphabet>());

            Alphabet english = new Alphabet("English", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            Alphabet russian = new Alphabet("Русский", "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");

            alphabets.ListOfAlphabets.Add(russian);
            alphabets.ListOfAlphabets.Add(english);

            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));
            File.WriteAllText("Alphabets.xml", String.Empty);

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabets);
            }

            if (sender != null) 
                Application.Restart();

        }

        private void LoadTextFromFile(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = $"{Properties.MyStrings.FileDialogTxtFiles} (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = fileDialog.FileName;
                string FileContent = File.ReadAllText(FilePath);

                if (tabControl.SelectedIndex == 0)
                    tbCaesar.Text = FileContent;
                else
                    tbVigenere.Text = FileContent;

            }
        }

        private void SaveTextToFile(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = $"{Properties.MyStrings.FileDialogTxtFiles} (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = fileDialog.FileName;
                if (tabControl.SelectedIndex == 0)
                    File.WriteAllText(FilePath, tbCaesar.Text);
                else
                    File.WriteAllText(FilePath, tbVigenere.Text);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenHelpForm(object sender, EventArgs e)
        {
            FormHelp helpform = new FormHelp();
            helpform.ShowDialog();
        }

        private void FormStart_FormClosing(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Width = this.Width;
            Properties.Settings.Default.Height = this.Height;
            Properties.Settings.Default.Save();
        }
    }
}
