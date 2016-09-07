using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal class HeavyMetalBandNameGenerator : INameGenerator
    {
        public string GenerateName(string i_FirstName, string i_LastName)
        {
            StringBuilder name = new StringBuilder();

            switch (i_FirstName[0])
            {
                case 'A':
                    name.Append("Rancid");
                    break;
                case 'B':
                    name.Append("Insane");
                    break;
                case 'C':
                    name.Append("Black");
                    break;
                case 'D':
                    name.Append("Iron");
                    break;
                case 'E':
                    name.Append("Holy");
                    break;
                case 'F':
                    name.Append("Rabid");
                    break;
                case 'G':
                    name.Append("Bloody");
                    break;
                case 'H':
                    name.Append("Satan's");
                    break;
                case 'I':
                    name.Append("Bastard");
                    break;
                case 'J':
                    name.Append("Forsaken");
                    break;
                case 'K':
                    name.Append("Hell's");
                    break;
                case 'L':
                    name.Append("Forbidden");
                    break;
                case 'M':
                    name.Append("Dark");
                    break;
                case 'N':
                    name.Append("Frantic");
                    break;
                case 'O':
                    name.Append("Devil's");
                    break;
                case 'P':
                    name.Append("Evil");
                    break;
                case 'Q':
                    name.Append("Inner");
                    break;
                case 'R':
                    name.Append("Bleeding");
                    break;
                case 'S':
                    name.Append("Guilty");
                    break;
                case 'T':
                    name.Append("Witch's");
                    break;
                case 'U':
                    name.Append("Heavy");
                    break;
                case 'V':
                    name.Append("Illegal");
                    break;
                case 'W':
                    name.Append("Fallen");
                    break;
                case 'X':
                    name.Append("Sinister");
                    break;
                case 'Y':
                    name.Append("Crazy");
                    break;
                case 'Z':
                    name.Append("Troubled");
                    break;
            }

            name.Append(" ");
            switch (i_LastName[0])
            {
                case 'A':
                    name.Append("Empire");
                    break;
                case 'B':
                    name.Append("Fury");
                    break;
                case 'C':
                    name.Append("Rage");
                    break;
                case 'D':
                    name.Append("Zombies");
                    break;
                case 'E':
                    name.Append("Sin");
                    break;
                case 'F':
                    name.Append("Warriors");
                    break;
                case 'G':
                    name.Append("Angels");
                    break;
                case 'H':
                    name.Append("Death");
                    break;
                case 'I':
                    name.Append("Anarchy");
                    break;
                case 'J':
                    name.Append("Henchmen");
                    break;
                case 'K':
                    name.Append("Kill");
                    break;
                case 'L':
                    name.Append("Vengeance");
                    break;
                case 'M':
                    name.Append("Tendencies");
                    break;
                case 'N':
                    name.Append("Magic");
                    break;
                case 'O':
                    name.Append("Soldier");
                    break;
                case 'P':
                    name.Append("Gods");
                    break;
                case 'Q':
                    name.Append("Goblin");
                    break;
                case 'R':
                    name.Append("Spawn");
                    break;
                case 'S':
                    name.Append("Temple");
                    break;
                case 'T':
                    name.Append("Realm");
                    break;
                case 'U':
                    name.Append("Hate");
                    break;
                case 'V':
                    name.Append("Slaves");
                    break;
                case 'W':
                    name.Append("Thorn");
                    break;
                case 'X':
                    name.Append("Abyss");
                    break;
                case 'Y':
                    name.Append("Fire");
                    break;
                case 'Z':
                    name.Append("Secrets");
                    break;
            }

            return name.ToString();
        }
    }
}
