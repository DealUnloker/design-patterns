using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_5
{
    interface IAudioPlayer
    {
        void Load(string file);
        void Play();
    }
}
