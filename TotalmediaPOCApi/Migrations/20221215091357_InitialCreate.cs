using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TotalmediaPOCApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(nullable: false),
                    CountryName = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "CountryVATRates",
                columns: table => new
                {
                    CountryVATRateId = table.Column<Guid>(nullable: false),
                    CountryVATRateValue = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryVATRates", x => x.CountryVATRateId);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { new Guid("8fc99100-6c51-4b50-b640-abb96593cb6a"), "Portugal" },
                    { new Guid("0b1e9ce5-70a5-4d61-8a09-9e9dcfd80cec"), "France" },
                    { new Guid("445ae582-533c-4a95-94de-60c4694dd220"), "United Kingdom" },
                    { new Guid("8e7ed540-a4a4-4f0a-80ba-dde9473b4f41"), "Spain" }
                });

            migrationBuilder.InsertData(
                table: "CountryVATRates",
                columns: new[] { "CountryVATRateId", "CountryId", "CountryVATRateValue" },
                values: new object[,]
                {
                    { new Guid("5b86f9ef-1d81-4f75-a013-4ef19a23fa46"), new Guid("0b1e9ce5-70a5-4d61-8a09-9e9dcfd80cec"), 5.5m },
                    { new Guid("06fff34f-0cc9-4a20-bad9-0a9111a347f2"), new Guid("0b1e9ce5-70a5-4d61-8a09-9e9dcfd80cec"), 20m },
                    { new Guid("d7dffab9-1e36-4377-a076-01aaecd38a09"), new Guid("0b1e9ce5-70a5-4d61-8a09-9e9dcfd80cec"), 10m },
                    { new Guid("bfdd0a03-40a4-42c8-87d5-7d03b15f9ad9"), new Guid("445ae582-533c-4a95-94de-60c4694dd220"), 5m },
                    { new Guid("7a238b83-5238-4ce0-828c-b38c4f577765"), new Guid("445ae582-533c-4a95-94de-60c4694dd220"), 20m },
                    { new Guid("c79d35ba-e75e-46dc-b7be-3dfed93b031a"), new Guid("8fc99100-6c51-4b50-b640-abb96593cb6a"), 6m },
                    { new Guid("777cd10f-b105-4ae1-a2a6-2743d4c74331"), new Guid("8fc99100-6c51-4b50-b640-abb96593cb6a"), 13m },
                    { new Guid("63c515d4-e4f9-40ec-a0a9-5d53221fbe7e"), new Guid("8fc99100-6c51-4b50-b640-abb96593cb6a"), 23m },
                    { new Guid("31c2d3c0-8a16-490f-b242-c568f3f6928f"), new Guid("8e7ed540-a4a4-4f0a-80ba-dde9473b4f41"), 21m },
                    { new Guid("f7484de8-856e-45e7-86bf-40ad86ed470c"), new Guid("8e7ed540-a4a4-4f0a-80ba-dde9473b4f41"), 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "CountryVATRates");
        }
    }
}
