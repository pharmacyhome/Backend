using System.Linq;
using System;

namespace PharmacyHome.Memory
{
    public class MedicineRepository : IMedicineRepository

    {
        private readonly Medicine[] medicines = new[]
        {
            new Medicine(1, "Омепразол", "Омез", "03.2022", "Твердые желатиновые непрозрачные капсулы размером №3, " +
                "с желтым корпусом, светло-фиолетовой крышечкой и маркировкой черного цвета «OMEZ 10» на крышечке и " +
                "корпусе капсулы. Содержимое капсулы — гранулы от почти белого до светло-желтого цвета.", 20, 30),
            new Medicine(2, "Парацетамол", "Терафлю", "05.2022", "Порошок для приготовления раствора для приема внутрь" +
                " (лимонный) белого цвета с желтыми вкраплениями, сыпучий, гранулированный, без посторонних частиц," +
                " с цитрусовым запахом; допускается наличие мягких комков.", 325, 10),
            new Medicine(3, "Цинк", "Зинерит", "01.2023", "Зинерит – эритромицин-цинковый комплекс. Оказывает " +
                "противовоспалительное, противомикробное действие и комедонолитическое действие.", 30, 1)
        };

        public Medicine[] GetAllByExpirationDate(string expirationDate)
        {
            throw new NotImplementedException();
        }

        public Medicine[] GetAllByTitle(string titlePart)
        {
            return medicines.Where(m => m.Title.Contains(titlePart))
                             .ToArray();
        }

        public Medicine GetById(int id)
        {
            return medicines.Single(m => m.Id == id);
        }
    }
}
