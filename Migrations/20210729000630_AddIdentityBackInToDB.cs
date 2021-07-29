using Microsoft.EntityFrameworkCore.Migrations;

namespace CityHallTracker.Migrations
{
    public partial class AddIdentityBackInToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CouncilActions",
                keyColumn: "CouncilActionId",
                keyValue: 1,
                column: "CouncilActionDate",
                value: "January 2, 2018");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 2,
                column: "CouncilMemberStartDate",
                value: "January 2, 2018");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 4,
                column: "CouncilMemberStartDate",
                value: "January 2, 2018");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 6,
                column: "CouncilMemberStartDate",
                value: "January 2, 2018");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CouncilActions",
                keyColumn: "CouncilActionId",
                keyValue: 1,
                column: "CouncilActionDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 2,
                column: "CouncilMemberStartDate",
                value: "January 9, 2018");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 4,
                column: "CouncilMemberStartDate",
                value: "January 9, 2018");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 6,
                column: "CouncilMemberStartDate",
                value: "January 9, 2018");
        }
    }
}
