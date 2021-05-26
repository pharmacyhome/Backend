using System;
using Xunit;

namespace Medicine.Tests
{
    public class MedicineTests
    {
        [Fact]
        public void IsExpirationDate_WithNull_ReturnFalse()
        {
            bool actual = PharmacyHome.Medicine.IsExpirationDate(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsExpirationDate_WithBlankString_ReturnFalse()
        {
            bool actual = PharmacyHome.Medicine.IsExpirationDate("    ");

            Assert.False(actual);
        }

        [Fact]
        public void IsExpirationDate_WithInvalidExpirationDate_ReturnFalse()
        {
            bool actual = PharmacyHome.Medicine.IsExpirationDate("02.2");

            Assert.False(actual);
        }
    }
}
