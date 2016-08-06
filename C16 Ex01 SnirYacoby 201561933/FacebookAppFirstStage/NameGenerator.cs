using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal class NameGenerator
    {
        private string m_FirstName;
        private string m_LastName;

        public NameGenerator(string i_FirstName, string i_LastName)
        {
            m_FirstName = i_FirstName;
            m_LastName = i_LastName;
        }

        public string GenerateDragonName(string i_FatherName, string i_MotherName)
        {
            StringBuilder name = new StringBuilder();

            name.Append(m_FirstName.Substring(m_FirstName.Length - 2, 1).ToUpper() + m_FirstName.Substring(m_FirstName.Length - 1));
            name.Append(m_LastName.Substring(m_LastName.Length / 2, 2));
            name.Append(i_MotherName.Substring(0, 2).ToLower());
            name.Append(i_FatherName.Substring(i_FatherName.Length - 1));

            return name.ToString();
        }

        public string GenerateWerewolfName()
        {
            StringBuilder name = new StringBuilder();

            switch (m_FirstName[0])
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
            switch(m_LastName[m_LastName.Length - 1])
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

        public string GenerateSuperheroName()
        {
            StringBuilder name = new StringBuilder();

            switch (m_FirstName[0])
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
            switch (m_LastName[0])
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

        public string GenerateJapaneseName()
        {
            StringBuilder name = new StringBuilder();

            foreach(char letter in m_FirstName)
            {
                name.Append(japaneseNameHelper(letter));
            }

            name.Append(" ");
            foreach(char letter in m_LastName)
            {
                name.Append(japaneseNameHelper(letter));
            }

            return name.ToString();
        }

        private string japaneseNameHelper(char i_Letter)
        {
            string changedLetter = string.Empty;

            switch (i_Letter)
            {
                case 'A':
                case 'a':
                    changedLetter = "ka";
                    break;
                case 'B':
                case 'b':
                    changedLetter = "tu";
                    break;
                case 'C':
                case 'c':
                    changedLetter = "mi";
                    break;
                case 'D':
                case 'd':
                    changedLetter = "te";
                    break;
                case 'E':
                case 'e':
                    changedLetter = "ku";
                    break;
                case 'F':
                case 'f':
                    changedLetter = "lu";
                    break;
                case 'G':
                case 'g':
                    changedLetter = "ji";
                    break;
                case 'H':
                case 'h':
                    changedLetter = "ri";
                    break;
                case 'I':
                case 'i':
                    changedLetter = "ki";
                    break;
                case 'J':
                case 'j':
                    changedLetter = "zu";
                    break;
                case 'K':
                case 'k':
                    changedLetter = "me";
                    break;
                case 'L':
                case 'l':
                    changedLetter = "ta";
                    break;
                case 'M':
                case 'm':
                    changedLetter = "rin";
                    break;
                case 'N':
                case 'n':
                    changedLetter = "to";
                    break;
                case 'O':
                case 'o':
                    changedLetter = "mo";
                    break;
                case 'P':
                case 'p':
                    changedLetter = "no";
                    break;
                case 'Q':
                case 'q':
                    changedLetter = "ke";
                    break;
                case 'R':
                case 'r':
                    changedLetter = "shi";
                    break;
                case 'S':
                case 's':
                    changedLetter = "ari";
                    break;
                case 'T':
                case 't':
                    changedLetter = "chi";
                    break;
                case 'U':
                case 'u':
                    changedLetter = "do";
                    break;
                case 'V':
                case 'v':
                    changedLetter = "ru";
                    break;
                case 'W':
                case 'w':
                    changedLetter = "mei";
                    break;
                case 'X':
                case 'x':
                    changedLetter = "na";
                    break;
                case 'Y':
                case 'y':
                    changedLetter = "fu";
                    break;
                case 'Z':
                case 'z':
                    changedLetter = "zi";
                    break;
            }

            return changedLetter;
        }
    }
}
