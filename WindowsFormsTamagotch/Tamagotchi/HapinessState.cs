using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    class HapinessState : TamagotchiState
    {
        public HapinessState()
        {
            TamagotchiImageLocation = @"gif\happy.gif";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            if (minCharacteristic <= 8)
                tamagotchi.State = new JoyState();             
        }
    }
}
