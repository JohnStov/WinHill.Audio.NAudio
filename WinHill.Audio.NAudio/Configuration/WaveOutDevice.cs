namespace WinHill.Audio.Configuration
{
    using WinHill.Audio.NAudio.Configuration;

    using global::NAudio.Wave;

    public class WaveOutDevice : DeviceBase
    {
        private readonly WaveOutCapabilities capabilities;

        public WaveOutDevice(int id, WaveOutCapabilities capabilities)
        {
            this.capabilities = capabilities;
            Player = new WavePlayerConverter(new WaveOut { DeviceNumber = id });
        }

        public override string Name { get { return capabilities.ProductName; } }
    }
}