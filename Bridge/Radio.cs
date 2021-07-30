using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Radio : IDevice
    {
        public void IsEnabled(bool isEnable)
        {
            if (isEnable == true)
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
            Console.WriteLine($"Radio is Disabled");
        }                      
        public void Enable()   
        {                      
            Console.WriteLine($"Radio is Enabled");
        }
        public void GetChannel()
        {
            double channel = 10;
            Console.WriteLine($"Radio channel :  {channel}");
        }
        public void SetChannel(double channel)
        {
            Console.WriteLine($"Radio channel : {channel}");
        }
        public void GetVolume()
        {
            double percent = 10;
            Console.WriteLine($"Radio volume : {percent}");
        }
        public void SetVolume(double percent)
        {
            Console.WriteLine($"Radio volume :  {percent}");
        }
    }
}
