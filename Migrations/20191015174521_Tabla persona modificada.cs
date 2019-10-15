using Microsoft.EntityFrameworkCore.Migrations;

namespace RedPepper.API.Migrations
{
    public partial class Tablapersonamodificada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Personas",
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(char),
                oldMaxLength: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "Sexo",
                table: "Personas",
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1,
                oldNullable: true);
        }
    }
}
