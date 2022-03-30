namespace Cryptograph
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlphabet = new System.Windows.Forms.TabPage();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAlphabets = new System.Windows.Forms.Label();
            this.tbLetters = new System.Windows.Forms.TextBox();
            this.lblLetters = new System.Windows.Forms.Label();
            this.btnSaveAlphabets = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvAlphabets = new System.Windows.Forms.ListView();
            this.tabLanguage = new System.Windows.Forms.TabPage();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rbtnRussian = new System.Windows.Forms.RadioButton();
            this.rbtnEnglish = new System.Windows.Forms.RadioButton();
            this.btnSaveLanguage = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabAlphabet.SuspendLayout();
            this.tabLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAlphabet);
            this.tabControl.Controls.Add(this.tabLanguage);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabAlphabet
            // 
            this.tabAlphabet.Controls.Add(this.btnUp);
            this.tabAlphabet.Controls.Add(this.btnDown);
            this.tabAlphabet.Controls.Add(this.tbName);
            this.tabAlphabet.Controls.Add(this.lblName);
            this.tabAlphabet.Controls.Add(this.lblAlphabets);
            this.tabAlphabet.Controls.Add(this.tbLetters);
            this.tabAlphabet.Controls.Add(this.lblLetters);
            this.tabAlphabet.Controls.Add(this.btnSaveAlphabets);
            this.tabAlphabet.Controls.Add(this.btnDelete);
            this.tabAlphabet.Controls.Add(this.btnAdd);
            this.tabAlphabet.Controls.Add(this.lvAlphabets);
            resources.ApplyResources(this.tabAlphabet, "tabAlphabet");
            this.tabAlphabet.Name = "tabAlphabet";
            this.tabAlphabet.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            resources.ApplyResources(this.btnUp, "btnUp");
            this.btnUp.Name = "btnUp";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.RaiseElement);
            // 
            // btnDown
            // 
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.LetDownElement);
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.tbName.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblAlphabets
            // 
            resources.ApplyResources(this.lblAlphabets, "lblAlphabets");
            this.lblAlphabets.Name = "lblAlphabets";
            // 
            // tbLetters
            // 
            this.tbLetters.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.tbLetters, "tbLetters");
            this.tbLetters.Name = "tbLetters";
            this.tbLetters.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // lblLetters
            // 
            resources.ApplyResources(this.lblLetters, "lblLetters");
            this.lblLetters.Name = "lblLetters";
            // 
            // btnSaveAlphabets
            // 
            resources.ApplyResources(this.btnSaveAlphabets, "btnSaveAlphabets");
            this.btnSaveAlphabets.Name = "btnSaveAlphabets";
            this.btnSaveAlphabets.UseVisualStyleBackColor = true;
            this.btnSaveAlphabets.Click += new System.EventHandler(this.SaveAlphabets);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteAlphabet);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddAlphabet);
            // 
            // lvAlphabets
            // 
            resources.ApplyResources(this.lvAlphabets, "lvAlphabets");
            this.lvAlphabets.GridLines = true;
            this.lvAlphabets.HideSelection = false;
            this.lvAlphabets.MultiSelect = false;
            this.lvAlphabets.Name = "lvAlphabets";
            this.lvAlphabets.UseCompatibleStateImageBehavior = false;
            this.lvAlphabets.View = System.Windows.Forms.View.List;
            this.lvAlphabets.SelectedIndexChanged += new System.EventHandler(this.AlphabetChanged);
            // 
            // tabLanguage
            // 
            this.tabLanguage.Controls.Add(this.lblLanguage);
            this.tabLanguage.Controls.Add(this.rbtnRussian);
            this.tabLanguage.Controls.Add(this.rbtnEnglish);
            this.tabLanguage.Controls.Add(this.btnSaveLanguage);
            resources.ApplyResources(this.tabLanguage, "tabLanguage");
            this.tabLanguage.Name = "tabLanguage";
            this.tabLanguage.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // rbtnRussian
            // 
            resources.ApplyResources(this.rbtnRussian, "rbtnRussian");
            this.rbtnRussian.Name = "rbtnRussian";
            this.rbtnRussian.TabStop = true;
            this.rbtnRussian.UseVisualStyleBackColor = true;
            // 
            // rbtnEnglish
            // 
            resources.ApplyResources(this.rbtnEnglish, "rbtnEnglish");
            this.rbtnEnglish.Name = "rbtnEnglish";
            this.rbtnEnglish.TabStop = true;
            this.rbtnEnglish.UseVisualStyleBackColor = true;
            // 
            // btnSaveLanguage
            // 
            this.btnSaveLanguage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSaveLanguage, "btnSaveLanguage");
            this.btnSaveLanguage.Name = "btnSaveLanguage";
            this.btnSaveLanguage.UseVisualStyleBackColor = true;
            this.btnSaveLanguage.Click += new System.EventHandler(this.SaveLanguage);
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.tabControl.ResumeLayout(false);
            this.tabAlphabet.ResumeLayout(false);
            this.tabAlphabet.PerformLayout();
            this.tabLanguage.ResumeLayout(false);
            this.tabLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabAlphabet;
        private System.Windows.Forms.TabPage tabLanguage;
        private System.Windows.Forms.Button btnSaveAlphabets;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvAlphabets;
        private System.Windows.Forms.TextBox tbLetters;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblAlphabets;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtnRussian;
        private System.Windows.Forms.RadioButton rbtnEnglish;
        private System.Windows.Forms.Button btnSaveLanguage;
        private System.Windows.Forms.Label lblLanguage;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}