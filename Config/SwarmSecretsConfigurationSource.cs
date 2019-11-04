using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ApplicationSecretsExample.Config
{
    public class SwarmSecretsConfigurationSource : IConfigurationSource
    {
        public IEnumerable<SwarmSecretsPath> SwarmSecretsPaths { get; private set; }

        public SwarmSecretsConfigurationSource()
        {
            SwarmSecretsPaths = new List<SwarmSecretsPath>() 
            {
                new SwarmSecretsPath() 
                { 
                    Path = "/run/secrets",
                    KeyDelimiter = ":",
                    Optional = false
                }
            };
        }
        public SwarmSecretsConfigurationSource(IEnumerable<SwarmSecretsPath> swarmSecretsPaths)
        {
            SwarmSecretsPaths = swarmSecretsPaths;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new SwarmSecretsConfigurationProvider(SwarmSecretsPaths);
        }

    }
}