using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Sqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course18",
                columns: table => new
                {
                    Id18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Name18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Semester18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Hours18 = table.Column<int>(type: "INTEGER", nullable: false),
                    Credit18 = table.Column<int>(type: "INTEGER", nullable: false),
                    ExamMethod18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course18", x => x.Id18);
                });

            migrationBuilder.CreateTable(
                name: "Major18",
                columns: table => new
                {
                    Id18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Name18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major18", x => x.Id18);
                });

            migrationBuilder.CreateTable(
                name: "User18",
                columns: table => new
                {
                    Id18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Name18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Age18 = table.Column<int>(type: "INTEGER", nullable: false),
                    Gender18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Password18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 256, nullable: false),
                    Role18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User18", x => x.Id18);
                });

            migrationBuilder.CreateTable(
                name: "Class18",
                columns: table => new
                {
                    Id18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Name18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    MajorId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class18", x => x.Id18);
                    table.ForeignKey(
                        name: "FK_Class18_Major18",
                        column: x => x.MajorId18,
                        principalTable: "Major18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher18",
                columns: table => new
                {
                    UserId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Title18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Telephone18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher18", x => x.UserId18);
                    table.ForeignKey(
                        name: "FK_Teacher18_User18",
                        column: x => x.UserId18,
                        principalTable: "User18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassCourse18",
                columns: table => new
                {
                    ClassId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    CourseId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCourse18", x => new { x.CourseId18, x.ClassId18 });
                    table.ForeignKey(
                        name: "FK_ClassCourse18_Class18",
                        column: x => x.ClassId18,
                        principalTable: "Class18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCourse18_Course18",
                        column: x => x.CourseId18,
                        principalTable: "Course18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student18",
                columns: table => new
                {
                    UserId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    SourcePlace18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    ClassId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Credit18 = table.Column<int>(type: "INTEGER", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student18_1", x => x.UserId18);
                    table.ForeignKey(
                        name: "FK_Student18_Class18",
                        column: x => x.ClassId18,
                        principalTable: "Class18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student18_User18",
                        column: x => x.UserId18,
                        principalTable: "User18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourse18",
                columns: table => new
                {
                    TeacherId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    CourseId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourse18", x => new { x.CourseId18, x.TeacherId18 });
                    table.ForeignKey(
                        name: "FK_TeacherCourse18_Course18",
                        column: x => x.CourseId18,
                        principalTable: "Course18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherCourse18_Teacher18",
                        column: x => x.TeacherId18,
                        principalTable: "Teacher18",
                        principalColumn: "UserId18",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse18",
                columns: table => new
                {
                    StudentId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    CourseId18 = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 10, nullable: false),
                    Score18 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse18", x => new { x.CourseId18, x.StudentId18 });
                    table.ForeignKey(
                        name: "FK_StudentCourse18_Course18",
                        column: x => x.CourseId18,
                        principalTable: "Course18",
                        principalColumn: "Id18",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse18_Student18",
                        column: x => x.StudentId18,
                        principalTable: "Student18",
                        principalColumn: "UserId18",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class18_MajorId18",
                table: "Class18",
                column: "MajorId18");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse18",
                table: "ClassCourse18",
                columns: new[] { "ClassId18", "CourseId18" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student18_ClassId18",
                table: "Student18",
                column: "ClassId18");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse18",
                table: "StudentCourse18",
                columns: new[] { "StudentId18", "CourseId18" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourse18",
                table: "TeacherCourse18",
                columns: new[] { "TeacherId18", "CourseId18" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassCourse18");

            migrationBuilder.DropTable(
                name: "StudentCourse18");

            migrationBuilder.DropTable(
                name: "TeacherCourse18");

            migrationBuilder.DropTable(
                name: "Student18");

            migrationBuilder.DropTable(
                name: "Course18");

            migrationBuilder.DropTable(
                name: "Teacher18");

            migrationBuilder.DropTable(
                name: "Class18");

            migrationBuilder.DropTable(
                name: "User18");

            migrationBuilder.DropTable(
                name: "Major18");
        }
    }
}
