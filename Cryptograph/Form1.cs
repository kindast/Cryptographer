using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cryptograph
{
    public partial class Form1 : Form
    {
        Alphabets alphabets = new Alphabets(new List<Alphabet>());
        public Form1()
        {
            if (Properties.Settings.Default.Launches == 0)
                ResetSettings(null, null);

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Language);
            }

            Properties.Settings.Default.Launches++;
            Properties.Settings.Default.Save();

            InitializeComponent();

            if (File.Exists("Alphabets.xml"))
            {
                LoadAlphabets();
            }
        }

        private void CaesarEncrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == CaesarAlphabetComboBox.Text)
                {
                    int Shift = Convert.ToInt32(ShiftComboBox.Text);
                    CaesarTextBox.Text = CaesarCipher.Encrypt(CaesarTextBox.Text, Shift, alphabet.Letters);
                    break;
                }
            }
        }

        private void CaesarDecrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == CaesarAlphabetComboBox.Text)
                {
                    int Shift = Convert.ToInt32(ShiftComboBox.Text);
                    CaesarTextBox.Text = CaesarCipher.Decrypt(CaesarTextBox.Text, Shift, alphabet.Letters);
                    break;
                }
            }
        }

        private void VigenereCrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == VigenereAlphabetComboBox.Text)
                {
                    VigenereTextBox.Text = VigenereCipher.Encrypt(VigenereTextBox.Text, KeyTextBox.Text, alphabet.Letters);
                    break;
                }
            }
        }

        private void VigenereDecrypt(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == VigenereAlphabetComboBox.Text)
                {
                    VigenereTextBox.Text = VigenereCipher.Decrypt(VigenereTextBox.Text, KeyTextBox.Text, alphabet.Letters);
                    break;
                }
            }
        }

        private void LoadAlphabets()
        {
            CaesarAlphabetComboBox.Items.Clear();
            VigenereAlphabetComboBox.Items.Clear();

            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
                alphabets = (Alphabets)serializer.Deserialize(fs);

            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                CaesarAlphabetComboBox.Items.Add(alphabet.Name);
                VigenereAlphabetComboBox.Items.Add(alphabet.Name);
            }

            CaesarAlphabetComboBox.SelectedIndex = 0;
            VigenereAlphabetComboBox.SelectedIndex = 0;
        }

        private void AlphabetChanged(object sender, EventArgs e)
        {
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == CaesarAlphabetComboBox.SelectedItem.ToString())
                {
                    ShiftComboBox.Items.Clear();
                    for (int i = 0; i < alphabet.Letters.Length; i++)
                    {
                        ShiftComboBox.Items.Add((i + 1).ToString());
                    }
                    ShiftComboBox.SelectedIndex = 0;
                    break;
                }
            }
        }

        private void OpenSettings(int TabControlIndex)
        {
            Form2 settings = new Form2();

            settings.AlphabetComboBox = this.CaesarAlphabetComboBox;
            settings.AlphabetComboBox2 = this.VigenereAlphabetComboBox;
            settings.ShiftComboBox = this.ShiftComboBox;
            settings.alphabets = this.alphabets;
            settings.TabControl.SelectedIndex = TabControlIndex;

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

            alphabets.ListOfAlphabets.Add(english);
            alphabets.ListOfAlphabets.Add(russian);

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
            fileDialog.Filter = $"{MyStrings.FileDialogTxtFiles} (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = fileDialog.FileName;
                string FileContent = File.ReadAllText(FilePath);

                if (TabControl.SelectedIndex == 0)
                    CaesarTextBox.Text = FileContent;
                else
                    VigenereTextBox.Text = FileContent;

            }
        }

        private void SaveTextToFile(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = $"{MyStrings.FileDialogTxtFiles} (*.txt)|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string FilePath = fileDialog.FileName;
                if (TabControl.SelectedIndex == 0)
                    File.WriteAllText(FilePath, CaesarTextBox.Text);
                else
                    File.WriteAllText(FilePath, VigenereTextBox.Text);
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenHelpForm(object sender, EventArgs e)
        {
            Form3 helpform = new Form3();
            helpform.ShowDialog();
        }
    }
}
