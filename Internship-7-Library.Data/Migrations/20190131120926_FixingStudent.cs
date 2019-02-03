using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_7_Library.Data.Migrations
{
    public partial class FixingStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }
    }
}
