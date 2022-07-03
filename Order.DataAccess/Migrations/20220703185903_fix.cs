using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Orders.DataAccess.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unitPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "unitStock",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "unitPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "unitStock",
                table: "Products");
        }
    }
}
