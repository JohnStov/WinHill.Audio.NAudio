namespace WinHill.Audio.NAudio.Configuration
{
    using WinHill.Audio.Configuration;

    public class WavePlayerConverter : IWavePlayer
    {
        private global::NAudio.Wave.IWavePlayer player;
        
        public WavePlayerConverter(global::NAudio.Wave.IWavePlayer player)
        {
            this.player = player;
        }
        
        public void Dispose()
        {
            if (player != null)
            {
                player.Dispose();
                player = null;
            }
        }

        public void Play()
        {
            if (player != null)
                player.Play();
        }

        public void Stop()
        {
            if (player != null)
                player.Stop();
        }

        public void Pause()
        {
            if (player != null)
                player.Pause();
        }

        public PlaybackState PlaybackState
        {
            get
            {
                switch (player.PlaybackState)
                {
                    case global::NAudio.Wave.PlaybackState.Stopped:
                        return PlaybackState.Stopped;
                    case global::NAudio.Wave.PlaybackState.Paused:
                        return PlaybackState.Paused;
                    case global::NAudio.Wave.PlaybackState.Playing:
                        return PlaybackState.Playing;
                    default:
                        return PlaybackState.Unknown;
                }
            }
        }
    }
}
