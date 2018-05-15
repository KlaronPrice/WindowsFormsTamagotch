using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    class LostState : TamagotchiState
    {
        public LostState()
        {
            TamagotchiImageLocation = @"jpg\lost.jpg";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            //Конечное состояние.
        }
    }
}
