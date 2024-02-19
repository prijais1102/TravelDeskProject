using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class removedcommentstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commentsFromHR",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "commentsFromManager",
                table: "Requests");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "EmployeeRequestStatus",
                keyColumn: "StatusId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "FlightTypes",
                keyColumn: "FlightTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "MealPreferenceTypes",
                keyColumn: "MealPreferenceTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "MealTypes",
                keyColumn: "MealTypeId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 2, 18, 15, 32, 54, 852, DateTimeKind.Local).AddTicks(2765));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "commentsFromHR",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "commentsFromManager",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
