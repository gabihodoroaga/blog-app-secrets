using System;

namespace ApplicationSecretsExample.Config
{
    public class SwarmSecretsPath
    {
        public SwarmSecretsPath()
        {
        }
        public SwarmSecretsPath(
            string path,
            string keyDelimiter = ":",
            bool optional = false,
            Func<string, string> keySelector = null)
        {
            Path = path;
            KeyDelimiter = keyDelimiter;
            Optional = optional;
            KeySelector = keySelector;
        }
        public string Path { get; set; }
        public string KeyDelimiter { get; set; }
        public bool Optional { get; set; }
        public Func<string, string> KeySelector { get; set; }

    }
}
