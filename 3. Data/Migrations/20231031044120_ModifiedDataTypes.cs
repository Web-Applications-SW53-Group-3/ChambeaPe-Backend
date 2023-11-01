using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedDataTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 144, DateTimeKind.Local).AddTicks(2639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 363, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(8901),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(2853),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(7156),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(1139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(8583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "portfolio",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(5818),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(4271),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(2945),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(7816),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(3781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 358, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 138, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(2048));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "reviews");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 363, DateTimeKind.Local).AddTicks(2926),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 144, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(8664),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(5662),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(9139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.AlterColumn<int>(
                name: "image_url",
                table: "portfolio",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(3469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(1708),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(7639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(4616),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(119),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 358, DateTimeKind.Local).AddTicks(5680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(9577),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(2048),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 138, DateTimeKind.Local).AddTicks(7456));
        }
    }
}
