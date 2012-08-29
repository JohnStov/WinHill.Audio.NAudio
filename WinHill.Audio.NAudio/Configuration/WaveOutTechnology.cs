namespace WinHill.Audio.NAudio.Configuration
{
    using System.Collections.Generic;

    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    public class WaveOutTechnology : TechnologyBase
    {
        public WaveOutTechnology()
            : base("WaveOut")
        {}

        public override IEnumerable<IDevice> Devices
        {
            get
            {
                for (var i = 0; i < WaveOut.DeviceCount; ++i)
                    yield return new WaveOutDevice(i, WaveOut.GetCapabilities(i));
            }
        }
    }

}