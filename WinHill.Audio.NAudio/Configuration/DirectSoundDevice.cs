namespace WinHill.Audio.NAudio.Configuration
{
    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    public class DirectSoundDevice : DeviceBase
    {
        private readonly DirectSoundDeviceInfo info;

        public DirectSoundDevice(DirectSoundDeviceInfo info)
        {
            this.info = info;
            Player = new WavePlayerAdapter(new DirectSoundOut(info.Guid));
        }

        public override string Name { get { return info.Description; } }
    }
}