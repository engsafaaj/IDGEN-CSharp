using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IDGEN.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studnets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmissionYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudySystem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdmissionChannel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnrollmentOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CollegesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studnets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Studnets_Colleges_CollegesId",
                        column: x => x.CollegesId,
                        principalTable: "Colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Studnets_CollegesId",
                table: "Studnets",
                column: "CollegesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studnets");
        }
    }
}
