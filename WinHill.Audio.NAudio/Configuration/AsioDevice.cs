using NAudio.Wave;

namespace WinHill.Audio.NAudio.Configuration
{
    using Audio.Configuration;

    public class AsioDevice : DeviceBase
    {
        private readonly string name;

        public AsioDevice(string name)
        {
            this.name = name;
            Player = new AsioOut(name);
        }

        public override string Name { get { return name; } }
    }
}