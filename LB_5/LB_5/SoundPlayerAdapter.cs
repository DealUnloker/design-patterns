using System;
using System.Media;

namespace LB_5
{
    public class SoundPlayerAdapter : SoundPlayer, IAudioPlayer
    {
        /// <Summary> Loads the audio file. </ Summary>
        public void Load(string file)
        {
            this.SoundLocation = file;
            this.Load();
        }
    }
}
