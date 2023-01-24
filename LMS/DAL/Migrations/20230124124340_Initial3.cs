using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpNumber = table.Column<int>(type: "int", nullable: false),
                    EmpFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpDoj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpMgrId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_EmpMgrId",
                        column: x => x.EmpMgrId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_UserMasters_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "UserMasters",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMasters_EmployeeId",
                table: "UserMasters",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmpMgrId",
                table: "Employee",
                column: "EmpMgrId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UpdatedBy",
                table: "Employee",
                column: "UpdatedBy",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserMasters_Employee_EmployeeId",
                table: "UserMasters",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserMasters_Employee_EmployeeId",
                table: "UserMasters");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_UserMasters_EmployeeId",
                table: "UserMasters");
        }
    }
}
