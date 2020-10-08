using KaedeCore;
using KaedeCore.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaedeTranslator
{
    public partial class KaedeEditor : Form
    {
        private Kaede k;
        private int currentIndex = 0;

        public KaedeEditor()
        {
            InitializeComponent();
            updateButtonStates();
        }

        private void updateButtonStates()
        {
            bool state = k == null;

            localeSelectionBox.Enabled = !state;
            btnAddLocale.Enabled = !state;
            btnSetFallbackLocale.Enabled = k != null && localeSelectionBox.SelectedIndex >= 0 &&
                (k.Locales.Count >= 0 &&
                k.Locales[localeSelectionBox.SelectedIndex] != null &&
                k.FallbackLocale == null ? true : k.Locales[localeSelectionBox.SelectedIndex].Id != k.FallbackLocale.Id);

            btnLoad.Enabled = state;
            btnCreate.Enabled = state;

            btnUnload.Enabled = !state;
            btnSave.Enabled = !state;

            stringNameBox.Enabled = !state;
            stringValueBox.Enabled = !state;
            btnUpdateString.Enabled = !state;
            btnDeleteString.Enabled = !state;

            if (stringList.Items.Count > 0 && state)
            {
                stringList.Items.Clear();
            }

            fbLocaleTxt.Text = string.Format("Fallback Locale: {0}", k == null ? "<unknown>" : (k.FallbackLocale == null ? "<unknown>" : string.Format("{0} ({1})", k.FallbackLocale.Code, k.FallbackLocale.LocalisedName)));
        }

        private void refreshBoxStates()
        {
            if (k.Locales.Count > 0)
            {
                stringList.Items.Clear();
                localeSelectionBox.Items.Clear();

                foreach (Locale l in k.Locales)
                {
                    localeSelectionBox.Items.Add(string.Format("{0} ({1})", l.LocalisedName, l.Code));
                }

                foreach (LocaleString l in k.Locales[0].Strings)
                {
                    stringList.Items.Add(l.Name);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Title = "Open a Kaede Translation file...";
            of.Filter = "Kaede Translation File (*.ktf)|*.ktf";

            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stringList.Items.Clear();
                    localeSelectionBox.Items.Clear();
                    localeSelectionBox.Text = "";

                    k = Kaede.FromFile(of.FileName);
                 
                    refreshBoxStates();
                    updateButtonStates();
                    localeSelectionBox.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An internal error has occured while opening your translation file.\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();

            of.Title = "Create a new Kaede Translation file...";
            of.Filter = "Kaede Translation File (*.ktf)|*.ktf";

            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    stringList.Items.Clear();
                    localeSelectionBox.Items.Clear();
                    localeSelectionBox.Text = "";

                    k = new Kaede()
                    {
                        TranslationFilePath = of.FileName
                    };
                    updateButtonStates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("An internal error has occured while opening your translation file.\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUnload_Click(object sender, EventArgs e)
        {
            if(k != null)
            {
                if(MessageBox.Show("Do you want to save your translation file before unloading?", "Unloading process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    k.SaveTranslationFile();
                }
            }
            k = null;

            stringList.Items.Clear();
            localeSelectionBox.Items.Clear();
            localeSelectionBox.Text = "";

            updateButtonStates();
        }

        private void KaedeEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (k != null)
            {
                if (MessageBox.Show("Do you want to save your translation file before closing?", "Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    k.SaveTranslationFile();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            k.SaveTranslationFile();
        }

        private void loadStringsForLocale()
        {
            Locale l = k.Locales[localeSelectionBox.SelectedIndex];

            stringList.Items.Clear();

            foreach(LocaleString s in l.Strings)
            {
                stringList.Items.Add(s.Name);
            }
        }

        private void localeSelectionBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(currentIndex != localeSelectionBox.SelectedIndex)
            {
                currentIndex = localeSelectionBox.SelectedIndex;
            }

            int c = stringList.SelectedIndex;
            string n = stringNameBox.Text;

            stringNameBox.Text = "";
            stringValueBox.Text = "";

            loadStringsForLocale();
            updateButtonStates();

            if (c >= 0)
            {
                stringNameBox.Text = n;
                stringValueBox.Text = k.GetString(k.Locales[localeSelectionBox.SelectedIndex].Code, stringNameBox.Text);
                int idx = k.GetStringIndex(k.Locales[localeSelectionBox.SelectedIndex].Code, stringNameBox.Text);
                if(idx >= 0)
                {
                    stringList.SelectedIndex = idx;
                }
            }
        }

        private void btnAddLocale_Click(object sender, EventArgs e)
        {
            AddLocaleForm localeForm = new AddLocaleForm();

            if (localeForm.ShowDialog(this) == DialogResult.OK)
            {
                if (k.FindLocale(localeForm.selectedCultureInfo.Name) != null)
                {
                    MessageBox.Show("This locale has been added already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Locale l = new Locale();

                    l.Code = localeForm.selectedCultureInfo.Name;
                    l.LocalisedName = localeForm.selectedCultureInfo.EnglishName;
                    l.Id = new Random().Next(1000);
                    l.Strings = new List<LocaleString>();

                    if (k.Locales.Count > 0)
                    {
                        foreach (LocaleString _ls in k.Locales[0].Strings)
                        {
                            l.Strings.Add(new LocaleString()
                            {
                                Name = _ls.Name,
                                Value = ""
                            });
                        }
                    }

                    localeSelectionBox.Items.Add(string.Format("{0} ({1})", l.LocalisedName, l.Code));
                    k.Locales.Add(l);

                    if (localeSelectionBox.Items.Count == 1)
                    {
                        localeSelectionBox.SelectedIndex = 0;
                    }
                    else
                    {
                        localeSelectionBox.SelectedIndex = localeSelectionBox.Items.Count - 1;
                    }
                }
            }

            localeForm.Dispose();
        }

        private void btnSetFallbackLocale_Click(object sender, EventArgs e)
        {
            k.FallbackLocale = k.Locales[localeSelectionBox.SelectedIndex];
            updateButtonStates();
        }

        private void stringList_SelectedValueChanged(object sender, EventArgs e)
        {
            if(stringList.SelectedIndex < 0)
            {
                stringNameBox.Text = "";
                stringValueBox.Text = "";
                return;
            }

            stringNameBox.Text = k.Locales[localeSelectionBox.SelectedIndex].Strings[stringList.SelectedIndex].Name;
            stringValueBox.Text = k.GetString(k.Locales[localeSelectionBox.SelectedIndex].Code, k.Locales[localeSelectionBox.SelectedIndex].Strings[stringList.SelectedIndex].Name);
        }

        private void btnUpdateString_Click(object sender, EventArgs e)
        {
            if(stringNameBox.Text == "" || stringNameBox.Text.Length <= 0)
            {
                MessageBox.Show("Invalid String Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Locale l = k.FindLocale(k.Locales[localeSelectionBox.SelectedIndex].Code);

            if (l != null)
            {
                bool foundStr = false;

                foreach (LocaleString s in l.Strings)
                {
                    if (string.Compare(s.Name, stringNameBox.Text) == 0)
                    {
                        foundStr = true;
                        s.Value = stringValueBox.Text;
                        break;
                    }
                }

                if(!foundStr)
                {
                    l.Strings.Add(new LocaleString() {
                        Name = stringNameBox.Text,
                        Value = stringValueBox.Text
                    });

                    foreach(Locale _lk in k.Locales)
                    {
                        bool _h = false;

                        foreach(LocaleString _s in _lk.Strings)
                        {
                            if(string.Compare(_s.Name, stringNameBox.Text) == 0)
                            {
                                _h = true;
                                break;
                            }
                        }

                        if(!_h)
                        {
                            _lk.Strings.Add(new LocaleString()
                            {
                                Name = stringNameBox.Text,
                                Value = ""
                            });
                        }
                    }

                    MessageBox.Show("Created a new string successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadStringsForLocale();
                } else
                {
                    MessageBox.Show("Updated the string!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteString_Click(object sender, EventArgs e)
        {
            if (stringList.SelectedIndex < 0) return;
            if (k.GetString(k.Locales[localeSelectionBox.SelectedIndex].Code, stringNameBox.Text) == null) return;

            if (MessageBox.Show("Are you sure you want to delete this entry?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach(Locale s in k.Locales)
                {
                    s.Strings.RemoveAll(x => x.Name == stringNameBox.Text);
                }

                loadStringsForLocale();

                if(k.Locales[localeSelectionBox.SelectedIndex].Strings.Count <= 0)
                {
                    stringNameBox.Text = "";
                    stringValueBox.Text = "";
                }
            }
        }
    }
}
