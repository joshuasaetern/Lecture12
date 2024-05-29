using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12
{
    internal class Character
    {
        //Used for rolling stats
        Random rand = new Random();

        //Fields
        String playerName;
        String characterName;
        int intelligence;
        int constitution;
        int proficiency;

        //Constructors
        public Character(String playerName, String characterName, int intelligence, int constitution)
        {
            this.playerName = playerName;
            this.characterName = characterName;
            this.intelligence = intelligence;
            this.constitution = constitution;
        }
        public Character(String playerName, String characterName)
        {
            this.playerName= playerName;
            this.characterName= characterName;
            this.intelligence = rand.Next(0, 21);
            this.constitution = rand.Next(0, 21);
        }

        //Properties
        public string PlayerName { get => playerName; set => playerName = value; }
        public string CharacterName { get => characterName; set => characterName = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Hacking { get => AbilityModifier(this.intelligence); }
        public int WillPower { get => AbilityModifier(this.constitution); }

        //Methods
        public static int AbilityModifier(int stat)
        {
            //Makes it so that the Ability cannot be negative
            if (stat < 10)
            {
                return 0;
            }
            
            return (stat - 10) / 2;
        }
        public override string ToString()
        {
            return $"Player Name: {this.PlayerName}\n" +
                   $"Character Name: {this.CharacterName}\n" +
                   $"Intelligence: {this.Intelligence}\n" +
                   $"Constitution: {this.Constitution}\n" +
                   $"Hacking: {this.Hacking}\n" +
                   $"Will Power: {this.WillPower}";
        }

    }
}
