using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingDay",
                table: "Workouts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainingDay",
                table: "Workouts");
        }
    }
}
