using Moq;
using PharmacyHome;
using System;
using System.Collections.Generic;
using Xunit;

namespace Medicine.Tests
{
    public class MedicineServiceTest
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByExpirationDate()
        {
            var medicineRepositoryStub = new Mock<IMedicineRepository>();
            medicineRepositoryStub.Setup(x => x.GetAllByExpirationDate(It.IsAny<string>()))
                                   .Returns(new[] { new PharmacyHome.Medicine(1,"","","") });

            medicineRepositoryStub.Setup(x => x.GetAllByTitle(It.IsAny<string>()))
                                  .Returns(new[] { new PharmacyHome.Medicine(2, "", "", "") });

            var medicineService = new MedicineService(medicineRepositoryStub.Object);
            var validDate = "02.02.2021";

            var actual = medicineService.GetAllByQuery(validDate);

            Assert.Collection(actual, medicine => Assert.Equal(1, medicine.Id));
        }

        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByTitle()
        {
            var medicineRepositoryStub = new Mock<IMedicineRepository>();
            medicineRepositoryStub.Setup(x => x.GetAllByExpirationDate(It.IsAny<string>()))
                                   .Returns(new[] { new PharmacyHome.Medicine(1, "", "", "") });

            medicineRepositoryStub.Setup(x => x.GetAllByTitle(It.IsAny<string>()))
                                  .Returns(new[] { new PharmacyHome.Medicine(2, "", "", "") });

            var medicineService = new MedicineService(medicineRepositoryStub.Object);
            var validTitle = "Омез";

            var actual = medicineService.GetAllByQuery(validTitle);

            Assert.Collection(actual, medicine => Assert.Equal(2, medicine.Id));
        }
    }
}
