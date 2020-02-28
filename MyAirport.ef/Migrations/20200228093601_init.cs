using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PBZN.MyAirport.ef.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_Vol = table.Column<int>(nullable: false),
                    Code_Ita = table.Column<string>(nullable: true),
                    Date_Creation = table.Column<DateTime>(nullable: false),
                    Classe = table.Column<string>(nullable: false),
                    Prioritaire = table.Column<bool>(nullable: false),
                    Sta = table.Column<string>(nullable: false),
                    Ssur = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Escale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageId);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cie = table.Column<string>(nullable: true),
                    Lig = table.Column<string>(nullable: true),
                    Dhc = table.Column<DateTime>(nullable: false),
                    Pkg = table.Column<string>(nullable: true),
                    Imm = table.Column<string>(nullable: true),
                    Pax = table.Column<int>(nullable: false),
                    Des = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.VolId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vols");
        }
    }
}
