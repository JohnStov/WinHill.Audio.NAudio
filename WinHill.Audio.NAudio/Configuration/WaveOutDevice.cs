namespace WinHill.Audio.Configuration
{
    using System;

    using NAudio.Wave;

    public class WaveOutDevice : DeviceBase
    {
        private readonly WaveOutCapabilities capabilities;

        public WaveOutDevice(int id, WaveOutCapabilities capabilities)
        {
            this.capabilities = capabilities;
            Player = new WaveOut { DeviceNumber = id };
        }

        public override string Name { get { return capabilities.ProductName; } }
    }
}