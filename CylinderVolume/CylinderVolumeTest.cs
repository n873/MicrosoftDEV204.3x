using Shape;
using System;
using Xunit;

namespace CylinderVolume
{
    public class CylinderVolumeTest
    {
        private readonly Cyclinder Cylinder;

        private readonly decimal Radius;
        private readonly decimal Height;
        private readonly decimal Volume;

        public CylinderVolumeTest()
        {
            var random = new Random();
            Radius = random.Next(1, 20);
            Height = random.Next(1, 40);
            Volume = Radius * Height;

            Cylinder = new Cyclinder(Radius, Height);
        }

        [Fact]
        public void CalculateCylinderVolume()
        {
            Assert.Equal(Volume, Cylinder.Volume());
        }
    }
}
