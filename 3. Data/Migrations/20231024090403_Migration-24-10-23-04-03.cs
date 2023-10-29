using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration2410230403 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(8044),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 108, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(2652),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(4555),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(6680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(3668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(9938),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(5260),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 455, DateTimeKind.Local).AddTicks(9311),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 103, DateTimeKind.Local).AddTicks(4604));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 108, DateTimeKind.Local).AddTicks(3281),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(9974),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(7865),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(4824),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(2046),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(9539),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(5495),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(1596),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(9309),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(8043),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(6886),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(2115),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(8645),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(515),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 103, DateTimeKind.Local).AddTicks(4604),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 455, DateTimeKind.Local).AddTicks(9311));
        }
    }
}
