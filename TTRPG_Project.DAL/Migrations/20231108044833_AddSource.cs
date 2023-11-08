using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TTRPG_Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Stats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Spells",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "SkillsTree",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "ServicePrices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "ItemsBase",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Headlines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Effects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Creatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Attacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Effects",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "Source", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2227), "", true, "Незаметное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2227) },
                    { 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2228), "", true, "Кровопускающее", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2229) },
                    { 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2230), "", true, "Пробивающее броню", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2230) },
                    { 4, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2231), "", true, "Дезориентирующее(1)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2231) },
                    { 5, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2232), "", true, "Дезориентирующее(2)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2232) },
                    { 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2251), "", true, "Дезориентирующее(3)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2251) },
                    { 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2252), "", true, "Метеоритное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2252) },
                    { 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2253), "", true, "Длинное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2254) },
                    { 9, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2254), "", true, "Фокусирующее(1)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2255) },
                    { 10, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2255), "", true, "Фокусирующее(2)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2256) },
                    { 11, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2257), "", true, "Фокусирующее(3)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2257) },
                    { 12, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2258), "", true, "Сокрушающая сила", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2258) },
                    { 13, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2259), "", true, "Серебрянное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2259) },
                    { 14, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2260), "", true, "Сбалансированное(1)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2260) },
                    { 15, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2261), "", true, "Сбалансированное(2)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2261) },
                    { 16, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2262), "", true, "Сбалансированное(3)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2262) },
                    { 17, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2263), "", true, "Улучшенное пробивание брони", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2263) },
                    { 18, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2264), "", true, "Захватное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2264) },
                    { 19, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2265), "", true, "Ловящий лезвия", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2266) },
                    { 20, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2266), "", true, "Магические путы", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2267) },
                    { 21, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2267), "", true, "Медленно перезаряжающееся", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2268) },
                    { 22, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2268), "", true, "Несмертельное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2269) },
                    { 23, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2269), "", true, "Опутывающее", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2270) },
                    { 24, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2270), "", true, "Парирующее", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2271) },
                    { 25, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2271), "", true, "Разрушающее", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2272) },
                    { 26, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2272), "", true, "Рукопашное", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2273) },
                    { 27, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2273), "", true, "Расчетная перезарядка", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2274) },
                    { 28, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2274), "", true, "Улучшенное фокусирующее", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2275) },
                    { 29, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2275), "", true, "Устанавливаемое", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2276) },
                    { 30, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2276), "", true, "Шприц", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2277) },
                    { 31, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2278), "", true, "Закрывает все тело", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2278) },
                    { 32, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2279), "", true, "Огнеупорный", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2279) },
                    { 33, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2279), "", true, "Ограничение зрения", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2280) },
                    { 34, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2280), "", true, "Полное укрытие", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2281) },
                    { 35, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2281), "", true, "Сопротивление(Д)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2282) },
                    { 36, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2282), "", true, "Сопротивление(Р)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2283) },
                    { 37, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2283), "", true, "Сопротивление(К)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2284) },
                    { 38, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2285), "", true, "Сопротивление(С)", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2286) },
                    { 39, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2286), "", true, "Горение", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2287) },
                    { 40, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2287), "", true, "Дезориентация", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2288) },
                    { 41, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2288), "", true, "Отравление", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2289) },
                    { 42, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2289), "", true, "Кровотечение", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2290) },
                    { 43, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2290), "", true, "Замораживание", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2291) },
                    { 44, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2291), "", true, "Ошеломление", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2292) },
                    { 45, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2292), "", true, "Опьянение", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2293) },
                    { 46, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2293), "", true, "Галлюцинации", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2294) },
                    { 47, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2294), "", true, "Тошнота", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2295) },
                    { 48, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2295), "", true, "Удушье", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2296) },
                    { 49, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2296), "", true, "Слепота", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2297) }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "IsClassSkill", "IsDifficult", "Name", "Source", "StatId", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2132), "", true, false, false, "Внимание", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2133) },
                    { 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2136), "", true, false, false, "Выживание в дикой природе", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2136) },
                    { 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2137), "", true, false, false, "Дедукция", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2137) },
                    { 4, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2138), "", true, false, true, "Монстрология", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2139) },
                    { 5, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2140), "", true, false, false, "Образование", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2140) },
                    { 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2141), "", true, false, false, "Ориентирование в городе", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2141) },
                    { 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2142), "", true, false, false, "Передача знаний", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2143) },
                    { 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2145), "", true, false, true, "Тактика", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2145) },
                    { 9, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2146), "", true, false, false, "Торговля", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2146) },
                    { 10, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2147), "", true, false, false, "Этикет", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2147) },
                    { 11, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2148), "", true, false, true, "Язык всеобщий", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2149) },
                    { 12, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2150), "", true, false, true, "Язык Старшей Речи", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2150) },
                    { 13, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2151), "", true, false, true, "Язык краснолюдов", "", 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2151) },
                    { 14, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2152), "", true, false, false, "Ближний бой", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2153) },
                    { 15, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2154), "", true, false, false, "Борьба", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2154) },
                    { 16, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2155), "", true, false, false, "Верховая езда", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2155) },
                    { 17, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2156), "", true, false, false, "Владение древковым оружием", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2157) },
                    { 18, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2158), "", true, false, false, "Владение легкими клинками", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2158) },
                    { 19, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2159), "", true, false, false, "Владение мечом", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2159) },
                    { 20, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2160), "", true, false, false, "Мореходство", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2160) },
                    { 21, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2161), "", true, false, false, "Уклонение/Изворотливость", "", 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2162) },
                    { 22, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2163), "", true, false, false, "Атлетика", "", 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2163) },
                    { 23, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2164), "", true, false, false, "Ловкость рук", "", 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2164) },
                    { 24, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2165), "", true, false, false, "Скрытность", "", 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2165) },
                    { 25, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2166), "", true, false, false, "Стрельба из арбалета", "", 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2167) },
                    { 26, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2168), "", true, false, false, "Стрельба из лука", "", 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2168) },
                    { 27, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2170), "", true, false, false, "Сила", "", 4, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2170) },
                    { 28, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2171), "", true, false, false, "Стойкость", "", 4, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2171) },
                    { 29, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2172), "", true, false, false, "Азартные игры", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2173) },
                    { 30, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2174), "", true, false, false, "Внешний вид", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2174) },
                    { 31, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2175), "", true, false, false, "Выступление", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2175) },
                    { 32, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2176), "", true, false, false, "Искусство", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2176) },
                    { 33, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2177), "", true, false, false, "Лидерство", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2178) },
                    { 34, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2179), "", true, false, false, "Обман", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2179) },
                    { 35, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2180), "", true, false, false, "Понимание людей", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2180) },
                    { 36, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2181), "", true, false, false, "Соблазнение", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2181) },
                    { 37, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2182), "", true, false, false, "Убеждение", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2183) },
                    { 38, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2184), "", true, false, false, "Харизма", "", 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2184) },
                    { 39, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2185), "", true, false, true, "Алхимия", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2185) },
                    { 40, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2186), "", true, false, false, "Взлом замков", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2186) },
                    { 41, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2187), "", true, false, true, "Знание ловушек", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2188) },
                    { 42, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2189), "", true, false, true, "Изготовление", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2189) },
                    { 43, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2190), "", true, false, false, "Маскировка", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2190) },
                    { 44, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2191), "", true, false, false, "Первая помощь", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2191) },
                    { 45, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2192), "", true, false, false, "Подделывание", "", 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2193) },
                    { 46, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2194), "", true, false, false, "Запугивание", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2194) },
                    { 47, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2196), "", true, false, true, "Наведение порчи", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2196) },
                    { 48, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2197), "", true, false, true, "Проведение ритуалов", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2197) },
                    { 49, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2198), "", true, false, true, "Сопротивление магии", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2199) },
                    { 50, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2200), "", true, false, false, "Сопротивление убеждению", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2200) },
                    { 51, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2201), "", true, false, true, "Сотворение заклинаний", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2201) },
                    { 52, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2202), "", true, false, false, "Храбрость", "", 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2202) }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "CreateDate", "Description", "Enabled", "Name", "Source", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1947), "", true, "Интеллект", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1955) },
                    { 2, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1982), "", true, "Реакция", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1982) },
                    { 3, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1983), "", true, "Ловкость", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1983) },
                    { 4, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1984), "", true, "Телосложение", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1985) },
                    { 5, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1985), "", true, "Скорость", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1986) },
                    { 6, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1987), "", true, "Эмпатия", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1987) },
                    { 7, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1988), "", true, "Ремесло", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1988) },
                    { 8, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1989), "", true, "Воля", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1989) },
                    { 9, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1990), "", true, "Удача", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1990) },
                    { 10, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1991), "", true, "Энергия", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1991) },
                    { 11, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1992), "", true, "Устойчивость", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1992) },
                    { 12, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1993), "", true, "Бег", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1993) },
                    { 13, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1994), "", true, "Прыжок", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1994) },
                    { 14, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1995), "", true, "Пункты Здоровья", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1995) },
                    { 15, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1996), "", true, "Выносливость", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1996) },
                    { 16, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1997), "", true, "Переносимый вес", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1997) },
                    { 17, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1998), "", true, "Отдых", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1998) },
                    { 18, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1999), "", true, "Удар рукой", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(1999) },
                    { 19, new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2000), "", true, "Удар ногой", "", new DateTime(2023, 11, 8, 11, 48, 32, 727, DateTimeKind.Local).AddTicks(2000) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Effects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Stats");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Spells");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "SkillsTree");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "ServicePrices");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "ItemsBase");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Headlines");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Effects");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Creatures");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Attacks");

            migrationBuilder.DropColumn(
                name: "Source",
                table: "Abilities");
        }
    }
}
