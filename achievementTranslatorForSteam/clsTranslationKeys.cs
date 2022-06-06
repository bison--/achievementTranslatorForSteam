using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achievementTranslatorForSteam
{
    public class clsTranslationKeys
    {
        // NEW_ACHIEVEMENT_1_0_NAME
        public string keyName = "";
        // NEW_ACHIEVEMENT_1_0_DESC
        public string keyDescription = "";

        public string getCombinedKeyName()
        {
            return keyName.Substring(0, keyName.Length - 5);
        }

        public bool isComplete()
        {
            return keyName != "" && keyDescription != "";
        }

        public void addKey(string key)
        {
            // auto add because we spare us the count 2 on the other side
            if (keyName == "")
            {
                keyName = key;
            }
            else if (keyDescription == "")
            {
                keyDescription = key;
            }
        }
    }
}
