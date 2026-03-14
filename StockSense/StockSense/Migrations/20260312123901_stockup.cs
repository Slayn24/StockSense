using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockSense.Migrations
{
    /// <inheritdoc />
    public partial class stockup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReceived",
                table: "OrderSlips",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReceived",
                table: "OrderSlips");
        }
    }
}
