using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.Migrations
{
    public partial class AddEngineerTagJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EngineerMachine");

            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EngineerTags",
                columns: table => new
                {
                    EngineerTagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EngineerId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineerTags", x => x.EngineerTagId);
                    table.ForeignKey(
                        name: "FK_EngineerTags_Engineers_EngineerId",
                        column: x => x.EngineerId,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngineerTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerTags_EngineerId",
                table: "EngineerTags",
                column: "EngineerId");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerTags_TagId",
                table: "EngineerTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Engineers_Machines_MachineId",
                table: "Engineers");

            migrationBuilder.DropTable(
                name: "EngineerTags");

            migrationBuilder.DropIndex(
                name: "IX_Engineers_MachineId",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");

            migrationBuilder.CreateTable(
                name: "EngineerMachine",
                columns: table => new
                {
                    EngineersEngineerID = table.Column<int>(type: "int", nullable: false),
                    MachinesMachineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineerMachine", x => new { x.EngineersEngineerID, x.MachinesMachineId });
                    table.ForeignKey(
                        name: "FK_EngineerMachine_Engineers_EngineersEngineerID",
                        column: x => x.EngineersEngineerID,
                        principalTable: "Engineers",
                        principalColumn: "EngineerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EngineerMachine_Machines_MachinesMachineId",
                        column: x => x.MachinesMachineId,
                        principalTable: "Machines",
                        principalColumn: "MachineId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EngineerMachine_MachinesMachineId",
                table: "EngineerMachine",
                column: "MachinesMachineId");
        }
    }
}
