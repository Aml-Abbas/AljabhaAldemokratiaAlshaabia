using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AljabhaAldemokratiaAlshaabia.Client.Shared
{
    public static class LocalizerSettings
    {
        public const string NeutralCulture = "en-US";

        public static readonly string[] SupportedCultures = { NeutralCulture, "ar-AR"};

        public static readonly (string, string)[] SupportedCulturesWithName = new[] { ("English", NeutralCulture), ("Arabic", "ar-AR")};
    }
}
