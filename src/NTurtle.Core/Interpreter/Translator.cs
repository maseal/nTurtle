using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NTurtle.Core.Interpreter
{
    public partial class Translator
    {
        protected Translator()
        {
        }

        /// <summary>
        /// Converts a unicode string to a token type. Uses the dictionary to do so.
        /// If the string could not translated to a Token type, TokenType.Unknown is returned.
        /// </summary>
        /// <param name="look">the unicode string a bit of Turtle code</param>
        /// <returns>the token type, TokenType.Unknown if not recognised</returns>
        public TokenType LookToType(string look)
        {
            return lookToTypeMap.ContainsKey(look) ? lookToTypeMap[look] : TokenType.Unknown;
        }

        /// <summary>
        /// Converts a unicode character to a token type. Uses the dictionary to do so.
        /// If the string could not translated to a Token type, TokenType.Unknown is returned.
        /// </summary>
        /// <param name="look">the unicode string a bit of Turtle code</param>
        /// <returns>the token type, TokenType.Unknown if not recognised</returns>
        public TokenType LookToType(char look)
        {
            string lookStr = look.ToString();
            return lookToTypeMap.ContainsKey(lookStr) ? lookToTypeMap[lookStr] : TokenType.Unknown;
        }

        public Dictionary<TokenType, List<string>> TokenToStringsMap()
        {
            var resultMap = new Dictionary<TokenType, List<string>>();
            foreach (var tokenType in lookToTypeMap)
            {
                if (!resultMap.ContainsKey(tokenType.Value))
                    resultMap.Add(tokenType.Value, new List<string>());
                resultMap[tokenType.Value].Add(tokenType.Key);
            }

            return resultMap;
        }
        
        public string DefaultToLocalized(string defaultLook) { return defaultToLocalizedMap[defaultLook]; }
        
        /// returns all default looks that have a localized look
        public List<string> AllDefaultLooks()
        {
            return defaultToLocalizedMap.Keys.ToList();
        }

        public List<string> AllLocalizedLooks()
        {
            return defaultToLocalizedMap.Values.ToList();
        }

        public string DefaultLook(string localizedEntry)
        {
            return defaultToLocalizedMap
                .Where(def => def.Value == localizedEntry)
                .Select(def => def.Key)
                .FirstOrDefault();
        }

        public List<string> ExampleNames()
        {
            return examples.Keys.ToList();
        }

        public string Example(string name)
        {
            return examples[name];
        }

        public string LocalizeScript(string untranslatedScript)
        {
            // TODO: test it
            //const string localizedCommandPattern = "@\\(.*?\\)";
            return defaultToLocalizedMap.Aggregate(
                untranslatedScript,
                (current, item) => 
                    Regex.Replace(current, $"@\\({item.Key}\\)", item.Value, RegexOptions.IgnoreCase));
        }

        /// <summary>
        /// Sets the dictionary language.
        /// By setting the dictionary KTurtle will use a different translation of TurtleScript.
        /// Examples are managed by the Translator aswell. Easy.
        /// </summary>
        /// <param name="langCode">the ISO language code of the dictionary (eg: "en_US", "fr", "pt_BR", "nl")</param>
        /// <returns>TRUE is the loading was successful, otherwise FALSE</returns>
        public bool SetLanguage(string langCode)
        {
            localizer = new List<string> {langCode, DefaultLanguageCode};
            SetDictionary();
            SetExamples();
            return true;
        }

        public const string DefaultLanguageCode = "en_US";
        private List<string> localizer;
        
        private IDictionary<string, TokenType> lookToTypeMap;
        private IDictionary<string, string> defaultToLocalizedMap;
        private IDictionary<string, string> examples;
        
        public static Translator Instance = new Translator();
    }
}