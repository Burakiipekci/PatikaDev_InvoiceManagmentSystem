using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvoiceManagmentSystem.DataAccess.Migrations
{
    public partial class InvoiceManagmentSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleName = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    TC = table.Column<string>(type: "text", nullable: false),
                    Plate = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlockID = table.Column<int>(type: "integer", nullable: false),
                    IsEmpty = table.Column<bool>(type: "boolean", nullable: false),
                    StyleID = table.Column<int>(type: "integer", nullable: false),
                    Floor = table.Column<int>(type: "integer", nullable: false),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Blocks_BlockID",
                        column: x => x.BlockID,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Styles_StyleID",
                        column: x => x.StyleID,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<int>(type: "integer", nullable: false),
                    CardPassword = table.Column<int>(type: "integer", nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    WrotenMessage = table.Column<string>(type: "text", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Debts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    ApartmentID = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Debts_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Debts_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerID = table.Column<int>(type: "integer", nullable: false),
                    ApartmentID = table.Column<int>(type: "integer", nullable: false),
                    CardId = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Apartments_ApartmentID",
                        column: x => x.ApartmentID,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_User_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "A Block", null },
                    { 2, null, null, "B Block", null },
                    { 3, null, null, "C Block", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "RoleName", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "Admin", null },
                    { 2, null, null, "Customer", null }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "1+1", null },
                    { 2, null, null, "2+1", null },
                    { 3, null, null, "3+1", null },
                    { 4, null, null, "4+1", null },
                    { 5, null, null, "5+1", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Plate", "RoleId", "TC", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, null, "asdfasd1@hotmail.com", "Berk", "Gultekin", new byte[] { 171, 47, 28, 107, 187, 192, 102, 211, 200, 135, 134, 143, 26, 72, 245, 89, 164, 90, 17, 240, 140, 127, 137, 250, 245, 18, 43, 136, 46, 168, 57, 64, 99, 190, 170, 94, 137, 50, 188, 54, 251, 71, 81, 237, 185, 109, 224, 93, 24, 71, 114, 248, 69, 249, 153, 240, 31, 132, 151, 222, 3, 140, 203, 33 }, new byte[] { 56, 228, 224, 130, 96, 177, 151, 170, 164, 244, 192, 58, 32, 118, 6, 238, 16, 93, 2, 93, 105, 132, 20, 128, 178, 137, 16, 169, 109, 175, 26, 36, 245, 209, 155, 163, 234, 46, 185, 183, 114, 214, 12, 141, 250, 215, 139, 123, 84, 225, 112, 233, 210, 174, 117, 190, 97, 53, 79, 98, 45, 234, 5, 161, 9, 240, 88, 118, 235, 6, 207, 208, 121, 223, 130, 253, 109, 172, 130, 215, 171, 147, 173, 30, 154, 156, 80, 71, 15, 170, 67, 22, 194, 114, 237, 98, 166, 137, 173, 20, 193, 249, 107, 48, 227, 131, 61, 169, 112, 160, 77, 41, 83, 13, 92, 187, 64, 170, 224, 205, 115, 94, 20, 158, 64, 211, 106, 192 }, "5320000000", "49 AC 49", 1, "11111111111", null },
                    { 2, null, null, "asdfasd2@hotmail.com", "Can", "demir", new byte[] { 171, 47, 28, 107, 187, 192, 102, 211, 200, 135, 134, 143, 26, 72, 245, 89, 164, 90, 17, 240, 140, 127, 137, 250, 245, 18, 43, 136, 46, 168, 57, 64, 99, 190, 170, 94, 137, 50, 188, 54, 251, 71, 81, 237, 185, 109, 224, 93, 24, 71, 114, 248, 69, 249, 153, 240, 31, 132, 151, 222, 3, 140, 203, 33 }, new byte[] { 56, 228, 224, 130, 96, 177, 151, 170, 164, 244, 192, 58, 32, 118, 6, 238, 16, 93, 2, 93, 105, 132, 20, 128, 178, 137, 16, 169, 109, 175, 26, 36, 245, 209, 155, 163, 234, 46, 185, 183, 114, 214, 12, 141, 250, 215, 139, 123, 84, 225, 112, 233, 210, 174, 117, 190, 97, 53, 79, 98, 45, 234, 5, 161, 9, 240, 88, 118, 235, 6, 207, 208, 121, 223, 130, 253, 109, 172, 130, 215, 171, 147, 173, 30, 154, 156, 80, 71, 15, 170, 67, 22, 194, 114, 237, 98, 166, 137, 173, 20, 193, 249, 107, 48, 227, 131, 61, 169, 112, 160, 77, 41, 83, 13, 92, 187, 64, 170, 224, 205, 115, 94, 20, 158, 64, 211, 106, 192 }, "5320000001", "61 AC 62", 2, "11111111112", null },
                    { 3, null, null, "asdfasd3@hotmail.com", "Burak", "ipekçi", new byte[] { 171, 47, 28, 107, 187, 192, 102, 211, 200, 135, 134, 143, 26, 72, 245, 89, 164, 90, 17, 240, 140, 127, 137, 250, 245, 18, 43, 136, 46, 168, 57, 64, 99, 190, 170, 94, 137, 50, 188, 54, 251, 71, 81, 237, 185, 109, 224, 93, 24, 71, 114, 248, 69, 249, 153, 240, 31, 132, 151, 222, 3, 140, 203, 33 }, new byte[] { 56, 228, 224, 130, 96, 177, 151, 170, 164, 244, 192, 58, 32, 118, 6, 238, 16, 93, 2, 93, 105, 132, 20, 128, 178, 137, 16, 169, 109, 175, 26, 36, 245, 209, 155, 163, 234, 46, 185, 183, 114, 214, 12, 141, 250, 215, 139, 123, 84, 225, 112, 233, 210, 174, 117, 190, 97, 53, 79, 98, 45, 234, 5, 161, 9, 240, 88, 118, 235, 6, 207, 208, 121, 223, 130, 253, 109, 172, 130, 215, 171, 147, 173, 30, 154, 156, 80, 71, 15, 170, 67, 22, 194, 114, 237, 98, 166, 137, 173, 20, 193, 249, 107, 48, 227, 131, 61, 169, 112, 160, 77, 41, 83, 13, 92, 187, 64, 170, 224, 205, 115, 94, 20, 158, 64, 211, 106, 192 }, "5320000002", "61 AC 63", 2, "11111111113", null }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "BlockID", "CreateDate", "CustomerID", "DeletedDate", "Floor", "IsEmpty", "StyleID", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, null, 1, null, 18, true, 1, null },
                    { 2, 2, null, 2, null, 19, true, 2, null },
                    { 3, 3, null, 3, null, 20, true, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Balance", "CardNumber", "CardPassword", "CreateDate", "CustomerID", "DeletedDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 3000, 11223344, 1234, null, 1, null, null },
                    { 2, 4000, 11112222, 4321, null, 2, null, null },
                    { 3, 5000, 33334444, 1221, null, 3, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BlockID",
                table: "Apartments",
                column: "BlockID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_CustomerID",
                table: "Apartments",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_StyleID",
                table: "Apartments",
                column: "StyleID");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CustomerID",
                table: "Cards",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Debts_ApartmentID",
                table: "Debts",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Debts_CustomerID",
                table: "Debts",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_CustomerID",
                table: "Messages",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ApartmentID",
                table: "Payments",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CardId",
                table: "Payments",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerID",
                table: "Payments",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Debts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
