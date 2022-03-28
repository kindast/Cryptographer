namespace Cryptograph
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.tabVigenere = new System.Windows.Forms.TabPage();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblAlphabet2 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.cbVigenereAlphabet = new System.Windows.Forms.ComboBox();
            this.tbVigenere = new System.Windows.Forms.RichTextBox();
            this.btnVigenereDecrypt = new System.Windows.Forms.Button();
            this.btnVigenereEncrypt = new System.Windows.Forms.Button();
            this.tabCaesar = new System.Windows.Forms.TabPage();
            this.cbShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblAlphabet1 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.cbCaesarAlphabet = new System.Windows.Forms.ComboBox();
            this.tbCaesar = new System.Windows.Forms.RichTextBox();
            this.btnCaesarDecrypt = new System.Windows.Forms.Button();
            this.btnCaesarEncrypt = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miAlphabets = new System.Windows.Forms.ToolStripMenuItem();
            this.miLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.miReset = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAndIntriduction = new System.Windows.Forms.ToolStripMenuItem();
            this.tabVigenere.SuspendLayout();
            this.tabCaesar.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVigenere
            // 
            this.tabVigenere.Controls.Add(this.tbKey);
            this.tabVigenere.Controls.Add(this.lblKey);
            this.tabVigenere.Controls.Add(this.lblAlphabet2);
            this.tabVigenere.Controls.Add(this.lblText2);
            this.tabVigenere.Controls.Add(this.cbVigenereAlphabet);
            this.tabVigenere.Controls.Add(this.tbVigenere);
            this.tabVigenere.Controls.Add(this.btnVigenereDecrypt);
            this.tabVigenere.Controls.Add(this.btnVigenereEncrypt);
            resources.ApplyResources(this.tabVigenere, "tabVigenere");
            this.tabVigenere.Name = "tabVigenere";
            this.tabVigenere.UseVisualStyleBackColor = true;
            // 
            // tbKey
            // 
            resources.ApplyResources(this.tbKey, "tbKey");
            this.tbKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKey.Name = "tbKey";
            // 
            // lblKey
            // 
            resources.ApplyResources(this.lblKey, "lblKey");
            this.lblKey.Name = "lblKey";
            // 
            // lblAlphabet2
            // 
            resources.ApplyResources(this.lblAlphabet2, "lblAlphabet2");
            this.lblAlphabet2.Name = "lblAlphabet2";
            // 
            // lblText2
            // 
            resources.ApplyResources(this.lblText2, "lblText2");
            this.lblText2.Name = "lblText2";
            // 
            // cbVigenereAlphabet
            // 
            resources.ApplyResources(this.cbVigenereAlphabet, "cbVigenereAlphabet");
            this.cbVigenereAlphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVigenereAlphabet.FormattingEnabled = true;
            this.cbVigenereAlphabet.Name = "cbVigenereAlphabet";
            // 
            // tbVigenere
            // 
            resources.ApplyResources(this.tbVigenere, "tbVigenere");
            this.tbVigenere.Name = "tbVigenere";
            // 
            // btnVigenereDecrypt
            // 
            resources.ApplyResources(this.btnVigenereDecrypt, "btnVigenereDecrypt");
            this.btnVigenereDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVigenereDecrypt.Name = "btnVigenereDecrypt";
            this.btnVigenereDecrypt.UseVisualStyleBackColor = true;
            this.btnVigenereDecrypt.Click += new System.EventHandler(this.VigenereEnDecrypt);
            // 
            // btnVigenereEncrypt
            // 
            resources.ApplyResources(this.btnVigenereEncrypt, "btnVigenereEncrypt");
            this.btnVigenereEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVigenereEncrypt.Name = "btnVigenereEncrypt";
            this.btnVigenereEncrypt.UseVisualStyleBackColor = true;
            this.btnVigenereEncrypt.Click += new System.EventHandler(this.VigenereEnDecrypt);
            // 
            // tabCaesar
            // 
            this.tabCaesar.Controls.Add(this.cbShift);
            this.tabCaesar.Controls.Add(this.lblShift);
            this.tabCaesar.Controls.Add(this.lblAlphabet1);
            this.tabCaesar.Controls.Add(this.lblText1);
            this.tabCaesar.Controls.Add(this.cbCaesarAlphabet);
            this.tabCaesar.Controls.Add(this.tbCaesar);
            this.tabCaesar.Controls.Add(this.btnCaesarDecrypt);
            this.tabCaesar.Controls.Add(this.btnCaesarEncrypt);
            resources.ApplyResources(this.tabCaesar, "tabCaesar");
            this.tabCaesar.Name = "tabCaesar";
            this.tabCaesar.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            resources.ApplyResources(this.cbShift, "cbShift");
            this.cbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShift.FormattingEnabled = true;
            this.cbShift.Name = "cbShift";
            // 
            // lblShift
            // 
            resources.ApplyResources(this.lblShift, "lblShift");
            this.lblShift.Name = "lblShift";
            // 
            // lblAlphabet1
            // 
            resources.ApplyResources(this.lblAlphabet1, "lblAlphabet1");
            this.lblAlphabet1.Name = "lblAlphabet1";
            // 
            // lblText1
            // 
            resources.ApplyResources(this.lblText1, "lblText1");
            this.lblText1.Name = "lblText1";
            // 
            // cbCaesarAlphabet
            // 
            resources.ApplyResources(this.cbCaesarAlphabet, "cbCaesarAlphabet");
            this.cbCaesarAlphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaesarAlphabet.FormattingEnabled = true;
            this.cbCaesarAlphabet.Name = "cbCaesarAlphabet";
            this.cbCaesarAlphabet.SelectedIndexChanged += new System.EventHandler(this.AlphabetChanged);
            // 
            // tbCaesar
            // 
            resources.ApplyResources(this.tbCaesar, "tbCaesar");
            this.tbCaesar.Name = "tbCaesar";
            // 
            // btnCaesarDecrypt
            // 
            resources.ApplyResources(this.btnCaesarDecrypt, "btnCaesarDecrypt");
            this.btnCaesarDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaesarDecrypt.Name = "btnCaesarDecrypt";
            this.btnCaesarDecrypt.UseVisualStyleBackColor = true;
            this.btnCaesarDecrypt.Click += new System.EventHandler(this.CaesarEnDecrypt);
            // 
            // btnCaesarEncrypt
            // 
            resources.ApplyResources(this.btnCaesarEncrypt, "btnCaesarEncrypt");
            this.btnCaesarEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaesarEncrypt.Name = "btnCaesarEncrypt";
            this.btnCaesarEncrypt.UseVisualStyleBackColor = true;
            this.btnCaesarEncrypt.Click += new System.EventHandler(this.CaesarEnDecrypt);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCaesar);
            this.tabControl.Controls.Add(this.tabVigenere);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miSettings,
            this.miHelp});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoadFile,
            this.miSaveFile,
            this.miExit});
            this.miFile.Name = "miFile";
            resources.ApplyResources(this.miFile, "miFile");
            // 
            // miLoadFile
            // 
            this.miLoadFile.Name = "miLoadFile";
            resources.ApplyResources(this.miLoadFile, "miLoadFile");
            this.miLoadFile.Click += new System.EventHandler(this.LoadTextFromFile);
            // 
            // miSaveFile
            // 
            this.miSaveFile.Name = "miSaveFile";
            resources.ApplyResources(this.miSaveFile, "miSaveFile");
            this.miSaveFile.Click += new System.EventHandler(this.SaveTextToFile);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Click += new System.EventHandler(this.Exit);
            // 
            // miSettings
            // 
            this.miSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAlphabets,
            this.miLanguage,
            this.miReset});
            this.miSettings.Name = "miSettings";
            resources.ApplyResources(this.miSettings, "miSettings");
            // 
            // miAlphabets
            // 
            this.miAlphabets.Name = "miAlphabets";
            resources.ApplyResources(this.miAlphabets, "miAlphabets");
            this.miAlphabets.Click += new System.EventHandler(this.OpenAlphabetSettings);
            // 
            // miLanguage
            // 
            this.miLanguage.Name = "miLanguage";
            resources.ApplyResources(this.miLanguage, "miLanguage");
            this.miLanguage.Click += new System.EventHandler(this.OpenLanguageSettings);
            // 
            // miReset
            // 
            this.miReset.Name = "miReset";
            resources.ApplyResources(this.miReset, "miReset");
            this.miReset.Click += new System.EventHandler(this.ResetSettings);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAndIntriduction});
            this.miHelp.Name = "miHelp";
            resources.ApplyResources(this.miHelp, "miHelp");
            // 
            // miHelpAndIntriduction
            // 
            this.miHelpAndIntriduction.Name = "miHelpAndIntriduction";
            resources.ApplyResources(this.miHelpAndIntriduction, "miHelpAndIntriduction");
            this.miHelpAndIntriduction.Click += new System.EventHandler(this.OpenHelpForm);
            // 
            // FormStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormStart";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStart_FormClosing);
            this.tabVigenere.ResumeLayout(false);
            this.tabVigenere.PerformLayout();
            this.tabCaesar.ResumeLayout(false);
            this.tabCaesar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabVigenere;
        private System.Windows.Forms.TabPage tabCaesar;
        private System.Windows.Forms.RichTextBox tbCaesar;
        private System.Windows.Forms.Button btnCaesarDecrypt;
        private System.Windows.Forms.Button btnCaesarEncrypt;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ComboBox cbCaesarAlphabet;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblAlphabet1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miLanguage;
        private System.Windows.Forms.ToolStripMenuItem miReset;
        private System.Windows.Forms.ToolStripMenuItem miHelpAndIntriduction;
        private System.Windows.Forms.ToolStripMenuItem miAlphabets;
        private System.Windows.Forms.ComboBox cbShift;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblAlphabet2;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.ComboBox cbVigenereAlphabet;
        private System.Windows.Forms.RichTextBox tbVigenere;
        private System.Windows.Forms.Button btnVigenereDecrypt;
        private System.Windows.Forms.Button btnVigenereEncrypt;
        private System.Windows.Forms.ToolStripMenuItem miLoadFile;
        private System.Windows.Forms.ToolStripMenuItem miSaveFile;
    }
}

