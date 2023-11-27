using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeLine.Migrations
{
    public partial class AddDetailsTableFixDropdownTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StepLineName",
                table: "Dropdown");

            migrationBuilder.RenameColumn(
                name: "DescriptionFirst",
                table: "FirstAidItemsDetail",
                newName: "TitleStatement");

            migrationBuilder.RenameColumn(
                name: "DescriptionAfter",
                table: "FirstAidItemsDetail",
                newName: "TitleSTEP");

            migrationBuilder.AddColumn<string>(
                name: "ContentPrevent",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentReason",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContentStatement",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitlePrevent",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleReason",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentPrevent",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "ContentReason",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "ContentStatement",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "TitlePrevent",
                table: "FirstAidItemsDetail");

            migrationBuilder.DropColumn(
                name: "TitleReason",
                table: "FirstAidItemsDetail");

            migrationBuilder.RenameColumn(
                name: "TitleStatement",
                table: "FirstAidItemsDetail",
                newName: "DescriptionFirst");

            migrationBuilder.RenameColumn(
                name: "TitleSTEP",
                table: "FirstAidItemsDetail",
                newName: "DescriptionAfter");

            migrationBuilder.AddColumn<string>(
                name: "StepLineName",
                table: "Dropdown",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
