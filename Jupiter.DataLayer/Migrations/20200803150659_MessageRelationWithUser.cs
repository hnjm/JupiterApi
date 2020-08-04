using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jupiter.DataLayer.Migrations
{
    public partial class MessageRelationWithUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageComments_Messages_MessageId",
                table: "MessageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageComments_Users_UserId",
                table: "MessageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageVisits_Messages_MessageId",
                table: "MessageVisits");

            migrationBuilder.AlterColumn<long>(
                name: "MessageId",
                table: "MessageVisits",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "MessageComments",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "MessageId",
                table: "MessageComments",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 19, 36, 58, 447, DateTimeKind.Local).AddTicks(9386), new DateTime(2020, 8, 3, 19, 36, 58, 453, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 19, 36, 58, 453, DateTimeKind.Local).AddTicks(2461), new DateTime(2020, 8, 3, 19, 36, 58, 453, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 19, 36, 58, 453, DateTimeKind.Local).AddTicks(2536), new DateTime(2020, 8, 3, 19, 36, 58, 453, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.AddForeignKey(
                name: "FK_MessageComments_Messages_MessageId",
                table: "MessageComments",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageComments_Users_UserId",
                table: "MessageComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageVisits_Messages_MessageId",
                table: "MessageVisits",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MessageComments_Messages_MessageId",
                table: "MessageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageComments_Users_UserId",
                table: "MessageComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_MessageVisits_Messages_MessageId",
                table: "MessageVisits");

            migrationBuilder.AlterColumn<long>(
                name: "MessageId",
                table: "MessageVisits",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Messages",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "MessageComments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "MessageId",
                table: "MessageComments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 12, 49, 18, 62, DateTimeKind.Local).AddTicks(8370), new DateTime(2020, 8, 3, 12, 49, 18, 69, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 12, 49, 18, 70, DateTimeKind.Local).AddTicks(1710), new DateTime(2020, 8, 3, 12, 49, 18, 70, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreateDate", "LastUpdateDate" },
                values: new object[] { new DateTime(2020, 8, 3, 12, 49, 18, 70, DateTimeKind.Local).AddTicks(1831), new DateTime(2020, 8, 3, 12, 49, 18, 70, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.AddForeignKey(
                name: "FK_MessageComments_Messages_MessageId",
                table: "MessageComments",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageComments_Users_UserId",
                table: "MessageComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessageVisits_Messages_MessageId",
                table: "MessageVisits",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
