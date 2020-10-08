using KaedeCore.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaedeTranslator
{
    public partial class AddLocaleForm : Form
    {
        public CultureInfo selectedCultureInfo;

        public AddLocaleForm()
        {
            InitializeComponent();

            localeBox.Items.Clear();

            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
            {
                if (info.Name.Length <= 0) continue;
                localeBox.Items.Add(string.Format("{0} ({1})", info.EnglishName, info.Name));
            }

            localeBox.SelectedIndex = 0;
            selectedCultureInfo = CultureInfo.GetCultures(CultureTypes.NeutralCultures)[1];
        }

        private void localeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedCultureInfo = CultureInfo.GetCultures(CultureTypes.NeutralCultures)[1 + localeBox.SelectedIndex];
        }
    }
}
