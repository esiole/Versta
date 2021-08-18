using System;
using System.Collections.Immutable;
using Versta.Models;

namespace Versta.Data
{
    public static class SampleData
    {
        private static readonly Order[] data = {
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Санкт-Петербург",
                SenderAddress = "Невский проспект 5к2, кв. 212",
                RecipientCity = "Москва",
                RecipientAddress = "Тверская улица 6, кв. 15",
                WeightInKg = 4.123,
                DateOfReceiving = new DateTime(2021, 10, 20)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Москва",
                SenderAddress = "Тверская улица 6, кв. 15",
                RecipientCity = "Санкт-Петербург",
                RecipientAddress = "Невский проспект 5к2, кв. 212",
                WeightInKg = 15.123,
                DateOfReceiving = new DateTime(2022, 1, 11)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Волгоград",
                SenderAddress = "улица Габышева, кв. 56",
                RecipientCity = "Москва",
                RecipientAddress = "ул. Серёгина 19, кв. 103",
                WeightInKg = 16.789,
                DateOfReceiving = new DateTime(2021, 11, 21)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Санкт-Петербург",
                SenderAddress = "ул. Якубовичка 898, кв. 11",
                RecipientCity = "Волгоград",
                RecipientAddress = "ул. Богданова 32, кв. 567",
                WeightInKg = 24.98,
                DateOfReceiving = new DateTime(2021, 09, 18)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Волгоград",
                SenderAddress = "пер. Ващенко 19, кв. 789",
                RecipientCity = "Санкт-Петербург",
                RecipientAddress = "улица Труда 89, кв. 313",
                WeightInKg = 11.4,
                DateOfReceiving = new DateTime(2022, 2, 11)
            },
            new Order()
            {
                Id = Guid.NewGuid(),
                SenderCity = "Волгоград",
                SenderAddress = "ул. Полухина, кв. 321",
                RecipientCity = "Владивосток",
                RecipientAddress = "Читинская улица 1234, кв. 52",
                WeightInKg = 18,
                DateOfReceiving = new DateTime(2021, 12, 9)
            }
        };

        public static readonly ImmutableList<Order> Data = ImmutableList.CreateRange(data);
    }
}
