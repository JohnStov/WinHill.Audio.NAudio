using WinHill.Audio.NAudio.Configuration;

namespace WinHill.Audio.Configuration
{
    using System.Collections.Generic;
    using System.Linq;

    using NAudio.Wave;

    public class AsioTechnology : TechnologyBase
    {
        public AsioTechnology()
            : base("ASIO Out")
        { }

        public override IEnumerable<IDevice> Devices { get { return AsioOut.GetDriverNames().Select(n => new AsioDevice(n)); } }
    }
}