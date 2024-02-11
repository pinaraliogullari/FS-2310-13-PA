using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "84a85b24-91ae-47d9-bdfe-bc8cb97b99b6", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "9e6b4e56-9b75-42a4-941f-e4ef1b6bac2c", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2677555c-35f0-495d-8f21-3639c695010e", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "dc191ea9-ad09-48fe-aafb-361b09a5f449", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "kemaldurukan@gmail.com", true, "Kemal", "Erkek", "Durukan", false, null, "KEMALDURUKAN@GMAIL.COM", "KEMALDURUKAN", "AQAAAAIAAYagAAAAEFDEtzQWdobyRE9XzzvtDQHJafHHgNctkyysMIjuCm4nnIBZ8cZhMWkByBOykTrhhA==", "05346758734", false, "1361c75a-40a8-4adb-8e5f-617d38bb306f", false, "kemaldurukan" },
                    { "c18c17f0-5e3d-4160-8b82-054a768ab944", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "3963830d-c7a7-41e2-9eac-0dfb8eeb4a7e", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "aysenumay@gmail.com", true, "Ayşen Umay", "Kadın", "Ergül", false, null, "AYSENUMAY@GMAIL.COM", "AYSENUMAY", "AQAAAAIAAYagAAAAEN6CYb7HwqCsMi3RSUslcRoFBXz+isMlmNGn9dfG9YlJDgeU+k+OlBNaYGhJzvkgDA==", "05346758734", false, "3a9e44d0-aeec-4b7d-a09f-43ac976723e4", false, "aysenumay" },
                    { "d55d5abc-d6bf-409e-a266-89536c2babee", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "d6aa22c2-056e-40e4-aeca-6086d09bf581", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "denizfoca@gmail.com", true, "Deniz", "Erkek", "Foça", false, null, "DENIZFOCA@GMAIL.COM", "DENIZFOCA", "AQAAAAIAAYagAAAAEGyg9Lk/voxDQu9nGes81CnJLQlKQ8SnPnj8NI142aXdXOXBLZ9fnOAqRZaBZiry8A==", "05346758734", false, "0d3e1447-2292-424c-b929-4d49c0071c9e", false, "denizfoca" },
                    { "e8c8425d-5785-4a0b-8c37-34913e03bf3f", 0, "Halilpaşa Konağı Caddesi Kemeraltı Sokak No:4 D:2 Üsküdar", "İstanbul", "4ee01f54-bbef-43c2-adb6-f84e6216e433", new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "selinmete@gmail.com", true, "Selin", "Kadın", "Mete", false, null, "SELINMETE@GMAIL.COM", "SELINMETE", "AQAAAAIAAYagAAAAEP3AromVhr1ul2kC2G5lJ8NFb1me33yOZUJCeuDbhvvBw2NQNw3dailZb9H6NyLW8A==", "05387659945", false, "f50128f3-c429-4e4b-a73f-595dc92837d6", false, "selinmete" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3040), new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3060), new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3062), new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3064), new DateTime(2024, 2, 8, 20, 7, 30, 581, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3641), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3646), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3651), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 2, 8, 20, 7, 30, 582, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "CreatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 8, 20, 7, 30, 580, DateTimeKind.Local).AddTicks(6758), "d55d5abc-d6bf-409e-a266-89536c2babee" },
                    { 2, new DateTime(2024, 2, 8, 20, 7, 30, 580, DateTimeKind.Local).AddTicks(6778), "e8c8425d-5785-4a0b-8c37-34913e03bf3f" },
                    { 3, new DateTime(2024, 2, 8, 20, 7, 30, 580, DateTimeKind.Local).AddTicks(6780), "2677555c-35f0-495d-8f21-3639c695010e" },
                    { 4, new DateTime(2024, 2, 8, 20, 7, 30, 580, DateTimeKind.Local).AddTicks(6781), "c18c17f0-5e3d-4160-8b82-054a768ab944" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832", "2677555c-35f0-495d-8f21-3639c695010e" },
                    { "84a85b24-91ae-47d9-bdfe-bc8cb97b99b6", "c18c17f0-5e3d-4160-8b82-054a768ab944" },
                    { "9e6b4e56-9b75-42a4-941f-e4ef1b6bac2c", "d55d5abc-d6bf-409e-a266-89536c2babee" },
                    { "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832", "e8c8425d-5785-4a0b-8c37-34913e03bf3f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832", "2677555c-35f0-495d-8f21-3639c695010e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84a85b24-91ae-47d9-bdfe-bc8cb97b99b6", "c18c17f0-5e3d-4160-8b82-054a768ab944" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e6b4e56-9b75-42a4-941f-e4ef1b6bac2c", "d55d5abc-d6bf-409e-a266-89536c2babee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832", "e8c8425d-5785-4a0b-8c37-34913e03bf3f" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1aee6a4b-50d8-4b38-9b11-c0ccbd9b0832");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a85b24-91ae-47d9-bdfe-bc8cb97b99b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e6b4e56-9b75-42a4-941f-e4ef1b6bac2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2677555c-35f0-495d-8f21-3639c695010e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c18c17f0-5e3d-4160-8b82-054a768ab944");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d55d5abc-d6bf-409e-a266-89536c2babee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8c8425d-5785-4a0b-8c37-34913e03bf3f");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2201), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2222), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2224), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7822), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7826), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7833), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 2, 7, 21, 47, 48, 822, DateTimeKind.Local).AddTicks(7839) });
        }
    }
}
