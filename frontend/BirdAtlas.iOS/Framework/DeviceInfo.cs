using BirdAtlas.Framework;
using BirdAtlas.iOS.Framework;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfo))]
namespace BirdAtlas.iOS.Framework
{
    public class DeviceInfo : IDeviceInfo
    {
        public float StatusbarHeight => (float)UIApplication.SharedApplication.StatusBarFrame.Size.Height;
    }
}