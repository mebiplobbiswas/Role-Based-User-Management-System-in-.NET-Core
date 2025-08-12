using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreAuth.Data.Migrations
{
    /// <inheritdoc />
    public partial class script4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AreaCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaCode",
                table: "AspNetUsers");
        }
    }
}
