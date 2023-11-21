using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPostulationEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 849, DateTimeKind.Local).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(6729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(9689),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(2623),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(9093),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(5741),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(1169),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(8716),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(5736),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(525),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(8835),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(2722),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 844, DateTimeKind.Local).AddTicks(8124),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 622, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 844, DateTimeKind.Local).AddTicks(3208),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 622, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 843, DateTimeKind.Local).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 621, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 842, DateTimeKind.Local).AddTicks(8639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 620, DateTimeKind.Local).AddTicks(6845));

            migrationBuilder.CreateTable(
                name: "postulations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 849, DateTimeKind.Local).AddTicks(9127)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_postulations_posts_PostId",
                        column: x => x.PostId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_postulations_worker_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "worker",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_postulations_PostId",
                table: "postulations",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_postulations_WorkerId",
                table: "postulations",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "postulations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(9620),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 849, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(2593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 626, DateTimeKind.Local).AddTicks(5488),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(8636),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 848, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(5063),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 625, DateTimeKind.Local).AddTicks(2042),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(7768),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 847, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(5346),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 624, DateTimeKind.Local).AddTicks(2560),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(9508),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(7772),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 846, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(6190),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(3720),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 623, DateTimeKind.Local).AddTicks(562),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 845, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 622, DateTimeKind.Local).AddTicks(6144),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 844, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 622, DateTimeKind.Local).AddTicks(1450),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 844, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 621, DateTimeKind.Local).AddTicks(5356),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 843, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 14, 53, 52, 620, DateTimeKind.Local).AddTicks(6845),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 21, 14, 58, 45, 842, DateTimeKind.Local).AddTicks(8639));
        }
    }
}
