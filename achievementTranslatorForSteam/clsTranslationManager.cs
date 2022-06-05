using Gameloop.Vdf;
using Gameloop.Vdf.JsonConverter;
using Gameloop.Vdf.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achievementTranslatorForSteam
{
    public class clsTranslationManager
    {
        public static clsTranslationManager Instance;
        public VProperty volvo;
        public JObject json;

        public clsTranslationManager()
        {
            Instance = this;
        }

        /*public VProperty getLanguageAndKey(string language, string key)
        {
            //return volvo.Value[language][key].Value(key);
            return new VProperty(key, );
        }*/

        public void setLanguageAndKey(string language, string key, string value)
        {
            //volvo.Value[language][key].Value = value;
        }

        public void loadFile(string fileName)
        {
            volvo = VdfConvert.Deserialize(File.ReadAllText(fileName));
            json = JObject.Parse("{" + volvo.ToJson().ToString() + "}");

            Console.WriteLine(volvo.ToString());
        }

        public void saveFile(string fileName = "")
        {
            File.WriteAllText(@"K:\gamedev\unity3d\NachkriegsrattenPunkRockPuzzle\other\achievement_translations\dummy.vdf", VdfConvert.Serialize(json.ToVdf()));
        }
    }
}
