namespace WindowsFormsTamagotch
{
    partial class TamagotchiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tamagotchiPictureBox = new System.Windows.Forms.PictureBox();
            this.happinessProgressBar = new System.Windows.Forms.ProgressBar();
            this.cleanlinessProgressBar = new System.Windows.Forms.ProgressBar();
            this.hungerProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tamagotchiPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tamagotchiPictureBox
            // 
            this.tamagotchiPictureBox.ImageLocation = "jpg\\joy.jpg";
            this.tamagotchiPictureBox.Location = new System.Drawing.Point(12, 12);
            this.tamagotchiPictureBox.Name = "tamagotchiPictureBox";
            this.tamagotchiPictureBox.Size = new System.Drawing.Size(332, 295);
            this.tamagotchiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tamagotchiPictureBox.TabIndex = 0;
            this.tamagotchiPictureBox.TabStop = false;
            // 
            // happinessProgressBar
            // 
            this.happinessProgressBar.Location = new System.Drawing.Point(114, 324);
            this.happinessProgressBar.Maximum = 10;
            this.happinessProgressBar.Name = "happinessProgressBar";
            this.happinessProgressBar.Size = new System.Drawing.Size(100, 23);
            this.happinessProgressBar.Step = 1;
            this.happinessProgressBar.TabIndex = 1;
            // 
            // cleanlinessProgressBar
            // 
            this.cleanlinessProgressBar.Location = new System.Drawing.Point(114, 357);
            this.cleanlinessProgressBar.Maximum = 10;
            this.cleanlinessProgressBar.Name = "cleanlinessProgressBar";
            this.cleanlinessProgressBar.Size = new System.Drawing.Size(100, 23);
            this.cleanlinessProgressBar.Step = 1;
            this.cleanlinessProgressBar.TabIndex = 2;
            // 
            // hungerProgressBar
            // 
            this.hungerProgressBar.Location = new System.Drawing.Point(114, 391);
            this.hungerProgressBar.Maximum = 10;
            this.hungerProgressBar.Name = "hungerProgressBar";
            this.hungerProgressBar.Size = new System.Drawing.Size(100, 23);
            this.hungerProgressBar.Step = 1;
            this.hungerProgressBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Happiness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cleanliness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hunger";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(274, 328);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(274, 357);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 8;
            this.cleanButton.Text = "Clean";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(274, 386);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(75, 23);
            this.feedButton.TabIndex = 9;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // TamagotchiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(361, 443);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hungerProgressBar);
            this.Controls.Add(this.cleanlinessProgressBar);
            this.Controls.Add(this.happinessProgressBar);
            this.Controls.Add(this.tamagotchiPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TamagotchiForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tamagotchi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamagotchiPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tamagotchiPictureBox;
        private System.Windows.Forms.ProgressBar happinessProgressBar;
        private System.Windows.Forms.ProgressBar cleanlinessProgressBar;
        private System.Windows.Forms.ProgressBar hungerProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button feedButton;
    }
}

