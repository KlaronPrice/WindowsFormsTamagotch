using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    class JoyState : TamagotchiState
    {
        public JoyState()
        {
            TamagotchiImageLocation = @"gif\joy.gif";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            if (minCharacteristic <= 6)
                tamagotchi.State = new SatisfiedState();
            if (minCharacteristic > 8)
                tamagotchi.State = new HapinessState();
        }
    }
}
