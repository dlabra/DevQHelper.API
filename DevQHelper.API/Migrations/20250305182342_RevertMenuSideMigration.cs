using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevQHelper.API.Migrations
{
    /// <inheritdoc />
    public partial class RevertMenuSideMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItemCategory");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "SideMenu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
