namespace KaedeTranslator
{
    partial class AddLocaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLocaleForm));
            this.btnAddLocale = new System.Windows.Forms.Button();
            this.localeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddLocale
            // 
            this.btnAddLocale.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddLocale.Location = new System.Drawing.Point(12, 63);
            this.btnAddLocale.Name = "btnAddLocale";
            this.btnAddLocale.Size = new System.Drawing.Size(304, 23);
            this.btnAddLocale.TabIndex = 0;
            this.btnAddLocale.Text = "Add";
            this.btnAddLocale.UseVisualStyleBackColor = true;
            // 
            // localeBox
            // 
            this.localeBox.FormattingEnabled = true;
            this.localeBox.Location = new System.Drawing.Point(12, 29);
            this.localeBox.Name = "localeBox";
            this.localeBox.Size = new System.Drawing.Size(304, 21);
            this.localeBox.TabIndex = 1;
            this.localeBox.SelectedValueChanged += new System.EventHandler(this.localeBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select locale to add:";
            // 
            // AddLocaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 98);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localeBox);
            this.Controls.Add(this.btnAddLocale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLocaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add locale...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLocale;
        private System.Windows.Forms.ComboBox localeBox;
        private System.Windows.Forms.Label label1;
    }
}