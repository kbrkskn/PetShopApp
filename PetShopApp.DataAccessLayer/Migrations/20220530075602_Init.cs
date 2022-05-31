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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProducts_tblCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tblCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblProducts_tblSubCategories_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "tblSubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiscountedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    percent = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountedProducts_tblProducts_ProductID",
                        column: x => x.ProductID,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdersNo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
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
                    { 1, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9785), false, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9794), "Kedi" },
                    { 2, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9797), false, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9797), "Köpek" },
                    { 3, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9799), false, new DateTime(2022, 5, 30, 10, 56, 2, 453, DateTimeKind.Local).AddTicks(9799), "Kuş" }
                });

            migrationBuilder.InsertData(
                table: "tblUsers",
                columns: new[] { "Id", "Email", "IsActive", "IsAdmin", "LastName", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 22, "kbrkskn@gmail.com", true, false, "Keskin", "Kübra", "123456", "05362879963" },
                    { 23, "eymen@gmail.com", true, false, "Keskin", "Eymen", "123456", "05362879963" },
                    { 24, "bhrkskn@gmail.com", true, false, "Keskin", "Bahar", "123456", "05362879963" }
                });

            migrationBuilder.InsertData(
                table: "tblSubCategories",
                columns: new[] { "Id", "CategoryID", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(68), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(69), "Kuş Vitamini" },
                    { 4, 1, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(50), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(51), "Kedi Maması" },
                    { 5, 1, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(53), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(54), "Kedi Kumu" },
                    { 6, 1, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(56), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(56), "Kedi Oyuncakları" },
                    { 7, 2, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(58), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(58), "Köpek Maması" },
                    { 8, 2, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(60), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(60), "Köpek Kıyafetleri" },
                    { 9, 2, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(62), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(63), "Köpek Oyuncakları" },
                    { 10, 3, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(64), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(65), "Kuş Yemi" },
                    { 11, 3, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(66), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(67), "Kuş Suluğu" }
                });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CategoryID", "CreatedDate", "ExpirationDate", "Img", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { 13, "155855578", "Nutri", 1, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(161), "aa", false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(162), "Tahılsız Kedi Maması", 250m, 10, 4 });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CategoryID", "CreatedDate", "ExpirationDate", "Img", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { 14, "155855579", "Nutri", 2, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(175), new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(175), "aa", false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(176), "Tahılsız Köpek Maması", 150m, 10, 7 });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "Barcode", "Brand", "CategoryID", "CreatedDate", "ExpirationDate", "Img", "IsDeleted", "ModifiedDate", "Name", "Price", "Stock", "SubCategoryID" },
                values: new object[] { 15, "155955579", "Nutri", 3, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(181), new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(181), "aa", false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(182), "Tahılsız Kuş Yemi", 100m, 10, 10 });

            migrationBuilder.InsertData(
                table: "tblComments",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "ProductID", "Text", "UserID" },
                values: new object[,]
                {
                    { 100, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(439), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(440), 14, "Yorummmmm", 22 },
                    { 101, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(443), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(443), 13, "Yorummmmm", 22 },
                    { 102, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(445), false, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(446), 13, "Yorummmmm", 23 }
                });

            migrationBuilder.InsertData(
                table: "tblProductFeatures",
                columns: new[] { "Id", "CreatedDate", "Feature", "ModifiedDate", "ProductID" },
                values: new object[,]
                {
                    { 16, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(257), "Açıklama 1", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(258), 13 },
                    { 17, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(260), "Açıklama 2", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(261), 13 },
                    { 18, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(262), "Açıklama 1", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(263), 14 },
                    { 19, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(264), "Açıklama 2", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(265), 14 },
                    { 20, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(266), "Açıklama 1", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(267), 15 },
                    { 21, new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(268), "Açıklama 2", new DateTime(2022, 5, 30, 10, 56, 2, 454, DateTimeKind.Local).AddTicks(269), 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscountedProducts_ProductID",
                table: "DiscountedProducts",
                column: "ProductID");

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
                name: "IX_tblProducts_CategoryID",
                table: "tblProducts",
                column: "CategoryID");

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
                name: "DiscountedProducts");

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
