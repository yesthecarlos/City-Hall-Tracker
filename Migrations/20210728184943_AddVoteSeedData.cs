using Microsoft.EntityFrameworkCore.Migrations;

namespace CityHallTracker.Migrations
{
    public partial class AddVoteSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CouncilActionCouncilMember",
                columns: new[] { "CouncilActionCouncilMemberId", "CouncilActionId", "CouncilMemberId", "CouncilMembersVote" },
                values: new object[,]
                {
                    { 1, 1, 8, "Yes" },
                    { 2, 1, 9, "Yes" },
                    { 4, 1, 4, "Yes" },
                    { 5, 1, 6, "Yes" },
                    { 6, 1, 2, "Yes" },
                    { 7, 1, 7, "Yes" }
                });

            migrationBuilder.InsertData(
                table: "CouncilMembers",
                columns: new[] { "CouncilMemberId", "CouncilMemberDistrict", "CouncilMemberEndDate", "CouncilMemberName", "CouncilMemberStartDate" },
                values: new object[] { 11, 2, "December 31, 2019", "Dulce Gutierrez", "January 5, 2016" });

            migrationBuilder.InsertData(
                table: "CouncilActionCouncilMember",
                columns: new[] { "CouncilActionCouncilMemberId", "CouncilActionId", "CouncilMemberId", "CouncilMembersVote" },
                values: new object[] { 3, 1, 11, "Yes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CouncilActionCouncilMember",
                keyColumn: "CouncilActionCouncilMemberId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 11);
        }
    }
}
