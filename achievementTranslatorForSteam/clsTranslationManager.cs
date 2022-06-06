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

        public void loadFile(string fileName)
        {
            volvo = VdfConvert.Deserialize(File.ReadAllText(fileName));
            json = JObject.Parse("{" + volvo.ToJson().ToString() + "}");

            Console.WriteLine(volvo.ToString());
        }

        public void saveFile(string fileName)
        {
            string vdfString = VdfConvert.Serialize(json.ToVdf()).Trim();
            // for whatever reason, the serialised version has { } at start and end and this has to go
            char[] charsToTrim = { '{', '}' };
            vdfString = vdfString.Trim(charsToTrim);

            File.WriteAllText(fileName, vdfString);
        }


    }
}
