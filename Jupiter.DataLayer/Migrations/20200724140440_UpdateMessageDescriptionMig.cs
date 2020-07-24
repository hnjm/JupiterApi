using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jupiter.DataLayer.Migrations
{
    public partial class UpdateMessageDescriptionMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Messages",
                maxLength: 10000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Auther",
                table: "Messages",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 10000);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 24, 18, 34, 40, 150, DateTimeKind.Local).AddTicks(762), new DateTime(2020, 7, 24, 18, 34, 40, 155, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 24, 18, 34, 40, 155, DateTimeKind.Local).AddTicks(3825), new DateTime(2020, 7, 24, 18, 34, 40, 155, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 24, 18, 34, 40, 155, DateTimeKind.Local).AddTicks(3895), new DateTime(2020, 7, 24, 18, 34, 40, 155, DateTimeKind.Local).AddTicks(3901) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Messages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10000);

            migrationBuilder.AlterColumn<string>(
                name: "Auther",
                table: "Messages",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 23, 18, 53, 53, 407, DateTimeKind.Local).AddTicks(3791), new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5516), new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5652), new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5663) });
        }
    }
}
