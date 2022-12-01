using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UP.Data.Migrations
{
    public partial class newtablesDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jobname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Jobstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    TrainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainDes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.TrainID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Training");
        }
    }
}
