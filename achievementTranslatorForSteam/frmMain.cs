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

            foreach (var kvp in _translationManager.json["lang"].Cast<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().ToList())
            {
                Console.WriteLine(kvp.Key);

                foreach (var kvp2 in kvp.Value["Tokens"].Cast<KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>().ToList())
                {
                    Console.WriteLine(kvp2.Key + ": " + kvp2.Value.ToString());

                    kvp.Value["Tokens"][kvp2.Key] = "aaaaaaaaaaa";
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _translationManager.saveFile();
        }
    }
}
