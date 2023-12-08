using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using NAudio.CoreAudioApi;

namespace HearingAssistant
{
	public partial class MainWindow : Form
	{
		// Initialize variables and objects for use in program
		private double count;
		private MediaPlayer Player;
		private Uri path = new Uri(@"Audio\noise.wav", UriKind.Relative);
		private MMDeviceEnumerator devEnum;
		private MMDevice defaultDevice;
		private float leftChannelVol, rightChannelVol;

		// Function that runs on program start
		public MainWindow()
		{
			InitializeComponent();

			count = 0; // Initialize step count variable to decrease audio metric with every step

			Player = new MediaPlayer(); // Initialize the media player that will play the sound used in the program

			// Get the computer's default audio device using NAudio
			devEnum = new MMDeviceEnumerator();
			defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

			// Get the already existing channel volumes from the default audio device so that the audio can be reset later
			leftChannelVol = defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar;
			rightChannelVol = defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar;
		}

		// Function that runs when play button is clicked - Plays the audio
        private void PlayButton_Click(object sender, EventArgs e)
        {
			Player.Open(path); // Open the audio from the path declared earlier
			Player.Play(); // Play the audio
		}

		// Function that runs when the Left Ear button is clicked - Changes the audio balance to be further to the right
		private void LeftButton_Click(object sender, EventArgs e)
		{
			count++;
			float newVol = (float)Math.Pow(0.5, count) / 5;
			defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = volRange(defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar - newVol);
			defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = volRange(defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar + newVol);
		}

		// Function that runs when the Right Ear button is clicked - Changes the audio balance to be further to the left
		private void RightButton_Click(object sender, EventArgs e)
        {
			count++;
			float newVol = (float)Math.Pow(0.5, count) / 5;
			defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = volRange(defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar + newVol);
			defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = volRange(defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar - newVol);
		}

        // Function that runs when the "sounds the same" button is clicked - Exits the program
        private void SameButton_Click(object sender, EventArgs e)
		{
			Label.Text = "Thank you for using Hearing Assistant!";
			Refresh();
			System.Threading.Thread.Sleep(3000);
			this.Close();
		}

		// Function that runs when the Reset button is clicked - Sets computer's audio back to normal and resets values
		private void ResetButton_Click(object sender, EventArgs e)
		{
			defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = leftChannelVol;
			defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = rightChannelVol;
			count = 0;
		}

		// Function for making sure volume never goes outside of its range (0-1)
		private float volRange(float x)
        {
			if (x < 0)
            {
				return 0f;
            } else if (x > 1)
            {
				return 1f;
            } else
            {
				return x;
            }
        }
	}
}
