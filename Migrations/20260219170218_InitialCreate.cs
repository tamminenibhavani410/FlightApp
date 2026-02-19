using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flight.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightModel",
                columns: table => new
                {
                    FlightModelId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightNumber = table.Column<string>(type: "TEXT", nullable: false),
                    From = table.Column<string>(type: "TEXT", nullable: false),
                    To = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightModel", x => x.FlightModelId);
                });

            migrationBuilder.InsertData(
                table: "FlightModel",
                columns: new[] { "FlightModelId", "Date", "FlightNumber", "From", "Price", "To" },
                values: new object[,]
                {
                    { 1, "2/15/2026", "UA3321", "Chicago", 235, "New York" },
                    { 2, "3/1/2026", "QA1078", "Dubai", 590, "London" },
                    { 3, "6/15/2026", "UA3321", "Hong Kong", 900, "San Francisco" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightModel");
        }
    }
}
