using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetShopApp.DataAccessLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSubCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSubCategories_tblCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tblCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SubCategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProducts_tblSubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "tblSubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_tblProducts_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_tblUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblComments_tblProducts_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblComments_tblUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProductFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Feature = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProductFeatures_tblProducts_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblCategories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5341), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5352), "Kedi" },
                    { new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5356), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5357), "Köpek" },
                    { new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5359), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5360), "Kuş" }
                });

            migrationBuilder.InsertData(
                table: "tblUsers",
                columns: new[] { "Id", "Email", "IsActive", "IsAdmin", "LastName", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { new Guid("97649960-1851-4ae8-a047-c64f0fba3e56"), "eymen@gmail.com", true, false, "Keskin", "Eymen", "123456", "05362879963" },
                    { new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe"), "kbrkskn@gmail.com", true, false, "Keskin", "Kübra", "123456", "05362879963" },
                    { new Guid("d43ecbfe-2136-478e-b367-ab5ab5a40c68"), "bhrkskn@gmail.com", true, false, "Keskin", "Bahar", "123456", "05362879963" }
                });

            migrationBuilder.InsertData(
                table: "tblSubCategories",
                columns: new[] { "Id", "CategoryID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("369f5122-8721-4225-b397-dc443dc7b623"), new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5724), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5725), "Kedi Kumu" },
                    { new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"), new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5749), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5749), "Kuş Vitamini" },
                    { new Guid("5e5efebe-5ec5-4eed-ad45-6becc1962fba"), new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5746), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5747), "Kuş Suluğu" },
                    { new Guid("67eb800d-7c06-4b25-9e52-2ea894492197"), new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5734), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5735), "Köpek Kıyafetleri" },
                    { new Guid("7c4be645-86d3-4c19-ba18-0c7424525fe4"), new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5716), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5721), "Kedi Maması" },
                    { new Guid("a6539c11-3188-44ee-abae-3053ac1a3e3e"), new Guid("0a96abdd-7174-4c2a-8539-67a18b877045"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5727), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5729), "Kedi Oyuncakları" },
                    { new Guid("acff3fbc-0995-4d27-8536-d49583bbbf60"), new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5731), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5732), "Köpek Maması" },
                    { new Guid("b5cea59b-c9a9-403c-90f4-3f939270e462"), new Guid("52c5da72-afc7-4c11-80de-0adabe9aaff9"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5743), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5744), "Kuş Yemi" },
                    { new Guid("d1e97a85-b4d5-4f9a-b79e-a1bbfa67a1dd"), new Guid("433bc24f-d187-4d80-a38b-d88db8bd359e"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5737), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5740), "Köpek Oyuncakları" }
                });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CreatedDate", "ExpirationDate", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd"), "155955579", "Nutri", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5937), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5938), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5939), "Tahılsız Kuş Yemi", 100m, 10, new Guid("b5cea59b-c9a9-403c-90f4-3f939270e462") });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CreatedDate", "ExpirationDate", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842"), "155855579", "Nutri", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5928), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5928), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5929), "Tahılsız Köpek Maması", 150m, 10, new Guid("acff3fbc-0995-4d27-8536-d49583bbbf60") });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CreatedDate", "ExpirationDate", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"), "155855578", "Nutri", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5906), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5908), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(5910), "Tahılsız Kedi Maması", 250m, 10, new Guid("7c4be645-86d3-4c19-ba18-0c7424525fe4") });

            migrationBuilder.InsertData(
                table: "tblComments",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "ProductID", "Text", "UserID" },
                values: new object[,]
                {
                    { new Guid("a9b758fa-c4b8-40cb-8764-2a720e6aa85b"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6390), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6391), new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"), "Yorummmmm", new Guid("97649960-1851-4ae8-a047-c64f0fba3e56") },
                    { new Guid("bb0708c5-807b-40bd-b313-eddb132cd2aa"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6374), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6376), new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842"), "Yorummmmm", new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe") },
                    { new Guid("eb75510a-d3e2-4e4d-8fe3-8f518ae48c11"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6382), false, new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6383), new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb"), "Yorummmmm", new Guid("a546a1b2-703e-4d32-aff0-c664d9526bfe") }
                });

            migrationBuilder.InsertData(
                table: "tblProductFeatures",
                columns: new[] { "Id", "CreatedDate", "Feature", "ModifiedDate", "ProductID" },
                values: new object[,]
                {
                    { new Guid("232d8dae-8891-4e41-bcee-a70d89d01b25"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6075), "Açıklama 1", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6076), new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd") },
                    { new Guid("6033240b-5807-49d9-ada8-645385b87fad"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6071), "Açıklama 2", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6073), new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842") },
                    { new Guid("6c2e5c45-539d-4555-9171-22b5bd3d5d66"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6061), "Açıklama 1", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6062), new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb") },
                    { new Guid("70d3f463-ef01-4bd9-ac6e-2846a63dd04d"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6078), "Açıklama 2", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6079), new Guid("36c8e3f7-d932-461d-ae99-e0a3630b51cd") },
                    { new Guid("b4c3909e-4b70-4071-8e77-a68c78af746c"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6065), "Açıklama 2", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6066), new Guid("ae10f3d1-8a7d-4af5-a062-b63d2b5bd8fb") },
                    { new Guid("f6a202a6-973c-42f3-a61b-e2391a7f9d67"), new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6068), "Açıklama 1", new DateTime(2022, 5, 10, 14, 45, 22, 427, DateTimeKind.Local).AddTicks(6069), new Guid("7dd39a36-b5b0-4c7d-b40f-edf270513842") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductID",
                table: "Orders",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComments_ProductID",
                table: "tblComments",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblComments_UserID",
                table: "tblComments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductFeatures_ProductID",
                table: "tblProductFeatures",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tblProducts_SubCategoryID",
                table: "tblProducts",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblSubCategories_CategoryID",
                table: "tblSubCategories",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "tblComments");

            migrationBuilder.DropTable(
                name: "tblProductFeatures");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblProducts");

            migrationBuilder.DropTable(
                name: "tblSubCategories");

            migrationBuilder.DropTable(
                name: "tblCategories");
        }
    }
}
