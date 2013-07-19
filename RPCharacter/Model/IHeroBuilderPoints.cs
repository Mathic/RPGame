using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    interface IHeroBuilderPoints
    {
        IHeroBuilderPoints HP(int hitPoints);
        IHeroBuilderPoints MP(int manaPoints);
    }
}
