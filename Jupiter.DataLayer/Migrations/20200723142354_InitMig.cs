using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Jupiter.DataLayer.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    UrlTitle = table.Column<string>(maxLength: 100, nullable: false),
                    ParentId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageCategories_MessageCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MessageCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Auther = table.Column<string>(maxLength: 10000, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Like = table.Column<int>(nullable: true),
                    DisLike = table.Column<int>(nullable: true),
                    IsImportant = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MembershipNumber = table.Column<string>(maxLength: 12, nullable: false),
                    Avatar = table.Column<string>(maxLength: 150, nullable: true),
                    NationalCode = table.Column<string>(maxLength: 10, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 13, nullable: false),
                    Dateofbirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 320, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    EmailActiveCode = table.Column<string>(maxLength: 38, nullable: true),
                    IsActivated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessageSelectedCategories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    MessageId = table.Column<long>(nullable: false),
                    MessageCategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageSelectedCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageSelectedCategories_MessageCategories_MessageCategoryId",
                        column: x => x.MessageCategoryId,
                        principalTable: "MessageCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageSelectedCategories_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageVisits",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    MessageId = table.Column<long>(nullable: false),
                    UserID = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageVisits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageVisits_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MessageComments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    MessageId = table.Column<long>(nullable: false),
                    ParentId = table.Column<long>(nullable: true),
                    UserId = table.Column<long>(nullable: false),
                    Text = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessageComments_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessageComments_MessageComments_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MessageComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessageComments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "IsDelete", "LastUpdateDate", "Name", "Title" },
                values: new object[] { 1L, new DateTime(2020, 7, 23, 18, 53, 53, 407, DateTimeKind.Local).AddTicks(3791), false, new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(3355), "Admin", "ادمین" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "IsDelete", "LastUpdateDate", "Name", "Title" },
                values: new object[] { 2L, new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5516), false, new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5609), "Professor", "استاد" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "IsDelete", "LastUpdateDate", "Name", "Title" },
                values: new object[] { 3L, new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5652), false, new DateTime(2020, 7, 23, 18, 53, 53, 449, DateTimeKind.Local).AddTicks(5663), "Student", "دانشجو" });

            migrationBuilder.CreateIndex(
                name: "IX_MessageCategories_ParentId",
                table: "MessageCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageComments_MessageId",
                table: "MessageComments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageComments_ParentId",
                table: "MessageComments",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageComments_UserId",
                table: "MessageComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageSelectedCategories_MessageCategoryId",
                table: "MessageSelectedCategories",
                column: "MessageCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageSelectedCategories_MessageId",
                table: "MessageSelectedCategories",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessageVisits_MessageId",
                table: "MessageVisits",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageComments");

            migrationBuilder.DropTable(
                name: "MessageSelectedCategories");

            migrationBuilder.DropTable(
                name: "MessageVisits");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "MessageCategories");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
