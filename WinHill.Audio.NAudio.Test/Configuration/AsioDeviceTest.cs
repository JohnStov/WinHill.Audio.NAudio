using System.Linq;
using Should.Fluent;
using WinHill.Audio.Configuration;
using WinHill.Audio.NAudio.Configuration;

namespace WinHill.Audio.NAudio.Test.Configuration
{
    using NUnit.Framework;

    [TestFixture]
    public class AsioDeviceTest
    {
        
        [Test]
        [RequiresSTA]
        [Ignore]
        public void CanCreateDeviceWithName()
        {
            var tech = new AsioTechnology();
            if (tech.Devices.Any())
            {
                var name = tech.Devices.First().Name;
                var device = new AsioDevice(name);
                
                device.Name.Should().Equal(name);
            }

        }
    }
}
