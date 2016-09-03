using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal class WerewolfNameGenerator : INameGenerator
    {
        public string GenerateName(string i_FirstName, string i_LastName)
        {
            StringBuilder name = new StringBuilder();

            switch (i_FirstName[0])
            {
                case 'A':
                    name.Append("White");
                    break;
                case 'B':
                    name.Append("Lone");
                    break;
                case 'C':
                    name.Append("Ravenous");
                    break;
                case 'D':
                    name.Append("Ancient");
                    break;
                case 'E':
                    name.Append("Magic");
                    break;
                case 'F':
                    name.Append("Ebony");
                    break;
                case 'G':
                    name.Append("Dark");
                    break;
                case 'H':
                    name.Append("Savage");
                    break;
                case 'I':
                    name.Append("Regal");
                    break;
                case 'J':
                    name.Append("Rogue");
                    break;
                case 'K':
                    name.Append("Scarlet");
                    break;
                case 'L':
                    name.Append("Fierce");
                    break;
                case 'M':
                    name.Append("Alpha");
                    break;
                case 'N':
                    name.Append("Beautiful");
                    break;
                case 'O':
                    name.Append("Blood");
                    break;
                case 'P':
                    name.Append("Moon");
                    break;
                case 'Q':
                    name.Append("Loyal");
                    break;
                case 'R':
                    name.Append("Scarred");
                    break;
                case 'S':
                    name.Append("Grey");
                    break;
                case 'T':
                    name.Append("Mystic");
                    break;
                case 'U':
                    name.Append("Prime");
                    break;
                case 'V':
                    name.Append("Graceful");
                    break;
                case 'W':
                    name.Append("Majestic");
                    break;
                case 'X':
                    name.Append("Wild");
                    break;
                case 'Y':
                    name.Append("Vengeful");
                    break;
                case 'Z':
                    name.Append("Cruel");
                    break;
            }

            name.Append(" ");
            switch (i_LastName[i_LastName.Length - 1])
            {
                case 'a':
                    name.Append("Hunter");
                    break;
                case 'b':
                    name.Append("Demon");
                    break;
                case 'c':
                    name.Append("Howler");
                    break;
                case 'd':
                    name.Append("Rain");
                    break;
                case 'e':
                    name.Append("Red");
                    break;
                case 'f':
                    name.Append("Shadow");
                    break;
                case 'g':
                    name.Append("Storm");
                    break;
                case 'h':
                    name.Append("Beast");
                    break;
                case 'i':
                    name.Append("Bane");
                    break;
                case 'j':
                    name.Append("Dagger");
                    break;
                case 'k':
                    name.Append("Hound");
                    break;
                case 'l':
                    name.Append("Fang");
                    break;
                case 'm':
                    name.Append("Claw");
                    break;
                case 'n':
                    name.Append("Wolf");
                    break;
                case 'o':
                    name.Append("Cresent");
                    break;
                case 'p':
                    name.Append("Paw");
                    break;
                case 'q':
                    name.Append("Lupus");
                    break;
                case 'r':
                    name.Append("Fire");
                    break;
                case 's':
                    name.Append("Temptress");
                    break;
                case 't':
                    name.Append("Warrior");
                    break;
                case 'u':
                    name.Append("Rage");
                    break;
                case 'v':
                    name.Append("Thorn");
                    break;
                case 'w':
                    name.Append("Moon");
                    break;
                case 'x':
                    name.Append("Lupe");
                    break;
                case 'y':
                    name.Append("Vixen");
                    break;
                case 'z':
                    name.Append("Omega");
                    break;
            }

            return name.ToString();
        }
    }
}
