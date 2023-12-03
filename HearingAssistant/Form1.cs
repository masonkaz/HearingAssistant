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
		private double channelBalance, count;
		private MediaPlayer Player;
		private Uri path = new Uri(@"Audio\noise.wav", UriKind.Relative);
		private MMDeviceEnumerator devEnum;
		private MMDevice defaultDevice;
		private float leftChannelVol, rightChannelVol;

		public MainWindow()
		{
			InitializeComponent();

			channelBalance = 0;
			count = 0;

			Player = new MediaPlayer();

			devEnum = new MMDeviceEnumerator();
			defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

			leftChannelVol = defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar;
			rightChannelVol = defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar;
		}

        private void ReplayButton_Click(object sender, EventArgs e)
        {
			Player.Open(path);
			Player.Play();
		}

        private void RightButton_Click(object sender, EventArgs e)
        {
			count++;
			channelBalance = channelBalance - Math.Pow(0.5, count);
			Player.Balance = channelBalance;
		}

        private void LeftButton_Click(object sender, EventArgs e)
        {
			count++;
			channelBalance = channelBalance + Math.Pow(0.5, count);
			Player.Balance = channelBalance;
		}

		private void SameButton_Click(object sender, EventArgs e)
		{
			if (channelBalance < 0)
            {
				defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = 1 + (float) channelBalance;
				defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = Math.Abs((float) channelBalance);
			} else if (channelBalance > 0)
            {
				defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = (float) channelBalance; 
				defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = 1 - (float) channelBalance;
			}
		}
		private void ResetButton_Click(object sender, EventArgs e)
		{
			defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = leftChannelVol;
			defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = rightChannelVol;
		}
	}
}
