using Microsoft.EntityFrameworkCore.Migrations;

namespace Parks.Migrations
{
    public partial class updateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Acres",
                table: "Parks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acres",
                table: "Parks");
        }
    }
}
