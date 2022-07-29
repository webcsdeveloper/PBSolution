using Microsoft.EntityFrameworkCore.Migrations;

namespace PB.Data.Migrations
{
    public partial class _20220721a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WAddrDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WInternalNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAddrDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
