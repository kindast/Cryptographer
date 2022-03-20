namespace Cryptograph
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VigenereTab = new System.Windows.Forms.TabPage();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VigenereAlphabetComboBox = new System.Windows.Forms.ComboBox();
            this.VigenereTextBox = new System.Windows.Forms.RichTextBox();
            this.VigenereDecryptBtn = new System.Windows.Forms.Button();
            this.VigenereEncryptBtn = new System.Windows.Forms.Button();
            this.CaesarTab = new System.Windows.Forms.TabPage();
            this.ShiftComboBox = new System.Windows.Forms.ComboBox();
            this.ShiftLbl = new System.Windows.Forms.Label();
            this.AlphabetLbl = new System.Windows.Forms.Label();
            this.TextLbl = new System.Windows.Forms.Label();
            this.CaesarAlphabetComboBox = new System.Windows.Forms.ComboBox();
            this.CaesarTextBox = new System.Windows.Forms.RichTextBox();
            this.CaesarDecryptBtn = new System.Windows.Forms.Button();
            this.CaesarEncryptBtn = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTextFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTextToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlphabetsSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAndIntriductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VigenereTab.SuspendLayout();
            this.CaesarTab.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VigenereTab
            // 
            this.VigenereTab.Controls.Add(this.KeyTextBox);
            this.VigenereTab.Controls.Add(this.label1);
            this.VigenereTab.Controls.Add(this.label2);
            this.VigenereTab.Controls.Add(this.label3);
            this.VigenereTab.Controls.Add(this.VigenereAlphabetComboBox);
            this.VigenereTab.Controls.Add(this.VigenereTextBox);
            this.VigenereTab.Controls.Add(this.VigenereDecryptBtn);
            this.VigenereTab.Controls.Add(this.VigenereEncryptBtn);
            resources.ApplyResources(this.VigenereTab, "VigenereTab");
            this.VigenereTab.Name = "VigenereTab";
            this.VigenereTab.UseVisualStyleBackColor = true;
            // 
            // KeyTextBox
            // 
            resources.ApplyResources(this.KeyTextBox, "KeyTextBox");
            this.KeyTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.KeyTextBox.Name = "KeyTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // VigenereAlphabetComboBox
            // 
            resources.ApplyResources(this.VigenereAlphabetComboBox, "VigenereAlphabetComboBox");
            this.VigenereAlphabetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VigenereAlphabetComboBox.FormattingEnabled = true;
            this.VigenereAlphabetComboBox.Name = "VigenereAlphabetComboBox";
            // 
            // VigenereTextBox
            // 
            resources.ApplyResources(this.VigenereTextBox, "VigenereTextBox");
            this.VigenereTextBox.Name = "VigenereTextBox";
            // 
            // VigenereDecryptBtn
            // 
            resources.ApplyResources(this.VigenereDecryptBtn, "VigenereDecryptBtn");
            this.VigenereDecryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VigenereDecryptBtn.Name = "VigenereDecryptBtn";
            this.VigenereDecryptBtn.UseVisualStyleBackColor = true;
            this.VigenereDecryptBtn.Click += new System.EventHandler(this.VigenereDecrypt);
            // 
            // VigenereEncryptBtn
            // 
            resources.ApplyResources(this.VigenereEncryptBtn, "VigenereEncryptBtn");
            this.VigenereEncryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VigenereEncryptBtn.Name = "VigenereEncryptBtn";
            this.VigenereEncryptBtn.UseVisualStyleBackColor = true;
            this.VigenereEncryptBtn.Click += new System.EventHandler(this.VigenereCrypt);
            // 
            // CaesarTab
            // 
            this.CaesarTab.Controls.Add(this.ShiftComboBox);
            this.CaesarTab.Controls.Add(this.ShiftLbl);
            this.CaesarTab.Controls.Add(this.AlphabetLbl);
            this.CaesarTab.Controls.Add(this.TextLbl);
            this.CaesarTab.Controls.Add(this.CaesarAlphabetComboBox);
            this.CaesarTab.Controls.Add(this.CaesarTextBox);
            this.CaesarTab.Controls.Add(this.CaesarDecryptBtn);
            this.CaesarTab.Controls.Add(this.CaesarEncryptBtn);
            resources.ApplyResources(this.CaesarTab, "CaesarTab");
            this.CaesarTab.Name = "CaesarTab";
            this.CaesarTab.UseVisualStyleBackColor = true;
            // 
            // ShiftComboBox
            // 
            resources.ApplyResources(this.ShiftComboBox, "ShiftComboBox");
            this.ShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftComboBox.FormattingEnabled = true;
            this.ShiftComboBox.Name = "ShiftComboBox";
            // 
            // ShiftLbl
            // 
            resources.ApplyResources(this.ShiftLbl, "ShiftLbl");
            this.ShiftLbl.Name = "ShiftLbl";
            // 
            // AlphabetLbl
            // 
            resources.ApplyResources(this.AlphabetLbl, "AlphabetLbl");
            this.AlphabetLbl.Name = "AlphabetLbl";
            // 
            // TextLbl
            // 
            resources.ApplyResources(this.TextLbl, "TextLbl");
            this.TextLbl.Name = "TextLbl";
            // 
            // CaesarAlphabetComboBox
            // 
            resources.ApplyResources(this.CaesarAlphabetComboBox, "CaesarAlphabetComboBox");
            this.CaesarAlphabetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CaesarAlphabetComboBox.FormattingEnabled = true;
            this.CaesarAlphabetComboBox.Name = "CaesarAlphabetComboBox";
            this.CaesarAlphabetComboBox.SelectedIndexChanged += new System.EventHandler(this.AlphabetChanged);
            // 
            // CaesarTextBox
            // 
            resources.ApplyResources(this.CaesarTextBox, "CaesarTextBox");
            this.CaesarTextBox.Name = "CaesarTextBox";
            // 
            // CaesarDecryptBtn
            // 
            resources.ApplyResources(this.CaesarDecryptBtn, "CaesarDecryptBtn");
            this.CaesarDecryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaesarDecryptBtn.Name = "CaesarDecryptBtn";
            this.CaesarDecryptBtn.UseVisualStyleBackColor = true;
            this.CaesarDecryptBtn.Click += new System.EventHandler(this.CaesarDecrypt);
            // 
            // CaesarEncryptBtn
            // 
            resources.ApplyResources(this.CaesarEncryptBtn, "CaesarEncryptBtn");
            this.CaesarEncryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaesarEncryptBtn.Name = "CaesarEncryptBtn";
            this.CaesarEncryptBtn.UseVisualStyleBackColor = true;
            this.CaesarEncryptBtn.Click += new System.EventHandler(this.CaesarEncrypt);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CaesarTab);
            this.TabControl.Controls.Add(this.VigenereTab);
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.settingsMenuItem,
            this.infoHelpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTextFromFileToolStripMenuItem,
            this.saveTextToFileToolStripMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            resources.ApplyResources(this.FileMenuItem, "FileMenuItem");
            // 
            // loadTextFromFileToolStripMenuItem
            // 
            this.loadTextFromFileToolStripMenuItem.Name = "loadTextFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadTextFromFileToolStripMenuItem, "loadTextFromFileToolStripMenuItem");
            this.loadTextFromFileToolStripMenuItem.Click += new System.EventHandler(this.LoadTextFromFile);
            // 
            // saveTextToFileToolStripMenuItem
            // 
            this.saveTextToFileToolStripMenuItem.Name = "saveTextToFileToolStripMenuItem";
            resources.ApplyResources(this.saveTextToFileToolStripMenuItem, "saveTextToFileToolStripMenuItem");
            this.saveTextToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveTextToFile);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            resources.ApplyResources(this.ExitMenuItem, "ExitMenuItem");
            this.ExitMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlphabetsSettingsMenuItem,
            this.languageSettingsToolStripMenuItem,
            this.resetSettingsMenuItem});
            this.settingsMenuItem.Name = "settingsMenuItem";
            resources.ApplyResources(this.settingsMenuItem, "settingsMenuItem");
            // 
            // AlphabetsSettingsMenuItem
            // 
            this.AlphabetsSettingsMenuItem.Name = "AlphabetsSettingsMenuItem";
            resources.ApplyResources(this.AlphabetsSettingsMenuItem, "AlphabetsSettingsMenuItem");
            this.AlphabetsSettingsMenuItem.Click += new System.EventHandler(this.OpenAlphabetSettings);
            // 
            // languageSettingsToolStripMenuItem
            // 
            this.languageSettingsToolStripMenuItem.Name = "languageSettingsToolStripMenuItem";
            resources.ApplyResources(this.languageSettingsToolStripMenuItem, "languageSettingsToolStripMenuItem");
            this.languageSettingsToolStripMenuItem.Click += new System.EventHandler(this.OpenLanguageSettings);
            // 
            // resetSettingsMenuItem
            // 
            this.resetSettingsMenuItem.Name = "resetSettingsMenuItem";
            resources.ApplyResources(this.resetSettingsMenuItem, "resetSettingsMenuItem");
            this.resetSettingsMenuItem.Click += new System.EventHandler(this.ResetSettings);
            // 
            // infoHelpToolStripMenuItem
            // 
            this.infoHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAndIntriductionToolStripMenuItem});
            this.infoHelpToolStripMenuItem.Name = "infoHelpToolStripMenuItem";
            resources.ApplyResources(this.infoHelpToolStripMenuItem, "infoHelpToolStripMenuItem");
            // 
            // helpAndIntriductionToolStripMenuItem
            // 
            this.helpAndIntriductionToolStripMenuItem.Name = "helpAndIntriductionToolStripMenuItem";
            resources.ApplyResources(this.helpAndIntriductionToolStripMenuItem, "helpAndIntriductionToolStripMenuItem");
            this.helpAndIntriductionToolStripMenuItem.Click += new System.EventHandler(this.OpenHelpForm);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.VigenereTab.ResumeLayout(false);
            this.VigenereTab.PerformLayout();
            this.CaesarTab.ResumeLayout(false);
            this.CaesarTab.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage VigenereTab;
        private System.Windows.Forms.TabPage CaesarTab;
        private System.Windows.Forms.RichTextBox CaesarTextBox;
        private System.Windows.Forms.Button CaesarDecryptBtn;
        private System.Windows.Forms.Button CaesarEncryptBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.ComboBox CaesarAlphabetComboBox;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label ShiftLbl;
        private System.Windows.Forms.Label AlphabetLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAndIntriductionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlphabetsSettingsMenuItem;
        private System.Windows.Forms.ComboBox ShiftComboBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VigenereAlphabetComboBox;
        private System.Windows.Forms.RichTextBox VigenereTextBox;
        private System.Windows.Forms.Button VigenereDecryptBtn;
        private System.Windows.Forms.Button VigenereEncryptBtn;
        private System.Windows.Forms.ToolStripMenuItem loadTextFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTextToFileToolStripMenuItem;
    }
}

