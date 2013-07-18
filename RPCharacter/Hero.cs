using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    public class Hero : ICharacter
    {
		public enum ClassType
		{
			Warrior,
			Paladin,
			Priest,
			Rogue,
			Mage,
			Warlock
		};

		public enum RaceType
		{
			Human,
			Dwarf,
			Elf,
			Orc,
			Troll,
			Tauren
		};

        private Guid _id;
        private string _name;
        private string _dialog;
        public ClassType Class;
        public RaceType Race;
        public int Level;
        public int Experience;
        public int Strength;
        public int Constitution;
        public int Dexterity;
        public int Wisdom;
        public int Intelligence;
        public int Charisma;
        public int Gold;
        public int HitPoints;
        public int ManaPoints;

        #region Constructors

        public Hero()
        {
            _id = Guid.NewGuid();
            _name = "Test";
            _dialog = "Hello World!";
        }

        public Hero(string name)
        {
            _id = Guid.NewGuid();
            _name = name;
            _dialog = "Hello World!";
        }

        public Hero(Guid id, string name, string dialog)
        {
            _id = id;
            _name = name;
            _dialog = dialog;
        }

        #endregion

        #region Access Modifiers

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Dialog
        {
            get { return _dialog; }
            set { _dialog = value; }
        }

        #endregion

        public override string ToString()
        {
            return "======================\n" +
                "\nGreeting: " + Dialog +
                "\nNAME:\t" + Name +
                "\nLVL:\t" + Level +
                "   " + Race +
                " " + Class +
                "\nSTR:\t" + Strength +
                "\nCON:\t" + Constitution +
                "\nDEX:\t" + Dexterity +
                "\nWIS:\t" + Wisdom +
                "\nINT:\t" + Intelligence +
                "\nCHA:\t" + Charisma +
                "\nHP:\t" + HitPoints +
                "\nMP:\t" + ManaPoints +
                "\nEXP:\t" + Experience +
                "\nGOLD:\t" + Gold +
                "\n======================\n";
        }
    }
}
