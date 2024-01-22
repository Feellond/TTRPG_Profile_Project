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
                    { 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9089), true, "Базовая книга", new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9098) },
                    { 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9100), true, "Хоумбрю", new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9100) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9388), "", true, "Незаметное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9389) },
                    { 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9390), "", true, "Кровопускающее", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9390) },
                    { 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9391), "", true, "Пробивающее броню", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9391) },
                    { 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9392), "", true, "Дезориентирующее(1)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9392) },
                    { 5, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9393), "", true, "Дезориентирующее(2)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9393) },
                    { 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9394), "", true, "Дезориентирующее(3)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9395) },
                    { 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9395), "", true, "Метеоритное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9396) },
                    { 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9397), "", true, "Длинное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9397) },
                    { 9, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9398), "", true, "Фокусирующее(1)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9398) },
                    { 10, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9399), "", true, "Фокусирующее(2)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9399) },
                    { 11, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9400), "", true, "Фокусирующее(3)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9400) },
                    { 12, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9401), "", true, "Сокрушающая сила", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9402) },
                    { 13, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9402), "", true, "Серебрянное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9403) },
                    { 14, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9404), "", true, "Сбалансированное(1)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9404) },
                    { 15, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9405), "", true, "Сбалансированное(2)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9405) },
                    { 16, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9406), "", true, "Сбалансированное(3)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9406) },
                    { 17, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9407), "", true, "Улучшенное пробивание брони", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9407) },
                    { 18, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9408), "", true, "Захватное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9408) },
                    { 19, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9409), "", true, "Ловящий лезвия", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9410) },
                    { 20, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9410), "", true, "Магические путы", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9411) },
                    { 21, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9412), "", true, "Медленно перезаряжающееся", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9412) },
                    { 22, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9413), "", true, "Несмертельное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9413) },
                    { 23, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9414), "", true, "Опутывающее", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9414) },
                    { 24, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9415), "", true, "Парирующее", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9415) },
                    { 25, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9416), "", true, "Разрушающее", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9416) },
                    { 26, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9417), "", true, "Рукопашное", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9417) },
                    { 27, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9418), "", true, "Расчетная перезарядка", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9419) },
                    { 28, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9419), "", true, "Улучшенное фокусирующее", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9420) },
                    { 29, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9420), "", true, "Устанавливаемое", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9421) },
                    { 30, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9422), "", true, "Шприц", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9423) },
                    { 31, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9423), "", true, "Закрывает все тело", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9424) },
                    { 32, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9425), "", true, "Огнеупорный", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9425) },
                    { 33, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9426), "", true, "Ограничение зрения", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9426) },
                    { 34, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9427), "", true, "Полное укрытие", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9427) },
                    { 35, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9428), "", true, "Сопротивление(Д)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9428) },
                    { 36, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9429), "", true, "Сопротивление(Р)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9429) },
                    { 37, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9430), "", true, "Сопротивление(К)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9430) },
                    { 38, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9431), "", true, "Сопротивление(С)", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9431) },
                    { 39, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9432), "", true, "Горение", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9433) },
                    { 40, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9455), "", true, "Дезориентация", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9455) },
                    { 41, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9456), "", true, "Отравление", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9457) },
                    { 42, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9457), "", true, "Кровотечение", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9458) },
                    { 43, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9459), "", true, "Замораживание", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9459) },
                    { 44, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9460), "", true, "Ошеломление", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9460) },
                    { 45, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9461), "", true, "Опьянение", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9461) },
                    { 46, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9462), "", true, "Галлюцинации", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9462) },
                    { 47, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9463), "", true, "Тошнота", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9464) },
                    { 48, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9464), "", true, "Удушье", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9465) },
                    { 49, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9466), "", true, "Слепота", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9466) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9479), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "Обезболивающие травы", 12, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9480), 0.10000000000000001 },
                    { 2, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9494), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "Капюшон вердэнского лучника", 100, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9494), 0.5 },
                    { 3, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9537), "", true, "Пепел", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9537), 0.10000000000000001 },
                    { 4, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9543), "", true, "Уголь", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9543), 0.10000000000000001 },
                    { 5, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9548), "", true, "Хлопок", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9548), 0.10000000000000001 },
                    { 6, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9552), "", true, "Двойное полотно", 22, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9552), 0.10000000000000001 },
                    { 7, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9555), "", true, "Стекло", 5, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9555), 0.5 },
                    { 8, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9557), "", true, "Укрепленное дерево", 16, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9558), 0.10000000000000001 },
                    { 9, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9561), "", true, "Полотно", 9, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9561), 0.10000000000000001 },
                    { 10, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9563), "", true, "Масло", 3, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9563), 0.10000000000000001 },
                    { 11, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9566), "", true, "Смлоа", 2, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9566), 0.10000000000000001 },
                    { 12, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9568), "", true, "Шелк", 50, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9568), 0.10000000000000001 },
                    { 13, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9570), "", true, "Нитки", 3, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9570), 0.10000000000000001 },
                    { 14, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9572), "", true, "Древесина", 3, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9573), 1.0 },
                    { 15, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9575), "", true, "Воск", 2, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9575), 0.10000000000000001 },
                    { 16, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9577), "", true, "Кости животных", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9577), 4.0 },
                    { 17, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9579), "", true, "Коровья шкура", 10, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9580), 5.0 },
                    { 18, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9601), "", true, "Кожа драконида", 58, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9602), 5.0 },
                    { 19, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9604), "", true, "Чешуя драконида", 30, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9604), 5.0 },
                    { 20, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9610), "", true, "Перья", 4, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9610), 0.10000000000000001 },
                    { 21, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9612), "", true, "Укрепленная кожа", 48, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9612), 3.0 },
                    { 22, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9614), "", true, "Кожа", 28, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9615), 2.0 },
                    { 23, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9617), "", true, "Лирийская кожа", 60, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9617), 2.0 },
                    { 24, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9619), "", true, "Волчья шкура", 14, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9619), 3.0 },
                    { 25, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9621), "", true, "Чернящее масло", 24, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9622), 0.10000000000000001 },
                    { 26, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9623), "", true, "Масло из дрейка", 45, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9624), 0.10000000000000001 },
                    { 27, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9626), "", true, "Эфирная смазка", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9626), 0.10000000000000001 },
                    { 28, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9628), "", true, "Травильная кислота", 2, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9629), 0.10000000000000001 },
                    { 29, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9631), "", true, "Пятая эссенция", 82, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9632), 0.10000000000000001 },
                    { 30, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9635), "", true, "Огров воск", 10, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9636), 0.10000000000000001 },
                    { 31, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9637), "", true, "Точильный порошок", 32, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9638), 0.10000000000000001 },
                    { 32, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9640), "", true, "Дубильные травы", 3, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9640), 0.10000000000000001 },
                    { 33, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9642), "", true, "Темное железо", 52, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9642), 1.5 },
                    { 34, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9644), "", true, "Темная сталь", 82, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9644), 1.0 },
                    { 35, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9647), "", true, "Двимерит", 240, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9647), 1.0 },
                    { 36, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9649), "", true, "Самоцветы", 100, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9649), 0.10000000000000001 },
                    { 37, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9651), "", true, "Совершенный самоцвет", 1000, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9651), 0.10000000000000001 },
                    { 38, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9653), "", true, "Светящаяся руда", 80, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9654), 1.0 },
                    { 39, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9656), "", true, "Золото", 85, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9657), 1.0 },
                    { 40, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9659), "", true, "Железо", 30, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9659), 1.5 },
                    { 41, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9661), "", true, "Махакамский двимерит", 300, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9662), 1.0 },
                    { 42, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9664), "", true, "Махакамская сталь", 114, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9664), 1.0 },
                    { 43, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9666), "", true, "Метеорит", 98, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9666), 1.0 },
                    { 44, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9668), "", true, "Речная глина", 5, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9668), 1.5 },
                    { 45, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9670), "", true, "Серебро", 72, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9671), 1.0 },
                    { 46, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9673), "", true, "Сталь", 48, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9673), 1.0 },
                    { 47, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9675), "", true, "Камень", 4, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9675), 2.0 },
                    { 48, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9678), "", true, "Третогорская сталь", 64, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9678), 1.0 },
                    { 49, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9680), "", true, "Зерриканская смесь", 30, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9680), 0.10000000000000001 },
                    { 50, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9701), "", true, "Зеленая плесень", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9702), 0.10000000000000001 },
                    { 51, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9704), "", true, "Переступень", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9704), 0.10000000000000001 },
                    { 52, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9707), "", true, "Помет беса", 20, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9707), 1.0 },
                    { 53, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9710), "", true, "Омела", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9710), 0.10000000000000001 },
                    { 54, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9712), "", true, "Паутинник", 18, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9713), 0.10000000000000001 },
                    { 55, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9715), "", true, "Optima mater", 100, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9715), 0.10000000000000001 },
                    { 56, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9717), "", true, "Жимолость", 21, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9717), 0.10000000000000001 },
                    { 57, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9720), "", true, "Листья балиссы", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9721), 0.10000000000000001 },
                    { 58, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9722), "", true, "Сера", 14, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9723), 0.10000000000000001 },
                    { 59, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9725), "", true, "Собачья петрушка", 2, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9725), 0.10000000000000001 },
                    { 60, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9727), "", true, "Царская водка", 20, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9727), 0.10000000000000001 },
                    { 61, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9729), "", true, "Аконит", 9, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9729), 0.10000000000000001 },
                    { 62, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9732), "", true, "Корень лопуха", 32, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9733), 0.10000000000000001 },
                    { 63, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9735), "", true, "Корень мандрагоры", 65, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9735), 0.10000000000000001 },
                    { 64, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9737), "", true, "Фосфор", 20, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9738), 0.5 },
                    { 65, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9740), "", true, "Calcium equum", 12, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9740), 0.10000000000000001 },
                    { 66, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9743), "", true, "Вороний глаз", 17, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9743), 0.10000000000000001 },
                    { 67, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9745), "", true, "Грибы-шибальцы", 17, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9745), 0.10000000000000001 },
                    { 68, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9747), "", true, "Лепестки белого мирта", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9747), 0.10000000000000001 },
                    { 69, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9749), "", true, "Плод балиссы", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9749), 0.10000000000000001 },
                    { 70, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9751), "", true, "Ячмень", 9, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9751), 0.10000000000000001 },
                    { 71, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9753), "", true, "Винный камень", 88, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9754), 0.5 },
                    { 72, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9755), "", true, "Волокна хана", 17, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9756), 0.10000000000000001 },
                    { 73, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9757), "", true, "Ласточкина трава", 8, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9758), 0.10000000000000001 },
                    { 74, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9760), "", true, "Лунная крошка", 91, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9760), 0.10000000000000001 },
                    { 75, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9762), "", true, "Вербена", 18, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9762), 0.10000000000000001 },
                    { 76, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9766), "", true, "Листья волчьего алоэ", 39, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9766), 0.10000000000000001 },
                    { 77, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9768), "", true, "Краснолюдский бессмертник", 75, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9768), 0.10000000000000001 },
                    { 78, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9770), "", true, "Эмбрион эндриаги", 55, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9770), 1.5 },
                    { 79, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9772), "", true, "Жемчуг", 100, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9772), 0.10000000000000001 },
                    { 80, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9774), "", true, "Корень зарника", 18, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9775), 0.10000000000000001 },
                    { 81, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9777), "", true, "Лепестки гинации", 17, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9777), 0.10000000000000001 },
                    { 82, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9779), "", true, "Лепестки морозника", 19, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9779), 0.10000000000000001 },
                    { 83, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9781), "", true, "Плод берберки", 9, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9781), 0.10000000000000001 },
                    { 84, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9783), "", true, "Ртутный раствор", 77, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9783), 0.10000000000000001 },
                    { 85, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9786), "", true, "Склеродерм", 5, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9786), 0.10000000000000001 },
                    { 86, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9841), "", true, "Чертеж «Капюшон вердэнского лучника»", 150, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9841), 0.0 },
                    { 87, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9875), "", true, "Формула «Обезболивающие травы»", 0, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9875), 1.0 },
                    { 88, 0, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9906), "Всегда с собой таскай верёвку. Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "Веревка (20 метров)", 20, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9907), 1.5 },
                    { 89, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9921), "Позволяют создавать алхимические составы", true, "Инструменты алхимика", 80, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9921), 3.0 },
                    { 90, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9932), "", true, "Стилет", 275, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9933), 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9229), "", true, "Интеллект", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9230) },
                    { 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9231), "", true, "Реакция", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9232) },
                    { 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9233), "", true, "Ловкость", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9233) },
                    { 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9234), "", true, "Телосложение", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9235) },
                    { 5, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9236), "", true, "Скорость", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9236) },
                    { 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9237), "", true, "Эмпатия", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9237) },
                    { 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9238), "", true, "Ремесло", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9238) },
                    { 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9239), "", true, "Воля", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9239) },
                    { 9, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9240), "", true, "Удача", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9241) },
                    { 10, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9241), "", true, "Энергия", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9242) },
                    { 11, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9242), "", true, "Устойчивость", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9243) },
                    { 12, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9244), "", true, "Бег", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9244) },
                    { 13, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9245), "", true, "Прыжок", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9245) },
                    { 14, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9246), "", true, "Пункты Здоровья", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9246) },
                    { 15, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9247), "", true, "Выносливость", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9247) },
                    { 16, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9248), "", true, "Переносимый вес", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9248) },
                    { 17, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9249), "", true, "Отдых", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9250) },
                    { 18, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9250), "", true, "Удар рукой", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9251) },
                    { 19, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9251), "", true, "Удар ногой", 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9252) }
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
                values: new object[] { 88, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9271), "", true, false, false, "Внимание", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9271) },
                    { 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9274), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9275) },
                    { 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9276), "", true, false, false, "Дедукция", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9276) },
                    { 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9277), "", true, false, true, "Монстрология", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9277) },
                    { 5, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9279), "", true, false, false, "Образование", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9279) },
                    { 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9280), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9280) },
                    { 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9282), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9282) },
                    { 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9283), "", true, false, true, "Тактика", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9283) },
                    { 9, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9284), "", true, false, false, "Торговля", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9285) },
                    { 10, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9286), "", true, false, false, "Этикет", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9286) },
                    { 11, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9287), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9288) },
                    { 12, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9310), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9310) },
                    { 13, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9311), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9312) },
                    { 14, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9313), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9313) },
                    { 15, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9314), "", true, false, false, "Борьба", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9314) },
                    { 16, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9315), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9316) },
                    { 17, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9317), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9317) },
                    { 18, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9318), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9319) },
                    { 19, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9320), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9320) },
                    { 20, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9321), "", true, false, false, "Мореходство", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9322) },
                    { 21, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9323), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9323) },
                    { 22, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9325), "", true, false, false, "Атлетика", 1, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9325) },
                    { 23, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9326), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9327) },
                    { 24, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9328), "", true, false, false, "Скрытность", 1, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9328) },
                    { 25, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9329), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9329) },
                    { 26, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9330), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9331) },
                    { 27, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9332), "", true, false, false, "Сила", 1, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9332) },
                    { 28, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9333), "", true, false, false, "Стойкость", 1, 4, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9334) },
                    { 29, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9335), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9335) },
                    { 30, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9336), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9336) },
                    { 31, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9338), "", true, false, false, "Выступление", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9338) },
                    { 32, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9339), "", true, false, false, "Искусство", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9339) },
                    { 33, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9340), "", true, false, false, "Лидерство", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9341) },
                    { 34, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9342), "", true, false, false, "Обман", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9342) },
                    { 35, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9343), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9343) },
                    { 36, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9345), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9345) },
                    { 37, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9346), "", true, false, false, "Убеждение", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9346) },
                    { 38, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9347), "", true, false, false, "Харизма", 1, 6, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9348) },
                    { 39, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9349), "", true, false, true, "Алхимия", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9349) },
                    { 40, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9351), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9351) },
                    { 41, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9352), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9352) },
                    { 42, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9354), "", true, false, true, "Изготовление", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9354) },
                    { 43, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9355), "", true, false, false, "Маскировка", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9355) },
                    { 44, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9356), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9357) },
                    { 45, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9358), "", true, false, false, "Подделывание", 1, 7, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9358) },
                    { 46, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9359), "", true, false, false, "Запугивание", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9359) },
                    { 47, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9361), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9361) },
                    { 48, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9362), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9362) },
                    { 49, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9363), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9364) },
                    { 50, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9365), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9365) },
                    { 51, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9366), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9366) },
                    { 52, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9367), "", true, false, false, "Храбрость", 1, 8, new DateTime(2024, 1, 22, 11, 18, 46, 828, DateTimeKind.Local).AddTicks(9368) }
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
                table: "FormulaComponentList",
                columns: new[] { "Id", "Amount", "FormulaId", "SubstanceType" },
                values: new object[,]
                {
                    { 1, 1, 87, 3 },
                    { 2, 1, 87, 4 }
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
