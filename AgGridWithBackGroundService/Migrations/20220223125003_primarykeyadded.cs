using Microsoft.EntityFrameworkCore.Migrations;

namespace AgGridWithBackGroundService.Migrations
{
    public partial class primarykeyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FundingRequestNumber",
                table: "EmergencyConnectivityFund",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmergencyConnectivityFund",
                table: "EmergencyConnectivityFund",
                column: "FundingRequestNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmergencyConnectivityFund",
                table: "EmergencyConnectivityFund");

            migrationBuilder.AlterColumn<string>(
                name: "FundingRequestNumber",
                table: "EmergencyConnectivityFund",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
