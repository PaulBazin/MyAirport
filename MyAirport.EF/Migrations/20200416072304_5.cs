using Microsoft.EntityFrameworkCore.Migrations;

namespace PBZN_SSU.MyAirport.EF.Migrations
{
    /// <summary>
    /// Migration
    /// </summary>
    public partial class _5 : Migration
    {
        /// <summary>
        /// Upgrade les objets dans leur nouvelle version 
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolID",
                table: "Bagages",
                newName: "VolId");

            migrationBuilder.RenameColumn(
                name: "BagageID",
                table: "Bagages",
                newName: "BagageId");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolID",
                table: "Bagages",
                newName: "IX_Bagages_VolId");

            migrationBuilder.AlterColumn<int>(
                name: "Pax",
                table: "Vols",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Sta",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<bool>(
                name: "Prioritaire",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <summary>
        /// Restaure les objets dans leur version précédente
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.RenameColumn(
                name: "VolId",
                table: "Bagages",
                newName: "VolID");

            migrationBuilder.RenameColumn(
                name: "BagageId",
                table: "Bagages",
                newName: "BagageID");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                newName: "IX_Bagages_VolID");

            migrationBuilder.AlterColumn<int>(
                name: "Pax",
                table: "Vols",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolID",
                table: "Bagages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sta",
                table: "Bagages",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Prioritaire",
                table: "Bagages",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolID",
                table: "Bagages",
                column: "VolID",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
