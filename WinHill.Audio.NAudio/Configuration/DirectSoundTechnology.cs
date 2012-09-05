namespace WinHill.Audio.Configuration
{
    using System.Collections.Generic;
    using System.Linq;

    using NAudio.Wave;

    public class DirectSoundTechnology : TechnologyBase
    {
        public DirectSoundTechnology()
            : base("DirectSound")
        {}

        public override IEnumerable<IDevice> Devices { get { return DirectSoundOut.Devices.Select(d => new DirectSoundDevice(d)); } }
    }
}