using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVP_Agenda.Migrations
{
    /// <inheritdoc />
    public partial class RefactorScheduleItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrition",
                table: "ScheduleItems");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ScheduleItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ScheduleItems");

            migrationBuilder.AddColumn<string>(
                name: "Descrition",
                table: "ScheduleItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
