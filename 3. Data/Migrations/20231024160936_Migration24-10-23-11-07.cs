using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration2410231107 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "user",
                newName: "users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 206, DateTimeKind.Local).AddTicks(2065),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(862),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(7521),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(4330),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(37),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(7702),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(4704),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(1552),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(9668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(5085),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(1619),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 201, DateTimeKind.Local).AddTicks(5041),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 201, DateTimeKind.Local).AddTicks(314),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 200, DateTimeKind.Local).AddTicks(4406),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 199, DateTimeKind.Local).AddTicks(6933),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 455, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(4809),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(2652));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "users",
                newName: "user");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(8044),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 206, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(4555),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 459, DateTimeKind.Local).AddTicks(1090),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 204, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(9227),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(6680),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(4285),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 203, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(9668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 458, DateTimeKind.Local).AddTicks(1819),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(7276),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 202, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 457, DateTimeKind.Local).AddTicks(3668),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 201, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(9938),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 201, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 456, DateTimeKind.Local).AddTicks(5260),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 200, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 455, DateTimeKind.Local).AddTicks(9311),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 199, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 24, 4, 4, 3, 460, DateTimeKind.Local).AddTicks(2652),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 24, 11, 9, 35, 205, DateTimeKind.Local).AddTicks(4809));
        }
    }
}
