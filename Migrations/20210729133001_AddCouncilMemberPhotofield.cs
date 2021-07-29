using Microsoft.EntityFrameworkCore.Migrations;

namespace CityHallTracker.Migrations
{
    public partial class AddCouncilMemberPhotofield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CouncilMemberPhoto",
                table: "CouncilMembers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 1,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/macias.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 2,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/jason-white.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 3,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/byers.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 4,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/kay-funk.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 5,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/lund.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 6,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/brad-hill.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 7,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/holly-cousens-1.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 8,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/Kathy-Coffey-500.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 9,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/carmen-mendez-1.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 10,
                column: "CouncilMemberPhoto",
                value: "https://seattleglobalist.com/wp-content/uploads/2016/01/Avina_Gutierrez-e1452286695271.jpg");

            migrationBuilder.UpdateData(
                table: "CouncilMembers",
                keyColumn: "CouncilMemberId",
                keyValue: 11,
                column: "CouncilMemberPhoto",
                value: "https://www.yakimawa.gov/council/assets/dulce-gutierrez.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CouncilMemberPhoto",
                table: "CouncilMembers");
        }
    }
}
