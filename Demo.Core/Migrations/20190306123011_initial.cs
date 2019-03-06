using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Core.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BagCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<int>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CategoryDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BagType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<int>(nullable: true),
                    LastModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    BagName = table.Column<string>(maxLength: 50, nullable: true),
                    BagDesc = table.Column<string>(nullable: true),
                    BagCategoryNo = table.Column<short>(nullable: false),
                    TareWeight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BagCategory");

            migrationBuilder.DropTable(
                name: "BagType");
        }
    }
}
