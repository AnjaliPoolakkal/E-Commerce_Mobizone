﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalog.Domain.Migrations
{
    public partial class InitialCatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookUp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "Varchar(50)", nullable: true),
                    OsSupported = table.Column<string>(type: "Varchar(100)", nullable: true),
                    SystemRequirement = table.Column<string>(type: "Varchar(100)", nullable: true),
                    SimType = table.Column<string>(type: "Varchar(100)", nullable: true),
                    HybridSlot = table.Column<string>(type: "Varchar(100)", nullable: true),
                    DisplaySize = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Resolution = table.Column<string>(type: "Varchar(100)", nullable: true),
                    ResolutionType = table.Column<string>(type: "Varchar(100)", nullable: true),
                    DisplayType = table.Column<string>(type: "Varchar(100)", nullable: true),
                    OtherFeatures = table.Column<string>(type: "Varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Contact = table.Column<long>(type: "bigInt", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(50)", nullable: false),
                    SpecificationId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(12,3)", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<string>(type: "Varchar(50)", nullable: false),
                    createdDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LookUpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_LookUp_LookUpId",
                        column: x => x.LookUpId,
                        principalTable: "LookUp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LookUpId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_LookUp_LookUpId",
                        column: x => x.LookUpId,
                        principalTable: "LookUp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItem_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    UserLocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAddress_UserLocation_UserLocationId",
                        column: x => x.UserLocationId,
                        principalTable: "UserLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_url = table.Column<string>(type: "Varchar(300)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    created_on_utc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_on_utc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_by = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CatalogOrderId = table.Column<int>(type: "int", nullable: true),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdetedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdetedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "Decimal(12,3)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CatalogOrderId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: false),
                    PaymentDetailsId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_PaymentDetails_PaymentDetailsId",
                        column: x => x.PaymentDetailsId,
                        principalTable: "PaymentDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<int>(type: "int", nullable: true),
                    LookUpId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderDetailsId = table.Column<int>(type: "int", nullable: false),
                    createdDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogOrder_LookUp_LookUpId",
                        column: x => x.LookUpId,
                        principalTable: "LookUp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogOrder_OrderDetails_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogOrder_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LookUp",
                columns: new[] { "Id", "ParentId", "Name" },
                values: new object[,]
                {
                    { 1, 0, "ProductType" },
                    { 2, 0, "ProductBrand" },
                    { 3, 0, "Color" },
                    { 4, 0, "Storage" },
                    { 5, 0, "SimType" },
                    { 6, 0, "OperatingSystem" },
                    { 7, 0, "ProcessorType" },
                    { 8, 0, "ProcessorCore" },
                    { 9, 0, "PrimaryCamera" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_LookUpId",
                table: "CartItem",
                column: "LookUpId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_UserId",
                table: "CartItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogOrder_LookUpId",
                table: "CatalogOrder",
                column: "LookUpId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogOrder_OrderDetailsId",
                table: "CatalogOrder",
                column: "OrderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogOrder_ProductId1",
                table: "CatalogOrder",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PaymentDetailsId",
                table: "OrderDetails",
                column: "PaymentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_UserId",
                table: "OrderDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_CatalogOrderId",
                table: "OrderStatus",
                column: "CatalogOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_CatalogOrderId",
                table: "PaymentDetails",
                column: "CatalogOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LookUpId",
                table: "Products",
                column: "LookUpId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpecificationId",
                table: "Products",
                column: "SpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_UserId",
                table: "Role",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserId",
                table: "UserAddress",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAddress_UserLocationId",
                table: "UserAddress",
                column: "UserLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatus_CatalogOrder_CatalogOrderId",
                table: "OrderStatus",
                column: "CatalogOrderId",
                principalTable: "CatalogOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_CatalogOrder_CatalogOrderId",
                table: "PaymentDetails",
                column: "CatalogOrderId",
                principalTable: "CatalogOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogOrder_LookUp_LookUpId",
                table: "CatalogOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LookUp_LookUpId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_User_UserId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogOrder_OrderDetails_OrderDetailsId",
                table: "CatalogOrder");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "UserLocation");

            migrationBuilder.DropTable(
                name: "LookUp");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.DropTable(
                name: "CatalogOrder");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Specifications");
        }
    }
}
