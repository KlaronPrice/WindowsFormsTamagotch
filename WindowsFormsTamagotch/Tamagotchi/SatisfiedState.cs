namespace WindowsFormsTamagotch.Tamagotchi
{
    class SatisfiedState : TamagotchiState
    {
        public SatisfiedState()
        {
            TamagotchiImageLocation = @"gif\satisfied.gif";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            if (minCharacteristic > 6)
                tamagotchi.State = new JoyState();
            if (minCharacteristic <= 4)
                tamagotchi.State = new WorryState();
        }
    }
}
