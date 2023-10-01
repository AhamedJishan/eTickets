using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eTicket.Migrations
{
    public partial class StartDate_NameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StarDate",
                table: "Movies",
                newName: "StartDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "StarDate");
        }
    }
}
