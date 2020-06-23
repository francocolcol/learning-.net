using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.Data.EF.Migrations
{
    public partial class Studios_Creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("45ffdb54-d251-4776-bb9a-499d3b5fd3d3"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("54803936-48f3-4ea5-aa71-f1fb4cc3aab7"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("7a4a9ff4-394f-49b9-993d-b195d18c2769"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("d91406e4-bf02-4c0e-a719-6c4a44e49ee5"));

            migrationBuilder.AddColumn<Guid>(
                name: "StudioId",
                table: "Videos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "CreationDate", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("d9c734cf-76f6-4db6-839a-013ff6bbc875"), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6198), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6225), "Studio 1" },
                    { new Guid("4328e74c-d820-4f6d-8fb0-fd49a552d65d"), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6565), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6568), "Universal Studios" },
                    { new Guid("1d3e5008-5c35-4180-a898-55c5f5ca7fe8"), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6585), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6586), "Studio 3" },
                    { new Guid("bce0d965-1fe6-46e7-bc4c-94ac3628091f"), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6589), new DateTime(2020, 6, 23, 0, 33, 56, 266, DateTimeKind.Local).AddTicks(6590), "Studio 4" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "CreationDate", "DirectedBy", "Duration", "Genre", "ModifiedDate", "Name", "StudioId" },
                values: new object[,]
                {
                    { new Guid("b2619ad5-9f66-46be-b681-cac9015bd961"), new DateTime(2020, 6, 23, 0, 33, 56, 264, DateTimeKind.Local).AddTicks(4317), "Bong Joon Ho", 132, "Comedy, Drama, Trhiller", new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(2449), "Parasite", new Guid("d9c734cf-76f6-4db6-839a-013ff6bbc875") },
                    { new Guid("c7bdeb3c-d43c-439c-9291-9b3294837577"), new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3597), "Sam Mendez", 119, "Drama, War", new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3618), "1917", new Guid("4328e74c-d820-4f6d-8fb0-fd49a552d65d") },
                    { new Guid("aa9f4b38-5e3f-4fe3-b11e-3e800a66f64f"), new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3635), "Martin Scorsese", 209, "Biography, Crime, Drama", new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3637), "The Irishman", new Guid("1d3e5008-5c35-4180-a898-55c5f5ca7fe8") },
                    { new Guid("63f04373-db66-4e88-bf43-906d31888bde"), new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3641), "Quentin Tarantino", 161, "Comedy, Drama", new DateTime(2020, 6, 23, 0, 33, 56, 265, DateTimeKind.Local).AddTicks(3642), "Once Upoin a Time... In Hollywood", new Guid("1d3e5008-5c35-4180-a898-55c5f5ca7fe8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("63f04373-db66-4e88-bf43-906d31888bde"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("aa9f4b38-5e3f-4fe3-b11e-3e800a66f64f"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("b2619ad5-9f66-46be-b681-cac9015bd961"));

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: new Guid("c7bdeb3c-d43c-439c-9291-9b3294837577"));

            migrationBuilder.DropColumn(
                name: "StudioId",
                table: "Videos");

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "CreationDate", "DirectedBy", "Duration", "Genre", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7a4a9ff4-394f-49b9-993d-b195d18c2769"), new DateTime(2020, 4, 19, 20, 49, 1, 603, DateTimeKind.Local).AddTicks(9135), "Bong Joon Ho", 132, "Comedy, Drama, Trhiller", new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(925), "Parasite" },
                    { new Guid("54803936-48f3-4ea5-aa71-f1fb4cc3aab7"), new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2670), "Sam Mendez", 119, "Drama, War", new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2705), "1917" },
                    { new Guid("d91406e4-bf02-4c0e-a719-6c4a44e49ee5"), new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2720), "Martin Scorsese", 209, "Biography, Crime, Drama", new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2722), "The Irishman" },
                    { new Guid("45ffdb54-d251-4776-bb9a-499d3b5fd3d3"), new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2725), "Quentin Tarantino", 161, "Comedy, Drama", new DateTime(2020, 4, 19, 20, 49, 1, 605, DateTimeKind.Local).AddTicks(2726), "Once Upoin a Time... In Hollywood" }
                });
        }
    }
}
