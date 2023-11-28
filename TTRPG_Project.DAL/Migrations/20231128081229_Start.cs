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
                    { 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5599), true, "Базовая книга", new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5608) },
                    { 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5609), true, "Хоумбрю", new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5610) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5899), "", true, "Незаметное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5899) },
                    { 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5900), "", true, "Кровопускающее", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5900) },
                    { 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5901), "", true, "Пробивающее броню", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5901) },
                    { 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5902), "", true, "Дезориентирующее(1)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5902) },
                    { 5, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5903), "", true, "Дезориентирующее(2)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5903) },
                    { 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5904), "", true, "Дезориентирующее(3)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5905) },
                    { 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5905), "", true, "Метеоритное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5906) },
                    { 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5907), "", true, "Длинное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5907) },
                    { 9, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5908), "", true, "Фокусирующее(1)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5908) },
                    { 10, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5909), "", true, "Фокусирующее(2)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5909) },
                    { 11, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5910), "", true, "Фокусирующее(3)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5910) },
                    { 12, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5911), "", true, "Сокрушающая сила", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5911) },
                    { 13, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5912), "", true, "Серебрянное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5912) },
                    { 14, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5913), "", true, "Сбалансированное(1)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5913) },
                    { 15, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5914), "", true, "Сбалансированное(2)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5914) },
                    { 16, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5915), "", true, "Сбалансированное(3)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5916) },
                    { 17, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5916), "", true, "Улучшенное пробивание брони", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5917) },
                    { 18, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5918), "", true, "Захватное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5918) },
                    { 19, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5919), "", true, "Ловящий лезвия", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5919) },
                    { 20, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5920), "", true, "Магические путы", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5920) },
                    { 21, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5921), "", true, "Медленно перезаряжающееся", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5921) },
                    { 22, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5922), "", true, "Несмертельное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5922) },
                    { 23, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5923), "", true, "Опутывающее", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5923) },
                    { 24, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5924), "", true, "Парирующее", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5924) },
                    { 25, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5925), "", true, "Разрушающее", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5926) },
                    { 26, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5926), "", true, "Рукопашное", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5927) },
                    { 27, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5927), "", true, "Расчетная перезарядка", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5928) },
                    { 28, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5929), "", true, "Улучшенное фокусирующее", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5929) },
                    { 29, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5930), "", true, "Устанавливаемое", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5930) },
                    { 30, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5931), "", true, "Шприц", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5932) },
                    { 31, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5933), "", true, "Закрывает все тело", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5933) },
                    { 32, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5934), "", true, "Огнеупорный", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5934) },
                    { 33, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5935), "", true, "Ограничение зрения", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5935) },
                    { 34, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5936), "", true, "Полное укрытие", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5936) },
                    { 35, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5937), "", true, "Сопротивление(Д)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5937) },
                    { 36, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5938), "", true, "Сопротивление(Р)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5938) },
                    { 37, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5939), "", true, "Сопротивление(К)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5939) },
                    { 38, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5940), "", true, "Сопротивление(С)", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5940) },
                    { 39, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5941), "", true, "Горение", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5941) },
                    { 40, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5942), "", true, "Дезориентация", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5942) },
                    { 41, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5943), "", true, "Отравление", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5944) },
                    { 42, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5944), "", true, "Кровотечение", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5945) },
                    { 43, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5962), "", true, "Замораживание", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5963) },
                    { 44, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5964), "", true, "Ошеломление", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5964) },
                    { 45, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5965), "", true, "Опьянение", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5965) },
                    { 46, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5966), "", true, "Галлюцинации", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5966) },
                    { 47, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5967), "", true, "Тошнота", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5968) },
                    { 48, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5969), "", true, "Удушье", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5969) },
                    { 49, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5970), "", true, "Слепота", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5970) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5985), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "Обезболивающие травы", 12, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5985), 0.10000000000000001 },
                    { 2, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5998), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "Капюшон вердэнского лучника", 100, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5999), 0.5 },
                    { 3, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6039), "", true, "Пепел", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6039), 0.10000000000000001 },
                    { 4, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6046), "", true, "Уголь", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6046), 0.10000000000000001 },
                    { 5, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6051), "", true, "Хлопок", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6052), 0.10000000000000001 },
                    { 6, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6055), "", true, "Двойное полотно", 22, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6055), 0.10000000000000001 },
                    { 7, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6057), "", true, "Стекло", 5, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6057), 0.5 },
                    { 8, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6059), "", true, "Укрепленное дерево", 16, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6060), 0.10000000000000001 },
                    { 9, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6062), "", true, "Полотно", 9, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6063), 0.10000000000000001 },
                    { 10, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6065), "", true, "Масло", 3, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6065), 0.10000000000000001 },
                    { 11, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6067), "", true, "Смлоа", 2, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6067), 0.10000000000000001 },
                    { 12, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6069), "", true, "Шелк", 50, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6069), 0.10000000000000001 },
                    { 13, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6072), "", true, "Нитки", 3, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6072), 0.10000000000000001 },
                    { 14, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6074), "", true, "Древесина", 3, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6074), 1.0 },
                    { 15, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6076), "", true, "Воск", 2, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6076), 0.10000000000000001 },
                    { 16, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6078), "", true, "Кости животных", 8, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6078), 4.0 },
                    { 17, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6081), "", true, "Коровья шкура", 10, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6081), 5.0 },
                    { 18, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6083), "", true, "Кожа драконида", 58, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6083), 5.0 },
                    { 19, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6085), "", true, "Чешуя драконида", 30, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6085), 5.0 },
                    { 20, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6105), "", true, "Перья", 4, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6106), 0.10000000000000001 },
                    { 21, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6108), "", true, "Укрепленная кожа", 48, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6108), 3.0 },
                    { 22, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6110), "", true, "Кожа", 28, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6111), 2.0 },
                    { 23, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6112), "", true, "Лирийская кожа", 60, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6113), 2.0 },
                    { 24, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6115), "", true, "Волчья шкура", 14, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6115), 3.0 },
                    { 25, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6117), "", true, "Чернящее масло", 24, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6118), 0.10000000000000001 },
                    { 26, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6120), "", true, "Масло из дрейка", 45, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6120), 0.10000000000000001 },
                    { 27, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6123), "", true, "Эфирная смазка", 8, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6123), 0.10000000000000001 },
                    { 28, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6125), "", true, "Травильная кислота", 2, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6126), 0.10000000000000001 },
                    { 29, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6129), "", true, "Пятая эссенция", 82, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6130), 0.10000000000000001 },
                    { 30, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6133), "", true, "Огров воск", 10, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6134), 0.10000000000000001 },
                    { 31, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6136), "", true, "Точильный порошок", 32, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6136), 0.10000000000000001 },
                    { 32, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6138), "", true, "Дубильные травы", 3, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6138), 0.10000000000000001 },
                    { 33, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6140), "", true, "Темное железо", 52, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6140), 1.5 },
                    { 34, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6143), "", true, "Темная сталь", 82, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6143), 1.0 },
                    { 35, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6145), "", true, "Двимерит", 240, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6145), 1.0 },
                    { 36, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6147), "", true, "Самоцветы", 100, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6148), 0.10000000000000001 },
                    { 37, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6150), "", true, "Совершенный самоцвет", 1000, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6150), 0.10000000000000001 },
                    { 38, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6152), "", true, "Светящаяся руда", 80, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6152), 1.0 },
                    { 39, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6155), "", true, "Золото", 85, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6155), 1.0 },
                    { 40, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6157), "", true, "Железо", 30, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6158), 1.5 },
                    { 41, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6160), "", true, "Махакамский двимерит", 300, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6160), 1.0 },
                    { 42, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6162), "", true, "Махакамская сталь", 114, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6162), 1.0 },
                    { 43, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6164), "", true, "Метеорит", 98, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6165), 1.0 },
                    { 44, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6167), "", true, "Речная глина", 5, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6167), 1.5 },
                    { 45, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6169), "", true, "Серебро", 72, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6169), 1.0 },
                    { 46, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6171), "", true, "Сталь", 48, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6171), 1.0 },
                    { 47, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6173), "", true, "Камень", 4, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6174), 2.0 },
                    { 48, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6176), "", true, "Третогорская сталь", 64, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6176), 1.0 },
                    { 49, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6179), "", true, "Зерриканская смесь", 30, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6179), 0.10000000000000001 },
                    { 50, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6223), "", true, "Капюшон вердэнского лучника", 150, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6223), 0.0 },
                    { 51, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6257), "", true, "Обезболивающие травы", 0, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6257), 1.0 },
                    { 52, 0, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6285), "Всегда с собой таскай верёвку.Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "Веревка (20 метров)", 20, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6285), 1.5 },
                    { 53, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6297), "Позволяют создавать алхимические составы", true, "Инструменты алхимика", 80, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6297), 3.0 },
                    { 54, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6309), "", true, "Стилет", 275, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(6309), 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5744), "", true, "Интеллект", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5745) },
                    { 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5746), "", true, "Реакция", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5747) },
                    { 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5748), "", true, "Ловкость", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5748) },
                    { 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5749), "", true, "Телосложение", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5749) },
                    { 5, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5750), "", true, "Скорость", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5750) },
                    { 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5751), "", true, "Эмпатия", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5752) },
                    { 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5753), "", true, "Ремесло", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5753) },
                    { 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5754), "", true, "Воля", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5754) },
                    { 9, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5755), "", true, "Удача", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5755) },
                    { 10, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5756), "", true, "Энергия", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5756) },
                    { 11, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5757), "", true, "Устойчивость", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5757) },
                    { 12, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5758), "", true, "Бег", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5758) },
                    { 13, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5759), "", true, "Прыжок", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5760) },
                    { 14, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5760), "", true, "Пункты Здоровья", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5761) },
                    { 15, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5761), "", true, "Выносливость", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5762) },
                    { 16, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5763), "", true, "Переносимый вес", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5763) },
                    { 17, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5764), "", true, "Отдых", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5764) },
                    { 18, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5765), "", true, "Удар рукой", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5765) },
                    { 19, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5766), "", true, "Удар ногой", 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5766) }
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
                    { 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5785), "", true, false, false, "Внимание", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5785) },
                    { 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5788), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5788) },
                    { 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5789), "", true, false, false, "Дедукция", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5789) },
                    { 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5791), "", true, false, true, "Монстрология", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5791) },
                    { 5, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5792), "", true, false, false, "Образование", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5792) },
                    { 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5793), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5794) },
                    { 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5795), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5795) },
                    { 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5796), "", true, false, true, "Тактика", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5796) },
                    { 9, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5798), "", true, false, false, "Торговля", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5798) },
                    { 10, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5799), "", true, false, false, "Этикет", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5799) },
                    { 11, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5800), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5801) },
                    { 12, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5802), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5802) },
                    { 13, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5803), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5803) },
                    { 14, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5805), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5805) },
                    { 15, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5825), "", true, false, false, "Борьба", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5826) },
                    { 16, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5827), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5827) },
                    { 17, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5828), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5829) },
                    { 18, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5830), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5830) },
                    { 19, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5831), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5831) },
                    { 20, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5833), "", true, false, false, "Мореходство", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5833) },
                    { 21, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5834), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5834) },
                    { 22, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5836), "", true, false, false, "Атлетика", 1, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5836) },
                    { 23, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5838), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5838) },
                    { 24, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5839), "", true, false, false, "Скрытность", 1, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5839) },
                    { 25, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5840), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5841) },
                    { 26, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5842), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5842) },
                    { 27, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5843), "", true, false, false, "Сила", 1, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5843) },
                    { 28, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5844), "", true, false, false, "Стойкость", 1, 4, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5845) },
                    { 29, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5846), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5846) },
                    { 30, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5847), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5847) },
                    { 31, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5849), "", true, false, false, "Выступление", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5849) },
                    { 32, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5850), "", true, false, false, "Искусство", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5850) },
                    { 33, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5851), "", true, false, false, "Лидерство", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5852) },
                    { 34, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5853), "", true, false, false, "Обман", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5853) },
                    { 35, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5854), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5854) },
                    { 36, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5856), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5856) },
                    { 37, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5857), "", true, false, false, "Убеждение", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5857) },
                    { 38, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5858), "", true, false, false, "Харизма", 1, 6, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5858) },
                    { 39, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5860), "", true, false, true, "Алхимия", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5860) },
                    { 40, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5862), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5862) },
                    { 41, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5863), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5864) },
                    { 42, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5865), "", true, false, true, "Изготовление", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5865) },
                    { 43, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5866), "", true, false, false, "Маскировка", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5866) },
                    { 44, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5867), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5868) },
                    { 45, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5869), "", true, false, false, "Подделывание", 1, 7, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5869) },
                    { 46, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5870), "", true, false, false, "Запугивание", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5870) },
                    { 47, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5871), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5872) },
                    { 48, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5873), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5873) },
                    { 49, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5874), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5874) },
                    { 50, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5876), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5876) },
                    { 51, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5877), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5877) },
                    { 52, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5878), "", true, false, false, "Храбрость", 1, 8, new DateTime(2023, 11, 28, 15, 12, 29, 425, DateTimeKind.Local).AddTicks(5879) }
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
                columns: new[] { "Id", "Amount", "FormulaId", "SubstanceType" },
                values: new object[,]
                {
                    { 1, 1, 51, 3 },
                    { 2, 1, 51, 4 }
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
