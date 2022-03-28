using System;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Cryptograph
{
    public partial class FormSettings : Form
    {
        public Alphabets alphabets;
        public ComboBox cbAlphabet;
        public ComboBox cbAlphabet2;
        public ComboBox cbShift;
        public FormSettings()
        {
            InitializeComponent();

            if (File.Exists("Alphabets.xml"))
                LoadSettings();

            if (System.Threading.Thread.CurrentThread.CurrentCulture.ToString() == "en")
                rbtnEnglish.Checked = true;
            else
                rbtnRussian.Checked = true;
        }

        private void LoadSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
            {
                Alphabets alphabets = (Alphabets)serializer.Deserialize(fs);

                lvAlphabets.Items.Clear();
                foreach (var alphabet in alphabets.ListOfAlphabets)
                {
                    lvAlphabets.Items.Add(alphabet.Name);

                    int index = lvAlphabets.Items.Count - 1;
                    lvAlphabets.Items[index].Tag = alphabet;
                }
            }
        }
        
        private void AddAlphabet(object sender, EventArgs e)
        {
            if (tbLetters.Text == String.Empty || tbName.Text == String.Empty || tbLetters.Text.Length < 2)
                return;

            for (int i = 0; i < lvAlphabets.Items.Count; i++)
            {
                if (tbName.Text == lvAlphabets.Items[i].Text)
                {
                    MessageBox.Show(Properties.MyStrings.AlphabetNameError);
                    return;
                }
            }

            Alphabet alphabet = new Alphabet(tbName.Text, tbLetters.Text);

            lvAlphabets.Items.Add(alphabet.Name);

            int index = lvAlphabets.Items.Count - 1;
            lvAlphabets.Items[index].Tag = alphabet;

            ClearInput();
        }

        private void DeleteAlphabet(object sender, EventArgs e)
        {
            if (lvAlphabets.SelectedItems.Count == 1)
                lvAlphabets.SelectedItems[0].Remove();
        }

        private void RaiseElement(object sender, EventArgs e)
        {
            if (lvAlphabets.SelectedItems.Count == 0)
                return;

            if (lvAlphabets.SelectedItems[0].Index == 0)
                return;

            Alphabet alphabet = (Alphabet)lvAlphabets.SelectedItems[0].Tag;
            string name = lvAlphabets.SelectedItems[0].Text;
            int index = lvAlphabets.SelectedItems[0].Index - 1;

            lvAlphabets.SelectedItems[0].Text = lvAlphabets.Items[index].Text;
            lvAlphabets.SelectedItems[0].Tag = lvAlphabets.Items[index].Tag;

            lvAlphabets.Items[index].Text = name;
            lvAlphabets.Items[index].Tag = alphabet;

            lvAlphabets.Items[index].Selected = true;
            lvAlphabets.Items[index].Focused = true;
        }

        private void LetDownElement(object sender, EventArgs e)
        {
            if (lvAlphabets.SelectedItems.Count == 0)
                return;

            if (lvAlphabets.SelectedItems[0].Index == lvAlphabets.Items.Count - 1)
                return;

            Alphabet alphabet = (Alphabet)lvAlphabets.SelectedItems[0].Tag;
            string name = lvAlphabets.SelectedItems[0].Text;
            int index = lvAlphabets.SelectedItems[0].Index + 1;

            lvAlphabets.SelectedItems[0].Text = lvAlphabets.Items[index].Text;
            lvAlphabets.SelectedItems[0].Tag = lvAlphabets.Items[index].Tag;

            lvAlphabets.Items[index].Text = name;
            lvAlphabets.Items[index].Tag = alphabet;

            lvAlphabets.Items[index].Selected = true;
            lvAlphabets.Items[index].Focused = true;
        }

        private void SaveAlphabets(object sender, EventArgs e)
        {
            alphabets.ListOfAlphabets.Clear();
            for (int i = 0; i < lvAlphabets.Items.Count; i++)
            {
                alphabets.ListOfAlphabets.Add((Alphabet)lvAlphabets.Items[i].Tag);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Alphabets));
            File.WriteAllText("Alphabets.xml", String.Empty);

            using (FileStream fs = new FileStream("Alphabets.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabets);
            }

            cbAlphabet.Items.Clear();
            cbAlphabet2.Items.Clear();

            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                cbAlphabet.Items.Add(alphabet.Name);
                cbAlphabet2.Items.Add(alphabet.Name);
            }

            cbAlphabet.SelectedIndex = 0;
            cbAlphabet2.SelectedIndex = 0;

            cbShift.Items.Clear();
            foreach (var alphabet in alphabets.ListOfAlphabets)
            {
                if (alphabet.Name == cbAlphabet.SelectedItem.ToString())
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

        private void AlphabetChanged(object sender, EventArgs e)
        {
            if (lvAlphabets.SelectedItems.Count == 1)
            {
                Alphabet alphabet = (Alphabet)lvAlphabets.SelectedItems[0].Tag;

                if (alphabet != null)
                {
                    tbName.Text = alphabet.Name;
                    tbLetters.Text = alphabet.Letters;
                }
            }
            else if (lvAlphabets.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }

        private void ClearInput()
        {
            tbLetters.Text = String.Empty;
            tbName.Text = String.Empty;
        } 

        private void InputChanged(object sender, EventArgs e)
        {
            if (tbName.Text == String.Empty || tbLetters.Text == String.Empty)
                return;

            if (lvAlphabets.SelectedItems.Count == 1)
            {
                Alphabet alphabet = (Alphabet)lvAlphabets.SelectedItems[0].Tag;
                alphabet.Name = tbName.Text;
                lvAlphabets.SelectedItems[0].Text = tbName.Text;
                alphabet.Letters = tbLetters.Text;

                lvAlphabets.SelectedItems[0].Tag = alphabet;
            }
        }

        private void SaveLanguage(object sender, EventArgs e)
        {
            if (rbtnEnglish.Checked)
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
