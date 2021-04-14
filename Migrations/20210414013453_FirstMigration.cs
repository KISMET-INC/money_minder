using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace money_minder.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountBalances",
                columns: table => new
                {
                    Total = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountBalances", x => x.Total);
                });

            migrationBuilder.CreateTable(
                name: "Paychecks",
                columns: table => new
                {
                    PayDate = table.Column<DateTime>(nullable: false),
                    From = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paychecks", x => x.PayDate);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Total = table.Column<decimal>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Due = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PaycheckPayDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Total);
                    table.ForeignKey(
                        name: "FK_Bills_Paychecks_PaycheckPayDate",
                        column: x => x.PaycheckPayDate,
                        principalTable: "Paychecks",
                        principalColumn: "PayDate",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BillHistories",
                columns: table => new
                {
                    Total = table.Column<decimal>(nullable: false),
                    PaidDate = table.Column<DateTime>(nullable: false),
                    BillId = table.Column<int>(nullable: false),
                    SourceTotal = table.Column<decimal>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillHistories", x => x.Total);
                    table.ForeignKey(
                        name: "FK_BillHistories_Bills_SourceTotal",
                        column: x => x.SourceTotal,
                        principalTable: "Bills",
                        principalColumn: "Total",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillHistories_SourceTotal",
                table: "BillHistories",
                column: "SourceTotal");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PaycheckPayDate",
                table: "Bills",
                column: "PaycheckPayDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountBalances");

            migrationBuilder.DropTable(
                name: "BillHistories");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Paychecks");
        }
    }
}
