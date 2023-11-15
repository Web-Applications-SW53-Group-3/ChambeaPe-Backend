using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedPasswordLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 730, DateTimeKind.Local).AddTicks(7770),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 336, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "varchar(60)",
                maxLength: 60,
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
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(9205),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 730, DateTimeKind.Local).AddTicks(2700),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 336, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(4577),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(3634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(320),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 728, DateTimeKind.Local).AddTicks(6650),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 728, DateTimeKind.Local).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(8529),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(5171),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(7388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(4194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(9262),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(7371),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(4287),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 332, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(571),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 332, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 725, DateTimeKind.Local).AddTicks(5231),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 331, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 724, DateTimeKind.Local).AddTicks(9593),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 331, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 724, DateTimeKind.Local).AddTicks(2686),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 330, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 723, DateTimeKind.Local).AddTicks(2906),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 330, DateTimeKind.Local).AddTicks(1445));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "worker",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 336, DateTimeKind.Local).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 730, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                collation: "utf8mb4_0900_ai_ci",
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "users",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "user_notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 336, DateTimeKind.Local).AddTicks(612),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 730, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "suscription",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(3634),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "skills",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 335, DateTimeKind.Local).AddTicks(341),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 729, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "service",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(7268),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 728, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "reviews",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(2545),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 728, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "premium",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 334, DateTimeKind.Local).AddTicks(154),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "posts",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(7388),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "portfolio",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(4194),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 727, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "notifications",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(2434),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "message",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 333, DateTimeKind.Local).AddTicks(704),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "evidences",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 332, DateTimeKind.Local).AddTicks(7678),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "employer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 332, DateTimeKind.Local).AddTicks(4588),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 726, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "contract",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 331, DateTimeKind.Local).AddTicks(9830),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 725, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "claims",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 331, DateTimeKind.Local).AddTicks(5172),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 724, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "chat",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 330, DateTimeKind.Local).AddTicks(9444),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 724, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date_created",
                table: "advertisements",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 1, 21, 8, 30, 330, DateTimeKind.Local).AddTicks(1445),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValue: new DateTime(2023, 11, 14, 19, 50, 36, 723, DateTimeKind.Local).AddTicks(2906));
        }
    }
}
