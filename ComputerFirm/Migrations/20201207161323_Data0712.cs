using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerFirm.Migrations
{
    public partial class Data0712 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderData = table.Column<DateTime>(nullable: false),
                    DueData = table.Column<DateTime>(nullable: false),
                    ShareofPrepayment = table.Column<int>(nullable: false),
                    PaymentMark = table.Column<bool>(nullable: false),
                    ExecutionMark = table.Column<bool>(nullable: false),
                    GeneralWarranttyPeriod = table.Column<DateTime>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false),
                    Customer_ID = table.Column<long>(nullable: false),
                    Component_1ID = table.Column<long>(nullable: false),
                    Component_2ID = table.Column<long>(nullable: false),
                    Component_3ID = table.Column<long>(nullable: false),
                    Service_1ID = table.Column<long>(nullable: false),
                    Service_2ID = table.Column<long>(nullable: false),
                    Service_3ID = table.Column<long>(nullable: false),
                    Staff_ID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Component",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    DataofIssue = table.Column<DateTime>(nullable: false),
                    WarrantyPeriod = table.Column<DateTime>(nullable: false),
                    Described = table.Column<string>(nullable: true),
                    Specificatrion = table.Column<string>(nullable: true),
                    CountryProduced = table.Column<string>(nullable: true),
                    TypesofСomponent_ID = table.Column<long>(nullable: false),
                    OrderID = table.Column<long>(nullable: true),
                    OrderID1 = table.Column<long>(nullable: true),
                    OrderID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Component", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Component_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Component_Order_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Component_Order_OrderID2",
                        column: x => x.OrderID2,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Telephone = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customer_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OrderID = table.Column<long>(nullable: true),
                    OrderID1 = table.Column<long>(nullable: true),
                    OrderID2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Service_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Order_OrderID1",
                        column: x => x.OrderID1,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Order_OrderID2",
                        column: x => x.OrderID2,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<short>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    PassportData = table.Column<string>(nullable: true),
                    Position_ID = table.Column<long>(nullable: false),
                    OrderID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypesofСomponent",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTypesofComponents = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ComponentID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesofСomponent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TypesofСomponent_Component_ComponentID",
                        column: x => x.ComponentID,
                        principalTable: "Component",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePosition = table.Column<string>(nullable: true),
                    Salary = table.Column<string>(nullable: true),
                    Duties = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Position_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Component_OrderID",
                table: "Component",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Component_OrderID1",
                table: "Component",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Component_OrderID2",
                table: "Component",
                column: "OrderID2");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderID",
                table: "Customer",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Position_StaffID",
                table: "Position",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_OrderID",
                table: "Service",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Service_OrderID1",
                table: "Service",
                column: "OrderID1");

            migrationBuilder.CreateIndex(
                name: "IX_Service_OrderID2",
                table: "Service",
                column: "OrderID2");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_OrderID",
                table: "Staff",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_TypesofСomponent_ComponentID",
                table: "TypesofСomponent",
                column: "ComponentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "TypesofСomponent");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Component");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
