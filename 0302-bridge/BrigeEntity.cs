using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0302_bridge
{
    public interface Device
    {

        bool IsEnable();

        void Enable();

        void Disable();

        int GetVolume();

        void SetVolume(int volume);

        int GetChannel();

        void SetChannel(int channel);
    }

    public class Remote
    {
        public Device Device { get; set; }

        public Remote(Device device)
        {
            Device = device;
        }

        public void TogglePower()
        {
            if (Device.IsEnable())
            {
                Device.Disable();
            }
            else
            {
                Device.Enable();
            }
        }

        public void VolumeDow()
        {
            var old = Device.GetVolume();
            Device.SetVolume(old - 1);
        }

        public void VolumeUp()
        {
            var old = Device.GetVolume();
            Device.SetVolume(old + 1);
        }

        public void ChannelDown()
        {
            var old = Device.GetChannel();
            Device.SetChannel(old - 1);
        }

        public void ChannelUp()
        {
            var old = Device.GetChannel();
            Device.SetChannel(old + 1);
        }
    }

    public class AdvanceRemote: Remote
    {
        public AdvanceRemote(Device device) : base(device)
        {
        }

        public void Mute()
        {
            Device.SetVolume(0);
        }
    }

    public class Radio : Device
    {

        public bool EnableStatus { get; set; } = false;

        public int Volume { get; set; } = 5;

        public int Channel { get; set; } = 1;

        public void Enable()
        {
            EnableStatus = true;
        }

        public void Disable()
        {
            EnableStatus = false;
        }

        public int GetChannel()
        {
            return Channel;
        }

        public int GetVolume()
        {
            return Volume;
        }

        public bool IsEnable()
        {
            return EnableStatus;
        }

        public void SetChannel(int channel)
        {
            this.Channel = channel;
        }

        public void SetVolume(int volume)
        {
            this.Volume = volume;
        }

        public override string ToString()
        {
            return $"{EnableStatus} volume {Volume} channel {Channel}";
        }
    }
}
