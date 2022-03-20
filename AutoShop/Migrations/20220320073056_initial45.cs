using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoShop1.Migrations
{
    public partial class initial45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoShop",
                columns: table => new
                {
                    IdCar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarName = table.Column<string>(nullable: true),
                    Manifacture = table.Column<string>(nullable: true),
                    CarLocation = table.Column<string>(nullable: true),
                    CarPower = table.Column<string>(nullable: true),
                    CarTransmission = table.Column<string>(nullable: true),
                    CarColor = table.Column<string>(nullable: true),
                    CarPrice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.IdCar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoShop");
        }
    }
}
