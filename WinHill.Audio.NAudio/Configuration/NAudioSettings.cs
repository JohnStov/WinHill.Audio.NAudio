namespace WinHill.Audio.NAudio.Configuration
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    public class NAudioSettings : AudioSettings
    {
        private static readonly List<ITechnology> AvailableTechnologies = new List<ITechnology>();

        static NAudioSettings()
        {
            if (WaveOut.DeviceCount > 0)
                AvailableTechnologies.Add(new WaveOutTechnology());

            Contract.Assume(DirectSoundOut.Devices != null);
            if (DirectSoundOut.Devices.Any())
                AvailableTechnologies.Add(new DirectSoundTechnology());

            if (AsioOut.isSupported())
                AvailableTechnologies.Add(new AsioTechnology());

            Contract.Assume(Environment.OSVersion != null);
            Contract.Assume(Environment.OSVersion.Version != null);
            if (Environment.OSVersion.Version.Major >= 6)
                AvailableTechnologies.Add(new WasapiTechnology());
        }
        
        protected override IEnumerable<ITechnology> GetTechnologies()
        {
            return AvailableTechnologies;
        }
    }
}