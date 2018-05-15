using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTamagotch.Tamagotchi
{
    class Tamagotchi
    {
        sbyte happy;
        sbyte cleanliness;
        sbyte hunger;

        public TamagotchiState State { get; set; }
        // 4 sostoyaniiya  1 убежал, 2 грустит, 3 нейтрален, 4 доволен, 5 счастлив из 2,3 можно перейти в 4, из 4 в 5, в 1 только из 2
        //сигналы подавать наборами из характеристик тамагочи// вместо набора можно поставлять минимальную характеристику

        public sbyte Happy
        {
            set
            {
                SetСharacteristic(ref happy, value);
            }
            get
            {
                return happy;
            }
        }
        public sbyte Cleanliness
        {
            set
            {
                SetСharacteristic(ref cleanliness, value);
            }
            get
            {
                return cleanliness;
            }
        }
        public sbyte Hunger
        {
            set
            {
                SetСharacteristic(ref hunger, value);
            }
            get
            {
                return hunger;
            }
        }


        public string GetTamagotchiPicturePath()
        {
            State.CheckTamagotchi(this,MinСharacteristic());
            return State.TamagotchiImageLocation;
        }

        void SetСharacteristic(ref sbyte characteristic, sbyte value)
        {
            characteristic = value;
            if (characteristic <= 0)
                characteristic = 0;
            else if (characteristic >= 10)
                characteristic = 10;
        }

        sbyte MinСharacteristic()
        {
            sbyte minCharacteristic;
            minCharacteristic = Math.Min(happy, cleanliness);
            minCharacteristic = Math.Min(minCharacteristic, hunger);
            return minCharacteristic;
        }

        public Tamagotchi()
        {
            happy = 8;
            cleanliness = 8;
            hunger = 8;
            State = new JoyState();
        }

    }
}
