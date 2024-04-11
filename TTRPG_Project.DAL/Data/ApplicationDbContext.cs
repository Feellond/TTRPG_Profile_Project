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
        public DbSet<Ability> Abilitiys { get; set; }
        public DbSet<Attack> Attacks { get; set; }
        public DbSet<AttackEffectList> AttackEffectList { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<CreatureAttack> CreatureAttacks { get; set; }
        public DbSet<CreatureReward> CreatureRewardList { get; set; }
        public DbSet<Reward> Rewards { get; set; }
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
                    new Skill
                    {
                        Id = 53,
                        StatId = 1,
                        Name = "Подготовка ведьмака",
                        Description = "Большинство ведьмаков проводят детство и юность в крепости, корпя над пыльными томами и проходя чудовищные боевые тренировки." +
                        " Многие говорят, что главное оружие ведьмака — это знания о чудовищах и умение найти выход из любой ситуации. Находясь в опасной среде или" +
                        " на пересечённой местности, ведьмак может снизить соответствующие штрафы на половину значения своего навыка Подготовка ведьмака (минимум 1)." +
                        " Подготовку ведьмака также можно использовать в любой ситуации, где понадобился бы навык Монстрология.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 54,
                        Name = "Магический клинок",
                        Description = "Ведьмак может войти в медитативный транс, что позволяет ему получить все преимущества сна, но при этом сохранять бдительность. " +
                        "Во время медитации ведьмак считается находящимся в сознании для того, чтобы заметить что-либо в радиусе в метрах, равном удвоенному значению его Медитации.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 55,
                        Name = "Магический источник",
                        Description = "По мере того как ведьмак всё больше использует знаки, его тело постепенно привыкает к течению магической энергии. Каждые 2 очка," +
                        " вложенные в способность Магический источник, повышают значение Энергии ведьмака на 1. Когда эта способность достигает 10 уровня, максимальное" +
                        " значение Энергии ведьмака становится равно 7. Эта способность развивается аналогично прочим навыкам.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 56,
                        StatId = 8,
                        Name = "Гелиотроп",
                        Description = "Когда ведьмак становится целью заклинания, инвокации или порчи, он может совершить проверку способности Гелиотроп, чтобы попытаться" +
                        " отменить эффект. Он должен выкинуть результат, который больше либо равен результату его противника, а также потратить количество Выносливости," +
                        " равное половине Выносливости, затраченной на сотворение магии.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 57,
                        Name = "Крепкий желудок",
                        Description = "а годы употребления ядовитых ведьмачьих эликсиров ведьмаки привыкают к токсинам. Ведьмак может выдержать отвары и эликсиры суммарной" +
                        " токсичностью на 5% больше за каждые 2 очка, вложенные в способность Крепкий желудок. Эта способность развивается аналогично прочим навыкам." +
                        " На 10 уровне максимальная токсичность для ведьмака равна 150%.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 58,
                        Name = "Ярость",
                        Description = "Будучи отравленным, ведьмак впадает в ярость и наносит дополнительно 1 урон в ближнем бою за каждый уровень Ярости. В этом" +
                        " состоянии единственная цель ведьмака — добраться до безопасного места или убить отравителя. Действие Ярости заканчивается одновременно" +
                        " с действием яда. Ведьмак может попытаться избавиться от Ярости раньше, совершив проверку Стойкости со СЛ 15.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 59,
                        StatId = 4,
                        Name = "Трансмутация",
                        Description = "Принимая отвар, ведьмак может совершить проверку Трансмутации со СЛ 18. При успехе тело ведьмака принимает в себя несколько" +
                        " больше мутагена, чем обычно, что позволяет получить бонус в зависимости от принятого отвара (см. таблицу на полях). Длительность действия" +
                        " отвара уменьшается вдвое. Дополнительные мутации слишком малы, чтобы их заметить.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 60,
                        StatId = 3,
                        Name = "Отбивание стрел",
                        Description = "Ведьмак может совершить проверку этой способности со штрафом -3, чтобы отбить летящий физический снаряд. При отбивании ведьмак" +
                        " может выбрать цель в пределах 10 м. Эта цель должна совершить действие защиты против броска Отбивания стрел ведьмака, или она будет ошеломлена" +
                        " из-за попадания отбитого снаряда.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 61,
                        StatId = 2,
                        Name = "Быстрый удар",
                        Description = "Закончив свой ход, ведьмак может потратить 5 очков Вын и совершить проверку Быстрого удара со СЛ, равной Реа противника хЗ." +
                        " При успехе ведьмак совершает ещё одну атаку в этот раунд против этого противника, которая может включать в себя разоружение, подсечку и прочие атаки.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 62,
                        StatId = 2,
                        Name = "Вихрь",
                        Description = "Потратив 5 очков Вын за раунд, ведьмак может закрутиться в Вихре, совершая каждый ход по одной атаке против всех, кто находится" +
                        " в пределах дистанции его меча. Проверка Вихрясчитается проверкой атаки. Находясь в Вихре, ведьмак может только поддерживать его, уклоняться" +
                        " и передвигаться на 2 метра за раунд. Любое другое действие или полученный удар прекращают Вихрь.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
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

                new Effect{Id = 50, Name = "Дистанция", SourceId = 1},
                new Effect{Id = 51, Name = "Точность+1", SourceId = 1},
                new Effect{Id = 52, Name = "Точность+2", SourceId = 1},
                new Effect{Id = 53, Name = "Точность+3", SourceId = 1},
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
                    WhereToFind = WhereToFindEnum.Campfire + " и " + WhereToFindEnum.Burned,
                },
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

                #region Алхимические ингредиенты
                new Component{
                    Id = 50,
                    Name = "Зеленая плесень",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Caelum,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Caves,
                },
                new Component{
                    Id = 51,
                    Name = "Переступень",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Caelum,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Cities,
                },
                new Component{
                    Id = 52,
                    Name = "Помет беса",
                    SourceId = 1,
                    Weight = 1,
                    Price = 20,
                    Amount = "1к6/2",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Caelum,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.ImpTerritory + " или " + WhereToFindEnum.Imps,
                },
                new Component{
                    Id = 53,
                    Name = "Омела",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Hydragenium,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields + " и " + WhereToFindEnum.Forests,
                },
                new Component{
                    Id = 54,
                    Name = "Паутинник",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 18,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Hydragenium,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Forests,
                },
                new Component{
                    Id = 55,
                    Name = "Optima mater",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 100,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 56,
                    Name = "Жимолость",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 21,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 57,
                    Name = "Листья балиссы",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 58,
                    Name = "Сера",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 14,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 59,
                    Name = "Собачья петрушка",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 2,
                    Amount = "2к6",
                    Complexity = 10,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 60,
                    Name = "Царская водка",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 20,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 61,
                    Name = "Аконит",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 9,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vermilion,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields + ", " + WhereToFindEnum.Forests + " и " + WhereToFindEnum.Mountains,
                },
                new Component{
                    Id = 62,
                    Name = "Корень лопуха",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 32,
                    Amount = "1к6",
                    Complexity = 16,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vermilion,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 63,
                    Name = "Корень мандрагоры",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 65,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vermilion,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 64,
                    Name = "Фосфор",
                    SourceId = 1,
                    Weight = 0.5,
                    Price = 20,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vermilion,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 65,
                    Name = "Calcium equum",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 12,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 66,
                    Name = "Вороний глаз",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 17,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 67,
                    Name = "Грибы-шибальцы",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 17,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Mountains,
                },
                new Component{
                    Id = 68,
                    Name = "Лепестки белого мирта",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 69,
                    Name = "Плод балиссы",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 70,
                    Name = "Ячмень",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 9,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Vitriol,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 71,
                    Name = "Винный камень",
                    SourceId = 1,
                    Weight = 0.5,
                    Price = 88,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Rebis,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Distilleries,
                },
                new Component{
                    Id = 72,
                    Name = "Волокна хана",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 17,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Rebis,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 73,
                    Name = "Ласточкина трава",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 8,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Rebis,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 74,
                    Name = "Лунная крошка",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 91,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Rebis,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Monsters + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 75,
                    Name = "Вербена",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 18,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Sol,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 76,
                    Name = "Листья волчьего алоэ",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 39,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Sol,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.BlueMountains,
                },
                new Component{
                    Id = 77,
                    Name = "Краснолюдский бессмертник",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 75,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Fulgur,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 78,
                    Name = "Эмбрион эндриаги",
                    SourceId = 1,
                    Weight = 1.5,
                    Price = 55,
                    Amount = "1к6",
                    Complexity = 0,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Fulgur,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.EndriagNests,
                },
                new Component{
                    Id = 79,
                    Name = "Жемчуг",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 100,
                    Amount = "1к6/3",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.OceanFloor + " и " + WhereToFindEnum.Coastline,
                },
                new Component{
                    Id = 80,
                    Name = "Корень зарника",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 18,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 81,
                    Name = "Лепестки гинации",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 17,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Fields,
                },
                new Component{
                    Id = 82,
                    Name = "Лепестки морозника",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 19,
                    Amount = "1к6",
                    Complexity = 15,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Poor,
                    WhereToFind = WhereToFindEnum.Forests,
                },
                new Component{
                    Id = 83,
                    Name = "Плод берберки",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 9,
                    Amount = "1к10",
                    Complexity = 12,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Swamps,
                },
                new Component{
                    Id = 84,
                    Name = "Ртутный раствор",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 77,
                    Amount = "1к6/2",
                    Complexity = 18,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = WhereToFindEnum.Mountains + " и " + WhereToFindEnum.Underground,
                },
                new Component{
                    Id = 85,
                    Name = "Склеродерм",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 5,
                    Amount = "2к6",
                    Complexity = 10,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Aether,
                    AvailabilityType = (int)ItemAvailabilityType.Everywhere,
                    WhereToFind = WhereToFindEnum.Forests + " и " + WhereToFindEnum.Caves,
                },
                #endregion
            });

            builder.Entity<Blueprint>().HasData(new Blueprint[]
            {
                new Blueprint{
                    Id = 86,
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
                new BlueprintComponentList{Id = 1, BlueprintId = 86, ComponentId = 9, Amount = 2},
                new BlueprintComponentList{Id = 2, BlueprintId = 86, ComponentId = 22, Amount = 1},
                new BlueprintComponentList{Id = 3, BlueprintId = 86, ComponentId = 13, Amount = 6},
                new BlueprintComponentList{Id = 4, BlueprintId = 86, ComponentId = 15, Amount = 3},
            });

            builder.Entity<Formula>().HasData(new Formula[]
            {
                new Formula{
                    Id = 87,
                    AdditionalPayment = 1,
                    AvailabilityType = 1,
                    Complexity = 1,
                    Name = "Формула «Обезболивающие травы»",
                    SourceId = 1,
                    Weight = 1,

                }
            });

            builder.Entity<FormulaSubstanceList>().HasData(new FormulaSubstanceList[]
            {
                new FormulaSubstanceList{Id = 1, FormulaId = 87, SubstanceType = (int)SubstanceType.Quebrith, Amount = 1},
                new FormulaSubstanceList{Id = 2, FormulaId = 87, SubstanceType = (int)SubstanceType.Vermilion, Amount = 1},
            });

            builder.Entity<Item>().HasData(new Item[]
            {
                new Item{
                    Id = 88,
                    Name = "Веревка (20 метров)",
                    SourceId = 1,
                    Weight = 1.5,
                    Price = 20,
                    Description = "Всегда с собой таскай верёвку. " +
                    "Я не раз в ямы проваливался, да и на скалы карабкаться приходилось. " +
                    "Ситуаций, где нужна верёвка, предостаточно"
                },
                new Item
                {
                    Id = 91,
                    Name = "Кроны",
                    SourceId = 1,
                    Weight = 0.01,
                    Price = 1,
                    Description = "Валюта это",
                }
            });

            builder.Entity<Tool>().HasData(new Tool[]
            {
                new Tool{Id = 89,
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
                    Id = 90,
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

            builder.Entity<Race>().HasData(new Race[]
            {
                new Race
                {
                    Id = 1,
                    Name = "Ведьмаки",
                    Description = "Ведьмаки — тема деликатная с тех самых пор, как их создали много веков тому назад. " +
                    "Но, знаешь, даже когда они были нарасхват, их не особо-то любили. Ведьмаков выращивали из людских детей" +
                    " в пяти ведьмачьих школах. Там дети проходили какую-то лютую подготовку, после которой становились живым оружием. Быстрые до одури, " +
                    "могут сражаться вслепую и обучены охотиться считай на всех тварей, каких только " +
                    "можно встретить. Через парулет тренировок их подвергают мутациям — известней " +
                    "всего так называемое Испытание травами. Ведьмак, с которым мне довелось странствовать, рассказал, что " +
                    "переживает эту дрянь только один дитёнок из четырёх. Те, кто выжил, меняются. Глаза у них становятся кошачьими, " +
                    "а эмоции напрочь отмирают. Вроде как последнее со временем налаживается — например, тот самый " +
                    "знакомый мне ведьмак по дороге шутки-то малясь травил. Но с того самого момента, " +
                    "как ведьмаки мутируют, они становятся убийцами. Они перерождаются ради единственной цели — убивать чудовищ. " +
                    "И если доведётся тебе повидать ведьмака в деле, то поймёшь, что все те пройденные страдания были не зря. Одна только проблема: " +
                    "они мутанты, а люди мутантов ненавидят. С адаптацией в обществе у ведьмаков плохо, и для большинства они — хладнокровные " +
                    "бессердечные выродки, что честным людям кишки выпускают, предварительно ограбив да их дочек снасильничав",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 2,
                    Name = "Эльфы (Aen Seidhe)",
                    Description = "История эльфов (точнее Aen Seidhe, поскольку наши эльфы далеко не единственные) весьма грустная." +
                    " Они прибыли сюда неизвестно откуда на огромных белых кораблях. Случилось это незадолго до появления людей. Я бы не " +
                    "назвал эльфов добряками, но с остальными они как-то уживались. От людей они не сильно отличаются: высокие, худые, любят на" +
                    " другие народы свысока смотреть. Разве что уши острые, жизнь вечная, да, считай, полное единение с природой — эльфы много поколений" +
                    " только и делали, что занимались собирательством и строили дворцы. Унихза время поеданияягод да кореньев и клыков-то не осталось. " +
                    "Правда, всё равно не советую их из себя выводить — на поле боя эльфы могут устроить тот ещё ад. Броню они толком не носят, но заприметить " +
                    "эльфа в лесу также тяжело, как зимой лягушку найти. А уж искуснее лучника чем эльф, днём с огнём не сыщешь.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 3,
                    Name = "Краснолюды",
                    Description = "Друже, вот что я тебе скажу: реки высохнут, горы рассыплются, а краснолюды никуда не денутся. Может, мы и низенькие в сравнении" +
                    " с эльфами и людьми, да только в силе и закалке им с нами не тягаться. Мы — само воплощение стойкости! Краснолюды уже не первый век существуют" +
                    " в этом мире. Жили себе спокойно в горах, ковали. Мы народ достаточно дружелюбный, если познакомиться с нами поближе. Да и уживаемся спокойно" +
                    " со всеми... если нас не бесить, конечно. Человечишки нас не особо любят, но мы им нужны — кто ж сталь им ковать будет и торговать? К тому же, в" +
                    " отличие от сраных эльфов, мы не держим на людей зла. Нас не трогают — и мы их не трогаем в ответ. Порой даже кружечку-другую готовы раздавить" +
                    " вместе с человеком. Жаль, конечно, что вся эта безумная расистская дрянь по Северу расползлась. Теперь и на краснолюдов травлю открыли. Повезло" +
                    " ещё, что люди наших девок нормально от мужиков отличить не могут, а то бы всех уже увели! Ведь нету бабы краше нраснолюдки. Правильно говорят:" +
                    " чем пышнее борода, тем приятнее... ну, ты понимаешь.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 4,
                    Name = "Люди",
                    Description = "Ох, будь я покозлистее, то всю желчь излил бы тебе о том, как людишки насолили моему народу и остальным Старшим Народам. Но я не такой." +
                    " С людьми я служил бок о бок на войне с Нильфгаардом; в той же темерской армии большинство — люди. Не все они говнюки — бывают и хорошие. По характеру" +
                    " люди-mo разные. Обычно они весьма стойкие ребята. Разве что частенько начинают то за «правое дело» воевать, то тыкать пальцами и бояться. Сейчас люди" +
                    " на Континенте — преобладающий вид, и они об этом прекрасно знают... чёрт, даже не надо стараться, чтобы о них гадости говорить. Люди почти уничтожили" +
                    " Старшие Народы, выкосили вранов, оставили в живых всего пару сотен боболаков, построили свои города на руинах Старших Народов и каждый день кого-то" +
                    " из Старших убивают. Но нет, они не все говнюки. Да, большинство магов — люди, и именно они погрузили мир в хаос, но они также сделали мир лучше с" +
                    " помощью науки и магии. Люди умные и, на самом деле, верные — если ты с человеком дружен, он тебя в беде не бросит.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 5,
                    Name = "Гуманоиды",
                    Description = "Формально гуманоиды чудовищами не являются. Это люди, эльфы, краснолюды и прочие представители Старших Народов. " +
                    "Гуманоиды разнообразны в плане поведения и мест обитания. Важно помнить, что даже\r\nпо стандартным правилам гуманоиды не имеют" +
                    " восприимчивости к серебру и сопротивления стали.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 6,
                    Name = "Трупоеды",
                    Description = "Трупоеды едят трупы, и зачастую их можно встретить на кладбищах, полях боя и в глубоких пещерах. Их отталкивающая внешность" +
                    " обманчива — это вполне живые существа с иных планов. Менее разумные трупоеды, такие как гули, нападают на всё, что оказывается поблизости." +
                    " Умные трупоеды, вроде кладбищенских баб, бродят по кладбищам и заманивают селян.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 7,
                    Name = "Духи",
                    Description = "Духи представляют собой сильные желания усопших. Обычно они появляются тогда, когда кого-то убивают или когда кто-то перед " +
                    "смертью испытывает интенсивные эмоции. Многие духи разумны, но все они целиком захвачены каким-то одним чувством — обычно " +
                    "яростью, — что просто не позволяет вести с ними диалог.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 8,
                    Name = "Звери",
                    Description = "Звери, как и гуманоиды, формально не относятся к чудовищам. В этой категории — собаки, волки и тому подобные существа." +
                    " Они не имеют восприимчивости к серебру и сопротивления стали. Встретить их и вблизи поселений. Охотятся они преимущественно на селян и скот.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 9,
                    Name = "Проклятые",
                    Description = "Проклятые — это люди и нелюди, на которых было наложено проклятие, превратившее их в чудовиш. Наиболее распространены волколаки." +
                    " Поскольку это проклятые люди они обычно живут в человеческих поселениях. В большинстве своём такие существа открыто агрессивны по отношению к людям.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 10,
                    Name = "Гибриды",
                    Description = "Этот класс объединяет множество разных химер вроде сирен и грифонов — соединение частей разных животных. Гибриды необычайно разнообразны" +
                    " и предпочитают различные среды обитания. Те, у кого есть способность к полёту, живут на возвышенностях, хотя в целом гибридов можно найти повсемест" +
                    " но, в самых разных зонах.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 11,
                    Name = "Инсектоиды",
                    Description = "Инсектоиды — это огромные насекомые и арахниды, которые бродят за пределами поселений, подстерегая неосторожных путников. " +
                    "Инсектоиды — хищники, обычно нападающие из засады и ранящие своих жертв ядовитыми жвалами или когтями. " +
                    "Если подобратьсслишком близко к гнезду инсектоидов, то вскоре вас может окружить целый рой этих существ.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 12,
                    Name = "Духи стихий",
                    Description = "Духи стихий - восхитительные создания магии: големы, элементали, гаргульи и им подобные. Большинство таких существ призваны магами и " +
                    "жрецами. Они следуют приказам призвавшего, у них практически нет своей воли. Но если призвать их в этот мир, не связав узами, духи" +
                    "стихий становятся ужасающей силой, способной уничтожать города.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 13,
                    Name = "Реликты",
                    Description = "Реликты — силы природы, периодически проявляющиеся за пределами поселений. Скорее всего, эти чудовища прибыли в наш мир" +
                    " во время Сопряжения Сфер. Все они владеют магиейи тесно связаны с природой. По разумности реликты различаются: от умных и хитрых до" +
                    " примитивных и жестоких.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 14,
                    Name = "Огры",
                    Description = "Огры, включая троллей, накеров и великанов, — это гуманоидные создания, зачастую с почти человеческим интеллектом." +
                    " Большинство из них велики и нескладны (за исключением накеров). Они не только способны создавать племенные сообщества, но и, в" +
                    " случае троллей, кое-как разговаривать на человеческом языке и Старшей Речи.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 15,
                    Name = "Дракониды",
                    Description = "Среди драконидов есть такие существа, как виверны и драконы. Большинство драконидов — это крупные крылатые ящеры," +
                    " крайне опасные (особенно в ближнем бою), но дикие. Истинные драконы по интеллекту близки к людям, а то и вовсе их превосходят" +
                    " и обладают куда большим количеством способностей. Логова драконидов расположены высоко в горах.",
                    SourceId = 1,
                },
                new Race
                {
                    Id = 16,
                    Name = "Вампиры",
                    Description = "Вампиры — весьма разнообразная группа кровососущих чудовищ. Обычно они охотятся в руинах, хотя могущественные вампиры" +
                    " могут процветать и в городах. Низшие вампиры — это неразумные твари, раздирающие тела на части и затем выпивающие кровь. Высшие вампиры" +
                    " способны без проблем влиться в человеческое общество и обладают огромной силой.",
                    SourceId = 1,
                },
            });

            #region #Creatures Data

            var abilityList = new Ability[]
            {
                new Ability
                {
                    Id = 1,
                    Name = "Обостренные чувства",
                    Description = "Благодаря обострённым чувствам ведьмаки не получают штрафов при слабом свете и получают врождённый бонус +1 к Вниманию," +
                    " а также возможность выслеживания по запаху",
                    RaceId = 1,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 2,
                    Name = "Стойкость мутанта",
                    Description = "После всех мутаций ведьмаки становятся невосприимчивы к болезням и способны использовать мутагены",
                    RaceId = 1,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 3,
                    Name = "Притупление эмоций",
                    Description = "Из-за пережитых страданий и мутаций эмоции у ведьмаков притупляются. Ведьмакам не нужно совершать проверки" +
                    " Храбрости против Запугивания, но они получают штраф -4 к Эмпатии. При этом значение Эмпатии ведьмака не может быть ниже 1.",
                    RaceId = 1,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 4,
                    Name = "Молниеносная реакция",
                    Description = "Благодаря интенсивным тренировкам и мутациям ведьмаки куда быстрее и проворнее обычных людей. Они получают" +
                    " постоянный бонус +1 к Реакции и Ловкости, позволяющий сделать эти значения больше 10.",
                    RaceId = 1,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 5,
                    Name = "Чувство прекрасного",
                    Description = "У эльфов есть врождённая творческая жилка и развитое чувство прекрасного. Эльфы получают врождённый бонус +1 к Искусству.",
                    RaceId = 2,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 6,
                    Name = "Стрелок",
                    Description = "Благодаря давним традициям и постоянным тренировкам эльфы — одни из лучших лучников в мире. Эльфы получают врождённый бонус" +
                    " +2 к Стрельбе из лука и способны выхватывать и натягивать лук, не тратя на это действие.",
                    RaceId = 2,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 7,
                    Name = "Единение с природой",
                    Description = "Эльфы тесно связаны с природой. Они не тревожат животных — любой зверь, встреченный эльфом, будет относиться к нему дружелюбно " +
                    "и не нападёт без провокации. Эльфы также способны автоматически находить любые обычные и повсеместные субстанции растительного происхождения, " +
                    "если искомые растения обитают в природе на данной территории",
                    RaceId = 2,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 8,
                    Name = "Закаленный",
                    Description = "У краснолюдов весьма крепкая кожа, имеющая врождённую прочность 2. Данная величина прибавляется к прочности любой брони и не может" +
                    " быть понижена разрушающим уроном.",
                    RaceId = 3,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 9,
                    Name = "Силач",
                    Description = "Благодаря невысокому росту и склонности к тяжелой работе, требующей физических усилий, краснолюды получают +1 к Силе и повышают свое" +
                    " значение Переносимого веса на 25.",
                    RaceId = 3,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 10,
                    Name = "Наметанный глаз",
                    Description = "Краснолюды - прекрасные оценщики, обладающие вниманием к деталям, а потому обмануть их весьма трудно. Краснолюды получают врожденный" +
                    " бонус +1 к Торговле.",
                    RaceId = 3,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 11,
                    Name = "Доверие",
                    Description = "В мире, где нелюдям не доверяют, людям довериться куда проще. У людей есть врожденный бонус +1 к проверкам Харизмы, Соблазнения и " +
                    "Убеждения против других людей.",
                    RaceId = 4,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 12,
                    Name = "Изобретательность",
                    Description = "Люди умны и зачастую находят великолепные решения сложных проблем. Люди получают врожденный бонус +1 к Дедукции.",
                    RaceId = 4,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 13,
                    Name = "Упрямство",
                    Description = "Одно из величайших преимуществ человеческой расы — нежелание отступать даже в опасной ситуации. Они могут собраться с духом и перебросить" +
                    " неудачный результат проверки Сопротивления убеждению или Храбрости, но не более 3 раз за игровую партию. В таком случае из двух результатов выбирают" +
                    " наивысший, но если результат всё равно провальный, то вновь использовать Упрямство нельзя.",
                    RaceId = 4,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                }
            };

            builder.Entity<Ability>().HasData(abilityList);

            builder.Entity<SkillsTree>().HasData(new SkillsTree[]
            {
                new SkillsTree
                {
                    Id = 1,
                    MainSkillId = 53,
                    FirstLeftSkillId = 54,
                    SecondLeftSkillId = 55,
                    ThirdLeftSkillId = 56,

                    FirstMiddleSkillId = 57,
                    SecondMiddleSkillId = 58,
                    ThirdMiddleSkillId = 59,

                    FirstRightSkillId = 60,
                    SecondRightSkillId = 61,
                    ThirdRightSkillId = 62,
                },
            });

            builder.Entity<Class>().HasData(new Class[]
            {
                new Class
                {
                    Id = 1,
                    Name = "Ведьмак",
                    Description = "Я ведь уже говорил тебе, что странствовал какое-то время с ведьмаком? Так вот. Спросил я его как-то, почему он ведьмаком остался." +
                    " Это ведь явно не работа мечты — входишь в деревню, дети прячутся, отцы своих дочурок по домам запирают. Впрочем, ответ был ожидаем — он попросту" +
                    " незнал другой жизни. На самом деле логично. Вот живёшь ты, живёшь, занимаешься одним делом, а больше-то ничего и не умеешь. Но не всё так плохо." +
                    " Ведьмаки — это сила. Мечники они отменные — тот ведьмак, с которым я странствовал, как-то раз арбалетный болт отбил на лету. Могу повторить, если" +
                    " тебя это не впечатлило. Своим кручением-верчением они вполне способны в капусту покрошить более медленных мечников. Двигаются ведьмаки так быстро," +
                    " что со стороны за мечом не уследишь и каждый взмах превращается в серебряную полосу. И не стоит забывать об алхимии! Раньше они точно с собой таскали" +
                    " всякие эликсиры и масла, благодаря которым на поле боя превращались в сущих дьяволов — становились быстрее и раны залечивали, как волколаки. Вдобавок" +
                    " ко всему ведьмаки чуточку магией владеют. Ну, не такой мощной, как настоящие чародеи, но всё же заклинания свои творят. Называется это знаками. Это" +
                    " такие пассы руками, обладающие магическим действием. Любой маг на это лишь пофыркает, поскольку такие вещи не дотягивают даже до простейших заклинаний," +
                    " но всёравно знаки весьма эффективны. Так что честно тебе скажу: я рад, что ведьмаки только на чудовищ охотятся. Ну... по крайней мере, когда-то так было.",
                    DefaultMagicAbilities = "",
                    Energy = 2,
                    SkillsTreeId = 1,
                    SourceId = 1,
                },
            });

            var attackList = new Attack[]
            {
                new Attack
                {
                    Id = 1,
                    Name = "Железный полуторный меч",
                    Description = "",
                    AttackSpeed = 1,
                    AttackType = (int)AttackType.PiercingAndSlashing,
                    BaseAttack = 12,
                    Damage = "2к6+2",
                    Distance = 0,
                    Reliability = 10,
                    SourceId = 1,
                },
                new Attack
                {
                    Id = 2,
                    Name = "Кинжал",
                    Description = "",
                    AttackSpeed = 1,
                    AttackType = (int)AttackType.PiercingAndSlashing,
                    BaseAttack = 11,
                    Damage = "1к6",
                    Distance = 0,
                    Reliability = 10,
                    SourceId = 1,
                },
                new Attack
                {
                    Id = 3,
                    Name = "Ручной арбалет",
                    Description = "",
                    AttackSpeed = 1,
                    AttackType = (int)AttackType.Piercing,
                    BaseAttack = 10,
                    Damage = "2к6+2",
                    Distance = 0,
                    Reliability = 10,
                    SourceId = 1,
                },
            };

            builder.Entity<Attack>().HasData(attackList);

            var attackEffectList = new AttackEffectList[]
            {
                new AttackEffectList
                {
                    Id = 1,
                    //AttackId = 3,
                    EffectId = 50,
                    ChancePercent = 0,
                    Damage = "50м",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 2,
                    //AttackId = 3,
                    EffectId = 21,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 3,
                    //AttackId = 3,
                    EffectId = 51,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },
            };

            builder.Entity<AttackEffectList>().HasData(attackEffectList);

            builder.Entity<StatsList>().HasData(new StatsList[]
            {
                new StatsList
                {
                    Id = 1,

                    IntellectId = 1,
                    ReactionId = 2,
                    DexterityId = 3,
                    ConstitutionId = 4,
                    SpeedId = 5,
                    EmpathyId = 6,
                    CraftsmanshipId = 7,
                    WillpowerId = 8,
                    LuckId = 9,

                    IntellectValue = 3,
                    ReactionValue = 6,
                    DexterityValue = 5,
                    ConstitutionValue = 5,
                    SpeedValue = 4,
                    EmpathyValue = 3,
                    CraftsmanshipValue = 4,
                    WillpowerValue = 4,
                    LuckValue = 0,

                    EnergyId = 10,
                    ResilienceId = 11,
                    RunningId = 12,
                    JumpingId = 13,
                    HealthPointsId = 14,
                    EnduranceId = 15,
                    WeightId = 16,
                    RestId = 17,
                    HandStrikeId = 18,
                    KickId = 19,

                    EnergyValue = 0,
                    ResilienceValue = 4,
                    RunningValue = 12,
                    JumpingValue = 2,
                    EnduranceValue = 20,
                    WeightValue = 50,
                    RestValue = 4,
                    HealthPointsValue = 20,
                    HandStrikeValue = 0,
                    KickValue = 2,
                },
            });

            builder.Entity<SkillsList>().HasData(new SkillsList[]
            {
                new SkillsList
                {
                    Id = 1,

                    AttentionId = 1,
                    SurvivalId = 2,
                    DeductionId = 3,
                    MonsterologyId = 4,
                    EducationId = 5,
                    CityOrientationId = 6,
                    KnowledgeTransferId = 7,
                    TacticsId = 8,
                    TradingId = 9,
                    EtiquetteId = 10,
                    LanguageGeneralId = 11,
                    LanguageHighId = 12,
                    LanguageDwarfId = 13,

                    AttentionValue = 6,
                    SurvivalValue = 5,
                    DeductionValue = 0,
                    MonsterologyValue = 0,
                    EducationValue = 0,
                    CityOrientationValue = 0,
                    KnowledgeTransferValue = 0,
                    TacticsValue = 0,
                    TradingValue = 0,
                    EtiquetteValue = 0,
                    LanguageGeneralValue = 0,
                    LanguageHighValue = 0,
                    LanguageDwarfValue = 0,

                    StrengthId = 27,
                    EnduranceId = 28,

                    StrengthValue = 0,
                    EnduranceValue = 5,

                    MeleeCombatId = 14,
                    WrestlingId = 15,
                    RidingId = 16,
                    PoleWeaponMasteryId = 17,
                    LightBladeMasteryId = 18,
                    SwordsmanshipId = 19,
                    SeamanshipId = 20,
                    EvasionId = 21,

                    MeleeCombatValue = 0,
                    WrestlingValue = 6,
                    RidingValue = 0,
                    PoleWeaponMasteryValue = 0,
                    LightBladeMasteryValue = 5,
                    SwordsmanshipValue = 6,
                    SeamanshipValue = 0,
                    EvasionValue = 4,

                    AthleticsId = 22,
                    ManualDexterityId = 23,
                    StealthId = 24,
                    CrossbowMasteryId = 25,
                    ArcheryId = 26,

                    AthleticsValue = 4,
                    ManualDexterityValue = 0,
                    StealthValue = 3,
                    CrossbowMasteryValue = 4,
                    ArcheryValue = 0,

                    GamblingId = 29,
                    AppearanceId = 30,
                    PublicSpeakingId = 31,
                    ArtistryId = 32,
                    LeadershipId = 33,
                    DeceptionId = 34,
                    UnderstandingPeopleId = 35,
                    SeductionId = 36,
                    PersuasionId = 37,
                    CharismaId = 38,

                    GamblingValue = 0,
                    AppearanceValue = 0,
                    PublicSpeakingValue = 0,
                    ArtistryValue = 0,
                    LeadershipValue = 0,
                    DeceptionValue = 0,
                    UnderstandingPeopleValue = 0,
                    SeductionValue = 0,
                    PersuasionValue = 0,
                    CharismaValue = 0,

                    AlchemyId = 39,
                    LockpickingId = 40,
                    TrapKnowledgeId = 41,
                    ManufacturingId = 42,
                    CamouflageId = 43,
                    FirstAidId = 44,
                    ForgeryId = 45,

                    AlchemyValue = 0,
                    LockpickingValue = 0,
                    TrapKnowledgeValue = 0,
                    ManufacturingValue = 0,
                    CamouflageValue = 0,
                    FirstAidValue = 0,
                    ForgeryValue = 0,

                    IntimidationId = 46,
                    CorruptionId = 47,
                    RitualsId = 48,
                    MagicResistanceId = 49,
                    PersuasionResistanceId = 50,
                    SpellcastingId = 51,
                    CourageId = 52,

                    IntimidationValue = 0,
                    CorruptionValue = 0,
                    RitualsValue = 0,
                    MagicResistanceValue = 4,
                    PersuasionResistanceValue = 5,
                    SpellcastingValue = 0,
                    CourageValue = 7,
                },
            });

            var creatureRewardList = new Reward[]
            {
                new Reward
                {
                    Id = 1,
                    Amount = "3к10",
                    ItemBaseId = 90,
                }
            };

            builder.Entity<Reward>().HasData(creatureRewardList);
            
            var creatureList = new Creature[]
            {
                new Creature
                {
                    Id = 1,
                    Name = "Разбойник",
                    Description = "",
                    AdditionalInformation = "",
                    //Abilities = abilityList.ToList(),
                    Armor = 5,
                    AthleticsBase = 9,
                    //Attacks = attackList.ToList(),
                    BlockBase = 12,
                    Complexity = (int)Complexity.EasySimple,
                    //CreatureRewardList = creatureRewardList.ToList(),
                    EducationSkill = 8,
                    MonsterLoreSkill = 10,
                    SuperstitionsInformation = "Хе, разбойники, дезертиры, ренегаты, сукины дети... Называй их как хочешь. Люди ступают на преступный путь" +
                    " ради денег и власти, но в большинстве своём они делают это от страха и голода. Все знают, что уровень преступности растёт во время" +
                    " войны. Так было в прошлых двух войнах, и вот сейчас опять. Но это не значит, что простой народ с этим согласен. Хех, не говорите это" +
                    " в лицо убийце, но среднестатистический ублюдок о бандите того же мнения, что и о гуле. И те, и другие прячутся по грязным закоулкам" +
                    " мира, ждут момента, чтобы напасть, и устраивают засаду на добрых трудяг, чтобы отобрать заработанное кровью и потом.",
                    MonsterLoreInformation = "Разбойники — одна из самых распространённых угроз на дороге, но отнюдь не самая опасная. Куда тяжелее скинуть" +
                    " с себя гуля, чем расправиться с парочкой разбойников. Но порой они могут представлять настоящую угрозу, особенно когда их много." +
                    " Большая часть разбойников — это солдаты без армии, наёмники без контракта или дезертиры, которые покинули одну из воюющих сторон." +
                    " Разбойники просты. Первые ряды побегут с полуторными мечами наголо. Те, кто на такое не способен, воспользуются арбалетами. Разбойникам" +
                    " обычно нужны три вещи: безопасность, деньги и что-нибудь, на чём можно выместить свой гнев. С ними не то чтобы просто расправиться," +
                    " но, в отличие от большинства чудовищ, можно воззвать к их разуму. Возможно, вы сумеете убедить их не убивать вас. Разбойники," +
                    " скорее всего, сдадутся, если вы нанесёте им достаточно урона.\r\nОднако некоторые разбойники, странствующие крепко сбитыми группами," +
                    " могут начать сражаться яростнее, если убить их товарищей. На истерзанном войной Севере стоит быть осторожнее: нехватка пищи заставила" +
                    " некоторых разбойников стать каннибалами. Каннибалы зачастую сходят с ума и нападают с бешеной яростью — они не сдаются, даже стоя" +
                    " одной ногой в могиле. Если не хотите драться, будьте внимательны на дороге. =",
                    EvasionBase = 10,
                    GroupSize = "Банда из 3-15 разбойников",
                    HabitatPlace = "Часто рядом с городами и на трактах",
                    Resistances = "",
                    Immunities = "",
                    Vulnerabilities = "",
                    Height = 180,
                    Intellect = "Человеческий",
                    MoneyReward = 10,
                    RaceId = 4,
                    Regeneration = 0,
                    SkillsListId = 1,
                    SourceId = 1,
                    SpellResistBase = 8,
                    StatsListId = 1,
                    Weight = 80,
                }
            };

            builder.Entity<Creature>().HasData(creatureList);

            builder.Entity<CreatureAttack>().HasData(new CreatureAttack[]
            {
                new CreatureAttack
                {
                    Id = 1,
                    AttackId = 1,
                    CreatureId = 1,
                },
                new CreatureAttack
                {
                    Id = 2,
                    AttackId = 2,
                    CreatureId = 1,
                },
                new CreatureAttack
                {
                    Id = 3,
                    AttackId = 3,
                    CreatureId = 1,
                },
            });

            #endregion

            #region #Spells Data

            var spellSkillProtectionList = new SpellSkillProtectionList[]
            {
                new SpellSkillProtectionList
                {
                    Id = 1,
                    SkillId = 14,
                },
                new SpellSkillProtectionList
                {
                    Id = 2,
                    SkillId = 17,
                },
                new SpellSkillProtectionList
                {
                    Id = 3,
                    SkillId = 18,
                },
                new SpellSkillProtectionList
                {
                    Id = 4,
                    SkillId = 19,
                },
                new SpellSkillProtectionList
                {
                    Id = 5,
                    SkillId = 21,
                },
            };

            builder.Entity<SpellSkillProtectionList>().HasData(spellSkillProtectionList);

            //builder.Entity<Spell>().HasData(new Spell[]
            //{
            //    new Spell
            //    {
            //        Id = 1,
            //        Name = "Слепящая пыль",
            //        Description = "Слепящая пыль позволяет направить в глаза цели горсть магической пыли, которая ослепит её на время действия заклинания.",
            //        CheckDC = -1,
            //        ConcetrationEnduranceCost = 0,
            //        DangerInfo = "",
            //        Distance = 4,
            //        Duration = "1к10 раундов",
            //        EnduranceCost = 3,
            //        IsConcetration = false,
            //        IsDruidSpell = false,
            //        IsPriestSpell = false,
            //        PreparationTime = 0,
            //        SourceId = 1,
            //        SourceType = (int)SpellSource.Mixed,
            //        SourceTypeDescription = "",
            //        SpellLevel = 1,
            //        SpellSkillProtectionList = spellSkillProtectionList.ToList(),
            //        SpellType = (int)SpellType.Spell,
            //        SpellTypeDescription = "",
            //        WithdrawalCondition = "",
            //    },
            //});

            #endregion
        }
    }
}
