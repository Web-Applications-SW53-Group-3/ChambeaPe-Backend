using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "worker");

            migrationBuilder.DropColumn(
                name: "description",
                table: "employer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(9375),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 468, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(2390),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "users",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(5164),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(8515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(5273),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(2261),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(7951),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(5544),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(2782),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(9874),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(8129),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(6364),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(3738),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(662),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 709, DateTimeKind.Local).AddTicks(6271),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 709, DateTimeKind.Local).AddTicks(1910),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 708, DateTimeKind.Local).AddTicks(6082),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 707, DateTimeKind.Local).AddTicks(8680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 462, DateTimeKind.Local).AddTicks(2828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 468, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "worker",
                type: "text",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(5398),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 713, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 712, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(1532),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(7951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 711, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(3758),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 710, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "employer",
                type: "text",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 709, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 709, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 708, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 462, DateTimeKind.Local).AddTicks(2828),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 23, 54, 11, 707, DateTimeKind.Local).AddTicks(8680));
        }
    }
}
