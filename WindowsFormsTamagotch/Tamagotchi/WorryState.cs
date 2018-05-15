using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    class WorryState : TamagotchiState
    {
        public WorryState()
        {
            TamagotchiImageLocation = @"gif\worry.gif";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            if (minCharacteristic <= 2)
                tamagotchi.State = new SadnessState();
            if (minCharacteristic > 4)
                tamagotchi.State = new JoyState();
        }
    }
}
