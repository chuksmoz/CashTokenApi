using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CashToken.Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionTokens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    SourceAccount = table.Column<string>(nullable: false),
                    BeneficiaryNumber = table.Column<string>(nullable: false),
                    DepositorNumber = table.Column<string>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Token = table.Column<string>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionTokens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionTokens");
        }
    }
}
