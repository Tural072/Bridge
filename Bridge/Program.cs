using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            IRemote radioRemote = new RadioRemote(new Radio());
            bool isEnabled = true;
            bool isMute = false;
            radioRemote.OnOff(isEnabled);
            radioRemote.Mute(isMute);
            radioRemote.VolumeDown();
            radioRemote.VolumeUP();
            radioRemote.ChannelDown();
            radioRemote.ChannelUp();


            IRemote tvRemote = new TvRemote(new Tv());

            bool isEnabled2 = true;
            bool isMute2 = false;

            tvRemote.OnOff(isEnabled2);
            tvRemote.Mute(isMute2);
            tvRemote.VolumeDown();
            tvRemote.VolumeUP();
            tvRemote.ChannelDown();
            tvRemote.ChannelUp();


        }
    }
}
