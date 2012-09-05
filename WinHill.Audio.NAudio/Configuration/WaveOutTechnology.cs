namespace WinHill.Audio.Configuration
{
    using System.Collections.Generic;

    using NAudio.Wave;

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