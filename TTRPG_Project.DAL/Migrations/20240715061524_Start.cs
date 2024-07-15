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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    IsPlayable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    LeftBranchName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleBranchName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RightBranchName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    MutagenId = table.Column<int>(type: "int", nullable: true),
                    TrophyId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ImageFileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                    ItemOriginType = table.Column<int>(type: "int", nullable: false),
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
                values: new object[,]
                {
                    { 1, 39, 0, 30, 0, 26, 0, 32, 0, 22, 4, 1, 6, 43, 0, 38, 0, 6, 0, 47, 0, 52, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7969), 25, 4, 34, 0, 3, 0, 5, 0, true, 28, 5, 10, 0, 21, 4, 44, 0, 45, 0, 29, 0, 46, 0, 7, 0, 13, 0, 11, 0, 12, 0, 33, 0, 18, 5, 40, 0, 49, 4, 23, 0, 42, 0, 14, 0, 4, 0, 37, 50, 5, 0, 17, 0, 31, 0, 16, 0, 48, 0, 20, 0, 36, 0, 51, 0, 24, 3, 27, 0, 2, 5, 19, 6, 8, 0, 9, 0, 41, 0, 35, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7970), 15, 6 },
                    { 2, 39, 0, 30, 0, 26, 0, 32, 0, 22, 10, 1, 10, 43, 0, 38, 10, 6, 0, 47, 0, 52, 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8006), 25, 0, 34, 0, 3, 0, 5, 0, true, 28, 5, 10, 7, 21, 9, 44, 0, 45, 0, 29, 0, 46, 9, 7, 0, 13, 0, 11, 0, 12, 0, 33, 0, 18, 0, 40, 0, 49, 10, 23, 0, 42, 0, 14, 9, 4, 0, 37, 50, 9, 9, 17, 0, 31, 0, 16, 0, 48, 0, 20, 0, 36, 10, 51, 0, 24, 4, 27, 5, 2, 9, 19, 0, 8, 0, 9, 0, 41, 0, 35, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8007), 15, 9 }
                });

            migrationBuilder.InsertData(
                table: "SkillsTree",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "FirstLeftSkillId", "FirstLeftSkillValue", "FirstMiddleSkillId", "FirstMiddleSkillValue", "FirstRightSkillId", "FirstRightSkillValue", "ImageFileName", "LeftBranchName", "MainSkillId", "MainSkillValue", "MiddleBranchName", "Name", "RightBranchName", "SecondLeftSkillId", "SecondLeftSkillValue", "SecondMiddleSkillId", "SecondMiddleSkillValue", "SecondRightSkillId", "SecondRightSkillValue", "SourceId", "ThirdLeftSkillId", "ThirdLeftSkillValue", "ThirdMiddleSkillId", "ThirdMiddleSkillValue", "ThirdRightSkillId", "ThirdRightSkillValue", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7771), "", true, 54, 0, 57, 0, 60, 0, "", "Магический клинок", 53, 0, "Мутант", "", "Убийца", 55, 0, 58, 0, 61, 0, null, 56, 0, 59, 0, 62, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7772) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7775), "", true, 64, 0, 67, 0, 70, 0, "", "Стрелок", 63, 0, "Охотник за головами", "", "Убийца", 65, 0, 68, 0, 71, 0, null, 66, 0, 69, 0, 72, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7776) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7778), "", true, 74, 0, 77, 0, 80, 0, "", "Проповедник", 73, 0, "Друид", "", "Фанатик", 75, 0, 78, 0, 81, 0, null, 76, 0, 79, 0, 82, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7779) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7780), "", true, 84, 0, 87, 0, 90, 0, "", "Политик", 83, 0, "Ученый", "", "Архимаг", 85, 0, 88, 0, 91, 0, null, 86, 0, 89, 0, 92, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7781) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7783), "", true, 94, 0, 97, 0, 100, 0, "", "Хирург", 93, 0, "Травник", "", "Анатом", 95, 0, 98, 0, 101, 0, null, 96, 0, 99, 0, 102, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7783) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7785), "", true, 104, 0, 107, 0, 110, 0, "", "Вор", 103, 0, "Атаман", "", "Ассасин", 105, 0, 108, 0, 111, 0, null, 106, 0, 109, 0, 112, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7785) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7787), "", true, 114, 0, 117, 0, 120, 0, "", "Оружейник", 113, 0, "Алхимик", "", "Импровизатор", 115, 0, 118, 0, 121, 0, null, 116, 0, 119, 0, 122, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7787) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7789), "", true, 124, 0, 127, 0, 130, 0, "", "Посредник", 123, 0, "Человек со связями", "", "Гавенкар", 125, 0, 128, 0, 131, 0, null, 126, 0, 129, 0, 132, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7789) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7791), "", true, 134, 0, 137, 0, 140, 0, "", "Обольститель", 133, 0, "Информатор", "", "Интриган", 135, 0, 138, 0, 141, 0, null, 136, 0, 139, 0, 142, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7791) }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreateDate", "Enabled", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6259), true, "Базовая книга", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6270) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6272), true, "Хоумбрю", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6272) }
                });

            migrationBuilder.InsertData(
                table: "StatsList",
                columns: new[] { "Id", "ConstitutionId", "ConstitutionValue", "CraftsmanshipId", "CraftsmanshipValue", "CreateDate", "DexterityId", "DexterityValue", "EmpathyId", "EmpathyValue", "Enabled", "EnduranceId", "EnduranceValue", "EnergyId", "EnergyValue", "HandStrikeId", "HandStrikeValue", "HealthPointsId", "HealthPointsValue", "IntellectId", "IntellectValue", "JumpingId", "JumpingValue", "KickId", "KickValue", "LuckId", "LuckValue", "ReactionId", "ReactionValue", "ResilienceId", "ResilienceValue", "RestId", "RestValue", "RunningId", "RunningValue", "SpeedId", "SpeedValue", "UpdateDate", "WeightId", "WeightValue", "WillpowerId", "WillpowerValue" },
                values: new object[,]
                {
                    { 1, 4, 5, 7, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7900), 3, 5, 6, 3, true, 15, 20, 10, 0, 18, 0, 14, 20, 1, 3, 13, 2, 19, 2, 9, 0, 2, 6, 11, 4, 17, 4, 12, 12, 5, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7901), 16, 50, 8, 4 },
                    { 2, 4, 10, 7, 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7912), 3, 13, 6, 7, true, 15, 50, 10, 0, 18, 4, 14, 80, 1, 6, 13, 6, 19, 8, 9, 0, 2, 13, 11, 8, 17, 8, 12, 33, 5, 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7913), 16, 100, 8, 7 }
                });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "AttackSpeed", "AttackType", "BaseAttack", "CreateDate", "Damage", "Description", "Distance", "Enabled", "ImageFileName", "Name", "Reliability", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, 4, 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7838), "2к6+2", "", 0, true, "", "Железный полуторный меч", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7839) },
                    { 2, 1, 4, 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7842), "1к6", "", 0, true, "", "Кинжал", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7842) },
                    { 3, 1, 1, 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7844), "2к6+2", "", 0, true, "", "Ручной арбалет", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7844) },
                    { 4, 1, 1, 22, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7846), "5к6", "", 0, true, "", "Укус", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7846) },
                    { 5, 2, 4, 22, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7848), "4к6", "", 0, true, "", "Удар когтями", 15, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7848) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreateDate", "DefaultMagicAbilities", "Description", "Enabled", "Energy", "ImageFileName", "Name", "SkillsTreeId", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7810), "", "Я ведь уже говорил тебе, что странствовал какое-то время с ведьмаком? Так вот. Спросил я его как-то, почему он ведьмаком остался. Это ведь явно не работа мечты — входишь в деревню, дети прячутся, отцы своих дочурок по домам запирают. Впрочем, ответ был ожидаем — он попросту незнал другой жизни. На самом деле логично. Вот живёшь ты, живёшь, занимаешься одним делом, а больше-то ничего и не умеешь. Но не всё так плохо. Ведьмаки — это сила. Мечники они отменные — тот ведьмак, с которым я странствовал, как-то раз арбалетный болт отбил на лету. Могу повторить, если тебя это не впечатлило. Своим кручением-верчением они вполне способны в капусту покрошить более медленных мечников. Двигаются ведьмаки так быстро, что со стороны за мечом не уследишь и каждый взмах превращается в серебряную полосу. И не стоит забывать об алхимии! Раньше они точно с собой таскали всякие эликсиры и масла, благодаря которым на поле боя превращались в сущих дьяволов — становились быстрее и раны залечивали, как волколаки. Вдобавок ко всему ведьмаки чуточку магией владеют. Ну, не такой мощной, как настоящие чародеи, но всё же заклинания свои творят. Называется это знаками. Это такие пассы руками, обладающие магическим действием. Любой маг на это лишь пофыркает, поскольку такие вещи не дотягивают даже до простейших заклинаний, но всёравно знаки весьма эффективны. Так что честно тебе скажу: я рад, что ведьмаки только на чудовищ охотятся. Ну... по крайней мере, когда-то так было.", true, 2, "", "Ведьмак", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7810) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7813), "", "Никогда не знаешь, что случится, пока рядом с тобой бард. Часть лучших моих воспоминаний связана с бардами... Впрочем, часть самых скверных передряг я пережил как раз из-за бардов. Может статься, повстречаешь ты такого барда, как знаменитый Лютик: он и поэт, и искатель приключений, и постоянный спутник легендарного Геральта из Ривии. Он исходил весь мир в поисках знаний и историй, заглядывая в городки и деревни, чтобы петь там о своих многочисленных приключениях. Вот такие, как он, — ребята нормальные. Ну, разве что чёрта с два ты отличишь в их сказкахреальность от выдумки: барды любят правду искажать, чтобы показать себя в лучшем свете. В принципе, обычно это не мешает. Спрашиваешь, каких бардов опасаться стоит? Да всяких шпионов и интриганов. Барды вообще хорошо мозги промывают, да и сказки выдумывать горазды. Они тебеязык заговорят, голову вскружат, марионеткой своей сделают — и всё, будешь думать, что вы друзья до гроба. А потом в самый неожиданный момент получишь нож в печень. Неудивительно, что многие барды шпионят для разных королевств. Впрочем, хороший бард всегда пригодится. Например, нужно тебе узнать какую-то легенду или же хочешь награду получить за голову опасного атамана. Бард-mo тебе наверняка расскажет, на кого ты охотишься, где его найти и как с ним разговаривать. Как я уже говорил, никогда не знаешь, что случится, пока рядом с тобой бард.", true, 0, "", "Бард", 9, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7813) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7814), "", "Знаю я, что ты думаешь: Родольф, сукин ты карлик, ты морды чистил две войны подряд — небось ты воин, солдат до мозга костей! И ой как ошибаешься. Да, я сражался в двух войнах: на первой служил разведчиком, на второй — арбалетчиком. Воевал в Соддене и у Бренны. Да только не так хорошо я дрался, как настоящие воины, которые всю жизнь этим занимаются. Я сражался, потому что страну свою люблю. Но любовь к стране и арбалет в руках не делают из тебя солдата. Настоящие воины — это люди вроде Вернона Роше и Яна Наталиса. Вояк лучше них я за всю жизнь не встречал. Дело своё они знают от и до, поскольку настоящие солдаты войной живут. А когда войны нету, они служат телохранителями и наёмниками. Стоит им на поле боя за оружие взяться, как там сущий ад начинается: воины в латах несутся на врага, машут мечом размером с себя и рубят кавалеристам головы на раз-два. Отправь такого в болота Понтара — и вот тебе самый настоящий хищник, выискивающий эльфов меж деревьев, ставящий ловушки под каждым кустом и с лёгкостью читающий любое действие противника, словно долбаную книгу. А дашь ему арбалет, так он чёрного уложит одним выстрелом в глаз со ста двадцати ярдов. Воякой-то я был, но воином — никогда. И поверь, меня это вполне устраивает.", true, 0, "", "Воин", 2, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7815) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7816), "", "Как-то раз в Маг Турге повстречал я жреца необычайно широких взглядов. Он сказал мне: «Каждый своим путём к богам приходит». Думаю, такое описание подходит для всех жрецов. Есть на Юге культисты, что верят в великий катаклизм и новое солнце; на Севере есть фанатики, поклоняющиеся огню; и есть сумасшедшие, что славят богиню жизни и плодородия. Короче говоря, каждый в чём-то находит божественное. Тяжело доказать, что твой бог единственный, так что церквей повсюду полно. Некоторые жрецы обладают магическим даром, да только чёрта с два они признают, чторавны магам-безбожникам. И неважно, что сходств выше крыши, ведь жрецам магию даруют божества, которым они молятся, а значит, эта магия богоугодна. Такие жрецы, обычно опекают города, заботятся о духе земли и следят, чтобы живущие на этой земле люди были благочестивы и поклонялись их богу. Есть ещё друиды. В целомребята они добрые, если только ты не браконьер или ещё какой-нибудь поганец. Они живут в единении с природой и жизнь кладут на то, чтобы сохранять равновесие. Лично я ни разу не встречал друида, но рассказы о них слыхал. Сейчас друидов всё меньше. Судя по слухам, большинство живёт на островах Скеллиге. Кроме них, бывают ещёрадикалы и настоящие культисты. Вот этих стоит опасаться: никогда не знаешь, что сотворит какой-нибудь безумец, ведомый голосом своего божества. Хуже только сумасшедший жрец, что велит пастве исполнять волю богов — нечто подобное сейчас в Редании можно видеть. Страна сошла сума с тех самых пор, как там обосновался культ Вечного Огня. ", true, 2, "", "Жрец", 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7816) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7817), "", "Маги, колдуны, ведьмы... по-разному их кличут. Лично я называю их проблемой, но это моё скромное мнение. Маг — это тот, кто способен использовать природную магию стихий, которую люди зовут Изначальным Хаосом. Учатся маги в расфуфыренных школах вроде Бан Арда и Аретузы на Севере и Гвейсон Хайль на Юге. Имел я, кхм, дело с одной чародейкой пару лун тому назад, так она меня просветила в перерывах между перепихонами. Сказала, мол, маги — это мощные проводники магической энергии, и пока они не используют её слишком много, они, считай, что угодно могут с этой энергией творить. А если у мага при себе фокусирующий предмет вроде жезла, посоха или амулета, то он может ещё больше магической энергии заграбастать. И что, мол, в академиях магов учат думать наперёд, использовать магию для развития науки и улучшения жизни простого люда. Весьма позитивный взгляд на вещи. Что ж, маги нехило так жизнь улучшили, и без них, наверно, не было бы науки в том виде, в каком мы её сейчас знаем. Долгое время при каждом королевском дворе было по магу-советнику, благодаря чему маги стали, считай, одними из самых могущественных и влиятельных существ в мире. Многие из них и по сей день используют все те приёмчики, которым при дворе научились. И как минимум поэтому они опасны. Но теперь, после той заварушки с Ложей, магам никто не доверяет, как на Севере, так и на Юге. Моя подружка-чародейка всё потеряла из-за этих потаскух. На Севере она и в город теперь войти не может, не скрываясь", true, 5, "", "Маг", 4, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7818) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7819), "", "Все, кто хоть сколько-то в армии служил, знают, как полезен бывает хороший медик. Скажу тебе так, друже: если бы у меня сейчас все залеченные медиками раны открылись, я бы не на краснолюда был похож, а на гуля. Странствовал я както с медиком из Нильфгаарда. Один из немногих чёрных, кого я терпел. Клянусь, этот сукин сын чуть ли не чудеса творил, когда в настроении был, — такому любой хороший медик обучен. Такие берут и вырывают парней из лап смерти. Они используют всё, чему научились в этих своих академиях, чтобы понять, чем ты болен, что у тебя за рана, да как ещё тебя при этом на ноги поставить. Хороший медик знает и всякие целебные отвары. Я вершки да корешки продаю едва ли не всем встречным грамотеям, но вот медики все эти растения используют поболе остальных — варят из них припарки, эликсиры, да в порошки растирают. И всё это, чтобы остановить кровотечение, унять тошноту, с болезнью справиться. Как я слыхал, самые лучшие травники сами лекарства мешают. Самоубийство чистой воды, как по мне, но я тут не знаток — я не умею намешать кучу разной зелени, чтобы она при этом пользу приносила. Впрочем, если не лекарство намешаешь, то неплохой яд. Ведь медик знает не только как лечить, но и как калечить: где надо резать, как раны сделать хуже и трудней для излечения. Они умеют такие вещи, которые я лично никогда бы не стал использовать другим во вред. Но, если так подумать, в этом мире даже медику приходится порой за свою жизнь драться.", true, 0, "", "Медик", 5, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7819) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7821), "", "Преступник — термин весьма расплывчатый. Сюда относятся и профессиональные взломщики, и наёмные убийцы. Всех этих ребят объединяет одно: если их сцапают, им конец. Врать не стану, я имел дело с преступниками, считай, всюду, от Ковира до Геммеры. Контрабандисты, убийцы и воры всехмастей. Иногда они вполне себе неплохие ребята. С ворами дела вести просто, и порой их навыки действительно могут пригодиться. Взломщики, щипачи и домушники — вот кого стоит искать, если хочешь вломиться в чужой дом. Если надо проникнуть через запертые ворота или заполучить что-то без шума и грязи, обращайся к вору. Наёмные убийцы тоже неплохи, если только их не наняли по твою душу. В своё время я знавал парочку, и у каждого были свои моральные принципы, побольше даже, чем у большинства воров. У них на всё свои правила: кого убивать, а кого нет, что слишком рискованно, что по дешёвке сделать, а за что содрать с клиента последнюю шкуру. Но, так или иначе, зарабатывают они убийством и делают это хорошо. Встречал я одну эльфку, так у неё при себе было шестнадцать ножей. Чёрт знает, где она их все прятала. Стоит упомянуть и профессиональных преступников — вроде лидеров банд, чья профессия — организовывать и совершать преступления. Вот их реально следует опасаться. Среди этих ребят полно дураков-филантропов, которые грабят богачей и раздают деньги своим людям, и хладнокровных садюг-убийц. Они всегда действуют только себе на пользу и выбирают тот путь, который принесёт им больше выгоды. Когда с ними общаешься, невольно ощущаешь себя пешкой в большой игре. ", true, 0, "", "Преступник", 6, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7821) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7822), "", "Ремесленник — пожалуй, самаяраспространённая профессия после крестьянина. Ну, на самом деле шлюх тоже немало, но ты меня понял. Ремесленники, или мастера, занимаются всем и вся: и обувь делают, и зелья варят. Но если ремесленник отправляется в какое-нибудь опасное приключение, то это, скорее всего, кузнец или алхимик. Алхимик в любом походе полезен. Наука-то древняя, и хороший алхимик способен много полезностей сделать: кислоту, горючую жидкость, бомбы и всякое такое. Конечно, если у тебя есть нужные инструменты, ты и сам можешь что-нибудь полезное сварганить, но только профессиональный алхимик сделает это идеально. Может, я и предвзято говорю, но как по мне, кузнецы — самые уважаемые ремесленники. Они часами торчат у пылающего горна, работают с самыми твёрдыми материалами и при этом действуют точно и аккуратно. Хороший кузнец способен выковать настолько острый меч, что тот пробьёт доспех самого большого и крепкого врага, или же смастерить броню, которая выдержит удар чёртова тролля. Я и сам какое-то время поработал кузнецом в Ангрене до Второй войны, и честно скажу: работа не из лёгких. Когда я в армии служил и сражался с чёрными, меня с ребятами послали в болота Соддена, отбиваться от отряда нильфов. Мы остановили их по другую сторону реки, но за целый день боя мой арбалет промок, и тетива растянулась. Прямо там, посреди заварушки, пока остальные обстрел вели и сражались по колено в грязи, мастер по имени Клаус мне новую тетиву натянул, и я вновь бросился в бой. Я этому парню жизнью обязан.", true, 0, "", "Ремесленник", 7, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7822) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7824), "", "Посмотри вокруг. Пошуруй, что у тебя в заплечном мешке, в поясной сумке да в перемётной суме. Наверняка большую часть скарба ты у торговца прикупил. Ну как, прав я?Дружище, народ не слишком ценит торговцев и попросту не понимает, насколько мы важны. Торговцы привозят то, что людям нужно. Вот нужен мужику из Метинны меч из Редании. Да, он может рискнуть своей шкурой и сам за ним отправиться, а может найти торговца. Ты навряд ли хоть раз в жизни побываешь в Зеррикании, но пока оттуда раз в месяц приходят корабли, ты получишь и кость, и экзотические сабли, и прочую дребедень. У хорошего торговца связи есть по всему миру. Мы знаем, что продать, где это достать и как заплатить подешевле. Ежели тебе нужна какая информация или услуга — найди торговца. Уменя друзья почти в каждом городе, и за пару монет я могу разузнать почти о чём угодно. Кстати, о монетах. Ах, монетки! Если ты не полный дурак, то наваришь прибыль на чём угодно. Прибыль — это деньги, а деньги — это власть. Надо пробраться на пышный приём? Это куда легче сделать, если ты разодет по последней моде и позвякиваешь кошелём размером с краснолюдский кулак. Скажешь, я не хочу руки марать? Всегда есть тот, кто готов за тебя выполнить грязную работёнку за справедливую цену. Сама жизнь торговца зависит от его связей, знаний и товара. Если с этими тремя вещами у тебя всё в порядке, ты точно озолотишься. Только послушай моего совета: под сиденьем повозки держи арбалет. Так, на всякий случай. Вдруг попадутся клиенты, не желающие платить. ", true, 0, "", "Торговец", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7824) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6920), "Это оружие легко спрятать. Вы получаете бонус +2 при попытке скрыть это оружие.", true, "", "Незаметное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6920) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6921), "Если это оружие нанесёт урон цели, с определённой вероятностью оно может вызвать кровотечение.Вероятность кровотечения указана в скобках.", true, "", "Кровопускающее", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6921) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6923), "Такое оружие игнорирует сопротивление урону любой брони, по которой оно попадает.", true, "", "Пробивающее броню", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6923) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6924), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "", "Дезориентирующее(1)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6924) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6925), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "", "Дезориентирующее(2)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6926) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6927), "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости, к которому применяется штраф, указанный в скобках.", true, "", "Дезориентирующее(3)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6927) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6928), "Это оружие наносит полный урон чудовищам, уязвимым к метеоритной стали. Также такое оружие имеет 5 дополнительных пунктов надёжности.", true, "", "Метеоритное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6929) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6930), "Этим оружием можно атаковать противников в пределах 2 метров.", true, "", "Длинное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6930) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6931), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "", "Фокусирующее(1)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6931) },
                    { 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6932), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "", "Фокусирующее(2)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6932) },
                    { 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6933), "При сотворении магии с помощью этого оружия вычтите его значение фокусировки из стоимости заклинания в Вын.", true, "", "Фокусирующее(3)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6933) },
                    { 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6934), "Атаки наносят двойной разрушающий урон оружию, щиту или броне.", true, "", "Сокрушающая сила", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6935) },
                    { 13, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6936), "Когда вы атакуете чудовище восприимчивое к серебряному оружию, то наносите не только стандартный урон, но и определённое количество урона от серебра, обозначенное в скобках.", true, "", "Серебрянное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6936) },
                    { 14, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6937), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "", "Сбалансированное(1)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6937) },
                    { 15, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6938), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "", "Сбалансированное(2)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6938) },
                    { 16, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6939), "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности критического ранения.", true, "", "Сбалансированное(3)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6939) },
                    { 17, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6940), "Такое оружие игнорирует сопротивление урону любой брони и половину прочности брони,по которой оно попадает.", true, "", "Улучшенное пробивание брони", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6941) },
                    { 18, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6941), "Это оружие можно использовать для захвата и подсечки противника в пределах дистанции.", true, "", "Захватное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6942) },
                    { 19, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6943), "Когда владелец блокирует рукопашную атаку врага этим оружием, часть его оружия оказывается в ловушке. Оба оружия становятся бесполезными и не могут быть разделены до тех пор, пока противник не сможет пройти проверку Силы или Ловкости рук, которая превзойдет изначальную проверку Владения лёгкими клинками, или пока владелец не выпустит свое оружие.", true, "", "Ловящий лезвия", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6943) },
                    { 20, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6944), "Пока существо прикасается к этому оружию, оно не может стать невидимым или неосязаемым или использовать любую способность, которая позволяет ему телепортироваться. Существа, которые уже являются невидимыми или неосязаемыми, становятся видимыми и осязаемыми при прикосновении к этому оружию.", true, "", "Магические путы", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6944) },
                    { 21, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6945), "Для перезарядки этого оружия требуется 1 действие.", true, "", "Медленно перезаряжающееся", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6945) },
                    { 22, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6946), "Это оружие можно использовать для нанесения несмертельного урона без штрафов.", true, "", "Несмертельное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6946) },
                    { 23, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6947), "Цель, пораженная этим оружием, становится опутанной. Она снижает свою Скор на 5 и получает штраф -2 ко всем физическим действиям. Каждый ход цель может совершать проверку Уклонения/Изворотливости или Борьбы со СЛ 18, чтобы высвободиться. В качестве альтернативы другой персонаж может потратить действие, чтобы освободить опутанного.", true, "", "Опутывающее", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6948) },
                    { 24, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6949), "-2 к штрафу за парирование.", true, "", "Парирующее", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6949) },
                    { 25, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6950), "При попадании это оружие наносит 1d6 / 2 урона прочности брони.", true, "", "Разрушающее", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6950) },
                    { 26, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6951), "Такое оружие использует навык Борьба. Его урон прибавляется к урону от атаки без оружия.", true, "", "Рукопашное", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6951) },
                    { 27, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6953), "Чтобы перезарядить это оружие, требуется потратить 2 действия. Эти действия могут быть совершены двумя разными персонажами.", true, "", "Расчетная перезарядка", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6953) },
                    { 28, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6954), "При сотворении заклинаний с помощью этого оружия СЛ проверок против ваших заклинаний считается на 2 выше.", true, "", "Улучшенное фокусирующее", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6954) },
                    { 29, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6955), "Это оружие фиксируется в одном месте, а не удерживается. Персонаж должен потратить действие, чтобы установить оружие там, где он хочет его использовать, и должен потратить действие, чтобы демонтировать его, когда он захочет снова его переместить.", true, "", "Устанавливаемое", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6955) },
                    { 30, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6956), "Это оружие может быть заряжено флаконом с любым ядом или эликсиром. Когда владелец наносит урон этим оружием, он впрыскивает содержимое глубоко в организм цели. Это увеличивает СЛ для избавления от яда на 3 или увеличивает продолжительность действия эликсира на 3 раунда.", true, "", "Шприц", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6957) },
                    { 31, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6957), "Данный доспех закрывает: голову, туловище, руки и ноги.", true, "", "Закрывает все тело", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6958) },
                    { 32, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6959), "Если атака, заблокированная этим щитом, была огненной, то щит не получает повреждений от блокирования.", true, "", "Огнеупорный", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6959) },
                    { 33, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6960), "Как только персонаж опускает забрало шлема, его поле зрения сужается до конуса прямо перед ним вместо обычного поля от плеча до плеча. Этот эффект также отменяет Обострённые чувства ведьмака (бонус к Вниманию и выслеживанию по запаху).", true, "", "Ограничение зрения", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6960) },
                    { 34, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6961), "Этот щит достаточно велик, чтобы за ним можно было спрятаться целиком, как за стенкой. Если персонаж сидит на корточках за этим щитом, она действует как укрытие, и любая атака, направленная против персонажа, должна нанести урон, превышающий надёжность щита, чтобы навредить персонажу. Каждый раз, когда этот щит получает урон, его надёжность снижается на 1.", true, "", "Полное укрытие", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6961) },
                    { 35, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6962), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Д – Дробящий урон.", true, "", "Сопротивление(Д)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6962) },
                    { 36, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6963), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Р – Режущий урон.", true, "", "Сопротивление(Р)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6964) },
                    { 37, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6965), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. К – Колющий урон.", true, "", "Сопротивление(К)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6965) },
                    { 38, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6966), "Снижает урон от атак определённого типа в два раза после вычитания ПБ. С – Стихийный (обычно указывается стихия вместо буквы).", true, "", "Сопротивление(С)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6966) },
                    { 39, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6967), "Персонаж объят пламенем. Каждый ход он получает 5 пунктов урона по каждой части тела. Броня поглощает урон, но при этом огонь наносит 1 урон броне и оружию каждый ход. Чтобы погасить огонь, персонаж должен потратить ход либо на обливание водой, либо на то, чтобы упасть на землю, покататься и сбить пламя.", true, "", "Горение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6967) },
                    { 40, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6968), "Персонаж дезориентирован. У него кружится голова, перед глазами всё плывёт. В этом состоянии он не может совершать каких-либо действий, а для того, чтобы попасть по нему, достаточно пройти проверку со СЛ 10. Чтобы завершить этот эффект, персонаж должен пройти испытание Устойчивости. Это действие занимает полный ход. Если по персонажу попадают, пока он дезориентирован, он тут же приходит в себя.", true, "", "Дезориентация", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6968) },
                    { 41, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6969), "В крови персонажа течёт яд, наносящий ему каждый ход 3 урона, не снижаемые бронёй. Чтобы прекратить действие яда, персонаж должен пройти проверку Стойкости со СЛ 15, потратив одно действие.", true, "", "Отравление", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6970) },
                    { 42, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6970), "При ранении был задет крупный сосуд, из-за чего рана сильно кровоточит. Персонаж получает 2 урона каждый ход до тех пор, пока кровотечение не будет остановлено. Для этого необходимо либо сотворить исцеляющее заклинание, либо совершить успешную проверку Первой помощи со СЛ 15, потратив одно действие.", true, "", "Кровотечение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6971) },
                    { 43, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6972), "Персонаж не превратился в цельный кусок льда, но тело его плохо слушается, а одежда покрыта наледью. До тех пор, пока персонаж не сломает лёд, он получает штраф -3 к Скор и -1 к Реа. Лёд можно сломать, пройдя проверку Силы со СЛ 16 и потратив одно действие.", true, "", "Замораживание", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6972) },
                    { 44, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6973), "Персонаж теряет равновесие и получает штраф -2 к атаке и защите. К началу следующего хода вашего персонажа эффект проходит и штраф отменяется.", true, "", "Ошеломление", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6973) },
                    { 45, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6974), "Персонаж пьян. Он получает штраф -2 к Реа, Лвк и Инт, а также -3 в Словесной дуэли. Есть шанс 25%, что персонаж будет плохо помнить, что делал в состоянии опьянения.", true, "", "Опьянение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6974) },
                    { 46, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6975), "Персонаж видит образы и вещи, которых на самом деле нет. Ведущий может свободно выбирать, какой ложный сенсорный эффект почувствует на себе ваш персонаж. Для того чтобы отличить одну иллюзию от реальности, требуется проверка Дедукции со СЛ 15.", true, "", "Галлюцинации", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6975) },
                    { 47, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6976), "Персонаж ощущает тяжесть в желудке и сосредоточенно пытается сдержать рвоту. Каждые 3 раунда персонаж обязан совершать бросок 1d10, результат которого должен быть ниже его Тел. В противном случае в течение одного раунда его будет рвать или он будет мучим рвотными позывами.", true, "", "Тошнота", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6976) },
                    { 48, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6980), "Персонажу нечем дышать, он задыхается. Каждый раунд персонаж получает З урона, не снижаемые бронёй. Способы избавиться от удушья разные, в зависимости от ситуации. Восстановление доступа к воздуху (персонаж выныривает, выворачивается из удушающего захвата и т.д.) прекращает этот эффект.", true, "", "Удушье", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6981) },
                    { 49, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6982), "Глаза персонажа закрыты или повреждены. Пока персонаж не потратит ход, чтобы восстановить зрение, он получает штраф -3 ко всем атакам и защите и штраф -5 к проверкам Внимания, связанным со зрением.", true, "", "Слепота", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6982) },
                    { 50, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6983), "Дистанция, на которую можно бросать предмет или стрелять из него", true, "", "Дистанция", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6983) },
                    { 51, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6984), "Бонус к броскам на попадание", true, "", "Точность+1", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6984) },
                    { 52, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6985), "Бонус к броскам на попадание", true, "", "Точность+2", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6985) },
                    { 53, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6986), "Бонус к броскам на попадание", true, "", "Точность+3", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6987) },
                    { 54, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6987), "Наносит Колющий урон", true, "", "Колющий", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6988) },
                    { 55, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7019), "Наносит Дробящий урон", true, "", "Дробящий", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7019) },
                    { 56, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7020), "Наносит Режущий урон", true, "", "Режущий", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7020) },
                    { 57, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7021), "Персонаж лежит без сознания или спит. Он считается сбитым с ног и не может двигаться и совершать какие-либо действия, кроме Отдыха. Условия прекращения этого состояния зависят от причины, которая его вызвала.", true, "", "Без сознания", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7022) },
                    { 58, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7022), "Нет штрафов при тусклом свете", true, "", "Ночное зрение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7023) },
                    { 59, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7024), "Нет штрафов при тусклом свете и при отсутствии освещения", true, "", "Улучшенное ночное зрение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7024) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "ImageFileName", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7057), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "", "Обезболивающие травы", 12, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7057), 0.10000000000000001 },
                    { 2, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7076), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "", "Капюшон вердэнского лучника", 100, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7076), 0.5 },
                    { 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7127), "", true, "", "Пепел", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7127), 0.10000000000000001 },
                    { 4, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7139), "", true, "", "Уголь", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7139), 0.10000000000000001 },
                    { 5, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7144), "", true, "", "Хлопок", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7145), 0.10000000000000001 },
                    { 6, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7148), "", true, "", "Двойное полотно", 22, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7148), 0.10000000000000001 },
                    { 7, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7151), "", true, "", "Стекло", 5, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7152), 0.5 },
                    { 8, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7154), "", true, "", "Укрепленное дерево", 16, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7154), 0.10000000000000001 },
                    { 9, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7156), "", true, "", "Полотно", 9, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7156), 0.10000000000000001 },
                    { 10, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7158), "", true, "", "Масло", 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7158), 0.10000000000000001 },
                    { 11, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7160), "", true, "", "Смлоа", 2, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7161), 0.10000000000000001 },
                    { 12, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7163), "", true, "", "Шелк", 50, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7163), 0.10000000000000001 },
                    { 13, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7165), "", true, "", "Нитки", 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7165), 0.10000000000000001 },
                    { 14, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7167), "", true, "", "Древесина", 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7167), 1.0 },
                    { 15, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7169), "", true, "", "Воск", 2, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7169), 0.10000000000000001 },
                    { 16, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7171), "", true, "", "Кости животных", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7172), 4.0 },
                    { 17, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7174), "", true, "", "Коровья шкура", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7174), 5.0 },
                    { 18, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7176), "", true, "", "Кожа драконида", 58, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7176), 5.0 },
                    { 19, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7178), "", true, "", "Чешуя драконида", 30, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7178), 5.0 },
                    { 20, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7180), "", true, "", "Перья", 4, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7180), 0.10000000000000001 },
                    { 21, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7182), "", true, "", "Укрепленная кожа", 48, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7182), 3.0 },
                    { 22, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7231), "", true, "", "Кожа", 28, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7231), 2.0 },
                    { 23, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7234), "", true, "", "Лирийская кожа", 60, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7235), 2.0 },
                    { 24, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7237), "", true, "", "Волчья шкура", 14, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7237), 3.0 },
                    { 25, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7239), "", true, "", "Чернящее масло", 24, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7239), 0.10000000000000001 },
                    { 26, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7240), "", true, "", "Масло из дрейка", 45, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7241), 0.10000000000000001 },
                    { 27, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7243), "", true, "", "Эфирная смазка", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7244), 0.10000000000000001 },
                    { 28, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7246), "", true, "", "Травильная кислота", 2, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7246), 0.10000000000000001 },
                    { 29, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7249), "", true, "", "Пятая эссенция", 82, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7249), 0.10000000000000001 },
                    { 30, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7252), "", true, "", "Огров воск", 10, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7253), 0.10000000000000001 },
                    { 31, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7254), "", true, "", "Точильный порошок", 32, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7255), 0.10000000000000001 },
                    { 32, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7257), "", true, "", "Дубильные травы", 3, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7258), 0.10000000000000001 },
                    { 33, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7260), "", true, "", "Темное железо", 52, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7260), 1.5 },
                    { 34, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7262), "", true, "", "Темная сталь", 82, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7262), 1.0 },
                    { 35, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7264), "", true, "", "Двимерит", 240, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7264), 1.0 },
                    { 36, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7266), "", true, "", "Самоцветы", 100, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7267), 0.10000000000000001 },
                    { 37, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7269), "", true, "", "Совершенный самоцвет", 1000, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7269), 0.10000000000000001 },
                    { 38, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7271), "", true, "", "Светящаяся руда", 80, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7271), 1.0 },
                    { 39, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7273), "", true, "", "Золото", 85, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7273), 1.0 },
                    { 40, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7275), "", true, "", "Железо", 30, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7276), 1.5 },
                    { 41, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7278), "", true, "", "Махакамский двимерит", 300, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7279), 1.0 },
                    { 42, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7281), "", true, "", "Махакамская сталь", 114, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7281), 1.0 },
                    { 43, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7283), "", true, "", "Метеорит", 98, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7283), 1.0 },
                    { 44, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7285), "", true, "", "Речная глина", 5, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7285), 1.5 },
                    { 45, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7289), "", true, "", "Серебро", 72, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7289), 1.0 },
                    { 46, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7291), "", true, "", "Сталь", 48, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7291), 1.0 },
                    { 47, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7293), "", true, "", "Камень", 4, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7294), 2.0 },
                    { 48, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7295), "", true, "", "Третогорская сталь", 64, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7296), 1.0 },
                    { 49, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7298), "", true, "", "Зерриканская смесь", 30, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7298), 0.10000000000000001 },
                    { 50, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7300), "", true, "", "Зеленая плесень", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7300), 0.10000000000000001 },
                    { 51, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7303), "", true, "", "Переступень", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7303), 0.10000000000000001 },
                    { 52, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7305), "", true, "", "Помет беса", 20, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7305), 1.0 },
                    { 53, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7308), "", true, "", "Омела", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7308), 0.10000000000000001 },
                    { 54, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7310), "", true, "", "Паутинник", 18, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7310), 0.10000000000000001 },
                    { 55, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7312), "", true, "", "Optima mater", 100, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7312), 0.10000000000000001 },
                    { 56, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7314), "", true, "", "Жимолость", 21, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7315), 0.10000000000000001 },
                    { 57, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7316), "", true, "", "Листья балиссы", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7317), 0.10000000000000001 },
                    { 58, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7361), "", true, "", "Сера", 14, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7361), 0.10000000000000001 },
                    { 59, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7364), "", true, "", "Собачья петрушка", 2, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7364), 0.10000000000000001 },
                    { 60, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7366), "", true, "", "Царская водка", 20, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7367), 0.10000000000000001 },
                    { 61, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7370), "", true, "", "Аконит", 9, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7370), 0.10000000000000001 },
                    { 62, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7373), "", true, "", "Корень лопуха", 32, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7374), 0.10000000000000001 },
                    { 63, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7376), "", true, "", "Корень мандрагоры", 65, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7376), 0.10000000000000001 },
                    { 64, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7378), "", true, "", "Фосфор", 20, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7379), 0.5 },
                    { 65, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7381), "", true, "", "Calcium equum", 12, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7381), 0.10000000000000001 },
                    { 66, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7383), "", true, "", "Вороний глаз", 17, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7384), 0.10000000000000001 },
                    { 67, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7386), "", true, "", "Грибы-шибальцы", 17, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7386), 0.10000000000000001 },
                    { 68, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7388), "", true, "", "Лепестки белого мирта", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7388), 0.10000000000000001 },
                    { 69, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7390), "", true, "", "Плод балиссы", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7390), 0.10000000000000001 },
                    { 70, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7392), "", true, "", "Ячмень", 9, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7393), 0.10000000000000001 },
                    { 71, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7394), "", true, "", "Винный камень", 88, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7395), 0.5 },
                    { 72, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7396), "", true, "", "Волокна хана", 17, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7397), 0.10000000000000001 },
                    { 73, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7398), "", true, "", "Ласточкина трава", 8, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7399), 0.10000000000000001 },
                    { 74, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7401), "", true, "", "Лунная крошка", 91, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7401), 0.10000000000000001 },
                    { 75, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7403), "", true, "", "Вербена", 18, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7403), 0.10000000000000001 },
                    { 76, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7405), "", true, "", "Листья волчьего алоэ", 39, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7405), 0.10000000000000001 },
                    { 77, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7407), "", true, "", "Краснолюдский бессмертник", 75, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7407), 0.10000000000000001 },
                    { 78, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7409), "", true, "", "Эмбрион эндриаги", 55, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7409), 1.5 },
                    { 79, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7411), "", true, "", "Жемчуг", 100, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7411), 0.10000000000000001 },
                    { 80, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7414), "", true, "", "Корень зарника", 18, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7414), 0.10000000000000001 },
                    { 81, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7416), "", true, "", "Лепестки гинации", 17, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7416), 0.10000000000000001 },
                    { 82, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7418), "", true, "", "Лепестки морозника", 19, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7418), 0.10000000000000001 },
                    { 83, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7420), "", true, "", "Плод берберки", 9, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7420), 0.10000000000000001 },
                    { 84, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7422), "", true, "", "Ртутный раствор", 77, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7423), 0.10000000000000001 },
                    { 85, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7425), "", true, "", "Склеродерм", 5, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7425), 0.10000000000000001 },
                    { 86, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7521), "", true, "", "Чертеж «Капюшон вердэнского лучника»", 150, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7521), 0.0 },
                    { 87, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7561), "", true, "", "Формула «Обезболивающие травы»", 0, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7562), 1.0 },
                    { 88, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7594), "Всегда с собой таскай верёвку. Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "", "Веревка (20 метров)", 20, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7595), 1.5 },
                    { 89, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7614), "Позволяют создавать алхимические составы", true, "", "Инструменты алхимика", 80, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7614), 3.0 },
                    { 90, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7630), "", true, "", "Стилет", 275, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7630), 0.5 },
                    { 91, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7597), "Валюта это", true, "", "Кроны", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7597), 0.01 },
                    { 92, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7427), "", true, "", "Лимфа чудовища", 152, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7427), 0.10000000000000001 },
                    { 93, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7429), "", true, "", "Слюна Альпа", 145, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7429), 0.10000000000000001 },
                    { 94, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7431), "", true, "", "Эссенция смерти", 155, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7431), 0.10000000000000001 },
                    { 95, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7433), "", true, "", "Зубы вампира", 150, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7433), 0.10000000000000001 },
                    { 96, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7598), "Обычные предметы по усмотрению мастера", true, "", "Обычные предметы", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7599), 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Mutagen",
                columns: new[] { "Id", "Complexity", "CreateDate", "Description", "Effect", "Enabled", "ImageFileName", "Mutation", "Name", "SourceId", "UpdateDate" },
                values: new object[] { 1, 20, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8053), "", "+1 Воля", true, "", "переплетение темно-красных вен под кожей", "Мутаген Альпа", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "IsPlayable", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7647), "Ведьмаки — тема деликатная с тех самых пор, как их создали много веков тому назад. Но, знаешь, даже когда они были нарасхват, их не особо-то любили. Ведьмаков выращивали из людских детей в пяти ведьмачьих школах. Там дети проходили какую-то лютую подготовку, после которой становились живым оружием. Быстрые до одури, могут сражаться вслепую и обучены охотиться считай на всех тварей, каких только можно встретить. Через парулет тренировок их подвергают мутациям — известней всего так называемое Испытание травами. Ведьмак, с которым мне довелось странствовать, рассказал, что переживает эту дрянь только один дитёнок из четырёх. Те, кто выжил, меняются. Глаза у них становятся кошачьими, а эмоции напрочь отмирают. Вроде как последнее со временем налаживается — например, тот самый знакомый мне ведьмак по дороге шутки-то малясь травил. Но с того самого момента, как ведьмаки мутируют, они становятся убийцами. Они перерождаются ради единственной цели — убивать чудовищ. И если доведётся тебе повидать ведьмака в деле, то поймёшь, что все те пройденные страдания были не зря. Одна только проблема: они мутанты, а люди мутантов ненавидят. С адаптацией в обществе у ведьмаков плохо, и для большинства они — хладнокровные бессердечные выродки, что честным людям кишки выпускают, предварительно ограбив да их дочек снасильничав", true, "", true, "Ведьмаки", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7647) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7649), "История эльфов (точнее Aen Seidhe, поскольку наши эльфы далеко не единственные) весьма грустная. Они прибыли сюда неизвестно откуда на огромных белых кораблях. Случилось это незадолго до появления людей. Я бы не назвал эльфов добряками, но с остальными они как-то уживались. От людей они не сильно отличаются: высокие, худые, любят на другие народы свысока смотреть. Разве что уши острые, жизнь вечная, да, считай, полное единение с природой — эльфы много поколений только и делали, что занимались собирательством и строили дворцы. Унихза время поеданияягод да кореньев и клыков-то не осталось. Правда, всё равно не советую их из себя выводить — на поле боя эльфы могут устроить тот ещё ад. Броню они толком не носят, но заприметить эльфа в лесу также тяжело, как зимой лягушку найти. А уж искуснее лучника чем эльф, днём с огнём не сыщешь.", true, "", true, "Эльфы (Aen Seidhe)", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7649) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7650), "Друже, вот что я тебе скажу: реки высохнут, горы рассыплются, а краснолюды никуда не денутся. Может, мы и низенькие в сравнении с эльфами и людьми, да только в силе и закалке им с нами не тягаться. Мы — само воплощение стойкости! Краснолюды уже не первый век существуют в этом мире. Жили себе спокойно в горах, ковали. Мы народ достаточно дружелюбный, если познакомиться с нами поближе. Да и уживаемся спокойно со всеми... если нас не бесить, конечно. Человечишки нас не особо любят, но мы им нужны — кто ж сталь им ковать будет и торговать? К тому же, в отличие от сраных эльфов, мы не держим на людей зла. Нас не трогают — и мы их не трогаем в ответ. Порой даже кружечку-другую готовы раздавить вместе с человеком. Жаль, конечно, что вся эта безумная расистская дрянь по Северу расползлась. Теперь и на краснолюдов травлю открыли. Повезло ещё, что люди наших девок нормально от мужиков отличить не могут, а то бы всех уже увели! Ведь нету бабы краше нраснолюдки. Правильно говорят: чем пышнее борода, тем приятнее... ну, ты понимаешь.", true, "", true, "Краснолюды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7651) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7652), "Ох, будь я покозлистее, то всю желчь излил бы тебе о том, как людишки насолили моему народу и остальным Старшим Народам. Но я не такой. С людьми я служил бок о бок на войне с Нильфгаардом; в той же темерской армии большинство — люди. Не все они говнюки — бывают и хорошие. По характеру люди-mo разные. Обычно они весьма стойкие ребята. Разве что частенько начинают то за «правое дело» воевать, то тыкать пальцами и бояться. Сейчас люди на Континенте — преобладающий вид, и они об этом прекрасно знают... чёрт, даже не надо стараться, чтобы о них гадости говорить. Люди почти уничтожили Старшие Народы, выкосили вранов, оставили в живых всего пару сотен боболаков, построили свои города на руинах Старших Народов и каждый день кого-то из Старших убивают. Но нет, они не все говнюки. Да, большинство магов — люди, и именно они погрузили мир в хаос, но они также сделали мир лучше с помощью науки и магии. Люди умные и, на самом деле, верные — если ты с человеком дружен, он тебя в беде не бросит.", true, "", true, "Люди", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7652) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7653), "Формально гуманоиды чудовищами не являются. Это люди, эльфы, краснолюды и прочие представители Старших Народов. Гуманоиды разнообразны в плане поведения и мест обитания. Важно помнить, что даже по стандартным правилам гуманоиды не имеют восприимчивости к серебру и сопротивления стали.", true, "", false, "Гуманоиды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7654) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7654), "Трупоеды едят трупы, и зачастую их можно встретить на кладбищах, полях боя и в глубоких пещерах. Их отталкивающая внешность обманчива — это вполне живые существа с иных планов. Менее разумные трупоеды, такие как гули, нападают на всё, что оказывается поблизости. Умные трупоеды, вроде кладбищенских баб, бродят по кладбищам и заманивают селян.", true, "", false, "Трупоеды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7655) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7656), "Духи представляют собой сильные желания усопших. Обычно они появляются тогда, когда кого-то убивают или когда кто-то перед смертью испытывает интенсивные эмоции. Многие духи разумны, но все они целиком захвачены каким-то одним чувством — обычно яростью, — что просто не позволяет вести с ними диалог.", true, "", false, "Духи", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7656) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7657), "Звери, как и гуманоиды, формально не относятся к чудовищам. В этой категории — собаки, волки и тому подобные существа. Они не имеют восприимчивости к серебру и сопротивления стали. Встретить их и вблизи поселений. Охотятся они преимущественно на селян и скот.", true, "", false, "Звери", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7657) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7658), "Проклятые — это люди и нелюди, на которых было наложено проклятие, превратившее их в чудовиш. Наиболее распространены волколаки. Поскольку это проклятые люди они обычно живут в человеческих поселениях. В большинстве своём такие существа открыто агрессивны по отношению к людям.", true, "", false, "Проклятые", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7658) },
                    { 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7659), "Этот класс объединяет множество разных химер вроде сирен и грифонов — соединение частей разных животных. Гибриды необычайно разнообразны и предпочитают различные среды обитания. Те, у кого есть способность к полёту, живут на возвышенностях, хотя в целом гибридов можно найти повсемест но, в самых разных зонах.", true, "", false, "Гибриды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7659) },
                    { 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7660), "Инсектоиды — это огромные насекомые и арахниды, которые бродят за пределами поселений, подстерегая неосторожных путников. Инсектоиды — хищники, обычно нападающие из засады и ранящие своих жертв ядовитыми жвалами или когтями. Если подобратьсслишком близко к гнезду инсектоидов, то вскоре вас может окружить целый рой этих существ.", true, "", false, "Инсектоиды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7660) },
                    { 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7661), "Духи стихий - восхитительные создания магии: големы, элементали, гаргульи и им подобные. Большинство таких существ призваны магами и жрецами. Они следуют приказам призвавшего, у них практически нет своей воли. Но если призвать их в этот мир, не связав узами, духистихий становятся ужасающей силой, способной уничтожать города.", true, "", false, "Духи стихий", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7662) },
                    { 13, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7663), "Реликты — силы природы, периодически проявляющиеся за пределами поселений. Скорее всего, эти чудовища прибыли в наш мир во время Сопряжения Сфер. Все они владеют магиейи тесно связаны с природой. По разумности реликты различаются: от умных и хитрых до примитивных и жестоких.", true, "", false, "Реликты", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7663) },
                    { 14, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7664), "Огры, включая троллей, накеров и великанов, — это гуманоидные создания, зачастую с почти человеческим интеллектом. Большинство из них велики и нескладны (за исключением накеров). Они не только способны создавать племенные сообщества, но и, в случае троллей, кое-как разговаривать на человеческом языке и Старшей Речи.", true, "", false, "Огры", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7664) },
                    { 15, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7665), "Среди драконидов есть такие существа, как виверны и драконы. Большинство драконидов — это крупные крылатые ящеры, крайне опасные (особенно в ближнем бою), но дикие. Истинные драконы по интеллекту близки к людям, а то и вовсе их превосходят и обладают куда большим количеством способностей. Логова драконидов расположены высоко в горах.", true, "", false, "Дракониды", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7665) },
                    { 16, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7666), "Вампиры — весьма разнообразная группа кровососущих чудовищ. Обычно они охотятся в руинах, хотя могущественные вампиры могут процветать и в городах. Низшие вампиры — это неразумные твари, раздирающие тела на части и затем выпивающие кровь. Высшие вампиры способны без проблем влиться в человеческое общество и обладают огромной силой.", true, "", false, "Вампиры", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7666) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 54, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6601), "Ведьмак может войти в медитативный транс, что позволяет ему получить все преимущества сна, но при этом сохранять бдительность. Во время медитации ведьмак считается находящимся в сознании для того, чтобы заметить что-либо в радиусе в метрах, равном удвоенному значению его Медитации.", true, "", true, false, "Медитация", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6601) },
                    { 55, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6603), "По мере того как ведьмак всё больше использует знаки, его тело постепенно привыкает к течению магической энергии. Каждые 2 очка, вложенные в способность Магический источник, повышают значение Энергии ведьмака на 1. Когда эта способность достигает 10 уровня, максимальное значение Энергии ведьмака становится равно 7. Эта способность развивается аналогично прочим навыкам.", true, "", true, false, "Магический источник", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6603) },
                    { 57, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6605), "За годы употребления ядовитых ведьмачьих эликсиров ведьмаки привыкают к токсинам. Ведьмак может выдержать отвары и эликсиры суммарной токсичностью на 5% больше за каждые 2 очка, вложенные в способность Крепкий желудок. Эта способность развивается аналогично прочим навыкам. На 10 уровне максимальная токсичность для ведьмака равна 150%.", true, "", true, false, "Крепкий желудок", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6606) },
                    { 58, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6607), "Будучи отравленным, ведьмак впадает в ярость и наносит дополнительно 1 урон в ближнем бою за каждый уровень Ярости. В этом состоянии единственная цель ведьмака — добраться до безопасного места или убить отравителя. Действие Ярости заканчивается одновременно с действием яда. Ведьмак может попытаться избавиться от Ярости раньше, совершив проверку Стойкости со СЛ 15.", true, "", true, false, "Ярость", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6607) },
                    { 74, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6678), "Укрепляя связь с божеством, жрец может повысить своё значение Энергии на 1 за каждый уровень Божественной силы. Таким образом, значение Энергии жреца на 10 уровне будет равно 12. Эта способность развивается аналогично прочим навыкам и суммируется с Еди нением с природой. Значение Энергии в этом случае общее.", true, "", true, false, "Божественная сила", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6678) },
                    { 77, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6684), "Укрепляя связь с природой, жрец может повысить своё значение Энергии на 1 за каждый уровень Единения с природой. Таким образом, значение Энергии жреца на 10 уровне будет равно 12. Эта способность развивается аналогично прочим навыкам и суммируется с Божественной силой. Значение Энергии в этом случае общее.", true, "", true, false, "Единение с природой", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6684) },
                    { 90, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6704), "По мере того как маг всё больше использует магию, его тело постепенно привыкает к течению магической энергии. Каждое очко, вложенное в способность Укрепление связи, повышает значение Энергии мага на 2. Когда эта способность достигает 10 уровня, максимальное значение Энергии мага равно 25. Эта способность развивается аналогично прочим навыкам.", true, "", true, false, "Укрепление связи", 1, null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6705) }
                });

            migrationBuilder.InsertData(
                table: "Spells",
                columns: new[] { "Id", "CheckDC", "ConcentrationEnduranceCost", "CreateDate", "CreatureId", "DangerInfo", "Description", "Distance", "Duration", "Enabled", "EnduranceCost", "ImageFileName", "IsConcentration", "IsDruidSpell", "IsPriestSpell", "Name", "PreparationTime", "SourceId", "SourceType", "SourceTypeDescription", "SpellLevel", "SpellType", "SpellTypeDescription", "UpdateDate", "WithdrawalCondition" },
                values: new object[,]
                {
                    { 1, 0, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8241), null, "", "Слепящая пыль позволяет направить в глаза цели горсть магической пыли, которая ослепит её на время действия заклинания.", 4, "1к10 раундов", true, 3, "", false, false, false, "Слепящая пыль", 0, 1, 1, "", 1, 1, "", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8241), "" },
                    { 2, 0, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8248), null, "", "Кипящая кровь заставляет животное или неразумное чудовище в пределах дистанции заклинания разозлиться на цель. Это существо будет пытаться напасть на цель, пока действие заклинания не закончится.", 8, "1к10 раундов", true, 3, "", false, false, true, "Кипящая кровь", 0, 1, 1, "", 1, 2, "", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8248), "" },
                    { 3, 0, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8251), null, "", "Квен создаёт щит с 5 ПЗ за каждое очко Вын, потраченное на защиту. Если вы не смогли (или не захотели) защититься от атаки или наносящего урон эффекта, урон сначала применяется к щиту Квен. Смертельный и несмертельный урон одинаковым образом уменьшают ПЗ щита Квен. Когда ПЗ щита снижаются до 0, оставшийся урон применяется к укрывшемуся за ним персонажу. Чтобы повлиять на ваши ПЗ или Вын, урон должен сначала преодолеть ПБ и сопротивление урону, как при любой атаке. Квен можно применять против любых заклинаний, которые поддаются блокированию, но против остальных заклинаний он бессилен. Также Квен не действует на уже имеющийся урон от отравления, болезней или удушения от нехватки кислорода в воздухе. Квен нельзя сотворить снова, пока действует предыдущий такой же знак.", 0, "10 раундов или пока не истрачен", true, 1, "", false, false, false, "Квен", 0, 1, 2, "", 1, 3, "", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8252), "" },
                    { 4, 15, 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8254), null, "", "Пиромантия позволяет заглянуть в пламя и увидеть происходящие события. Пиромантия несколько опаснее Гидромантии — её тяжелее поддерживать, к тому же огонь не позволяет смотреть в прошлое. Зато разглядеть события, происходящие в данный момент, куда проще. Как и в случае с Гидромантией, маг,за которым наблюдает заклинатель, может почувствовать слежку, совершив проверку Магических познаний со СЛ, равной результату проверки Проведения ритуалов", 0, "активный", true, 4, "", true, false, false, "Пиромантия", 0, 1, 1, "", 1, 4, "", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8255), "" },
                    { 5, 0, 0, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8257), null, "", "На гениталиях жертвы высыпают воспалённые зудящие прыщи. Вечный зуд не наносит урона, но причиняет жертве постоянный дискомфорт, что даёт штраф -1 к любым действиям. Также жертва получает штраф -5 к Соблазнению, когда доходит до раздевания.", 0, "", true, 5, "", false, false, false, "Вечный зуд", 0, 1, 1, "", 1, 5, "", new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8258), "Жертва должна взять единицу склеродерма, немного собачьей петрушки и переступня, затем развести костёр и связать травы в пучок. Как только всё будет готово, травы нужно поджечь и пеплом посыпать пострадавший от порчи участок тела, произнося при этом магические слова" }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6402), "", true, "", "Интеллект", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6402) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6404), "", true, "", "Реакция", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6405) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6406), "", true, "", "Ловкость", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6406) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6407), "", true, "", "Телосложение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6407) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6408), "", true, "", "Скорость", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6408) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6409), "", true, "", "Эмпатия", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6410) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6411), "", true, "", "Ремесло", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6411) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6412), "", true, "", "Воля", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6412) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6413), "", true, "", "Удача", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6413) },
                    { 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6414), "", true, "", "Энергия", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6414) },
                    { 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6415), "", true, "", "Устойчивость", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6415) },
                    { 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6416), "", true, "", "Бег", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6416) },
                    { 13, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6417), "", true, "", "Прыжок", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6417) },
                    { 14, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6419), "", true, "", "Пункты Здоровья", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6419) },
                    { 15, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6420), "", true, "", "Выносливость", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6420) },
                    { 16, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6421), "", true, "", "Переносимый вес", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6421) },
                    { 17, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6422), "", true, "", "Отдых", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6423) },
                    { 18, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6423), "", true, "", "Удар рукой", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6424) },
                    { 19, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6424), "", true, "", "Удар ногой", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6425) }
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "Name", "RaceId", "SourceId", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7679), "Благодаря обострённым чувствам ведьмаки не получают штрафов при слабом свете и получают врождённый бонус +1 к Вниманию, а также возможность выслеживания по запаху", true, "", "Обостренные чувства", 1, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7679) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7681), "После всех мутаций ведьмаки становятся невосприимчивы к болезням и способны использовать мутагены", true, "", "Стойкость мутанта", 1, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7681) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7683), "Из-за пережитых страданий и мутаций эмоции у ведьмаков притупляются. Ведьмакам не нужно совершать проверки Храбрости против Запугивания, но они получают штраф -4 к Эмпатии. При этом значение Эмпатии ведьмака не может быть ниже 1.", true, "", "Притупление эмоций", 1, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7683) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7685), "Благодаря интенсивным тренировкам и мутациям ведьмаки куда быстрее и проворнее обычных людей. Они получают постоянный бонус +1 к Реакции и Ловкости, позволяющий сделать эти значения больше 10.", true, "", "Молниеносная реакция", 1, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7685) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7686), "У эльфов есть врождённая творческая жилка и развитое чувство прекрасного. Эльфы получают врождённый бонус +1 к Искусству.", true, "", "Чувство прекрасного", 2, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7686) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7687), "Благодаря давним традициям и постоянным тренировкам эльфы — одни из лучших лучников в мире. Эльфы получают врождённый бонус +2 к Стрельбе из лука и способны выхватывать и натягивать лук, не тратя на это действие.", true, "", "Стрелок", 2, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7688) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7689), "Эльфы тесно связаны с природой. Они не тревожат животных — любой зверь, встреченный эльфом, будет относиться к нему дружелюбно и не нападёт без провокации. Эльфы также способны автоматически находить любые обычные и повсеместные субстанции растительного происхождения, если искомые растения обитают в природе на данной территории", true, "", "Единение с природой", 2, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7689) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7690), "У краснолюдов весьма крепкая кожа, имеющая врождённую прочность 2. Данная величина прибавляется к прочности любой брони и не может быть понижена разрушающим уроном.", true, "", "Закаленный", 3, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7691) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7692), "Благодаря невысокому росту и склонности к тяжелой работе, требующей физических усилий, краснолюды получают +1 к Силе и повышают свое значение Переносимого веса на 25.", true, "", "Силач", 3, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7692) },
                    { 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7693), "Краснолюды - прекрасные оценщики, обладающие вниманием к деталям, а потому обмануть их весьма трудно. Краснолюды получают врожденный бонус +1 к Торговле.", true, "", "Наметанный глаз", 3, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7694) },
                    { 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7695), "В мире, где нелюдям не доверяют, людям довериться куда проще. У людей есть врожденный бонус +1 к проверкам Харизмы, Соблазнения и Убеждения против других людей.", true, "", "Доверие", 4, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7695) },
                    { 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7696), "Люди умны и зачастую находят великолепные решения сложных проблем. Люди получают врожденный бонус +1 к Дедукции.", true, "", "Изобретательность", 4, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7696) },
                    { 13, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7698), "Одно из величайших преимуществ человеческой расы — нежелание отступать даже в опасной ситуации. Они могут собраться с духом и перебросить неудачный результат проверки Сопротивления убеждению или Храбрости, но не более 3 раз за игровую партию. В таком случае из двух результатов выбирают наивысший, но если результат всё равно провальный, то вновь использовать Упрямство нельзя.", true, "", "Упрямство", 4, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7698) },
                    { 14, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7728), "В качестве действия полного хода альп может издать направленный звук в 6-метровом конусе. Все в этом конусе должны совершить проверку изменения позиции со СЛ 16 или блокировать атаку щитом. Если цель не сумела защититься, она получает 5к6 урона в туловище, отлетает на 4 метра и ошеломлена. Если цель успешно блокировала атаку, она должна совершить проверку Силы со СЛ 16 и при провале все равно отлетает на 4 метра.", true, "", "Звуковая волна", 16, 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7729) },
                    { 15, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7730), "Слюна альпа является сильнодействующим снотворным средством. Ничего не подозревающее существо, вступившее в контакт с этой слюной, должно пройти проверку Стойкости СЛ 16, инчае погрузиться в глубокий сон, наполненный яркими кошмарами. Существо, знающее об этом эффекте или находящееся в бою, вместо этого снижает свою Выносливость на 5 и может пройти проверку Стойкости СЛ 18, чтобы проснуться каждый раз, когда он получает урон или кто-то тратит действие, чтобы разбудить его. Если методы не срабатывают, персонаж просыпается через 8 часов.", true, "", "Усыпляющая слюна", 16, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7730) },
                    { 16, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7731), "Если альп наносит урон укусом, цель получает дополнительно 2к6 урона, а альп восстанавливает себе столько же ПЗ. Если цель без сознания или спит, альп может использовать этуспособность без атаки Укусом", true, "", "Высасывание крови", 16, 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7732) },
                    { 17, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7733), "Перемещаясь, альм может превратить свое тело в туман и пройти расстрояние до 14 м. Применяя эту способность, альп может двигаться по горизонтали или по вертикали и проходить через самые маленькие щели и отверстия. Альп не может использовать эту способность в зоне действия бомбы Лунная пыль.", true, "", "Туманная форма", 16, 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7733) },
                    { 18, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7735), "Протратив действие, альп может замаскироваться под прекрасного эльфа или небольшое животное. Пока альп замаскирован под эльфа, только прошедший проверку Понимания людей СЛ 16 может заметить, что он кажется чуждым и отталкивающим. Замаскированный под животное альп может принимать форму Собаки или Кошки, используя соответствующий блок характеристик животного (см. Базовую книгу Ведьмака, стра 310), но сохраняя свои характеристики ИНТ, ЭМП, РЕМ и ВОЛЮ и любые сопутствующие навыки. Если альп получает урон или использует любую из своих способностей, кроме Усыпляющей слюны, его маскировка исчезает и он возвращается в свою естественную форму. ", true, "", "Превращение", 16, 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(7736) }
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
                    { 1, 3, 0, "50м", 50, false },
                    { 2, 3, 0, "", 21, false },
                    { 3, 3, 0, "", 51, false },
                    { 4, 4, 0, "", 17, false },
                    { 5, 4, 75, "", 2, false },
                    { 6, 5, 0, "", 3, false },
                    { 7, 5, 0, "", 14, false }
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
                    { 85, "2к6", 10, true, 0, 9, "Леса и Пещеры" },
                    { 92, "С чудовища", 20, true, 0, 3, "Существа (бруксы, гаркаины, высшие вампиры)" },
                    { 93, "С чудовища", 20, true, 0, 2, "Существа (Альпы)" },
                    { 94, "С чудовища", 20, true, 0, 8, "Существа (вендиго, бруксы, альпы)" },
                    { 95, "С чудовища", 20, true, 0, 1, "Существа (катаканы, альпы)" }
                });

            migrationBuilder.InsertData(
                table: "Creatures",
                columns: new[] { "Id", "AdditionalInformation", "Armor", "AthleticsBase", "BlockBase", "Complexity", "CreateDate", "Description", "EducationSkill", "Enabled", "EvasionBase", "GroupSize", "HabitatPlace", "Height", "ImageFileName", "Intellect", "MoneyReward", "MonsterLoreInformation", "MonsterLoreSkill", "MutagenId", "Name", "RaceId", "Regeneration", "SkillsListId", "SourceId", "SpellResistBase", "StatsListId", "SuperstitionsInformation", "TrophyId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, "", 5, 9, 12, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8079), "", 8, true, 10, "Банда из 3-15 разбойников", "Часто рядом с городами и на трактах", 180, "", "Человеческий", 10, "Разбойники — одна из самых распространённых угроз на дороге, но отнюдь не самая опасная. Куда тяжелее скинуть с себя гуля, чем расправиться с парочкой разбойников. Но порой они могут представлять настоящую угрозу, особенно когда их много. Большая часть разбойников — это солдаты без армии, наёмники без контракта или дезертиры, которые покинули одну из воюющих сторон. Разбойники просты. Первые ряды побегут с полуторными мечами наголо. Те, кто на такое не способен, воспользуются арбалетами. Разбойникам обычно нужны три вещи: безопасность, деньги и что-нибудь, на чём можно выместить свой гнев. С ними не то чтобы просто расправиться, но, в отличие от большинства чудовищ, можно воззвать к их разуму. Возможно, вы сумеете убедить их не убивать вас. Разбойники, скорее всего, сдадутся, если вы нанесёте им достаточно урона. Однако некоторые разбойники, странствующие крепко сбитыми группами, могут начать сражаться яростнее, если убить их товарищей. На истерзанном войной Севере стоит быть осторожнее: нехватка пищи заставила некоторых разбойников стать каннибалами. Каннибалы зачастую сходят с ума и нападают с бешеной яростью — они не сдаются, даже стоя одной ногой в могиле. Если не хотите драться, будьте внимательны на дороге.", 10, null, "Разбойник", 4, 0, 1, 1, 8, 1, "Хе, разбойники, дезертиры, ренегаты, сукины дети... Называй их как хочешь. Люди ступают на преступный путь ради денег и власти, но в большинстве своём они делают это от страха и голода. Все знают, что уровень преступности растёт во время войны. Так было в прошлых двух войнах, и вот сейчас опять. Но это не значит, что простой народ с этим согласен. Хех, не говорите это в лицо убийце, но среднестатистический ублюдок о бандите того же мнения, что и о гуле. И те, и другие прячутся по грязным закоулкам мира, ждут момента, чтобы напасть, и устраивают засаду на добрых трудяг, чтобы отобрать заработанное кровью и потом.", null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8079), 80f },
                    { 2, "", 10, 23, 22, 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8090), "", 15, true, 22, "Одиночка", "Заброшенные строения, подвалы или пещеры рядом с людскими поселениями", 175, "", "Разумный", 2000, "Альпы – это вампиры внешне напоминающие брукс. Некоторые называют их фантомами и не попросту, ибо как фантомы они преследуют и мучают люд под женским обликом, хотя также могут прикинуться и животным. Альпы чаще всего встречаются рядом с деревнями, нападая по ночам и наиболее активны в полнолуние. Слюна альпа – мощный анестетик и, будучи скормленной спящему, вызовет у того жуткие кошмары. Некоторые предполагают, что именно альпы стали причиной слухов о людях, найденных на утро белее первого снега, без капли крови в венах. В бою альпы демонстрируют сверхъестественную скорость и необычайную (даже по вампирским меркам) выносливость. Решившийся сразиться с альпом должен тщательно вымерять свои удары, ибо альпам нет равных в изворотливости. Рекомендуется использовать знак Ирден, чтобы замедлить Альпа и ослабить его защиту. Хорошим решением будет выпить эликсир Чёрная Кровь, так как альпы высасывают кровь из своих жертв, чтобы лишить их сил и восполнить собственные. Так же может пригодиться Иволга, которая предоставит защиту от усыпляющей слюны альпа. В отличие от брукс, альпы не могут становиться невидимыми, но уподобляясь своим ещё более жутким сородичам, они могут испускать звуковую волну, обезвреживающую жертву. Их сильная сторона — это их ловкость и прыжки, кои они совершают с невероятной лёгкостью, и их можно сравнить с полетом. Будучи в человеческой форме, они легко замешиваются в местную общину. А там, где человек будет выглядеть слишком подозрительно, они прикидываются зверьём.", 16, 1, "Альп", 16, 0, 2, 1, 17, 2, "Мало какой монстр вдохновляет так много историй, как альп. Эта суккубо-дьяволица может превратиться в чёрную псину или ядовитую жабу. Говорят, что эти распутные бестии любят соблазнять красивых молодых парне. Так же говорят, что их способности очаровывать могут сравниться только с их ненавистью к девственницам. Они двигаются без единого звука и даже ветер не может их коснуться, как и солнечный свет, который сжигает их кожу, даже не успев до неё дотронуться. Однако они до жути боятся кошаков.", null, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8090), 90f }
                });

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
                    { 91, 0, 0, 0 },
                    { 96, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reward",
                columns: new[] { "Id", "Amount", "ItemBaseId" },
                values: new object[,]
                {
                    { 1, "3к10", 90 },
                    { 2, "1к6/3", 92 },
                    { 3, "1к6", 93 },
                    { 4, "2к6", 94 },
                    { 5, "1к6/2", 95 },
                    { 6, "1к6", 96 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "ImageFileName", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6520), "", true, "", false, false, "Внимание", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6520) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6525), "", true, "", false, false, "Выживание в дикой природе", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6525) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6526), "", true, "", false, false, "Дедукция", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6527) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6528), "", true, "", false, true, "Монстрология", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6528) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6529), "", true, "", false, false, "Образование", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6529) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6531), "", true, "", false, false, "Ориентирование в городе", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6531) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6532), "", true, "", false, false, "Передача знаний", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6532) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6534), "", true, "", false, true, "Тактика", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6534) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6535), "", true, "", false, false, "Торговля", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6535) },
                    { 10, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6536), "", true, "", false, false, "Этикет", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6537) },
                    { 11, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6538), "", true, "", false, true, "Язык всеобщий", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6538) },
                    { 12, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6539), "", true, "", false, true, "Язык Старшей Речи", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6540) },
                    { 13, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6541), "", true, "", false, true, "Язык краснолюдов", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6542) },
                    { 14, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6543), "", true, "", false, false, "Ближний бой", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6543) },
                    { 15, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6544), "", true, "", false, false, "Борьба", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6545) },
                    { 16, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6546), "", true, "", false, false, "Верховая езда", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6546) },
                    { 17, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6547), "", true, "", false, false, "Владение древковым оружием", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6547) },
                    { 18, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6549), "", true, "", false, false, "Владение легкими клинками", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6549) },
                    { 19, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6550), "", true, "", false, false, "Владение мечом", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6550) },
                    { 20, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6551), "", true, "", false, false, "Мореходство", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6552) },
                    { 21, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6553), "", true, "", false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6553) },
                    { 22, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6554), "", true, "", false, false, "Атлетика", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6554) },
                    { 23, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6556), "", true, "", false, false, "Ловкость рук", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6556) },
                    { 24, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6557), "", true, "", false, false, "Скрытность", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6557) },
                    { 25, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6558), "", true, "", false, false, "Стрельба из арбалета", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6559) },
                    { 26, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6560), "", true, "", false, false, "Стрельба из лука", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6560) },
                    { 27, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6561), "", true, "", false, false, "Сила", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6561) },
                    { 28, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6563), "", true, "", false, false, "Стойкость", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6563) },
                    { 29, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6565), "", true, "", false, false, "Азартные игры", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6565) },
                    { 30, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6566), "", true, "", false, false, "Внешний вид", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6566) },
                    { 31, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6568), "", true, "", false, false, "Выступление", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6568) },
                    { 32, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6569), "", true, "", false, false, "Искусство", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6569) },
                    { 33, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6570), "", true, "", false, false, "Лидерство", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6571) },
                    { 34, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6572), "", true, "", false, false, "Обман", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6572) },
                    { 35, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6573), "", true, "", false, false, "Понимание людей", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6573) },
                    { 36, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6575), "", true, "", false, false, "Соблазнение", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6575) },
                    { 37, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6576), "", true, "", false, false, "Убеждение", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6576) },
                    { 38, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6577), "", true, "", false, false, "Харизма", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6578) },
                    { 39, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6579), "", true, "", false, true, "Алхимия", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6579) },
                    { 40, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6580), "", true, "", false, false, "Взлом замков", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6580) },
                    { 41, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6582), "", true, "", false, true, "Знание ловушек", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6582) },
                    { 42, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6583), "", true, "", false, true, "Изготовление", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6583) },
                    { 43, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6584), "", true, "", false, false, "Маскировка", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6585) },
                    { 44, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6587), "", true, "", false, false, "Первая помощь", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6587) },
                    { 45, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6588), "", true, "", false, false, "Подделывание", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6589) },
                    { 46, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6590), "", true, "", false, false, "Запугивание", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6590) },
                    { 47, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6591), "", true, "", false, true, "Наведение порчи", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6591) },
                    { 48, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6593), "", true, "", false, true, "Проведение ритуалов", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6593) },
                    { 49, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6594), "", true, "", false, true, "Сопротивление магии", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6594) },
                    { 50, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6595), "", true, "", false, false, "Сопротивление убеждению", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6596) },
                    { 51, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6597), "", true, "", false, true, "Сотворение заклинаний", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6597) },
                    { 52, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6598), "", true, "", false, false, "Храбрость", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6598) },
                    { 53, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6600), "Большинство ведьмаков проводят детство и юность в крепости, корпя над пыльными томами и проходя чудовищные боевые тренировки. Многие говорят, что главное оружие ведьмака — это знания о чудовищах и умение найти выход из любой ситуации. Находясь в опасной среде или на пересечённой местности, ведьмак может снизить соответствующие штрафы на половину значения своего навыка Подготовка ведьмака (минимум 1). Подготовку ведьмака также можно использовать в любой ситуации, где понадобился бы навык Монстрология.", true, "", true, false, "Подготовка ведьмака", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6600) },
                    { 56, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6604), "Когда ведьмак становится целью заклинания, инвокации или порчи, он может совершить проверку способности Гелиотроп, чтобы попытаться отменить эффект. Он должен выкинуть результат, который больше либо равен результату его противника, а также потратить количество Выносливости, равное половине Выносливости, затраченной на сотворение магии.", true, "", true, false, "Гелиотроп", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6604) },
                    { 59, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6608), "Принимая отвар, ведьмак может совершить проверку Трансмутации со СЛ 18. При успехе тело ведьмака принимает в себя несколько больше мутагена, чем обычно, что позволяет получить бонус в зависимости от принятого отвара (см. таблицу на полях). Длительность действия отвара уменьшается вдвое. Дополнительные мутации слишком малы, чтобы их заметить.", true, "", true, false, "Трансмутация", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6608) },
                    { 60, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6610), "Ведьмак может совершить проверку этой способности со штрафом -3, чтобы отбить летящий физический снаряд. При отбивании ведьмак может выбрать цель в пределах 10 м. Эта цель должна совершить действие защиты против броска Отбивания стрел ведьмака, или она будет ошеломлена из-за попадания отбитого снаряда.", true, "", true, false, "Отбивание стрел", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6610) },
                    { 61, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6612), "Закончив свой ход, ведьмак может потратить 5 очков Вын и совершить проверку Быстрого удара со СЛ, равной Реа противника хЗ. При успехе ведьмак совершает ещё одну атаку в этот раунд против этого противника, которая может включать в себя разоружение, подсечку и прочие атаки.", true, "", true, false, "Быстрый удар", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6612) },
                    { 62, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6613), "Потратив 5 очков Вын за раунд, ведьмак может закрутиться в Вихре, совершая каждый ход по одной атаке против всех, кто находится в пределах дистанции его меча. Проверка Вихрясчитается проверкой атаки. Находясь в Вихре, ведьмак может только поддерживать его, уклоняться и передвигаться на 2 метра за раунд. Любое другое действие или полученный удар прекращают Вихрь.", true, "", true, false, "Вихрь", 1, 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6614) },
                    { 63, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6615), "Настоящие воины — будь то темерские «Синие полоски» или нильфгаардцы из бригады «Импера» — никогда не сдаются. Когда ПЗ воина опускается до 0 или ниже, он может совершить проверку навыка Крепче стали со СЛ, равной количеству отрицательных ПЗ х 2, чтобы продолжить сражаться. При провале воин оказывается при смерти. При успехе он может продолжать сражение, как если бы его ПЗ были ниже порога ранения. Получив урон, он вновь должен совершить проверку со СЛ, зависящей от его ПЗ.", true, "", true, false, "Крепче стали", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6615) },
                    { 64, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6616), "Совершая дистанционную атаку, которая получила бы штраф за дистанцию, воин может уменьшить штраф на половину Максимальной дистанции. Он также может совершить проверку способности Максимальная дистанция со СЛ 16, чтобы атаковать цель на расстоянии до 3 дистанций своего оружия со штрафом -10. Этот штраф можно уменьшить, применив данную способность.", true, "", true, false, "Максимальная дистанция", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6617) },
                    { 65, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6618), "Совершая дистанционную атаку из лука или метательным оружием, воин может совершить проверку способности Двойной выстрел вместо соответствующего оружию навыка. При попадании воин выпускает в цель два снаряда, повреждая две случайные части тела. Даже если атака была прицельной, второй снаряд попадёт в случайную часть тела.", true, "", true, false, "Двойной выстрел", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6618) },
                    { 66, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6619), "Если воин совершает критическую атаку дистанционным оружием, он может немедленно совершить проверку Точного прицела со СЛ, равной Лвк х 3 цели. При успехе воин добавляет значение способности Точный прицел к критическому броску. Эти очки влияют только на определение положения критического ранения.", true, "", true, false, "Точный прицел", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6619) },
                    { 67, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6621), "При выслеживании цели воин добавляет значение Ищейки к проверкам Выживания в дикой природе, чтобы найти след или пройти по нему. Если воин теряет след во время выслеживания с помощью этой способности, он может совершить проверку Ищейки со СЛ, определяемой ведущим, чтобы немедленно вновь найти след.", true, "", true, false, "Ищейка", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6621) },
                    { 68, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6622), "Воин может совершить проверку способности Ловушка воина, чтобы установить самодельную ловушку в определённой зоне. Вид ловушки определите по таблице «Ловушки воина». Воин может создать ловушку только одного вида за раз. У каждой ловушки есть растяжка радиу сом 2 метра, для её обнаружения требуется совершить проверку Внимания со СЛ, равной проверке Ловушки воина", true, "", true, false, "Ловушка воина", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6622) },
                    { 69, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6624), "Вместо перемещения воин может совершить проверку Тактического преимущества, чтобы оценить группу противников. Воин получает бонус +3 к атаке и защите на один раунд против всех врагов в пределах 10 метров, чья Лвк х З меньше, чем результат проверки. Также эта способность позволяет понять, что собирается делать каждый из врагов, на которых она действует.", true, "", true, false, "Тактическое преимущество", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6624) },
                    { 70, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6625), "Воин может совершить проверку Неистовства со СЛ, равной его Эмп х З. При успехе воин становится невосприимчив к ужасу, влияющим на эмоции заклинаниям и Словесной дуэли на количество раундов, равное удвоенному значению Неистовства. В это время ярость застилает разум воина и он полностью отдается во власть инстинктов", true, "", true, false, "Неистовство", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6625) },
                    { 71, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6627), "Потратив 10 очков Вын и совершив проверку способности Двуручник со штрафом -3 против защиты противника, воин может совершить одну атаку, которая наносит двойной урон и считается пробивающей броню. Если его оружие уже пробивающее броню, оно становится улучшенным пробивающим броню. Улучшенное пробивающее броню оружие с этой способностью наносит 3d6 дополнительного урона.", true, "", true, false, "Двуручник", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6627) },
                    { 72, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6628), "Количество раз за игровую партию, равное Тел воина, он может потратить 10 очков Вын, чтобы немедленно совершить проверку способности Игнорировать удар, когда противник наносит ему критическое ранение. Если результат проверки выше проверки атаки противника, воин отменяет критическое ранение, как если бы атака противника не была критической.", true, "", true, false, "Игнорировать удар", 1, 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6628) },
                    { 73, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6630), "В большинстве церквей мира рады посетителям. Служители храмов помогают местным жителям и с радостью принимают новообращённых в свою веру. Жрец может совершить проверку навыка Посвящённый (СЛ определяет ведущий) в храме своей религии, чтобы получить бесплатный кров, исцеление и прочие услуги на усмотрение ведущего. Навык Посвящённый также можно использовать при общении с единоверцами, но получите вы куда меньше, чем в церкви. Посвящённый не действует при общении с теми, кто исповедует другую веру", true, "", true, false, "Посвященный", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6630) },
                    { 75, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6680), "Для крестьян и простого люда жрецы — проводники воли богов. Жрец может добавить значение Божественного авторитета к своим проверкам Лидерства, если он находится в области, где исповедуют ту же религию. Если жрец находится за пределами такой области, то он добавляет половину значения способности.", true, "", true, false, "Божественный авторитет", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6681) },
                    { 76, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6682), "По решению ведущего жрец может получить видение будущего, на 3 раунда впав в состояние кататонии. После этого жрец может совершить проверку Предвидения со СЛ, определяемой ведущим, чтобы расшифровать полученные видения, которые представляют собой смесь символов и метафор.", true, "", true, false, "Предвидение", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6682) },
                    { 78, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6685), "Находясь среди природы, друид может совершить проверку способности Знаки природы со СЛ, определяемой ведущим. При успехе друид по знакам узнаёт, кто в этом месте был и что делал. Эта проверка даёт только локальную информацию и не позволяет выслеживать.", true, "", true, false, "Знаки природы", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6685) },
                    { 79, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6686), "Друид добавляет способность Союзник природы к любым проверкам Выживания в дикой природе для обращения с животными. Друид также может сдружиться с животным, потратив полный раунд и совершив проверку Союзника природы. Зверь или иное животное становится союзником друида наколичество часов, равное значению способности Союзник природы. Данная способность не действует на чудовищ.", true, "", true, false, "Союзник природы", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6687) },
                    { 80, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6688), "Проводя ритуал, жрец может совершить проверку способности Кровавые ритуалы со СЛ, равной СЛ ритуала. При успехе жрец проводит ритуал без необходимых алхимических субстанций, жертвуя при этом 5 ПЗ в виде крови за каждую недостающую субстанцию. Это может быть и чужая кровь, но только пролитая во время данного ритуала", true, "", true, false, "Кровавые ритуалы", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6688) },
                    { 81, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6690), "Жрец может совершить проверку Рвения против текущего значения ИнтхЗ цели. При успехе слова жреца ободряют цель, что даёт ей ld6 временных ПЗ за каждый пункт сверх СЛ (максимум 5). Этот эффект длится коли чество раундов, равное значению Рвениях2, и на одну цель его можно использовать только раз в день.", true, "", true, false, "Рвение", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6690) },
                    { 82, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6692), "Жрец может совершить проверку способности Слово божье, чтобы убедить слушателей, что его устами говорит божество. Любой, кто провалит проверку Сопротивления убеждению, будет считать жреца мессией и следовать за ним. Количество последователей жреца равно значению его Слова божьего. Если у последователей нет блоков параметров, используйте для них параметры разбойников.", true, "", true, false, "Слово божье", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6692) },
                    { 83, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6693), "Для того чтобы стать полноправным магом, способный к магии адепт должен пройти обучение в одной из магических академий. Маг может совершить проверку Магических познаний, если ему попадётся магический феномен, если он увидит незнакомое заклинание или захочет узнать ответ на какой-то теоретический вопрос. СЛ проверки определяется ведущим. При успехе маг узнаёт всё, что касается данного магического феномена. Проверка Магических познаний также может заменить проверку Внимания для обнаружения использованной магии и духов.", true, "", true, false, "Магические познания", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6693) },
                    { 84, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6695), "Маг может совершить проверку способности Строить козни со СЛ, равной Инт х З цели. При успехе маг получает бонус +3 к Обману, Соблазнению, Запугиванию или Убеждению против этой цели благодаря знаниям о её сильных и слабых сторонах. Бонус действует количество дней, равное значению способности Строить козни.", true, "", true, false, "Строить козни", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6695) },
                    { 85, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6696), "Потратив час времени, маг может совершить проверку Сплетен против ЭмпхЗ цели. При успехе маг успешно распускает слухи о цели по всему поселению, что снижает репутацию цели на половину значения Сплетен мага на количество дней, равное значению этой способности.", true, "", true, false, "Сплетни", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6696) },
                    { 86, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6698), "Один раз за игру маг может совершить проверку Полезных связей, чтобы вспомнить о комто, кто мог бы быть полезен. Результат проверки необходимо распределить между четырьмя категориями, указанными в таблице на полях, чтобы понять, кто этот знакомый. То, как агент будет помогать магу, зависит от их отношений.", true, "", true, false, "Полезные связи", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6698) },
                    { 87, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6699), "Потратив час на изучение алхимического состава, маг может совершить проверку Анализа со СЛ, равной СЛ Изготовления этого алхимического состава + 3. При успехе маг выводити записывает формулу этого состава. СЛ создания предмета по воссозданной формуле на 3 пункта выше, но в итоге маг получает желаемый предмет.", true, "", true, false, "Анализ", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6699) },
                    { 88, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6701), "Маг может совершить проверку Дистилляции вместо Алхимии при изготовлении алхимического состава. При успехе маг создаёт порцию состава, действующую в полтора раза эффективнее обычной порции — это относится к длительности, урону или СЛ сопротивления на выбор мага. Округление эффекта всегда идет вниз.", true, "", true, false, "Дистилляция", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6701) },
                    { 89, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6702), "Маг может потратить полный день и всю свою Выносливость на проведение экспериментов над целью, чтобы совершить бросок Мутации со СЛ, равной (28 -(Тел+ Воля цели)/ 2), и мутацией изменить цель. При успехе цель получает возможность использовать мутаген с подходящей малой мутацией. При провале цель оказывается при смерти и получает крупную мутацию.", true, "", true, false, "Мутация", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6702) },
                    { 91, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6706), "Маг может совершить проверку Устойчивости к двимериту со СЛ 16 в любой момент, когда на него обычно может воздействовать двимерит. При успехе маг способен противостоять эффекту двимерита: у него кружится голова и он испытывает дискомфорт, но сохраняет половину Энергии и способность сотворять заклинания.", true, "", true, false, "Устойчивость к двимериту", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6706) },
                    { 92, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6707), "Маг может обрести огромное могущество, проводя магическую энергию через разные фокусирующие магические предметы. Маг может совершить проверкуУсиления магии со СЛ 16 перед сотворением заклинания или проведением ритуала. При успехе маг может провести магическую энергию через любые 2 фокусирующих предмета по своему выбору, снижая затраты Выносливости вдвое.", true, "", true, false, "Усиление магии", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6707) },
                    { 93, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6709), "Кто угодно может перевязать рану, но только у медика достаточно знаний, чтобы проводить сложные хирургические операции. Медик с навыком Лечащее прикосновение — единственный, кто способен вылечить критическое ранение. Для исцеления критического ранения медик должен успешно совершить несколько проверок Лечащего прикосновения — число их зависит от серьёзности критического ранения. СЛ проверки также зависит от серьёзности критического ранения. Помимо этого, Лечащее прикосновение можно использовать вместо проверки Первой помощи.", true, "", true, false, "Лечащее прикосновение", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6709) },
                    { 94, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6710), "При возможности осмотреть раненое существо медик может совершить проверку Диагноза со СЛ, определяемой ведущим. При успехе он обнаруживает все критические ранения цели и узнаёт, сколько пунктов здоровья у неё осталось. Это также даёт бонус +2 ко всем проверкам Лечащего прикосновения для лечения этих ран.", true, "", true, false, "Диагноз", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6710) },
                    { 95, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6711), "Перед проверкой Лечащего прикосновения медик может потратить ход и совершить проверку Осмотра со СЛ, зависящей от серьёзности критического ранения. При успехе медик понимает природу ранения и за каждые 2 пункта проверки свыше СЛ (минимум 1) хирургическая операция займёт на 1 ход меньше.", true, "", true, false, "Осмотр", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6712) },
                    { 96, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6713), "Перед тем как начать лечить критическое ранение, медик может совершить проверку Эффективной хирургии со СЛ, равной СЛ проверки Лечащего прикосновения, необходимой для лечения данного ранения. При успехе медик зашивает раны столь искусно, что они исцеляются в два раза быстрее. Эту способность можно использовать при лечении как критических ранений,так и обычных.", true, "", true, false, "Эффективная хирургия", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6713) },
                    { 97, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6714), "Палатка лекаря позволяет совершить проверку со СЛ, определяемой ведущим, чтобы создать укрытие с оптимальными условиями для лечения. Это требует 1 часа, но добавляет бонус +3 к совершённым внутри проверкам Лечащего прикосновения/Первой помощи и +2 к скорости исцеления любого, кто находится в палатке, на количество дней, равное значению Палатки лекаря.", true, "", true, false, "Палатка лекаря", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6715) },
                    { 98, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6716), "Медик может совершить проверку Подручных средств со СЛ, равной СЛ Изготовления определённого лечащего алхимического состава, чтобы заменить его чем-то, что у него есть в наличии. Проверка занимает 1 раунд, и её можно повторить при провале. Подручные средства весьма специфичны и действуют только на конкретную рану.", true, "", true, false, "Подручные средства", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6716) },
                    { 99, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6717), "Смешав алхимические субстанции, медик может создать растительное лекарство, которое даёт бонусы/эффекты в зависимости от состава (см. таблицу Растительные лекарства). Каждое лекарство хранится максимум 3 дня, после истечения этого срока его нельзя использовать. Чтобы получить бонус, лекарство следует сжечь или разжевать; его хватает только на одно применение. Создание лекарства занимает 1 ход", true, "", true, false, "Растительное лекарство", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6718) },
                    { 100, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6719), "Нанося урон клинковым оружием, медик может совершить проверку способности Кровавая рана со СЛ 15. При успехе после этой атаки цель начинает истекать кровью со скоростью 1 урон за каждые 2 пункта свыше установленной СЛ за раунд. Кровотечение можно остановить только проверкой Первой помощи со СЛ, равной результату проверки Кровавой раны.", true, "", true, false, "Кровавая рана", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6719) },
                    { 101, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6720), "Медикможет совершить проверку способности Практическая резня со СЛ, равной Тел х 3 противника, чтобы обычные и критические ранения противника исцелялись в два раза медленнее. Другие медики могут нейтрализовать этот эффект при помощи Эффективной хирургии и предметов, повышающих скорость исцеления обычных и критических ран.", true, "", true, false, "Практическая резня", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6721) },
                    { 102, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6722), "Медик может совершить проверку способности Калечащая рана против защиты цели. Эта атака даёт штраф -6 к попаданию, но при успехе снижает Реакцию, Телосложение или Скорость цели на 1 пункт за каждые 3 пункта свыше броска защиты. Штраф можно снять, только со 2вершив проверку Эффективной хирургии с результатом выше результата атаки медика.", true, "", true, false, "Калечащая рана", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6722) },
                    { 103, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6723), "Все преступники, будь то убийцы, воры, фальшивомонетчики или контрабандисты, обладают обострённым чутьём на опасность — фактически профессиональной паранойей, благодаря которой они избегают поимки. Когда преступник оказывается в пределах 10 метров от ловушки (включая экспериментальные ловушки, ловушки воина и засады), он может немедленно совершить проверку Профессиональной паранойи либо против СЛ обнаружения ловушки, либо против Скрытности засады, либо против заданной ведущим СЛ. Даже если преступник не заметит ловушки, чутьё всё равно ему подскажет, что тут что-то не так.", true, "", true, false, "Профессиональная паранойя", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6724) },
                    { 104, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6726), "Преступник может потратить час, чтобы побродить по улицам поселения и совершить проверку способности Присмотреться со СЛ, указанной в таблице на полях. При успехе преступник запоминает маршруты патрулей, расположение улиц и укрытий, что даёт ему бонус +2 к Скрытности в этом районе на количество дней, равное значению Присмотреться", true, "", true, false, "Присмотреться", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6726) },
                    { 105, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6727), "Когда преступник успешно вскрывает замок, он может совершить проверку Повторного взлома со СЛ, равной СЛ Взлома замков (для данного замка), чтобы запомнить положение штифтов. Это позволит ему открыть тот же замок без проверки навыка Взлом замков. Преступник может запомнить столько замков, сколько у него очков Инт. Всегда можно запомнить новый замок, забыв старый.", true, "", true, false, "Повторный взлом", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6727) },
                    { 106, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6728), "Один раз за игровую партию преступник может совершить проверку способности Залечь на дно, чтобы найти тайное убежище, где он может спрятаться на какое-то время. Результат проверки Залечь на дно распределите между тремя категориями по соответствующей таблице на полях. Тайное убежище существует, пока его не уничтожат, и преступник всегда nможет в него вернуться.", true, "", true, false, "Залечь на дно", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6729) },
                    { 107, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6730), "Преступник может совершить встречную проверку Уязвимости против навыка Обман разумной цели, чтобы определить самую дорогую для цели вещь или личность. Это также даёт преступнику бонус +1 к Запугиванию за каждые 2 пункта свыше Обмана цели. Этот бонус действует до тех пор, покауязвимость цели не изменится.", true, "", true, false, "Уязвимость", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6730) },
                    { 108, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6731), "Преступник может совершить проверку способности Взять на заметку со СЛ, равной Эмп х З цели, чтобы оставить метку на её двери или что-то подобное. При успехе цель должна проходить проверку Харизмы, Убеждения или Запугивания, результат которой должен быть выше проверки Взять на заметку преступника, чтобы получить помощь или услугу у кого-либо в своём поселении.", true, "", true, false, "Взять на заметку", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6732) },
                    { 109, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6733), "Один раз в день, потратив час, преступник может совершить проверку Сбора с установленной ведущим СЛ. За каждые 2 пункта выше установленной СЛ преступник может завербовать 1 разбойника на количество дней, равное значению Сбора. Если у разбойника меньше половины ПЗ, он должен совершить бросок десятигранной кости, результат которого должен быть ниже значения Воли преступника; в противном случае разбойник убегает.", true, "", true, false, "Сбор", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6733) },
                    { 110, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6734), "Преступник, не участвующий в бою, может потратить раунд, чтобы прицелиться, и совершить проверку Прицеливания со СЛ, равной Реа х 3 цели, чтобы получить бонус к следующей атаке, равный половине значения Прицеливания. Если преступника заметят после броска, но до атаки, бонус снижается в два раза.", true, "", true, false, "Прицеливание", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6735) },
                    { 111, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6736), "Вместо атаки преступник может совершить проверку способности Прямо в глаз, чтобы временно ослепить цель. Для этого необходимо, чтобы преступник находился на дистанции ближнего боя; к удару при этом применяется штраф -3. При попадании цель получает 2d6 урона без модификаторов и ослепляется на количество раундов, равное значению Прямо в глаз. ", true, "", true, false, "Прямо в глаз", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6737) },
                    { 112, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6738), "Устраивая засаду, преступник может совершить встречную проверку способности Удар ассасина против Внимания цели, чтобы скрыться после атаки. Эту способность можно использовать в любой ситуации, но к ней применяются штрафы в зависимости от освещённости и других условий. Если противников несколько, каждый может совершить по броску, чтобы попытаться заметить преступника. ", true, "", true, false, "Удар ассасина", 1, 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6738) },
                    { 113, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6739), "Умелый ремесленник способен наскоро подлатать оружие или броню, чтобы их владелец мог продолжать сражаться. Ремесленник свяжет вместе обрывки лопнувшей тетивы, заострит край сломанного клинка или приколотит металлическую пластину поверх треснувшего щита. Ремесленник может потратить ход и совершить проверку Быстрого ремонта со сложностью, равной СЛ Изготовления данного предмета минус 3, чтобы восстановить 1/2 прочности брони или 1/2 надёжности сломанного оружия или щита. Пока оружие после Быстрого ремонта не починят в кузнице, оно наносит половину обычного урона.", true, "", true, false, "Быстрый ремонт", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6740) },
                    { 114, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6743), "Умелый ремесленник способен запомнить огромное количество чертежей на все случаи жизни. Когда ремесленник уже запомнил максимальное доступное ему количество чертежей, он может совершить проверку способности Большой каталог со СЛ 15, чтобы запомнить ещё один. Нет ограничения на количество запомненных чертежей, но за каждые 10 запоминаний СЛ проверки повышается на 1. ", true, "", true, false, "Большой каталог", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6743) },
                    { 115, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6744), "Когда ремесленник начинает изготавливать какой-либо предмет, он может совершить проверку способности Подмастерье со СЛ, равной СЛ Изготовления данного предмета. При успехе он прибавляет 1 к урону или к прочности за каждые 2 пункта сверх указанной СЛ. Максимальный бонус к урону или прочности равен 5. Ремесленник не может использовать Удачу для увеличения этого бонуса.", true, "", true, false, "Подмастерье", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6744) },
                    { 116, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6746), "Мастерская работа позволяет ремесленнику изготавливать предметы уровня мастера. Ремесленник может также в любой момент совершить проверку способности Мастерская работа со СЛ, равной СЛ Изготовления предмета, чтобы навсегда придать броне сопротивление (он сам решает, чему именно) или бонус оружию: дробящее оружие получает свойство дезориентирующее (-2), колющее или режущее — кровопускающее (50%).", true, "", true, false, "Мастерская работа", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6746) },
                    { 117, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6747), "Умелый ремесленник способен запомнить огромное количество формул на все случаи жизни. Когда ремесленник уже запомнил доступное ему число формул, он может совершить проверку способности Список лекарств со СЛ 15, чтобы запомнить ещё одну. Нет ограничения на количество запомненных формул, но за каждые 10 запоминаний СЛ проверки повышается на 1.", true, "", true, false, "Список лекарств", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6747) },
                    { 118, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6749), "Когда ремесленник собирается изготовить алхимический состав, он может совершить проверку Двойной порции со СЛ, равной СЛ Изготовления данной формулы. При успехе он создаёт две порции состава из ингредиентов, рассчитанных на одну порцию. Это применимо ко всем алхимическим предметам, включая эликсиры, масла, отвары и бомбы.", true, "", true, false, "Двойная порция", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6749) },
                    { 119, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6751), "Перед созданием ведьмачьего эликсира ремесленник может совершить проверку Адаптации (3 + СЛ Изготовления), чтобы уменьшить СЛ избегания отравления на 1 за каждый пункт свыше СЛ Изготовления. При провале ядовитость эликсира не меняется. СЛ избегания отравления не может опускаться ниже 12.", true, "", true, false, "Адаптация", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6751) },
                    { 120, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6752), "Ремесленник может совершить проверку Улучшения со СЛ, указанной в таблице на полях, чтобы придать оружию или броне особые свойства (при наличии инструментов ремесленника). На улучшение необходимо потратить 3 раунда. Для улучшения не обязательно использовать кузницу, но она даёт бонус +2 к проверке. Критический провал наносит предмету урон, равный значению провала.", true, "", true, false, "Улучшение", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6752) },
                    { 121, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6754), "Ремесленник может посеребрить имеющееся оружие в кузнице, совершив проверку со СЛ 16. Количество необходимых для этого серебряных слитков зависит от размера оружия. При успехе оружие наносит +ld6 урона серебром за каждые 3 пункта свыше сложности, но не более 5d6. При провале оружие ломается", true, "", true, false, "Серебрение", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6754) },
                    { 122, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6755), "Ремесленник может совершить проверку способности Прицельный удар со СЛ, равной СЛ Изготовления предмета, чтобы найти в нём изъян. На осмотр предмета уходит 1 раунд, но это позволяет ремесленнику совершить прицельную атаку со штрафом -6, чтобы нанести разрушающий урон оружию или броне, равный результату броска шестигранных костей в количестве, равном значению Прицельного удара.", true, "", true, false, "Прицельный удар", 1, 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6755) },
                    { 123, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6757), "Обычный торговец зарабатывает на жизнь тем, что продаёт товар приходящим к нему покупателям. Странствующий же торговец сам приходит к покупателю. Он ездит по миру и узнаёт обо всём, что там происходит. Торговец может в любой момент по своему желанию совершить проверку навыка Бывалый путешественник, чтобы узнать один факт об определённом предмете, культуре или области. СЛ проверки определяет ведущий. При успехе торговец получает ответ на вопрос, вспомнив те времена, когда он в прошлый раз был в этом месте. ", true, "", true, false, "Бывалый путешественник", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6757) },
                    { 124, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6758), "Торговец может совершить проверку Рынка с определяемой ведущим СЛ, чтобы найти нужный предмет по более низкой цене. При успехе торговец находит того, кто продаст ему тот же предмет за полцены. Чем более редкий предмет, тем выше СЛ поиска. Рынок не действует на экспериментальные, ведьмачьи предметы и реликвии.", true, "", true, false, "Рынок", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6758) },
                    { 125, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6759), "Совершая подкуп, торговец может совершить проверку способности Нечестная сделка со СЛ, равной ВолехЗ цели. При успехе торговец даёт взятку любым предметом, который у него есть и который стоит не менее 5 крон. Взятка всегда даёт +3 к Убеждению. Если взятка совсем уж несуразна, СЛ увеличивается на 5", true, "", true, false, "Нечестная сделка", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6760) },
                    { 126, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6761), "При попытке купить предмет торговец может совершить проверку Обещания со СЛ, равной Эмп х 3 продавца. При успехе продавец верит обещанию торговца заплатить позже. Количество недель, через которое необходимо выполнить это обязательство, равно значению Обещания.", true, "", true, false, "Обещание", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6761) },
                    { 127, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6762), "Торговец может совершить проверку способности Трущобы со СЛ в зависимости от размера поселения, чтобы заручиться помощью 1 беспризорника или бездомного за каждый пункт свыше СЛ (максимум 10). Торговец может спросить у них совета и получить бонус +1 к проверкам Ориентирования в городе за каждого. Информаторы берут плату в 1 крону на каждого, когда с ними советуются.", true, "", true, false, "Трущобы", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6763) },
                    { 128, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6764), "Торговец со способностью Свой человек может убедить другого персонажа пошпионить на него. Заплатите 10 крон и совершите встречную проверку Своего человека против Сопротивления убеждению цели. При успехе персонаж будет шпионить для торговца количество дней, равное значению способности Свой человек. По истечении этого срока торговец может снова совершить проверку, опять же заплатив.", true, "", true, false, "Свой человек", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6764) },
                    { 129, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6765), "Один разза игровую партию торговец может совершить проверку способности Карта сокровищ со СЛ, определяемой ведущим, чтобы вспомнить предполагаемое местонахождение реликвии или руин, в которых может оказаться что-то полезное. Место, где находится этот предмет или руины, расположено достаточно далеко или же кишит опасностями. Чтобы добраться до него, потребуется целая игровая партия.", true, "", true, false, "Карта сокровищ", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6766) },
                    { 130, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6767), "Входя в поселение впервые, торговец может потратить час на распространение вести о своём прибытии, а затем совершить проверку Хороших связей со СЛ в зависимости от размера поселения. При успехе репутация торговца в этом поселении на ld6 недель увеличивается на значение проверки свыше указанной СЛ, делённое на 2 (минимум 1).", true, "", true, false, "Хорошие связи", 1, 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6767) },
                    { 131, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6768), "Торговец, которому необходимо избавиться от предмета с сомнительным происхождением или краденого, может совершить проверку способности Сбытчик со СЛ, определяемой ведущим. При успехе торговец продаёт предмет по полной рыночной цене покупателю, который не станет задавать лишних вопросов и не сдаст торговца страже.", true, "", true, false, "Сбытчик", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6769) },
                    { 132, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6770), "Торговец может совершить проверку способности Воинский долг, чтобы попросить о помощи воина, который у него в долгу. Результат броска необходимо распределить по 3 категориям, указанным в таблице на полях. Воин будет работать на торговца количество дней, равное значению Воинского долга, и без лишних вопросов исполнит любой приказ в пределах разумного. ", true, "", true, false, "Воинский долг", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6770) },
                    { 133, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6772), "Бард весьма полезен в группе, особенно когда у вас не хватает денег. Бард может потратить час времени и совершить проверку Уличного выступления в центре ближайшего города. Результат броска — это сумма, которую бард заработал за время уличного выступления. Критический провал может снизить результат броска. Отрицательный результат означает, что бард не только не заработал денег, но и был освистан местными, что даёт ему штраф -2 к Харизме при контакте со всеми в этом городе на остаток дня.", true, "", true, false, "Уличное выступление", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6772) },
                    { 134, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6774), "Перед проверкой Уличного выступления бард может совершить проверку Повторного выступления со СЛ, установленной ведущим, чтобы определить, выступал ли он в этом городе раньше. При успехе бард уже завоевал популярность в этом городе. В таком случае доход с его Уличного выступления удваивается, а сам бард получает бонус +2 к Харизме при общении со всеми, кто пришёл на выступление. ", true, "", true, false, "Повторное выступление", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6774) },
                    { 135, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6775), "Выступая в течение полного раунда, вы можете совершить проверку способности Заворожить публику, чтобы привлечь внимание всех в радиусе 20 метров. Любой персонаж, чей результат проверки Сопротивления убеждению будет ниже вашего изначального, может только стоять и наблюдать, пока не выбросит более высокий результат. Атакованные цели автоматически перестают быть заворожёнными.", true, "", true, false, "Заворожить публику", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6775) },
                    { 136, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6777), "Один раз за игровую партию бард может совершить проверку способности Добрый друг, чтобы найти друга, который помог бы ему. Результат броска необходимо распределить между 3 категориями, указанными в таблице «Добрый друг» на полях. Друг по старой памяти окажет вам одну услугу в пределах разумного, после чего не будет больше помогать бесплатно и его нужно будет уговаривать.", true, "", true, false, "Добрый друг", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6777) },
                    { 137, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6778), "Бард может совершить проверку Незаметности против Внимания нескольких целей, чтобы слиться с толпой. Эта способность позволяет барду прятаться даже там, где нет подходящих укрытий, — бард попросту вклинивается в разговор, переключает внимание окружающих на другой предмет и тому подобное. Эта способность не работает в том случае, если бард одет во что-то очень броское.", true, "", true, false, "Незаметность", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6778) },
                    { 138, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6780), "После успешного броска Обмана против цели бард может совершить встречный бросок способности Пустить слух против Сопротивления убеждению цели. При успехе барда цель распространяет рассказанную им ложь в своём поселении или группе, что даёт барду бонус +2 к Обману при попытке рассказать ту же ложь кому-то ещё", true, "", true, false, "Пустить слух", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6780) },
                    { 139, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6781), "Находясь в поселении, бард может совершить проверку Сойти за своего (см. таблицу на полях). При успехе бард узнаёт, как выдать себя за местного, и его больше не считают чужим. Он получает бонус +2 к Харизме и Убеждению при общении с местными. При этом к нему не будут относиться с подозрением или подвергать травле, как чужак", true, "", true, false, "Сойти за своего", 1, 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6781) },
                    { 140, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6783), "Когда бард пытается повлиять на одного или нескольких собеседников, он может совершить проверку Коварства против Эмп х 3 цели. При успехе бард делает ехидное замечание, которое даёт штраф -1 к Соблазнению, Убеждению, Лидерству, Запугиванию или Харизме цели за каждый пункт свыше СЛ. ", true, "", true, false, "Коварство", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6783) },
                    { 141, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6784), "Бард может совершить встречную проверку способности Подколка против Сопротивления убеждению цели. При успехе бард дразнит цель, осыпает её угрозами и ругательствами до тех пор, пока цель не нападёт. Цель получает штраф к атаке и защите, равный половине значения Подколки барда и длящийся количество раундов, равное значению способности Подколка. ", true, "", true, false, "Подколка", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6784) },
                    { 142, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6786), "Бард может совершить проверку способности И ты, Брут против ВолихЗ цели, чтобы настроить цель против одного союзника. При успехе ложь или полуправда, сказанная бардом, заставляет цель относиться к своему союзнику с подозрением и враждебностью количество дней, равное значению И ты, Брут, или пока цель не совершит проверку Сопротивления убеждению, результат которой выше результата И ты, Брут. ", true, "", true, false, "И ты, Брут", 1, 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(6786) }
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
                table: "CreatureAbility",
                columns: new[] { "Id", "AbilityId", "CreatureId" },
                values: new object[,]
                {
                    { 1, 14, 2 },
                    { 2, 15, 2 },
                    { 3, 16, 2 },
                    { 4, 17, 2 },
                    { 5, 18, 2 }
                });

            migrationBuilder.InsertData(
                table: "CreatureAttacks",
                columns: new[] { "Id", "AttackId", "CreatureId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 2 },
                    { 5, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "CreatureEffect",
                columns: new[] { "Id", "CreateDate", "CreatureId", "Description", "EffectId", "Enabled", "Name", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8186), 1, "Бей его", null, true, "Урон", 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8186) },
                    { 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8189), 2, "", 59, true, "", 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8189) },
                    { 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8191), 2, "", 40, true, "Кровотечение", 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8191) },
                    { 4, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8192), 2, "", 42, true, "Дезориентирование", 2, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8192) },
                    { 5, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8194), 2, "", null, true, "Магическое обнаружение", 1, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8194) },
                    { 6, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8195), 2, "", null, true, "Масло против вампиров", 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8195) },
                    { 7, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8196), 2, "", null, true, "Эликсир Черная кровь", 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8196) },
                    { 8, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8198), 2, "", null, true, "Бомба лунная пыль", 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8198) },
                    { 9, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8199), 2, "", null, true, "Огонь", 3, new DateTime(2024, 7, 15, 13, 15, 23, 925, DateTimeKind.Local).AddTicks(8199) }
                });

            migrationBuilder.InsertData(
                table: "CreatureRewardList",
                columns: new[] { "Id", "Amount", "CreatureId", "ItemBaseId" },
                values: new object[,]
                {
                    { 1, "", 1, 90 },
                    { 2, "1к6/2", 2, 92 },
                    { 3, "1к6", 2, 93 },
                    { 4, "2к6", 2, 94 },
                    { 5, "1к6/2", 2, 95 },
                    { 6, "1к6", 2, 96 }
                });

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

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Accuracy", "AmountOfEnhancements", "Damage", "Distance", "EquipmentType", "Grip", "IsAmmunition", "ItemOriginType", "ItemType", "Reliability", "SkillId", "StealthType", "Type" },
                values: new object[] { 90, 1, 1, "1к6", 0, 2, 1, false, 1, 0, 5, 18, 2, 4 });

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
