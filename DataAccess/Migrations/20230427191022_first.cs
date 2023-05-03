using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Province_Region_RegionID",
                        column: x => x.RegionID,
                        principalTable: "Region",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROVINCEREF = table.Column<int>(type: "int", nullable: false),
                    ProvinceID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.ID);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Neighbourhood",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighbourhood", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Neighbourhood_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MERNISNO = table.Column<long>(type: "bigint", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GENDER = table.Column<int>(type: "int", nullable: false),
                    MOBILEPHONE = table.Column<long>(type: "bigint", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceID = table.Column<int>(type: "int", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    NeighbourhoodID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Persons_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Persons_Neighbourhood_NeighbourhoodID",
                        column: x => x.NeighbourhoodID,
                        principalTable: "Neighbourhood",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Persons_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceID = table.Column<int>(type: "int", nullable: true),
                    DistrictID = table.Column<int>(type: "int", nullable: true),
                    NeighbourhoodID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schools_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Schools_Neighbourhood_NeighbourhoodID",
                        column: x => x.NeighbourhoodID,
                        principalTable: "Neighbourhood",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Schools_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Department_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Branch_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Branch_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Classroom",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Classroom_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Classroom_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Classroom_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DURATION = table.Column<int>(type: "int", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    ClassroomID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lesson_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Lesson_Classroom_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "Classroom",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Lesson_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Lesson_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    ClassroomID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Student_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Classroom_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "Classroom",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Student_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: true),
                    ClassroomID = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<int>(type: "int", nullable: false),
                    CREATEDBY = table.Column<long>(type: "bigint", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MODIFIEDBY = table.Column<long>(type: "bigint", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teachers_Branch_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branch",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teachers_Classroom_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "Classroom",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teachers_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Teachers_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LessonStudent",
                columns: table => new
                {
                    LessonsID = table.Column<int>(type: "int", nullable: false),
                    StudentsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonStudent", x => new { x.LessonsID, x.StudentsID });
                    table.ForeignKey(
                        name: "FK_LessonStudent_Lesson_LessonsID",
                        column: x => x.LessonsID,
                        principalTable: "Lesson",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LessonStudent_Student_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Student",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolTeacher",
                columns: table => new
                {
                    SchoolsID = table.Column<int>(type: "int", nullable: false),
                    TeachersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolTeacher", x => new { x.SchoolsID, x.TeachersID });
                    table.ForeignKey(
                        name: "FK_SchoolTeacher_Schools_SchoolsID",
                        column: x => x.SchoolsID,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolTeacher_Teachers_TeachersID",
                        column: x => x.TeachersID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_DepartmentID",
                table: "Branch",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Branch_SchoolID",
                table: "Branch",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_BranchID",
                table: "Classroom",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_DepartmentID",
                table: "Classroom",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_SchoolID",
                table: "Classroom",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_SchoolID",
                table: "Department",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceID",
                table: "District",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_BranchID",
                table: "Lesson",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ClassroomID",
                table: "Lesson",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_DepartmentID",
                table: "Lesson",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_SchoolID",
                table: "Lesson",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_LessonStudent_StudentsID",
                table: "LessonStudent",
                column: "StudentsID");

            migrationBuilder.CreateIndex(
                name: "IX_Neighbourhood_DistrictID",
                table: "Neighbourhood",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DistrictID",
                table: "Persons",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_NeighbourhoodID",
                table: "Persons",
                column: "NeighbourhoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ProvinceID",
                table: "Persons",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Province_RegionID",
                table: "Province",
                column: "RegionID");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_DistrictID",
                table: "Schools",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_NeighbourhoodID",
                table: "Schools",
                column: "NeighbourhoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_ProvinceID",
                table: "Schools",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolTeacher_TeachersID",
                table: "SchoolTeacher",
                column: "TeachersID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_BranchID",
                table: "Student",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassroomID",
                table: "Student",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentID",
                table: "Student",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PersonID",
                table: "Student",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolID",
                table: "Student",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_BranchID",
                table: "Teachers",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ClassroomID",
                table: "Teachers",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DepartmentID",
                table: "Teachers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_PersonID",
                table: "Teachers",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonID",
                table: "Users",
                column: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LessonStudent");

            migrationBuilder.DropTable(
                name: "SchoolTeacher");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Classroom");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Neighbourhood");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Region");
        }
    }
}
