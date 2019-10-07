using Microsoft.EntityFrameworkCore.Migrations;

namespace RedPepper.API.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "Personas",
                maxLength: 17,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "Personas",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 17,
                oldNullable: true);
        }
    }
}
