using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship_7_Library.Data.Migrations
{
    public partial class BooksEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfBooks",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBooks",
                table: "Books");
        }
    }
}
