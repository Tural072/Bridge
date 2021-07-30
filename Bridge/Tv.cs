using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Tv : IDevice
    {
        public void IsEnabled(bool IsEnable)
        {
            if (IsEnable == true)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }
        public void Disable()
        {
            Console.WriteLine($"TV is Disabled");
        }                       
        public void Enable()    
        {                       
            Console.WriteLine($"TV is Enabled");
        }
        public void GetChannel()
        {
            double channel = 10;
            Console.WriteLine($"TV Channel {channel}");
        }
        public void SetChannel(double channel)
        {
            Console.WriteLine($"TV Channel {channel}");
        }
        public void GetVolume()
        {
            double percent = 10;
            Console.WriteLine($"TV Volume : {percent}");
        }
        public void SetVolume(double percent)
        {
            Console.WriteLine($"TV Volume : {percent}");
        }
    }
}
