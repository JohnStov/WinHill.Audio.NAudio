using NUnit.Framework;
using Should.Fluent;
using WinHill.Audio.Configuration;

namespace WinHill.Audio.NAudio.Test.Configuration
{
    [TestFixture]
	public class AudioSettingsTest
	{
		[Test]
		public void TechnologiesListIsNotNull()
		{
			var audioSettings = new AudioSettings();

		    audioSettings.Technologies.Should().Count.AtLeast(0);
		}

		[Test]
		public void DeviceIsInitiallyNull()
		{
			var audioSettings = new AudioSettings();
			
            audioSettings.Device.Should().Be.Null();
		}

		[Test]
		public void CanSetDevice()
		{
			var mockDevice = new Mock<IDevice>();

			var audioSettings = new AudioSettings { Device = mockDevice.Object };
			
            audioSettings.Device.Should().Equal(mockDevice.Object);
		}

		[Test]
		public void SettingDeviceNotifiesPropertyChanging()
		{
			var mockDevice = new Mock<IDevice>();
			var audioSettings = new AudioSettings();
            string propertyName = null;
			object sender = null;
            audioSettings.Changing.Subscribe(x => { propertyName = x.PropertyName; sender = x.Sender; });

			audioSettings.Device = mockDevice.Object;

			propertyName.Should().Equal("Device");
			sender.Should().Equal(audioSettings);
		}

		[Test]
		public void SettingDeviceNotifiesPropertyChanged()
		{
			var mockDevice = new Mock<IDevice>();
			var audioSettings = new AudioSettings();
            string propertyName = null;
			object sender = null;
            audioSettings.Changed.Subscribe(x => { propertyName = x.PropertyName; sender = x.Sender; });

			audioSettings.Device = mockDevice.Object;

			propertyName.Should().Equal("Device");
			sender.Should().Equal(audioSettings);
		}
	}
}
