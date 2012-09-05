namespace WinHill.Audio.Configuration
{
    using NAudio.Wave;

    public class DirectSoundDevice : DeviceBase
    {
        private readonly DirectSoundDeviceInfo info;

        public DirectSoundDevice(DirectSoundDeviceInfo info)
        {
            this.info = info;
            Player = new DirectSoundOut(info.Guid);
        }

        public override string Name { get { return info.Description; } }
    }
}