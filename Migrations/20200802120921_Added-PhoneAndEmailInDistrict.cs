using Microsoft.EntityFrameworkCore.Migrations;

namespace DAIF2021.Migrations
{
    public partial class AddedPhoneAndEmailInDistrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "District",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "District",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "District");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "District");
        }
    }
}
