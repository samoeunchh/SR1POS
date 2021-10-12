using Microsoft.EntityFrameworkCore.Migrations;

namespace SR1POS.Data.Migrations
{
    public partial class UpdateCategoryField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descriptio",
                table: "Category",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Category",
                newName: "Descriptio");
        }
    }
}
