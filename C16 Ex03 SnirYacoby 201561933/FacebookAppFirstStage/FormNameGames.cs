using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApp
{
    internal partial class FormNameGames : Form
    {
        private User m_LoggedInUser;

        public FormNameGames(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
        }

        private void doWhenNameGeneratorButtonClicked(Func<string, string, string> i_NameGenerationMethod, eNameGenerator i_TypeOfName)
        {
            StringBuilder sb = new StringBuilder();
            INameGenerator nameGenerator = NameGeneratorFactory.CreateNameGenerator(m_LoggedInUser.FirstName, m_LoggedInUser.LastName, i_NameGenerationMethod);

            sb.Append(string.Format("Your {1} name is: {0}{0}", Environment.NewLine, Enum.GetName(typeof(eNameGenerator), i_TypeOfName)));
            sb.Append(nameGenerator.GenerateName());
            richTextBoxGeneration.Clear();
            richTextBoxGeneration.Text = sb.ToString();
        }

        private void buttonJapaneseName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(JapaneseName, eNameGenerator.Japanese);
        }

        private void buttonSuperheroName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(SuperheroName, eNameGenerator.Superhero);
        }

        private void buttonWerewolfName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(WerewolfName, eNameGenerator.Werewolf);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if(richTextBoxGeneration.TextLength > 0)
            {
                m_LoggedInUser.PostStatus(richTextBoxGeneration.Text);
                richTextBoxGeneration.Clear();
                MessageBox.Show("Post successful");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxGeneration.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBandName_Click(object sender, EventArgs e)
        {
            doWhenNameGeneratorButtonClicked(HeavyMetalBandName, eNameGenerator.HeavyMetalBand);
        }

        private string HeavyMetalBandName(string i_FirstName, string i_LastName)
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

        private string JapaneseName(string i_FirstName, string i_LastName)
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

        private string SuperheroName(string i_FirstName, string i_LastName)
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

        private string WerewolfName(string i_FirstName, string i_LastName)
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
