using Microsoft.EntityFrameworkCore.Migrations;

namespace CityHallTracker.Migrations
{
    public partial class AddVoteColandActionSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CouncilActionDate",
                table: "CouncilActions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CouncilMembersVote",
                table: "CouncilActionCouncilMember",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CouncilActions",
                columns: new[] { "CouncilActionId", "CouncilActionContextLink", "CouncilActionDate", "CouncilActionTag", "CouncilActionTitle" },
                values: new object[] { 1, "https://www.seattletimes.com/seattle-news/yakima-mayor-drives-suv-into-rite-aid-building/", null, "Politics", "Make Kathy Coffey Mayor" });

            migrationBuilder.InsertData(
                table: "CouncilMembers",
                columns: new[] { "CouncilMemberId", "CouncilMemberDistrict", "CouncilMemberEndDate", "CouncilMemberName", "CouncilMemberStartDate" },
                values: new object[,]
                {
                    { 8, 5, "December 31, 2019", "Kathy Coffey", "January 5, 2016" },
                    { 9, 3, "December 31, 2019", "Carmen Mendez", "January 5, 2016" },
                    { 10, 1, "December 31, 2019", "Avina Gutierrez", "January 5, 2016" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CouncilActions",
                keyColumn: "CouncilActionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "CouncilActionDate",
                table: "CouncilActions");

            migrationBuilder.DropColumn(
                name: "CouncilMembersVote",
                table: "CouncilActionCouncilMember");
        }
    }
}
