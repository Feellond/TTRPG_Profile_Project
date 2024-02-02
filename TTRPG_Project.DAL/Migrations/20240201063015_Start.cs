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
                    { 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1291), true, "Базовая книга", new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1299) },
                    { 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1301), true, "Хоумбрю", new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1301) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1561), "", true, "Незаметное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1561) },
                    { 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1562), "", true, "Кровопускающее", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1562) },
                    { 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1563), "", true, "Пробивающее броню", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1563) },
                    { 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1564), "", true, "Дезориентирующее(1)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1564) },
                    { 5, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1565), "", true, "Дезориентирующее(2)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1566) },
                    { 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1566), "", true, "Дезориентирующее(3)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1567) },
                    { 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1567), "", true, "Метеоритное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1568) },
                    { 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1568), "", true, "Длинное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1569) },
                    { 9, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1570), "", true, "Фокусирующее(1)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1570) },
                    { 10, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1571), "", true, "Фокусирующее(2)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1571) },
                    { 11, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1572), "", true, "Фокусирующее(3)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1572) },
                    { 12, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1573), "", true, "Сокрушающая сила", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1573) },
                    { 13, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1574), "", true, "Серебрянное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1574) },
                    { 14, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1575), "", true, "Сбалансированное(1)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1575) },
                    { 15, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1576), "", true, "Сбалансированное(2)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1576) },
                    { 16, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1577), "", true, "Сбалансированное(3)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1578) },
                    { 17, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1578), "", true, "Улучшенное пробивание брони", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1579) },
                    { 18, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1579), "", true, "Захватное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1580) },
                    { 19, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1581), "", true, "Ловящий лезвия", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1581) },
                    { 20, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1582), "", true, "Магические путы", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1582) },
                    { 21, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1583), "", true, "Медленно перезаряжающееся", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1583) },
                    { 22, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1584), "", true, "Несмертельное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1584) },
                    { 23, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1585), "", true, "Опутывающее", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1585) },
                    { 24, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1586), "", true, "Парирующее", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1586) },
                    { 25, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1587), "", true, "Разрушающее", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1587) },
                    { 26, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1588), "", true, "Рукопашное", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1588) },
                    { 27, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1589), "", true, "Расчетная перезарядка", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1589) },
                    { 28, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1591), "", true, "Улучшенное фокусирующее", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1591) },
                    { 29, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1592), "", true, "Устанавливаемое", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1593) },
                    { 30, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1593), "", true, "Шприц", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1594) },
                    { 31, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1595), "", true, "Закрывает все тело", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1595) },
                    { 32, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1596), "", true, "Огнеупорный", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1596) },
                    { 33, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1597), "", true, "Ограничение зрения", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1597) },
                    { 34, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1598), "", true, "Полное укрытие", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1598) },
                    { 35, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1599), "", true, "Сопротивление(Д)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1599) },
                    { 36, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1600), "", true, "Сопротивление(Р)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1600) },
                    { 37, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1601), "", true, "Сопротивление(К)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1601) },
                    { 38, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1602), "", true, "Сопротивление(С)", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1602) },
                    { 39, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1603), "", true, "Горение", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1603) },
                    { 40, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1604), "", true, "Дезориентация", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1605) },
                    { 41, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1605), "", true, "Отравление", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1606) },
                    { 42, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1606), "", true, "Кровотечение", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1607) },
                    { 43, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1607), "", true, "Замораживание", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1608) },
                    { 44, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1609), "", true, "Ошеломление", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1609) },
                    { 45, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1610), "", true, "Опьянение", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1610) },
                    { 46, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1611), "", true, "Галлюцинации", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1611) },
                    { 47, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1612), "", true, "Тошнота", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1612) },
                    { 48, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1613), "", true, "Удушье", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1613) },
                    { 49, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1614), "", true, "Слепота", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1614) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1630), "Прикладывание к ране обезболивающих трав притупляет боль, снижая штраф от критических ранений и состояния «при смерти» на 2. Эффект действует 2d10 раундов.", true, "Обезболивающие травы", 12, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1630), 0.10000000000000001 },
                    { 2, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1645), "Вердонские лучники — крепкие ребята. Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.", true, "Капюшон вердэнского лучника", 100, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1645), 0.5 },
                    { 3, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1696), "", true, "Пепел", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1697), 0.10000000000000001 },
                    { 4, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1703), "", true, "Уголь", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1704), 0.10000000000000001 },
                    { 5, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1709), "", true, "Хлопок", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1709), 0.10000000000000001 },
                    { 6, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1712), "", true, "Двойное полотно", 22, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1713), 0.10000000000000001 },
                    { 7, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1715), "", true, "Стекло", 5, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1716), 0.5 },
                    { 8, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1718), "", true, "Укрепленное дерево", 16, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1718), 0.10000000000000001 },
                    { 9, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1721), "", true, "Полотно", 9, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1721), 0.10000000000000001 },
                    { 10, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1723), "", true, "Масло", 3, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1723), 0.10000000000000001 },
                    { 11, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1725), "", true, "Смлоа", 2, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1726), 0.10000000000000001 },
                    { 12, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1727), "", true, "Шелк", 50, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1728), 0.10000000000000001 },
                    { 13, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1729), "", true, "Нитки", 3, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1730), 0.10000000000000001 },
                    { 14, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1731), "", true, "Древесина", 3, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1732), 1.0 },
                    { 15, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1734), "", true, "Воск", 2, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1734), 0.10000000000000001 },
                    { 16, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1736), "", true, "Кости животных", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1736), 4.0 },
                    { 17, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1742), "", true, "Коровья шкура", 10, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1742), 5.0 },
                    { 18, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1744), "", true, "Кожа драконида", 58, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1744), 5.0 },
                    { 19, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1746), "", true, "Чешуя драконида", 30, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1746), 5.0 },
                    { 20, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1749), "", true, "Перья", 4, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1749), 0.10000000000000001 },
                    { 21, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1751), "", true, "Укрепленная кожа", 48, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1751), 3.0 },
                    { 22, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1753), "", true, "Кожа", 28, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1754), 2.0 },
                    { 23, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1755), "", true, "Лирийская кожа", 60, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1756), 2.0 },
                    { 24, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1758), "", true, "Волчья шкура", 14, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1758), 3.0 },
                    { 25, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1760), "", true, "Чернящее масло", 24, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1760), 0.10000000000000001 },
                    { 26, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1762), "", true, "Масло из дрейка", 45, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1762), 0.10000000000000001 },
                    { 27, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1765), "", true, "Эфирная смазка", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1765), 0.10000000000000001 },
                    { 28, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1767), "", true, "Травильная кислота", 2, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1768), 0.10000000000000001 },
                    { 29, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1770), "", true, "Пятая эссенция", 82, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1770), 0.10000000000000001 },
                    { 30, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1774), "", true, "Огров воск", 10, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1774), 0.10000000000000001 },
                    { 31, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1776), "", true, "Точильный порошок", 32, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1777), 0.10000000000000001 },
                    { 32, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1784), "", true, "Дубильные травы", 3, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1785), 0.10000000000000001 },
                    { 33, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1787), "", true, "Темное железо", 52, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1788), 1.5 },
                    { 34, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1790), "", true, "Темная сталь", 82, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1790), 1.0 },
                    { 35, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1792), "", true, "Двимерит", 240, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1792), 1.0 },
                    { 36, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1795), "", true, "Самоцветы", 100, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1795), 0.10000000000000001 },
                    { 37, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1797), "", true, "Совершенный самоцвет", 1000, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1797), 0.10000000000000001 },
                    { 38, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1799), "", true, "Светящаяся руда", 80, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1800), 1.0 },
                    { 39, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1803), "", true, "Золото", 85, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1803), 1.0 },
                    { 40, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1805), "", true, "Железо", 30, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1805), 1.5 },
                    { 41, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1807), "", true, "Махакамский двимерит", 300, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1808), 1.0 },
                    { 42, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1810), "", true, "Махакамская сталь", 114, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1810), 1.0 },
                    { 43, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1812), "", true, "Метеорит", 98, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1812), 1.0 },
                    { 44, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1814), "", true, "Речная глина", 5, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1814), 1.5 },
                    { 45, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1818), "", true, "Серебро", 72, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1818), 1.0 },
                    { 46, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1820), "", true, "Сталь", 48, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1821), 1.0 },
                    { 47, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1823), "", true, "Камень", 4, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1823), 2.0 },
                    { 48, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1825), "", true, "Третогорская сталь", 64, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1826), 1.0 },
                    { 49, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1828), "", true, "Зерриканская смесь", 30, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1828), 0.10000000000000001 },
                    { 50, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1830), "", true, "Зеленая плесень", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1830), 0.10000000000000001 },
                    { 51, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1832), "", true, "Переступень", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1833), 0.10000000000000001 },
                    { 52, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1835), "", true, "Помет беса", 20, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1835), 1.0 },
                    { 53, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1837), "", true, "Омела", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1838), 0.10000000000000001 },
                    { 54, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1840), "", true, "Паутинник", 18, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1840), 0.10000000000000001 },
                    { 55, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1842), "", true, "Optima mater", 100, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1842), 0.10000000000000001 },
                    { 56, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1845), "", true, "Жимолость", 21, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1845), 0.10000000000000001 },
                    { 57, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1847), "", true, "Листья балиссы", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1847), 0.10000000000000001 },
                    { 58, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1849), "", true, "Сера", 14, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1850), 0.10000000000000001 },
                    { 59, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1852), "", true, "Собачья петрушка", 2, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1852), 0.10000000000000001 },
                    { 60, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1854), "", true, "Царская водка", 20, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1854), 0.10000000000000001 },
                    { 61, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1856), "", true, "Аконит", 9, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1857), 0.10000000000000001 },
                    { 62, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1860), "", true, "Корень лопуха", 32, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1860), 0.10000000000000001 },
                    { 63, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1862), "", true, "Корень мандрагоры", 65, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1862), 0.10000000000000001 },
                    { 64, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1864), "", true, "Фосфор", 20, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1865), 0.5 },
                    { 65, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1875), "", true, "Calcium equum", 12, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1875), 0.10000000000000001 },
                    { 66, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1877), "", true, "Вороний глаз", 17, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1878), 0.10000000000000001 },
                    { 67, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1880), "", true, "Грибы-шибальцы", 17, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1880), 0.10000000000000001 },
                    { 68, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1882), "", true, "Лепестки белого мирта", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1882), 0.10000000000000001 },
                    { 69, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1884), "", true, "Плод балиссы", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1885), 0.10000000000000001 },
                    { 70, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1886), "", true, "Ячмень", 9, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1887), 0.10000000000000001 },
                    { 71, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1889), "", true, "Винный камень", 88, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1889), 0.5 },
                    { 72, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1891), "", true, "Волокна хана", 17, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1891), 0.10000000000000001 },
                    { 73, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1893), "", true, "Ласточкина трава", 8, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1893), 0.10000000000000001 },
                    { 74, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1895), "", true, "Лунная крошка", 91, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1896), 0.10000000000000001 },
                    { 75, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1898), "", true, "Вербена", 18, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1898), 0.10000000000000001 },
                    { 76, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1901), "", true, "Листья волчьего алоэ", 39, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1902), 0.10000000000000001 },
                    { 77, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1903), "", true, "Краснолюдский бессмертник", 75, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1904), 0.10000000000000001 },
                    { 78, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1906), "", true, "Эмбрион эндриаги", 55, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1906), 1.5 },
                    { 79, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1908), "", true, "Жемчуг", 100, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1908), 0.10000000000000001 },
                    { 80, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1910), "", true, "Корень зарника", 18, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1910), 0.10000000000000001 },
                    { 81, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1912), "", true, "Лепестки гинации", 17, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1912), 0.10000000000000001 },
                    { 82, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1914), "", true, "Лепестки морозника", 19, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1915), 0.10000000000000001 },
                    { 83, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1916), "", true, "Плод берберки", 9, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1917), 0.10000000000000001 },
                    { 84, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1919), "", true, "Ртутный раствор", 77, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1919), 0.10000000000000001 },
                    { 85, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1922), "", true, "Склеродерм", 5, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1922), 0.10000000000000001 },
                    { 86, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1955), "", true, "Чертеж «Капюшон вердэнского лучника»", 150, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1956), 0.0 },
                    { 87, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1997), "", true, "Формула «Обезболивающие травы»", 0, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1997), 1.0 },
                    { 88, 0, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2026), "Всегда с собой таскай верёвку. Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. Ситуаций, где нужна верёвка, предостаточно", true, "Веревка (20 метров)", 20, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2026), 1.5 },
                    { 89, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2036), "Позволяют создавать алхимические составы", true, "Инструменты алхимика", 80, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2036), 3.0 },
                    { 90, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2049), "", true, "Стилет", 275, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(2049), 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1416), "", true, "Интеллект", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1417) },
                    { 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1420), "", true, "Реакция", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1420) },
                    { 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1421), "", true, "Ловкость", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1421) },
                    { 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1422), "", true, "Телосложение", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1422) },
                    { 5, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1423), "", true, "Скорость", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1423) },
                    { 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1424), "", true, "Эмпатия", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1424) },
                    { 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1425), "", true, "Ремесло", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1426) },
                    { 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1426), "", true, "Воля", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1427) },
                    { 9, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1427), "", true, "Удача", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1428) },
                    { 10, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1429), "", true, "Энергия", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1429) },
                    { 11, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1430), "", true, "Устойчивость", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1430) },
                    { 12, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1431), "", true, "Бег", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1431) },
                    { 13, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1432), "", true, "Прыжок", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1432) },
                    { 14, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1433), "", true, "Пункты Здоровья", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1433) },
                    { 15, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1434), "", true, "Выносливость", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1434) },
                    { 16, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1435), "", true, "Переносимый вес", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1435) },
                    { 17, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1436), "", true, "Отдых", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1436) },
                    { 18, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1437), "", true, "Удар рукой", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1437) },
                    { 19, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1438), "", true, "Удар ногой", 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1438) }
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
                    { 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1459), "", true, false, false, "Внимание", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1459) },
                    { 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1462), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1462) },
                    { 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1463), "", true, false, false, "Дедукция", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1464) },
                    { 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1465), "", true, false, true, "Монстрология", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1465) },
                    { 5, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1466), "", true, false, false, "Образование", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1467) },
                    { 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1468), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1468) },
                    { 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1469), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1469) },
                    { 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1470), "", true, false, true, "Тактика", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1471) },
                    { 9, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1472), "", true, false, false, "Торговля", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1472) },
                    { 10, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1473), "", true, false, false, "Этикет", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1473) },
                    { 11, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1475), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1475) },
                    { 12, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1476), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1476) },
                    { 13, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1477), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1478) },
                    { 14, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1479), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1479) },
                    { 15, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1480), "", true, false, false, "Борьба", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1480) },
                    { 16, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1481), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1482) },
                    { 17, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1483), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1483) },
                    { 18, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1484), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1484) },
                    { 19, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1485), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1486) },
                    { 20, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1487), "", true, false, false, "Мореходство", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1487) },
                    { 21, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1488), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1488) },
                    { 22, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1490), "", true, false, false, "Атлетика", 1, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1490) },
                    { 23, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1492), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1492) },
                    { 24, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1493), "", true, false, false, "Скрытность", 1, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1493) },
                    { 25, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1494), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1494) },
                    { 26, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1496), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1496) },
                    { 27, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1497), "", true, false, false, "Сила", 1, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1497) },
                    { 28, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1498), "", true, false, false, "Стойкость", 1, 4, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1499) },
                    { 29, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1500), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1500) },
                    { 30, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1501), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1501) },
                    { 31, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1502), "", true, false, false, "Выступление", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1503) },
                    { 32, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1504), "", true, false, false, "Искусство", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1504) },
                    { 33, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1505), "", true, false, false, "Лидерство", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1505) },
                    { 34, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1506), "", true, false, false, "Обман", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1507) },
                    { 35, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1508), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1508) },
                    { 36, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1509), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1509) },
                    { 37, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1510), "", true, false, false, "Убеждение", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1511) },
                    { 38, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1513), "", true, false, false, "Харизма", 1, 6, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1513) },
                    { 39, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1515), "", true, false, true, "Алхимия", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1515) },
                    { 40, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1516), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1516) },
                    { 41, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1517), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1518) },
                    { 42, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1519), "", true, false, true, "Изготовление", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1519) },
                    { 43, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1520), "", true, false, false, "Маскировка", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1520) },
                    { 44, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1521), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1522) },
                    { 45, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1523), "", true, false, false, "Подделывание", 1, 7, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1523) },
                    { 46, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1524), "", true, false, false, "Запугивание", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1524) },
                    { 47, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1525), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1526) },
                    { 48, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1527), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1527) },
                    { 49, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1528), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1528) },
                    { 50, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1529), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1530) },
                    { 51, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1531), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1531) },
                    { 52, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1538), "", true, false, false, "Храбрость", 1, 8, new DateTime(2024, 2, 1, 13, 30, 14, 930, DateTimeKind.Local).AddTicks(1539) }
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
