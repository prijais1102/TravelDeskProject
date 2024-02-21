using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class dataseeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Address", "CreatedOn", "DepartmentId", "Email", "FirstName", "LastName", "MobileNumber", "Password" },
                values: new object[] { "Bihar", new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(9005), 1, "abhinav@gmail.com", "Abhinav", "Deep", "9987231453", "Abhinav@123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedBy", "CreatedOn", "DepartmentId", "Email", "FirstName", "IsActive", "LastName", "ManagerId", "MobileNumber", "Password", "RoleId", "UpdatedBy", "UpdatedOn" },
                values: new object[] { 3, "Lucknow", 1, new DateTime(2024, 2, 20, 11, 44, 20, 427, DateTimeKind.Local).AddTicks(9009), 1, "saurav@gmail.com", "Saurav", true, "Tandon", 1, "9898765432", "Saurav@123", 2, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Address", "CreatedOn", "DepartmentId", "Email", "FirstName", "LastName", "MobileNumber", "Password" },
                values: new object[] { "Delhi", new DateTime(2024, 2, 19, 19, 17, 42, 175, DateTimeKind.Local).AddTicks(4269), 2, "erica@gmail.com", "Erica", "Attal", "9090909090", "Erica@123" });
        }
    }
}
