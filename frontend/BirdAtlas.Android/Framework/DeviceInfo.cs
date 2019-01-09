using BirdAtlas.Droid.Framework;
using BirdAtlas.Framework;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfo))]
namespace BirdAtlas.Droid.Framework
{
    public class DeviceInfo : IDeviceInfo
    {
        public float StatusbarHeight => 0;
    }
}