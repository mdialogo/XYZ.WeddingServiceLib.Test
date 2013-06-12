using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using XYZ.WeddingServiceLib;

namespace XYZ.WeddingServiceLib.Test
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void TestWeddingService()
        {
            IEventService weddingService = new WeddingService();

            Assert.That(weddingService.Cost, Is.EqualTo(10000));
        }

        [Test]
        public void TestPhotographyService()
        {
            IEventService weddingService = new PhotographyService(new WeddingService());

            Assert.That(weddingService.Cost, Is.EqualTo(25000));
        }

        [Test]
        public void TestCateringService()
        {
            IEventService weddingService = new CateringService(new WeddingService());

            Assert.That(weddingService.Cost, Is.EqualTo(60000));
        }

        [Test]
        public void TestCaterAndPhotoService()
        {
            IEventService weddingService = new WeddingService();
            weddingService = new CateringService(weddingService);
            weddingService = new PhotographyService(weddingService);

            Assert.That(weddingService.Cost, Is.EqualTo(75000));
        }

        [Test]
        public void TestSeminarService()
        {
            IEventService seminarService = new SeminarService();

            Assert.That(seminarService.Cost, Is.EqualTo(5000));
        }

        [Test]
        public void TestSeminarServiceWithPhotography_Catering()
        {
            IEventService seminarService = new SeminarService(); //5000
            seminarService = new PhotographyService(seminarService); //15000
            seminarService = new CateringService(seminarService); //50000

            Assert.That(seminarService.Cost, Is.EqualTo(70000));
        }
    }
}
