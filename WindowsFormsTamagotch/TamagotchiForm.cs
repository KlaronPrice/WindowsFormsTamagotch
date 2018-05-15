using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            StartGame();
        }

        async void Rotate()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (tamagotchiPictureBox.Image != null)
                    tamagotchiPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
        }

        async void StartGame()
        {
            //Task task = new Task(LifeTime);
            //task.Start();          
            //while (true)
            //BeginInvoke(new Action(Rotate));
            //new Task(Rotate).Start();
            await Task.Factory.StartNew(LifeTime);
            playButton.Enabled = false;
            cleanButton.Enabled = false;
            feedButton.Enabled = false;
            MessageBox.Show(@"Тамагочи сбежал!!!");

        }

        bool LifeTime()
        {
            int lowerChar;
            Random rand = new Random();
            while (!(tamagotchi.State is Tamagotchi.LostState))
            {
                //for (int i = 0; i < 6; i++)
                //{
                //    Thread.Sleep(500);
                //    if (tamagotchiPictureBox.Image != null)
                //    {
                //        tamagotchiPictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                //        BeginInvoke(new Action(tamagotchiPictureBox.Refresh));
                //    }

                //}
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
            return false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            tamagotchi.Happy += 1;
            happinessProgressBar.Value = tamagotchi.Happy;
            RefreshTamagotchiImageBox();
        }
        private void cleanButton_Click(object sender, EventArgs e)
        {
            tamagotchi.Cleanliness += 1;
            cleanlinessProgressBar.Value = tamagotchi.Cleanliness;
            RefreshTamagotchiImageBox();
        }
        private void feedButton_Click(object sender, EventArgs e)
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
