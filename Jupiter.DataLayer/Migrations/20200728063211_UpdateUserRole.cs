using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jupiter.DataLayer.Migrations
{
    public partial class UpdateUserRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "UserRoles",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "UserRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "UserRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "UserRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 28, 11, 2, 11, 85, DateTimeKind.Local).AddTicks(388), new DateTime(2020, 7, 28, 11, 2, 11, 89, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 28, 11, 2, 11, 89, DateTimeKind.Local).AddTicks(6486), new DateTime(2020, 7, 28, 11, 2, 11, 89, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 28, 11, 2, 11, 89, DateTimeKind.Local).AddTicks(6560), new DateTime(2020, 7, 28, 11, 2, 11, 89, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "UserRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 27, 22, 26, 45, 720, DateTimeKind.Local).AddTicks(9052), new DateTime(2020, 7, 27, 22, 26, 45, 729, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 27, 22, 26, 45, 729, DateTimeKind.Local).AddTicks(9596), new DateTime(2020, 7, 27, 22, 26, 45, 729, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 27, 22, 26, 45, 729, DateTimeKind.Local).AddTicks(9708), new DateTime(2020, 7, 27, 22, 26, 45, 729, DateTimeKind.Local).AddTicks(9718) });
        }
    }
}
