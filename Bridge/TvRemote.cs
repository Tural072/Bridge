using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class TvRemote : IRemote
    {
        public IDevice Device { get; set; }
        double percent = 100;
        double channel = 10;
        public TvRemote(IDevice _device)
        {
            Device = _device;
        }
        public void OnOff(bool IsEnable)
        {

            Device.IsEnabled(IsEnable);
        }
        public void VolumeDown()
        {
            percent--;
            Device.SetVolume(percent);
        }
        public void VolumeUP()
        {
            percent++;
            Device.SetVolume(percent);
        }
        public void ChannelDown()
        {
            channel--;
            Device.SetVolume(channel);
        }
        public void ChannelUp()
        {
            channel++;
            Device.SetVolume(channel);
        }
        public void Mute(bool isMute)
        {
            Console.WriteLine($"TV Mute is {isMute}");
        }
    }
}
