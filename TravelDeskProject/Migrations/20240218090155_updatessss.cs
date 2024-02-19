using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class updatessss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss");

            migrationBuilder.RenameTable(
                name: "Statuss",
                newName: "EmployeeRequestStatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRequestStatus",
                table: "EmployeeRequestStatus",
                column: "StatusId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 31, 55, 97, DateTimeKind.Local).AddTicks(4598));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRequestStatus",
                table: "EmployeeRequestStatus");

            migrationBuilder.RenameTable(
                name: "EmployeeRequestStatus",
                newName: "Statuss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuss",
                table: "Statuss",
                column: "StatusId");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Statuss",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 14, 23, 46, 365, DateTimeKind.Local).AddTicks(3093));
        }
    }
}
