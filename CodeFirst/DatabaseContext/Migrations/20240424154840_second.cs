using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.DatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_IdCompany",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_IdDepartment",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_IdDepartment",
                table: "Employee",
                newName: "IX_Employee_IdDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_IdCompany",
                table: "Employee",
                newName: "IX_Employee_IdCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "IdDepartment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "IdCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_IdCompany",
                table: "Employee",
                column: "IdCompany",
                principalTable: "Company",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_IdDepartment",
                table: "Employee",
                column: "IdDepartment",
                principalTable: "Department",
                principalColumn: "IdDepartment",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_IdCompany",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_IdDepartment",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_IdDepartment",
                table: "Employees",
                newName: "IX_Employees_IdDepartment");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_IdCompany",
                table: "Employees",
                newName: "IX_Employees_IdCompany");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "IdDepartment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "IdCompany");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_IdCompany",
                table: "Employees",
                column: "IdCompany",
                principalTable: "Companies",
                principalColumn: "IdCompany",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_IdDepartment",
                table: "Employees",
                column: "IdDepartment",
                principalTable: "Departments",
                principalColumn: "IdDepartment",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
