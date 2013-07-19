using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    interface IHeroBuilderStats
    {
        IHeroBuilderStats Exp(int experience);
        IHeroBuilderStats Str(int strength);
        IHeroBuilderStats Con(int constitution);
        IHeroBuilderStats Dex(int dexterity);
        IHeroBuilderStats Wis(int wisdom);
        IHeroBuilderStats Int(int intelligence);
        IHeroBuilderStats Cha(int charisma);
        IHeroBuilderPoints Gold(int gold);
    }
}
