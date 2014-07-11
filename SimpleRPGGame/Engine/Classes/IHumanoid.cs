using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Classes
{
    public interface IHumanoid
    {
        string sName
        {
            get;
            set;
        }

        int iCurrentHitPoints
        {
            get;
            set;
        }
        int iMaxHitPoints
        {
            get;
            set;
        }

        int iCurrentStaminaPoints
        {
            get;
            set;
        }
        int iMaxStaminaPoints
        {
            get;
            set;
        }

        int iGold
        {
            get;
            set;
        }

        int iExp
        {
            get;
            set;
        }

        int iLevel
        {
            get;
            set;
        }
    }
}
