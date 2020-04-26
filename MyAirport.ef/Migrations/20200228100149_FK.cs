using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PBZN_SSU.MyAirport.EF.Migrations
{
    /// <summary>
    /// Migration
    /// </summary>
    public partial class FK : Migration
    {
        /// <summary>
        /// Upgrade les objets dans leur nouvelle version
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code_Ita",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "Date_Creation",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "id_Vol",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "BagageId",
                table: "Bagages",
                newName: "BagageID");

            migrationBuilder.AlterColumn<string>(
                name: "Classe",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<string>(
                name: "CodeIata",
                table: "Bagages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Bagages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VolID",
                table: "Bagages",
                nullable: false,
                defaultValue: 0);
        }
        /// <summary>
        /// Restaure les objets dans leur version précédente
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeIata",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Bagages");

            migrationBuilder.DropColumn(
                name: "VolID",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "BagageID",
                table: "Bagages",
                newName: "BagageId");

            migrationBuilder.AlterColumn<string>(
                name: "Classe",
                table: "Bagages",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code_Ita",
                table: "Bagages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Creation",
                table: "Bagages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "id_Vol",
                table: "Bagages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
