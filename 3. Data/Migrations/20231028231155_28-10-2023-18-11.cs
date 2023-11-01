using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class _281020231811 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 363, DateTimeKind.Local).AddTicks(2926),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(8664),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(1982),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(5662),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(9139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(3469),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(1708),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(7639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(4616),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(119),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 358, DateTimeKind.Local).AddTicks(5680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(9577),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 755, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(2048),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 754, DateTimeKind.Local).AddTicks(7808));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(9151),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 363, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 760, DateTimeKind.Local).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(7904),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 362, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(4447),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 759, DateTimeKind.Local).AddTicks(1209),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(6530),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 361, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(4224),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 758, DateTimeKind.Local).AddTicks(949),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(8172),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(6567),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(5092),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 360, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 757, DateTimeKind.Local).AddTicks(2692),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(7639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(9832),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(5663),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 359, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 756, DateTimeKind.Local).AddTicks(1359),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 358, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 755, DateTimeKind.Local).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 25, 0, 3, 5, 754, DateTimeKind.Local).AddTicks(7808),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 28, 18, 11, 54, 357, DateTimeKind.Local).AddTicks(2048));
        }
    }
}
