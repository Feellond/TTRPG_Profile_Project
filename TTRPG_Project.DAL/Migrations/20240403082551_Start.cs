using System;
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
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRemember = table.Column<bool>(type: "bit", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    AttackType = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    AttackSpeed = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Headlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "ItemBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilityType = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "ServicePrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "SkillsTree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "AttackEffectList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttackId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChancePercent = table.Column<int>(type: "int", nullable: false),
                    IsDealDamage = table.Column<bool>(type: "bit", nullable: false)
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
                });

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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "Blueprints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    TimeSpend = table.Column<float>(type: "real", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    WhereToFind = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    IsAlchemical = table.Column<bool>(type: "bit", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Formulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Complexity = table.Column<int>(type: "int", nullable: false),
                    TimeSpend = table.Column<float>(type: "real", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "ItemBaseEffectList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChancePercent = table.Column<int>(type: "int", nullable: false),
                    IsDealDamage = table.Column<bool>(type: "bit", nullable: false)
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
                });

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
                });

            migrationBuilder.CreateTable(
                name: "Reward",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reward_ItemBases_ItemBaseId",
                        column: x => x.ItemBaseId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                });

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
                });

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationSkill = table.Column<int>(type: "int", nullable: false),
                    SuperstitionsInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonsterLoreSkill = table.Column<int>(type: "int", nullable: false),
                    MonsterLoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Weight = table.Column<float>(type: "real", nullable: false),
                    HabitatPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intellect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creatures", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Energy = table.Column<int>(type: "int", nullable: false),
                    DefaultMagicAbilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillsTreeId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDifficult = table.Column<bool>(type: "bit", nullable: false),
                    IsClassSkill = table.Column<bool>(type: "bit", nullable: false),
                    StatId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "BlueprintComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "FormulaComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "CreatureAbility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "CreatureAttacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "CreatureRewardList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    RewardId = table.Column<int>(type: "int", nullable: true),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_CreatureRewardList_Reward_RewardId",
                        column: x => x.RewardId,
                        principalTable: "Reward",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnduranceCost = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConcetration = table.Column<bool>(type: "bit", nullable: false),
                    ConcetrationEnduranceCost = table.Column<int>(type: "int", nullable: false),
                    SpellLevel = table.Column<int>(type: "int", nullable: false),
                    CheckDC = table.Column<int>(type: "int", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: false),
                    DangerInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WithdrawalCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellType = table.Column<int>(type: "int", nullable: false),
                    SpellTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceType = table.Column<int>(type: "int", nullable: false),
                    SourceTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPriestSpell = table.Column<bool>(type: "bit", nullable: false),
                    IsDruidSpell = table.Column<bool>(type: "bit", nullable: false),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    EquipmentType = table.Column<int>(type: "int", nullable: false),
                    Accuracy = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    Grip = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    StealthType = table.Column<int>(type: "int", nullable: false),
                    AmountOfEnhancements = table.Column<int>(type: "int", nullable: false),
                    IsAmmunition = table.Column<bool>(type: "bit", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "SpellComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "SpellSkillProtectionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellId = table.Column<int>(type: "int", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.InsertData(
                table: "SkillsList",
                columns: new[] { "Id", "AlchemyId", "AlchemyValue", "AppearanceId", "AppearanceValue", "ArcheryId", "ArcheryValue", "ArtistryId", "ArtistryValue", "AthleticsId", "AthleticsValue", "AttentionId", "AttentionValue", "CamouflageId", "CamouflageValue", "CharismaId", "CharismaValue", "CityOrientationId", "CityOrientationValue", "CorruptionId", "CorruptionValue", "CourageId", "CourageValue", "CreateDate", "CrossbowMasteryId", "CrossbowMasteryValue", "DeceptionId", "DeceptionValue", "DeductionId", "DeductionValue", "EducationId", "EducationValue", "Enabled", "EnduranceId", "EnduranceValue", "EtiquetteId", "EtiquetteValue", "EvasionId", "EvasionValue", "FirstAidId", "FirstAidValue", "ForgeryId", "ForgeryValue", "GamblingId", "GamblingValue", "IntimidationId", "IntimidationValue", "KnowledgeTransferId", "KnowledgeTransferValue", "LanguageDwarfId", "LanguageDwarfValue", "LanguageGeneralId", "LanguageGeneralValue", "LanguageHighId", "LanguageHighValue", "LeadershipId", "LeadershipValue", "LightBladeMasteryId", "LightBladeMasteryValue", "LockpickingId", "LockpickingValue", "MagicResistanceId", "MagicResistanceValue", "ManualDexterityId", "ManualDexterityValue", "ManufacturingId", "ManufacturingValue", "MeleeCombatId", "MeleeCombatValue", "MonsterologyId", "MonsterologyValue", "PersuasionId", "PersuasionResistanceId", "PersuasionResistanceValue", "PersuasionValue", "PoleWeaponMasteryId", "PoleWeaponMasteryValue", "PublicSpeakingId", "PublicSpeakingValue", "RidingId", "RidingValue", "RitualsId", "RitualsValue", "SeamanshipId", "SeamanshipValue", "SeductionId", "SeductionValue", "SpellcastingId", "SpellcastingValue", "StealthId", "StealthValue", "StrengthId", "StrengthValue", "SurvivalId", "SurvivalValue", "SwordsmanshipId", "SwordsmanshipValue", "TacticsId", "TacticsValue", "TradingId", "TradingValue", "TrapKnowledgeId", "TrapKnowledgeValue", "UnderstandingPeopleId", "UnderstandingPeopleValue", "UpdateDate", "WrestlingId", "WrestlingValue" },
                values: new object[] { 1, 39, 0, 30, 0, 26, 0, 32, 0, 22, 4, 1, 6, 43, 0, 38, 0, 6, 0, 47, 0, 52, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7336), 25, 4, 34, 0, 3, 0, 5, 0, true, 28, 5, 10, 0, 21, 4, 44, 0, 45, 0, 29, 0, 46, 0, 7, 0, 13, 0, 11, 0, 12, 0, 33, 0, 18, 5, 40, 0, 49, 4, 23, 0, 42, 0, 14, 0, 4, 0, 37, 50, 5, 0, 17, 0, 31, 0, 16, 0, 48, 0, 20, 0, 36, 0, 51, 0, 24, 3, 27, 0, 2, 5, 19, 6, 8, 0, 9, 0, 41, 0, 35, 0, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7336), 15, 6 });

            migrationBuilder.InsertData(
                table: "SkillsTree",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "FirstLeftSkillId", "FirstLeftSkillValue", "FirstMiddleSkillId", "FirstMiddleSkillValue", "FirstRightSkillId", "FirstRightSkillValue", "MainSkillId", "MainSkillValue", "Name", "SecondLeftSkillId", "SecondLeftSkillValue", "SecondMiddleSkillId", "SecondMiddleSkillValue", "SecondRightSkillId", "SecondRightSkillValue", "SourceId", "ThirdLeftSkillId", "ThirdLeftSkillValue", "ThirdMiddleSkillId", "ThirdMiddleSkillValue", "ThirdRightSkillId", "ThirdRightSkillValue", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7238), "", true, 54, 0, 57, 0, 60, 0, 53, 0, "", 55, 0, 58, 0, 61, 0, null, 56, 0, 59, 0, 62, 0, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreateDate", "Enabled", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6232), true, "Базовая книга", new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6241) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6243), true, "Хоумбрю", new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6243) }
                });

            migrationBuilder.InsertData(
                table: "StatsList",
                columns: new[] { "Id", "ConstitutionId", "ConstitutionValue", "CraftsmanshipId", "CraftsmanshipValue", "CreateDate", "DexterityId", "DexterityValue", "EmpathyId", "EmpathyValue", "Enabled", "EnduranceId", "EnduranceValue", "EnergyId", "EnergyValue", "HandStrikeId", "HandStrikeValue", "HealthPointsId", "HealthPointsValue", "IntellectId", "IntellectValue", "JumpingId", "JumpingValue", "KickId", "KickValue", "LuckId", "LuckValue", "ReactionId", "ReactionValue", "ResilienceId", "ResilienceValue", "RestId", "RestValue", "RunningId", "RunningValue", "SpeedId", "SpeedValue", "UpdateDate", "WeightId", "WeightValue", "WillpowerId", "WillpowerValue" },
                values: new object[] { 1, 4, 5, 7, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7303), 3, 5, 6, 3, true, 15, 20, 10, 0, 18, 0, 14, 20, 1, 3, 13, 2, 19, 2, 9, 0, 2, 6, 11, 4, 17, 4, 12, 12, 5, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7304), 16, 50, 8, 4 });

            migrationBuilder.InsertData(
                table: "Attacks",
                columns: new[] { "Id", "AttackSpeed", "AttackType", "BaseAttack", "CreateDate", "Damage", "Description", "Distance", "Enabled", "Name", "Reliability", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, 4, 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7260), "2к6+2", "", 0, true, "Железный полуторный меч", 10, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7260) },
                    { 2, 1, 4, 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7265), "1к6", "", 0, true, "Кинжал", 10, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7265) },
                    { 3, 1, 1, 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7267), "2к6+2", "", 0, true, "Ручной арбалет", 10, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7268) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreateDate", "DefaultMagicAbilities", "Description", "Enabled", "Energy", "Name", "SkillsTreeId", "SourceId", "UpdateDate" },
                values: new object[] { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7250), "", "Я ведь уже говорил тебе, что странствовал какое-то время с ведьмаком? Так вот. Спросил я его как-то, почему он ведьмаком остался. Это ведь явно не работа мечты — входишь в деревню, дети прячутся, отцы своих дочурок по домам запирают. Впрочем, ответ был ожидаем — он попросту незнал другой жизни. На самом деле логично. Вот живёшь ты, живёшь, занимаешься одним делом, а больше-то ничего и не умеешь. Но не всё так плохо. Ведьмаки — это сила. Мечники они отменные — тот ведьмак, с которым я странствовал, как-то раз арбалетный болт отбил на лету. Могу повторить, если тебя это не впечатлило. Своим кручением-верчением они вполне способны в капусту покрошить более медленных мечников. Двигаются ведьмаки так быстро, что со стороны за мечом не уследишь и каждый взмах превращается в серебряную полосу. И не стоит забывать об алхимии! Раньше они точно с собой таскали всякие эликсиры и масла, благодаря которым на поле боя превращались в сущих дьяволов — становились быстрее и раны залечивали, как волколаки. Вдобавок ко всему ведьмаки чуточку магией владеют. Ну, не такой мощной, как настоящие чародеи, но всё же заклинания свои творят. Называется это знаками. Это такие пассы руками, обладающие магическим действием. Любой маг на это лишь пофыркает, поскольку такие вещи не дотягивают даже до простейших заклинаний, но всёравно знаки весьма эффективны. Так что честно тебе скажу: я рад, что ведьмаки только на чудовищ охотятся. Ну... по крайней мере, когда-то так было.", true, 2, "Ведьмак", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6564), "", true, "Незаметное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6565) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6566), "", true, "Кровопускающее", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6566) },
                    { 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6567), "", true, "Пробивающее броню", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6567) },
                    { 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6568), "", true, "Дезориентирующее(1)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6568) },
                    { 5, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6569), "", true, "Дезориентирующее(2)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6569) },
                    { 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6570), "", true, "Дезориентирующее(3)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6570) },
                    { 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6571), "", true, "Метеоритное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6571) },
                    { 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6572), "", true, "Длинное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6572) },
                    { 9, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6573), "", true, "Фокусирующее(1)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6574) },
                    { 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6574), "", true, "Фокусирующее(2)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6575) },
                    { 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6575), "", true, "Фокусирующее(3)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6576) },
                    { 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6577), "", true, "Сокрушающая сила", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6577) },
                    { 13, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6578), "", true, "Серебрянное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6578) },
                    { 14, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6579), "", true, "Сбалансированное(1)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6579) },
                    { 15, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6581), "", true, "Сбалансированное(2)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6581) },
                    { 16, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6582), "", true, "Сбалансированное(3)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6582) },
                    { 17, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6583), "", true, "Улучшенное пробивание брони", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6583) },
                    { 18, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6584), "", true, "Захватное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6584) },
                    { 19, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6585), "", true, "Ловящий лезвия", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6585) },
                    { 20, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6586), "", true, "Магические путы", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6586) },
                    { 21, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6587), "", true, "Медленно перезаряжающееся", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6587) },
                    { 22, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6588), "", true, "Несмертельное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6589) },
                    { 23, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6589), "", true, "Опутывающее", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6590) },
                    { 24, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6591), "", true, "Парирующее", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6592) },
                    { 25, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6592), "", true, "Разрушающее", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6593) },
                    { 26, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6593), "", true, "Рукопашное", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6594) },
                    { 27, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6594), "", true, "Расчетная перезарядка", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6595) },
                    { 28, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6596), "", true, "Улучшенное фокусирующее", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6596) },
                    { 29, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6597), "", true, "Устанавливаемое", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6597) },
                    { 30, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6598), "", true, "Шприц", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6598) },
                    { 31, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6599), "", true, "Закрывает все тело", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6599) },
                    { 32, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6600), "", true, "Огнеупорный", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6600) },
                    { 33, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6601), "", true, "Ограничение зрения", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6601) },
                    { 34, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6602), "", true, "Полное укрытие", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6602) },
                    { 35, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6603), "", true, "Сопротивление(Д)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6603) },
                    { 36, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6604), "", true, "Сопротивление(Р)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6605) },
                    { 37, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6605), "", true, "Сопротивление(К)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6606) },
                    { 38, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6606), "", true, "Сопротивление(С)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6607) },
                    { 39, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6608), "", true, "Горение", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6609) },
                    { 40, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6609), "", true, "Дезориентация", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6610) },
                    { 41, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6610), "", true, "Отравление", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6611) },
                    { 42, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6612), "", true, "Кровотечение", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6612) },
                    { 43, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6613), "", true, "Замораживание", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6613) },
                    { 44, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6614), "", true, "Ошеломление", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6614) },
                    { 45, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6615), "", true, "Опьянение", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6615) },
                    { 46, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6616), "", true, "Галлюцинации", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6616) },
                    { 47, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6618), "", true, "Тошнота", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6618) },
                    { 48, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6619), "", true, "Удушье", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6619) },
                    { 49, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6620), "", true, "Слепота", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6620) },
                    { 50, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6621), "", true, "Дистанция", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6621) },
                    { 51, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6622), "", true, "Точность+1", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6622) },
                    { 52, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6623), "", true, "Точность+2", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6623) },
                    { 53, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6624), "", true, "Точность+3", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6624) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6640), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "Обезболивающие травы", 12, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6641), 0.10000000000000001 },
                    { 2, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6658), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "Капюшон вердэнского лучника", 100, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6658), 0.5 },
                    { 3, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6704), "", true, "Пепел", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6705), 0.10000000000000001 },
                    { 4, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6713), "", true, "Уголь", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6714), 0.10000000000000001 },
                    { 5, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6718), "", true, "Хлопок", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6718), 0.10000000000000001 },
                    { 6, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6722), "", true, "Двойное полотно", 22, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6722), 0.10000000000000001 },
                    { 7, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6725), "", true, "Стекло", 5, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6725), 0.5 },
                    { 8, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6727), "", true, "Укрепленное дерево", 16, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6727), 0.10000000000000001 },
                    { 9, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6730), "", true, "Полотно", 9, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6730), 0.10000000000000001 },
                    { 10, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6732), "", true, "Масло", 3, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6732), 0.10000000000000001 },
                    { 11, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6735), "", true, "Смлоа", 2, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6735), 0.10000000000000001 },
                    { 12, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6737), "", true, "Шелк", 50, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6737), 0.10000000000000001 },
                    { 13, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6739), "", true, "Нитки", 3, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6739), 0.10000000000000001 },
                    { 14, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6741), "", true, "Древесина", 3, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6741), 1.0 },
                    { 15, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6744), "", true, "Воск", 2, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6744), 0.10000000000000001 },
                    { 16, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6746), "", true, "Кости животных", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6746), 4.0 },
                    { 17, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6748), "", true, "Коровья шкура", 10, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6749), 5.0 },
                    { 18, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6750), "", true, "Кожа драконида", 58, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6751), 5.0 },
                    { 19, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6753), "", true, "Чешуя драконида", 30, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6753), 5.0 },
                    { 20, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6755), "", true, "Перья", 4, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6755), 0.10000000000000001 },
                    { 21, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6757), "", true, "Укрепленная кожа", 48, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6757), 3.0 },
                    { 22, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6759), "", true, "Кожа", 28, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6759), 2.0 },
                    { 23, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6761), "", true, "Лирийская кожа", 60, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6761), 2.0 },
                    { 24, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6765), "", true, "Волчья шкура", 14, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6765), 3.0 },
                    { 25, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6767), "", true, "Чернящее масло", 24, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6767), 0.10000000000000001 },
                    { 26, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6769), "", true, "Масло из дрейка", 45, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6769), 0.10000000000000001 },
                    { 27, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6773), "", true, "Эфирная смазка", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6773), 0.10000000000000001 },
                    { 28, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6783), "", true, "Травильная кислота", 2, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6783), 0.10000000000000001 },
                    { 29, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6785), "", true, "Пятая эссенция", 82, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6785), 0.10000000000000001 },
                    { 30, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6789), "", true, "Огров воск", 10, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6789), 0.10000000000000001 },
                    { 31, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6791), "", true, "Точильный порошок", 32, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6791), 0.10000000000000001 },
                    { 32, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6793), "", true, "Дубильные травы", 3, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6794), 0.10000000000000001 },
                    { 33, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6796), "", true, "Темное железо", 52, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6796), 1.5 },
                    { 34, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6799), "", true, "Темная сталь", 82, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6799), 1.0 },
                    { 35, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6807), "", true, "Двимерит", 240, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6808), 1.0 },
                    { 36, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6810), "", true, "Самоцветы", 100, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6810), 0.10000000000000001 },
                    { 37, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6813), "", true, "Совершенный самоцвет", 1000, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6813), 0.10000000000000001 },
                    { 38, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6815), "", true, "Светящаяся руда", 80, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6815), 1.0 },
                    { 39, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6818), "", true, "Золото", 85, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6818), 1.0 },
                    { 40, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6820), "", true, "Железо", 30, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6820), 1.5 },
                    { 41, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6822), "", true, "Махакамский двимерит", 300, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6823), 1.0 },
                    { 42, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6825), "", true, "Махакамская сталь", 114, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6825), 1.0 },
                    { 43, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6828), "", true, "Метеорит", 98, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6828), 1.0 },
                    { 44, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6830), "", true, "Речная глина", 5, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6830), 1.5 },
                    { 45, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6832), "", true, "Серебро", 72, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6832), 1.0 },
                    { 46, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6834), "", true, "Сталь", 48, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6835), 1.0 },
                    { 47, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6837), "", true, "Камень", 4, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6837), 2.0 },
                    { 48, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6839), "", true, "Третогорская сталь", 64, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6839), 1.0 },
                    { 49, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6841), "", true, "Зерриканская смесь", 30, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6841), 0.10000000000000001 },
                    { 50, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6845), "", true, "Зеленая плесень", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6845), 0.10000000000000001 },
                    { 51, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6847), "", true, "Переступень", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6847), 0.10000000000000001 },
                    { 52, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6850), "", true, "Помет беса", 20, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6850), 1.0 },
                    { 53, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6853), "", true, "Омела", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6853), 0.10000000000000001 },
                    { 54, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6856), "", true, "Паутинник", 18, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6856), 0.10000000000000001 },
                    { 55, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6858), "", true, "Optima mater", 100, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6858), 0.10000000000000001 },
                    { 56, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6860), "", true, "Жимолость", 21, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6860), 0.10000000000000001 },
                    { 57, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6862), "", true, "Листья балиссы", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6863), 0.10000000000000001 },
                    { 58, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6865), "", true, "Сера", 14, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6865), 0.10000000000000001 },
                    { 59, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6867), "", true, "Собачья петрушка", 2, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6868), 0.10000000000000001 },
                    { 60, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6869), "", true, "Царская водка", 20, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6870), 0.10000000000000001 },
                    { 61, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6872), "", true, "Аконит", 9, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6872), 0.10000000000000001 },
                    { 62, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6876), "", true, "Корень лопуха", 32, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6876), 0.10000000000000001 },
                    { 63, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6878), "", true, "Корень мандрагоры", 65, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6879), 0.10000000000000001 },
                    { 64, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6881), "", true, "Фосфор", 20, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6881), 0.5 },
                    { 65, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6883), "", true, "Calcium equum", 12, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6883), 0.10000000000000001 },
                    { 66, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6885), "", true, "Вороний глаз", 17, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6886), 0.10000000000000001 },
                    { 67, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6888), "", true, "Грибы-шибальцы", 17, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6888), 0.10000000000000001 },
                    { 68, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6896), "", true, "Лепестки белого мирта", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6896), 0.10000000000000001 },
                    { 69, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6898), "", true, "Плод балиссы", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6898), 0.10000000000000001 },
                    { 70, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6900), "", true, "Ячмень", 9, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6900), 0.10000000000000001 },
                    { 71, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6903), "", true, "Винный камень", 88, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6903), 0.5 },
                    { 72, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6905), "", true, "Волокна хана", 17, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6905), 0.10000000000000001 },
                    { 73, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6907), "", true, "Ласточкина трава", 8, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6907), 0.10000000000000001 },
                    { 74, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6909), "", true, "Лунная крошка", 91, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6910), 0.10000000000000001 },
                    { 75, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6912), "", true, "Вербена", 18, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6912), 0.10000000000000001 },
                    { 76, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6914), "", true, "Листья волчьего алоэ", 39, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6914), 0.10000000000000001 },
                    { 77, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6916), "", true, "Краснолюдский бессмертник", 75, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6917), 0.10000000000000001 },
                    { 78, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6918), "", true, "Эмбрион эндриаги", 55, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6919), 1.5 },
                    { 79, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6922), "", true, "Жемчуг", 100, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6922), 0.10000000000000001 },
                    { 80, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6924), "", true, "Корень зарника", 18, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7013), 0.10000000000000001 },
                    { 81, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7016), "", true, "Лепестки гинации", 17, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7016), 0.10000000000000001 },
                    { 82, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7018), "", true, "Лепестки морозника", 19, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7018), 0.10000000000000001 },
                    { 83, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7020), "", true, "Плод берберки", 9, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7020), 0.10000000000000001 },
                    { 84, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7023), "", true, "Ртутный раствор", 77, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7023), 0.10000000000000001 },
                    { 85, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7025), "", true, "Склеродерм", 5, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7026), 0.10000000000000001 },
                    { 86, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7064), "", true, "Чертеж «Капюшон вердэнского лучника»", 150, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7064), 0.0 },
                    { 87, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7097), "", true, "Формула «Обезболивающие травы»", 0, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7098), 1.0 },
                    { 88, 0, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7130), "Всегда с собой таскай верёвку. Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "Веревка (20 метров)", 20, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7130), 1.5 },
                    { 89, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7143), "Позволяют создавать алхимические составы", true, "Инструменты алхимика", 80, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7143), 3.0 },
                    { 90, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7157), "", true, "Стилет", 275, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7158), 0.5 },
                    { 91, 0, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7131), "Валюта это", true, "Кроны", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7132), 0.01 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7171), "Ведьмаки — тема деликатная с тех самых пор, как их создали много веков тому назад. Но, знаешь, даже когда они были нарасхват, их не особо-то любили. Ведьмаков выращивали из людских детей в пяти ведьмачьих школах. Там дети проходили какую-то лютую подготовку, после которой становились живым оружием. Быстрые до одури, могут сражаться вслепую и обучены охотиться считай на всех тварей, каких только можно встретить. Через парулет тренировок их подвергают мутациям — известней всего так называемое Испытание травами. Ведьмак, с которым мне довелось странствовать, рассказал, что переживает эту дрянь только один дитёнок из четырёх. Те, кто выжил, меняются. Глаза у них становятся кошачьими, а эмоции напрочь отмирают. Вроде как последнее со временем налаживается — например, тот самый знакомый мне ведьмак по дороге шутки-то малясь травил. Но с того самого момента, как ведьмаки мутируют, они становятся убийцами. Они перерождаются ради единственной цели — убивать чудовищ. И если доведётся тебе повидать ведьмака в деле, то поймёшь, что все те пройденные страдания были не зря. Одна только проблема: они мутанты, а люди мутантов ненавидят. С адаптацией в обществе у ведьмаков плохо, и для большинства они — хладнокровные бессердечные выродки, что честным людям кишки выпускают, предварительно ограбив да их дочек снасильничав", true, "Ведьмаки", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7171) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7172), "История эльфов (точнее Aen Seidhe, поскольку наши эльфы далеко не единственные) весьма грустная. Они прибыли сюда неизвестно откуда на огромных белых кораблях. Случилось это незадолго до появления людей. Я бы не назвал эльфов добряками, но с остальными они как-то уживались. От людей они не сильно отличаются: высокие, худые, любят на другие народы свысока смотреть. Разве что уши острые, жизнь вечная, да, считай, полное единение с природой — эльфы много поколений только и делали, что занимались собирательством и строили дворцы. Унихза время поеданияягод да кореньев и клыков-то не осталось. Правда, всё равно не советую их из себя выводить — на поле боя эльфы могут устроить тот ещё ад. Броню они толком не носят, но заприметить эльфа в лесу также тяжело, как зимой лягушку найти. А уж искуснее лучника чем эльф, днём с огнём не сыщешь.", true, "Эльфы (Aen Seidhe)", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7172) },
                    { 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7173), "Друже, вот что я тебе скажу: реки высохнут, горы рассыплются, а краснолюды никуда не денутся. Может, мы и низенькие в сравнении с эльфами и людьми, да только в силе и закалке им с нами не тягаться. Мы — само воплощение стойкости! Краснолюды уже не первый век существуют в этом мире. Жили себе спокойно в горах, ковали. Мы народ достаточно дружелюбный, если познакомиться с нами поближе. Да и уживаемся спокойно со всеми... если нас не бесить, конечно. Человечишки нас не особо любят, но мы им нужны — кто ж сталь им ковать будет и торговать? К тому же, в отличие от сраных эльфов, мы не держим на людей зла. Нас не трогают — и мы их не трогаем в ответ. Порой даже кружечку-другую готовы раздавить вместе с человеком. Жаль, конечно, что вся эта безумная расистская дрянь по Северу расползлась. Теперь и на краснолюдов травлю открыли. Повезло ещё, что люди наших девок нормально от мужиков отличить не могут, а то бы всех уже увели! Ведь нету бабы краше нраснолюдки. Правильно говорят: чем пышнее борода, тем приятнее... ну, ты понимаешь.", true, "Краснолюды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7173) },
                    { 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7174), "Ох, будь я покозлистее, то всю желчь излил бы тебе о том, как людишки насолили моему народу и остальным Старшим Народам. Но я не такой. С людьми я служил бок о бок на войне с Нильфгаардом; в той же темерской армии большинство — люди. Не все они говнюки — бывают и хорошие. По характеру люди-mo разные. Обычно они весьма стойкие ребята. Разве что частенько начинают то за «правое дело» воевать, то тыкать пальцами и бояться. Сейчас люди на Континенте — преобладающий вид, и они об этом прекрасно знают... чёрт, даже не надо стараться, чтобы о них гадости говорить. Люди почти уничтожили Старшие Народы, выкосили вранов, оставили в живых всего пару сотен боболаков, построили свои города на руинах Старших Народов и каждый день кого-то из Старших убивают. Но нет, они не все говнюки. Да, большинство магов — люди, и именно они погрузили мир в хаос, но они также сделали мир лучше с помощью науки и магии. Люди умные и, на самом деле, верные — если ты с человеком дружен, он тебя в беде не бросит.", true, "Люди", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7175) },
                    { 5, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7176), "Формально гуманоиды чудовищами не являются. Это люди, эльфы, краснолюды и прочие представители Старших Народов. Гуманоиды разнообразны в плане поведения и мест обитания. Важно помнить, что даже\r\nпо стандартным правилам гуманоиды не имеют восприимчивости к серебру и сопротивления стали.", true, "Гуманоиды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7176) },
                    { 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7177), "Трупоеды едят трупы, и зачастую их можно встретить на кладбищах, полях боя и в глубоких пещерах. Их отталкивающая внешность обманчива — это вполне живые существа с иных планов. Менее разумные трупоеды, такие как гули, нападают на всё, что оказывается поблизости. Умные трупоеды, вроде кладбищенских баб, бродят по кладбищам и заманивают селян.", true, "Трупоеды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7177) },
                    { 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7178), "Духи представляют собой сильные желания усопших. Обычно они появляются тогда, когда кого-то убивают или когда кто-то перед смертью испытывает интенсивные эмоции. Многие духи разумны, но все они целиком захвачены каким-то одним чувством — обычно яростью, — что просто не позволяет вести с ними диалог.", true, "Духи", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7178) },
                    { 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7179), "Звери, как и гуманоиды, формально не относятся к чудовищам. В этой категории — собаки, волки и тому подобные существа. Они не имеют восприимчивости к серебру и сопротивления стали. Встретить их и вблизи поселений. Охотятся они преимущественно на селян и скот.", true, "Звери", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7180) },
                    { 9, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7181), "Проклятые — это люди и нелюди, на которых было наложено проклятие, превратившее их в чудовиш. Наиболее распространены волколаки. Поскольку это проклятые люди они обычно живут в человеческих поселениях. В большинстве своём такие существа открыто агрессивны по отношению к людям.", true, "Проклятые", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7181) },
                    { 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7182), "Этот класс объединяет множество разных химер вроде сирен и грифонов — соединение частей разных животных. Гибриды необычайно разнообразны и предпочитают различные среды обитания. Те, у кого есть способность к полёту, живут на возвышенностях, хотя в целом гибридов можно найти повсемест но, в самых разных зонах.", true, "Гибриды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7182) },
                    { 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7183), "Инсектоиды — это огромные насекомые и арахниды, которые бродят за пределами поселений, подстерегая неосторожных путников. Инсектоиды — хищники, обычно нападающие из засады и ранящие своих жертв ядовитыми жвалами или когтями. Если подобратьсслишком близко к гнезду инсектоидов, то вскоре вас может окружить целый рой этих существ.", true, "Инсектоиды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7184) },
                    { 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7185), "Духи стихий - восхитительные создания магии: големы, элементали, гаргульи и им подобные. Большинство таких существ призваны магами и жрецами. Они следуют приказам призвавшего, у них практически нет своей воли. Но если призвать их в этот мир, не связав узами, духистихий становятся ужасающей силой, способной уничтожать города.", true, "Духи стихий", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7185) },
                    { 13, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7186), "Реликты — силы природы, периодически проявляющиеся за пределами поселений. Скорее всего, эти чудовища прибыли в наш мир во время Сопряжения Сфер. Все они владеют магиейи тесно связаны с природой. По разумности реликты различаются: от умных и хитрых до примитивных и жестоких.", true, "Реликты", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7186) },
                    { 14, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7187), "Огры, включая троллей, накеров и великанов, — это гуманоидные создания, зачастую с почти человеческим интеллектом. Большинство из них велики и нескладны (за исключением накеров). Они не только способны создавать племенные сообщества, но и, в случае троллей, кое-как разговаривать на человеческом языке и Старшей Речи.", true, "Огры", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7187) },
                    { 15, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7188), "Среди драконидов есть такие существа, как виверны и драконы. Большинство драконидов — это крупные крылатые ящеры, крайне опасные (особенно в ближнем бою), но дикие. Истинные драконы по интеллекту близки к людям, а то и вовсе их превосходят и обладают куда большим количеством способностей. Логова драконидов расположены высоко в горах.", true, "Дракониды", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7189) },
                    { 16, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7189), "Вампиры — весьма разнообразная группа кровососущих чудовищ. Обычно они охотятся в руинах, хотя могущественные вампиры могут процветать и в городах. Низшие вампиры — это неразумные твари, раздирающие тела на части и затем выпивающие кровь. Высшие вампиры способны без проблем влиться в человеческое общество и обладают огромной силой.", true, "Вампиры", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7190) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 54, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6519), "Ведьмак может войти в медитативный транс, что позволяет ему получить все преимущества сна, но при этом сохранять бдительность. Во время медитации ведьмак считается находящимся в сознании для того, чтобы заметить что-либо в радиусе в метрах, равном удвоенному значению его Медитации.", true, true, false, "Магический клинок", 1, null, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6520) },
                    { 55, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6521), "По мере того как ведьмак всё больше использует знаки, его тело постепенно привыкает к течению магической энергии. Каждые 2 очка, вложенные в способность Магический источник, повышают значение Энергии ведьмака на 1. Когда эта способность достигает 10 уровня, максимальное значение Энергии ведьмака становится равно 7. Эта способность развивается аналогично прочим навыкам.", true, true, false, "Магический источник", 1, null, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6521) },
                    { 57, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6524), "а годы употребления ядовитых ведьмачьих эликсиров ведьмаки привыкают к токсинам. Ведьмак может выдержать отвары и эликсиры суммарной токсичностью на 5% больше за каждые 2 очка, вложенные в способность Крепкий желудок. Эта способность развивается аналогично прочим навыкам. На 10 уровне максимальная токсичность для ведьмака равна 150%.", true, true, false, "Крепкий желудок", 1, null, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6524) },
                    { 58, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6525), "Будучи отравленным, ведьмак впадает в ярость и наносит дополнительно 1 урон в ближнем бою за каждый уровень Ярости. В этом состоянии единственная цель ведьмака — добраться до безопасного места или убить отравителя. Действие Ярости заканчивается одновременно с действием яда. Ведьмак может попытаться избавиться от Ярости раньше, совершив проверку Стойкости со СЛ 15.", true, true, false, "Ярость", 1, null, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6525) }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6391), "", true, "Интеллект", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6391) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6393), "", true, "Реакция", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6393) },
                    { 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6394), "", true, "Ловкость", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6395) },
                    { 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6395), "", true, "Телосложение", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6396) },
                    { 5, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6396), "", true, "Скорость", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6397) },
                    { 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6398), "", true, "Эмпатия", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6398) },
                    { 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6399), "", true, "Ремесло", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6399) },
                    { 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6400), "", true, "Воля", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6400) },
                    { 9, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6401), "", true, "Удача", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6401) },
                    { 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6402), "", true, "Энергия", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6402) },
                    { 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6403), "", true, "Устойчивость", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6404) },
                    { 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6404), "", true, "Бег", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6405) },
                    { 13, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6406), "", true, "Прыжок", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6406) },
                    { 14, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6407), "", true, "Пункты Здоровья", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6407) },
                    { 15, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6408), "", true, "Выносливость", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6408) },
                    { 16, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6409), "", true, "Переносимый вес", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6409) },
                    { 17, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6410), "", true, "Отдых", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6410) },
                    { 18, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6411), "", true, "Удар рукой", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6411) },
                    { 19, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6413), "", true, "Удар ногой", 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6413) }
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "RaceId", "SourceId", "Type", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7197), "Благодаря обострённым чувствам ведьмаки не получают штрафов при слабом свете и получают врождённый бонус +1 к Вниманию, а также возможность выслеживания по запаху", true, "Обостренные чувства", 1, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7197) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7199), "После всех мутаций ведьмаки становятся невосприимчивы к болезням и способны использовать мутагены", true, "Стойкость мутанта", 1, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7200) },
                    { 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7201), "Из-за пережитых страданий и мутаций эмоции у ведьмаков притупляются. Ведьмакам не нужно совершать проверки Храбрости против Запугивания, но они получают штраф -4 к Эмпатии. При этом значение Эмпатии ведьмака не может быть ниже 1.", true, "Притупление эмоций", 1, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7201) },
                    { 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7202), "Благодаря интенсивным тренировкам и мутациям ведьмаки куда быстрее и проворнее обычных людей. Они получают постоянный бонус +1 к Реакции и Ловкости, позволяющий сделать эти значения больше 10.", true, "Молниеносная реакция", 1, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7203) },
                    { 5, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7204), "У эльфов есть врождённая творческая жилка и развитое чувство прекрасного. Эльфы получают врождённый бонус +1 к Искусству.", true, "Чувство прекрасного", 2, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7204) },
                    { 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7205), "Благодаря давним традициям и постоянным тренировкам эльфы — одни из лучших лучников в мире. Эльфы получают врождённый бонус +2 к Стрельбе из лука и способны выхватывать и натягивать лук, не тратя на это действие.", true, "Стрелок", 2, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7206) },
                    { 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7207), "Эльфы тесно связаны с природой. Они не тревожат животных — любой зверь, встреченный эльфом, будет относиться к нему дружелюбно и не нападёт без провокации. Эльфы также способны автоматически находить любые обычные и повсеместные субстанции растительного происхождения, если искомые растения обитают в природе на данной территории", true, "Единение с природой", 2, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7207) },
                    { 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7208), "У краснолюдов весьма крепкая кожа, имеющая врождённую прочность 2. Данная величина прибавляется к прочности любой брони и не может быть понижена разрушающим уроном.", true, "Закаленный", 3, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7209) },
                    { 9, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7210), "Благодаря невысокому росту и склонности к тяжелой работе, требующей физических усилий, краснолюды получают +1 к Силе и повышают свое значение Переносимого веса на 25.", true, "Силач", 3, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7210) },
                    { 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7211), "Краснолюды - прекрасные оценщики, обладающие вниманием к деталям, а потому обмануть их весьма трудно. Краснолюды получают врожденный бонус +1 к Торговле.", true, "Наметанный глаз", 3, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7212) },
                    { 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7213), "В мире, где нелюдям не доверяют, людям довериться куда проще. У людей есть врожденный бонус +1 к проверкам Харизмы, Соблазнения и Убеждения против других людей.", true, "Доверие", 4, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7214) },
                    { 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7215), "Люди умны и зачастую находят великолепные решения сложных проблем. Люди получают врожденный бонус +1 к Дедукции.", true, "Изобретательность", 4, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7215) },
                    { 13, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7216), "Одно из величайших преимуществ человеческой расы — нежелание отступать даже в опасной ситуации. Они могут собраться с духом и перебросить неудачный результат проверки Сопротивления убеждению или Храбрости, но не более 3 раз за игровую партию. В таком случае из двух результатов выбирают наивысший, но если результат всё равно провальный, то вновь использовать Упрямство нельзя.", true, "Упрямство", 4, 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7217) }
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
                columns: new[] { "Id", "AdditionalInformation", "Armor", "AthleticsBase", "BlockBase", "Complexity", "CreateDate", "Description", "EducationSkill", "Enabled", "EvasionBase", "GroupSize", "HabitatPlace", "Height", "Intellect", "MoneyReward", "MonsterLoreInformation", "MonsterLoreSkill", "Name", "RaceId", "Regeneration", "SkillsListId", "SourceId", "SpellResistBase", "StatsListId", "SuperstitionsInformation", "UpdateDate", "Weight" },
                values: new object[] { 1, "", 5, 9, 12, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7390), "", 8, true, 10, "Банда из 3-15 разбойников", "Часто рядом с городами и на трактах", 180, "Человеческий", 10, "Разбойники — одна из самых распространённых угроз на дороге, но отнюдь не самая опасная. Куда тяжелее скинуть с себя гуля, чем расправиться с парочкой разбойников. Но порой они могут представлять настоящую угрозу, особенно когда их много. Большая часть разбойников — это солдаты без армии, наёмники без контракта или дезертиры, которые покинули одну из воюющих сторон. Разбойники просты. Первые ряды побегут с полуторными мечами наголо. Те, кто на такое не способен, воспользуются арбалетами. Разбойникам обычно нужны три вещи: безопасность, деньги и что-нибудь, на чём можно выместить свой гнев. С ними не то чтобы просто расправиться, но, в отличие от большинства чудовищ, можно воззвать к их разуму. Возможно, вы сумеете убедить их не убивать вас. Разбойники, скорее всего, сдадутся, если вы нанесёте им достаточно урона.\r\nОднако некоторые разбойники, странствующие крепко сбитыми группами, могут начать сражаться яростнее, если убить их товарищей. На истерзанном войной Севере стоит быть осторожнее: нехватка пищи заставила некоторых разбойников стать каннибалами. Каннибалы зачастую сходят с ума и нападают с бешеной яростью — они не сдаются, даже стоя одной ногой в могиле. Если не хотите драться, будьте внимательны на дороге. =", 10, "Разбойник", 4, 0, 1, 1, 8, 1, "Хе, разбойники, дезертиры, ренегаты, сукины дети... Называй их как хочешь. Люди ступают на преступный путь ради денег и власти, но в большинстве своём они делают это от страха и голода. Все знают, что уровень преступности растёт во время войны. Так было в прошлых двух войнах, и вот сейчас опять. Но это не значит, что простой народ с этим согласен. Хех, не говорите это в лицо убийце, но среднестатистический ублюдок о бандите того же мнения, что и о гуле. И те, и другие прячутся по грязным закоулкам мира, ждут момента, чтобы напасть, и устраивают засаду на добрых трудяг, чтобы отобрать заработанное кровью и потом.", new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(7391), 80f });

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
                    { 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6439), "", true, false, false, "Внимание", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6439) },
                    { 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6440), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6441) },
                    { 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6442), "", true, false, false, "Дедукция", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6442) },
                    { 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6443), "", true, false, true, "Монстрология", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6444) },
                    { 5, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6445), "", true, false, false, "Образование", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6445) },
                    { 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6446), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6447) },
                    { 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6448), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6448) },
                    { 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6449), "", true, false, true, "Тактика", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6449) },
                    { 9, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6450), "", true, false, false, "Торговля", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6451) },
                    { 10, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6453), "", true, false, false, "Этикет", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6454) },
                    { 11, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6455), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6455) },
                    { 12, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6456), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6456) },
                    { 13, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6458), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6458) },
                    { 14, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6459), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6459) },
                    { 15, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6460), "", true, false, false, "Борьба", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6461) },
                    { 16, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6463), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6463) },
                    { 17, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6464), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6464) },
                    { 18, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6466), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6466) },
                    { 19, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6468), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6468) },
                    { 20, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6469), "", true, false, false, "Мореходство", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6469) },
                    { 21, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6471), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6471) },
                    { 22, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6472), "", true, false, false, "Атлетика", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6472) },
                    { 23, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6473), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6474) },
                    { 24, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6475), "", true, false, false, "Скрытность", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6475) },
                    { 25, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6476), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6477) },
                    { 26, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6478), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6478) },
                    { 27, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6479), "", true, false, false, "Сила", 1, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6479) },
                    { 28, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6481), "", true, false, false, "Стойкость", 1, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6481) },
                    { 29, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6482), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6482) },
                    { 30, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6483), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6484) },
                    { 31, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6485), "", true, false, false, "Выступление", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6485) },
                    { 32, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6487), "", true, false, false, "Искусство", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6487) },
                    { 33, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6489), "", true, false, false, "Лидерство", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6489) },
                    { 34, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6490), "", true, false, false, "Обман", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6490) },
                    { 35, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6491), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6492) },
                    { 36, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6493), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6493) },
                    { 37, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6494), "", true, false, false, "Убеждение", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6494) },
                    { 38, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6496), "", true, false, false, "Харизма", 1, 6, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6496) },
                    { 39, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6497), "", true, false, true, "Алхимия", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6497) },
                    { 40, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6498), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6499) },
                    { 41, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6500), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6500) },
                    { 42, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6502), "", true, false, true, "Изготовление", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6502) },
                    { 43, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6503), "", true, false, false, "Маскировка", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6503) },
                    { 44, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6504), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6505) },
                    { 45, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6506), "", true, false, false, "Подделывание", 1, 7, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6506) },
                    { 46, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6507), "", true, false, false, "Запугивание", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6507) },
                    { 47, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6509), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6509) },
                    { 48, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6511), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6511) },
                    { 49, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6512), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6512) },
                    { 50, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6514), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6514) },
                    { 51, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6515), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6515) },
                    { 52, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6516), "", true, false, false, "Храбрость", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6517) },
                    { 53, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6518), "Большинство ведьмаков проводят детство и юность в крепости, корпя над пыльными томами и проходя чудовищные боевые тренировки. Многие говорят, что главное оружие ведьмака — это знания о чудовищах и умение найти выход из любой ситуации. Находясь в опасной среде или на пересечённой местности, ведьмак может снизить соответствующие штрафы на половину значения своего навыка Подготовка ведьмака (минимум 1). Подготовку ведьмака также можно использовать в любой ситуации, где понадобился бы навык Монстрология.", true, true, false, "Подготовка ведьмака", 1, 1, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6518) },
                    { 56, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6522), "Когда ведьмак становится целью заклинания, инвокации или порчи, он может совершить проверку способности Гелиотроп, чтобы попытаться отменить эффект. Он должен выкинуть результат, который больше либо равен результату его противника, а также потратить количество Выносливости, равное половине Выносливости, затраченной на сотворение магии.", true, true, false, "Гелиотроп", 1, 8, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6522) },
                    { 59, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6526), "Принимая отвар, ведьмак может совершить проверку Трансмутации со СЛ 18. При успехе тело ведьмака принимает в себя несколько больше мутагена, чем обычно, что позволяет получить бонус в зависимости от принятого отвара (см. таблицу на полях). Длительность действия отвара уменьшается вдвое. Дополнительные мутации слишком малы, чтобы их заметить.", true, true, false, "Трансмутация", 1, 4, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6527) },
                    { 60, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6528), "Ведьмак может совершить проверку этой способности со штрафом -3, чтобы отбить летящий физический снаряд. При отбивании ведьмак может выбрать цель в пределах 10 м. Эта цель должна совершить действие защиты против броска Отбивания стрел ведьмака, или она будет ошеломлена из-за попадания отбитого снаряда.", true, true, false, "Отбивание стрел", 1, 3, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6528) },
                    { 61, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6530), "Закончив свой ход, ведьмак может потратить 5 очков Вын и совершить проверку Быстрого удара со СЛ, равной Реа противника хЗ. При успехе ведьмак совершает ещё одну атаку в этот раунд против этого противника, которая может включать в себя разоружение, подсечку и прочие атаки.", true, true, false, "Быстрый удар", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6530) },
                    { 62, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6533), "Потратив 5 очков Вын за раунд, ведьмак может закрутиться в Вихре, совершая каждый ход по одной атаке против всех, кто находится в пределах дистанции его меча. Проверка Вихрясчитается проверкой атаки. Находясь в Вихре, ведьмак может только поддерживать его, уклоняться и передвигаться на 2 метра за раунд. Любое другое действие или полученный удар прекращают Вихрь.", true, true, false, "Вихрь", 1, 2, new DateTime(2024, 4, 3, 15, 25, 51, 69, DateTimeKind.Local).AddTicks(6533) }
                });

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
                table: "FormulaComponentList",
                columns: new[] { "Id", "Amount", "FormulaId", "SubstanceType" },
                values: new object[,]
                {
                    { 1, 1, 87, 3 },
                    { 2, 1, 87, 4 }
                });

            migrationBuilder.InsertData(
                table: "SpellSkillProtectionList",
                columns: new[] { "Id", "SkillId", "SpellId" },
                values: new object[,]
                {
                    { 1, 14, null },
                    { 2, 17, null },
                    { 3, 18, null },
                    { 4, 19, null },
                    { 5, 21, null }
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
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "IX_CreatureRewardList_CreatureId",
                table: "CreatureRewardList",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_ItemBaseId",
                table: "CreatureRewardList",
                column: "ItemBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_RewardId",
                table: "CreatureRewardList",
                column: "RewardId");

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
                name: "Reward");

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
                name: "Races");

            migrationBuilder.DropTable(
                name: "SkillsList");

            migrationBuilder.DropTable(
                name: "StatsList");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
