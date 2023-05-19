using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrganicMarket.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init_mg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FileType = table.Column<string>(type: "TEXT", nullable: true),
                    FileName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SupplierId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ViewCount = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoriteCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    SalesUnit = table.Column<int>(type: "INTEGER", nullable: false),
                    SupplierId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Neighbourhood = table.Column<string>(type: "TEXT", nullable: true),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    PostCode = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BasketPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    BeingOrder = table.Column<bool>(type: "INTEGER", nullable: false),
                    ProductCount = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Discount = table.Column<decimal>(type: "TEXT", nullable: false),
                    CargoPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketProducts",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketProducts", x => new { x.BasketId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_BasketProducts_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "3fb68b15-8f69-4aa6-8530-d6e16556b7d4", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "5a88d506-a072-44c5-8a5a-9896d5251400", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "26c7cab1-cb85-4fd7-b00c-ee9d8526deb2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(286), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sebze" },
                    { new Guid("22b5d36e-1d52-4d2f-8ce1-31a0aa567c66"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(376), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hurmalar" },
                    { new Guid("2e209a21-7bb2-43b1-a0c6-6e7d0c990db8"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(280), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meyve" },
                    { new Guid("336461a4-29b2-4dbc-887d-2b68e6527ba5"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(312), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Süt ve Süt Ürünleri" },
                    { new Guid("45269bbb-a36f-46c8-a69f-e1d2802207f5"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(290), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Köy Ürünleri" },
                    { new Guid("49405eff-13c5-4558-a5f2-8b589b7e915c"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(294), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tereyağları" },
                    { new Guid("4a8cad9c-57cd-4ad9-8048-7662c6c24a17"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(332), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şire Ürünleri" },
                    { new Guid("4ab0c360-a01f-4862-aed4-52f16a08470d"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(298), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pekmezler" },
                    { new Guid("62e6c2e9-e35c-4f4e-a4c2-4a70c7d06180"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(303), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turşular" },
                    { new Guid("6644a63f-c42b-49e8-afb9-67e012a3c855"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(351), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sucuklar" },
                    { new Guid("6724e8c6-a7fa-42d7-ad36-33e87d945a31"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(320), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuruyemiş" },
                    { new Guid("9bcef803-76d1-4993-8b1f-7eec1941acf4"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(316), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kahvaltılık" },
                    { new Guid("a0ce76d6-e259-47e5-afda-12e5f4b52852"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(371), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zeytinler" },
                    { new Guid("c1faf13c-9e78-43be-9970-b6a20336bf48"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(307), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yöresel" },
                    { new Guid("c8784e8e-13de-4024-b7fb-71229b37fd55"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(324), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baharatlar" },
                    { new Guid("c9b467ba-9efa-481f-bdc1-1132e6f5186d"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(328), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lokumlar" },
                    { new Guid("fa961207-14b0-4f31-9aa7-d9ab3ebd35f5"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(380), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kuru Meyveler" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "FileName", "FileType", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(3140), "test2", "PNG", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(3124), "test1", "JPG", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("25783bd4-8e59-49bb-a10e-3b7c2ada573b"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 21, DateTimeKind.Local).AddTicks(123), "Sakarya da 1898 de kurulduk.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baştan Gıda" },
                    { new Guid("d7a9c01c-ffaf-49c5-86b3-f2eda4b970b5"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 21, DateTimeKind.Local).AddTicks(117), "Adana da 1999 da kurulduk.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doğan Gıda" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SupplierId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, "c1f286fa-b847-4bed-94dd-93e2a31719bb", "admin@gmail.com", false, "Admin", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEB60POeBQydYlOD/PT3fwFSA3D+4Dq0o2lEdtVYbQeOSOQT1N3Rgyyb4SJKrk/FVhA==", "+905439999988", false, "2349f522-1b00-4d37-92b4-3df94ecf8be1", null, false, "admin@gmail.com" },
                    { new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428"), 0, "bff7eb66-4dd8-469b-824a-d71087cf3776", "user@gmail.com", false, "Normal", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "User", false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", null, "+905439999988", false, "eb635397-6872-48e4-9e82-f5f55efce615", null, false, "user@gmail.com" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, "e59b8747-5642-44c2-b989-38b2f311cbb7", "superadmin@gmail.com", true, "Cem", new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Keskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJmYWUFXa5iWlhONLWuBfQcvPLih4HaP5tDk5KOYuFJM3mcaxKadThVja3CkbJBueA==", "+905439999999", true, "12dbc323-9efc-45ad-bfac-21ba87e117ee", null, false, "superadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Description", "FavoriteCount", "ImageId", "ModifiedBy", "ModifiedDate", "Name", "Price", "SalesUnit", "SupplierId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4"), new Guid("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 20, DateTimeKind.Local).AddTicks(7568), "Mevsiminde Adananın bahçelerinden toplanmış fasulye", 0, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırmızı Biber", 50m, 0, new Guid("25783bd4-8e59-49bb-a10e-3b7c2ada573b"), 0 },
                    { new Guid("6aab099d-e302-4a07-8cf8-cb883a497465"), new Guid("0bd7b92f-d7bf-4dce-91c3-ac17f3b1b345"), "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 20, DateTimeKind.Local).AddTicks(7527), "Mevsiminde Adananın bahçelerinden toplanmış fasulye", 0, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taze Fasulye", 50m, 0, new Guid("d7a9c01c-ffaf-49c5-86b3-f2eda4b970b5"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Id", "City", "CreatedBy", "CreatedDate", "District", "ModifiedBy", "ModifiedDate", "Neighbourhood", "PostCode", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("9aaa8835-2327-4e20-8617-8c3c9ce1c0b2"), "İstanbul", "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 16, 801, DateTimeKind.Local).AddTicks(9424), "Sultan", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bağcılar", 34250, "2. Ev Adresi", new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428") },
                    { new Guid("c14086c3-a1bf-4921-9fb5-5dec6db1ac0f"), "Konya", "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 16, 801, DateTimeKind.Local).AddTicks(9427), "Ayvalca", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bozkır", 42630, "Köy Evi Adresi", new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428") },
                    { new Guid("c1a7de0b-ab68-4d75-8ead-944ced86c1e2"), "Sakarya", "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 16, 801, DateTimeKind.Local).AddTicks(9400), "Erenler", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Küpçüler", 54100, "Ev Adresi", new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "BasketPrice", "BeingOrder", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "ProductCount", "UserId" },
                values: new object[] { new Guid("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a"), 0m, false, "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 17, DateTimeKind.Local).AddTicks(8735), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428") });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CargoPrice", "Completed", "CreatedBy", "CreatedDate", "Discount", "ModifiedBy", "ModifiedDate", "TotalPrice", "UserId" },
                values: new object[] { new Guid("91593468-0be9-4543-9045-b02f112b1d8e"), 15m, false, "Süper Admin", new DateTime(2023, 5, 18, 15, 57, 17, 19, DateTimeKind.Local).AddTicks(5948), 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m, new Guid("4bb43339-1c0f-4630-9d1a-dd579ecd0428") });

            migrationBuilder.InsertData(
                table: "BasketProducts",
                columns: new[] { "BasketId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a"), new Guid("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4") },
                    { new Guid("2335fd49-d0e3-4ee6-8f4e-2d4386172d3a"), new Guid("6aab099d-e302-4a07-8cf8-cb883a497465") }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("91593468-0be9-4543-9045-b02f112b1d8e"), new Guid("013e4f26-f5a1-4c56-8f9a-3d77c89bbcc4") },
                    { new Guid("91593468-0be9-4543-9045-b02f112b1d8e"), new Guid("6aab099d-e302-4a07-8cf8-cb883a497465") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SupplierId",
                table: "AspNetUsers",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketProducts_ProductId",
                table: "BasketProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasketProducts");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
