using Gameloop.Vdf.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace achievementTranslatorForSteam
{
    public partial class frmMain : Form
    {
        private clsTranslationManager _translationManager = new clsTranslationManager();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            ofdLoadFile.ShowDialog();
        }

        private void ofdLoadFile_FileOk(object sender, CancelEventArgs e)
        {
            txtSourceFile.Text = ofdLoadFile.FileName;
            _translationManager.loadFile(txtSourceFile.Text);
            generateUi();
        }

        private void generateUi()
        {
            flpTranslate.SuspendLayout();

            List<string> languages = new List<string>();
            foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> kvp in _translationManager.json["lang"].Cast<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().ToList())
            {
                languages.Add(kvp.Key);
            }

            HashSet<string> createdKeyNames = new HashSet<string>();

            foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> kvp in _translationManager.json["lang"].Cast<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().ToList())
            {
                //Console.WriteLine(kvp.Key);
                string currentLangauge = kvp.Key;

                clsTranslationKeys keyToAdd = new clsTranslationKeys();

                foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> kvp2 in kvp.Value["Tokens"].Cast<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().ToList())
                {
                    //Console.WriteLine(kvp2.Key + ": " + kvp2.Value.ToString());

                    keyToAdd.addKey(kvp2.Key);

                    if (keyToAdd.isComplete())
                    {
                        if (!createdKeyNames.Contains(keyToAdd.getCombinedKeyName()))
                        {
                            uscTranslation translation = new uscTranslation();
                            translation.setTranslationKeys(keyToAdd);
                            translation.addLanguages(languages);

                            flpTranslate.Controls.Add(translation);

                            createdKeyNames.Add(keyToAdd.getCombinedKeyName());
                        }

                        keyToAdd = new clsTranslationKeys();
                    }

                    //kvp.Value["Tokens"][kvp2.Key] = "aaaaaaaaaaa";
                    //kvp2 = "aaaa";
                }
                //kvp.Key
                //kvp.Value
            }

            foreach (var language in _translationManager.json)
            {
                /*
                foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> property in language)
                {
                    Console.WriteLine(property.Key + " - " + property.Value);
                }
                */
                //Console.WriteLine(language.Value);
                /*
                foreach (var entry in language.Value["Tokens"])
                {
                    Console.WriteLine(":" + entry.ToString());
                } */
            }


            lblLoadedAmount.Text = flpTranslate.Controls.Count.ToString();
            flpTranslate.ResumeLayout();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdSaveTranslation.FileName == "")
            {
                sfdSaveTranslation.FileName = ofdLoadFile.FileName;
            }

            sfdSaveTranslation.ShowDialog();
        }

        private void sfdSaveTranslation_FileOk(object sender, CancelEventArgs e)
        {
            foreach (uscTranslation translationControl in flpTranslate.Controls)
            {
                translationControl.saveData();
            }

            _translationManager.saveFile(sfdSaveTranslation.FileName);
        }

        private void flpTranslate_SizeChanged(object sender, EventArgs e)
        {
            flpTranslate.SuspendLayout();
            foreach (Control ctrl in flpTranslate.Controls)
            {
                ctrl.Width = flpTranslate.ClientSize.Width - 10;
            }
            flpTranslate.ResumeLayout();
        }
    }
}
