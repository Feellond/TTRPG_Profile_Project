using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection.Emit;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Entities.Database;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;
using TTRPG_Project.DAL.Entities.Database.Spells;
using TTRPG_Project.DAL.Entities.Database.Users;
using TTRPG_Project.DAL.Entities.Interface;

namespace TTRPG_Project.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Effect> Effects { get; set; }
        public DbSet<ServicePrice> ServicePrices { get; set; }
        public DbSet<Abilitiy> Abilitiys { get; set; }
        public DbSet<Attack> Attacks { get; set; }
        public DbSet<AttackEffectList> AttackEffectList { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<CreatureEffectList> CreatureEffectList { get; set; }
        public DbSet<CreatureRewardList> CreatureRewardList { get; set; }
        //public DbSet<CreatureSpellsList> CreatureSpellsList { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillsList> SkillsList { get; set; }
        public DbSet<SkillsTree> SkillsTree { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<StatsList> StatsList { get; set; }
        public DbSet<AlchemicalItem> AlchemicalItems { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Blueprint> Blueprints { get; set; }
        public DbSet<BlueprintComponentList> BlueprintComponentList { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<FormulaSubstanceList> FormulaComponentList { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemBase> ItemBases { get; set; }
        public DbSet<ItemBaseEffectList> ItemBaseEffectList { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<SpellComponentList> SpellComponentList { get; set; }
        public DbSet<SpellSkillProtectionList> SpellSkillProtectionList { get; set; }
        public DbSet<Headline> Headlines { get; set; }
        public DbSet<ServiceLog> ServiceLogs { get; set; }
        public DbSet<Source> Sources { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public override int SaveChanges()
        {
            UpdateDate();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            UpdateDate();
            return await base.SaveChangesAsync();
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateDate();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public void UpdateDate()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IEntityBase<int> || e.Entity is IEntityBase<string> && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.Entity is IEntityBase<int>)
                    ((IEntityBase<int>)entityEntry.Entity).UpdateDate = DateTime.Now;

                if (entityEntry.Entity is IEntityBase<string>)
                    ((IEntityBase<string>)entityEntry.Entity).UpdateDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    if (entityEntry.Entity is IEntityBase<int>)
                        ((IEntityBase<int>)entityEntry.Entity).CreateDate = DateTime.Now;

                    if (entityEntry.Entity is IEntityBase<string>)
                        ((IEntityBase<string>)entityEntry.Entity).CreateDate = DateTime.Now;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            /*builder.Entity<Competence>()
                .Property(e => e.TypeCompetence)
                .HasConversion<byte>();


            builder.Entity<User>()
            .Property(e => e.Gender)
            .HasConversion<byte>();*/

            builder.Entity<User>().UseTphMappingStrategy();  // TPH

            CreateDefaultData(builder);
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.IsSubclassOf(typeof(ItemBase)))
                {
                    builder.Entity(entityType.ClrType).Property<ItemType>("ItemType")
                        .HasConversion(
                            v => (int)v,
                            v => (ItemType)v);
                }
            }
        }

        public static void CreateDefaultData(ModelBuilder builder)
        {
            //TODO: Добавить описания к каждому элементу при создании дефолтных записей в БД
            builder.Entity<Source>().HasData(new Source[]
            {
                new Source{Id = 1, Name = "Базовая книга"},
                new Source{Id = 2, Name = "Хоумбрю"},
            });

            builder.Entity<Stat>().HasData(new Stat[] { 
                new Stat{Id = 1, Name = "Интеллект",  SourceId = 1},
                new Stat{Id = 2, Name = "Реакция",  SourceId = 1},
                new Stat{Id = 3, Name = "Ловкость",  SourceId = 1},
                new Stat{Id = 4, Name = "Телосложение",  SourceId = 1},
                new Stat{Id = 5, Name = "Скорость",  SourceId = 1},
                new Stat{Id = 6, Name = "Эмпатия",  SourceId = 1},
                new Stat{Id = 7, Name = "Ремесло",  SourceId = 1},
                new Stat{Id = 8, Name = "Воля",  SourceId = 1},
                new Stat{Id = 9, Name = "Удача",  SourceId = 1},
                new Stat{Id = 10, Name = "Энергия",  SourceId = 1},
                new Stat{Id = 11, Name = "Устойчивость",  SourceId = 1},
                new Stat{Id = 12, Name = "Бег",  SourceId = 1},
                new Stat{Id = 13, Name = "Прыжок",  SourceId = 1},
                new Stat{Id = 14, Name = "Пункты Здоровья",  SourceId = 1},
                new Stat{Id = 15, Name = "Выносливость",  SourceId = 1},
                new Stat{Id = 16, Name = "Переносимый вес",  SourceId = 1},
                new Stat{Id = 17, Name = "Отдых",  SourceId = 1},
                new Stat{Id = 18, Name = "Удар рукой",  SourceId = 1},
                new Stat{Id = 19, Name = "Удар ногой",  SourceId = 1},
            });

            builder.Entity<Skill>().HasData(new Skill[]{
                    //Навыки Интеллекта
                    new Skill{Id = 1, StatId = 1, Name = "Внимание",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 2, StatId = 1, Name = "Выживание в дикой природе",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 3, StatId = 1, Name = "Дедукция",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 4, StatId = 1, Name = "Монстрология",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 5, StatId = 1, Name = "Образование",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 6, StatId = 1, Name = "Ориентирование в городе",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 7, StatId = 1, Name = "Передача знаний",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 8, StatId = 1, Name = "Тактика",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 9, StatId = 1, Name = "Торговля",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 10, StatId = 1, Name = "Этикет",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 11, StatId = 1, Name = "Язык всеобщий",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 12, StatId = 1, Name = "Язык Старшей Речи",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 13, StatId = 1, Name = "Язык краснолюдов",  IsClassSkill = false, IsDifficult = true, SourceId = 1},

                    //Навыки Реакции
                    new Skill{Id = 14, StatId = 2, Name = "Ближний бой",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 15, StatId = 2, Name = "Борьба",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 16, StatId = 2, Name = "Верховая езда",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 17, StatId = 2, Name = "Владение древковым оружием",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 18, StatId = 2, Name = "Владение легкими клинками",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 19, StatId = 2, Name = "Владение мечом",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 20, StatId = 2, Name = "Мореходство",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 21, StatId = 2, Name = "Уклонение/Изворотливость",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Ловкости
                    new Skill{Id = 22, StatId = 3, Name = "Атлетика",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 23, StatId = 3, Name = "Ловкость рук",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 24, StatId = 3, Name = "Скрытность",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 25, StatId = 3, Name = "Стрельба из арбалета",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 26, StatId = 3, Name = "Стрельба из лука",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Телосложения
                    new Skill{Id = 27, StatId = 4, Name = "Сила",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 28, StatId = 4, Name = "Стойкость",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Эмпатии
                    new Skill{Id = 29, StatId = 6, Name = "Азартные игры",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 30, StatId = 6, Name = "Внешний вид",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 31, StatId = 6, Name = "Выступление",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 32, StatId = 6, Name = "Искусство",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 33, StatId = 6, Name = "Лидерство",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 34, StatId = 6, Name = "Обман",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 35, StatId = 6, Name = "Понимание людей",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 36, StatId = 6, Name = "Соблазнение",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 37, StatId = 6, Name = "Убеждение",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 38, StatId = 6, Name = "Харизма",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Ремесла
                    new Skill{Id = 39, StatId = 7, Name = "Алхимия",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 40, StatId = 7, Name = "Взлом замков",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 41, StatId = 7, Name = "Знание ловушек",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 42, StatId = 7, Name = "Изготовление",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 43, StatId = 7, Name = "Маскировка",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 44, StatId = 7, Name = "Первая помощь",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 45, StatId = 7, Name = "Подделывание",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Воли
                    new Skill{Id = 46, StatId = 8, Name = "Запугивание",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 47, StatId = 8, Name = "Наведение порчи",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 48, StatId = 8, Name = "Проведение ритуалов",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 49, StatId = 8, Name = "Сопротивление магии",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 50, StatId = 8, Name = "Сопротивление убеждению",  IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 51, StatId = 8, Name = "Сотворение заклинаний",  IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 52, StatId = 8, Name = "Храбрость",  IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Далее должны идти классовые навыки
                });

            builder.Entity<Effect>().HasData(new Effect[]
            {
                //Эффекты предметов
                new Effect{Id = 1, Name = "Незаметное",  SourceId = 1},
                new Effect{Id = 2, Name = "Кровопускающее",  SourceId = 1},
                new Effect{Id = 3, Name = "Пробивающее броню",  SourceId = 1},
                new Effect{Id = 4, Name = "Дезориентирующее(1)",  SourceId = 1},
                new Effect{Id = 5, Name = "Дезориентирующее(2)",  SourceId = 1},
                new Effect{Id = 6, Name = "Дезориентирующее(3)",  SourceId = 1},
                new Effect{Id = 7, Name = "Метеоритное",  SourceId = 1},
                new Effect{Id = 8, Name = "Длинное",  SourceId = 1},
                new Effect{Id = 9, Name = "Фокусирующее(1)",  SourceId = 1},
                new Effect{Id = 10, Name = "Фокусирующее(2)",  SourceId = 1},
                new Effect{Id = 11, Name = "Фокусирующее(3)",  SourceId = 1},
                new Effect{Id = 12, Name = "Сокрушающая сила",  SourceId = 1},
                new Effect{Id = 13, Name = "Серебрянное",  SourceId = 1},
                new Effect{Id = 14, Name = "Сбалансированное(1)",  SourceId = 1},
                new Effect{Id = 15, Name = "Сбалансированное(2)",  SourceId = 1},
                new Effect{Id = 16, Name = "Сбалансированное(3)",  SourceId = 1},
                new Effect{Id = 17, Name = "Улучшенное пробивание брони",  SourceId = 1},
                new Effect{Id = 18, Name = "Захватное",  SourceId = 1},
                new Effect{Id = 19, Name = "Ловящий лезвия",  SourceId = 1},
                new Effect{Id = 20, Name = "Магические путы",  SourceId = 1},
                new Effect{Id = 21, Name = "Медленно перезаряжающееся",  SourceId = 1},
                new Effect{Id = 22, Name = "Несмертельное",  SourceId = 1},
                new Effect{Id = 23, Name = "Опутывающее",  SourceId = 1},
                new Effect{Id = 24, Name = "Парирующее",  SourceId = 1},
                new Effect{Id = 25, Name = "Разрушающее",  SourceId = 1},
                new Effect{Id = 26, Name = "Рукопашное",  SourceId = 1},
                new Effect{Id = 27, Name = "Расчетная перезарядка",  SourceId = 1},
                new Effect{Id = 28, Name = "Улучшенное фокусирующее",  SourceId = 1},
                new Effect{Id = 29, Name = "Устанавливаемое",  SourceId = 1},
                new Effect{Id = 30, Name = "Шприц",  SourceId = 1},
                new Effect{Id = 31, Name = "Закрывает все тело",  SourceId = 1},
                new Effect{Id = 32, Name = "Огнеупорный",  SourceId = 1},
                new Effect{Id = 33, Name = "Ограничение зрения",  SourceId = 1},
                new Effect{Id = 34, Name = "Полное укрытие",  SourceId = 1},
                new Effect{Id = 35, Name = "Сопротивление(Д)",  SourceId = 1},
                new Effect{Id = 36, Name = "Сопротивление(Р)",  SourceId = 1},
                new Effect{Id = 37, Name = "Сопротивление(К)",  SourceId = 1},
                new Effect{Id = 38, Name = "Сопротивление(С)",  SourceId = 1},

                //Эффекты в целом
                new Effect{Id = 39, Name = "Горение",  SourceId = 1},
                new Effect{Id = 40, Name = "Дезориентация",  SourceId = 1},
                new Effect{Id = 41, Name = "Отравление",  SourceId = 1},
                new Effect{Id = 42, Name = "Кровотечение",  SourceId = 1},
                new Effect{Id = 43, Name = "Замораживание",  SourceId = 1},
                new Effect{Id = 44, Name = "Ошеломление",  SourceId = 1},
                new Effect{Id = 45, Name = "Опьянение",  SourceId = 1},
                new Effect{Id = 46, Name = "Галлюцинации",  SourceId = 1},
                new Effect{Id = 47, Name = "Тошнота",  SourceId = 1},
                new Effect{Id = 48, Name = "Удушье",  SourceId = 1},
                new Effect{Id = 49, Name = "Слепота",  SourceId = 1},
            });

            //ВСЕ НИЖЕ ДЛЯ ТЕСТА, ПОСЛЕ НАДО БД ПЕРЕСОБРАТЬ!!!

            var alchItem = new AlchemicalItem[]
            {
                new AlchemicalItem{
                    Id = 1,
                    Name = "Обезболивающие травы",
                    SourceId = 1,
                    Weight = 0.1,
                    Description = "Прикладывание к ране обезболивающих трав притупляет боль, " +
                    "снижая штраф от критических ранений и состояния «при смерти» на 2. " +
                    "Эффект действует 2d10 раундов.",
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    Price = 12,
                }
            };

            builder.Entity<AlchemicalItem>().HasData(alchItem);

            var armor = new Armor[]
            {
                new Armor{
                    Id = 2,
                    Name = "Капюшон вердэнского лучника",
                    SourceId = 1,
                    Weight = 0.5,
                    Description = "Вердонские лучники — крепкие ребята. " +
                    "Обычно они не слишком усердствуют с бронёй — дриады-то всёравно в щели между доспехами дротик-другой засадят. " +
                    "Зато они носят хорошие плотные капюшоны, расшитые сине-чёрным стрельчатым узором.",
                    Type = (int)ArmorType.Light,
                    Reliability = 3,
                    AmountOfEnhancements = 1,
                    Stiffness = 0,
                    Price = 100,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    EquipmentType = (int)ArmorEquipmentType.Head,
                    ItemOriginType = (int)ItemOriginType.Human,
                }
            };

            builder.Entity<Armor>().HasData(armor);

            var itemEffectList = new ItemBaseEffectList[]
            {
                new ItemBaseEffectList{Id = 1, EffectId = 2, ItemBaseId = armor[0].Id, IsDealDamage = false, ChancePercent = 75},
                new ItemBaseEffectList{Id = 2, EffectId = 2, ItemBaseId = alchItem[0].Id, IsDealDamage = true, Damage = "2к6+2"},
                new ItemBaseEffectList{Id = 3, EffectId = 1, ItemBaseId = 54,},
            };

            builder.Entity<ItemBaseEffectList>().HasData(itemEffectList);

            builder.Entity<Component>().HasData(new Component[]
            {
                new Component{
                    Id = 3,
                    Name = "Пепел",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 1,
                    Amount = "1к10",
                    Complexity = 10,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Campfire + " и " + WhereToFindEnum.Burned},
                new Component{
                    Id = 4,
                    Name = "Уголь",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 1,
                    Amount = "1к10",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Campfire + ", " + WhereToFindEnum.Mountains + " или " + WhereToFindEnum.Underground},
                new Component{
                    Id = 5,
                    Name = "Хлопок",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 1,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields + " и " + WhereToFindEnum.Plantations},
                new Component{
                    Id = 6,
                    Name = "Двойное полотно",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 22,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 7,
                    Name = "Стекло",
                    SourceId = 1,
                    Weight = 0.5,
                    Price = 5,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy},
                new Component{
                    Id = 8,
                    Name = "Укрепленное дерево",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 16,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 9, 
                    Name = "Полотно", 
                    SourceId = 1, 
                    Weight = 0.1, 
                    Price = 9,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Buy + " или " + WhereToFindEnum.Craft},
                new Component{
                    Id = 10,
                    Name = "Масло",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 3,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 11,
                    Name = "Смлоа",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 2,
                    Amount = "1к6",
                    Complexity = 10,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Forests},
                new Component{
                    Id = 12,
                    Name = "Шелк",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 50,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy},
                new Component{
                    Id = 13,
                    Name = "Нитки",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 3,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Buy + " или " + WhereToFindEnum.Craft},
                new Component{
                    Id = 14,
                    Name = "Древесина",
                    SourceId = 1,
                    Weight = 1,
                    Price = 3,
                    Amount = "2к6",
                    Complexity = 8,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Forests},
                new Component{
                    Id = 15,
                    Name = "Воск",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 2,
                    Amount = "1к6",
                    Complexity = 12,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields},
                new Component{
                    Id = 16,
                    Name = "Кости животных",
                    SourceId = 1,
                    Weight = 4,
                    Price = 8,
                    Amount = "Варьируется",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Monsters + " и " + WhereToFindEnum.Animals},
                new Component{
                    Id = 17,
                    Name = "Коровья шкура",
                    SourceId = 1,
                    Weight = 5,
                    Price = 10,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Buy},
                new Component{
                    Id = 18,
                    Name = "Кожа драконида",
                    SourceId = 1,
                    Weight = 5,
                    Price = 58,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 19,
                    Name = "Чешуя драконида",
                    SourceId = 1,
                    Weight = 5,
                    Price = 30,
                    Amount = "1к6",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Wyverns},
                new Component{
                    Id = 20,
                    Name = "Перья",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 4,
                    Amount = "1к6",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Birds},
                new Component{
                    Id = 21,
                    Name = "Укрепленная кожа",
                    SourceId = 1,
                    Weight = 3,
                    Price = 48,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 22,
                    Name = "Кожа", 
                    SourceId = 1, 
                    Weight = 2, 
                    Price = 28,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Buy + " или " + WhereToFindEnum.Craft},
                new Component{
                    Id = 23,
                    Name = "Лирийская кожа",
                    SourceId = 1,
                    Weight = 2,
                    Price = 60,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 24,
                    Name = "Волчья шкура",
                    SourceId = 1,
                    Weight = 3,
                    Price = 14,
                    Amount = "3",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Wolfs},
                new Component{
                    Id = 25,
                    Name = "Чернящее масло",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 24,
                    Amount = "1к6",
                    Complexity = 16,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Forests},
                new Component{
                    Id = 26,
                    Name = "Масло из дрейка",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 45,
                    Amount = "1к6",
                    Complexity = 16,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Rivers + " и " + WhereToFindEnum.Coastline},
                new Component{
                    Id = 27,
                    Name = "Эфирная смазка",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields},
                new Component{
                    Id = 28,
                    Name = "Травильная кислота",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 2,
                    Amount = "1к10",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Caves + " и " + WhereToFindEnum.Mountains},
                new Component{
                    Id = 29,
                    Name = "Пятая эссенция",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 82,
                    Amount = "Варьируется",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.PowerPlace + ", " + WhereToFindEnum.Mages + " и " + WhereToFindEnum.Imps},
                new Component{
                    Id = 30,
                    Name = "Огров воск",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 10,
                    Amount = "1к10",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Caves},
                new Component{
                    Id = 31,
                    Name = "Точильный порошок",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 32,
                    Amount = "1к6",
                    Complexity = 16,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Caves},
                new Component{
                    Id = 32,
                    Name = "Дубильные травы",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 3,
                    Amount = "1к10",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields + " и " + WhereToFindEnum.Forests},
                new Component{
                    Id = 33,
                    Name = "Темное железо",
                    SourceId = 1,
                    Weight = 1.5,
                    Price = 52,
                    Amount = "1к6",
                    Complexity = 18,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 34,
                    Name = "Темная сталь",
                    SourceId = 1,
                    Weight = 1,
                    Price = 82,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 35,
                    Name = "Двимерит",
                    SourceId = 1,
                    Weight = 1,
                    Price = 240,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 36,
                    Name = "Самоцветы",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 100,
                    Amount = "1к6/2",
                    Complexity = 24,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 37,
                    Name = "Совершенный самоцвет",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 1000,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 38,
                    Name = "Светящаяся руда",
                    SourceId = 1,
                    Weight = 1,
                    Price = 80,
                    Amount = "1к6/2",
                    Complexity = 20,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 39,
                    Name = "Золото",
                    SourceId = 1,
                    Weight = 1,
                    Price = 85,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 40,
                    Name = "Железо",
                    SourceId = 1,
                    Weight = 1.5,
                    Price = 30,
                    Amount = "1к6",
                    Complexity = 16,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 41,
                    Name = "Махакамский двимерит",
                    SourceId = 1,
                    Weight = 1,
                    Price = 300,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 42,
                    Name = "Махакамская сталь",
                    SourceId = 1,
                    Weight = 1,
                    Price = 114,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 43,
                    Name = "Метеорит",
                    SourceId = 1,
                    Weight = 1,
                    Price = 98,
                    Amount = "1к6/2",
                    Complexity = 24,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Anywhere},
                new Component{
                    Id = 44,
                    Name = "Речная глина",
                    SourceId = 1,
                    Weight = 1.5,
                    Price = 5,
                    Amount = "1к6",
                    Complexity = 14,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Rivers + " и " + WhereToFindEnum.RiversCoast},
                new Component{
                    Id = 45,
                    Name = "Серебро",
                    SourceId = 1,
                    Weight = 1,
                    Price = 72,
                    Amount = "1к6/2",
                    Complexity = 16,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
                new Component{
                    Id = 46,
                    Name = "Сталь",
                    SourceId = 1,
                    Weight = 1,
                    Price = 48,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 47,
                    Name = "Камень",
                    SourceId = 1,
                    Weight = 2,
                    Price = 4,
                    Amount = "2к6",
                    Complexity = 8,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Everywhere},
                new Component{
                    Id = 48,
                    Name = "Третогорская сталь",
                    SourceId = 1,
                    Weight = 1,
                    Price = 64,
                    Amount = "",
                    Complexity = 0,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Buy + " и " + WhereToFindEnum.Craft},
                new Component{
                    Id = 49,
                    Name = "Зерриканская смесь",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 30,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = false,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground},
            });

            builder.Entity<Blueprint>().HasData(new Blueprint[]
            {
                new Blueprint{
                    Id = 50,
                    AdditionalPayment = 70,
                    Price = 150,
                    AvailabilityType = (int)ItemAvailabilityType.Common, 
                    Complexity = 10,
                    Name = "Чертеж «Капюшон вердэнского лучника»", 
                    SourceId = 1,
                    TimeSpend = 3,
                }
            });

            builder.Entity<BlueprintComponentList>().HasData(new BlueprintComponentList[]
            {
                new BlueprintComponentList{Id = 1, BlueprintId = 50, ComponentId = 9, Amount = 2},
                new BlueprintComponentList{Id = 2, BlueprintId = 50, ComponentId = 22, Amount = 1},
                new BlueprintComponentList{Id = 3, BlueprintId = 50, ComponentId = 13, Amount = 6},
                new BlueprintComponentList{Id = 4, BlueprintId = 50, ComponentId = 15, Amount = 3},
            });

            builder.Entity<Formula>().HasData(new Formula[]
            {
                new Formula{
                    Id = 51,
                    AdditionalPayment = 1, 
                    AvailabilityType = 1, 
                    Complexity = 1, 
                    Name = "Формула «Обезболивающие травы»", 
                    SourceId = 1, 
                    Weight = 1,}
            });

            builder.Entity<FormulaSubstanceList>().HasData(new FormulaSubstanceList[]
            {
                new FormulaSubstanceList{Id = 1, FormulaId = 51, SubstanceType = (int)SubstanceType.Quebrith, Amount = 1},
                new FormulaSubstanceList{Id = 2, FormulaId = 51, SubstanceType = (int)SubstanceType.Vermilion, Amount = 1},
            });

            builder.Entity<Item>().HasData(new Item[]
            {
                new Item{
                    Id = 52, 
                    Name = "Веревка (20 метров)", 
                    SourceId = 1, 
                    Weight = 1.5,
                    Price = 20,
                    Description = "Всегда с собой таскай верёвку." +
                    "Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. " +
                    "Ситуаций, где нужна верёвка, предостаточно"
                }
            });

            builder.Entity<Tool>().HasData(new Tool[]
            {
                new Tool{Id = 53, 
                    Name = "Инструменты алхимика", 
                    SourceId = 1, 
                    Weight = 3, 
                    Price = 80, 
                    StealthType = (int)ItemStealthType.Large,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    Description = "Позволяют создавать алхимические составы"}
            });

            builder.Entity<Weapon>().HasData(new Weapon[]
            {
                new Weapon{
                    Id = 54,
                    Name = "Стилет", 
                    SourceId = 1, 
                    Weight = 0.5,
                    Price = 275,
                    Type = (int)AttackType.PiercingAndSlashing,
                    Accuracy = 1,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    Damage = "1к6",
                    Reliability = 5,
                    Grip = 1,
                    Distance = 0,
                    StealthType = (int)ItemStealthType.Tiny,
                    AmountOfEnhancements = 1,
                }
            });
        }
    }
}
