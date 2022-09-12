using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeenTogether.Data.Migrations
{
    public partial class ModifyUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsInLoveWith",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInLoveWith",
                table: "AspNetUsers");
        }
    }
}
