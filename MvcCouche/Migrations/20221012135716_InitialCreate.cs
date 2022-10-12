using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCouche.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Couche",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: false),
                    Colour = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    CountryOfOrigin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couche", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Couche");
        }
    }
}
