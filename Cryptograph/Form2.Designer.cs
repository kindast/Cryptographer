namespace Cryptograph
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.AlphabetSettingsPage = new System.Windows.Forms.TabPage();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AlphabetsLbl = new System.Windows.Forms.Label();
            this.LettersTextBox = new System.Windows.Forms.TextBox();
            this.LettersLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AlphabetsListView = new System.Windows.Forms.ListView();
            this.LanguageSettingsPage = new System.Windows.Forms.TabPage();
            this.LanguageLbl = new System.Windows.Forms.Label();
            this.RussianRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveLanguageBtn = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.AlphabetSettingsPage.SuspendLayout();
            this.LanguageSettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.AlphabetSettingsPage);
            this.TabControl.Controls.Add(this.LanguageSettingsPage);
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            // 
            // AlphabetSettingsPage
            // 
            this.AlphabetSettingsPage.Controls.Add(this.NameTextBox);
            this.AlphabetSettingsPage.Controls.Add(this.NameLbl);
            this.AlphabetSettingsPage.Controls.Add(this.AlphabetsLbl);
            this.AlphabetSettingsPage.Controls.Add(this.LettersTextBox);
            this.AlphabetSettingsPage.Controls.Add(this.LettersLbl);
            this.AlphabetSettingsPage.Controls.Add(this.SaveBtn);
            this.AlphabetSettingsPage.Controls.Add(this.DeleteBtn);
            this.AlphabetSettingsPage.Controls.Add(this.AddBtn);
            this.AlphabetSettingsPage.Controls.Add(this.AlphabetsListView);
            resources.ApplyResources(this.AlphabetSettingsPage, "AlphabetSettingsPage");
            this.AlphabetSettingsPage.Name = "AlphabetSettingsPage";
            this.AlphabetSettingsPage.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // NameLbl
            // 
            resources.ApplyResources(this.NameLbl, "NameLbl");
            this.NameLbl.Name = "NameLbl";
            // 
            // AlphabetsLbl
            // 
            resources.ApplyResources(this.AlphabetsLbl, "AlphabetsLbl");
            this.AlphabetsLbl.Name = "AlphabetsLbl";
            // 
            // LettersTextBox
            // 
            this.LettersTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.LettersTextBox, "LettersTextBox");
            this.LettersTextBox.Name = "LettersTextBox";
            this.LettersTextBox.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // LettersLbl
            // 
            resources.ApplyResources(this.LettersLbl, "LettersLbl");
            this.LettersLbl.Name = "LettersLbl";
            // 
            // SaveBtn
            // 
            resources.ApplyResources(this.SaveBtn, "SaveBtn");
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveAlphabets);
            // 
            // DeleteBtn
            // 
            resources.ApplyResources(this.DeleteBtn, "DeleteBtn");
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteAlphabet);
            // 
            // AddBtn
            // 
            resources.ApplyResources(this.AddBtn, "AddBtn");
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddAlphabet);
            // 
            // AlphabetsListView
            // 
            this.AlphabetsListView.GridLines = true;
            this.AlphabetsListView.HideSelection = false;
            resources.ApplyResources(this.AlphabetsListView, "AlphabetsListView");
            this.AlphabetsListView.MultiSelect = false;
            this.AlphabetsListView.Name = "AlphabetsListView";
            this.AlphabetsListView.UseCompatibleStateImageBehavior = false;
            this.AlphabetsListView.View = System.Windows.Forms.View.List;
            this.AlphabetsListView.SelectedIndexChanged += new System.EventHandler(this.AlphabetChanged);
            // 
            // LanguageSettingsPage
            // 
            this.LanguageSettingsPage.Controls.Add(this.LanguageLbl);
            this.LanguageSettingsPage.Controls.Add(this.RussianRadioButton);
            this.LanguageSettingsPage.Controls.Add(this.EnglishRadioButton);
            this.LanguageSettingsPage.Controls.Add(this.SaveLanguageBtn);
            resources.ApplyResources(this.LanguageSettingsPage, "LanguageSettingsPage");
            this.LanguageSettingsPage.Name = "LanguageSettingsPage";
            this.LanguageSettingsPage.UseVisualStyleBackColor = true;
            // 
            // LanguageLbl
            // 
            resources.ApplyResources(this.LanguageLbl, "LanguageLbl");
            this.LanguageLbl.Name = "LanguageLbl";
            // 
            // RussianRadioButton
            // 
            resources.ApplyResources(this.RussianRadioButton, "RussianRadioButton");
            this.RussianRadioButton.Name = "RussianRadioButton";
            this.RussianRadioButton.TabStop = true;
            this.RussianRadioButton.UseVisualStyleBackColor = true;
            // 
            // EnglishRadioButton
            // 
            resources.ApplyResources(this.EnglishRadioButton, "EnglishRadioButton");
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveLanguageBtn
            // 
            this.SaveLanguageBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SaveLanguageBtn, "SaveLanguageBtn");
            this.SaveLanguageBtn.Name = "SaveLanguageBtn";
            this.SaveLanguageBtn.UseVisualStyleBackColor = true;
            this.SaveLanguageBtn.Click += new System.EventHandler(this.SaveLanguage);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.TabControl.ResumeLayout(false);
            this.AlphabetSettingsPage.ResumeLayout(false);
            this.AlphabetSettingsPage.PerformLayout();
            this.LanguageSettingsPage.ResumeLayout(false);
            this.LanguageSettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage AlphabetSettingsPage;
        private System.Windows.Forms.TabPage LanguageSettingsPage;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListView AlphabetsListView;
        private System.Windows.Forms.TextBox LettersTextBox;
        private System.Windows.Forms.Label LettersLbl;
        private System.Windows.Forms.Label AlphabetsLbl;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.RadioButton RussianRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.Button SaveLanguageBtn;
        private System.Windows.Forms.Label LanguageLbl;
        public System.Windows.Forms.TabControl TabControl;
    }
}