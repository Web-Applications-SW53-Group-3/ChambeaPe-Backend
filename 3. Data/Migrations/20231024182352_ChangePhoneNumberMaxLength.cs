using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangePhoneNumberMaxLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 468, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "users",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(5398),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(7987),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(1719),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(5647),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(1532),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(9320),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(6585),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(3758),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(2154),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(568),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(8011),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(3067));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(658),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 702, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 702, DateTimeKind.Local).AddTicks(1240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(289),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 701, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 462, DateTimeKind.Local).AddTicks(2828),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 700, DateTimeKind.Local).AddTicks(8079));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 468, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "users",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(376),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 706, DateTimeKind.Local).AddTicks(2961),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(7987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(6744),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 467, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(3625),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 705, DateTimeKind.Local).AddTicks(659),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(6548),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 466, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(4369),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 704, DateTimeKind.Local).AddTicks(1634),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(8805),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(7127),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(5653),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 465, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(3067),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 703, DateTimeKind.Local).AddTicks(33),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 702, DateTimeKind.Local).AddTicks(5817),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 464, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 702, DateTimeKind.Local).AddTicks(1240),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 701, DateTimeKind.Local).AddTicks(5432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 463, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 13, 18, 49, 700, DateTimeKind.Local).AddTicks(8079),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 13, 23, 51, 462, DateTimeKind.Local).AddTicks(2828));
        }
    }
}
