using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAccessLayer.Migrations
{
    public partial class mig_add_messageCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MessageCategoyID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MessageCategoys",
                columns: table => new
                {
                    MessageCategoyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageCategoyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageCategoys", x => x.MessageCategoyID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageCategoyID",
                table: "Contacts",
                column: "MessageCategoyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategoys_MessageCategoyID",
                table: "Contacts",
                column: "MessageCategoyID",
                principalTable: "MessageCategoys",
                principalColumn: "MessageCategoyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategoys_MessageCategoyID",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "MessageCategoys");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_MessageCategoyID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "MessageCategoyID",
                table: "Contacts");
        }
    }
}
