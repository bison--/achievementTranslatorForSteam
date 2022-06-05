using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace achievementTranslatorForSteam
{
    public partial class uscLanguage : UserControl
    {
        public string keyName = "";
        public string keyDescription = "";

        public uscLanguage()
        {
            InitializeComponent();
        }

        public void addLanguage(string language)
        {
            cmbLanguage.Items.Add(language);
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (keyName == "" || keyDescription == "")
            {
                return;
            }


        }
    }
}
