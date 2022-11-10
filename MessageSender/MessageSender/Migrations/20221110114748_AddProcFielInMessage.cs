using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MessageSender.Migrations
{
    /// <inheritdoc />
    public partial class AddProcFielInMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Processed",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Processed",
                table: "Messages");
        }
    }
}
