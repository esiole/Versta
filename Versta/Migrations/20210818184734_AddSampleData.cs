using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Versta.Migrations
{
    public partial class AddSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateOfReceiving", "RecipientAddress", "RecipientCity", "SenderAddress", "SenderCity", "WeightInKg" },
                values: new object[,]
                {
                    { new Guid("8802b717-6e18-4487-b904-1f6d2cc7c784"), new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Тверская улица 6, кв. 15", "Москва", "Невский проспект 5к2, кв. 212", "Санкт-Петербург", 4.1230000000000002 },
                    { new Guid("983d5a87-e555-4175-b724-7403865b799b"), new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Невский проспект 5к2, кв. 212", "Санкт-Петербург", "Тверская улица 6, кв. 15", "Москва", 15.122999999999999 },
                    { new Guid("8d8e8607-5268-4752-83bf-5d88a66986c2"), new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ул. Серёгина 19, кв. 103", "Москва", "улица Габышева, кв. 56", "Волгоград", 16.789000000000001 },
                    { new Guid("40c75d95-9a41-4c37-907d-9d6bd88e1196"), new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ул. Богданова 32, кв. 567", "Волгоград", "ул. Якубовичка 898, кв. 11", "Санкт-Петербург", 24.98 },
                    { new Guid("c1e2b3e5-bc76-4c8f-bb61-a77569c64dff"), new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "улица Труда 89, кв. 313", "Санкт-Петербург", "пер. Ващенко 19, кв. 789", "Волгоград", 11.4 },
                    { new Guid("45c195f4-4c39-491c-8f68-48ef9fb86c6d"), new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Читинская улица 1234, кв. 52", "Владивосток", "ул. Полухина, кв. 321", "Волгоград", 18.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("40c75d95-9a41-4c37-907d-9d6bd88e1196"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("45c195f4-4c39-491c-8f68-48ef9fb86c6d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8802b717-6e18-4487-b904-1f6d2cc7c784"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8d8e8607-5268-4752-83bf-5d88a66986c2"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("983d5a87-e555-4175-b724-7403865b799b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c1e2b3e5-bc76-4c8f-bb61-a77569c64dff"));
        }
    }
}
