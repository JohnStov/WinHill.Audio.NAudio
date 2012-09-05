namespace WinHill.Audio.NAudio.Test.Configuration
{
    using NUnit.Framework;
    using Should.Fluent;

    using WinHill.Audio.NAudio.Configuration;

    using global::NAudio.Wave;

    [TestFixture]
    public class WaveOutDeviceTest
    {
        [Test]
        public void CanCreateDevice()
        {
            var device = new WaveOutDevice(0, new WaveOutCapabilities());

            device.Should().Not.Be.Null();
            device.Player.Should().Not.Be.Null();
            
            device.Dispose();
        }

        [Test]
        public void CanCreatePlayer()
        {
            var device = new WaveOutDevice(0, new WaveOutCapabilities());

            device.Player.Should().Not.Be.Null();

            device.Dispose();
        }
    }
}
