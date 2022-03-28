namespace Cryptograph
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabIntroduction = new System.Windows.Forms.TabPage();
            this.linkVigenere = new System.Windows.Forms.LinkLabel();
            this.linkCaesar = new System.Windows.Forms.LinkLabel();
            this.lblOptionsDescription = new System.Windows.Forms.Label();
            this.lblEncryptOptions = new System.Windows.Forms.Label();
            this.lblIntroductionText = new System.Windows.Forms.Label();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.tabCaesar = new System.Windows.Forms.TabPage();
            this.lblCaesarExample = new System.Windows.Forms.Label();
            this.lblCaesar = new System.Windows.Forms.Label();
            this.lblCaesarDescription = new System.Windows.Forms.Label();
            this.pbCaesar = new System.Windows.Forms.PictureBox();
            this.tabVigenere = new System.Windows.Forms.TabPage();
            this.pbVigenere = new System.Windows.Forms.PictureBox();
            this.lblVigenere = new System.Windows.Forms.Label();
            this.lblVigenereDescription = new System.Windows.Forms.Label();
            this.pbBanner = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabIntroduction.SuspendLayout();
            this.tabCaesar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaesar)).BeginInit();
            this.tabVigenere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVigenere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabIntroduction);
            this.tabControl.Controls.Add(this.tabCaesar);
            this.tabControl.Controls.Add(this.tabVigenere);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabIntroduction
            // 
            this.tabIntroduction.Controls.Add(this.linkVigenere);
            this.tabIntroduction.Controls.Add(this.linkCaesar);
            this.tabIntroduction.Controls.Add(this.lblOptionsDescription);
            this.tabIntroduction.Controls.Add(this.lblEncryptOptions);
            this.tabIntroduction.Controls.Add(this.lblIntroductionText);
            this.tabIntroduction.Controls.Add(this.lblIntroduction);
            resources.ApplyResources(this.tabIntroduction, "tabIntroduction");
            this.tabIntroduction.Name = "tabIntroduction";
            this.tabIntroduction.UseVisualStyleBackColor = true;
            // 
            // linkVigenere
            // 
            resources.ApplyResources(this.linkVigenere, "linkVigenere");
            this.linkVigenere.Name = "linkVigenere";
            this.linkVigenere.TabStop = true;
            this.linkVigenere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVigenere_LinkClicked);
            // 
            // linkCaesar
            // 
            resources.ApplyResources(this.linkCaesar, "linkCaesar");
            this.linkCaesar.Name = "linkCaesar";
            this.linkCaesar.TabStop = true;
            this.linkCaesar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCaesar_LinkClicked);
            // 
            // lblOptionsDescription
            // 
            resources.ApplyResources(this.lblOptionsDescription, "lblOptionsDescription");
            this.lblOptionsDescription.Name = "lblOptionsDescription";
            // 
            // lblEncryptOptions
            // 
            resources.ApplyResources(this.lblEncryptOptions, "lblEncryptOptions");
            this.lblEncryptOptions.Name = "lblEncryptOptions";
            // 
            // lblIntroductionText
            // 
            resources.ApplyResources(this.lblIntroductionText, "lblIntroductionText");
            this.lblIntroductionText.Name = "lblIntroductionText";
            // 
            // lblIntroduction
            // 
            resources.ApplyResources(this.lblIntroduction, "lblIntroduction");
            this.lblIntroduction.Name = "lblIntroduction";
            // 
            // tabCaesar
            // 
            this.tabCaesar.Controls.Add(this.lblCaesarExample);
            this.tabCaesar.Controls.Add(this.lblCaesar);
            this.tabCaesar.Controls.Add(this.lblCaesarDescription);
            this.tabCaesar.Controls.Add(this.pbCaesar);
            resources.ApplyResources(this.tabCaesar, "tabCaesar");
            this.tabCaesar.Name = "tabCaesar";
            this.tabCaesar.UseVisualStyleBackColor = true;
            // 
            // lblCaesarExample
            // 
            resources.ApplyResources(this.lblCaesarExample, "lblCaesarExample");
            this.lblCaesarExample.Name = "lblCaesarExample";
            // 
            // lblCaesar
            // 
            resources.ApplyResources(this.lblCaesar, "lblCaesar");
            this.lblCaesar.Name = "lblCaesar";
            // 
            // lblCaesarDescription
            // 
            resources.ApplyResources(this.lblCaesarDescription, "lblCaesarDescription");
            this.lblCaesarDescription.Name = "lblCaesarDescription";
            // 
            // pbCaesar
            // 
            resources.ApplyResources(this.pbCaesar, "pbCaesar");
            this.pbCaesar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaesar.Image = global::Cryptograph.Properties.Resources.Caesar;
            this.pbCaesar.Name = "pbCaesar";
            this.pbCaesar.TabStop = false;
            // 
            // tabVigenere
            // 
            this.tabVigenere.Controls.Add(this.pbVigenere);
            this.tabVigenere.Controls.Add(this.lblVigenere);
            this.tabVigenere.Controls.Add(this.lblVigenereDescription);
            resources.ApplyResources(this.tabVigenere, "tabVigenere");
            this.tabVigenere.Name = "tabVigenere";
            this.tabVigenere.UseVisualStyleBackColor = true;
            // 
            // pbVigenere
            // 
            resources.ApplyResources(this.pbVigenere, "pbVigenere");
            this.pbVigenere.Image = global::Cryptograph.Properties.Resources.Vigenere;
            this.pbVigenere.Name = "pbVigenere";
            this.pbVigenere.TabStop = false;
            // 
            // lblVigenere
            // 
            resources.ApplyResources(this.lblVigenere, "lblVigenere");
            this.lblVigenere.Name = "lblVigenere";
            // 
            // lblVigenereDescription
            // 
            resources.ApplyResources(this.lblVigenereDescription, "lblVigenereDescription");
            this.lblVigenereDescription.Name = "lblVigenereDescription";
            // 
            // pbBanner
            // 
            resources.ApplyResources(this.pbBanner, "pbBanner");
            this.pbBanner.Image = global::Cryptograph.Properties.Resources.Banner;
            this.pbBanner.Name = "pbBanner";
            this.pbBanner.TabStop = false;
            // 
            // FormHelp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbBanner);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.ShowIcon = false;
            this.tabControl.ResumeLayout(false);
            this.tabIntroduction.ResumeLayout(false);
            this.tabIntroduction.PerformLayout();
            this.tabCaesar.ResumeLayout(false);
            this.tabCaesar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaesar)).EndInit();
            this.tabVigenere.ResumeLayout(false);
            this.tabVigenere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVigenere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabIntroduction;
        private System.Windows.Forms.TabPage tabCaesar;
        private System.Windows.Forms.Label lblIntroductionText;
        private System.Windows.Forms.Label lblIntroduction;
        private System.Windows.Forms.PictureBox pbBanner;
        private System.Windows.Forms.PictureBox pbCaesar;
        private System.Windows.Forms.Label lblCaesar;
        private System.Windows.Forms.Label lblCaesarDescription;
        private System.Windows.Forms.Label lblCaesarExample;
        private System.Windows.Forms.TabPage tabVigenere;
        private System.Windows.Forms.Label lblVigenere;
        private System.Windows.Forms.Label lblVigenereDescription;
        private System.Windows.Forms.PictureBox pbVigenere;
        private System.Windows.Forms.Label lblOptionsDescription;
        private System.Windows.Forms.Label lblEncryptOptions;
        private System.Windows.Forms.LinkLabel linkVigenere;
        private System.Windows.Forms.LinkLabel linkCaesar;
    }
}