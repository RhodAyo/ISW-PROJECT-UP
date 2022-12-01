using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UP.Data.Migrations
{
    public partial class tablesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryCatId",
                table: "Training",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "jobcatCatId",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "joblocateLocationID",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Locationname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationPostalcode = table.Column<int>(type: "int", nullable: false),
                    LocationState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "TrainingLevel",
                columns: table => new
                {
                    TrainingId = table.Column<int>(type: "int", nullable: false),
                    TrainingLevels = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingLevel", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_TrainingLevel_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "TrainID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_categoryCatId",
                table: "Training",
                column: "categoryCatId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_jobcatCatId",
                table: "Job",
                column: "jobcatCatId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_joblocateLocationID",
                table: "Job",
                column: "joblocateLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Category_jobcatCatId",
                table: "Job",
                column: "jobcatCatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Location_joblocateLocationID",
                table: "Job",
                column: "joblocateLocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Category_categoryCatId",
                table: "Training",
                column: "categoryCatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Category_jobcatCatId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Location_joblocateLocationID",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Category_categoryCatId",
                table: "Training");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "TrainingLevel");

            migrationBuilder.DropIndex(
                name: "IX_Training_categoryCatId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Job_jobcatCatId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_joblocateLocationID",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "categoryCatId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "jobcatCatId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "joblocateLocationID",
                table: "Job");
        }
    }
}
