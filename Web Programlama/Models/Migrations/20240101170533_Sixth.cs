using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Programlama.Data.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customer",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customer");
        }
    }
}
