using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    class HeroBuilder : IHeroBuilderOrigin, IHeroBuilderStats, IHeroBuilderPoints
    {
        private Hero _hero;

        public IHeroBuilderOrigin Create(string name)
        {
            _hero = new Hero(name);
            return this;
        }

        public IHeroBuilderOrigin From(Hero.RaceType raceType)
        {
            _hero.Race = raceType;
            return this;
        }

        public IHeroBuilderOrigin As(Hero.ClassType classType)
        {
            _hero.Class = classType;
            return this;
        }

        public IHeroBuilderStats Lvl(int level)
        {
            _hero.Level = level;
            return this;
        }

        public IHeroBuilderStats Exp(int experience)
        {
            _hero.Experience = experience;
            return this;
        }

        public IHeroBuilderStats Str(int strength)
        {
            _hero.Strength = strength;
            return this;
        }

        public IHeroBuilderStats Con(int constitution)
        {
            _hero.Constitution = constitution;
            return this;
        }

        public IHeroBuilderStats Dex(int dexterity)
        {
            _hero.Dexterity = dexterity;
            return this;
        }

        public IHeroBuilderStats Wis(int wisdom)
        {
            _hero.Wisdom = wisdom;
            return this;
        }

        public IHeroBuilderStats Int(int intelligence)
        {
            _hero.Intelligence = intelligence;
            return this;
        }

        public IHeroBuilderStats Cha(int charisma)
        {
            _hero.Charisma = charisma;
            return this;
        }

        public IHeroBuilderPoints Gold(int gold)
        {
            _hero.Gold = gold;
            return this;
        }

        public IHeroBuilderPoints HP(int hitPoints)
        {
            _hero.HitPoints = hitPoints;
            return this;
        }

        public IHeroBuilderPoints MP(int manaPoints)
        {
            _hero.ManaPoints = manaPoints;
            return this;
        }

        public Hero Born()
        {
            return _hero;
        }
    }
}
