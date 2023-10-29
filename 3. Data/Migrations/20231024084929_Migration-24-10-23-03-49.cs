using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3._Data.Migrations
{
    /// <inheritdoc />
    public partial class Migration2410230349 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "message",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    time = table.Column<DateTime>(type: "datetime", nullable: false),
                    content = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    send_by_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(6886)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "notifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(8043)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "premium",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    price = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(3729)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<int>(type: "int", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    gender = table.Column<string>(type: "char(1)", fixedLength: true, maxLength: 1, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    has_premium = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    profile_pic = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(7865)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "employer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(2115)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Employer_User",
                        column: x => x.User_id,
                        principalTable: "user",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "suscription",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Premium_id = table.Column<int>(type: "int", nullable: false),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    start_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(4824)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Suscription_Premium",
                        column: x => x.Premium_id,
                        principalTable: "premium",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Suscription_User",
                        column: x => x.User_id,
                        principalTable: "user",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "user_notifications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Notifications_id = table.Column<int>(type: "int", nullable: false),
                    read = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(9974)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "User_Notifications_Notifications",
                        column: x => x.Notifications_id,
                        principalTable: "notifications",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "User_Notifications_User",
                        column: x => x.User_id,
                        principalTable: "user",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "worker",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    occupation = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 108, DateTimeKind.Local).AddTicks(3281)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Worker_User",
                        column: x => x.User_id,
                        principalTable: "user",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subtitle = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imgUrl = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Employer_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(1596)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "posts_Employer",
                        column: x => x.Employer_id,
                        principalTable: "employer",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "advertisements",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    text = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    picture_url = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 103, DateTimeKind.Local).AddTicks(4604)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Advertisements_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imgUrl = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    institution_name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    teacher_name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    issue_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    certificate_name = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Certificates_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "chat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    Employer_id = table.Column<int>(type: "int", nullable: false),
                    creation_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    Message_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(515)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Chat_Employer",
                        column: x => x.Employer_id,
                        principalTable: "employer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Chat_Message",
                        column: x => x.Message_id,
                        principalTable: "message",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Chat_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "portfolio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image_url = table.Column<int>(type: "int", nullable: false),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(9309)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Portfolio_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Employer_id = table.Column<int>(type: "int", nullable: false),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    sent_by_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(5495)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Reviews_Employer",
                        column: x => x.Employer_id,
                        principalTable: "employer",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Reviews_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    content = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 107, DateTimeKind.Local).AddTicks(2046)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Table_62_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "contract",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Worker_id = table.Column<int>(type: "int", nullable: false),
                    content = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_day = table.Column<DateTime>(type: "datetime", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: false),
                    Posts_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(8645)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Contract_Worker",
                        column: x => x.Worker_id,
                        principalTable: "worker",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Contract_posts",
                        column: x => x.Posts_id,
                        principalTable: "posts",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    creation_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    Message_id = table.Column<int>(type: "int", nullable: false),
                    Chat_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 104, DateTimeKind.Local).AddTicks(5055)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Claims_Chat",
                        column: x => x.Chat_id,
                        principalTable: "chat",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "Claims_Message",
                        column: x => x.Message_id,
                        principalTable: "message",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "service",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Contract_id = table.Column<int>(type: "int", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 106, DateTimeKind.Local).AddTicks(9539)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Service_Contract",
                        column: x => x.Contract_id,
                        principalTable: "contract",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateTable(
                name: "evidences",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Claims_id = table.Column<int>(type: "int", nullable: false),
                    Date_created = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2023, 10, 24, 3, 49, 29, 105, DateTimeKind.Local).AddTicks(4829)),
                    Date_updated = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "Evidences_Claims",
                        column: x => x.Claims_id,
                        principalTable: "claims",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "Advertisements_Worker",
                table: "advertisements",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Certificates_Worker",
                table: "certificates",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Chat_Employer",
                table: "chat",
                column: "Employer_id");

            migrationBuilder.CreateIndex(
                name: "Chat_Message",
                table: "chat",
                column: "Message_id");

            migrationBuilder.CreateIndex(
                name: "Chat_Worker",
                table: "chat",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Claims_Chat",
                table: "claims",
                column: "Chat_id");

            migrationBuilder.CreateIndex(
                name: "Claims_Message",
                table: "claims",
                column: "Message_id");

            migrationBuilder.CreateIndex(
                name: "Contract_posts",
                table: "contract",
                column: "Posts_id");

            migrationBuilder.CreateIndex(
                name: "Contract_Worker",
                table: "contract",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Employer_User",
                table: "employer",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "Evidences_Claims",
                table: "evidences",
                column: "Claims_id");

            migrationBuilder.CreateIndex(
                name: "Portfolio_Worker",
                table: "portfolio",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "posts_Employer",
                table: "posts",
                column: "Employer_id");

            migrationBuilder.CreateIndex(
                name: "Reviews_Employer",
                table: "reviews",
                column: "Employer_id");

            migrationBuilder.CreateIndex(
                name: "Reviews_Worker",
                table: "reviews",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Service_Contract",
                table: "service",
                column: "Contract_id");

            migrationBuilder.CreateIndex(
                name: "Table_62_Worker",
                table: "skills",
                column: "Worker_id");

            migrationBuilder.CreateIndex(
                name: "Suscription_Premium",
                table: "suscription",
                column: "Premium_id");

            migrationBuilder.CreateIndex(
                name: "Suscription_User",
                table: "suscription",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "User_Notifications_Notifications",
                table: "user_notifications",
                column: "Notifications_id");

            migrationBuilder.CreateIndex(
                name: "User_Notifications_User",
                table: "user_notifications",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "Worker_User",
                table: "worker",
                column: "User_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "advertisements");

            migrationBuilder.DropTable(
                name: "certificates");

            migrationBuilder.DropTable(
                name: "evidences");

            migrationBuilder.DropTable(
                name: "portfolio");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "service");

            migrationBuilder.DropTable(
                name: "skills");

            migrationBuilder.DropTable(
                name: "suscription");

            migrationBuilder.DropTable(
                name: "user_notifications");

            migrationBuilder.DropTable(
                name: "claims");

            migrationBuilder.DropTable(
                name: "contract");

            migrationBuilder.DropTable(
                name: "premium");

            migrationBuilder.DropTable(
                name: "notifications");

            migrationBuilder.DropTable(
                name: "chat");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "message");

            migrationBuilder.DropTable(
                name: "worker");

            migrationBuilder.DropTable(
                name: "employer");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
