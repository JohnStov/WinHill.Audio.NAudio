namespace WinHill.Audio.NAudio.Configuration
{
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Collections.Generic;

    using WinHill.Audio.Configuration;

    using global::NAudio.CoreAudioApi;

    public class WasapiTechnology : TechnologyBase
    {
        public WasapiTechnology()
            : base("WASAPI Out")
        {}

        public override IEnumerable<IDevice> Devices
        {
            get
            {
                Contract.Ensures(Contract.Result<IEnumerable<IDevice>>() != null);
                return new MMDeviceEnumerator()
                    .EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)
                    .Select(d => new WasapiDevice(d));
            }
        }
    }
}
