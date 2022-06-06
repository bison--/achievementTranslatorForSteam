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
    public partial class uscTranslation : UserControl
    {
        public clsTranslationKeys translationKeys;

        public uscTranslation()
        {
            InitializeComponent();
        }

        private void uscTranslation_Load(object sender, EventArgs e)
        {

        }

        public void setTranslationKeys(clsTranslationKeys _translationKeys)
        {
            translationKeys = _translationKeys;
            uscLangLeft.setTranslationKeys(_translationKeys);
            uscLangRight.setTranslationKeys(_translationKeys);

            lblKey.Text = translationKeys.getCombinedKeyName();
        }

        public void addLanguage(string language)
        {
            uscLangLeft.addLanguage(language);
            uscLangRight.addLanguage(language);
        }

        public void addLanguages(List<string> languages)
        {
            uscLangLeft.addLanguages(languages);
            uscLangLeft.selectLanguageFirst();

            uscLangRight.addLanguages(languages);
            uscLangRight.selectLanguageLast();
        }

        public void saveData()
        {
            uscLangLeft.saveData();
            uscLangRight.saveData();
        }

        private void btnNameToRight_Click(object sender, EventArgs e)
        {
            uscLangRight.getTxtName.Text = uscLangLeft.getTxtName.Text;
        }

        private void btnDescriptionToRight_Click(object sender, EventArgs e)
        {
            uscLangRight.getTxtDescription.Text = uscLangLeft.getTxtDescription.Text;
        }

        private void btnNameToLeft_Click(object sender, EventArgs e)
        {
            uscLangLeft.getTxtName.Text = uscLangRight.getTxtName.Text;
        }

        private void btnDescriptionToLeft_Click(object sender, EventArgs e)
        {
            uscLangLeft.getTxtDescription.Text = uscLangRight.getTxtDescription.Text;
        }
    }
}
