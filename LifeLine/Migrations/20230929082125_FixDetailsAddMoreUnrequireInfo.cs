using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeLine.Migrations
{
    public partial class FixDetailsAddMoreUnrequireInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentConsc",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentSymtoms",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleConsc",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleSymtoms",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentConsc",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "ContentSymtoms",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "TitleConsc",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "TitleSymtoms",
                table: "FirstAidItemsDetail");
        }
    }
}
