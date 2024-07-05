using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kursovaya3kurs.Migrations
{
    /// <inheritdoc />
    public partial class addedchedtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScheduleTime",
                table: "paidVisits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScheduleTime",
                table: "paidVisits");
        }
    }
}
