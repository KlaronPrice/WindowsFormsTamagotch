using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    abstract class TamagotchiState
    {
        public string TamagotchiImageLocation { get; protected set; }
        byte minCharacteristic;
        public abstract void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic);
    }
}
