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
                    AttentionId = table.Column<int>(type: "int", nullable: false),
                    AttentionValue = table.Column<int>(type: "int", nullable: false),
                    SurvivalId = table.Column<int>(type: "int", nullable: false),
                    SurvivalValue = table.Column<int>(type: "int", nullable: false),
                    DeductionId = table.Column<int>(type: "int", nullable: false),
                    DeductionValue = table.Column<int>(type: "int", nullable: false),
                    MonsterologyId = table.Column<int>(type: "int", nullable: false),
                    MonsterologyValue = table.Column<int>(type: "int", nullable: false),
                    EducationId = table.Column<int>(type: "int", nullable: false),
                    EducationValue = table.Column<int>(type: "int", nullable: false),
                    CityOrientationId = table.Column<int>(type: "int", nullable: false),
                    CityOrientationValue = table.Column<int>(type: "int", nullable: false),
                    KnowledgeTransferId = table.Column<int>(type: "int", nullable: false),
                    KnowledgeTransferValue = table.Column<int>(type: "int", nullable: false),
                    TacticsId = table.Column<int>(type: "int", nullable: false),
                    TacticsValue = table.Column<int>(type: "int", nullable: false),
                    TradingId = table.Column<int>(type: "int", nullable: false),
                    TradingValue = table.Column<int>(type: "int", nullable: false),
                    EtiquetteId = table.Column<int>(type: "int", nullable: false),
                    EtiquetteValue = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    LanguageValue = table.Column<int>(type: "int", nullable: false),
                    StrengthId = table.Column<int>(type: "int", nullable: false),
                    StrengthValue = table.Column<int>(type: "int", nullable: false),
                    EnduranceId = table.Column<int>(type: "int", nullable: false),
                    EnduranceValue = table.Column<int>(type: "int", nullable: false),
                    MeleeCombatId = table.Column<int>(type: "int", nullable: false),
                    MeleeCombatValue = table.Column<int>(type: "int", nullable: false),
                    WrestlingId = table.Column<int>(type: "int", nullable: false),
                    WrestlingValue = table.Column<int>(type: "int", nullable: false),
                    RidingId = table.Column<int>(type: "int", nullable: false),
                    RidingValue = table.Column<int>(type: "int", nullable: false),
                    PoleWeaponMasteryId = table.Column<int>(type: "int", nullable: false),
                    PoleWeaponMasteryValue = table.Column<int>(type: "int", nullable: false),
                    LightBladeMasteryId = table.Column<int>(type: "int", nullable: false),
                    LightBladeMasteryValue = table.Column<int>(type: "int", nullable: false),
                    SwordsmanshipId = table.Column<int>(type: "int", nullable: false),
                    SwordsmanshipValue = table.Column<int>(type: "int", nullable: false),
                    SeamanshipId = table.Column<int>(type: "int", nullable: false),
                    SeamanshipValue = table.Column<int>(type: "int", nullable: false),
                    EvasionId = table.Column<int>(type: "int", nullable: false),
                    EvasionValue = table.Column<int>(type: "int", nullable: false),
                    AthleticsId = table.Column<int>(type: "int", nullable: false),
                    AthleticsValue = table.Column<int>(type: "int", nullable: false),
                    ManualDexterityId = table.Column<int>(type: "int", nullable: false),
                    ManualDexterityValue = table.Column<int>(type: "int", nullable: false),
                    StealthId = table.Column<int>(type: "int", nullable: false),
                    StealthValue = table.Column<int>(type: "int", nullable: false),
                    CrossbowMasteryId = table.Column<int>(type: "int", nullable: false),
                    CrossbowMasteryValue = table.Column<int>(type: "int", nullable: false),
                    ArcheryId = table.Column<int>(type: "int", nullable: false),
                    ArcheryValue = table.Column<int>(type: "int", nullable: false),
                    GamblingId = table.Column<int>(type: "int", nullable: false),
                    GamblingValue = table.Column<int>(type: "int", nullable: false),
                    AppearanceId = table.Column<int>(type: "int", nullable: false),
                    AppearanceValue = table.Column<int>(type: "int", nullable: false),
                    PublicSpeakingId = table.Column<int>(type: "int", nullable: false),
                    PublicSpeakingValue = table.Column<int>(type: "int", nullable: false),
                    ArtistryId = table.Column<int>(type: "int", nullable: false),
                    ArtistryValue = table.Column<int>(type: "int", nullable: false),
                    LeadershipId = table.Column<int>(type: "int", nullable: false),
                    LeadershipValue = table.Column<int>(type: "int", nullable: false),
                    DeceptionId = table.Column<int>(type: "int", nullable: false),
                    DeceptionValue = table.Column<int>(type: "int", nullable: false),
                    UnderstandingPeopleId = table.Column<int>(type: "int", nullable: false),
                    UnderstandingPeopleValue = table.Column<int>(type: "int", nullable: false),
                    SeductionId = table.Column<int>(type: "int", nullable: false),
                    SeductionValue = table.Column<int>(type: "int", nullable: false),
                    PersuasionId = table.Column<int>(type: "int", nullable: false),
                    PersuasionValue = table.Column<int>(type: "int", nullable: false),
                    CharismaId = table.Column<int>(type: "int", nullable: false),
                    CharismaValue = table.Column<int>(type: "int", nullable: false),
                    AlchemyId = table.Column<int>(type: "int", nullable: false),
                    AlchemyValue = table.Column<int>(type: "int", nullable: false),
                    LockpickingId = table.Column<int>(type: "int", nullable: false),
                    LockpickingValue = table.Column<int>(type: "int", nullable: false),
                    TrapKnowledgeId = table.Column<int>(type: "int", nullable: false),
                    TrapKnowledgeValue = table.Column<int>(type: "int", nullable: false),
                    ManufacturingId = table.Column<int>(type: "int", nullable: false),
                    ManufacturingValue = table.Column<int>(type: "int", nullable: false),
                    CamouflageId = table.Column<int>(type: "int", nullable: false),
                    CamouflageValue = table.Column<int>(type: "int", nullable: false),
                    FirstAidId = table.Column<int>(type: "int", nullable: false),
                    FirstAidValue = table.Column<int>(type: "int", nullable: false),
                    ForgeryId = table.Column<int>(type: "int", nullable: false),
                    ForgeryValue = table.Column<int>(type: "int", nullable: false),
                    IntimidationId = table.Column<int>(type: "int", nullable: false),
                    IntimidationValue = table.Column<int>(type: "int", nullable: false),
                    SpellcastingId = table.Column<int>(type: "int", nullable: false),
                    SpellcastingValue = table.Column<int>(type: "int", nullable: false),
                    RitualsId = table.Column<int>(type: "int", nullable: false),
                    RitualsValue = table.Column<int>(type: "int", nullable: false),
                    MagicResistanceId = table.Column<int>(type: "int", nullable: false),
                    MagicResistanceValue = table.Column<int>(type: "int", nullable: false),
                    PersuasionResistanceId = table.Column<int>(type: "int", nullable: false),
                    PersuasionResistanceValue = table.Column<int>(type: "int", nullable: false),
                    CourageId = table.Column<int>(type: "int", nullable: false),
                    CourageValue = table.Column<int>(type: "int", nullable: false),
                    ClassSkill = table.Column<int>(type: "int", nullable: true),
                    ClassSkillValue = table.Column<int>(type: "int", nullable: false),
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
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Energy = table.Column<int>(type: "int", nullable: false),
                    DefaultMagicAbilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Classes_Sources_SourceId",
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
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnduranceCost = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Spells_Sources_SourceId",
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
                name: "Creatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
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
                name: "SkillsTree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_SkillsTree_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SkillsTree_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
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
                name: "SpellSkillProtectionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellId = table.Column<int>(type: "int", nullable: true),
                    EffectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSkillProtectionList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpellSkillProtectionList_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpellSkillProtectionList_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
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
                    StatId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Abilities_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
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
                name: "Attacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    AttackType = table.Column<int>(type: "int", nullable: false),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    AttackSpeed = table.Column<int>(type: "int", nullable: false),
                    AttackEffectListId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Attacks_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attacks_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatureEffectList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    EffectID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    ChancePercent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureEffectList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CreatureEffectList_Creatures_CreatureId",
                        column: x => x.CreatureId,
                        principalTable: "Creatures",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CreatureEffectList_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CreatureRewardList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatureId = table.Column<int>(type: "int", nullable: true),
                    ItemBaseId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "CreatureSpell",
                columns: table => new
                {
                    CreaturesId = table.Column<int>(type: "int", nullable: false),
                    SpellsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatureSpell", x => new { x.CreaturesId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_CreatureSpell_Creatures_CreaturesId",
                        column: x => x.CreaturesId,
                        principalTable: "Creatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CreatureSpell_Spells_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "FormulaComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormulaId = table.Column<int>(type: "int", nullable: true),
                    SubstanceType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ComponentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaComponentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormulaComponentList_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormulaComponentList_Formulas_FormulaId",
                        column: x => x.FormulaId,
                        principalTable: "Formulas",
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

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreateDate", "Enabled", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(4780), true, "Базовая книга", new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(4790) },
                    { 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(4792), true, "Хоумбрю", new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(4792) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5259), "", true, "Незаметное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5260) },
                    { 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5261), "", true, "Кровопускающее", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5261) },
                    { 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5262), "", true, "Пробивающее броню", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5262) },
                    { 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5263), "", true, "Дезориентирующее(1)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5263) },
                    { 5, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5264), "", true, "Дезориентирующее(2)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5264) },
                    { 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5265), "", true, "Дезориентирующее(3)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5266) },
                    { 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5266), "", true, "Метеоритное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5267) },
                    { 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5268), "", true, "Длинное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5268) },
                    { 9, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5269), "", true, "Фокусирующее(1)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5269) },
                    { 10, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5270), "", true, "Фокусирующее(2)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5270) },
                    { 11, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5271), "", true, "Фокусирующее(3)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5271) },
                    { 12, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5272), "", true, "Сокрушающая сила", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5272) },
                    { 13, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5273), "", true, "Серебрянное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5274) },
                    { 14, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5275), "", true, "Сбалансированное(1)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5275) },
                    { 15, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5276), "", true, "Сбалансированное(2)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5276) },
                    { 16, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5277), "", true, "Сбалансированное(3)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5277) },
                    { 17, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5278), "", true, "Улучшенное пробивание брони", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5278) },
                    { 18, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5279), "", true, "Захватное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5279) },
                    { 19, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5280), "", true, "Ловящий лезвия", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5281) },
                    { 20, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5281), "", true, "Магические путы", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5282) },
                    { 21, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5283), "", true, "Медленно перезаряжающееся", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5283) },
                    { 22, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5284), "", true, "Несмертельное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5284) },
                    { 23, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5285), "", true, "Опутывающее", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5285) },
                    { 24, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5286), "", true, "Парирующее", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5286) },
                    { 25, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5312), "", true, "Разрушающее", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5312) },
                    { 26, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5313), "", true, "Рукопашное", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5313) },
                    { 27, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5314), "", true, "Расчетная перезарядка", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5315) },
                    { 28, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5315), "", true, "Улучшенное фокусирующее", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5316) },
                    { 29, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5317), "", true, "Устанавливаемое", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5317) },
                    { 30, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5318), "", true, "Шприц", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5318) },
                    { 31, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5319), "", true, "Закрывает все тело", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5319) },
                    { 32, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5320), "", true, "Огнеупорный", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5320) },
                    { 33, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5321), "", true, "Ограничение зрения", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5322) },
                    { 34, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5322), "", true, "Полное укрытие", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5323) },
                    { 35, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5469), "", true, "Сопротивление(Д)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5469) },
                    { 36, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5470), "", true, "Сопротивление(Р)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5470) },
                    { 37, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5471), "", true, "Сопротивление(К)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5471) },
                    { 38, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5472), "", true, "Сопротивление(С)", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5473) },
                    { 39, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5473), "", true, "Горение", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5474) },
                    { 40, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5474), "", true, "Дезориентация", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5475) },
                    { 41, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5476), "", true, "Отравление", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5476) },
                    { 42, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5477), "", true, "Кровотечение", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5477) },
                    { 43, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5478), "", true, "Замораживание", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5478) },
                    { 44, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5479), "", true, "Ошеломление", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5479) },
                    { 45, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5480), "", true, "Опьянение", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5480) },
                    { 46, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5481), "", true, "Галлюцинации", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5481) },
                    { 47, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5482), "", true, "Тошнота", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5483) },
                    { 48, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5483), "", true, "Удушье", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5484) },
                    { 49, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5484), "", true, "Слепота", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5485) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5503), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "Обезболивающие травы", 12, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5504), 0.10000000000000001 },
                    { 2, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5521), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "Капюшон вердэнского лучника", 100, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5522), 0.5 },
                    { 3, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5575), "", true, "Пепел", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5575), 0.10000000000000001 },
                    { 4, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5586), "", true, "Уголь", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5586), 0.10000000000000001 },
                    { 5, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5592), "", true, "Хлопок", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5593), 0.10000000000000001 },
                    { 6, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5595), "", true, "Двойное полотно", 22, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5596), 0.10000000000000001 },
                    { 7, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5599), "", true, "Стекло", 5, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5600), 0.5 },
                    { 8, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5605), "", true, "Укрепленное дерево", 16, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5605), 0.10000000000000001 },
                    { 9, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5610), "", true, "Полотно", 9, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5610), 0.10000000000000001 },
                    { 10, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5612), "", true, "Масло", 3, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5612), 0.10000000000000001 },
                    { 11, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5638), "", true, "Смлоа", 2, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5639), 0.10000000000000001 },
                    { 12, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5641), "", true, "Шелк", 50, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5641), 0.10000000000000001 },
                    { 13, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5643), "", true, "Нитки", 3, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5644), 0.10000000000000001 },
                    { 14, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5646), "", true, "Древесина", 3, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5646), 1.0 },
                    { 15, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5648), "", true, "Воск", 2, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5648), 0.10000000000000001 },
                    { 16, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5651), "", true, "Кости животных", 8, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5651), 4.0 },
                    { 17, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5653), "", true, "Коровья шкура", 10, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5653), 5.0 },
                    { 18, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5655), "", true, "Кожа драконида", 58, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5656), 5.0 },
                    { 19, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5659), "", true, "Чешуя драконида", 30, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5659), 5.0 },
                    { 20, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5661), "", true, "Перья", 4, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5661), 0.10000000000000001 },
                    { 21, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5663), "", true, "Укрепленная кожа", 48, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5663), 3.0 },
                    { 22, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5666), "", true, "Кожа", 28, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5666), 2.0 },
                    { 23, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5668), "", true, "Лирийская кожа", 60, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5668), 2.0 },
                    { 24, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5670), "", true, "Волчья шкура", 14, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5671), 3.0 },
                    { 25, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5673), "", true, "Чернящее масло", 24, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5673), 0.10000000000000001 },
                    { 26, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5675), "", true, "Масло из дрейка", 45, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5675), 0.10000000000000001 },
                    { 27, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5678), "", true, "Эфирная смазка", 8, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5678), 0.10000000000000001 },
                    { 28, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5681), "", true, "Травильная кислота", 2, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5681), 0.10000000000000001 },
                    { 29, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5684), "", true, "Пятая эссенция", 82, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5685), 0.10000000000000001 },
                    { 30, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5688), "", true, "Огров воск", 10, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5688), 0.10000000000000001 },
                    { 31, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5690), "", true, "Точильный порошок", 32, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5691), 0.10000000000000001 },
                    { 32, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5693), "", true, "Дубильные травы", 3, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5693), 0.10000000000000001 },
                    { 33, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5696), "", true, "Темное железо", 52, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5696), 1.5 },
                    { 34, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5698), "", true, "Темная сталь", 82, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5699), 1.0 },
                    { 35, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5701), "", true, "Двимерит", 240, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5701), 1.0 },
                    { 36, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5703), "", true, "Самоцветы", 100, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5704), 0.10000000000000001 },
                    { 37, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5736), "", true, "Совершенный самоцвет", 1000, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5736), 0.10000000000000001 },
                    { 38, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5740), "", true, "Светящаяся руда", 80, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5740), 1.0 },
                    { 39, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5742), "", true, "Золото", 85, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5743), 1.0 },
                    { 40, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5745), "", true, "Железо", 30, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5745), 1.5 },
                    { 41, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5747), "", true, "Махакамский двимерит", 300, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5748), 1.0 },
                    { 42, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5750), "", true, "Махакамская сталь", 114, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5750), 1.0 },
                    { 43, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5752), "", true, "Метеорит", 98, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5753), 1.0 },
                    { 44, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5755), "", true, "Речная глина", 5, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5755), 1.5 },
                    { 45, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5757), "", true, "Серебро", 72, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5758), 1.0 },
                    { 46, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5760), "", true, "Сталь", 48, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5760), 1.0 },
                    { 47, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5763), "", true, "Камень", 4, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5763), 2.0 },
                    { 48, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5765), "", true, "Третогорская сталь", 64, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5765), 1.0 },
                    { 49, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5768), "", true, "Зерриканская смесь", 30, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5768), 0.10000000000000001 },
                    { 50, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5790), "", true, "Капюшон вердэнского лучника", 150, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5790), 0.0 },
                    { 51, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5826), "testFormula", true, "testFormula", 0, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5826), 1.0 },
                    { 52, 0, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5853), "Всегда с собой таскай верёвку.Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "Веревка (20 метров)", 20, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5853), 1.5 },
                    { 53, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5897), "Позволяют создавать алхимические составы", true, "Инструменты алхимика", 80, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5897), 3.0 },
                    { 54, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5911), "", true, "Стилет", 275, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5911), 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5059), "", true, "Интеллект", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5059) },
                    { 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5062), "", true, "Реакция", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5062) },
                    { 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5063), "", true, "Ловкость", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5063) },
                    { 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5064), "", true, "Телосложение", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5064) },
                    { 5, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5065), "", true, "Скорость", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5066) },
                    { 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5067), "", true, "Эмпатия", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5067) },
                    { 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5068), "", true, "Ремесло", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5068) },
                    { 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5069), "", true, "Воля", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5069) },
                    { 9, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5070), "", true, "Удача", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5071) },
                    { 10, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5071), "", true, "Энергия", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5072) },
                    { 11, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5073), "", true, "Устойчивость", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5073) },
                    { 12, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5074), "", true, "Бег", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5074) },
                    { 13, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5075), "", true, "Прыжок", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5075) },
                    { 14, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5076), "", true, "Пункты Здоровья", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5077) },
                    { 15, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5077), "", true, "Выносливость", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5078) },
                    { 16, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5079), "", true, "Переносимый вес", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5079) },
                    { 17, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5080), "", true, "Отдых", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5080) },
                    { 18, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5081), "", true, "Удар рукой", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5081) },
                    { 19, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5082), "", true, "Удар ногой", 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5082) }
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
                table: "Blueprints",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 50, 70, 10, 0, 3f });

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
                    { 49, "1к6/2", 18, false, 0, 0, "Горы и Под землей" }
                });

            migrationBuilder.InsertData(
                table: "Formulas",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 51, 1, 1, 0, 0f });

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
                values: new object[] { 52, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5145), "", true, false, false, "Внимание", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5145) },
                    { 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5149), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5149) },
                    { 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5151), "", true, false, false, "Дедукция", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5151) },
                    { 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5152), "", true, false, true, "Монстрология", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5152) },
                    { 5, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5153), "", true, false, false, "Образование", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5154) },
                    { 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5155), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5155) },
                    { 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5156), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5157) },
                    { 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5158), "", true, false, true, "Тактика", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5158) },
                    { 9, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5159), "", true, false, false, "Торговля", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5160) },
                    { 10, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5161), "", true, false, false, "Этикет", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5161) },
                    { 11, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5162), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5162) },
                    { 12, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5164), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5164) },
                    { 13, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5165), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5165) },
                    { 14, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5167), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5167) },
                    { 15, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5168), "", true, false, false, "Борьба", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5168) },
                    { 16, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5169), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5170) },
                    { 17, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5171), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5171) },
                    { 18, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5172), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5173) },
                    { 19, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5174), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5174) },
                    { 20, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5176), "", true, false, false, "Мореходство", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5176) },
                    { 21, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5182), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5182) },
                    { 22, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5183), "", true, false, false, "Атлетика", 1, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5184) },
                    { 23, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5185), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5185) },
                    { 24, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5186), "", true, false, false, "Скрытность", 1, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5186) },
                    { 25, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5189), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5189) },
                    { 26, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5190), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5191) },
                    { 27, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5192), "", true, false, false, "Сила", 1, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5192) },
                    { 28, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5193), "", true, false, false, "Стойкость", 1, 4, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5193) },
                    { 29, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5195), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5195) },
                    { 30, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5196), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5196) },
                    { 31, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5198), "", true, false, false, "Выступление", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5198) },
                    { 32, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5199), "", true, false, false, "Искусство", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5199) },
                    { 33, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5200), "", true, false, false, "Лидерство", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5201) },
                    { 34, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5202), "", true, false, false, "Обман", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5202) },
                    { 35, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5203), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5203) },
                    { 36, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5205), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5205) },
                    { 37, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5211), "", true, false, false, "Убеждение", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5211) },
                    { 38, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5212), "", true, false, false, "Харизма", 1, 6, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5212) },
                    { 39, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5213), "", true, false, true, "Алхимия", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5214) },
                    { 40, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5215), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5215) },
                    { 41, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5217), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5218) },
                    { 42, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5219), "", true, false, true, "Изготовление", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5219) },
                    { 43, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5220), "", true, false, false, "Маскировка", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5220) },
                    { 44, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5222), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5222) },
                    { 45, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5223), "", true, false, false, "Подделывание", 1, 7, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5223) },
                    { 46, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5224), "", true, false, false, "Запугивание", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5225) },
                    { 47, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5226), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5226) },
                    { 48, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5227), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5228) },
                    { 49, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5229), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5229) },
                    { 50, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5230), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5230) },
                    { 51, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5231), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5232) },
                    { 52, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5233), "", true, false, false, "Храбрость", 1, 8, new DateTime(2023, 11, 28, 14, 51, 0, 109, DateTimeKind.Local).AddTicks(5233) }
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "ItemType", "StealthType" },
                values: new object[] { 53, 0, 2 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Accuracy", "AmountOfEnhancements", "Damage", "Distance", "EquipmentType", "Grip", "IsAmmunition", "ItemType", "Reliability", "SkillId", "StealthType", "Type" },
                values: new object[] { 54, 1, 1, "1к6", 0, 0, 1, false, 0, 5, null, 4, 4 });

            migrationBuilder.InsertData(
                table: "BlueprintComponentList",
                columns: new[] { "Id", "Amount", "BlueprintId", "ComponentId" },
                values: new object[,]
                {
                    { 1, 2, 50, 9 },
                    { 2, 1, 50, 22 },
                    { 3, 6, 50, 13 },
                    { 4, 3, 50, 15 }
                });

            migrationBuilder.InsertData(
                table: "FormulaComponentList",
                columns: new[] { "Id", "Amount", "ComponentId", "FormulaId", "SubstanceType" },
                values: new object[,]
                {
                    { 1, 1, null, 51, 3 },
                    { 2, 1, null, 51, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abilities_CreatureId",
                table: "Abilities",
                column: "CreatureId");

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
                name: "IX_Attacks_CreatureId",
                table: "Attacks",
                column: "CreatureId");

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
                name: "IX_Classes_SourceId",
                table: "Classes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureEffectList_CreatureId",
                table: "CreatureEffectList",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureEffectList_EffectID",
                table: "CreatureEffectList",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_CreatureId",
                table: "CreatureRewardList",
                column: "CreatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CreatureRewardList_ItemBaseId",
                table: "CreatureRewardList",
                column: "ItemBaseId");

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
                name: "IX_CreatureSpell_SpellsId",
                table: "CreatureSpell",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SourceId",
                table: "Effects",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaComponentList_ComponentId",
                table: "FormulaComponentList",
                column: "ComponentId");

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
                name: "IX_SkillsTree_ClassId",
                table: "SkillsTree",
                column: "ClassId");

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
                name: "IX_Spells_SourceId",
                table: "Spells",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSkillProtectionList_EffectId",
                table: "SpellSkillProtectionList",
                column: "EffectId");

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
                name: "Abilities");

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
                name: "CreatureEffectList");

            migrationBuilder.DropTable(
                name: "CreatureRewardList");

            migrationBuilder.DropTable(
                name: "CreatureSpell");

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
                name: "SkillsTree");

            migrationBuilder.DropTable(
                name: "SpellComponentList");

            migrationBuilder.DropTable(
                name: "SpellSkillProtectionList");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Blueprints");

            migrationBuilder.DropTable(
                name: "Formulas");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "ItemBases");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "SkillsList");

            migrationBuilder.DropTable(
                name: "StatsList");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
