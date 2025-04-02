using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace InfernoNotificationManager
{
    public partial class MainForm : Form
    {
        private const string ProgramFilesPath = "C:\\Program Files\\InfernoNotificationManager";
        private const string SoundFileName = "bubble-pop.wav";
        private const string SoundFileUrl = "https://example.com/path/to/bubble-pop.wav"; // Replace with actual URL

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            CreateProgramFilesFolderAndDownloadSound();
            this.Close();
        }

        private void CreateProgramFilesFolderAndDownloadSound()
        {
            try
            {
                // Create folder in Program Files
                if (!Directory.Exists(ProgramFilesPath))
                {
                    Directory.CreateDirectory(ProgramFilesPath);
                }

                // Download sound file
                string soundFilePath = Path.Combine(ProgramFilesPath, SoundFileName);
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(SoundFileUrl, soundFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating folder or downloading sound: {ex.Message}");
            }
        }
    }
}
