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
    }
}
