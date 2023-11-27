using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeLine.Migrations
{
    public partial class FixDetailAndDrop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "Dropdown",
                table: "FirstAidItemsDetail");

            migrationBuilder.RenameColumn(
                name: "List2",
                table: "FirstAidItemsDetail",
                newName: "DescriptionFirst");

            migrationBuilder.RenameColumn(
                name: "List1",
                table: "FirstAidItemsDetail",
                newName: "DescriptionAfter");

            migrationBuilder.AddColumn<string>(
                name: "StepLineName",
                table: "Dropdown",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StepLineName",
                table: "Dropdown");

            migrationBuilder.RenameColumn(
                name: "DescriptionFirst",
                table: "FirstAidItemsDetail",
                newName: "List2");

            migrationBuilder.RenameColumn(
                name: "DescriptionAfter",
                table: "FirstAidItemsDetail",
                newName: "List1");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dropdown",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
