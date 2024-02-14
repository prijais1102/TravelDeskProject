using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelDeskProject.Migrations
{
    /// <inheritdoc />
    public partial class updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "FlightTypes",
                columns: table => new
                {
                    FlightTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightTypes", x => x.FlightTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "MealPreferenceTypes",
                columns: table => new
                {
                    MealPreferenceTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealPreferenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPreferenceTypes", x => x.MealPreferenceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "MealTypes",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypes", x => x.MealTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Statuss",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuss", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Users_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ReasonForTravelling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingTypeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AadharNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: true),
                    MealTypeId = table.Column<int>(type: "int", nullable: true),
                    MealPreferenceId = table.Column<int>(type: "int", nullable: true),
                    StayDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HotelLocationId = table.Column<int>(type: "int", nullable: false),
                    FlightTypeId = table.Column<int>(type: "int", nullable: true),
                    To = table.Column<int>(type: "int", nullable: true),
                    From = table.Column<int>(type: "int", nullable: true),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "BookingTypeName", "CreateBy", "CreatedOn", "IsActive", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Air ticket Only", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null },
                    { 2, "Hotel Only", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null },
                    { 3, "Both", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CreateBy", "CreatedOn", "DepartmentName", "IsActive", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6983), "IT", false, null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6988), "Sales", false, null, null },
                    { 3, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6990), "HR", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "FlightTypes",
                columns: new[] { "FlightTypeId", "CreateBy", "CreatedOn", "FlightTypeName", "IsActive", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6908), "Domestic", false, null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6911), "International", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country", "CreateBy", "CreatedOn", "IsActive", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Noida", "India", 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6959), false, null, null },
                    { 2, "Pune", "India", 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6961), false, null, null },
                    { 3, "London", "England", 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6963), false, null, null },
                    { 4, "Dubai", "United Arab Emirates", 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6964), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "MealPreferenceTypes",
                columns: new[] { "MealPreferenceTypeId", "CreateBy", "CreatedOn", "IsActive", "MealPreferenceName", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6823), false, "Veg", null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6826), false, "Non-Veg", null, null }
                });

            migrationBuilder.InsertData(
                table: "MealTypes",
                columns: new[] { "MealTypeId", "CreateBy", "CreatedOn", "IsActive", "MealTypeName", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6853), false, "Lunch", null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6855), false, "Dinner", null, null },
                    { 3, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6856), false, "Both", null, null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "CreateBy", "CreatedOn", "IsActive", "ProjectName", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6589), false, "GBS-UK", null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6605), false, "GBS-Dubai", null, null },
                    { 3, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6606), false, "GBS-Noida", null, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "CreateBy", "CreatedOn", "IsActive", "RoleName", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7012), false, "Admin", null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7015), false, "HRAdmin", null, null },
                    { 3, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7017), false, "Employee", null, null },
                    { 4, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7018), false, "Manager", null, null }
                });

            migrationBuilder.InsertData(
                table: "Statuss",
                columns: new[] { "StatusId", "CreateBy", "CreatedOn", "IsActive", "StatusName", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6934), false, "Pending", null, null },
                    { 2, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6937), false, "Rejected", null, null },
                    { 3, 0, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(6938), false, "Approved", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "CreatedBy", "CreatedOn", "DepartmentId", "Email", "FirstName", "IsActive", "LastName", "ManagerId", "MobileNumber", "Password", "RoleId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Mzp", 1, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7051), 1, "priya@gmail.com", "Priya", true, "Jaiswal", null, "6306788371", "Priya@123", 1, null, null },
                    { 2, "Delhi", 1, new DateTime(2024, 2, 14, 19, 12, 12, 478, DateTimeKind.Local).AddTicks(7057), 2, "erica@gmail.com", "Erica", true, "Attal", 1, "9090909090", "Erica@123", 4, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManagerId",
                table: "Users",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "FlightTypes");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "MealPreferenceTypes");

            migrationBuilder.DropTable(
                name: "MealTypes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Statuss");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
