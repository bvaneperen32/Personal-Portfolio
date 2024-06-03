using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class GitHubSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconClass",
                value: "fa fa-instagram");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconClass",
                value: "fa fa-linkedin");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconClass",
                value: "fa fa-twitter");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconClass", "Platform" },
                values: new object[] { "fa fa-github", "GitHub" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 1,
                column: "IconClass",
                value: "TODO");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 2,
                column: "IconClass",
                value: "TODO");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 3,
                column: "IconClass",
                value: "TODO");

            migrationBuilder.UpdateData(
                table: "SocialMedia",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconClass", "Platform" },
                values: new object[] { "TODO", "Facebook" });
        }
    }
}
