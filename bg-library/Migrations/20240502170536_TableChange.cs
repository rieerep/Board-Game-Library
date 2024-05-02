using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bg_library.Migrations
{
    /// <inheritdoc />
    public partial class TableChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Loans",
                newName: "BoardGameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BoardGameId",
                table: "Loans",
                newName: "BookId");
        }
    }
}
