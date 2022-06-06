using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace achievementTranslatorForSteam
{
    public partial class uscLanguage : UserControl
    {
        public TextBox getTxtName { get { return txtName; } }
        public TextBox getTxtDescription { get { return txtDescription; } }

        public clsTranslationKeys translationKeys;
        private string selectedLanguage = "";

        public uscLanguage()
        {
            InitializeComponent();
        }

        public void selectLanguageFirst()
        {
            cmbLanguage.SelectedIndex = 0;
        }

        public string getCurrentLanguage()
        {
            return selectedLanguage;
        }

        public void selectLanguageLast()
        {
            cmbLanguage.SelectedIndex = cmbLanguage.Items.Count - 1;
        }

        public void addLanguage(string language)
        {
            cmbLanguage.Items.Add(language);
        }

        public void addLanguages(List<string> languages)
        {
            cmbLanguage.Items.AddRange(languages.ToArray());
        }

        public void setTranslationKeys(clsTranslationKeys _translationKeys)
        {
            translationKeys = _translationKeys;
        }


        public void saveData()
        {
            ((JValue)clsTranslationManager.Instance.json["lang"][getCurrentLanguage()]["Tokens"][translationKeys.keyName]).Value = txtName.Text;
            ((JValue)clsTranslationManager.Instance.json["lang"][getCurrentLanguage()]["Tokens"][translationKeys.keyDescription]).Value = txtDescription.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Console.WriteLine("cmbLanguage_SelectionChangeCommitted");
            
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("cmbLanguage_SelectedIndexChanged");
            if (!translationKeys.isComplete())
            {
                return;
            }

            if (getCurrentLanguage() == "")
            {
                // nothing to save
                selectedLanguage = (string)cmbLanguage.SelectedItem;
            }
            else
            {
                // save old data before changing
                saveData();
                selectedLanguage = (string)cmbLanguage.SelectedItem;
            }

            // TODO: load data!
            //clsTranslationManager.Instance.json.Value["Tokens"][kvp2.Key]
            //kvp.Value["Tokens"][kvp2.Key]
            //clsTranslationManager.Instance.json["lang"]["english"]["Tokens"]["NEW_ACHIEVEMENT_1_0_NAME"]
            
            txtName.Text = (string)((JValue)clsTranslationManager.Instance.json["lang"][getCurrentLanguage()]["Tokens"][translationKeys.keyName]).Value;
            txtDescription.Text = (string)((JValue)clsTranslationManager.Instance.json["lang"][getCurrentLanguage()]["Tokens"][translationKeys.keyDescription]).Value;
        }
    }
}
