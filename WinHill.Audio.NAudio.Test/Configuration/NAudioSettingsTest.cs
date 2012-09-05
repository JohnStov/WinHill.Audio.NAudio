namespace WinHill.Audio.NAudio.Test.Configuration
{
    using System;
    using System.ComponentModel;
    using System.Reactive.Linq;

    using NSubstitute;

    using NUnit.Framework;

    using Should.Fluent;

    using Rxx;

    using WinHill.Audio.Configuration;
    using WinHill.Audio.NAudio.Configuration;

    [TestFixture]
	public class NAudioSettingsTest
	{
		[Test]
		public void TechnologiesListIsNotNull()
		{
			var audioSettings = new NAudioSettings();

		    audioSettings.Technologies.Should().Count.AtLeast(0);
		}

		[Test]
		public void DeviceIsInitiallyNull()
		{
			var audioSettings = new NAudioSettings();
			
            audioSettings.Device.Should().Be.Null();
		}

		[Test]
		public void CanSetDevice()
		{
			var mockDevice = Substitute.For<IDevice>();

			var audioSettings = new NAudioSettings { Device = mockDevice };
			
            audioSettings.Device.Should().Equal(mockDevice);
		}

		[Test]
		public void SettingDeviceNotifiesPropertyChanged()
		{
            var mockDevice = Substitute.For<IDevice>();
			var audioSettings = new NAudioSettings();

		    bool called = false;

		    audioSettings.PropertyChanged += (sender, e) =>
		        {
		            if (e.PropertyName == "Device")
		                called = true;
		        };

			audioSettings.Device = mockDevice;

			called.Should().Be.True();
		}
	}
}
