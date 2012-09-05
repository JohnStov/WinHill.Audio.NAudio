namespace WinHill.Audio.NAudio.Configuration
{
    using Audio.Configuration;

    using global::NAudio.Wave;

    public class AsioDevice : DeviceBase
    {
        private readonly string name;

        public AsioDevice(string name)
        {
            this.name = name;
            Player = new WavePlayerConverter(new AsioOut(name));
        }

        public override string Name { get { return name; } }
    }
}