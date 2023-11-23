﻿using System;
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
                    Weight = table.Column<float>(type: "real", nullable: false),
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
                    Reliability = table.Column<int>(type: "int", nullable: false),
                    AmountOfEnhancements = table.Column<int>(type: "int", nullable: false),
                    Stiffness = table.Column<int>(type: "int", nullable: false),
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
                    Amount = table.Column<int>(type: "int", nullable: false),
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
                    ComponentId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
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
                    { 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2156), true, "Базовая книга", new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2171) },
                    { 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2175), true, "Хоумбрю", new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2175) }
                });

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2974), "", true, "Незаметное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2974) },
                    { 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2975), "", true, "Кровопускающее", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2975) },
                    { 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2976), "", true, "Пробивающее броню", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2977) },
                    { 4, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2978), "", true, "Дезориентирующее(1)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2978) },
                    { 5, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2979), "", true, "Дезориентирующее(2)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2979) },
                    { 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2980), "", true, "Дезориентирующее(3)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2981) },
                    { 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2982), "", true, "Метеоритное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2982) },
                    { 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2983), "", true, "Длинное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2983) },
                    { 9, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2984), "", true, "Фокусирующее(1)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2984) },
                    { 10, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2985), "", true, "Фокусирующее(2)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2986) },
                    { 11, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2987), "", true, "Фокусирующее(3)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2987) },
                    { 12, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2988), "", true, "Сокрушающая сила", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2988) },
                    { 13, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2989), "", true, "Серебрянное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2989) },
                    { 14, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2990), "", true, "Сбалансированное(1)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2990) },
                    { 15, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2991), "", true, "Сбалансированное(2)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2992) },
                    { 16, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2993), "", true, "Сбалансированное(3)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2993) },
                    { 17, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2994), "", true, "Улучшенное пробивание брони", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2994) },
                    { 18, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2996), "", true, "Захватное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2996) },
                    { 19, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2997), "", true, "Ловящий лезвия", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2997) },
                    { 20, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2998), "", true, "Магические путы", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2999) },
                    { 21, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3000), "", true, "Медленно перезаряжающееся", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3000) },
                    { 22, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3001), "", true, "Несмертельное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3001) },
                    { 23, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3002), "", true, "Опутывающее", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3002) },
                    { 24, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3003), "", true, "Парирующее", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3004) },
                    { 25, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3005), "", true, "Разрушающее", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3005) },
                    { 26, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3006), "", true, "Рукопашное", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3006) },
                    { 27, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3007), "", true, "Расчетная перезарядка", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3007) },
                    { 28, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3008), "", true, "Улучшенное фокусирующее", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3009) },
                    { 29, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3009), "", true, "Устанавливаемое", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3010) },
                    { 30, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3011), "", true, "Шприц", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3011) },
                    { 31, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3012), "", true, "Закрывает все тело", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3012) },
                    { 32, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3013), "", true, "Огнеупорный", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3013) },
                    { 33, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3014), "", true, "Ограничение зрения", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3015) },
                    { 34, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3016), "", true, "Полное укрытие", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3016) },
                    { 35, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3017), "", true, "Сопротивление(Д)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3017) },
                    { 36, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3018), "", true, "Сопротивление(Р)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3018) },
                    { 37, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3019), "", true, "Сопротивление(К)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3020) },
                    { 38, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3022), "", true, "Сопротивление(С)", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3022) },
                    { 39, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3023), "", true, "Горение", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3023) },
                    { 40, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3024), "", true, "Дезориентация", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3024) },
                    { 41, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3025), "", true, "Отравление", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3026) },
                    { 42, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3027), "", true, "Кровотечение", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3027) },
                    { 43, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3028), "", true, "Замораживание", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3028) },
                    { 44, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3029), "", true, "Ошеломление", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3029) },
                    { 45, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3030), "", true, "Опьянение", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3030) },
                    { 46, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3031), "", true, "Галлюцинации", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3032) },
                    { 47, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3033), "", true, "Тошнота", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3033) },
                    { 48, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3034), "", true, "Удушье", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3034) },
                    { 49, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3035), "", true, "Слепота", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3035) }
                });

            migrationBuilder.InsertData(
                table: "ItemBases",
                columns: new[] { "Id", "AvailabilityType", "CreateDate", "Description", "Enabled", "Name", "Price", "SourceId", "UpdateDate", "Weight" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3211), "testAlchemicaItem", true, "testAlchemicaItem", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3211), 1f },
                    { 2, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3234), "testArmor", true, "testArmor", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3234), 1f },
                    { 3, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3359), "testBlueprint", true, "testBlueprint", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3359), 1f },
                    { 4, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3383), "testComponent", true, "testComponent", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3384), 1f },
                    { 5, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3404), "testFormula", true, "testFormula", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3404), 1f },
                    { 6, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3426), "testItem", true, "testItem", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3426), 1f },
                    { 7, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3446), "testTool", true, "testTool", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3447), 1f },
                    { 8, 0, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3461), "testWeapon", true, "testWeapon", 0, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(3461), 1f }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "SourceId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2432), "", true, "Интеллект", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2432) },
                    { 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2435), "", true, "Реакция", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2436) },
                    { 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2437), "", true, "Ловкость", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2437) },
                    { 4, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2438), "", true, "Телосложение", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2439) },
                    { 5, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2440), "", true, "Скорость", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2440) },
                    { 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2441), "", true, "Эмпатия", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2441) },
                    { 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2442), "", true, "Ремесло", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2442) },
                    { 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2443), "", true, "Воля", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2444) },
                    { 9, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2445), "", true, "Удача", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2445) },
                    { 10, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2446), "", true, "Энергия", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2446) },
                    { 11, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2447), "", true, "Устойчивость", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2447) },
                    { 12, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2448), "", true, "Бег", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2449) },
                    { 13, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2449), "", true, "Прыжок", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2450) },
                    { 14, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2451), "", true, "Пункты Здоровья", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2451) },
                    { 15, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2452), "", true, "Выносливость", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2452) },
                    { 16, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2453), "", true, "Переносимый вес", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2453) },
                    { 17, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2454), "", true, "Отдых", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2454) },
                    { 18, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2455), "", true, "Удар рукой", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2456) },
                    { 19, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2457), "", true, "Удар ногой", 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2458) }
                });

            migrationBuilder.InsertData(
                table: "AlchemicalItems",
                columns: new[] { "Id", "ItemType" },
                values: new object[] { 1, 0 });

            migrationBuilder.InsertData(
                table: "Armors",
                columns: new[] { "Id", "AmountOfEnhancements", "ItemType", "Reliability", "Stiffness" },
                values: new object[] { 2, 0, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Blueprints",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 3, 1, 1, 0, 0f });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "Amount", "Complexity", "IsAlchemical", "ItemType", "SubstanceType", "WhereToFind" },
                values: new object[] { 4, 0, 0, false, 0, 0, "" });

            migrationBuilder.InsertData(
                table: "Formulas",
                columns: new[] { "Id", "AdditionalPayment", "Complexity", "ItemType", "TimeSpend" },
                values: new object[] { 5, 1, 1, 0, 0f });

            migrationBuilder.InsertData(
                table: "ItemBaseEffectList",
                columns: new[] { "Id", "ChancePercent", "Damage", "EffectId", "IsDealDamage", "ItemBaseId" },
                values: new object[,]
                {
                    { 1, 75, "", 2, false, 2 },
                    { 2, 0, "2к6+2", 2, true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ItemType", "StealthType", "Type" },
                values: new object[] { 6, 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "SourceId", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2477), "", true, false, false, "Внимание", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2478) },
                    { 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2481), "", true, false, false, "Выживание в дикой природе", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2482) },
                    { 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2484), "", true, false, false, "Дедукция", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2484) },
                    { 4, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2486), "", true, false, true, "Монстрология", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2486) },
                    { 5, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2487), "", true, false, false, "Образование", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2487) },
                    { 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2489), "", true, false, false, "Ориентирование в городе", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2489) },
                    { 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2490), "", true, false, false, "Передача знаний", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2490) },
                    { 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2492), "", true, false, true, "Тактика", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2492) },
                    { 9, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2493), "", true, false, false, "Торговля", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2493) },
                    { 10, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2495), "", true, false, false, "Этикет", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2495) },
                    { 11, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2496), "", true, false, true, "Язык всеобщий", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2497) },
                    { 12, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2498), "", true, false, true, "Язык Старшей Речи", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2498) },
                    { 13, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2499), "", true, false, true, "Язык краснолюдов", 1, 1, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2500) },
                    { 14, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2501), "", true, false, false, "Ближний бой", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2501) },
                    { 15, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2502), "", true, false, false, "Борьба", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2503) },
                    { 16, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2504), "", true, false, false, "Верховая езда", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2504) },
                    { 17, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2506), "", true, false, false, "Владение древковым оружием", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2506) },
                    { 18, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2507), "", true, false, false, "Владение легкими клинками", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2672) },
                    { 19, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2674), "", true, false, false, "Владение мечом", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2675) },
                    { 20, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2676), "", true, false, false, "Мореходство", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2676) },
                    { 21, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2678), "", true, false, false, "Уклонение/Изворотливость", 1, 2, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2678) },
                    { 22, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2679), "", true, false, false, "Атлетика", 1, 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2680) },
                    { 23, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2681), "", true, false, false, "Ловкость рук", 1, 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2681) },
                    { 24, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2845), "", true, false, false, "Скрытность", 1, 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2845) },
                    { 25, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2847), "", true, false, false, "Стрельба из арбалета", 1, 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2847) },
                    { 26, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2848), "", true, false, false, "Стрельба из лука", 1, 3, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2848) },
                    { 27, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2850), "", true, false, false, "Сила", 1, 4, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2850) },
                    { 28, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2851), "", true, false, false, "Стойкость", 1, 4, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2852) },
                    { 29, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2853), "", true, false, false, "Азартные игры", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2853) },
                    { 30, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2854), "", true, false, false, "Внешний вид", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2855) },
                    { 31, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2856), "", true, false, false, "Выступление", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2856) },
                    { 32, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2857), "", true, false, false, "Искусство", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2858) },
                    { 33, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2859), "", true, false, false, "Лидерство", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2859) },
                    { 34, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2860), "", true, false, false, "Обман", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2861) },
                    { 35, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2864), "", true, false, false, "Понимание людей", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2865) },
                    { 36, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2866), "", true, false, false, "Соблазнение", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2866) },
                    { 37, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2867), "", true, false, false, "Убеждение", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2868) },
                    { 38, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2869), "", true, false, false, "Харизма", 1, 6, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2870) },
                    { 39, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2871), "", true, false, true, "Алхимия", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2871) },
                    { 40, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2872), "", true, false, false, "Взлом замков", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2873) },
                    { 41, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2874), "", true, false, true, "Знание ловушек", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2874) },
                    { 42, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2923), "", true, false, true, "Изготовление", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2924) },
                    { 43, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2926), "", true, false, false, "Маскировка", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2926) },
                    { 44, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2927), "", true, false, false, "Первая помощь", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2928) },
                    { 45, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2929), "", true, false, false, "Подделывание", 1, 7, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2929) },
                    { 46, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2930), "", true, false, false, "Запугивание", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2931) },
                    { 47, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2932), "", true, false, true, "Наведение порчи", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2932) },
                    { 48, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2934), "", true, false, true, "Проведение ритуалов", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2934) },
                    { 49, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2935), "", true, false, true, "Сопротивление магии", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2935) },
                    { 50, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2937), "", true, false, false, "Сопротивление убеждению", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2937) },
                    { 51, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2941), "", true, false, true, "Сотворение заклинаний", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2941) },
                    { 52, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2942), "", true, false, false, "Храбрость", 1, 8, new DateTime(2023, 11, 23, 13, 8, 4, 339, DateTimeKind.Local).AddTicks(2943) }
                });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "ItemType" },
                values: new object[] { 7, 0 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Accuracy", "AmountOfEnhancements", "Damage", "Distance", "Grip", "IsAmmunition", "ItemType", "Reliability", "SkillId", "StealthType" },
                values: new object[] { 8, 0, 0, "", 0, 0, false, 0, 0, null, 0 });

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
