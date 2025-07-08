using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GymApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SetEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.CreateTable(
                name: "SetEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseWorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetEntity", x => new { x.ExerciseWorkoutId, x.ExerciseId, x.Id });
                    table.ForeignKey(
                        name: "FK_SetEntity_Exercises_ExerciseWorkoutId_ExerciseId",
                        columns: x => new { x.ExerciseWorkoutId, x.ExerciseId },
                        principalTable: "Exercises",
                        principalColumns: new[] { "WorkoutId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetEntity");

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    ExerciseWorkoutId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExerciseId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reps = table.Column<int>(type: "integer", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => new { x.ExerciseWorkoutId, x.ExerciseId, x.Id });
                    table.ForeignKey(
                        name: "FK_Set_Exercises_ExerciseWorkoutId_ExerciseId",
                        columns: x => new { x.ExerciseWorkoutId, x.ExerciseId },
                        principalTable: "Exercises",
                        principalColumns: new[] { "WorkoutId", "Id" },
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
