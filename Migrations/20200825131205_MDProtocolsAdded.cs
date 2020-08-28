using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAIF2021.Migrations
{
    public partial class MDProtocolsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MDProtocol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    BodyTemp = table.Column<string>(nullable: true),
                    SoreThroat = table.Column<string>(nullable: true),
                    NasalCongestion = table.Column<string>(nullable: true),
                    Cough = table.Column<string>(nullable: true),
                    Headache = table.Column<string>(nullable: true),
                    Nausea = table.Column<string>(nullable: true),
                    Diarrhea = table.Column<string>(nullable: true),
                    MuscleAches = table.Column<string>(nullable: true),
                    OtherSymptoms = table.Column<string>(nullable: true),
                    OtherSymptomsDescription = table.Column<string>(nullable: true),
                    FamilySymtoms = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MDProtocol", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MDProtocol_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MDProtocol_PersonId",
                table: "MDProtocol",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MDProtocol");
        }
    }
}
