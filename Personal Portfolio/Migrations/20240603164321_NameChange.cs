using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Personal_Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class NameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia");

            migrationBuilder.RenameTable(
                name: "SocialMedia",
                newName: "SocialMediaInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMediaInfos",
                table: "SocialMediaInfos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMediaInfos",
                table: "SocialMediaInfos");

            migrationBuilder.RenameTable(
                name: "SocialMediaInfos",
                newName: "SocialMedia");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMedia",
                table: "SocialMedia",
                column: "Id");
        }
    }
}
