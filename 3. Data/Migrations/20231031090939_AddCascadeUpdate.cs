using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCascadeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Employer_User",
                table: "employer");

            migrationBuilder.DropForeignKey(
                name: "Worker_User",
                table: "worker");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 144, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(1374),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(4107),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(7681),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(7630),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(5493),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(128),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(7078),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(4638),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(1751),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 251, DateTimeKind.Local).AddTicks(7667),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 251, DateTimeKind.Local).AddTicks(3403),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 250, DateTimeKind.Local).AddTicks(7723),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 250, DateTimeKind.Local).AddTicks(410),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 138, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.AddForeignKey(
                name: "Employer_User",
                table: "employer",
                column: "User_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "Worker_User",
                table: "worker",
                column: "User_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Employer_User",
                table: "employer");

            migrationBuilder.DropForeignKey(
                name: "Worker_User",
                table: "worker");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 144, DateTimeKind.Local).AddTicks(2639),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(8901),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 255, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 143, DateTimeKind.Local).AddTicks(2853),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(9903),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(7156),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 254, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 142, DateTimeKind.Local).AddTicks(1139),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(8583),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(5818),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 253, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(4271),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(2945),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 141, DateTimeKind.Local).AddTicks(593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(4638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(7816),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 252, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 140, DateTimeKind.Local).AddTicks(3781),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 251, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(9694),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 251, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 139, DateTimeKind.Local).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 250, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 23, 41, 19, 138, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 10, 31, 4, 9, 38, 250, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.AddForeignKey(
                name: "Employer_User",
                table: "employer",
                column: "User_id",
                principalTable: "users",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "Worker_User",
                table: "worker",
                column: "User_id",
                principalTable: "users",
                principalColumn: "id");
        }
    }
}
