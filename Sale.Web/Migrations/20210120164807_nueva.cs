using Microsoft.EntityFrameworkCore.Migrations;

namespace Sale.Web.Migrations
{
    public partial class nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Department_DepartmentId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Country_CountryId",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Department_Name",
                table: "Departments",
                newName: "IX_Departments_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Department_CountryId",
                table: "Departments",
                newName: "IX_Departments_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Country_Name",
                table: "Countries",
                newName: "IX_Countries_Name");

            migrationBuilder.RenameIndex(
                name: "IX_City_Name",
                table: "Cities",
                newName: "IX_Cities_Name");

            migrationBuilder.RenameIndex(
                name: "IX_City_DepartmentId",
                table: "Cities",
                newName: "IX_Cities_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Departments_DepartmentId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Countries_CountryId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_Name",
                table: "Department",
                newName: "IX_Department_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_CountryId",
                table: "Department",
                newName: "IX_Department_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_Name",
                table: "Country",
                newName: "IX_Country_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_Name",
                table: "City",
                newName: "IX_City_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_DepartmentId",
                table: "City",
                newName: "IX_City_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Department_DepartmentId",
                table: "City",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Country_CountryId",
                table: "Department",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
