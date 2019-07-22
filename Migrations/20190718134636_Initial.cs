using Microsoft.EntityFrameworkCore.Migrations;

namespace QxHOracleLoader.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlanSeqId = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderSldTdy = table.Column<int>(nullable: false),
                    PlannedMinutesQty = table.Column<int>(nullable: false),
                    ActualMinutesQty = table.Column<int>(nullable: false),
                    NetworkId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    AvaiForSaleQty = table.Column<int>(nullable: false),
                    ShowDate = table.Column<string>(nullable: true),
                    ShowCd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
