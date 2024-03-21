using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDGEN.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddLogsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDeviceMac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
