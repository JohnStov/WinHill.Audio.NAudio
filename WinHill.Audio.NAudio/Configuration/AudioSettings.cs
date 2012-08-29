namespace WinHill.Audio.NAudio
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;

    using WinHill.Audio.Configuration;
    using WinHill.Audio.NAudio.Configuration;

    using global::NAudio.Wave;

    public class AudioSettings : AudioSettingsBase
    {
        protected override IEnumerable<ITechnology> GetTechnologies()
        {
            if (WaveOut.DeviceCount > 0)
                yield return new WaveOutTechnology();

            Contract.Assume(DirectSoundOut.Devices != null);
            if (DirectSoundOut.Devices.Any())
                yield return new DirectSoundTechnology();

            if (AsioOut.isSupported())
                yield return new AsioTechnology();

            Contract.Assume(Environment.OSVersion != null);
            Contract.Assume(Environment.OSVersion.Version != null);
            if (Environment.OSVersion.Version.Major >= 6)
                yield return new WasapiTechnology();
        }
    }
}
