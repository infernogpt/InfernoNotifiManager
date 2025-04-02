using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InfernoNotificationManager
{
    public partial class NotificationForm : Form
    {
        private const string ProgramFilesPath = "C:\\Program Files\\InfernoNotificationManager";
        private const string SoundFileName = "bubble-pop.wav";

        public NotificationForm(string appName, string message)
        {
            InitializeComponent();
            lblAppName.Text = appName;
            lblMessage.Text = message;
            this.Opacity = 0;
            this.TopMost = true; // Ensure the notification is always on top
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            // Set the initial position off-screen
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height);
            ShowNotification();
        }

        private void ShowNotification()
        {
            var timer = new Timer();
            timer.Interval = 10; // Animation speed
            timer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }

                if (this.Top > Screen.PrimaryScreen.WorkingArea.Height - this.Height - 20)
                {
                    this.Top -= 5; // Slide up
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();

            // Play notification sound
            string soundFilePath = Path.Combine(ProgramFilesPath, SoundFileName);
            if (File.Exists(soundFilePath))
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFilePath);
                player.Play();
            }
            else
            {
                MessageBox.Show("Sound file not found.");
            }
        }
    }
}
