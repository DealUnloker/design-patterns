namespace LB_5
{
    class App
    {
        private IAudioPlayer _player = new SoundPlayerAdapter();
        public void NotifyUser(int messageCode)
        {
            string wavFile = string.Empty;

            if (!string.IsNullOrEmpty(wavFile))
            {
                this._player.Load(wavFile);
                this._player.Play();
            }
        }
    }
}
