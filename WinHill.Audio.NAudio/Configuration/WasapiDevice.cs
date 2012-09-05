namespace WinHill.Audio.Configuration
{
    using System.Diagnostics.Contracts;

    using WinHill.Audio.NAudio.Configuration;

    using global::NAudio.CoreAudioApi;
    using global::NAudio.Wave;

    public class WasapiDevice : DeviceBase
    {
        private readonly MMDevice device;
        private readonly IWavePlayer player;

        public WasapiDevice(MMDevice device)
        {
            this.device = device;
            player = new WavePlayerConverter(new WasapiOut(device, AudioClientShareMode.Exclusive, false, 100));
        }

        public override string Name 
        { 
            get
            {
                Contract.Assume(!string.IsNullOrWhiteSpace(device.FriendlyName));
                Contract.Assume(!string.IsNullOrWhiteSpace(device.DeviceFriendlyName));
                return string.Format("{0} ({1})", device.FriendlyName, device.DeviceFriendlyName);
            } 
        }
    }
}