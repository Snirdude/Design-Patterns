using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal class SuperheroNameGenerator : INameGenerator
    {
        public string GenerateName(string i_FirstName, string i_LastName)
        {
            StringBuilder name = new StringBuilder();

            switch (i_FirstName[0])
            {
                case 'A':
                    name.Append("Captain");
                    break;
                case 'B':
                    name.Append("Turbo");
                    break;
                case 'C':
                    name.Append("Galactic");
                    break;
                case 'D':
                    name.Append("The");
                    break;
                case 'E':
                    name.Append("Aqua");
                    break;
                case 'F':
                    name.Append("Fire");
                    break;
                case 'G':
                    name.Append("Iron");
                    break;
                case 'H':
                    name.Append("Super");
                    break;
                case 'I':
                    name.Append("Green");
                    break;
                case 'J':
                    name.Append("Phantom");
                    break;
                case 'K':
                    name.Append("Dark");
                    break;
                case 'L':
                    name.Append("Ghost");
                    break;
                case 'M':
                    name.Append("Professor");
                    break;
                case 'N':
                    name.Append("Atomic");
                    break;
                case 'O':
                    name.Append("Rock");
                    break;
                case 'P':
                    name.Append("Omega");
                    break;
                case 'Q':
                    name.Append("Rocket");
                    break;
                case 'R':
                    name.Append("Shadow");
                    break;
                case 'S':
                    name.Append("Agent");
                    break;
                case 'T':
                    name.Append("Silver");
                    break;
                case 'U':
                    name.Append("Wild");
                    break;
                case 'V':
                    name.Append("Wolf");
                    break;
                case 'W':
                    name.Append("Ultra");
                    break;
                case 'X':
                    name.Append("Wonder");
                    break;
                case 'Y':
                    name.Append("Doctor");
                    break;
                case 'Z':
                    name.Append("Star");
                    break;
            }

            name.Append(" ");
            switch (i_LastName[0])
            {
                case 'A':
                    name.Append("X");
                    break;
                case 'B':
                    name.Append("Shield");
                    break;
                case 'C':
                    name.Append("Machine");
                    break;
                case 'D':
                    name.Append("Justice");
                    break;
                case 'E':
                    name.Append("Beast");
                    break;
                case 'F':
                    name.Append("Wing");
                    break;
                case 'G':
                    name.Append("Arrow");
                    break;
                case 'H':
                    name.Append("Skull");
                    break;
                case 'I':
                    name.Append("Blade");
                    break;
                case 'J':
                    name.Append("Bolt");
                    break;
                case 'K':
                    name.Append("Cobra");
                    break;
                case 'L':
                    name.Append("Blaze");
                    break;
                case 'M':
                    name.Append("Soldier");
                    break;
                case 'N':
                    name.Append("Strike");
                    break;
                case 'O':
                    name.Append("Falcon");
                    break;
                case 'P':
                    name.Append("Fang");
                    break;
                case 'Q':
                    name.Append("King");
                    break;
                case 'R':
                    name.Append("Surfer");
                    break;
                case 'S':
                    name.Append("Bot");
                    break;
                case 'T':
                    name.Append("Guard");
                    break;
                case 'U':
                    name.Append("Thing");
                    break;
                case 'V':
                    name.Append("Claw");
                    break;
                case 'W':
                    name.Append("Brain");
                    break;
                case 'X':
                    name.Append("Master");
                    break;
                case 'Y':
                    name.Append("Power");
                    break;
                case 'Z':
                    name.Append("Storm");
                    break;
            }

            return name.ToString();
        }
    }
}
