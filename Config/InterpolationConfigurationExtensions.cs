using Microsoft.Extensions.Configuration;

namespace ApplicationSecretsExample.Config
{
    public static class InterpolationConfigurationExtensions
    {
        public static IConfigurationBuilder AddInterpolation(this IConfigurationBuilder builder, IConfigurationRoot config)
        {
            builder.Add(new InterpolationConfigurationSource(config));
            return builder;
        }
        public static IConfigurationBuilder AddInterpolation(this IConfigurationBuilder builder, IConfigurationBuilder config)
        {
            return AddInterpolation(builder, config.Build());
        }
    }
}