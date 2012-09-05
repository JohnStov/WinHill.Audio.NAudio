namespace WinHill.Audio.NAudio.Configuration
{
    using System.Collections.Generic;
    using System.Linq;

    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    public class AsioTechnology : TechnologyBase
    {
        public AsioTechnology()
            : base("ASIO Out")
        { }

        public override IEnumerable<IDevice> Devices { get { return AsioOut.GetDriverNames().Select(n => new AsioDevice(n)); } }
    }
}