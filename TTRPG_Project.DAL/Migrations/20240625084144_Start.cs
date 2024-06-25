using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TTRPG_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastActivity = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RefreshToken = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsRemember = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogMessage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLogs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttentionId = table.Column<int>(type: "int", nullable: true),
                    AttentionValue = table.Column<int>(type: "int", nullable: true),
                    SurvivalId = table.Column<int>(type: "int", nullable: true),
                    SurvivalValue = table.Column<int>(type: "int", nullable: true),
                    DeductionId = table.Column<int>(type: "int", nullable: true),
                    DeductionValue = table.Column<int>(type: "int", nullable: true),
                    MonsterologyId = table.Column<int>(type: "int", nullable: true),
                    MonsterologyValue = table.Column<int>(type: "int", nullable: true),
                    EducationId = table.Column<int>(type: "int", nullable: true),
                    EducationValue = table.Column<int>(type: "int", nullable: true),
                    CityOrientationId = table.Column<int>(type: "int", nullable: true),
                    CityOrientationValue = table.Column<int>(type: "int", nullable: true),
                    KnowledgeTransferId = table.Column<int>(type: "int", nullable: true),
                    KnowledgeTransferValue = table.Column<int>(type: "int", nullable: true),
                    TacticsId = table.Column<int>(type: "int", nullable: true),
                    TacticsValue = table.Column<int>(type: "int", nullable: true),
                    TradingId = table.Column<int>(type: "int", nullable: true),
                    TradingValue = table.Column<int>(type: "int", nullable: true),
                    EtiquetteId = table.Column<int>(type: "int", nullable: true),
                    EtiquetteValue = table.Column<int>(type: "int", nullable: true),
                    LanguageGeneralId = table.Column<int>(type: "int", nullable: true),
                    LanguageGeneralValue = table.Column<int>(type: "int", nullable: true),
                    LanguageHighId = table.Column<int>(type: "int", nullable: true),
                    LanguageHighValue = table.Column<int>(type: "int", nullable: true),
                    LanguageDwarfId = table.Column<int>(type: "int", nullable: true),
                    LanguageDwarfValue = table.Column<int>(type: "int", nullable: true),
                    StrengthId = table.Column<int>(type: "int", nullable: true),
                    StrengthValue = table.Column<int>(type: "int", nullable: true),
                    EnduranceId = table.Column<int>(type: "int", nullable: true),
                    EnduranceValue = table.Column<int>(type: "int", nullable: true),
                    MeleeCombatId = table.Column<int>(type: "int", nullable: true),
                    MeleeCombatValue = table.Column<int>(type: "int", nullable: true),
                    WrestlingId = table.Column<int>(type: "int", nullable: true),
                    WrestlingValue = table.Column<int>(type: "int", nullable: true),
                    RidingId = table.Column<int>(type: "int", nullable: true),
                    RidingValue = table.Column<int>(type: "int", nullable: true),
                    PoleWeaponMasteryId = table.Column<int>(type: "int", nullable: true),
                    PoleWeaponMasteryValue = table.Column<int>(type: "int", nullable: true),
                    LightBladeMasteryId = table.Column<int>(type: "int", nullable: true),
                    LightBladeMasteryValue = table.Column<int>(type: "int", nullable: true),
                    SwordsmanshipId = table.Column<int>(type: "int", nullable: true),
                    SwordsmanshipValue = table.Column<int>(type: "int", nullable: true),
                    SeamanshipId = table.Column<int>(type: "int", nullable: true),
                    SeamanshipValue = table.Column<int>(type: "int", nullable: true),
                    EvasionId = table.Column<int>(type: "int", nullable: true),
                    EvasionValue = table.Column<int>(type: "int", nullable: true),
                    AthleticsId = table.Column<int>(type: "int", nullable: true),
                    AthleticsValue = table.Column<int>(type: "int", nullable: true),
                    ManualDexterityId = table.Column<int>(type: "int", nullable: true),
                    ManualDexterityValue = table.Column<int>(type: "int", nullable: true),
                    StealthId = table.Column<int>(type: "int", nullable: true),
                    StealthValue = table.Column<int>(type: "int", nullable: true),
                    CrossbowMasteryId = table.Column<int>(type: "int", nullable: true),
                    CrossbowMasteryValue = table.Column<int>(type: "int", nullable: true),
                    ArcheryId = table.Column<int>(type: "int", nullable: true),
                    ArcheryValue = table.Column<int>(type: "int", nullable: true),
                    GamblingId = table.Column<int>(type: "int", nullable: true),
                    GamblingValue = table.Column<int>(type: "int", nullable: true),
                    AppearanceId = table.Column<int>(type: "int", nullable: true),
                    AppearanceValue = table.Column<int>(type: "int", nullable: true),
                    PublicSpeakingId = table.Column<int>(type: "int", nullable: true),
                    PublicSpeakingValue = table.Column<int>(type: "int", nullable: true),
                    ArtistryId = table.Column<int>(type: "int", nullable: true),
                    ArtistryValue = table.Column<int>(type: "int", nullable: true),
                    LeadershipId = table.Column<int>(type: "int", nullable: true),
                    LeadershipValue = table.Column<int>(type: "int", nullable: true),
                    DeceptionId = table.Column<int>(type: "int", nullable: true),
                    DeceptionValue = table.Column<int>(type: "int", nullable: true),
                    UnderstandingPeopleId = table.Column<int>(type: "int", nullable: true),
                    UnderstandingPeopleValue = table.Column<int>(type: "int", nullable: true),
                    SeductionId = table.Column<int>(type: "int", nullable: true),
                    SeductionValue = table.Column<int>(type: "int", nullable: true),
                    PersuasionId = table.Column<int>(type: "int", nullable: true),
                    PersuasionValue = table.Column<int>(type: "int", nullable: true),
                    CharismaId = table.Column<int>(type: "int", nullable: true),
                    CharismaValue = table.Column<int>(type: "int", nullable: true),
                    AlchemyId = table.Column<int>(type: "int", nullable: true),
                    AlchemyValue = table.Column<int>(type: "int", nullable: true),
                    LockpickingId = table.Column<int>(type: "int", nullable: true),
                    LockpickingValue = table.Column<int>(type: "int", nullable: true),
                    TrapKnowledgeId = table.Column<int>(type: "int", nullable: true),
                    TrapKnowledgeValue = table.Column<int>(type: "int", nullable: true),
                    ManufacturingId = table.Column<int>(type: "int", nullable: true),
                    ManufacturingValue = table.Column<int>(type: "int", nullable: true),
                    CamouflageId = table.Column<int>(type: "int", nullable: true),
                    CamouflageValue = table.Column<int>(type: "int", nullable: true),
                    FirstAidId = table.Column<int>(type: "int", nullable: true),
                    FirstAidValue = table.Column<int>(type: "int", nullable: true),
                    ForgeryId = table.Column<int>(type: "int", nullable: true),
                    ForgeryValue = table.Column<int>(type: "int", nullable: true),
                    IntimidationId = table.Column<int>(type: "int", nullable: true),
                    IntimidationValue = table.Column<int>(type: "int", nullable: true),
                    CorruptionId = table.Column<int>(type: "int", nullable: true),
                    CorruptionValue = table.Column<int>(type: "int", nullable: true),
                    RitualsId = table.Column<int>(type: "int", nullable: true),
                    RitualsValue = table.Column<int>(type: "int", nullable: true),
                    MagicResistanceId = table.Column<int>(type: "int", nullable: true),
                    MagicResistanceValue = table.Column<int>(type: "int", nullable: true),
                    PersuasionResistanceId = table.Column<int>(type: "int", nullable: true),
                    PersuasionResistanceValue = table.Column<int>(type: "int", nullable: true),
                    SpellcastingId = table.Column<int>(type: "int", nullable: true),
                    SpellcastingValue = table.Column<int>(type: "int", nullable: true),
                    CourageId = table.Column<int>(type: "int", nullable: true),
                    CourageValue = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsList", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StatsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IntellectId = table.Column<int>(type: "int", nullable: false),
                    IntellectValue = table.Column<int>(type: "int", nullable: false),
                    ReactionId = table.Column<int>(type: "int", nullable: false),
                    ReactionValue = table.Column<int>(type: "int", nullable: false),
                    DexterityId = table.Column<int>(type: "int", nullable: false),
                    DexterityValue = table.Column<int>(type: "int", nullable: false),
                    ConstitutionId = table.Column<int>(type: "int", nullable: false),
                    ConstitutionValue = table.Column<int>(type: "int", nullable: false),
                    SpeedId = table.Column<int>(type: "int", nullable: false),
                    SpeedValue = table.Column<int>(type: "int", nullable: false),
                    EmpathyId = table.Column<int>(type: "int", nullable: false),
                    EmpathyValue = table.Column<int>(type: "int", nullable: false),
                    CraftsmanshipId = table.Column<int>(type: "int", nullable: false),
                    CraftsmanshipValue = table.Column<int>(type: "int", nullable: false),
                    WillpowerId = table.Column<int>(type: "int", nullable: false),
                    WillpowerValue = table.Column<int>(type: "int", nullable: false),
                    LuckId = table.Column<int>(type: "int", nullable: false),
                    LuckValue = table.Column<int>(type: "int", nullable: false),
                    EnergyId = table.Column<int>(type: "int", nullable: false),
                    EnergyValue = table.Column<int>(type: "int", nullable: false),
                    ResilienceId = table.Column<int>(type: "int", nullable: false),
                    ResilienceValue = table.Column<int>(type: "int", nullable: false),
                    RunningId = table.Column<int>(type: "int", nullable: false),
                    RunningValue = table.Column<int>(type: "int", nullable: false),
                    JumpingId = table.Column<int>(type: "int", nullable: false),
                    JumpingValue = table.Column<int>(type: "int", nullable: false),
                    HealthPointsId = table.Column<int>(type: "int", nullable: false),
                    HealthPointsValue = table.Column<int>(type: "int", nullable: false),
                    EnduranceId = table.Column<int>(type: "int", nullable: false),
                    EnduranceValue = table.Column<int>(type: "int", nullable: false),
                    WeightId = table.Column<int>(type: "int", nullable: false),
                    WeightValue = table.Column<int>(type: "int", nullable: false),
                    RestId = table.Column<int>(type: "int", nullable: false),
                    RestValue = table.Column<int>(type: "int", nullable: false),
                    HandStrikeId = table.Column<int>(type: "int", nullable: false),
                    HandStrikeValue = table.Column<int>(type: "int", nullable: false),
                    KickId = table.Column<int>(type: "int", nullable: false),
                    KickValue = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsList", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    AttackType = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    AttackSpeed = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attacks_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Effects_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Headlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headlines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headlines_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AvailabilityType = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemBases_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mutagen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    Effect = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mutation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutagen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mutagen_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServicePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePrices_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SkillsTree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MainSkillId = table.Column<int>(type: "int", nullable: false),
                    MainSkillValue = table.Column<int>(type: "int", nullable: false),
                    FirstLeftSkillId = table.Column<int>(type: "int", nullable: false),
                    SecondLeftSkillId = table.Column<int>(type: "int", nullable: false),
                    ThirdLeftSkillId = table.Column<int>(type: "int", nullable: false),
                    FirstLeftSkillValue = table.Column<int>(type: "int", nullable: false),
                    SecondLeftSkillValue = table.Column<int>(type: "int", nullable: false),
                    ThirdLeftSkillValue = table.Column<int>(type: "int", nullable: false),
                    FirstMiddleSkillId = table.Column<int>(type: "int", nullable: false),
                    SecondMiddleSkillId = table.Column<int>(type: "int", nullable: false),
                    ThirdMiddleSkillId = table.Column<int>(type: "int", nullable: false),
                    FirstMiddleSkillValue = table.Column<int>(type: "int", nullable: false),
                    SecondMiddleSkillValue = table.Column<int>(type: "int", nullable: false),
                    ThirdMiddleSkillValue = table.Column<int>(type: "int", nullable: false),
                    FirstRightSkillId = table.Column<int>(type: "int", nullable: false),
                    SecondRightSkillId = table.Column<int>(type: "int", nullable: false),
                    ThirdRightSkillId = table.Column<int>(type: "int", nullable: false),
                    FirstRightSkillValue = table.Column<int>(type: "int", nullable: false),
                    SecondRightSkillValue = table.Column<int>(type: "int", nullable: false),
                    ThirdRightSkillValue = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsTree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillsTree_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trophy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trophy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trophy_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AttackEffectList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AttackId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChancePercent = table.Column<int>(type: "int", nullable: false),
                    IsDealDamage = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackEffectList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttackEffectList_Attacks_AttackId",
                        column: x => x.AttackId,
                        principalTable: "Attacks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttackEffectList_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlchemicalItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemicalItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlchemicalItems_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    EquipmentType = table.Column<int>(type: "int", nullable: false),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    AmountOfEnhancements = table.Column<int>(type: "int", nullable: false),
                    Stiffness = table.Column<int>(type: "int", nullable: false),
                    ItemOriginType = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Armors_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Blueprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    TimeSpend = table.Column<float>(type: "float", nullable: false),
                    AdditionalPayment = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blueprints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blueprints_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    WhereToFind = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Amount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    IsAlchemical = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SubstanceType = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Components_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Formulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    TimeSpend = table.Column<float>(type: "float", nullable: false),
                    AdditionalPayment = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formulas_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ItemBaseEffectList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChancePercent = table.Column<int>(type: "int", nullable: false),
                    IsDealDamage = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBaseEffectList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemBaseEffectList_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemBaseEffectList_ItemBases_ItemBaseId",
                        column: x => x.ItemBaseId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StealthType = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reward_ItemBases_ItemBaseId",
                        column: x => x.ItemBaseId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    StealthType = table.Column<int>(type: "int", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tools_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abilities_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Abilities_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Energy = table.Column<int>(type: "int", nullable: false),
                    DefaultMagicAbilities = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SkillsTreeId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_SkillsTree_SkillsTreeId",
                        column: x => x.SkillsTreeId,
                        principalTable: "SkillsTree",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Classes_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDifficult = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsClassSkill = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StatId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Skills_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EducationSkill = table.Column<int>(type: "int", nullable: false),
                    SuperstitionsInformation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MonsterLoreSkill = table.Column<int>(type: "int", nullable: false),
                    MonsterLoreInformation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    MoneyReward = table.Column<int>(type: "int", nullable: false),
                    Armor = table.Column<int>(type: "int", nullable: false),
                    Regeneration = table.Column<int>(type: "int", nullable: false),
                    StatsListId = table.Column<int>(type: "int", nullable: true),
                    SkillsListId = table.Column<int>(type: "int", nullable: true),
                    EvasionBase = table.Column<int>(type: "int", nullable: false),
                    AthleticsBase = table.Column<int>(type: "int", nullable: false),
                    BlockBase = table.Column<int>(type: "int", nullable: false),
                    SpellResistBase = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "float", nullable: false),
                    HabitatPlace = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Intellect = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GroupSize = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MutagenId = table.Column<int>(type: "int", nullable: true),
                    TrophyId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Creatures_Mutagen_MutagenId",
                        column: x => x.MutagenId,
                        principalTable: "Mutagen",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Creatures_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Creatures_SkillsList_SkillsListId",
                        column: x => x.SkillsListId,
                        principalTable: "SkillsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Creatures_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Creatures_StatsList_StatsListId",
                        column: x => x.StatsListId,
                        principalTable: "StatsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Creatures_Trophy_TrophyId",
                        column: x => x.TrophyId,
                        principalTable: "Trophy",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlueprintComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BlueprintId = table.Column<int>(type: "int", nullable: true),
                    ComponentId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlueprintComponentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlueprintComponentList_Blueprints_BlueprintId",
                        column: x => x.BlueprintId,
                        principalTable: "Blueprints",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlueprintComponentList_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormulaComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormulaId = table.Column<int>(type: "int", nullable: true),
                    SubstanceType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaComponentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormulaComponentList_Formulas_FormulaId",
                        column: x => x.FormulaId,
                        principalTable: "Formulas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    EquipmentType = table.Column<int>(type: "int", nullable: false),
                    Accuracy = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    Grip = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    StealthType = table.Column<int>(type: "int", nullable: false),
                    AmountOfEnhancements = table.Column<int>(type: "int", nullable: false),
                    IsAmmunition = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: true),
                    ItemType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_ItemBases_Id",
                        column: x => x.Id,
                        principalTable: "ItemBases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Weapons_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CreatureAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    AbilityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureAbility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureAbility_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreatureAbility_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CreatureAttacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    AttackId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureAttacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureAttacks_Attacks_AttackId",
                        column: x => x.AttackId,
                        principalTable: "Attacks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreatureAttacks_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CreatureEffect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureEffect_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreatureEffect_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CreatureRewardList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureRewardList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureRewardList_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreatureRewardList_ItemBases_ItemBaseId",
                        column: x => x.ItemBaseId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EnduranceCost = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsConcentration = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ConcentrationEnduranceCost = table.Column<int>(type: "int", nullable: false),
                    SpellLevel = table.Column<int>(type: "int", nullable: false),
                    CheckDC = table.Column<int>(type: "int", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    DangerInfo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WithdrawalCondition = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SpellType = table.Column<int>(type: "int", nullable: false),
                    SpellTypeDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceType = table.Column<int>(type: "int", nullable: false),
                    SourceTypeDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPriestSpell = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDruidSpell = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spells_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Spells_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpellComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpellId = table.Column<int>(type: "int", nullable: true),
                    ComponentId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellComponentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellComponentList_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpellComponentList_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SpellSkillProtectionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SpellId = table.Column<int>(type: "int", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: true),
                    MoreInfo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSkillProtectionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellSkillProtectionList_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpellSkillProtectionList_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "SkillsList",
                columns: new[] { "Id", "AlchemyId", "AlchemyValue", "AppearanceId", "AppearanceValue", "ArcheryId", "ArcheryValue", "ArtistryId", "ArtistryValue", "AthleticsId", "AthleticsValue", "AttentionId", "AttentionValue", "CamouflageId", "CamouflageValue", "CharismaId", "CharismaValue", "CityOrientationId", "CityOrientationValue", "CorruptionId", "CorruptionValue", "CourageId", "CourageValue", "CreateDate", "CrossbowMasteryId", "CrossbowMasteryValue", "DeceptionId", "DeceptionValue", "DeductionId", "DeductionValue", "EducationId", "EducationValue", "Enabled", "EnduranceId", "EnduranceValue", "EtiquetteId", "EtiquetteValue", "EvasionId", "EvasionValue", "FirstAidId", "FirstAidValue", "ForgeryId", "ForgeryValue", "GamblingId", "GamblingValue", "IntimidationId", "IntimidationValue", "KnowledgeTransferId", "KnowledgeTransferValue", "LanguageDwarfId", "LanguageDwarfValue", "LanguageGeneralId", "LanguageGeneralValue", "LanguageHighId", "LanguageHighValue", "LeadershipId", "LeadershipValue", "LightBladeMasteryId", "LightBladeMasteryValue", "LockpickingId", "LockpickingValue", "MagicResistanceId", "MagicResistanceValue", "ManualDexterityId", "ManualDexterityValue", "ManufacturingId", "ManufacturingValue", "MeleeCombatId", "MeleeCombatValue", "MonsterologyId", "MonsterologyValue", "PersuasionId", "PersuasionResistanceId", "PersuasionResistanceValue", "PersuasionValue", "PoleWeaponMasteryId", "PoleWeaponMasteryValue", "PublicSpeakingId", "PublicSpeakingValue", "RidingId", "RidingValue", "RitualsId", "RitualsValue", "SeamanshipId", "SeamanshipValue", "SeductionId", "SeductionValue", "SpellcastingId", "SpellcastingValue", "StealthId", "StealthValue", "StrengthId", "StrengthValue", "SurvivalId", "SurvivalValue", "SwordsmanshipId", "SwordsmanshipValue", "TacticsId", "TacticsValue", "TradingId", "TradingValue", "TrapKnowledgeId", "TrapKnowledgeValue", "UnderstandingPeopleId", "UnderstandingPeopleValue", "UpdateDate", "WrestlingId", "WrestlingValue" },
                values: new object[] { 1, 39, 0, 30, 0, 26, 0, 32, 0, 22, 4, 1, 6, 43, 0, 38, 0, 6, 0, 47, 0, 52, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7967), 25, 4, 34, 0, 3, 0, 5, 0, true, 28, 5, 10, 0, 21, 4, 44, 0, 45, 0, 29, 0, 46, 0, 7, 0, 13, 0, 11, 0, 12, 0, 33, 0, 18, 5, 40, 0, 49, 4, 23, 0, 42, 0, 14, 0, 4, 0, 37, 50, 5, 0, 17, 0, 31, 0, 16, 0, 48, 0, 20, 0, 36, 0, 51, 0, 24, 3, 27, 0, 2, 5, 19, 6, 8, 0, 9, 0, 41, 0, 35, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7967), 15, 6 });

            migrationBuilder.InsertData(
                table: "SkillsTree",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "FirstLeftSkillId", "FirstLeftSkillValue", "FirstMiddleSkillId", "FirstMiddleSkillValue", "FirstRightSkillId", "FirstRightSkillValue", "MainSkillId", "MainSkillValue", "Name", "SecondLeftSkillId", "SecondLeftSkillValue", "SecondMiddleSkillId", "SecondMiddleSkillValue", "SecondRightSkillId", "SecondRightSkillValue", "SourceId", "ThirdLeftSkillId", "ThirdLeftSkillValue", "ThirdMiddleSkillId", "ThirdMiddleSkillValue", "ThirdRightSkillId", "ThirdRightSkillValue", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7836), "", true, 54, 0, 57, 0, 60, 0, 53, 0, "", 55, 0, 58, 0, 61, 0, null, 56, 0, 59, 0, 62, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreateDate", "Enabled", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6784), true, "Базовая книга", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6794) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6797), true, "Хоумбрю", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6797) }
                });

            migrationBuilder.InsertData(
                table: "StatsList",
                columns: new[] { "Id", "ConstitutionId", "ConstitutionValue", "CraftsmanshipId", "CraftsmanshipValue", "CreateDate", "DexterityId", "DexterityValue", "EmpathyId", "EmpathyValue", "Enabled", "EnduranceId", "EnduranceValue", "EnergyId", "EnergyValue", "HandStrikeId", "HandStrikeValue", "HealthPointsId", "HealthPointsValue", "IntellectId", "IntellectValue", "JumpingId", "JumpingValue", "KickId", "KickValue", "LuckId", "LuckValue", "ReactionId", "ReactionValue", "ResilienceId", "ResilienceValue", "RestId", "RestValue", "RunningId", "RunningValue", "SpeedId", "SpeedValue", "UpdateDate", "WeightId", "WeightValue", "WillpowerId", "WillpowerValue" },
                values: new object[] { 1, 4, 5, 7, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7904), 3, 5, 6, 3, true, 15, 20, 10, 0, 18, 0, 14, 20, 1, 3, 13, 2, 19, 2, 9, 0, 2, 6, 11, 4, 17, 4, 12, 12, 5, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7904), 16, 50, 8, 4 });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "AttackSpeed", "AttackType", "BaseAttack", "CreateDate", "Damage", "Description", "Distance", "Enabled", "Name", "Reliability", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, 4, 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7859), "2к6+2", "", 0, true, "Железный полуторный меч", 10, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7859) },
                    { 2, 1, 4, 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7861), "1к6", "", 0, true, "Кинжал", 10, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7862) },
                    { 3, 1, 1, 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7864), "2к6+2", "", 0, true, "Ручной арбалет", 10, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7864) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreateDate", "DefaultMagicAbilities", "Description", "Enabled", "Energy", "Name", "SkillsTreeId", "SourceId", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7852), "", "Я ведь уже говорил тебе, что странствовал какое-то время с ведьмаком? Так вот. Спросил я его как-то, почему он ведьмаком остался. Это ведь явно не работа мечты — входишь в деревню, дети прячутся, отцы своих дочурок по домам запирают. Впрочем, ответ был ожидаем — он попросту незнал другой жизни. На самом деле логично. Вот живёшь ты, живёшь, занимаешься одним делом, а больше-то ничего и не умеешь. Но не всё так плохо. Ведьмаки — это сила. Мечники они отменные — тот ведьмак, с которым я странствовал, как-то раз арбалетный болт отбил на лету. Могу повторить, если тебя это не впечатлило. Своим кручением-верчением они вполне способны в капусту покрошить более медленных мечников. Двигаются ведьмаки так быстро, что со стороны за мечом не уследишь и каждый взмах превращается в серебряную полосу. И не стоит забывать об алхимии! Раньше они точно с собой таскали всякие эликсиры и масла, благодаря которым на поле боя превращались в сущих дьяволов — становились быстрее и раны залечивали, как волколаки. Вдобавок ко всему ведьмаки чуточку магией владеют. Ну, не такой мощной, как настоящие чародеи, но всё же заклинания свои творят. Называется это знаками. Это такие пассы руками, обладающие магическим действием. Любой маг на это лишь пофыркает, поскольку такие вещи не дотягивают даже до простейших заклинаний, но всёравно знаки весьма эффективны. Так что честно тебе скажу: я рад, что ведьмаки только на чудовищ охотятся. Ну... по крайней мере, когда-то так было.", true, 2, "Ведьмак", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7130), "Это оружие легко спрятать. Вы получаете бонус +2 при попытке скрыть это оружие.", true, "Незаметное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7130) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7131), "Если это оружие нанесёт урон цели, с определённой вероятностью оно может вызвать кровотечение.Вероятность кровотечения указана в скобках.", true, "Кровопускающее", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7131) },
                    { 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7132), "Такое оружие игнорирует сопротивление урону любой брони, по которой оно попадает.", true, "Пробивающее броню", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7132) },
                    { 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7133), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "Дезориентирующее(1)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7134) },
                    { 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7135), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "Дезориентирующее(2)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7135) },
                    { 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7136), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "Дезориентирующее(3)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7136) },
                    { 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7137), "Это оружие наносит полный урон чудовищам, уязвимым к метеоритной стали. Также такое оружие имеет 5 дополнительных пунктов надёжности.", true, "Метеоритное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7137) },
                    { 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7138), "Этим оружием можно атаковать противников в пределах 2 метров.", true, "Длинное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7138) },
                    { 9, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7139), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "Фокусирующее(1)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7140) },
                    { 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7141), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "Фокусирующее(2)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7141) },
                    { 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7142), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "Фокусирующее(3)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7142) },
                    { 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7143), "Атаки наносят двойной разрушающий урон оружию, щиту или броне.", true, "Сокрушающая сила", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7143) },
                    { 13, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7145), "Когда вы атакуете чудовище восприимчивое к серебряному оружию, то наносите не только стандартный урон, но и определённое количество урона от серебра, обозначенное в скобках.", true, "Серебрянное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7145) },
                    { 14, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7146), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "Сбалансированное(1)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7146) },
                    { 15, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7147), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "Сбалансированное(2)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7148) },
                    { 16, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7148), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "Сбалансированное(3)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7149) },
                    { 17, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7150), "Такое оружие игнорирует сопротивление урону любой брони и половину прочности брони,по которой оно попадает.", true, "Улучшенное пробивание брони", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7150) },
                    { 18, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7151), "Это оружие можно использовать для захвата и подсечки противника в пределах дистанции.", true, "Захватное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7152) },
                    { 19, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7152), "Когда владелец блокирует рукопашную атаку врага этим оружием, часть его оружия оказывается в ловушке. Оба оружия становятся бесполезными и не могут быть разделены до тех пор, пока противник не сможет пройти проверку Силы или Ловкости рук, которая превзойдет изначальную проверку Владения лёгкими клинками, или пока владелец не выпустит свое оружие.", true, "Ловящий лезвия", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7153) },
                    { 20, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7154), "Пока существо прикасается к этому оружию, оно не может стать невидимым или неосязаемым или использовать любую способность, которая позволяет ему телепортироваться. Существа, которые уже являются невидимыми или неосязаемыми, становятся видимыми и осязаемыми при прикосновении к этому оружию.", true, "Магические путы", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7154) },
                    { 21, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7155), "Для перезарядки этого оружия требуется 1 действие.", true, "Медленно перезаряжающееся", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7155) },
                    { 22, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7156), "Это оружие можно использовать для нанесения несмертельного урона без штрафов.", true, "Несмертельное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7156) },
                    { 23, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7157), "Цель, пораженная этим оружием, становится опутанной. Она снижает свою Скор на 5 и получает штраф -2 ко всем физическим действиям. Каждый ход цель может совершать проверку Уклонения/Изворотливости или Борьбы со СЛ 18, чтобы высвободиться. В качестве альтернативы другой персонаж может потратить действие, чтобы освободить опутанного.", true, "Опутывающее", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7157) },
                    { 24, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7158), "-2 к штрафу за парирование.", true, "Парирующее", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7158) },
                    { 25, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7159), "При попадании это оружие наносит 1d6 / 2 урона прочности брони.", true, "Разрушающее", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7160) },
                    { 26, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7160), "Такое оружие использует навык Борьба. Его урон прибавляется к урону от атаки без оружия.", true, "Рукопашное", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7161) },
                    { 27, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7162), "Чтобы перезарядить это оружие, требуется потратить 2 действия. Эти действия могут быть совершены двумя разными персонажами.", true, "Расчетная перезарядка", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7162) },
                    { 28, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7163), "При сотворении заклинаний с помощью этого оружия СЛ проверок против ваших заклинаний считается на 2 выше.", true, "Улучшенное фокусирующее", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7163) },
                    { 29, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7164), "Это оружие фиксируется в одном месте, а не удерживается. Персонаж должен потратить действие, чтобы установить оружие там, где он хочет его использовать, и должен потратить действие, чтобы демонтировать его, когда он захочет снова его переместить.", true, "Устанавливаемое", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7164) },
                    { 30, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7165), "Это оружие может быть заряжено флаконом с любым ядом или эликсиром. Когда владелец наносит урон этим оружием, он впрыскивает содержимое глубоко в организм цели. Это увеличивает СЛ для избавления от яда на 3 или увеличивает продолжительность действия эликсира на 3 раунда.", true, "Шприц", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7165) },
                    { 31, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7166), "Данный доспех закрывает: голову, туловище, руки и ноги.", true, "Закрывает все тело", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7166) },
                    { 32, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7167), "Если атака, заблокированная этим щитом, была огненной, то щит не получает повреждений от блокирования.", true, "Огнеупорный", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7167) },
                    { 33, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7168), "Как только персонаж опускает забрало шлема, его поле зрения сужается до конуса прямо перед ним вместо обычного поля от плеча до плеча. Этот эффект также отменяет Обострённые чувства ведьмака (бонус к Вниманию и выслеживанию по запаху).", true, "Ограничение зрения", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7169) },
                    { 34, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7170), "Этот щит достаточно велик, чтобы за ним можно было спрятаться целиком, как за стенкой. Если персонаж сидит на корточках за этим щитом, она действует как укрытие, и любая атака, направленная против персонажа, должна нанести урон, превышающий надёжность щита, чтобы навредить персонажу. Каждый раз, когда этот щит получает урон, его надёжность снижается на 1.", true, "Полное укрытие", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7170) },
                    { 35, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7171), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Д – Дробящий урон.", true, "Сопротивление(Д)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7171) },
                    { 36, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7172), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Р – Режущий урон.", true, "Сопротивление(Р)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7172) },
                    { 37, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7173), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. К – Колющий урон.", true, "Сопротивление(К)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7173) },
                    { 38, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7174), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. С – Стихийный (обычно указывается стихия вместо буквы).", true, "Сопротивление(С)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7175) },
                    { 39, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7176), "Персонаж объят пламенем. Каждый ход он получает 5 пунктов урона по каждой части тела. Броня поглощает урон, но при этом огонь наносит 1 урон броне и оружию каждый ход. Чтобы погасить огонь, персонаж должен потратить ход либо на обливание водой, либо на то, чтобы упасть на землю, покататься и сбить пламя.", true, "Горение", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7176) },
                    { 40, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7177), "Персонаж дезориентирован. У него кружится голова, перед глазами всё плывёт. В этом состоянии он не может совершать каких-либо действий, а для того, чтобы попасть по нему, достаточно пройти проверку со СЛ 10. Чтобы завершить этот эффект, персонаж должен пройти испытание Устойчивости. Это действие занимает полный ход. Если по персонажу попадают, пока он дезориентирован, он тут же приходит в себя.", true, "Дезориентация", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7178) },
                    { 41, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7178), "В крови персонажа течёт яд, наносящий ему каждый ход 3 урона, не снижаемые бронёй. Чтобы прекратить действие яда, персонаж должен пройти проверку Стойкости со СЛ 15, потратив одно действие.", true, "Отравление", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7179) },
                    { 42, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7179), "При ранении был задет крупный сосуд, из-за чего рана сильно кровоточит. Персонаж получает 2 урона каждый ход до тех пор, пока кровотечение не будет остановлено. Для этого необходимо либо сотворить исцеляющее заклинание, либо совершить успешную проверку Первой помощи со СЛ 15, потратив одно действие.", true, "Кровотечение", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7180) },
                    { 43, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7181), "Персонаж не превратился в цельный кусок льда, но тело его плохо слушается, а одежда покрыта наледью. До тех пор, пока персонаж не сломает лёд, он получает штраф -3 к Скор и -1 к Реа. Лёд можно сломать, пройдя проверку Силы со СЛ 16 и потратив одно действие.", true, "Замораживание", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7181) },
                    { 44, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7182), "Персонаж теряет равновесие и получает штраф -2 к атаке и защите. К началу следующего хода вашего персонажа эффект проходит и штраф отменяется.", true, "Ошеломление", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7182) },
                    { 45, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7183), "Персонаж пьян. Он получает штраф -2 к Реа, Лвк и Инт, а также -3 в Словесной дуэли. Есть шанс 25%, что персонаж будет плохо помнить, что делал в состоянии опьянения.", true, "Опьянение", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7183) },
                    { 46, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7184), "Персонаж видит образы и вещи, которых на самом деле нет. Ведущий может свободно выбирать, какой ложный сенсорный эффект почувствует на себе ваш персонаж. Для того чтобы отличить одну иллюзию от реальности, требуется проверка Дедукции со СЛ 15.", true, "Галлюцинации", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7184) },
                    { 47, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7185), "Персонаж ощущает тяжесть в желудке и сосредоточенно пытается сдержать рвоту. Каждые 3 раунда персонаж обязан совершать бросок 1d10, результат которого должен быть ниже его Тел. В противном случае в течение одного раунда его будет рвать или он будет мучим рвотными позывами.", true, "Тошнота", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7185) },
                    { 48, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7186), "Персонажу нечем дышать, он задыхается. Каждый раунд персонаж получает З урона, не снижаемые бронёй. Способы избавиться от удушья разные, в зависимости от ситуации. Восстановление доступа к воздуху (персонаж выныривает, выворачивается из удушающего захвата и т.д.) прекращает этот эффект.", true, "Удушье", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7187) },
                    { 49, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7187), "Глаза персонажа закрыты или повреждены. Пока персонаж не потратит ход, чтобы восстановить зрение, он получает штраф -3 ко всем атакам и защите и штраф -5 к проверкам Внимания, связанным со зрением.", true, "Слепота", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7188) },
                    { 50, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7189), "Дистанция, на которую можно бросать предмет или стрелять из него", true, "Дистанция", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7189) },
                    { 51, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7190), "Бонус к броскам на попадание", true, "Точность+1", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7190) },
                    { 52, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7191), "Бонус к броскам на попадание", true, "Точность+2", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7191) },
                    { 53, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7192), "Бонус к броскам на попадание", true, "Точность+3", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7192) },
                    { 54, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7193), "Наносит Колющий урон", true, "Колющий", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7193) },
                    { 55, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7194), "Наносит Дробящий урон", true, "Дробящий", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7194) },
                    { 56, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7195), "Наносит Режущий урон", true, "Режущий", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7196) },
                    { 57, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7196), "Персонаж лежит без сознания или спит. Он считается сбитым с ног и не может двигаться и совершать какие-либо действия, кроме Отдыха. Условия прекращения этого состояния зависят от причины, которая его вызвала.", true, "Без сознания", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7197) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "ImageFileName", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7246), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "", "Обезболивающие травы", 12, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7246), 0.10000000000000001 },
                    { 2, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7265), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "", "Капюшон вердэнского лучника", 100, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7265), 0.5 },
                    { 3, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7320), "", true, "", "Пепел", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7321), 0.10000000000000001 },
                    { 4, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7329), "", true, "", "Уголь", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7329), 0.10000000000000001 },
                    { 5, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7335), "", true, "", "Хлопок", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7335), 0.10000000000000001 },
                    { 6, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7338), "", true, "", "Двойное полотно", 22, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7338), 0.10000000000000001 },
                    { 7, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7341), "", true, "", "Стекло", 5, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7341), 0.5 },
                    { 8, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7343), "", true, "", "Укрепленное дерево", 16, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7343), 0.10000000000000001 },
                    { 9, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7346), "", true, "", "Полотно", 9, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7346), 0.10000000000000001 },
                    { 10, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7348), "", true, "", "Масло", 3, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7348), 0.10000000000000001 },
                    { 11, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7350), "", true, "", "Смлоа", 2, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7351), 0.10000000000000001 },
                    { 12, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7352), "", true, "", "Шелк", 50, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7353), 0.10000000000000001 },
                    { 13, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7354), "", true, "", "Нитки", 3, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7355), 0.10000000000000001 },
                    { 14, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7356), "", true, "", "Древесина", 3, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7357), 1.0 },
                    { 15, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7359), "", true, "", "Воск", 2, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7359), 0.10000000000000001 },
                    { 16, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7361), "", true, "", "Кости животных", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7361), 4.0 },
                    { 17, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7363), "", true, "", "Коровья шкура", 10, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7363), 5.0 },
                    { 18, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7365), "", true, "", "Кожа драконида", 58, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7365), 5.0 },
                    { 19, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7368), "", true, "", "Чешуя драконида", 30, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7368), 5.0 },
                    { 20, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7370), "", true, "", "Перья", 4, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7370), 0.10000000000000001 },
                    { 21, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7372), "", true, "", "Укрепленная кожа", 48, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7372), 3.0 },
                    { 22, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7374), "", true, "", "Кожа", 28, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7374), 2.0 },
                    { 23, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7376), "", true, "", "Лирийская кожа", 60, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7376), 2.0 },
                    { 24, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7380), "", true, "", "Волчья шкура", 14, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7380), 3.0 },
                    { 25, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7382), "", true, "", "Чернящее масло", 24, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7382), 0.10000000000000001 },
                    { 26, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7383), "", true, "", "Масло из дрейка", 45, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7384), 0.10000000000000001 },
                    { 27, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7387), "", true, "", "Эфирная смазка", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7387), 0.10000000000000001 },
                    { 28, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7406), "", true, "", "Травильная кислота", 2, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7406), 0.10000000000000001 },
                    { 29, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7410), "", true, "", "Пятая эссенция", 82, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7410), 0.10000000000000001 },
                    { 30, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7413), "", true, "", "Огров воск", 10, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7414), 0.10000000000000001 },
                    { 31, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7415), "", true, "", "Точильный порошок", 32, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7416), 0.10000000000000001 },
                    { 32, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7418), "", true, "", "Дубильные травы", 3, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7418), 0.10000000000000001 },
                    { 33, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7420), "", true, "", "Темное железо", 52, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7420), 1.5 },
                    { 34, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7422), "", true, "", "Темная сталь", 82, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7422), 1.0 },
                    { 35, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7424), "", true, "", "Двимерит", 240, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7425), 1.0 },
                    { 36, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7427), "", true, "", "Самоцветы", 100, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7427), 0.10000000000000001 },
                    { 37, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7429), "", true, "", "Совершенный самоцвет", 1000, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7429), 0.10000000000000001 },
                    { 38, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7432), "", true, "", "Светящаяся руда", 80, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7432), 1.0 },
                    { 39, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7434), "", true, "", "Золото", 85, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7434), 1.0 },
                    { 40, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7436), "", true, "", "Железо", 30, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7437), 1.5 },
                    { 41, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7439), "", true, "", "Махакамский двимерит", 300, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7439), 1.0 },
                    { 42, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7441), "", true, "", "Махакамская сталь", 114, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7441), 1.0 },
                    { 43, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7443), "", true, "", "Метеорит", 98, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7443), 1.0 },
                    { 44, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7445), "", true, "", "Речная глина", 5, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7445), 1.5 },
                    { 45, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7447), "", true, "", "Серебро", 72, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7447), 1.0 },
                    { 46, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7449), "", true, "", "Сталь", 48, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7450), 1.0 },
                    { 47, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7451), "", true, "", "Камень", 4, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7452), 2.0 },
                    { 48, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7454), "", true, "", "Третогорская сталь", 64, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7454), 1.0 },
                    { 49, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7456), "", true, "", "Зерриканская смесь", 30, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7457), 0.10000000000000001 },
                    { 50, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7460), "", true, "", "Зеленая плесень", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7460), 0.10000000000000001 },
                    { 51, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7462), "", true, "", "Переступень", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7462), 0.10000000000000001 },
                    { 52, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7464), "", true, "", "Помет беса", 20, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7465), 1.0 },
                    { 53, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7467), "", true, "", "Омела", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7467), 0.10000000000000001 },
                    { 54, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7469), "", true, "", "Паутинник", 18, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7469), 0.10000000000000001 },
                    { 55, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7471), "", true, "", "Optima mater", 100, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7471), 0.10000000000000001 },
                    { 56, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7473), "", true, "", "Жимолость", 21, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7474), 0.10000000000000001 },
                    { 57, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7476), "", true, "", "Листья балиссы", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7476), 0.10000000000000001 },
                    { 58, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7478), "", true, "", "Сера", 14, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7478), 0.10000000000000001 },
                    { 59, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7480), "", true, "", "Собачья петрушка", 2, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7481), 0.10000000000000001 },
                    { 60, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7482), "", true, "", "Царская водка", 20, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7482), 0.10000000000000001 },
                    { 61, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7484), "", true, "", "Аконит", 9, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7485), 0.10000000000000001 },
                    { 62, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7487), "", true, "", "Корень лопуха", 32, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7488), 0.10000000000000001 },
                    { 63, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7490), "", true, "", "Корень мандрагоры", 65, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7490), 0.10000000000000001 },
                    { 64, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7492), "", true, "", "Фосфор", 20, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7492), 0.5 },
                    { 65, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7494), "", true, "", "Calcium equum", 12, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7494), 0.10000000000000001 },
                    { 66, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7514), "", true, "", "Вороний глаз", 17, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7514), 0.10000000000000001 },
                    { 67, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7516), "", true, "", "Грибы-шибальцы", 17, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7517), 0.10000000000000001 },
                    { 68, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7519), "", true, "", "Лепестки белого мирта", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7519), 0.10000000000000001 },
                    { 69, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7521), "", true, "", "Плод балиссы", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7521), 0.10000000000000001 },
                    { 70, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7523), "", true, "", "Ячмень", 9, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7523), 0.10000000000000001 },
                    { 71, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7525), "", true, "", "Винный камень", 88, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7525), 0.5 },
                    { 72, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7527), "", true, "", "Волокна хана", 17, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7527), 0.10000000000000001 },
                    { 73, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7529), "", true, "", "Ласточкина трава", 8, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7529), 0.10000000000000001 },
                    { 74, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7532), "", true, "", "Лунная крошка", 91, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7532), 0.10000000000000001 },
                    { 75, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7534), "", true, "", "Вербена", 18, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7534), 0.10000000000000001 },
                    { 76, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7537), "", true, "", "Листья волчьего алоэ", 39, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7537), 0.10000000000000001 },
                    { 77, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7539), "", true, "", "Краснолюдский бессмертник", 75, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7540), 0.10000000000000001 },
                    { 78, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7541), "", true, "", "Эмбрион эндриаги", 55, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7542), 1.5 },
                    { 79, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7543), "", true, "", "Жемчуг", 100, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7544), 0.10000000000000001 },
                    { 80, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7546), "", true, "", "Корень зарника", 18, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7546), 0.10000000000000001 },
                    { 81, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7548), "", true, "", "Лепестки гинации", 17, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7548), 0.10000000000000001 },
                    { 82, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7550), "", true, "", "Лепестки морозника", 19, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7550), 0.10000000000000001 },
                    { 83, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7552), "", true, "", "Плод берберки", 9, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7552), 0.10000000000000001 },
                    { 84, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7554), "", true, "", "Ртутный раствор", 77, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7554), 0.10000000000000001 },
                    { 85, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7556), "", true, "", "Склеродерм", 5, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7557), 0.10000000000000001 },
                    { 86, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7618), "", true, "", "Чертеж «Капюшон вердэнского лучника»", 150, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7618), 0.0 },
                    { 87, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7655), "", true, "", "Формула «Обезболивающие травы»", 0, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7655), 1.0 },
                    { 88, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7705), "Всегда с собой таскай верёвку. Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "", "Веревка (20 метров)", 20, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7705), 1.5 },
                    { 89, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7722), "Позволяют создавать алхимические составы", true, "", "Инструменты алхимика", 80, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7723), 3.0 },
                    { 90, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7740), "", true, "", "Стилет", 275, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7740), 0.5 },
                    { 91, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7707), "Валюта это", true, "", "Кроны", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7707), 0.01 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7757), "Ведьмаки — тема деликатная с тех самых пор, как их создали много веков тому назад. Но, знаешь, даже когда они были нарасхват, их не особо-то любили. Ведьмаков выращивали из людских детей в пяти ведьмачьих школах. Там дети проходили какую-то лютую подготовку, после которой становились живым оружием. Быстрые до одури, могут сражаться вслепую и обучены охотиться считай на всех тварей, каких только можно встретить. Через парулет тренировок их подвергают мутациям — известней всего так называемое Испытание травами. Ведьмак, с которым мне довелось странствовать, рассказал, что переживает эту дрянь только один дитёнок из четырёх. Те, кто выжил, меняются. Глаза у них становятся кошачьими, а эмоции напрочь отмирают. Вроде как последнее со временем налаживается — например, тот самый знакомый мне ведьмак по дороге шутки-то малясь травил. Но с того самого момента, как ведьмаки мутируют, они становятся убийцами. Они перерождаются ради единственной цели — убивать чудовищ. И если доведётся тебе повидать ведьмака в деле, то поймёшь, что все те пройденные страдания были не зря. Одна только проблема: они мутанты, а люди мутантов ненавидят. С адаптацией в обществе у ведьмаков плохо, и для большинства они — хладнокровные бессердечные выродки, что честным людям кишки выпускают, предварительно ограбив да их дочек снасильничав", true, "Ведьмаки", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7758) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7759), "История эльфов (точнее Aen Seidhe, поскольку наши эльфы далеко не единственные) весьма грустная. Они прибыли сюда неизвестно откуда на огромных белых кораблях. Случилось это незадолго до появления людей. Я бы не назвал эльфов добряками, но с остальными они как-то уживались. От людей они не сильно отличаются: высокие, худые, любят на другие народы свысока смотреть. Разве что уши острые, жизнь вечная, да, считай, полное единение с природой — эльфы много поколений только и делали, что занимались собирательством и строили дворцы. Унихза время поеданияягод да кореньев и клыков-то не осталось. Правда, всё равно не советую их из себя выводить — на поле боя эльфы могут устроить тот ещё ад. Броню они толком не носят, но заприметить эльфа в лесу также тяжело, как зимой лягушку найти. А уж искуснее лучника чем эльф, днём с огнём не сыщешь.", true, "Эльфы (Aen Seidhe)", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7759) },
                    { 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7760), "Друже, вот что я тебе скажу: реки высохнут, горы рассыплются, а краснолюды никуда не денутся. Может, мы и низенькие в сравнении с эльфами и людьми, да только в силе и закалке им с нами не тягаться. Мы — само воплощение стойкости! Краснолюды уже не первый век существуют в этом мире. Жили себе спокойно в горах, ковали. Мы народ достаточно дружелюбный, если познакомиться с нами поближе. Да и уживаемся спокойно со всеми... если нас не бесить, конечно. Человечишки нас не особо любят, но мы им нужны — кто ж сталь им ковать будет и торговать? К тому же, в отличие от сраных эльфов, мы не держим на людей зла. Нас не трогают — и мы их не трогаем в ответ. Порой даже кружечку-другую готовы раздавить вместе с человеком. Жаль, конечно, что вся эта безумная расистская дрянь по Северу расползлась. Теперь и на краснолюдов травлю открыли. Повезло ещё, что люди наших девок нормально от мужиков отличить не могут, а то бы всех уже увели! Ведь нету бабы краше нраснолюдки. Правильно говорят: чем пышнее борода, тем приятнее... ну, ты понимаешь.", true, "Краснолюды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7760) },
                    { 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7761), "Ох, будь я покозлистее, то всю желчь излил бы тебе о том, как людишки насолили моему народу и остальным Старшим Народам. Но я не такой. С людьми я служил бок о бок на войне с Нильфгаардом; в той же темерской армии большинство — люди. Не все они говнюки — бывают и хорошие. По характеру люди-mo разные. Обычно они весьма стойкие ребята. Разве что частенько начинают то за «правое дело» воевать, то тыкать пальцами и бояться. Сейчас люди на Континенте — преобладающий вид, и они об этом прекрасно знают... чёрт, даже не надо стараться, чтобы о них гадости говорить. Люди почти уничтожили Старшие Народы, выкосили вранов, оставили в живых всего пару сотен боболаков, построили свои города на руинах Старших Народов и каждый день кого-то из Старших убивают. Но нет, они не все говнюки. Да, большинство магов — люди, и именно они погрузили мир в хаос, но они также сделали мир лучше с помощью науки и магии. Люди умные и, на самом деле, верные — если ты с человеком дружен, он тебя в беде не бросит.", true, "Люди", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7761) },
                    { 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7762), "Формально гуманоиды чудовищами не являются. Это люди, эльфы, краснолюды и прочие представители Старших Народов. Гуманоиды разнообразны в плане поведения и мест обитания. Важно помнить, что даже\r\nпо стандартным правилам гуманоиды не имеют восприимчивости к серебру и сопротивления стали.", true, "Гуманоиды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7763) },
                    { 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7764), "Трупоеды едят трупы, и зачастую их можно встретить на кладбищах, полях боя и в глубоких пещерах. Их отталкивающая внешность обманчива — это вполне живые существа с иных планов. Менее разумные трупоеды, такие как гули, нападают на всё, что оказывается поблизости. Умные трупоеды, вроде кладбищенских баб, бродят по кладбищам и заманивают селян.", true, "Трупоеды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7764) },
                    { 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7765), "Духи представляют собой сильные желания усопших. Обычно они появляются тогда, когда кого-то убивают или когда кто-то перед смертью испытывает интенсивные эмоции. Многие духи разумны, но все они целиком захвачены каким-то одним чувством — обычно яростью, — что просто не позволяет вести с ними диалог.", true, "Духи", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7765) },
                    { 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7766), "Звери, как и гуманоиды, формально не относятся к чудовищам. В этой категории — собаки, волки и тому подобные существа. Они не имеют восприимчивости к серебру и сопротивления стали. Встретить их и вблизи поселений. Охотятся они преимущественно на селян и скот.", true, "Звери", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7766) },
                    { 9, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7767), "Проклятые — это люди и нелюди, на которых было наложено проклятие, превратившее их в чудовиш. Наиболее распространены волколаки. Поскольку это проклятые люди они обычно живут в человеческих поселениях. В большинстве своём такие существа открыто агрессивны по отношению к людям.", true, "Проклятые", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7767) },
                    { 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7768), "Этот класс объединяет множество разных химер вроде сирен и грифонов — соединение частей разных животных. Гибриды необычайно разнообразны и предпочитают различные среды обитания. Те, у кого есть способность к полёту, живут на возвышенностях, хотя в целом гибридов можно найти повсемест но, в самых разных зонах.", true, "Гибриды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7769) },
                    { 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7770), "Инсектоиды — это огромные насекомые и арахниды, которые бродят за пределами поселений, подстерегая неосторожных путников. Инсектоиды — хищники, обычно нападающие из засады и ранящие своих жертв ядовитыми жвалами или когтями. Если подобратьсслишком близко к гнезду инсектоидов, то вскоре вас может окружить целый рой этих существ.", true, "Инсектоиды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7770) },
                    { 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7772), "Духи стихий - восхитительные создания магии: големы, элементали, гаргульи и им подобные. Большинство таких существ призваны магами и жрецами. Они следуют приказам призвавшего, у них практически нет своей воли. Но если призвать их в этот мир, не связав узами, духистихий становятся ужасающей силой, способной уничтожать города.", true, "Духи стихий", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7772) },
                    { 13, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7773), "Реликты — силы природы, периодически проявляющиеся за пределами поселений. Скорее всего, эти чудовища прибыли в наш мир во время Сопряжения Сфер. Все они владеют магиейи тесно связаны с природой. По разумности реликты различаются: от умных и хитрых до примитивных и жестоких.", true, "Реликты", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7773) },
                    { 14, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7774), "Огры, включая троллей, накеров и великанов, — это гуманоидные создания, зачастую с почти человеческим интеллектом. Большинство из них велики и нескладны (за исключением накеров). Они не только способны создавать племенные сообщества, но и, в случае троллей, кое-как разговаривать на человеческом языке и Старшей Речи.", true, "Огры", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7774) },
                    { 15, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7775), "Среди драконидов есть такие существа, как виверны и драконы. Большинство драконидов — это крупные крылатые ящеры, крайне опасные (особенно в ближнем бою), но дикие. Истинные драконы по интеллекту близки к людям, а то и вовсе их превосходят и обладают куда большим количеством способностей. Логова драконидов расположены высоко в горах.", true, "Дракониды", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7775) },
                    { 16, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7776), "Вампиры — весьма разнообразная группа кровососущих чудовищ. Обычно они охотятся в руинах, хотя могущественные вампиры могут процветать и в городах. Низшие вампиры — это неразумные твари, раздирающие тела на части и затем выпивающие кровь. Высшие вампиры способны без проблем влиться в человеческое общество и обладают огромной силой.", true, "Вампиры", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7777) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 54, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7073), "Ведьмак может войти в медитативный транс, что позволяет ему получить все преимущества сна, но при этом сохранять бдительность. Во время медитации ведьмак считается находящимся в сознании для того, чтобы заметить что-либо в радиусе в метрах, равном удвоенному значению его Медитации.", true, true, false, "Магический клинок", 1, null, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7073) },
                    { 55, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7075), "По мере того как ведьмак всё больше использует знаки, его тело постепенно привыкает к течению магической энергии. Каждые 2 очка, вложенные в способность Магический источник, повышают значение Энергии ведьмака на 1. Когда эта способность достигает 10 уровня, максимальное значение Энергии ведьмака становится равно 7. Эта способность развивается аналогично прочим навыкам.", true, true, false, "Магический источник", 1, null, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7075) },
                    { 57, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7077), "а годы употребления ядовитых ведьмачьих эликсиров ведьмаки привыкают к токсинам. Ведьмак может выдержать отвары и эликсиры суммарной токсичностью на 5% больше за каждые 2 очка, вложенные в способность Крепкий желудок. Эта способность развивается аналогично прочим навыкам. На 10 уровне максимальная токсичность для ведьмака равна 150%.", true, true, false, "Крепкий желудок", 1, null, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7078) },
                    { 58, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7079), "Будучи отравленным, ведьмак впадает в ярость и наносит дополнительно 1 урон в ближнем бою за каждый уровень Ярости. В этом состоянии единственная цель ведьмака — добраться до безопасного места или убить отравителя. Действие Ярости заканчивается одновременно с действием яда. Ведьмак может попытаться избавиться от Ярости раньше, совершив проверку Стойкости со СЛ 15.", true, true, false, "Ярость", 1, null, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7079) }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "CheckDC", "ConcentrationEnduranceCost", "CreateDate", "CreatureId", "DangerInfo", "Description", "Distance", "Duration", "Enabled", "EnduranceCost", "ImageFileName", "IsConcentration", "IsDruidSpell", "IsPriestSpell", "Name", "PreparationTime", "SourceId", "SourceType", "SourceTypeDescription", "SpellLevel", "SpellType", "SpellTypeDescription", "UpdateDate", "WithdrawalCondition" },
                values: new object[,]
                {
                    { 1, 0, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8105), null, "", "Слепящая пыль позволяет направить в глаза цели горсть магической пыли, которая ослепит её на время действия заклинания.", 4, "1к10 раундов", true, 3, "", false, false, false, "Слепящая пыль", 0, 1, 1, "", 1, 1, "", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8106), "" },
                    { 2, 0, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8114), null, "", "Кипящая кровь заставляет животное или неразумное чудовище в пределах дистанции заклинания разозлиться на цель. Это существо будет пытаться напасть на цель, пока действие заклинания не закончится.", 8, "1к10 раундов", true, 3, "", false, false, true, "Кипящая кровь", 0, 1, 1, "", 1, 2, "", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8114), "" },
                    { 3, 0, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8118), null, "", "Квен создаёт щит с 5 ПЗ за каждое очко Вын, потраченное на защиту. Если вы не смогли (или не захотели) защититься от атаки или наносящего урон эффекта, урон сначала применяется к щиту Квен. Смертельный и несмертельный урон одинаковым образом уменьшают ПЗ щита Квен. Когда ПЗ щита снижаются до 0, оставшийся урон применяется к укрывшемуся за ним персонажу. Чтобы повлиять на ваши ПЗ или Вын, урон должен сначала преодолеть ПБ и сопротивление урону, как при любой атаке. Квен можно применять против любых заклинаний, которые поддаются блокированию, но против остальных заклинаний он бессилен. Также Квен не действует на уже имеющийся урон от отравления, болезней или удушения от нехватки кислорода в воздухе. Квен нельзя сотворить снова, пока действует предыдущий такой же знак.", 0, "10 раундов или пока не истрачен", true, 1, "", false, false, false, "Квен", 0, 1, 2, "", 1, 3, "", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8118), "" },
                    { 4, 15, 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8121), null, "", "Пиромантия позволяет заглянуть в пламя и увидеть происходящие события. Пиромантия несколько опаснее Гидромантии — её тяжелее поддерживать, к тому же огонь не позволяет смотреть в прошлое. Зато разглядеть события, происходящие в данный момент, куда проще. Как и в случае с Гидромантией, маг,за которым наблюдает заклинатель, может почувствовать слежку, совершив проверку Магических познаний со СЛ, равной результату проверки Проведения ритуалов", 0, "активный", true, 4, "", true, false, false, "Пиромантия", 0, 1, 1, "", 1, 4, "", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8121), "" },
                    { 5, 0, 0, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8124), null, "", "На гениталиях жертвы высыпают воспалённые зудящие прыщи. Вечный зуд не наносит урона, но причиняет жертве постоянный дискомфорт, что даёт штраф -1 к любым действиям. Также жертва получает штраф -5 к Соблазнению, когда доходит до раздевания.", 0, "", true, 5, "", false, false, false, "Вечный зуд", 0, 1, 1, "", 1, 5, "", new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8124), "Жертва должна взять единицу склеродерма, немного собачьей петрушки и переступня, затем развести костёр и связать травы в пучок. Как только всё будет готово, травы нужно поджечь и пеплом посыпать пострадавший от порчи участок тела, произнося при этом магические слова" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6926), "", true, "Интеллект", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6926) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6928), "", true, "Реакция", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6929) },
                    { 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6930), "", true, "Ловкость", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6930) },
                    { 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6931), "", true, "Телосложение", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6931) },
                    { 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6932), "", true, "Скорость", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6932) },
                    { 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6933), "", true, "Эмпатия", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6934) },
                    { 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6934), "", true, "Ремесло", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6935) },
                    { 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6936), "", true, "Воля", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6936) },
                    { 9, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6937), "", true, "Удача", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6937) },
                    { 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6938), "", true, "Энергия", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6938) },
                    { 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6939), "", true, "Устойчивость", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6939) },
                    { 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6940), "", true, "Бег", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6940) },
                    { 13, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6941), "", true, "Прыжок", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6941) },
                    { 14, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6942), "", true, "Пункты Здоровья", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6943) },
                    { 15, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6944), "", true, "Выносливость", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6945) },
                    { 16, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6945), "", true, "Переносимый вес", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6946) },
                    { 17, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6947), "", true, "Отдых", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6947) },
                    { 18, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6948), "", true, "Удар рукой", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6948) },
                    { 19, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6949), "", true, "Удар ногой", 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6949) }
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "RaceId", "SourceId", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7789), "Благодаря обострённым чувствам ведьмаки не получают штрафов при слабом свете и получают врождённый бонус +1 к Вниманию, а также возможность выслеживания по запаху", true, "Обостренные чувства", 1, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7789) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7791), "После всех мутаций ведьмаки становятся невосприимчивы к болезням и способны использовать мутагены", true, "Стойкость мутанта", 1, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7792) },
                    { 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7793), "Из-за пережитых страданий и мутаций эмоции у ведьмаков притупляются. Ведьмакам не нужно совершать проверки Храбрости против Запугивания, но они получают штраф -4 к Эмпатии. При этом значение Эмпатии ведьмака не может быть ниже 1.", true, "Притупление эмоций", 1, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7793) },
                    { 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7794), "Благодаря интенсивным тренировкам и мутациям ведьмаки куда быстрее и проворнее обычных людей. Они получают постоянный бонус +1 к Реакции и Ловкости, позволяющий сделать эти значения больше 10.", true, "Молниеносная реакция", 1, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7795) },
                    { 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7796), "У эльфов есть врождённая творческая жилка и развитое чувство прекрасного. Эльфы получают врождённый бонус +1 к Искусству.", true, "Чувство прекрасного", 2, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7796) },
                    { 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7797), "Благодаря давним традициям и постоянным тренировкам эльфы — одни из лучших лучников в мире. Эльфы получают врождённый бонус +2 к Стрельбе из лука и способны выхватывать и натягивать лук, не тратя на это действие.", true, "Стрелок", 2, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7798) },
                    { 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7799), "Эльфы тесно связаны с природой. Они не тревожат животных — любой зверь, встреченный эльфом, будет относиться к нему дружелюбно и не нападёт без провокации. Эльфы также способны автоматически находить любые обычные и повсеместные субстанции растительного происхождения, если искомые растения обитают в природе на данной территории", true, "Единение с природой", 2, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7799) },
                    { 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7800), "У краснолюдов весьма крепкая кожа, имеющая врождённую прочность 2. Данная величина прибавляется к прочности любой брони и не может быть понижена разрушающим уроном.", true, "Закаленный", 3, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7800) },
                    { 9, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7802), "Благодаря невысокому росту и склонности к тяжелой работе, требующей физических усилий, краснолюды получают +1 к Силе и повышают свое значение Переносимого веса на 25.", true, "Силач", 3, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7802) },
                    { 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7803), "Краснолюды - прекрасные оценщики, обладающие вниманием к деталям, а потому обмануть их весьма трудно. Краснолюды получают врожденный бонус +1 к Торговле.", true, "Наметанный глаз", 3, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7803) },
                    { 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7804), "В мире, где нелюдям не доверяют, людям довериться куда проще. У людей есть врожденный бонус +1 к проверкам Харизмы, Соблазнения и Убеждения против других людей.", true, "Доверие", 4, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7805) },
                    { 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7806), "Люди умны и зачастую находят великолепные решения сложных проблем. Люди получают врожденный бонус +1 к Дедукции.", true, "Изобретательность", 4, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7806) },
                    { 13, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7807), "Одно из величайших преимуществ человеческой расы — нежелание отступать даже в опасной ситуации. Они могут собраться с духом и перебросить неудачный результат проверки Сопротивления убеждению или Храбрости, но не более 3 раз за игровую партию. В таком случае из двух результатов выбирают наивысший, но если результат всё равно провальный, то вновь использовать Упрямство нельзя.", true, "Упрямство", 4, 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7807) }
                });

            migrationBuilder.InsertData(
                table: "AlchemicalItems",
                columns: new[] { "Id", "ItemType" },
                values: new object[] { 1, 0 });

            migrationBuilder.InsertData(
                table: "Armors",
                columns: new[] { "Id", "AmountOfEnhancements", "EquipmentType", "ItemOriginType", "ItemType", "Reliability", "Stiffness", "Type" },
                values: new object[] { 2, 1, 1, 1, 0, 3, 0, 1 });

            migrationBuilder.InsertData(
                table: "AttackEffectList",
                columns: new[] { "Id", "AttackId", "ChancePercent", "Damage", "EffectId", "IsDealDamage" },
                values: new object[,]
                {
                    { 1, null, 0, "50м", 50, false },
                    { 2, null, 0, "", 21, false },
                    { 3, null, 0, "", 51, false }
                });

            migrationBuilder.InsertData(
                table: "Blueprints",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 86, 70, 10, 0, 3f });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "Amount", "Complexity", "IsAlchemical", "ItemType", "SubstanceType", "WhereToFind" },
                values: new object[,]
                {
                    { 3, "1к10", 10, false, 0, 0, "Костер и Сгоревшие предметы" },
                    { 4, "1к10", 14, false, 0, 0, "Костер, Горы или Под землей" },
                    { 5, "1к10", 12, false, 0, 0, "Поля и Плантации" },
                    { 6, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 7, "", 0, false, 0, 0, "Покупается" },
                    { 8, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 9, "", 0, false, 0, 0, "Покупается или Изготавливается" },
                    { 10, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 11, "1к6", 10, false, 0, 0, "Леса" },
                    { 12, "", 0, false, 0, 0, "Покупается" },
                    { 13, "", 0, false, 0, 0, "Покупается или Изготавливается" },
                    { 14, "2к6", 8, false, 0, 0, "Леса" },
                    { 15, "1к6", 12, false, 0, 0, "Леса и Поля" },
                    { 16, "Варьируется", 0, false, 0, 0, "Чудовища и Животные" },
                    { 17, "", 0, false, 0, 0, "Покупается" },
                    { 18, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 19, "1к6", 0, false, 0, 0, "Виверны" },
                    { 20, "1к6", 0, false, 0, 0, "Птицы" },
                    { 21, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 22, "", 0, false, 0, 0, "Покупается или Изготавливается" },
                    { 23, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 24, "3", 0, false, 0, 0, "Волки" },
                    { 25, "1к6", 16, false, 0, 0, "Леса" },
                    { 26, "1к6", 16, false, 0, 0, "Реки и Побережье" },
                    { 27, "1к10", 14, false, 0, 0, "Леса и Поля" },
                    { 28, "1к10", 14, false, 0, 0, "Пещеры и Горы" },
                    { 29, "Варьируется", 0, false, 0, 0, "Места силы, Маги и Бесы" },
                    { 30, "1к10", 14, false, 0, 0, "Пещеры" },
                    { 31, "1к6", 16, false, 0, 0, "Горы и Пещеры" },
                    { 32, "1к10", 14, false, 0, 0, "Поля и Леса" },
                    { 33, "1к6", 18, false, 0, 0, "Горы и Под землей" },
                    { 34, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 35, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 36, "1к6/2", 24, false, 0, 0, "Горы и Под землей" },
                    { 37, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 38, "1к6/2", 20, false, 0, 0, "Горы и Под землей" },
                    { 39, "1к6/2", 18, false, 0, 0, "Горы и Под землей" },
                    { 40, "1к6", 16, false, 0, 0, "Горы и Под землей" },
                    { 41, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 42, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 43, "1к6/2", 24, false, 0, 0, "Где угодно на поверхности земли" },
                    { 44, "1к6", 14, false, 0, 0, "Реки и Берега реки" },
                    { 45, "1к6/2", 16, false, 0, 0, "Горы и Под землей" },
                    { 46, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 47, "2к6", 8, false, 0, 0, "Где угодно" },
                    { 48, "", 0, false, 0, 0, "Покупается и Изготавливается" },
                    { 49, "1к6/2", 18, false, 0, 0, "Горы и Под землей" },
                    { 50, "1к10", 12, true, 0, 1, "Пещеры" },
                    { 51, "1к10", 12, true, 0, 1, "Горы и Города" },
                    { 52, "1к6/2", 20, true, 0, 1, "Территория бесов или Бесы" },
                    { 53, "1к6", 15, true, 0, 2, "Поля и Леса" },
                    { 54, "1к6", 15, true, 0, 2, "Леса" },
                    { 55, "1к6/2", 18, true, 0, 3, "Горы и Под землей" },
                    { 56, "1к10", 12, true, 0, 3, "Поля" },
                    { 57, "1к10", 12, true, 0, 3, "Поля" },
                    { 58, "1к10", 12, true, 0, 3, "Горы и Под землей" },
                    { 59, "2к6", 10, true, 0, 3, "Поля" },
                    { 60, "1к10", 12, true, 0, 3, "Горы и Под землей" },
                    { 61, "1к6", 15, true, 0, 4, "Поля, Леса и Горы" },
                    { 62, "1к6", 16, true, 0, 4, "Леса и Поля" },
                    { 63, "1к6/2", 18, true, 0, 4, "Леса и Поля" },
                    { 64, "1к6", 15, true, 0, 4, "Горы и Под землей" },
                    { 65, "1к10", 12, true, 0, 5, "Горы и Под землей" },
                    { 66, "1к6", 15, true, 0, 5, "Леса и Поля" },
                    { 67, "1к6", 15, true, 0, 5, "Горы" },
                    { 68, "1к10", 12, true, 0, 5, "Поля" },
                    { 69, "1к10", 12, true, 0, 5, "Поля" },
                    { 70, "1к10", 12, true, 0, 5, "Поля" },
                    { 71, "1к6/2", 18, true, 0, 6, "Винокурни" },
                    { 72, "1к6", 15, true, 0, 6, "Поля" },
                    { 73, "1к10", 12, true, 0, 6, "Леса и Поля" },
                    { 74, "1к6/2", 18, true, 0, 6, "Чудовища и Под землей" },
                    { 75, "1к6", 15, true, 0, 7, "Поля" },
                    { 76, "1к6", 15, true, 0, 7, "Синие горы" },
                    { 77, "1к6/2", 18, true, 0, 8, "Под землей" },
                    { 78, "1к6", 0, true, 0, 8, "Гнезда эндриаг" },
                    { 79, "1к6/3", 20, true, 0, 9, "Дно океана и Побережье" },
                    { 80, "1к6", 15, true, 0, 9, "Поля" },
                    { 81, "1к6", 15, true, 0, 9, "Поля" },
                    { 82, "1к6", 15, true, 0, 9, "Леса" },
                    { 83, "1к10", 12, true, 0, 9, "Горы и Болота" },
                    { 84, "1к6/2", 18, true, 0, 9, "Горы и Под землей" },
                    { 85, "2к6", 10, true, 0, 9, "Леса и Пещеры" }
                });

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AdditionalInformation", "Armor", "AthleticsBase", "BlockBase", "Complexity", "CreateDate", "Description", "EducationSkill", "Enabled", "EvasionBase", "GroupSize", "HabitatPlace", "Height", "ImageFileName", "Intellect", "MoneyReward", "MonsterLoreInformation", "MonsterLoreSkill", "MutagenId", "Name", "RaceId", "Regeneration", "SkillsListId", "SourceId", "SpellResistBase", "StatsListId", "SuperstitionsInformation", "TrophyId", "UpdateDate", "Weight" },
                values: new object[] { 1, "", 5, 9, 12, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8020), "", 8, true, 10, "Банда из 3-15 разбойников", "Часто рядом с городами и на трактах", 180, "", "Человеческий", 10, "Разбойники — одна из самых распространённых угроз на дороге, но отнюдь не самая опасная. Куда тяжелее скинуть с себя гуля, чем расправиться с парочкой разбойников. Но порой они могут представлять настоящую угрозу, особенно когда их много. Большая часть разбойников — это солдаты без армии, наёмники без контракта или дезертиры, которые покинули одну из воюющих сторон. Разбойники просты. Первые ряды побегут с полуторными мечами наголо. Те, кто на такое не способен, воспользуются арбалетами. Разбойникам обычно нужны три вещи: безопасность, деньги и что-нибудь, на чём можно выместить свой гнев. С ними не то чтобы просто расправиться, но, в отличие от большинства чудовищ, можно воззвать к их разуму. Возможно, вы сумеете убедить их не убивать вас. Разбойники, скорее всего, сдадутся, если вы нанесёте им достаточно урона.\r\nОднако некоторые разбойники, странствующие крепко сбитыми группами, могут начать сражаться яростнее, если убить их товарищей. На истерзанном войной Севере стоит быть осторожнее: нехватка пищи заставила некоторых разбойников стать каннибалами. Каннибалы зачастую сходят с ума и нападают с бешеной яростью — они не сдаются, даже стоя одной ногой в могиле. Если не хотите драться, будьте внимательны на дороге. =", 10, null, "Разбойник", 4, 0, 1, 1, 8, 1, "Хе, разбойники, дезертиры, ренегаты, сукины дети... Называй их как хочешь. Люди ступают на преступный путь ради денег и власти, но в большинстве своём они делают это от страха и голода. Все знают, что уровень преступности растёт во время войны. Так было в прошлых двух войнах, и вот сейчас опять. Но это не значит, что простой народ с этим согласен. Хех, не говорите это в лицо убийце, но среднестатистический ублюдок о бандите того же мнения, что и о гуле. И те, и другие прячутся по грязным закоулкам мира, ждут момента, чтобы напасть, и устраивают засаду на добрых трудяг, чтобы отобрать заработанное кровью и потом.", null, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8020), 80f });

            migrationBuilder.InsertData(
                table: "Formulas",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 87, 1, 1, 0, 0f });

            migrationBuilder.InsertData(
                table: "ItemBaseEffectList",
                columns: new[] { "Id", "ChancePercent", "Damage", "EffectId", "IsDealDamage", "ItemBaseId" },
                values: new object[,]
                {
                    { 1, 75, "", 2, false, 2 },
                    { 2, 0, "2к6+2", 2, true, 1 },
                    { 3, 0, "", 1, false, 54 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemType", "StealthType", "Type" },
                values: new object[,]
                {
                    { 88, 0, 0, 0 },
                    { 91, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Amount", "ItemBaseId" },
                values: new object[] { 1, "3к10", 90 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6975), "", true, false, false, "Внимание", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6976) },
                    { 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6979), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6979) },
                    { 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6981), "", true, false, false, "Дедукция", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6981) },
                    { 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6982), "", true, false, true, "Монстрология", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6982) },
                    { 5, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6983), "", true, false, false, "Образование", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6984) },
                    { 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6985), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6985) },
                    { 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6986), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6986) },
                    { 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6988), "", true, false, true, "Тактика", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6988) },
                    { 9, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6990), "", true, false, false, "Торговля", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6990) },
                    { 10, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6991), "", true, false, false, "Этикет", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6991) },
                    { 11, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6992), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6993) },
                    { 12, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6994), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6994) },
                    { 13, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6996), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6996) },
                    { 14, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6997), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6998) },
                    { 15, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6999), "", true, false, false, "Борьба", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(6999) },
                    { 16, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7000), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7000) },
                    { 17, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7002), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7002) },
                    { 18, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7003), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7003) },
                    { 19, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7004), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7005) },
                    { 20, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7006), "", true, false, false, "Мореходство", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7006) },
                    { 21, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7007), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7007) },
                    { 22, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7008), "", true, false, false, "Атлетика", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7009) },
                    { 23, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7010), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7010) },
                    { 24, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7011), "", true, false, false, "Скрытность", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7011) },
                    { 25, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7012), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7013) },
                    { 26, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7014), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7014) },
                    { 27, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7015), "", true, false, false, "Сила", 1, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7016) },
                    { 28, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7017), "", true, false, false, "Стойкость", 1, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7017) },
                    { 29, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7019), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7019) },
                    { 30, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7020), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7020) },
                    { 31, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7022), "", true, false, false, "Выступление", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7022) },
                    { 32, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7023), "", true, false, false, "Искусство", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7023) },
                    { 33, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7024), "", true, false, false, "Лидерство", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7025) },
                    { 34, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7026), "", true, false, false, "Обман", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7026) },
                    { 35, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7027), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7027) },
                    { 36, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7028), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7029) },
                    { 37, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7030), "", true, false, false, "Убеждение", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7030) },
                    { 38, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7031), "", true, false, false, "Харизма", 1, 6, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7031) },
                    { 39, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7032), "", true, false, true, "Алхимия", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7033) },
                    { 40, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7034), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7034) },
                    { 41, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7035), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7036) },
                    { 42, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7037), "", true, false, true, "Изготовление", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7037) },
                    { 43, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7038), "", true, false, false, "Маскировка", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7038) },
                    { 44, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7039), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7040) },
                    { 45, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7042), "", true, false, false, "Подделывание", 1, 7, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7042) },
                    { 46, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7043), "", true, false, false, "Запугивание", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7043) },
                    { 47, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7044), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7045) },
                    { 48, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7064), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7064) },
                    { 49, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7066), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7066) },
                    { 50, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7067), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7068) },
                    { 51, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7069), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7069) },
                    { 52, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7070), "", true, false, false, "Храбрость", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7070) },
                    { 53, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7072), "Большинство ведьмаков проводят детство и юность в крепости, корпя над пыльными томами и проходя чудовищные боевые тренировки. Многие говорят, что главное оружие ведьмака — это знания о чудовищах и умение найти выход из любой ситуации. Находясь в опасной среде или на пересечённой местности, ведьмак может снизить соответствующие штрафы на половину значения своего навыка Подготовка ведьмака (минимум 1). Подготовку ведьмака также можно использовать в любой ситуации, где понадобился бы навык Монстрология.", true, true, false, "Подготовка ведьмака", 1, 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7072) },
                    { 56, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7076), "Когда ведьмак становится целью заклинания, инвокации или порчи, он может совершить проверку способности Гелиотроп, чтобы попытаться отменить эффект. Он должен выкинуть результат, который больше либо равен результату его противника, а также потратить количество Выносливости, равное половине Выносливости, затраченной на сотворение магии.", true, true, false, "Гелиотроп", 1, 8, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7076) },
                    { 59, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7080), "Принимая отвар, ведьмак может совершить проверку Трансмутации со СЛ 18. При успехе тело ведьмака принимает в себя несколько больше мутагена, чем обычно, что позволяет получить бонус в зависимости от принятого отвара (см. таблицу на полях). Длительность действия отвара уменьшается вдвое. Дополнительные мутации слишком малы, чтобы их заметить.", true, true, false, "Трансмутация", 1, 4, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7080) },
                    { 60, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7082), "Ведьмак может совершить проверку этой способности со штрафом -3, чтобы отбить летящий физический снаряд. При отбивании ведьмак может выбрать цель в пределах 10 м. Эта цель должна совершить действие защиты против броска Отбивания стрел ведьмака, или она будет ошеломлена из-за попадания отбитого снаряда.", true, true, false, "Отбивание стрел", 1, 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7082) },
                    { 61, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7084), "Закончив свой ход, ведьмак может потратить 5 очков Вын и совершить проверку Быстрого удара со СЛ, равной Реа противника хЗ. При успехе ведьмак совершает ещё одну атаку в этот раунд против этого противника, которая может включать в себя разоружение, подсечку и прочие атаки.", true, true, false, "Быстрый удар", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7084) },
                    { 62, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7086), "Потратив 5 очков Вын за раунд, ведьмак может закрутиться в Вихре, совершая каждый ход по одной атаке против всех, кто находится в пределах дистанции его меча. Проверка Вихрясчитается проверкой атаки. Находясь в Вихре, ведьмак может только поддерживать его, уклоняться и передвигаться на 2 метра за раунд. Любое другое действие или полученный удар прекращают Вихрь.", true, true, false, "Вихрь", 1, 2, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(7086) }
                });

            migrationBuilder.InsertData(
                table: "SpellSkillProtectionList",
                columns: new[] { "Id", "MoreInfo", "SkillId", "SpellId" },
                values: new object[] { 6, "Воля существа x3", null, 2 });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "ItemType", "StealthType" },
                values: new object[] { 89, 0, 4 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Accuracy", "AmountOfEnhancements", "Damage", "Distance", "EquipmentType", "Grip", "IsAmmunition", "ItemType", "Reliability", "SkillId", "StealthType", "Type" },
                values: new object[] { 90, 1, 1, "1к6", 0, 0, 1, false, 0, 5, null, 2, 4 });

            migrationBuilder.InsertData(
                table: "BlueprintComponentList",
                columns: new[] { "Id", "Amount", "BlueprintId", "ComponentId" },
                values: new object[,]
                {
                    { 1, 2, 86, 9 },
                    { 2, 1, 86, 22 },
                    { 3, 6, 86, 13 },
                    { 4, 3, 86, 15 }
                });

            migrationBuilder.InsertData(
                table: "CreatureAttacks",
                columns: new[] { "Id", "AttackId", "CreatureId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "CreatureEffect",
                columns: new[] { "Id", "CreateDate", "CreatureId", "Description", "EffectId", "Enabled", "Name", "Type", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8085), 1, "Бей его", null, true, "Урон", 3, new DateTime(2024, 6, 25, 15, 41, 43, 850, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.InsertData(
                table: "CreatureRewardList",
                columns: new[] { "Id", "Amount", "CreatureId", "ItemBaseId" },
                values: new object[] { 1, "", 1, 90 });

            migrationBuilder.InsertData(
                table: "FormulaComponentList",
                columns: new[] { "Id", "Amount", "FormulaId", "SubstanceType" },
                values: new object[,]
                {
                    { 1, 1, 87, 3 },
                    { 2, 1, 87, 4 }
                });

            migrationBuilder.InsertData(
                table: "SpellComponentList",
                columns: new[] { "Id", "Amount", "ComponentId", "SpellId" },
                values: new object[] { 1, 2, 15, 4 });

            migrationBuilder.InsertData(
                table: "SpellSkillProtectionList",
                columns: new[] { "Id", "MoreInfo", "SkillId", "SpellId" },
                values: new object[,]
                {
                    { 1, "", 14, 1 },
                    { 2, "", 17, 1 },
                    { 3, "", 18, 1 },
                    { 4, "", 19, 1 },
                    { 5, "", 21, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_RaceId",
                table: "Abilities",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_SourceId",
                table: "Abilities",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttackEffectList_AttackId",
                table: "AttackEffectList",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_AttackEffectList_EffectId",
                table: "AttackEffectList",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Attacks_SourceId",
                table: "Attacks",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintComponentList_BlueprintId",
                table: "BlueprintComponentList",
                column: "BlueprintId");

            migrationBuilder.CreateIndex(
                name: "IX_BlueprintComponentList_ComponentId",
                table: "BlueprintComponentList",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SkillsTreeId",
                table: "Classes",
                column: "SkillsTreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SourceId",
                table: "Classes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureAbility_AbilityId",
                table: "CreatureAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureAbility_CreatureId",
                table: "CreatureAbility",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureAttacks_AttackId",
                table: "CreatureAttacks",
                column: "AttackId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureAttacks_CreatureId",
                table: "CreatureAttacks",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureEffect_CreatureId",
                table: "CreatureEffect",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureEffect_EffectId",
                table: "CreatureEffect",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_CreatureId",
                table: "CreatureRewardList",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_ItemBaseId",
                table: "CreatureRewardList",
                column: "ItemBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_MutagenId",
                table: "Creatures",
                column: "MutagenId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_RaceId",
                table: "Creatures",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_SkillsListId",
                table: "Creatures",
                column: "SkillsListId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_SourceId",
                table: "Creatures",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_StatsListId",
                table: "Creatures",
                column: "StatsListId");

            migrationBuilder.CreateIndex(
                name: "IX_Creatures_TrophyId",
                table: "Creatures",
                column: "TrophyId");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SourceId",
                table: "Effects",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaComponentList_FormulaId",
                table: "FormulaComponentList",
                column: "FormulaId");

            migrationBuilder.CreateIndex(
                name: "IX_Headlines_SourceId",
                table: "Headlines",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseEffectList_EffectId",
                table: "ItemBaseEffectList",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBaseEffectList_ItemBaseId",
                table: "ItemBaseEffectList",
                column: "ItemBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemBases_SourceId",
                table: "ItemBases",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Mutagen_SourceId",
                table: "Mutagen",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SourceId",
                table: "Races",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reward_ItemBaseId",
                table: "Reward",
                column: "ItemBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePrices_SourceId",
                table: "ServicePrices",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SourceId",
                table: "Skills",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StatId",
                table: "Skills",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillsTree_SourceId",
                table: "SkillsTree",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellComponentList_ComponentId",
                table: "SpellComponentList",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellComponentList_SpellId",
                table: "SpellComponentList",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_CreatureId",
                table: "Spells",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SourceId",
                table: "Spells",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSkillProtectionList_SkillId",
                table: "SpellSkillProtectionList",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSkillProtectionList_SpellId",
                table: "SpellSkillProtectionList",
                column: "SpellId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_SourceId",
                table: "Stats",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trophy_SourceId",
                table: "Trophy",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SkillId",
                table: "Weapons",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlchemicalItems");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttackEffectList");

            migrationBuilder.DropTable(
                name: "BlueprintComponentList");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "CreatureAbility");

            migrationBuilder.DropTable(
                name: "CreatureAttacks");

            migrationBuilder.DropTable(
                name: "CreatureEffect");

            migrationBuilder.DropTable(
                name: "CreatureRewardList");

            migrationBuilder.DropTable(
                name: "FormulaComponentList");

            migrationBuilder.DropTable(
                name: "Headlines");

            migrationBuilder.DropTable(
                name: "ItemBaseEffectList");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Reward");

            migrationBuilder.DropTable(
                name: "ServiceLogs");

            migrationBuilder.DropTable(
                name: "ServicePrices");

            migrationBuilder.DropTable(
                name: "SpellComponentList");

            migrationBuilder.DropTable(
                name: "SpellSkillProtectionList");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Blueprints");

            migrationBuilder.DropTable(
                name: "SkillsTree");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Formulas");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "ItemBases");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Mutagen");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "SkillsList");

            migrationBuilder.DropTable(
                name: "StatsList");

            migrationBuilder.DropTable(
                name: "Trophy");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
