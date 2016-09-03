using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
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
        internal static INameGenerator CreateNameGenerator(eNameGenerator i_Context)
        {
            INameGenerator nameGenerator = null;

            switch (i_Context)
            {
                case eNameGenerator.Werewolf:
                    nameGenerator = new WerewolfNameGenerator();
                    break;
                case eNameGenerator.Japanese:
                    nameGenerator = new JapaneseNameGenerator();
                    break;
                case eNameGenerator.Superhero:
                    nameGenerator = new SuperheroNameGenerator();
                    break;
                case eNameGenerator.HeavyMetalBand:
                    nameGenerator = new HeavyMetalBandNameGenerator();
                    break;
            }

            return nameGenerator;
        }
    }
}
