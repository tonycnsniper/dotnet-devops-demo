using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_core_mvc.Migrations
{
    /// <inheritdoc />
    public partial class AddThreaterDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "threaters",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "threaters");
        }
    }
}
