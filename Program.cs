using System;
using System.Collections.Generic;

namespace Lab_5_1
{
    class GameCharacter
    {
        private string Name;
        private int Strength;
        private int Intelligence;

        public string CharName
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int CharStrength
        {
            get
            {
                return Strength;
            }

            set
            {
                Strength = value;
            }
        }

        public int CharIntelligence
        {
            get
            {
                return Intelligence;
            }
            set
            {
                Intelligence = value;
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} (intelligence {Intelligence}, strength {Strength})");
        }

        public GameCharacter(string playername, int playerstrength, int playerintelligence)
        {
            Name = playername;
            Strength = playerstrength;
            Intelligence = playerintelligence;
        }
    }

    class MagicUsingCharacter: GameCharacter
    {
        private int MagicalEngergy;
        
        public int CharMagicalEnergy
        {
            get
            {
                return MagicalEngergy;
            }

            set
            {
                MagicalEngergy = value;
            }
        }

        public override void Play()
        {
            Console.WriteLine($"{CharName} (intelligence {CharIntelligence}, strength {CharStrength}, magic {MagicalEngergy} )");
        }

        public MagicUsingCharacter(string playername, int playerstrength, int playerintelligence, int magmagic)
            : base(playername, playerstrength, playerintelligence)
        {
           
            MagicalEngergy = magmagic;
        }
    }

    class Warrior: GameCharacter
    {
        private string WeaponType;

        public string CharWeaponType
        {
            get
            {
                return WeaponType;
            }

            set
            {
                WeaponType = value;
            }
        }

        public override void Play()
        {
            Console.WriteLine($"{CharName} (intelligence {CharIntelligence}, strength {CharStrength}) {WeaponType}");
        }

        public Warrior(string playername, int playerstrength, int playerintelligence, string warweapontype)
            : base(playername, playerstrength, playerintelligence)
        {
            WeaponType = warweapontype;
        }
    }
  

    class Wizard: MagicUsingCharacter
    {
        private int SpellNumber;

        public int CharSpellNumber
        {
            get
            {
                return SpellNumber;
            }

            set
            {
                SpellNumber = value;
            }
        }

        public override void Play()
        {
            Console.WriteLine($"{CharName} (intelligence {CharIntelligence}, strength {CharStrength}, magic {CharMagicalEnergy}) {SpellNumber} spells");
        }

        public Wizard(string playername, int playerstrength, int playerintelligence, int magmagic, int wizspell)
            : base(playername, playerstrength, playerintelligence, magmagic)
        {
            SpellNumber = wizspell;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("Thor", 30, 15, "Hammer"));
            gameCharacters.Add(new Warrior("Hawkeye", 10, 18, "Bow and Arrow"));
            gameCharacters.Add(new Wizard("Doctor Strange", 15, 20, 20, 20));
            gameCharacters.Add(new Wizard("Wanda Maximoff", 20, 20, 30, 30));
            gameCharacters.Add(new Warrior("Hulk", 29, 35, "Fists"));
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");
            Console.WriteLine();

            foreach (GameCharacter player in gameCharacters)
            {
                player.Play();
            }
        }
    }
}
