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
		private double channelBalance, count;
		private MediaPlayer Player;
		private Uri path = new Uri(@"Audio\noise.wav", UriKind.Relative);
		private MMDeviceEnumerator devEnum;
		private MMDevice defaultDevice;
		private float leftChannelVol, rightChannelVol;

		// Function that runs on program start
		public MainWindow()
		{
			InitializeComponent();

			// Set the initial balance and step count to 0
			channelBalance = 0;
			count = 0;

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
			count++; // Add to step count
			channelBalance = channelBalance + Math.Pow(0.5, count); // Change channel balance so it is slightly farther to the right based on the step user is currently on
			Player.Balance = channelBalance; // Change the player's audio balance to the new balance
		}

		// Function that runs when the Right Ear button is clicked - Changes the audio balance to be further to the left
		private void RightButton_Click(object sender, EventArgs e)
        {
			count++; // Add to step count
			channelBalance = channelBalance - Math.Pow(0.5, count); // Change channel balance so it is slightly farther to the left based on the step user is currently on
			Player.Balance = channelBalance; // Change the player's audio balance to the new balance
		}

		// Function that runs when the "sounds the same" button is clicked - Sets the computer's audio balance to the calculated audio balance
        private void SameButton_Click(object sender, EventArgs e)
		{
			if (channelBalance < 0) // Checks to see if balance is to the left
            {
				// If it is, calculate the volume of each channel based on original channel volumes
				defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = 1 + (float) channelBalance;
				defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = Math.Abs((float) channelBalance);
			} else if (channelBalance > 0) // Checks to see if balance is to the right
            {
				// If it is, calculate the volume of each channel based on original channel volumes
				defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = (float) channelBalance; 
				defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = 1 - (float) channelBalance;
			}
		}

		// Functiont hat runs when the Reset button is clicked - Sets computer's audio back to normal and resets values
		private void ResetButton_Click(object sender, EventArgs e)
		{
			defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = leftChannelVol;
			defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = rightChannelVol;
			channelBalance = 0;
			count = 0;
			Player.Balance = 0;
		}
	}
}
