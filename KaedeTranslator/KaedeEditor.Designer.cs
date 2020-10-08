namespace KaedeTranslator
{
    partial class KaedeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaedeEditor));
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetFallbackLocale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.localeSelectionBox = new System.Windows.Forms.ComboBox();
            this.btnAddLocale = new System.Windows.Forms.Button();
            this.stringList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUnload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateString = new System.Windows.Forms.Button();
            this.stringValueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stringNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fbLocaleTxt = new System.Windows.Forms.Label();
            this.btnDeleteString = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(9, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(185, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load translation file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetFallbackLocale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.localeSelectionBox);
            this.groupBox1.Controls.Add(this.btnAddLocale);
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Localization";
            // 
            // btnSetFallbackLocale
            // 
            this.btnSetFallbackLocale.Location = new System.Drawing.Point(9, 92);
            this.btnSetFallbackLocale.Name = "btnSetFallbackLocale";
            this.btnSetFallbackLocale.Size = new System.Drawing.Size(188, 23);
            this.btnSetFallbackLocale.TabIndex = 7;
            this.btnSetFallbackLocale.Text = "Set as fallback locale";
            this.btnSetFallbackLocale.UseVisualStyleBackColor = true;
            this.btnSetFallbackLocale.Click += new System.EventHandler(this.btnSetFallbackLocale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Locale:";
            // 
            // localeSelectionBox
            // 
            this.localeSelectionBox.FormattingEnabled = true;
            this.localeSelectionBox.Location = new System.Drawing.Point(9, 36);
            this.localeSelectionBox.Name = "localeSelectionBox";
            this.localeSelectionBox.Size = new System.Drawing.Size(188, 21);
            this.localeSelectionBox.TabIndex = 3;
            this.localeSelectionBox.SelectedValueChanged += new System.EventHandler(this.localeSelectionBox_SelectedValueChanged);
            // 
            // btnAddLocale
            // 
            this.btnAddLocale.Location = new System.Drawing.Point(9, 63);
            this.btnAddLocale.Name = "btnAddLocale";
            this.btnAddLocale.Size = new System.Drawing.Size(188, 23);
            this.btnAddLocale.TabIndex = 2;
            this.btnAddLocale.Text = "Add new locale";
            this.btnAddLocale.UseVisualStyleBackColor = true;
            this.btnAddLocale.Click += new System.EventHandler(this.btnAddLocale_Click);
            // 
            // stringList
            // 
            this.stringList.FormattingEnabled = true;
            this.stringList.Location = new System.Drawing.Point(6, 19);
            this.stringList.Name = "stringList";
            this.stringList.Size = new System.Drawing.Size(249, 433);
            this.stringList.TabIndex = 0;
            this.stringList.SelectedValueChanged += new System.EventHandler(this.stringList_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUnload);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Location = new System.Drawing.Point(493, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File management";
            // 
            // btnUnload
            // 
            this.btnUnload.Location = new System.Drawing.Point(9, 83);
            this.btnUnload.Name = "btnUnload";
            this.btnUnload.Size = new System.Drawing.Size(185, 23);
            this.btnUnload.TabIndex = 3;
            this.btnUnload.Text = "Unload...";
            this.btnUnload.UseVisualStyleBackColor = true;
            this.btnUnload.Click += new System.EventHandler(this.btnUnload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(9, 48);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(185, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "New translation file";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.stringList);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 467);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "String list";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteString);
            this.groupBox4.Controls.Add(this.btnUpdateString);
            this.groupBox4.Controls.Add(this.stringValueBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.stringNameBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(262, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 343);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Editor";
            // 
            // btnUpdateString
            // 
            this.btnUpdateString.Location = new System.Drawing.Point(10, 281);
            this.btnUpdateString.Name = "btnUpdateString";
            this.btnUpdateString.Size = new System.Drawing.Size(183, 23);
            this.btnUpdateString.TabIndex = 4;
            this.btnUpdateString.Text = "Update/Create";
            this.btnUpdateString.UseVisualStyleBackColor = true;
            this.btnUpdateString.Click += new System.EventHandler(this.btnUpdateString_Click);
            // 
            // stringValueBox
            // 
            this.stringValueBox.Location = new System.Drawing.Point(10, 86);
            this.stringValueBox.Multiline = true;
            this.stringValueBox.Name = "stringValueBox";
            this.stringValueBox.Size = new System.Drawing.Size(183, 187);
            this.stringValueBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Value:";
            // 
            // stringNameBox
            // 
            this.stringNameBox.Location = new System.Drawing.Point(10, 33);
            this.stringNameBox.Name = "stringNameBox";
            this.stringNameBox.Size = new System.Drawing.Size(183, 20);
            this.stringNameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "String Name:";
            // 
            // fbLocaleTxt
            // 
            this.fbLocaleTxt.AutoSize = true;
            this.fbLocaleTxt.Location = new System.Drawing.Point(499, 284);
            this.fbLocaleTxt.Name = "fbLocaleTxt";
            this.fbLocaleTxt.Size = new System.Drawing.Size(144, 13);
            this.fbLocaleTxt.TabIndex = 6;
            this.fbLocaleTxt.Text = "Fallback Locale: <unknown>";
            // 
            // btnDeleteString
            // 
            this.btnDeleteString.Location = new System.Drawing.Point(10, 311);
            this.btnDeleteString.Name = "btnDeleteString";
            this.btnDeleteString.Size = new System.Drawing.Size(183, 23);
            this.btnDeleteString.TabIndex = 5;
            this.btnDeleteString.Text = "Delete";
            this.btnDeleteString.UseVisualStyleBackColor = true;
            this.btnDeleteString.Click += new System.EventHandler(this.btnDeleteString_Click);
            // 
            // KaedeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 491);
            this.Controls.Add(this.fbLocaleTxt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KaedeEditor";
            this.Text = "Kaede Translation Software - for katakuna! internal use.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KaedeEditor_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox localeSelectionBox;
        private System.Windows.Forms.Button btnAddLocale;
        private System.Windows.Forms.ListBox stringList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateString;
        private System.Windows.Forms.TextBox stringValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stringNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetFallbackLocale;
        private System.Windows.Forms.Label fbLocaleTxt;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Button btnDeleteString;
    }
}

