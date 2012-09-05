namespace WinHill.Audio.NAudio.Configuration
{
    using System.Collections.Generic;
    using System.Linq;

    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    public class DirectSoundTechnology : TechnologyBase
    {
        public DirectSoundTechnology()
            : base("DirectSound")
        {}

        public override IEnumerable<IDevice> Devices { get { return DirectSoundOut.Devices.Select(d => new DirectSoundDevice(d)); } }
    }
}