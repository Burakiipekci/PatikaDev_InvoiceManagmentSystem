using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvoiceManagmentSystem.DataAccess.Migrations
{
    public partial class InvoiceSystemDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    OperationClaimId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
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
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    CustomerID = table.Column<int>(type: "integer", nullable: false)
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
                        name: "FK_Apartments_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
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
                    CustomerID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
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
                    WrotenMessage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
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
                    Cost = table.Column<int>(type: "integer", nullable: false)
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
                        name: "FK_Debts_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
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
                    Cost = table.Column<int>(type: "integer", nullable: false)
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
                        name: "FK_Payments_Users_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A Block" },
                    { 2, "B Block" },
                    { 3, "C Block" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1+1" },
                    { 2, "2+1" },
                    { 3, "3+1" },
                    { 4, "4+1" },
                    { 5, "5+1" }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "OperationClaimId", "UserId" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "Plate", "RoleId", "TC" },
                values: new object[,]
                {
                    { 1, "berk@hotmail.com", "Berk", "Gultekin", new byte[] { 245, 66, 121, 118, 32, 162, 52, 176, 57, 197, 40, 75, 225, 96, 145, 189, 64, 104, 122, 195, 14, 41, 251, 207, 42, 65, 62, 66, 210, 188, 55, 218, 126, 111, 252, 3, 2, 210, 174, 140, 36, 124, 220, 0, 220, 188, 252, 13, 114, 101, 34, 158, 91, 162, 239, 109, 156, 69, 34, 129, 156, 133, 187, 236 }, new byte[] { 144, 34, 171, 132, 239, 140, 174, 204, 61, 167, 69, 240, 40, 10, 100, 3, 28, 113, 225, 119, 60, 44, 169, 254, 193, 138, 39, 128, 125, 112, 39, 6, 68, 129, 102, 251, 112, 64, 179, 104, 8, 21, 118, 213, 76, 80, 110, 12, 17, 232, 226, 169, 114, 197, 211, 240, 125, 217, 67, 94, 2, 202, 119, 92, 172, 119, 134, 236, 32, 234, 167, 79, 97, 1, 216, 31, 148, 209, 21, 195, 160, 105, 131, 145, 149, 225, 35, 136, 49, 143, 53, 183, 162, 170, 232, 100, 184, 85, 169, 149, 34, 123, 22, 136, 36, 115, 249, 126, 109, 197, 139, 24, 65, 33, 14, 9, 101, 177, 228, 1, 191, 17, 199, 187, 214, 206, 139, 25 }, "5320000000", "49 AC 49", 1, "11111111111" },
                    { 2, "can@hotmail.com", "Can", "demir", new byte[] { 245, 66, 121, 118, 32, 162, 52, 176, 57, 197, 40, 75, 225, 96, 145, 189, 64, 104, 122, 195, 14, 41, 251, 207, 42, 65, 62, 66, 210, 188, 55, 218, 126, 111, 252, 3, 2, 210, 174, 140, 36, 124, 220, 0, 220, 188, 252, 13, 114, 101, 34, 158, 91, 162, 239, 109, 156, 69, 34, 129, 156, 133, 187, 236 }, new byte[] { 144, 34, 171, 132, 239, 140, 174, 204, 61, 167, 69, 240, 40, 10, 100, 3, 28, 113, 225, 119, 60, 44, 169, 254, 193, 138, 39, 128, 125, 112, 39, 6, 68, 129, 102, 251, 112, 64, 179, 104, 8, 21, 118, 213, 76, 80, 110, 12, 17, 232, 226, 169, 114, 197, 211, 240, 125, 217, 67, 94, 2, 202, 119, 92, 172, 119, 134, 236, 32, 234, 167, 79, 97, 1, 216, 31, 148, 209, 21, 195, 160, 105, 131, 145, 149, 225, 35, 136, 49, 143, 53, 183, 162, 170, 232, 100, 184, 85, 169, 149, 34, 123, 22, 136, 36, 115, 249, 126, 109, 197, 139, 24, 65, 33, 14, 9, 101, 177, 228, 1, 191, 17, 199, 187, 214, 206, 139, 25 }, "5320000001", "61 AC 62", 2, "11111111112" },
                    { 3, "burak@hotmail.com", "Burak", "ipekçi", new byte[] { 245, 66, 121, 118, 32, 162, 52, 176, 57, 197, 40, 75, 225, 96, 145, 189, 64, 104, 122, 195, 14, 41, 251, 207, 42, 65, 62, 66, 210, 188, 55, 218, 126, 111, 252, 3, 2, 210, 174, 140, 36, 124, 220, 0, 220, 188, 252, 13, 114, 101, 34, 158, 91, 162, 239, 109, 156, 69, 34, 129, 156, 133, 187, 236 }, new byte[] { 144, 34, 171, 132, 239, 140, 174, 204, 61, 167, 69, 240, 40, 10, 100, 3, 28, 113, 225, 119, 60, 44, 169, 254, 193, 138, 39, 128, 125, 112, 39, 6, 68, 129, 102, 251, 112, 64, 179, 104, 8, 21, 118, 213, 76, 80, 110, 12, 17, 232, 226, 169, 114, 197, 211, 240, 125, 217, 67, 94, 2, 202, 119, 92, 172, 119, 134, 236, 32, 234, 167, 79, 97, 1, 216, 31, 148, 209, 21, 195, 160, 105, 131, 145, 149, 225, 35, 136, 49, 143, 53, 183, 162, 170, 232, 100, 184, 85, 169, 149, 34, 123, 22, 136, 36, 115, 249, 126, 109, 197, 139, 24, 65, 33, 14, 9, 101, 177, 228, 1, 191, 17, 199, 187, 214, 206, 139, 25 }, "5320000002", "61 AC 63", 2, "11111111113" }
                });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "BlockID", "CustomerID", "Floor", "IsEmpty", "StyleID" },
                values: new object[,]
                {
                    { 1, 1, 1, 18, true, 1 },
                    { 2, 2, 2, 19, true, 2 },
                    { 3, 3, 3, 20, true, 3 }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Balance", "CardNumber", "CardPassword", "CustomerID" },
                values: new object[,]
                {
                    { 1, 3000, 11223344, 1234, 1 },
                    { 2, 4000, 11112222, 4321, 2 },
                    { 3, 5000, 33334444, 1221, 3 }
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
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
