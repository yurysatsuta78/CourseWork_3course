using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya3kurs.Migrations
{
    /// <inheritdoc />
    public partial class ViewerAddedToVisits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ViewerFio",
                table: "visits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IsAdmin",
                table: "accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewerFio",
                table: "visits");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "accounts");
        }
    }
}
