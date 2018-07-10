using System;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsTamagotch
{
    public partial class TamagotchiForm : Form
    {
        Tamagotchi.Tamagotchi tamagotchi;
        public TamagotchiForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tamagotchi = new Tamagotchi.Tamagotchi();
            happinessProgressBar.Value = tamagotchi.Happy;
            cleanlinessProgressBar.Value = tamagotchi.Cleanliness;
            hungerProgressBar.Value = tamagotchi.Hunger;
            StartTheGameAsync();
        }

        async void StartTheGameAsync()
        {
            await Task.Factory.StartNew(LifeTime);
            playButton.Enabled = false;
            cleanButton.Enabled = false;
            feedButton.Enabled = false;
            MessageBox.Show(@"Питомец сбежал!");
        }

        void LifeTime()
        {
            int lowerChar;
            Random rand = new Random();
            while (!(tamagotchi.State is Tamagotchi.LostState))
            {
                Thread.Sleep(2000);
                lowerChar = rand.Next() % 3;
                switch (lowerChar)
                {
                    case 0:
                        tamagotchi.Happy -= 1;
                        BeginInvoke(new Action(() => happinessProgressBar.Value = tamagotchi.Happy));
                        break;
                    case 1:
                        tamagotchi.Cleanliness -= 1;
                        BeginInvoke(new Action(() => cleanlinessProgressBar.Value = tamagotchi.Cleanliness));
                        break;
                    case 2:
                        tamagotchi.Hunger -= 1;
                        BeginInvoke(new Action(() => hungerProgressBar.Value = tamagotchi.Hunger));
                        break;
                }
                RefreshTamagotchiImageBox();
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            tamagotchi.Happy += 1;
            happinessProgressBar.Value = tamagotchi.Happy;
            RefreshTamagotchiImageBox();
        }
        private void CleanButton_Click(object sender, EventArgs e)
        {
            tamagotchi.Cleanliness += 1;
            cleanlinessProgressBar.Value = tamagotchi.Cleanliness;
            RefreshTamagotchiImageBox();
        }
        private void FeedButton_Click(object sender, EventArgs e)
        {
            tamagotchi.Hunger += 1;
            hungerProgressBar.Value = tamagotchi.Hunger;
            RefreshTamagotchiImageBox();
        }

        void RefreshTamagotchiImageBox()
        {
            string newPath = tamagotchi.GetTamagotchiPicturePath();
            if (tamagotchiPictureBox.ImageLocation != newPath)
                tamagotchiPictureBox.ImageLocation = newPath;
        }
    }
}
