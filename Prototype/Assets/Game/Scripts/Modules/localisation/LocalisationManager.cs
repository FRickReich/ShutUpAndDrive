using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNWPrototype
{
    public class LocalisationManager : MonoBehaviour
    {
       
        public TextAsset englishLanguageFile;
        public TextAsset germanLanguageFile;

        public Localisation locale;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public void ChangeGameLanguage(string language)
        {
            SetGameLanguage(language);
        }

        public void SetGameLanguage(string language)
        {
            switch (language)
            {
                default:
                case "ENGLISH":
                    locale = Localisation.Locale(englishLanguageFile.ToString());
                    break;
                case "GERMAN":
                    locale = Localisation.Locale(germanLanguageFile.ToString());
                    break;
            }
        }
    }
}