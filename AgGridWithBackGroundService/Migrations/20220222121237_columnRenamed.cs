using Microsoft.EntityFrameworkCore.Migrations;

namespace AgGridWithBackGroundService.Migrations
{
    public partial class columnRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Application_Status",
                table: "EmergencyConnectivityFund",
                newName: "ApplicationStatus");

            migrationBuilder.RenameColumn(
                name: "ApplicationNusmber",
                table: "EmergencyConnectivityFund",
                newName: "ApplicationNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApplicationStatus",
                table: "EmergencyConnectivityFund",
                newName: "Application_Status");

            migrationBuilder.RenameColumn(
                name: "ApplicationNumber",
                table: "EmergencyConnectivityFund",
                newName: "ApplicationNusmber");
        }
    }
}
