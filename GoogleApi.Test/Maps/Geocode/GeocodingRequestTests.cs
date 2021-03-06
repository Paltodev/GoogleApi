using System;
using GoogleApi.Entities.Maps.Geocode.Request;
using NUnit.Framework;

namespace GoogleApi.Test.Maps.Geocode
{
    [TestFixture]
    public class GeocodingRequestTests : BaseTest
    {
        [Test]
        public void ConstructorDefaultTest()
        {
            var request = new GeocodingRequest();

            Assert.IsTrue(request.IsSsl);
        }

        [Test]
        public void GeocodingWhenAddressAndLocationIsNullTest()
        {
            var request = new GeocodingRequest();
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var parameters = request.GetQueryStringParameters();
                Assert.IsNull(parameters);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(exception.Message, "Location, PlaceId or Address is required");
        }

        [Test]
        public void GeocodingWhenPlaceIdAndKeyIsNullTest()
        {
            var request = new GeocodingRequest { PlaceId = "test" };
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var parameters = request.GetQueryStringParameters();
                Assert.IsNull(parameters);
            });

            Assert.IsNotNull(exception);
            Assert.AreEqual(exception.Message, "Key is required, when using PlaceId");
        }

        [Test]
        public void SetIsSslTest()
        {
            var exception = Assert.Throws<NotSupportedException>(() => new GeocodingRequest
            {
                IsSsl = false
            });
            Assert.AreEqual("This operation is not supported, Request must use SSL", exception.Message);
        }
    }
}