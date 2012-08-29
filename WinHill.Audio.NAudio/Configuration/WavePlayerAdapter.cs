namespace WinHill.Audio.NAudio.Configuration
{
    using WinHill.Audio.Configuration;

    using global::NAudio.Wave;

    using PlaybackState = WinHill.Audio.Configuration.PlaybackState;

    class WavePlayerAdapter : IPlayback
    {
        private IWavePlayer player;

        public WavePlayerAdapter(IWavePlayer player)
        {
            this.player = player;
        }

        public PlaybackState PlaybackState
        {
            get
            {
                if (player != null)
                    switch (player.PlaybackState)
                    {
                        case global::NAudio.Wave.PlaybackState.Stopped:
                            return PlaybackState.Stopped;

                        case global::NAudio.Wave.PlaybackState.Paused:
                            return PlaybackState.Paused;

                        case global::NAudio.Wave.PlaybackState.Playing:
                            return PlaybackState.Running;
                    };

                return PlaybackState.Unknown;
            }
        }

        public void Start()
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

        public void Dispose()
        {
            if (player != null)
                player.Dispose();
            player = null;
        }
    }
}
