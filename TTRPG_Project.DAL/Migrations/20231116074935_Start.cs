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
                name: "ItemBases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilityType = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<int>(type: "int", nullable: true),
                    Reliability = table.Column<int>(type: "int", nullable: true),
                    AmountOfEnhancements = table.Column<int>(type: "int", nullable: true),
                    Stiffness = table.Column<int>(type: "int", nullable: true),
                    Blueprint_Complexity = table.Column<int>(type: "int", nullable: true),
                    Blueprint_TimeSpend = table.Column<float>(type: "real", nullable: true),
                    Blueprint_AdditionalPayment = table.Column<int>(type: "int", nullable: true),
                    WhereToFind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Component_Complexity = table.Column<int>(type: "int", nullable: true),
                    IsAlchemical = table.Column<bool>(type: "bit", nullable: true),
                    SubstanceType = table.Column<int>(type: "int", nullable: true),
                    Complexity = table.Column<int>(type: "int", nullable: true),
                    TimeSpend = table.Column<float>(type: "real", nullable: true),
                    AdditionalPayment = table.Column<int>(type: "int", nullable: true),
                    StealthType = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Accuracy = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weapon_Reliability = table.Column<int>(type: "int", nullable: true),
                    Grip = table.Column<int>(type: "int", nullable: true),
                    Distance = table.Column<int>(type: "int", nullable: true),
                    Weapon_StealthType = table.Column<int>(type: "int", nullable: true),
                    Weapon_AmountOfEnhancements = table.Column<int>(type: "int", nullable: true),
                    IsAmmunition = table.Column<bool>(type: "bit", nullable: true),
                    SkillId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_ItemBases_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemBases_Sources_SourceId",
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
                        name: "FK_BlueprintComponentList_ItemBases_BlueprintId",
                        column: x => x.BlueprintId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlueprintComponentList_ItemBases_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "ItemBases",
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
                name: "FormulaComponentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormulaId = table.Column<int>(type: "int", nullable: true),
                    ComponentId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaComponentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormulaComponentList_ItemBases_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FormulaComponentList_ItemBases_FormulaId",
                        column: x => x.FormulaId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
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
                        name: "FK_SpellComponentList_ItemBases_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "ItemBases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpellComponentList_Spells_SpellId",
                        column: x => x.SpellId,
                        principalTable: "Spells",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "CreateDate", "Enabled", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(8839), true, "Базовая книга", new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(8852) },
                    { 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(8854), true, "Хоумбрю", new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(8854) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9235), "", true, "Незаметное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9235) },
                    { 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9236), "", true, "Кровопускающее", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9237) },
                    { 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9237), "", true, "Пробивающее броню", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9238) },
                    { 4, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9239), "", true, "Дезориентирующее(1)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9239) },
                    { 5, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9240), "", true, "Дезориентирующее(2)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9240) },
                    { 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9241), "", true, "Дезориентирующее(3)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9242) },
                    { 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9242), "", true, "Метеоритное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9243) },
                    { 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9244), "", true, "Длинное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9244) },
                    { 9, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9245), "", true, "Фокусирующее(1)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9245) },
                    { 10, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9246), "", true, "Фокусирующее(2)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9246) },
                    { 11, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9247), "", true, "Фокусирующее(3)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9248) },
                    { 12, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9248), "", true, "Сокрушающая сила", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9249) },
                    { 13, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9250), "", true, "Серебрянное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9250) },
                    { 14, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9251), "", true, "Сбалансированное(1)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9251) },
                    { 15, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9252), "", true, "Сбалансированное(2)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9252) },
                    { 16, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9253), "", true, "Сбалансированное(3)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9254) },
                    { 17, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9255), "", true, "Улучшенное пробивание брони", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9255) },
                    { 18, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9256), "", true, "Захватное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9256) },
                    { 19, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9258), "", true, "Ловящий лезвия", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9258) },
                    { 20, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9259), "", true, "Магические путы", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9259) },
                    { 21, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9260), "", true, "Медленно перезаряжающееся", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9261) },
                    { 22, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9262), "", true, "Несмертельное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9262) },
                    { 23, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9263), "", true, "Опутывающее", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9263) },
                    { 24, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9264), "", true, "Парирующее", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9264) },
                    { 25, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9265), "", true, "Разрушающее", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9265) },
                    { 26, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9266), "", true, "Рукопашное", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9267) },
                    { 27, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9268), "", true, "Расчетная перезарядка", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9268) },
                    { 28, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9269), "", true, "Улучшенное фокусирующее", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9269) },
                    { 29, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9270), "", true, "Устанавливаемое", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9270) },
                    { 30, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9271), "", true, "Шприц", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9272) },
                    { 31, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9272), "", true, "Закрывает все тело", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9273) },
                    { 32, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9274), "", true, "Огнеупорный", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9274) },
                    { 33, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9275), "", true, "Ограничение зрения", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9275) },
                    { 34, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9276), "", true, "Полное укрытие", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9276) },
                    { 35, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9277), "", true, "Сопротивление(Д)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9278) },
                    { 36, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9279), "", true, "Сопротивление(Р)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9279) },
                    { 37, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9280), "", true, "Сопротивление(К)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9280) },
                    { 38, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9281), "", true, "Сопротивление(С)", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9281) },
                    { 39, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9283), "", true, "Горение", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9283) },
                    { 40, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9284), "", true, "Дезориентация", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9284) },
                    { 41, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9285), "", true, "Отравление", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9286) },
                    { 42, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9287), "", true, "Кровотечение", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9287) },
                    { 43, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9313), "", true, "Замораживание", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9313) },
                    { 44, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9314), "", true, "Ошеломление", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9315) },
                    { 45, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9316), "", true, "Опьянение", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9316) },
                    { 46, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9317), "", true, "Галлюцинации", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9317) },
                    { 47, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9318), "", true, "Тошнота", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9319) },
                    { 48, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9319), "", true, "Удушье", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9320) },
                    { 49, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9321), "", true, "Слепота", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9321) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[] { 1, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9354), "testAlchemicaItem", "AlchemicalItem", true, 0, "testAlchemicaItem", 0, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9355), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AmountOfEnhancements", "AvailabilityType", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "Reliability", "SourceId", "Stiffness", "UpdateDate", "Weight" },
                values: new object[] { 2, 0, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9375), "testArmor", "Armor", true, 0, "testArmor", 0, 0, 1, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9376), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "Blueprint_AdditionalPayment", "AvailabilityType", "Blueprint_Complexity", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "SourceId", "Blueprint_TimeSpend", "UpdateDate", "Weight" },
                values: new object[] { 3, 1, 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9416), "testBlueprint", "Blueprint", true, 0, "testBlueprint", 0, 1, 0f, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9416), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "Amount", "AvailabilityType", "Component_Complexity", "CreateDate", "Description", "Discriminator", "Enabled", "IsAlchemical", "ItemType", "Name", "Price", "SourceId", "SubstanceType", "UpdateDate", "Weight", "WhereToFind" },
                values: new object[] { 4, 0, 0, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9434), "testComponent", "Component", true, false, 0, "testComponent", 0, 1, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9434), 1f, "" });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AdditionalPayment", "AvailabilityType", "Complexity", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "SourceId", "TimeSpend", "UpdateDate", "Weight" },
                values: new object[] { 5, 1, 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9456), "testFormula", "Formula", true, 0, "testFormula", 0, 1, 0f, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9456), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "SourceId", "StealthType", "Type", "UpdateDate", "Weight" },
                values: new object[] { 6, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9471), "testItem", "Item", true, 0, "testItem", 0, 1, 0, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9471), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Discriminator", "Enabled", "ItemType", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[] { 7, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9488), "testTool", "Tool", true, 0, "testTool", 0, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9489), 1f });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "Accuracy", "Weapon_AmountOfEnhancements", "AvailabilityType", "CreateDate", "Damage", "Description", "Discriminator", "Distance", "Enabled", "Grip", "IsAmmunition", "ItemType", "Name", "Price", "Weapon_Reliability", "SkillId", "SourceId", "Weapon_StealthType", "UpdateDate", "Weight" },
                values: new object[] { 8, 0, 0, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9503), "", "testWeapon", "Weapon", 0, true, 0, false, 0, "testWeapon", 0, 0, null, 1, 0, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9504), 1f });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9047), "", true, "Интеллект", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9047) },
                    { 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9050), "", true, "Реакция", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9050) },
                    { 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9051), "", true, "Ловкость", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9051) },
                    { 4, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9052), "", true, "Телосложение", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9053) },
                    { 5, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9054), "", true, "Скорость", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9054) },
                    { 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9055), "", true, "Эмпатия", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9056) },
                    { 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9057), "", true, "Ремесло", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9057) },
                    { 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9058), "", true, "Воля", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9058) },
                    { 9, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9059), "", true, "Удача", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9059) },
                    { 10, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9060), "", true, "Энергия", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9061) },
                    { 11, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9062), "", true, "Устойчивость", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9062) },
                    { 12, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9063), "", true, "Бег", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9063) },
                    { 13, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9064), "", true, "Прыжок", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9064) },
                    { 14, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9065), "", true, "Пункты Здоровья", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9066) },
                    { 15, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9066), "", true, "Выносливость", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9067) },
                    { 16, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9068), "", true, "Переносимый вес", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9068) },
                    { 17, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9069), "", true, "Отдых", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9069) },
                    { 18, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9070), "", true, "Удар рукой", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9070) },
                    { 19, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9071), "", true, "Удар ногой", 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9071) }
                });

            migrationBuilder.InsertData(
                table: "ItemBaseEffectList",
                columns: new[] { "Id", "ChancePercent", "Damage", "EffectId", "IsDealDamage", "ItemBaseId" },
                values: new object[,]
                {
                    { 1, 75, "", 2, false, 2 },
                    { 2, 0, "2к6+2", 2, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9095), "", true, false, false, "Внимание", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9095) },
                    { 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9099), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9099) },
                    { 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9101), "", true, false, false, "Дедукция", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9101) },
                    { 4, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9102), "", true, false, true, "Монстрология", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9103) },
                    { 5, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9104), "", true, false, false, "Образование", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9104) },
                    { 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9105), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9106) },
                    { 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9107), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9107) },
                    { 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9108), "", true, false, true, "Тактика", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9109) },
                    { 9, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9110), "", true, false, false, "Торговля", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9111) },
                    { 10, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9112), "", true, false, false, "Этикет", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9112) },
                    { 11, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9113), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9114) },
                    { 12, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9115), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9115) },
                    { 13, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9116), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9117) },
                    { 14, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9146), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9147) },
                    { 15, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9148), "", true, false, false, "Борьба", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9149) },
                    { 16, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9150), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9150) },
                    { 17, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9151), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9152) },
                    { 18, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9153), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9153) },
                    { 19, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9155), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9155) },
                    { 20, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9157), "", true, false, false, "Мореходство", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9157) },
                    { 21, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9159), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9159) },
                    { 22, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9160), "", true, false, false, "Атлетика", 1, 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9161) },
                    { 23, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9162), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9162) },
                    { 24, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9163), "", true, false, false, "Скрытность", 1, 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9164) },
                    { 25, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9165), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9165) },
                    { 26, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9166), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9167) },
                    { 27, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9168), "", true, false, false, "Сила", 1, 4, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9168) },
                    { 28, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9169), "", true, false, false, "Стойкость", 1, 4, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9170) },
                    { 29, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9171), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9171) },
                    { 30, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9172), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9173) },
                    { 31, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9174), "", true, false, false, "Выступление", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9174) },
                    { 32, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9176), "", true, false, false, "Искусство", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9176) },
                    { 33, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9177), "", true, false, false, "Лидерство", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9177) },
                    { 34, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9179), "", true, false, false, "Обман", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9179) },
                    { 35, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9180), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9180) },
                    { 36, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9182), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9183) },
                    { 37, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9184), "", true, false, false, "Убеждение", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9184) },
                    { 38, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9185), "", true, false, false, "Харизма", 1, 6, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9186) },
                    { 39, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9187), "", true, false, true, "Алхимия", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9187) },
                    { 40, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9189), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9189) },
                    { 41, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9190), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9190) },
                    { 42, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9192), "", true, false, true, "Изготовление", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9192) },
                    { 43, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9193), "", true, false, false, "Маскировка", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9193) },
                    { 44, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9194), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9195) },
                    { 45, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9196), "", true, false, false, "Подделывание", 1, 7, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9196) },
                    { 46, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9198), "", true, false, false, "Запугивание", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9198) },
                    { 47, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9199), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9199) },
                    { 48, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9200), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9201) },
                    { 49, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9202), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9202) },
                    { 50, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9204), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9204) },
                    { 51, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9205), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9205) },
                    { 52, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9207), "", true, false, false, "Храбрость", 1, 8, new DateTime(2023, 11, 16, 14, 49, 35, 556, DateTimeKind.Local).AddTicks(9208) }
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
                name: "IX_ItemBases_SkillId",
                table: "ItemBases",
                column: "SkillId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abilities");

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
                name: "Races");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Attacks");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "ItemBases");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Creatures");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SkillsList");

            migrationBuilder.DropTable(
                name: "StatsList");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
