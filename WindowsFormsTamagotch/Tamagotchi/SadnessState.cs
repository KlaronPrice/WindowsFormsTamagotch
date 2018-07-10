namespace WindowsFormsTamagotch.Tamagotchi
{
    class SadnessState : TamagotchiState
    {
        public SadnessState()
        {
            TamagotchiImageLocation= @"gif\sadness.gif";
        }
        public override void CheckTamagotchi(Tamagotchi tamagotchi, sbyte minCharacteristic)
        {
            if (minCharacteristic == 0)
                tamagotchi.State = new LostState();
            if (minCharacteristic > 2)
                tamagotchi.State = new WorryState();
        }
    }
}
