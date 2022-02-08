using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Quadrant = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_responses_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 2, 1, false, new DateTime(2022, 8, 20, 5, 15, 0, 0, DateTimeKind.Unspecified), 2, "Eat Dinner" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 3, 1, false, new DateTime(2022, 6, 20, 9, 15, 0, 0, DateTimeKind.Unspecified), 4, "Watch a Movie" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "TaskID", "CategoryID", "Completed", "DueDate", "Quadrant", "Task" },
                values: new object[] { 1, 2, true, new DateTime(2022, 7, 20, 9, 15, 0, 0, DateTimeKind.Unspecified), 1, "Finish Homework" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryID",
                table: "responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
