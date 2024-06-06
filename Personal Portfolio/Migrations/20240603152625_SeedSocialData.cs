using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Personal_Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class SeedSocialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialMedia",
                columns: new[] { "Id", "IconClass", "Platform", "Url" },
                values: new object[,]
                {
                    { 1, "TODO", "Instagram", "TODO" },
                    { 2, "TODO", "LinkedIn", "TODO" },
                    { 3, "TODO", "Twitter", "TODO" },
                    { 4, "TODO", "Facebook", "TODO" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
