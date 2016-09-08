using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp
{
    internal enum eNameGenerator
    {
        Werewolf,
        Japanese,
        Superhero,
        HeavyMetalBand
    }

    internal static class NameGeneratorFactory
    {
        internal static INameGenerator CreateNameGenerator(string i_FirstName, string i_LastName, Func<string, string, string> i_NameGenerationMethod)
        {
            return new NameGeneratorByFullName(i_FirstName, i_LastName, i_NameGenerationMethod);
        }
    }
}
