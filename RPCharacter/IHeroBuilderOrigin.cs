using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    interface IHeroBuilderOrigin
    {
        IHeroBuilderOrigin From(Hero.RaceType raceType);
        IHeroBuilderOrigin As(Hero.ClassType classType);
        IHeroBuilderStats Lvl(int level);
    }
}
