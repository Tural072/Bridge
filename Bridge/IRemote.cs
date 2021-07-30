using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IRemote
    {
        void OnOff(bool isEnable);

        void VolumeDown();

        void VolumeUP();

        void ChannelDown();

        void ChannelUp();

        void Mute(bool isMute);
    }
}
