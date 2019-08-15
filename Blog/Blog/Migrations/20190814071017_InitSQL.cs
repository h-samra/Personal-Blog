using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class InitSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Summury",
                table: "Posts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Summury",
                table: "Posts",
                nullable: true);
        }
    }
}
