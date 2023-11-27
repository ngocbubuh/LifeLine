using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeLine.Migrations
{
    public partial class UpdateDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "image",
                table: "FirstAidItemsDetail",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FirstAidItemsDetail",
                newName: "List2");

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

            migrationBuilder.AddColumn<string>(
                name: "List1",
                table: "FirstAidItemsDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "List1",
                table: "FirstAidItemsDetail");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "FirstAidItemsDetail",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "List2",
                table: "FirstAidItemsDetail",
                newName: "Description");
        }
    }
}
