﻿namespace WinHill.Audio.NAudio.Test.Configuration
{
    using NUnit.Framework;

    using Should.Fluent;

    using WinHill.Audio.NAudio.Configuration;

    using global::NAudio.Wave;

    [TestFixture]
	public class DirectSoundDeviceTest
	{
		[Test]
		public void CanCreateDevice()
		{
			var device = new DirectSoundDevice(new DirectSoundDeviceInfo());

			device.Should().Not.Be.Null();
		}

		[Test]
		public void DeviceTakesNameFromInfo()
		{
			var device = new DirectSoundDevice(new DirectSoundDeviceInfo { Description = "Test Device" });

			device.Name.Should().Equal("Test Device");
		}

		[Test]
		public void CanCreatePlayer()
		{
			var device = new DirectSoundDevice(new DirectSoundDeviceInfo());

			device.Player.Should().Not.Be.Null();
		}

	}
}
