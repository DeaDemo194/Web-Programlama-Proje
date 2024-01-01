using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Programlama.Data.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Planes_PlaneId",
                table: "Seat");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "Seat",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Routes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DidGetAppointed",
                table: "Planes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Routes_PlaneId",
                table: "Routes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Planes_PlaneId",
                table: "Routes",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Planes_PlaneId",
                table: "Seat",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Planes_PlaneId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Planes_PlaneId",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Routes_PlaneId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "DidGetAppointed",
                table: "Planes");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneId",
                table: "Seat",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Planes_PlaneId",
                table: "Seat",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
