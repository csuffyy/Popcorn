﻿using System;
using System.Windows.Media.Imaging;
using NUnit.Framework;
using Popcorn.Converters;

namespace Popcorn.Tests.Converters
{
    [TestFixture]
    public class UriToCachedImageConverterTest
    {
        private StringToUriConverter _converter;

        [OneTimeSetUp]
        public void InitializeConverter()
        {
            _converter = new StringToUriConverter();
        }

        [Test]
        public void Convert_SimpleValue_ReturnsMultipliedValueWithRatio()
        {
            var value = "http://www.google.com/";

            var result = _converter.Convert(value, null, null, null);
            Assert.That(result, Is.TypeOf<Uri>());

            var image = result as Uri;
            Assert.AreEqual(image.OriginalString, value);
        }
    }
}