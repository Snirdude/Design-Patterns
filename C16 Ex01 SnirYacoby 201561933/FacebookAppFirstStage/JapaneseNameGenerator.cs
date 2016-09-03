using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal class JapaneseNameGenerator : INameGenerator
    {
        public string GenerateName(string i_FirstName, string i_LastName)
        {
            StringBuilder name = new StringBuilder();

            foreach (char letter in i_FirstName)
            {
                name.Append(japaneseNameHelper(letter));
            }

            name.Append(" ");
            foreach (char letter in i_LastName)
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
