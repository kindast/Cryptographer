using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Cryptograph
{
    public partial class Form2 : Form
    {
        public Alphabets alphabets;
        public ComboBox AlphabetComboBox;
        public ComboBox AlphabetComboBox2;
        public ComboBox ShiftComboBox;
        public Form2()
        {
            InitializeComponent();

            if (File.Exists("Alphabets.xml"))
                LoadSettings();

            if (System.Threading.Thread.CurrentThread.CurrentCulture.ToString() == "en")
                EnglishRadioButton.Checked = true;
            else
                RussianRadioButton.Checked = true;
        }

        private void LoadSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
            {
                Alphabets alphabets_ = (Alphabets)serializer.Deserialize(fs);

                AlphabetsListView.Items.Clear();
                foreach (var alphabet in alphabets_.ListOfAlphabets)
                {
                    AlphabetsListView.Items.Add(alphabet.Name);

                    int index = AlphabetsListView.Items.Count - 1;
                    AlphabetsListView.Items[index].Tag = alphabet;
                }
            }
        }
        
        private void AddAlphabet(object sender, EventArgs e)
        {
            if (LettersTextBox.Text == String.Empty && NameTextBox.Text == String.Empty)
                return;

            for (int i = 0; i < AlphabetsListView.Items.Count; i++)
            {
                if (NameTextBox.Text == AlphabetsListView.Items[i].Text)
                {
                    MessageBox.Show(MyStrings.AlphabetNameError);
                    return;
                }
            }

            Alphabet alphabet = new Alphabet(NameTextBox.Text, LettersTextBox.Text);

            AlphabetsListView.Items.Add(alphabet.Name);

            int index = AlphabetsListView.Items.Count - 1;
            AlphabetsListView.Items[index].Tag = alphabet;

            ClearInput();
        }

        private void DeleteAlphabet(object sender, EventArgs e)
        {
            if (AlphabetsListView.SelectedItems.Count == 1)
            {
                AlphabetsListView.SelectedItems[0].Remove();
            }
        }

        private void SaveAlphabets(object sender, EventArgs e)
        {
            alphabets.ListOfAlphabets.Clear();
            for (int i = 0; i < AlphabetsListView.Items.Count; i++)
            {
                alphabets.ListOfAlphabets.Add((Alphabet)AlphabetsListView.Items[i].Tag);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));
            File.WriteAllText("Alphabets.xml", String.Empty);

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabets);
            }

            AlphabetComboBox.Items.Clear();
            AlphabetComboBox2.Items.Clear();

            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                AlphabetComboBox.Items.Add(alphabet.Name);
                AlphabetComboBox2.Items.Add(alphabet.Name);
            }

            AlphabetComboBox.SelectedIndex = 0;
            AlphabetComboBox2.SelectedIndex = 0;

            ShiftComboBox.Items.Clear();
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == AlphabetComboBox.SelectedItem.ToString())
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

        private void AlphabetChanged(object sender, EventArgs e)
        {
            if (AlphabetsListView.SelectedItems.Count == 1)
            {
                Alphabet alphabet = (Alphabet)AlphabetsListView.SelectedItems[0].Tag;

                if (alphabet != null)
                {
                    NameTextBox.Text = alphabet.Name;
                    LettersTextBox.Text = alphabet.Letters;
                }
            }
            else if (AlphabetsListView.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void ClearInput()
        {
            LettersTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
        } 

        private void InputChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == String.Empty || LettersTextBox.Text == String.Empty)
                return;

            if (AlphabetsListView.SelectedItems.Count == 1)
            {
                Alphabet alphabet = (Alphabet)AlphabetsListView.SelectedItems[0].Tag;
                alphabet.Name = NameTextBox.Text;
                AlphabetsListView.SelectedItems[0].Text = NameTextBox.Text;
                alphabet.Letters = LettersTextBox.Text;

                AlphabetsListView.SelectedItems[0].Tag = alphabet;
            }
        }

        private void SaveLanguage(object sender, EventArgs e)
        {
            if (EnglishRadioButton.Checked)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                Properties.Settings.Default.Language = "en";
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
                Properties.Settings.Default.Language = "ru";
            }

            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
