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
                    #region Ведьмак 53 по 62
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
                        Name = "Медитация",
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
                        Description = "За годы употребления ядовитых ведьмачьих эликсиров ведьмаки привыкают к токсинам. Ведьмак может выдержать отвары и эликсиры суммарной" +
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
                #endregion

                    #region Воин 63 по 72
                    new Skill
                    {
                        Id = 63,
                        StatId = 4,
                        Name = "Крепче стали",
                        Description = "Настоящие воины — будь то темерские «Синие полоски» или нильфгаардцы из бригады «Импера» — никогда не сдаются. " +
                        "Когда ПЗ воина опускается до 0 или ниже, он может совершить проверку навыка Крепче стали со СЛ, равной количеству отрицательных ПЗ х 2, чтобы продолжить сражаться. " +
                        "При провале воин оказывается при смерти. При успехе он может продолжать сражение, как если бы его ПЗ были ниже порога ранения. " +
                        "Получив урон, он вновь должен совершить проверку со СЛ, зависящей от его ПЗ.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 64,
                        StatId = 3,
                        Name = "Максимальная дистанция",
                        Description = "Совершая дистанционную атаку, которая получила бы штраф за дистанцию, воин может уменьшить штраф на половину Максимальной дистанции. " +
                        "Он также может совершить проверку способности Максимальная дистанция со СЛ 16, чтобы атаковать цель на расстоянии до 3 дистанций своего оружия со штрафом -10. " +
                        "Этот штраф можно уменьшить, применив данную способность.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 65,
                        StatId = 3,
                        Name = "Двойной выстрел",
                        Description = "Совершая дистанционную атаку из лука или метательным оружием, воин может совершить проверку способности Двойной выстрел " +
                        "вместо соответствующего оружию навыка. При попадании воин выпускает в цель два снаряда, повреждая две случайные части тела. Даже если атака была прицельной, " +
                        "второй снаряд попадёт в случайную часть тела.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 66,
                        StatId = 3,
                        Name = "Точный прицел",
                        Description = "Если воин совершает критическую атаку дистанционным оружием, он может немедленно совершить проверку Точного прицела со СЛ, " +
                        "равной Лвк х 3 цели. При успехе воин добавляет значение способности Точный прицел к критическому броску. " +
                        "Эти очки влияют только на определение положения критического ранения.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 67,
                        StatId = 1,
                        Name = "Ищейка",
                        Description = "При выслеживании цели воин добавляет значение Ищейки к проверкам Выживания в дикой природе, чтобы найти след или пройти по нему. " +
                        "Если воин теряет след во время выслеживания с помощью этой способности, он может совершить проверку Ищейки со СЛ, определяемой ведущим, " +
                        "чтобы немедленно вновь найти след.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 68,
                        StatId = 7,
                        Name = "Ловушка воина",
                        Description = "Воин может совершить проверку способности Ловушка воина, чтобы установить самодельную ловушку в определённой зоне. " +
                        "Вид ловушки определите по таблице «Ловушки воина». Воин может создать ловушку только одного вида за раз. У каждой ловушки есть растяжка радиу сом 2 метра, " +
                        "для её обнаружения требуется совершить проверку Внимания со СЛ, равной проверке Ловушки воина",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 69,
                        StatId = 1,
                        Name = "Тактическое преимущество",
                        Description = "Вместо перемещения воин может совершить проверку Тактического преимущества, чтобы оценить группу противников. " +
                        "Воин получает бонус +3 к атаке и защите на один раунд против всех врагов в пределах 10 метров, чья Лвк х З меньше, чем результат проверки. " +
                        "Также эта способность позволяет понять, что собирается делать каждый из врагов, на которых она действует.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 70,
                        StatId = 8,
                        Name = "Неистовство",
                        Description = "Воин может совершить проверку Неистовства со СЛ, равной его Эмп х З. При успехе воин становится невосприимчив к ужасу, " +
                        "влияющим на эмоции заклинаниям и Словесной дуэли на количество раундов, равное удвоенному значению Неистовства. " +
                        "В это время ярость застилает разум воина и он полностью отдается во власть инстинктов",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 71,
                        StatId = 4,
                        Name = "Двуручник",
                        Description = "Потратив 10 очков Вын и совершив проверку способности Двуручник со штрафом -3 против защиты противника, воин может совершить одну атаку, " +
                        "которая наносит двойной урон и считается пробивающей броню. Если его оружие уже пробивающее броню, оно становится улучшенным пробивающим броню. " +
                        "Улучшенное пробивающее броню оружие с этой способностью наносит 3d6 дополнительного урона.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 72,
                        StatId = 4,
                        Name = "Игнорировать удар",
                        Description = "Количество раз за игровую партию, равное Тел воина, он может потратить 10 очков Вын, чтобы немедленно совершить проверку способности " +
                        "Игнорировать удар, когда противник наносит ему критическое ранение. Если результат проверки выше проверки атаки противника, воин отменяет критическое ранение, " +
                        "как если бы атака противника не была критической.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Жрец 73 по 82
                    new Skill
                    {
                        Id = 73,
                        StatId = 6,
                        Name = "Посвященный",
                        Description = "В большинстве церквей мира рады посетителям. Служители храмов помогают местным жителям и с радостью принимают новообращённых в свою веру. " +
                        "Жрец может совершить проверку навыка Посвящённый (СЛ определяет ведущий) в храме своей религии, чтобы получить бесплатный кров, исцеление и прочие " +
                        "услуги на усмотрение ведущего. Навык Посвящённый также можно использовать при общении с единоверцами, но получите вы куда меньше, чем в церкви. " +
                        "Посвящённый не действует при общении с теми, кто исповедует другую веру",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 74,
                        Name = "Божественная сила",
                        Description = "Укрепляя связь с божеством, жрец может повысить своё значение Энергии на 1 за каждый уровень Божественной силы. " +
                        "Таким образом, значение Энергии жреца на 10 уровне будет равно 12. Эта способность развивается аналогично прочим навыкам и суммируется с Еди нением с природой. " +
                        "Значение Энергии в этом случае общее.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 75,
                        StatId = 6,
                        Name = "Божественный авторитет",
                        Description = "Для крестьян и простого люда жрецы — проводники воли богов. Жрец может добавить значение Божественного авторитета к своим проверкам Лидерства, " +
                        "если он находится в области, где исповедуют ту же религию. Если жрец находится за пределами такой области, то он добавляет половину значения способности.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 76,
                        StatId = 8,
                        Name = "Предвидение",
                        Description = "По решению ведущего жрец может получить видение будущего, на 3 раунда впав в состояние кататонии. " +
                        "После этого жрец может совершить проверку Предвидения со СЛ, определяемой ведущим, чтобы расшифровать полученные видения, " +
                        "которые представляют собой смесь символов и метафор.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 77,
                        Name = "Единение с природой",
                        Description = "Укрепляя связь с природой, жрец может повысить своё значение Энергии на 1 за каждый уровень Единения с природой. " +
                        "Таким образом, значение Энергии жреца на 10 уровне будет равно 12. Эта способность развивается аналогично прочим навыкам и суммируется с Божественной силой. " +
                        "Значение Энергии в этом случае общее.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 78,
                        StatId = 1,
                        Name = "Знаки природы",
                        Description = "Находясь среди природы, друид может совершить проверку способности Знаки природы со СЛ, определяемой ведущим. " +
                        "При успехе друид по знакам узнаёт, кто в этом месте был и что делал. Эта проверка даёт только локальную информацию и не позволяет выслеживать.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 79,
                        StatId = 8,
                        Name = "Союзник природы",
                        Description = "Друид добавляет способность Союзник природы к любым проверкам Выживания в дикой природе для обращения с животными. " +
                        "Друид также может сдружиться с животным, потратив полный раунд и совершив проверку Союзника природы. " +
                        "Зверь или иное животное становится союзником друида наколичество часов, равное значению способности Союзник природы. " +
                        "Данная способность не действует на чудовищ.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 80,
                        StatId = 8,
                        Name = "Кровавые ритуалы",
                        Description = "Проводя ритуал, жрец может совершить проверку способности Кровавые ритуалы со СЛ, равной СЛ ритуала. " +
                        "При успехе жрец проводит ритуал без необходимых алхимических субстанций, жертвуя при этом 5 ПЗ в виде крови за каждую недостающую субстанцию. " +
                        "Это может быть и чужая кровь, но только пролитая во время данного ритуала",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 81,
                        StatId = 6,
                        Name = "Рвение",
                        Description = "Жрец может совершить проверку Рвения против текущего значения ИнтхЗ цели. При успехе слова жреца ободряют цель, " +
                        "что даёт ей ld6 временных ПЗ за каждый пункт сверх СЛ (максимум 5). Этот эффект длится коли чество раундов, равное значению Рвениях2, и на одну цель его " +
                        "можно использовать только раз в день.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 82,
                        StatId = 6,
                        Name = "Слово божье",
                        Description = "Жрец может совершить проверку способности Слово божье, чтобы убедить слушателей, что его устами говорит божество. Любой, кто провалит проверку " +
                        "Сопротивления убеждению, будет считать жреца мессией и следовать за ним. Количество последователей жреца равно значению его Слова божьего. " +
                        "Если у последователей нет блоков параметров, используйте для них параметры разбойников.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Маг 83 по 92
                    new Skill
                    {
                        Id = 83,
                        StatId = 1,
                        Name = "Магические познания",
                        Description = "Для того чтобы стать полноправным магом, способный к магии адепт должен пройти обучение в одной из магических академий. " +
                        "Маг может совершить проверку Магических познаний, если ему попадётся магический феномен, если он увидит незнакомое заклинание или захочет " +
                        "узнать ответ на какой-то теоретический вопрос. СЛ проверки определяется ведущим. При успехе маг узнаёт всё, что касается данного магического феномена. " +
                        "Проверка Магических познаний также может заменить проверку Внимания для обнаружения использованной магии и духов.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 84,
                        StatId = 1,
                        Name = "Строить козни",
                        Description = "Маг может совершить проверку способности Строить козни со СЛ, равной Инт х З цели. При успехе маг получает бонус +3 к " +
                        "Обману, Соблазнению, Запугиванию или Убеждению против этой цели благодаря знаниям о её сильных и слабых сторонах. Бонус действует количество дней, " +
                        "равное значению способности Строить козни.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 85,
                        StatId = 1,
                        Name = "Сплетни",
                        Description = "Потратив час времени, маг может совершить проверку Сплетен против ЭмпхЗ цели. При успехе маг успешно распускает слухи о цели по всему поселению, " +
                        "что снижает репутацию цели на половину значения Сплетен мага на количество дней, равное значению этой способности.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 86,
                        StatId = 1,
                        Name = "Полезные связи",
                        Description = "Один раз за игру маг может совершить проверку Полезных связей, чтобы вспомнить о комто, кто мог бы быть полезен. " +
                        "Результат проверки необходимо распределить между четырьмя категориями, указанными в таблице на полях, чтобы понять, кто этот знакомый. " +
                        "То, как агент будет помогать магу, зависит от их отношений.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 87,
                        StatId = 1,
                        Name = "Анализ",
                        Description = "Потратив час на изучение алхимического состава, маг может совершить проверку Анализа со СЛ, равной СЛ Изготовления этого алхимического состава + 3. " +
                        "При успехе маг выводити записывает формулу этого состава. СЛ создания предмета по воссозданной формуле на 3 пункта выше, но в итоге маг получает желаемый предмет.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 88,
                        StatId = 7,
                        Name = "Дистилляция",
                        Description = "Маг может совершить проверку Дистилляции вместо Алхимии при изготовлении алхимического состава. При успехе маг создаёт порцию состава, действующую в " +
                        "полтора раза эффективнее обычной порции — это относится к длительности, урону или СЛ сопротивления на выбор мага. Округление эффекта всегда идет вниз.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 89,
                        StatId = 1,
                        Name = "Мутация",
                        Description = "Маг может потратить полный день и всю свою Выносливость на проведение экспериментов над целью, чтобы совершить бросок Мутации со СЛ, равной " +
                        "(28 -(Тел+ Воля цели)/ 2), и мутацией изменить цель. При успехе цель получает возможность использовать мутаген с подходящей малой мутацией. " +
                        "При провале цель оказывается при смерти и получает крупную мутацию.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 90,
                        Name = "Укрепление связи",
                        Description = "По мере того как маг всё больше использует магию, его тело постепенно привыкает к течению магической энергии. " +
                        "Каждое очко, вложенное в способность Укрепление связи, повышает значение Энергии мага на 2. Когда эта способность достигает 10 уровня, " +
                        "максимальное значение Энергии мага равно 25. Эта способность развивается аналогично прочим навыкам.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 91,
                        StatId = 8,
                        Name = "Устойчивость к двимериту",
                        Description = "Маг может совершить проверку Устойчивости к двимериту со СЛ 16 в любой момент, когда на него обычно может воздействовать двимерит. " +
                        "При успехе маг способен противостоять эффекту двимерита: у него кружится голова и он испытывает дискомфорт, но сохраняет половину Энергии и способность сотворять заклинания.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 92,
                        StatId = 8,
                        Name = "Усиление магии",
                        Description = "Маг может обрести огромное могущество, проводя магическую энергию через разные фокусирующие магические предметы. " +
                        "Маг может совершить проверкуУсиления магии со СЛ 16 перед сотворением заклинания или проведением ритуала. " +
                        "При успехе маг может провести магическую энергию через любые 2 фокусирующих предмета по своему выбору, снижая затраты Выносливости вдвое.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Медик 93 по 102
                     new Skill
                    {
                        Id = 93,
                        StatId = 7,
                        Name = "Лечащее прикосновение",
                        Description = "Кто угодно может перевязать рану, но только у медика достаточно знаний, чтобы проводить сложные хирургические операции. " +
                        "Медик с навыком Лечащее прикосновение — единственный, кто способен вылечить критическое ранение. Для исцеления критического ранения медик должен " +
                        "успешно совершить несколько проверок Лечащего прикосновения — число их зависит от серьёзности критического ранения. СЛ проверки также зависит от " +
                        "серьёзности критического ранения. Помимо этого, Лечащее прикосновение можно использовать вместо проверки Первой помощи.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 94,
                        StatId = 1,
                        Name = "Диагноз",
                        Description = "При возможности осмотреть раненое существо медик может совершить проверку Диагноза со СЛ, определяемой ведущим. При успехе он обнаруживает " +
                        "все критические ранения цели и узнаёт, сколько пунктов здоровья у неё осталось. Это также даёт бонус +2 ко всем проверкам Лечащего прикосновения для лечения этих ран.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 95,
                        StatId = 1,
                        Name = "Осмотр",
                        Description = "Перед проверкой Лечащего прикосновения медик может потратить ход и совершить проверку Осмотра со СЛ, зависящей от серьёзности критического ранения. " +
                        "При успехе медик понимает природу ранения и за каждые 2 пункта проверки свыше СЛ (минимум 1) хирургическая операция займёт на 1 ход меньше.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 96,
                        StatId = 7,
                        Name = "Эффективная хирургия",
                        Description = "Перед тем как начать лечить критическое ранение, медик может совершить проверку Эффективной хирургии со СЛ, равной СЛ проверки Лечащего прикосновения, " +
                        "необходимой для лечения данного ранения. При успехе медик зашивает раны столь искусно, что они исцеляются в два раза быстрее. " +
                        "Эту способность можно использовать при лечении как критических ранений,так и обычных.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 97,
                        StatId = 7,
                        Name = "Палатка лекаря",
                        Description = "Палатка лекаря позволяет совершить проверку со СЛ, определяемой ведущим, чтобы создать укрытие с оптимальными условиями для лечения. " +
                        "Это требует 1 часа, но добавляет бонус +3 к совершённым внутри проверкам Лечащего прикосновения/Первой помощи и +2 к скорости исцеления любого, кто " +
                        "находится в палатке, на количество дней, равное значению Палатки лекаря.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 98,
                        StatId = 1,
                        Name = "Подручные средства",
                        Description = "Медик может совершить проверку Подручных средств со СЛ, равной СЛ Изготовления определённого лечащего алхимического состава, чтобы заменить его " +
                        "чем-то, что у него есть в наличии. Проверка занимает 1 раунд, и её можно повторить при провале. Подручные средства весьма специфичны и действуют только на конкретную рану.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 99,
                        StatId = 7,
                        Name = "Растительное лекарство",
                        Description = "Смешав алхимические субстанции, медик может создать растительное лекарство, которое даёт бонусы/эффекты в зависимости от состава " +
                        "(см. таблицу Растительные лекарства). Каждое лекарство хранится максимум 3 дня, после истечения этого срока его нельзя использовать. " +
                        "Чтобы получить бонус, лекарство следует сжечь или разжевать; его хватает только на одно применение. Создание лекарства занимает 1 ход",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 100,
                        StatId = 1,
                        Name = "Кровавая рана",
                        Description = "Нанося урон клинковым оружием, медик может совершить проверку способности Кровавая рана со СЛ 15. При успехе после этой атаки цель начинает " +
                        "истекать кровью со скоростью 1 урон за каждые 2 пункта свыше установленной СЛ за раунд. Кровотечение можно остановить только проверкой Первой помощи " +
                        "со СЛ, равной результату проверки Кровавой раны.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 101,
                        StatId = 1,
                        Name = "Практическая резня",
                        Description = "Медикможет совершить проверку способности Практическая резня со СЛ, равной Тел х 3 противника, чтобы обычные и критические ранения противника исцелялись " +
                        "в два раза медленнее. Другие медики могут нейтрализовать этот эффект при помощи Эффективной хирургии и предметов, " +
                        "повышающих скорость исцеления обычных и критических ран.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 102,
                        StatId = 1,
                        Name = "Калечащая рана",
                        Description = "Медик может совершить проверку способности Калечащая рана против защиты цели. Эта атака даёт штраф -6 к попаданию, но при успехе снижает Реакцию, " +
                        "Телосложение или Скорость цели на 1 пункт за каждые 3 пункта свыше броска защиты. " +
                        "Штраф можно снять, только со 2вершив проверку Эффективной хирургии с результатом выше результата атаки медика.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Преступник 103 по 112
                     new Skill
                    {
                        Id = 103,
                        StatId = 1,
                        Name = "Профессиональная паранойя",
                        Description = "Все преступники, будь то убийцы, воры, фальшивомонетчики или контрабандисты, обладают обострённым чутьём на " +
                        "опасность — фактически профессиональной паранойей, благодаря которой они избегают поимки. Когда преступник оказывается в пределах 10 метров от ловушки " +
                        "(включая экспериментальные ловушки, ловушки воина и засады), он может немедленно совершить проверку Профессиональной паранойи либо против СЛ обнаружения ловушки, " +
                        "либо против Скрытности засады, либо против заданной ведущим СЛ. Даже если преступник не заметит ловушки, чутьё всё равно ему подскажет, что тут что-то не так.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 104,
                        StatId = 1,
                        Name = "Присмотреться",
                        Description = "Преступник может потратить час, чтобы побродить по улицам поселения и совершить проверку способности Присмотреться со СЛ, указанной в таблице на полях. " +
                        "При успехе преступник запоминает маршруты патрулей, расположение улиц и укрытий, что " +
                        "даёт ему бонус +2 к Скрытности в этом районе на количество дней, равное значению Присмотреться",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 105,
                        StatId = 1,
                        Name = "Повторный взлом",
                        Description = "Когда преступник успешно вскрывает замок, он может совершить проверку Повторного взлома со СЛ, равной СЛ Взлома замков (для данного замка), " +
                        "чтобы запомнить положение штифтов. Это позволит ему открыть тот же замок без проверки навыка Взлом замков. Преступник может запомнить столько замков, " +
                        "сколько у него очков Инт. Всегда можно запомнить новый замок, забыв старый.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 106,
                        StatId = 1,
                        Name = "Залечь на дно",
                        Description = "Один раз за игровую партию преступник может совершить проверку способности Залечь на дно, чтобы найти тайное убежище, где он может спрятаться " +
                        "на какое-то время. Результат проверки Залечь на дно распределите между тремя категориями по соответствующей таблице на полях. Тайное убежище " +
                        "существует, пока его не уничтожат, и преступник всегда nможет в него вернуться.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 107,
                        StatId = 6,
                        Name = "Уязвимость",
                        Description = "Преступник может совершить встречную проверку Уязвимости против навыка Обман разумной цели, чтобы определить самую дорогую для цели вещь или личность. " +
                        "Это также даёт преступнику бонус +1 к Запугиванию за каждые 2 пункта свыше Обмана цели. Этот бонус действует до тех пор, покауязвимость цели не изменится.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 108,
                        StatId = 8,
                        Name = "Взять на заметку",
                        Description = "Преступник может совершить проверку способности Взять на заметку со СЛ, равной Эмп х З цели, чтобы оставить метку на её двери или что-то подобное. " +
                        "При успехе цель должна проходить проверку Харизмы, Убеждения или Запугивания, результат которой должен быть выше проверки Взять на заметку преступника, чтобы " +
                        "получить помощь или услугу у кого-либо в своём поселении.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 109,
                        StatId = 8,
                        Name = "Сбор",
                        Description = "Один раз в день, потратив час, преступник может совершить проверку Сбора с установленной ведущим СЛ. За каждые 2 пункта выше установленной СЛ " +
                        "преступник может завербовать 1 разбойника на количество дней, равное значению Сбора. Если у разбойника меньше половины ПЗ, он должен совершить бросок " +
                        "десятигранной кости, результат которого должен быть ниже значения Воли преступника; в противном случае разбойник убегает.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 110,
                        StatId = 3,
                        Name = "Прицеливание",
                        Description = "Преступник, не участвующий в бою, может потратить раунд, чтобы прицелиться, и совершить проверку Прицеливания со СЛ, равной Реа х 3 цели, " +
                        "чтобы получить бонус к следующей атаке, равный половине значения Прицеливания. Если преступника заметят после броска, но до атаки, бонус снижается в два раза.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 111,
                        StatId = 3,
                        Name = "Прямо в глаз",
                        Description = "Вместо атаки преступник может совершить проверку способности Прямо в глаз, чтобы временно ослепить цель. " +
                        "Для этого необходимо, чтобы преступник находился на дистанции ближнего боя; к удару при этом применяется штраф -3. " +
                        "При попадании цель получает 2d6 урона без модификаторов и ослепляется на количество раундов, равное значению Прямо в глаз. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 112,
                        StatId = 3,
                        Name = "Удар ассасина",
                        Description = "Устраивая засаду, преступник может совершить встречную проверку способности Удар ассасина против Внимания цели, чтобы скрыться после атаки. " +
                        "Эту способность можно использовать в любой ситуации, но к ней применяются штрафы в зависимости от освещённости и других условий. Если противников несколько, " +
                        "каждый может совершить по броску, чтобы попытаться заметить преступника. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Ремесленник 113 по 122
                     new Skill
                    {
                        Id = 113,
                        StatId = 7,
                        Name = "Быстрый ремонт",
                        Description = "Умелый ремесленник способен наскоро подлатать оружие или броню, чтобы их владелец мог продолжать сражаться. " +
                        "Ремесленник свяжет вместе обрывки лопнувшей тетивы, заострит край сломанного клинка или приколотит металлическую пластину поверх треснувшего щита. " +
                        "Ремесленник может потратить ход и совершить проверку Быстрого ремонта со сложностью, равной СЛ Изготовления данного предмета минус 3, " +
                        "чтобы восстановить 1/2 прочности брони или 1/2 надёжности сломанного оружия или щита. Пока оружие после Быстрого ремонта не починят в кузнице, " +
                        "оно наносит половину обычного урона.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 114,
                        StatId = 1,
                        Name = "Большой каталог",
                        Description = "Умелый ремесленник способен запомнить огромное количество чертежей на все случаи жизни. " +
                        "Когда ремесленник уже запомнил максимальное доступное ему количество чертежей, он может совершить проверку способности Большой каталог со СЛ 15, " +
                        "чтобы запомнить ещё один. Нет ограничения на количество запомненных чертежей, но за каждые 10 запоминаний СЛ проверки повышается на 1. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 115,
                        StatId = 7,
                        Name = "Подмастерье",
                        Description = "Когда ремесленник начинает изготавливать какой-либо предмет, он может совершить проверку способности Подмастерье со СЛ, " +
                        "равной СЛ Изготовления данного предмета. При успехе он прибавляет 1 к урону или к прочности за каждые 2 пункта сверх указанной СЛ. " +
                        "Максимальный бонус к урону или прочности равен 5. Ремесленник не может использовать Удачу для увеличения этого бонуса.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 116,
                        StatId = 7,
                        Name = "Мастерская работа",
                        Description = "Мастерская работа позволяет ремесленнику изготавливать предметы уровня мастера. " +
                        "Ремесленник может также в любой момент совершить проверку способности Мастерская работа со СЛ, равной СЛ Изготовления предмета, чтобы навсегда придать " +
                        "броне сопротивление (он сам решает, чему именно) или бонус оружию: дробящее оружие получает свойство дезориентирующее (-2), колющее или режущее — кровопускающее (50%).",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 117,
                        StatId = 1,
                        Name = "Список лекарств",
                        Description = "Умелый ремесленник способен запомнить огромное количество формул на все случаи жизни. Когда ремесленник уже запомнил доступное ему число формул, " +
                        "он может совершить проверку способности Список лекарств со СЛ 15, чтобы запомнить ещё одну. Нет ограничения на количество запомненных формул, но за каждые 10 " +
                        "запоминаний СЛ проверки повышается на 1.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 118,
                        StatId = 7,
                        Name = "Двойная порция",
                        Description = "Когда ремесленник собирается изготовить алхимический состав, он может совершить проверку Двойной порции со СЛ, равной СЛ Изготовления данной формулы. " +
                        "При успехе он создаёт две порции состава из ингредиентов, рассчитанных на одну порцию. Это применимо ко всем алхимическим предметам, включая эликсиры, масла, отвары и бомбы.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 119,
                        StatId = 7,
                        Name = "Адаптация",
                        Description = "Перед созданием ведьмачьего эликсира ремесленник может совершить проверку Адаптации (3 + СЛ Изготовления), чтобы уменьшить СЛ избегания " +
                        "отравления на 1 за каждый пункт свыше СЛ Изготовления. При провале ядовитость эликсира не меняется. СЛ избегания отравления не может опускаться ниже 12.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 120,
                        StatId = 7,
                        Name = "Улучшение",
                        Description = "Ремесленник может совершить проверку Улучшения со СЛ, указанной в таблице на полях, чтобы придать оружию или броне особые свойства " +
                        "(при наличии инструментов ремесленника). На улучшение необходимо потратить 3 раунда. Для улучшения не обязательно использовать кузницу, но она даёт " +
                        "бонус +2 к проверке. Критический провал наносит предмету урон, равный значению провала.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 121,
                        StatId = 7,
                        Name = "Серебрение",
                        Description = "Ремесленник может посеребрить имеющееся оружие в кузнице, совершив проверку со СЛ 16. Количество необходимых для этого серебряных слитков зависит от размера оружия. При успехе оружие наносит +ld6 урона серебром за каждые 3 пункта свыше сложности, но не более 5d6. При провале оружие ломается",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 122,
                        StatId = 7,
                        Name = "Прицельный удар",
                        Description = "Ремесленник может совершить проверку способности Прицельный удар со СЛ, равной СЛ Изготовления предмета, чтобы найти в нём изъян. " +
                        "На осмотр предмета уходит 1 раунд, но это позволяет ремесленнику совершить прицельную атаку со штрафом -6, чтобы нанести разрушающий урон оружию или броне, " +
                        "равный результату броска шестигранных костей в количестве, равном значению Прицельного удара.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Торговец 123 по 132
                    new Skill
                    {
                        Id = 123,
                        StatId = 1,
                        Name = "Бывалый путешественник",
                        Description = "Обычный торговец зарабатывает на жизнь тем, что продаёт товар приходящим к нему покупателям. Странствующий же торговец сам приходит к покупателю. " +
                        "Он ездит по миру и узнаёт обо всём, что там происходит. Торговец может в любой момент по своему желанию совершить проверку навыка Бывалый путешественник, чтобы " +
                        "узнать один факт об определённом предмете, культуре или области. СЛ проверки определяет ведущий. При успехе торговец получает ответ на вопрос, вспомнив те времена, " +
                        "когда он в прошлый раз был в этом месте. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 124,
                        StatId = 1,
                        Name = "Рынок",
                        Description = "Торговец может совершить проверку Рынка с определяемой ведущим СЛ, чтобы найти нужный предмет по более низкой цене. При успехе торговец находит " +
                        "того, кто продаст ему тот же предмет за полцены. Чем более редкий предмет, тем выше СЛ поиска. Рынок не действует на экспериментальные, ведьмачьи предметы и реликвии.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 125,
                        StatId = 6,
                        Name = "Нечестная сделка",
                        Description = "Совершая подкуп, торговец может совершить проверку способности Нечестная сделка со СЛ, равной ВолехЗ цели. При успехе торговец даёт взятку любым " +
                        "предметом, который у него есть и который стоит не менее 5 крон. Взятка всегда даёт +3 к Убеждению. Если взятка совсем уж несуразна, СЛ увеличивается на 5",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 126,
                        StatId = 6,
                        Name = "Обещание",
                        Description = "При попытке купить предмет торговец может совершить проверку Обещания со СЛ, равной Эмп х 3 продавца. При успехе продавец верит обещанию торговца " +
                        "заплатить позже. Количество недель, через которое необходимо выполнить это обязательство, равно значению Обещания.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 127,
                        StatId = 6,
                        Name = "Трущобы",
                        Description = "Торговец может совершить проверку способности Трущобы со СЛ в зависимости от размера поселения, чтобы заручиться помощью 1 беспризорника или " +
                        "бездомного за каждый пункт свыше СЛ (максимум 10). Торговец может спросить у них совета и получить бонус +1 к проверкам Ориентирования в городе за каждого. " +
                        "Информаторы берут плату в 1 крону на каждого, когда с ними советуются.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 128,
                        StatId = 1,
                        Name = "Свой человек",
                        Description = "Торговец со способностью Свой человек может убедить другого персонажа пошпионить на него. Заплатите 10 крон и совершите встречную проверку Своего " +
                        "человека против Сопротивления убеждению цели. При успехе персонаж будет шпионить для торговца количество дней, равное значению способности Свой человек. " +
                        "По истечении этого срока торговец может снова совершить проверку, опять же заплатив.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 129,
                        StatId = 1,
                        Name = "Карта сокровищ",
                        Description = "Один разза игровую партию торговец может совершить проверку способности Карта сокровищ со СЛ, определяемой ведущим, чтобы вспомнить предполагаемое " +
                        "местонахождение реликвии или руин, в которых может оказаться что-то полезное. Место, где находится этот предмет или руины, " +
                        "расположено достаточно далеко или же кишит опасностями. Чтобы добраться до него, потребуется целая игровая партия.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 130,
                        StatId = 8,
                        Name = "Хорошие связи",
                        Description = "Входя в поселение впервые, торговец может потратить час на распространение вести о своём прибытии, а затем совершить проверку Хороших связей " +
                        "со СЛ в зависимости от размера поселения. При успехе репутация торговца в этом поселении на ld6 недель увеличивается на значение проверки свыше указанной СЛ, " +
                        "делённое на 2 (минимум 1).",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 131,
                        StatId = 1,
                        Name = "Сбытчик",
                        Description = "Торговец, которому необходимо избавиться от предмета с сомнительным происхождением или краденого, может совершить проверку способности Сбытчик со СЛ, " +
                        "определяемой ведущим. При успехе торговец продаёт предмет по полной рыночной цене покупателю, который не станет задавать лишних вопросов и не сдаст торговца страже.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 132,
                        StatId = 6,
                        Name = "Воинский долг",
                        Description = "Торговец может совершить проверку способности Воинский долг, чтобы попросить о помощи воина, который у него в долгу. Результат броска необходимо " +
                        "распределить по 3 категориям, указанным в таблице на полях. Воин будет работать на торговца количество дней, равное значению Воинского долга, и без лишних вопросов " +
                        "исполнит любой приказ в пределах разумного. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion

                    #region Бард 133 по 142
                    new Skill
                    {
                        Id = 133,
                        StatId = 6,
                        Name = "Уличное выступление",
                        Description = "Бард весьма полезен в группе, особенно когда у вас не хватает денег. Бард может потратить час времени и совершить проверку Уличного выступления в центре " +
                        "ближайшего города. Результат броска — это сумма, которую бард заработал за время уличного выступления. Критический провал может снизить результат броска. " +
                        "Отрицательный результат означает, что бард не только не заработал денег, но и был освистан местными, что даёт ему штраф -2 к Харизме при контакте со всеми в " +
                        "этом городе на остаток дня.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 134,
                        StatId = 6,
                        Name = "Повторное выступление",
                        Description = "Перед проверкой Уличного выступления бард может совершить проверку Повторного выступления со СЛ, установленной ведущим, " +
                        "чтобы определить, выступал ли он в этом городе раньше. При успехе бард уже завоевал популярность в этом городе. В таком случае доход с его Уличного выступления " +
                        "удваивается, а сам бард получает бонус +2 к Харизме при общении со всеми, кто пришёл на выступление. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 135,
                        StatId = 6,
                        Name = "Заворожить публику",
                        Description = "Выступая в течение полного раунда, вы можете совершить проверку способности Заворожить публику, чтобы привлечь внимание всех в радиусе 20 метров. " +
                        "Любой персонаж, чей результат проверки Сопротивления убеждению будет ниже вашего изначального, может только стоять и наблюдать, пока не выбросит более высокий результат. " +
                        "Атакованные цели автоматически перестают быть заворожёнными.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 136,
                        StatId = 6,
                        Name = "Добрый друг",
                        Description = "Один раз за игровую партию бард может совершить проверку способности Добрый друг, чтобы найти друга, который помог бы ему. " +
                        "Результат броска необходимо распределить между 3 категориями, указанными в таблице «Добрый друг» на полях. Друг по старой памяти окажет вам одну услугу в пределах разумного, " +
                        "после чего не будет больше помогать бесплатно и его нужно будет уговаривать.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 137,
                        StatId = 1,
                        Name = "Незаметность",
                        Description = "Бард может совершить проверку Незаметности против Внимания нескольких целей, чтобы слиться с толпой. " +
                        "Эта способность позволяет барду прятаться даже там, где нет подходящих укрытий, — бард попросту вклинивается в разговор, переключает внимание окружающих на другой " +
                        "предмет и тому подобное. Эта способность не работает в том случае, если бард одет во что-то очень броское.",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 138,
                        StatId = 1,
                        Name = "Пустить слух",
                        Description = "После успешного броска Обмана против цели бард может совершить встречный бросок способности Пустить слух против Сопротивления убеждению цели. " +
                        "При успехе барда цель распространяет рассказанную им ложь в своём поселении или группе, что даёт барду бонус +2 к Обману при попытке рассказать ту же ложь кому-то ещё",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 139,
                        StatId = 1,
                        Name = "Сойти за своего",
                        Description = "Находясь в поселении, бард может совершить проверку Сойти за своего (см. таблицу на полях). При успехе бард узнаёт, как выдать себя за местного, " +
                        "и его больше не считают чужим. Он получает бонус +2 к Харизме и Убеждению при общении с местными. При этом к нему не будут относиться с подозрением или подвергать " +
                        "травле, как чужак",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 140,
                        StatId = 6,
                        Name = "Коварство",
                        Description = "Когда бард пытается повлиять на одного или нескольких собеседников, он может совершить проверку Коварства против Эмп х 3 цели. " +
                        "При успехе бард делает ехидное замечание, которое даёт штраф -1 к Соблазнению, Убеждению, Лидерству, Запугиванию или Харизме цели за каждый пункт свыше СЛ. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 141,
                        StatId = 6,
                        Name = "Подколка",
                        Description = "Бард может совершить встречную проверку способности Подколка против Сопротивления убеждению цели. При успехе бард дразнит цель, " +
                        "осыпает её угрозами и ругательствами до тех пор, пока цель не нападёт. Цель получает штраф к атаке и защите, равный половине значения Подколки барда и " +
                        "длящийся количество раундов, равное значению способности Подколка. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    new Skill
                    {
                        Id = 142,
                        StatId = 6,
                        Name = "И ты, Брут",
                        Description = "Бард может совершить проверку способности И ты, Брут против ВолихЗ цели, чтобы настроить цель против одного союзника. " +
                        "При успехе ложь или полуправда, сказанная бардом, заставляет цель относиться к своему союзнику с подозрением и враждебностью количество дней, равное " +
                        "значению И ты, Брут, или пока цель не совершит проверку Сопротивления убеждению, результат которой выше результата И ты, Брут. ",
                        IsClassSkill = true,
                        IsDifficult = false,
                        SourceId = 1,
                    },
                    #endregion
            });

            builder.Entity<Effect>().HasData(new Effect[]
            {
                //Эффекты предметов
                new Effect{Id = 1, Name = "Незаметное", Description = "Это оружие легко спрятать. Вы получаете бонус +2 при попытке скрыть это оружие.", SourceId = 1},
                new Effect{Id = 2, Name = "Кровопускающее", Description = "Если это оружие нанесёт урон цели, с определённой вероятностью оно может вызвать кровотечение." +
                                                                            "Вероятность кровотечения указана в скобках.",  SourceId = 1},
                new Effect{Id = 3, Name = "Пробивающее броню", Description = "Такое оружие игнорирует сопротивление урону любой брони, по которой оно попадает.",  SourceId = 1},
                new Effect{Id = 4, Name = "Дезориентирующее(1)", Description = "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости," +
                                                                                " к которому применяется штраф, указанный в скобках.", SourceId = 1},
                new Effect{Id = 5, Name = "Дезориентирующее(2)", Description = "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости," +
                                                                                " к которому применяется штраф, указанный в скобках.", SourceId = 1},
                new Effect{Id = 6, Name = "Дезориентирующее(3)", Description = "Когда этим оружием наносят удар по туловищу или голове, противник должен совершить испытание Устойчивости," +
                                                                                " к которому применяется штраф, указанный в скобках.", SourceId = 1},
                new Effect{Id = 7, Name = "Метеоритное", Description = "Это оружие наносит полный урон чудовищам, уязвимым к метеоритной стали. " +
                                                                        "Также такое оружие имеет 5 дополнительных пунктов надёжности.", SourceId = 1},
                new Effect{Id = 8, Name = "Длинное", Description = "Этим оружием можно атаковать противников в пределах 2 метров.", SourceId = 1},
                new Effect{Id = 9, Name = "Фокусирующее(1)", Description = "При сотворении магии с помощью этого оружия вычтите его значение фокусировки " +
                                                                            "из стоимости заклинания в Вын.",  SourceId = 1},
                new Effect{Id = 10, Name = "Фокусирующее(2)", Description = "При сотворении магии с помощью этого оружия вычтите его значение фокусировки " +
                                                                            "из стоимости заклинания в Вын.",  SourceId = 1},
                new Effect{Id = 11, Name = "Фокусирующее(3)", Description = "При сотворении магии с помощью этого оружия вычтите его значение фокусировки " +
                                                                            "из стоимости заклинания в Вын.",  SourceId = 1},
                new Effect{Id = 12, Name = "Сокрушающая сила", Description = "Атаки наносят двойной разрушающий урон оружию, щиту или броне.", SourceId = 1},
                new Effect{Id = 13, Name = "Серебрянное", Description = "Когда вы атакуете чудовище восприимчивое к серебряному оружию, то наносите не только " +
                                                                        "стандартный урон, но и определённое количество урона от серебра, обозначенное в скобках.",  SourceId = 1},
                new Effect{Id = 14, Name = "Сбалансированное(1)", Description = "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого " +
                                                                                "ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности " +
                                                                                "критического ранения.", SourceId = 1},
                new Effect{Id = 15, Name = "Сбалансированное(2)", Description = "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого " +
                                                                                "ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности " +
                                                                                "критического ранения.", SourceId = 1},
                new Effect{Id = 16, Name = "Сбалансированное(3)", Description = "При нанесении критического ранения этим оружием бросьте 2d6+2 для определения места этого " +
                                                                                "ранения. Если атака была прицельной, бросьте 1d6+1 вместо 1d6 для определения серьёзности " +
                                                                                "критического ранения.", SourceId = 1},
                new Effect{Id = 17, Name = "Улучшенное пробивание брони", Description = "Такое оружие игнорирует сопротивление урону любой брони и половину прочности брони," +
                                                                                        "по которой оно попадает.", SourceId = 1},
                new Effect{Id = 18, Name = "Захватное", Description = "Это оружие можно использовать для захвата и подсечки противника в пределах дистанции.", SourceId = 1},
                new Effect{Id = 19, Name = "Ловящий лезвия", Description = "Когда владелец блокирует рукопашную атаку врага этим оружием, часть его оружия оказывается в " +
                                                                           "ловушке. Оба оружия становятся бесполезными и не могут быть разделены до тех пор, пока противник " +
                                                                           "не сможет пройти проверку Силы или Ловкости рук, которая превзойдет изначальную проверку " +
                                                                           "Владения лёгкими клинками, или пока владелец не выпустит свое оружие.", SourceId = 1},
                new Effect{Id = 20, Name = "Магические путы", Description = "Пока существо прикасается к этому оружию, оно не может стать невидимым или неосязаемым или " +
                                                                            "использовать любую способность, которая позволяет ему телепортироваться. Существа, которые уже" +
                                                                            " являются невидимыми или неосязаемыми, становятся видимыми и осязаемыми при " +
                                                                            "прикосновении к этому оружию.", SourceId = 1},
                new Effect{Id = 21, Name = "Медленно перезаряжающееся", Description = "Для перезарядки этого оружия требуется 1 действие.", SourceId = 1},
                new Effect{Id = 22, Name = "Несмертельное", Description = "Это оружие можно использовать для нанесения несмертельного урона без штрафов.", SourceId = 1},
                new Effect{Id = 23, Name = "Опутывающее", Description = "Цель, пораженная этим оружием, становится опутанной. Она снижает свою Скор на 5 и получает " +
                                                                        "штраф -2 ко всем физическим действиям. Каждый ход цель может совершать проверку " +
                                                                        "Уклонения/Изворотливости или Борьбы со СЛ 18, чтобы высвободиться. В качестве альтернативы другой " +
                                                                        "персонаж может потратить действие, чтобы освободить опутанного.", SourceId = 1},
                new Effect{Id = 24, Name = "Парирующее", Description = "-2 к штрафу за парирование.", SourceId = 1},
                new Effect{Id = 25, Name = "Разрушающее", Description = "При попадании это оружие наносит 1d6 / 2 урона прочности брони.", SourceId = 1},
                new Effect{Id = 26, Name = "Рукопашное", Description = "Такое оружие использует навык Борьба. Его урон прибавляется к урону от атаки без оружия.", SourceId = 1},
                new Effect{Id = 27, Name = "Расчетная перезарядка", Description = "Чтобы перезарядить это оружие, требуется потратить 2 действия. Эти действия могут " +
                                                                                   "быть совершены двумя разными персонажами.", SourceId = 1},
                new Effect{Id = 28, Name = "Улучшенное фокусирующее", Description = "При сотворении заклинаний с помощью этого оружия СЛ проверок против ваших " +
                                                                                    "заклинаний считается на 2 выше.", SourceId = 1},
                new Effect{Id = 29, Name = "Устанавливаемое", Description = "Это оружие фиксируется в одном месте, а не удерживается. Персонаж должен потратить " +
                                                                            "действие, чтобы установить оружие там, где он хочет его использовать, и должен " +
                                                                            "потратить действие, чтобы демонтировать его, когда он захочет снова его переместить.", SourceId = 1},
                new Effect{Id = 30, Name = "Шприц", Description = "Это оружие может быть заряжено флаконом с любым ядом или эликсиром. Когда владелец наносит " +
                                                                   "урон этим оружием, он впрыскивает содержимое глубоко в организм цели. Это увеличивает СЛ для " +
                                                                   "избавления от яда на 3 или увеличивает продолжительность действия эликсира на 3 раунда.", SourceId = 1},
                new Effect{Id = 31, Name = "Закрывает все тело", Description = "Данный доспех закрывает: голову, туловище, руки и ноги.", SourceId = 1},
                new Effect{Id = 32, Name = "Огнеупорный", Description = "Если атака, заблокированная этим щитом, была огненной, то щит не " +
                                                                        "получает повреждений от блокирования.", SourceId = 1},
                new Effect{Id = 33, Name = "Ограничение зрения", Description = "Как только персонаж опускает забрало шлема, его поле зрения сужается до конуса прямо " +
                                                                                "перед ним вместо обычного поля от плеча до плеча. Этот эффект также отменяет " +
                                                                                "Обострённые чувства ведьмака (бонус к Вниманию и выслеживанию по запаху).", SourceId = 1},
                new Effect{Id = 34, Name = "Полное укрытие", Description = "Этот щит достаточно велик, чтобы за ним можно было спрятаться целиком, как за стенкой. " +
                                                                            "Если персонаж сидит на корточках за этим щитом, она действует как укрытие, и любая атака, " +
                                                                            "направленная против персонажа, должна нанести урон, превышающий надёжность щита, " +
                                                                            "чтобы навредить персонажу. Каждый раз, когда этот щит получает урон, " +
                                                                            "его надёжность снижается на 1.", SourceId = 1},
                new Effect{Id = 35, Name = "Сопротивление(Д)", Description = "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Д – Дробящий урон.", SourceId = 1},
                new Effect{Id = 36, Name = "Сопротивление(Р)", Description = "Снижает урон от атак определённого типа в два раза после вычитания ПБ. Р – Режущий урон.", SourceId = 1},
                new Effect{Id = 37, Name = "Сопротивление(К)", Description = "Снижает урон от атак определённого типа в два раза после вычитания ПБ. К – Колющий урон.", SourceId = 1},
                new Effect{Id = 38, Name = "Сопротивление(С)", Description = "Снижает урон от атак определённого типа в два раза после вычитания ПБ. " +
                                                                             "С – Стихийный (обычно указывается стихия вместо буквы).", SourceId = 1},

                //Эффекты в целом
                new Effect{Id = 39, Name = "Горение", Description = "Персонаж объят пламенем. Каждый ход он получает 5 пунктов урона по каждой части тела. " +
                                                                    "Броня поглощает урон, но при этом огонь наносит 1 урон броне и оружию каждый ход. " +
                                                                    "Чтобы погасить огонь, персонаж должен потратить ход либо на обливание водой, либо " +
                                                                    "на то, чтобы упасть на землю, покататься и сбить пламя.", SourceId = 1},
                new Effect{Id = 40, Name = "Дезориентация", Description = "Персонаж дезориентирован. У него кружится голова, перед глазами всё плывёт. В этом " +
                                                                            "состоянии он не может совершать каких-либо действий, а для того, чтобы попасть по нему, " +
                                                                            "достаточно пройти проверку со СЛ 10. Чтобы завершить этот эффект, персонаж должен пройти " +
                                                                            "испытание Устойчивости. Это действие занимает полный ход. Если по персонажу попадают, " +
                                                                            "пока он дезориентирован, он тут же приходит в себя.", SourceId = 1},
                new Effect{Id = 41, Name = "Отравление", Description = "В крови персонажа течёт яд, наносящий ему каждый ход 3 урона, не снижаемые бронёй. Чтобы прекратить " +
                                                                        "действие яда, персонаж должен пройти проверку Стойкости со СЛ 15, потратив одно действие.", SourceId = 1},
                new Effect{Id = 42, Name = "Кровотечение", Description = "При ранении был задет крупный сосуд, из-за чего рана сильно кровоточит. Персонаж получает 2 урона " +
                                                                        "каждый ход до тех пор, пока кровотечение не будет остановлено. Для этого необходимо либо сотворить " +
                                                                        "исцеляющее заклинание, либо совершить успешную проверку " +
                                                                        "Первой помощи со СЛ 15, потратив одно действие.", SourceId = 1},
                new Effect{Id = 43, Name = "Замораживание", Description = "Персонаж не превратился в цельный кусок льда, но тело его плохо слушается, а одежда " +
                                                                        "покрыта наледью. До тех пор, пока персонаж не сломает лёд, он получает штраф -3 к " +
                                                                        "Скор и -1 к Реа. Лёд можно сломать, пройдя проверку Силы со СЛ 16 и " +
                                                                        "потратив одно действие.", SourceId = 1},
                new Effect{Id = 44, Name = "Ошеломление", Description = "Персонаж теряет равновесие и получает штраф -2 к атаке и защите. К началу " +
                                                                        "следующего хода вашего персонажа эффект проходит и штраф отменяется.", SourceId = 1},
                new Effect{Id = 45, Name = "Опьянение", Description = "Персонаж пьян. Он получает штраф -2 к Реа, Лвк и Инт, а также -3 в Словесной дуэли. " +
                                                                        "Есть шанс 25%, что персонаж будет плохо помнить, что делал в состоянии опьянения.", SourceId = 1},
                new Effect{Id = 46, Name = "Галлюцинации", Description = "Персонаж видит образы и вещи, которых на самом деле нет. Ведущий может свободно выбирать, " +
                                                                        "какой ложный сенсорный эффект почувствует на себе ваш персонаж. Для того чтобы отличить " +
                                                                        "одну иллюзию от реальности, требуется проверка Дедукции со СЛ 15.", SourceId = 1},
                new Effect{Id = 47, Name = "Тошнота", Description = "Персонаж ощущает тяжесть в желудке и сосредоточенно пытается сдержать рвоту. Каждые 3 раунда " +
                                                                    "персонаж обязан совершать бросок 1d10, результат которого должен быть ниже его Тел. " +
                                                                    "В противном случае в течение одного раунда его будет рвать " +
                                                                    "или он будет мучим рвотными позывами.", SourceId = 1},
                new Effect{Id = 48, Name = "Удушье", Description = "Персонажу нечем дышать, он задыхается. Каждый раунд персонаж получает З урона, не снижаемые бронёй. " +
                                                                    "Способы избавиться от удушья разные, в зависимости от ситуации. Восстановление доступа к воздуху " +
                                                                    "(персонаж выныривает, выворачивается из удушающего захвата и т.д.) прекращает этот эффект.", SourceId = 1},
                new Effect{Id = 49, Name = "Слепота", Description = "Глаза персонажа закрыты или повреждены. Пока персонаж не потратит ход, чтобы восстановить зрение, " +
                                                                    "он получает штраф -3 ко всем атакам и защите и штраф -5 к " +
                                                                    "проверкам Внимания, связанным со зрением.", SourceId = 1},

                new Effect{Id = 50, Name = "Дистанция", Description = "Дистанция, на которую можно бросать предмет или стрелять из него", SourceId = 1},
                new Effect{Id = 51, Name = "Точность+1", Description = "Бонус к броскам на попадание", SourceId = 1},
                new Effect{Id = 52, Name = "Точность+2", Description = "Бонус к броскам на попадание", SourceId = 1},
                new Effect{Id = 53, Name = "Точность+3", Description = "Бонус к броскам на попадание", SourceId = 1},

                new Effect{Id = 54, Name = "Колющий", Description = "Наносит Колющий урон", SourceId = 1},
                new Effect{Id = 55, Name = "Дробящий", Description = "Наносит Дробящий урон", SourceId = 1},
                new Effect{Id = 56, Name = "Режущий", Description = "Наносит Режущий урон", SourceId = 1},

                new Effect{Id = 57, Name = "Без сознания", Description = "Персонаж лежит без сознания или спит. Он считается сбитым с ног и не может " +
                                                                        "двигаться и совершать какие-либо действия, кроме Отдыха. Условия прекращения " +
                                                                        "этого состояния зависят от причины, которая его вызвала.", SourceId = 1},

                new Effect{Id = 58, Name = "Ночное зрение", Description = "Нет штрафов при тусклом свете", SourceId = 1},
                new Effect{Id = 59, Name = "Улучшенное ночное зрение", Description = "Нет штрафов при тусклом свете и при отсутствии освещения", SourceId = 1},
            });

            //ВСЕ НИЖЕ ДЛЯ ТЕСТА, ПОСЛЕ НАДО БД ПЕРЕСОБРАТЬ!!!

            //96 ID текущий максимальный
            #region Предметы

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

                #region Ингредиенты чудищ
                new Component{
                    Id = 92,
                    Name = "Лимфа чудовища",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 152,
                    Amount = "С чудовища",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Quebrith,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = "Существа (бруксы, гаркаины, высшие вампиры)",
                },
                new Component{
                    Id = 93,
                    Name = "Слюна Альпа",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 145,
                    Amount = "С чудовища",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Hydragenium,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = "Существа (Альпы)",
                },
                new Component{
                    Id = 94,
                    Name = "Эссенция смерти",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 155,
                    Amount = "С чудовища",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Fulgur,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = "Существа (вендиго, бруксы, альпы)",
                },
                new Component{
                    Id = 95,
                    Name = "Зубы вампира",
                    SourceId = 1,
                    Weight = 0.1,
                    Price = 150,
                    Amount = "С чудовища",
                    Complexity = 20,
                    IsAlchemical = true,
                    SubstanceType = (int)SubstanceType.Caelum,
                    AvailabilityType = (int)ItemAvailabilityType.Rare,
                    WhereToFind = "Существа (катаканы, альпы)",
                },
                #endregion

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
                },
                new Item{
                    Id = 96,
                    Name = "Обычные предметы",
                    SourceId = 1,
                    Weight = 0,
                    Price = 1,
                    Description = "Обычные предметы по усмотрению мастера",
                },
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
                    EquipmentType = (int)WeaponEquipmentType.SmallBlades,
                    ItemOriginType = (int)ItemOriginType.Human,
                    Type = (int)AttackType.PiercingAndSlashing,
                    Accuracy = 1,
                    AvailabilityType = (int)ItemAvailabilityType.Common,
                    Damage = "1к6",
                    Reliability = 5,
                    Grip = 1,
                    Distance = 0,
                    SkillId = 18,
                    StealthType = (int)ItemStealthType.Tiny,
                    AmountOfEnhancements = 1,
                }
            });

            #endregion

            #region #Creatures Data

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
                    IsPlayable = true,
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
                    IsPlayable = true,
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
                    IsPlayable = true,
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
                    IsPlayable = true,
                },
                new Race
                {
                    Id = 5,
                    Name = "Гуманоиды",
                    Description = "Формально гуманоиды чудовищами не являются. Это люди, эльфы, краснолюды и прочие представители Старших Народов. " +
                    "Гуманоиды разнообразны в плане поведения и мест обитания. Важно помнить, что даже по стандартным правилам гуманоиды не имеют" +
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
                },
                new Ability
                {
                    Id = 14,
                    Name = "Звуковая волна",
                    Description = "В качестве действия полного хода альп может издать направленный звук в 6-метровом конусе. Все в этом конусе должны совершить проверку изменения позиции со СЛ 16 " +
                    "или блокировать атаку щитом. Если цель не сумела защититься, она получает 5к6 урона в туловище, отлетает на 4 метра и ошеломлена. Если цель успешно блокировала атаку, она должна " +
                    "совершить проверку Силы со СЛ 16 и при провале все равно отлетает на 4 метра.",
                    RaceId = 16,
                    SourceId = 1,
                    Type = (int)AbilityType.FullAction,
                },
                new Ability
                {
                    Id = 15,
                    Name = "Усыпляющая слюна",
                    Description = "Слюна альпа является сильнодействующим снотворным средством. Ничего не подозревающее существо, вступившее в контакт с этой слюной, должно пройти проверку " +
                    "Стойкости СЛ 16, инчае погрузиться в глубокий сон, наполненный яркими кошмарами. Существо, знающее об этом эффекте или находящееся в бою, вместо этого снижает свою Выносливость " +
                    "на 5 и может пройти проверку Стойкости СЛ 18, чтобы проснуться каждый раз, когда он получает урон или кто-то тратит действие, чтобы разбудить его. Если " +
                    "методы не срабатывают, персонаж просыпается через 8 часов.",
                    RaceId = 16,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 16,
                    Name = "Высасывание крови",
                    Description = "Если альп наносит урон укусом, цель получает дополнительно 2к6 урона, а альп восстанавливает себе столько же ПЗ. Если цель без сознания или спит, альп может " +
                    "использовать этуспособность без атаки Укусом",
                    RaceId = 16,
                    SourceId = 1,
                    Type = (int)AbilityType.Passive,
                },
                new Ability
                {
                    Id = 17,
                    Name = "Туманная форма",
                    Description = "Перемещаясь, альм может превратить свое тело в туман и пройти расстрояние до 14 м. Применяя эту способность, альп может двигаться по горизонтали или по " +
                    "вертикали и проходить через самые маленькие щели и отверстия. Альп не может использовать эту способность в зоне действия бомбы Лунная пыль.",
                    RaceId = 16,
                    SourceId = 1,
                    Type = (int)AbilityType.Action,
                },
                new Ability
                {
                    Id = 18,
                    Name = "Превращение",
                    Description = "Протратив действие, альп может замаскироваться под прекрасного эльфа или небольшое животное. Пока альп замаскирован под эльфа, только прошедший проверку " +
                    "Понимания людей СЛ 16 может заметить, что он кажется чуждым и отталкивающим. Замаскированный под животное альп может принимать форму Собаки или Кошки, используя " +
                    "соответствующий блок характеристик животного (см. Базовую книгу Ведьмака, стра 310), но сохраняя свои характеристики ИНТ, ЭМП, РЕМ и ВОЛЮ и любые сопутствующие навыки. " +
                    "Если альп получает урон или использует любую из своих способностей, кроме Усыпляющей слюны, его маскировка исчезает и он возвращается в свою естественную форму. ",
                    RaceId = 16,
                    SourceId = 1,
                    Type = (int)AbilityType.Action,
                },
                //new Ability
                //{
                //    Id = 19,
                //    Name = "Перенаправляемая атака с разбега",
                //    Description = "Если до цели больше 6 метров, вепрь может в качестве действия полного хода переместиться не больше чем на 15 метров и совершить один удар клыками " +
                //    "с основой 9, нанося 5к6 урона вместо 3к6. После нанесения урона вепрь перемещается на оставшееся расстояние в любом направлении по выбору, в том числе назад " +
                //    "или вперед через пространство цели. Если эта атака провалилась, вепрь перемещается на оставшееся расстояние и может изменить траекторию. Однако при этом он " +
                //    "не может атаковать еще одну цель на своем пути.",
                //    RaceId = 8,
                //    SourceId = 1,
                //    Type = (int)AbilityType.FullAction,
                //},
                //new Ability
                //{
                //    Id = 20,
                //    Name = "Боевой вепрь",
                //    Description = "Некоторые, особенно на Скеллиге, любят заводить себе боевых вепрей. Их выбирают из самых крупных и сильных зверей и приручают убивать. Таких вепрей " +
                //    "зачастую выпускают на поле боя, чтобы нарушить строй противника и деморализовать вражеские силы. У боевого вепря прочность брони 10. Его удар клыками наносит " +
                //    "4к6 урона, а Перенаправляемая атака с разбега - 5к6 урона. У этих атак основа 15.",
                //    RaceId = 8,
                //    SourceId = 1,
                //    Type = (int)AbilityType.Passive,
                //},
            };

            builder.Entity<Ability>().HasData(abilityList);

            builder.Entity<SkillsTree>().HasData(new SkillsTree[]
            {
                //Ведьмак
                new SkillsTree
                {
                    Id = 1,

                    LeftBranchName = "Магический клинок",
                    MiddleBranchName = "Мутант",
                    RightBranchName = "Убийца",

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

                //Воин
                new SkillsTree
                {
                    Id = 2,

                    LeftBranchName = "Стрелок",
                    MiddleBranchName = "Охотник за головами",
                    RightBranchName = "Убийца",

                    MainSkillId = 63,
                    FirstLeftSkillId = 64,
                    SecondLeftSkillId = 65,
                    ThirdLeftSkillId = 66,

                    FirstMiddleSkillId = 67,
                    SecondMiddleSkillId = 68,
                    ThirdMiddleSkillId = 69,

                    FirstRightSkillId = 70,
                    SecondRightSkillId = 71,
                    ThirdRightSkillId = 72,
                },

                //Жрец
                new SkillsTree
                {
                    Id = 3,

                    LeftBranchName = "Проповедник",
                    MiddleBranchName = "Друид",
                    RightBranchName = "Фанатик",

                    MainSkillId = 73,
                    FirstLeftSkillId = 74,
                    SecondLeftSkillId = 75,
                    ThirdLeftSkillId = 76,

                    FirstMiddleSkillId = 77,
                    SecondMiddleSkillId = 78,
                    ThirdMiddleSkillId = 79,

                    FirstRightSkillId = 80,
                    SecondRightSkillId = 81,
                    ThirdRightSkillId = 82,
                },

                //Маг
                new SkillsTree
                {
                    Id = 4,

                    LeftBranchName = "Политик",
                    MiddleBranchName = "Ученый",
                    RightBranchName = "Архимаг",

                    MainSkillId = 83,
                    FirstLeftSkillId = 84,
                    SecondLeftSkillId = 85,
                    ThirdLeftSkillId = 86,

                    FirstMiddleSkillId = 87,
                    SecondMiddleSkillId = 88,
                    ThirdMiddleSkillId = 89,

                    FirstRightSkillId = 90,
                    SecondRightSkillId = 91,
                    ThirdRightSkillId = 92,
                },

                //Медик
                new SkillsTree
                {
                    Id = 5,

                    LeftBranchName = "Хирург",
                    MiddleBranchName = "Травник",
                    RightBranchName = "Анатом",

                    MainSkillId = 93,
                    FirstLeftSkillId = 94,
                    SecondLeftSkillId = 95,
                    ThirdLeftSkillId = 96,

                    FirstMiddleSkillId = 97,
                    SecondMiddleSkillId = 98,
                    ThirdMiddleSkillId = 99,

                    FirstRightSkillId = 100,
                    SecondRightSkillId = 101,
                    ThirdRightSkillId = 102,
                },

                //Преступник
                new SkillsTree
                {
                    Id = 6,

                    LeftBranchName = "Вор",
                    MiddleBranchName = "Атаман",
                    RightBranchName = "Ассасин",

                    MainSkillId = 103,
                    FirstLeftSkillId = 104,
                    SecondLeftSkillId = 105,
                    ThirdLeftSkillId = 106,

                    FirstMiddleSkillId = 107,
                    SecondMiddleSkillId = 108,
                    ThirdMiddleSkillId = 109,

                    FirstRightSkillId = 110,
                    SecondRightSkillId = 111,
                    ThirdRightSkillId = 112,
                },

                //Ремесленник
                new SkillsTree
                {
                    Id = 7,

                    LeftBranchName = "Оружейник",
                    MiddleBranchName = "Алхимик",
                    RightBranchName = "Импровизатор",

                    MainSkillId = 113,
                    FirstLeftSkillId = 114,
                    SecondLeftSkillId = 115,
                    ThirdLeftSkillId = 116,

                    FirstMiddleSkillId = 117,
                    SecondMiddleSkillId = 118,
                    ThirdMiddleSkillId = 119,

                    FirstRightSkillId = 120,
                    SecondRightSkillId = 121,
                    ThirdRightSkillId = 122,
                },

                //Торговец
                new SkillsTree
                {
                    Id = 8,

                    LeftBranchName = "Посредник",
                    MiddleBranchName = "Человек со связями",
                    RightBranchName = "Гавенкар",

                    MainSkillId = 123,
                    FirstLeftSkillId = 124,
                    SecondLeftSkillId = 125,
                    ThirdLeftSkillId = 126,

                    FirstMiddleSkillId = 127,
                    SecondMiddleSkillId = 128,
                    ThirdMiddleSkillId = 129,

                    FirstRightSkillId = 130,
                    SecondRightSkillId = 131,
                    ThirdRightSkillId = 132,
                },

                //Бард
                new SkillsTree
                {
                    Id = 9,

                    LeftBranchName = "Обольститель",
                    MiddleBranchName = "Информатор",
                    RightBranchName = "Интриган",

                    MainSkillId = 133,
                    FirstLeftSkillId = 134,
                    SecondLeftSkillId = 135,
                    ThirdLeftSkillId = 136,

                    FirstMiddleSkillId = 137,
                    SecondMiddleSkillId = 138,
                    ThirdMiddleSkillId = 139,

                    FirstRightSkillId = 140,
                    SecondRightSkillId = 141,
                    ThirdRightSkillId = 142,
                },
            });

            builder.Entity<Class>().HasData(new Class[]
            {
                //Ведьмак
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

                //Бард
                new Class
                {
                    Id = 2,
                    Name = "Бард",
                    Description = "Никогда не знаешь, что случится, пока рядом с тобой бард. Часть лучших моих воспоминаний связана с бардами... Впрочем, часть самых скверных передряг" +
                    " я пережил как раз из-за бардов. Может статься, повстречаешь ты такого барда, как знаменитый Лютик: он и поэт, и искатель приключений, и постоянный спутник легендарного" +
                    " Геральта из Ривии. Он исходил весь мир в поисках знаний и историй, заглядывая в городки и деревни, чтобы петь там о своих многочисленных приключениях. " +
                    "Вот такие, как он, — ребята нормальные. Ну, разве что чёрта с два ты отличишь в их сказкахреальность от выдумки: барды любят правду искажать, чтобы показать себя в лучшем свете. " +
                    "В принципе, обычно это не мешает. Спрашиваешь, каких бардов опасаться стоит? Да всяких шпионов и интриганов. Барды вообще хорошо мозги промывают, да и сказки выдумывать горазды. " +
                    "Они тебеязык заговорят, голову вскружат, марионеткой своей сделают — и всё, будешь думать, что вы друзья до гроба. А потом в самый неожиданный момент получишь нож в печень. " +
                    "Неудивительно, что многие барды шпионят для разных королевств. Впрочем, хороший бард всегда пригодится. Например, нужно тебе узнать какую-то легенду или же хочешь награду " +
                    "получить за голову опасного атамана. Бард-mo тебе наверняка расскажет, на кого ты охотишься, где его найти и как с ним разговаривать. Как я уже говорил, никогда не знаешь, " +
                    "что случится, пока рядом с тобой бард.",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 9,
                    SourceId = 1,
                },

                //Воин
                new Class
                {
                    Id = 3,
                    Name = "Воин",
                    Description = "Знаю я, что ты думаешь: Родольф, сукин ты карлик, ты морды чистил две войны подряд — небось ты воин, солдат до мозга костей! И ой как ошибаешься. " +
                    "Да, я сражался в двух войнах: на первой служил разведчиком, на второй — арбалетчиком. Воевал в Соддене и у Бренны. Да только не так хорошо я дрался, как настоящие воины, " +
                    "которые всю жизнь этим занимаются. Я сражался, потому что страну свою люблю. Но любовь к стране и арбалет в руках не делают из тебя солдата. Настоящие воины — это люди вроде " +
                    "Вернона Роше и Яна Наталиса. Вояк лучше них я за всю жизнь не встречал. Дело своё они знают от и до, поскольку настоящие солдаты войной живут. А когда войны нету, они служат " +
                    "телохранителями и наёмниками. Стоит им на поле боя за оружие взяться, как там сущий ад начинается: воины в латах несутся на врага, машут мечом размером с себя и рубят " +
                    "кавалеристам головы на раз-два. Отправь такого в болота Понтара — и вот тебе самый настоящий хищник, выискивающий эльфов меж деревьев, ставящий ловушки под каждым " +
                    "кустом и с лёгкостью читающий любое действие противника, словно долбаную книгу. А дашь ему арбалет, так он чёрного уложит одним выстрелом в глаз со ста двадцати ярдов. " +
                    "Воякой-то я был, но воином — никогда. И поверь, меня это вполне устраивает.",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 2,
                    SourceId = 1,
                },

                //Жрец
                new Class
                {
                    Id = 4,
                    Name = "Жрец",
                    Description = "Как-то раз в Маг Турге повстречал я жреца необычайно широких взглядов. Он сказал мне: «Каждый своим путём к богам приходит». Думаю, такое описание подходит " +
                    "для всех жрецов. Есть на Юге культисты, что верят в великий катаклизм и новое солнце; на Севере есть фанатики, поклоняющиеся огню; и есть сумасшедшие, что славят богиню " +
                    "жизни и плодородия. Короче говоря, каждый в чём-то находит божественное. Тяжело доказать, что твой бог единственный, так что церквей повсюду полно. Некоторые жрецы обладают " +
                    "магическим даром, да только чёрта с два они признают, чторавны магам-безбожникам. И неважно, что сходств выше крыши, ведь жрецам магию даруют божества, которым они молятся, " +
                    "а значит, эта магия богоугодна. Такие жрецы, обычно опекают города, заботятся о духе земли и следят, чтобы живущие на этой земле люди были благочестивы и поклонялись их богу. " +
                    "Есть ещё друиды. В целомребята они добрые, если только ты не браконьер или ещё какой-нибудь поганец. Они живут в единении с природой и жизнь кладут на то, чтобы сохранять " +
                    "равновесие. Лично я ни разу не встречал друида, но рассказы о них слыхал. Сейчас друидов всё меньше. Судя по слухам, большинство живёт на островах Скеллиге. Кроме них, " +
                    "бывают ещёрадикалы и настоящие культисты. Вот этих стоит опасаться: никогда не знаешь, что сотворит какой-нибудь безумец, ведомый голосом своего божества. Хуже только " +
                    "сумасшедший жрец, что велит пастве исполнять волю богов — нечто подобное сейчас в Редании можно видеть. Страна сошла сума с тех самых пор, как там обосновался культ Вечного Огня. ",
                    DefaultMagicAbilities = "",
                    Energy = 2,
                    SkillsTreeId = 3,
                    SourceId = 1,
                },

                //Маг
                new Class
                {
                    Id = 5,
                    Name = "Маг",
                    Description = "Маги, колдуны, ведьмы... по-разному их кличут. Лично я называю их проблемой, но это моё скромное мнение. Маг — это тот, кто способен использовать " +
                    "природную магию стихий, которую люди зовут Изначальным Хаосом. Учатся маги в расфуфыренных школах вроде Бан Арда и Аретузы на Севере и Гвейсон Хайль на Юге. " +
                    "Имел я, кхм, дело с одной чародейкой пару лун тому назад, так она меня просветила в перерывах между перепихонами. Сказала, мол, маги — это мощные проводники " +
                    "магической энергии, и пока они не используют её слишком много, они, считай, что угодно могут с этой энергией творить. А если у мага при себе фокусирующий предмет " +
                    "вроде жезла, посоха или амулета, то он может ещё больше магической энергии заграбастать. И что, мол, в академиях магов учат думать наперёд, использовать магию для " +
                    "развития науки и улучшения жизни простого люда. Весьма позитивный взгляд на вещи. Что ж, маги нехило так жизнь улучшили, и без них, наверно, не было бы науки в том " +
                    "виде, в каком мы её сейчас знаем. Долгое время при каждом королевском дворе было по магу-советнику, благодаря чему маги стали, считай, одними из самых могущественных " +
                    "и влиятельных существ в мире. Многие из них и по сей день используют все те приёмчики, которым при дворе научились. И как минимум поэтому они опасны. Но теперь, " +
                    "после той заварушки с Ложей, магам никто не доверяет, как на Севере, так и на Юге. Моя подружка-чародейка всё потеряла из-за этих потаскух. На Севере она и в город " +
                    "теперь войти не может, не скрываясь",
                    DefaultMagicAbilities = "",
                    Energy = 5,
                    SkillsTreeId = 4,
                    SourceId = 1,
                },

                //Медик
                new Class
                {
                    Id = 6,
                    Name = "Медик",
                    Description = "Все, кто хоть сколько-то в армии служил, знают, как полезен бывает хороший медик. Скажу тебе так, друже: если бы у меня сейчас все залеченные " +
                    "медиками раны открылись, я бы не на краснолюда был похож, а на гуля. Странствовал я както с медиком из Нильфгаарда. Один из немногих чёрных, кого я терпел. " +
                    "Клянусь, этот сукин сын чуть ли не чудеса творил, когда в настроении был, — такому любой хороший медик обучен. Такие берут и вырывают парней из лап смерти. " +
                    "Они используют всё, чему научились в этих своих академиях, чтобы понять, чем ты болен, что у тебя за рана, да как ещё тебя при этом на ноги поставить. " +
                    "Хороший медик знает и всякие целебные отвары. Я вершки да корешки продаю едва ли не всем встречным грамотеям, но вот медики все эти растения используют " +
                    "поболе остальных — варят из них припарки, эликсиры, да в порошки растирают. И всё это, чтобы остановить кровотечение, унять тошноту, с болезнью справиться. " +
                    "Как я слыхал, самые лучшие травники сами лекарства мешают. Самоубийство чистой воды, как по мне, но я тут не знаток — я не умею намешать кучу разной зелени, " +
                    "чтобы она при этом пользу приносила. Впрочем, если не лекарство намешаешь, то неплохой яд. Ведь медик знает не только как лечить, но и как калечить: где надо " +
                    "резать, как раны сделать хуже и трудней для излечения. Они умеют такие вещи, которые я лично никогда бы не стал использовать другим во вред. Но, если так подумать, " +
                    "в этом мире даже медику приходится порой за свою жизнь драться.",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 5,
                    SourceId = 1,
                },

                //Преступник
                new Class
                {
                    Id = 7,
                    Name = "Преступник",
                    Description = "Преступник — термин весьма расплывчатый. Сюда относятся и профессиональные взломщики, и наёмные убийцы. Всех этих ребят объединяет одно: если их " +
                    "сцапают, им конец. Врать не стану, я имел дело с преступниками, считай, всюду, от Ковира до Геммеры. Контрабандисты, убийцы и воры всехмастей. Иногда они вполне " +
                    "себе неплохие ребята. С ворами дела вести просто, и порой их навыки действительно могут пригодиться. Взломщики, щипачи и домушники — вот кого стоит искать, если " +
                    "хочешь вломиться в чужой дом. Если надо проникнуть через запертые ворота или заполучить что-то без шума и грязи, обращайся к вору. Наёмные убийцы тоже неплохи, " +
                    "если только их не наняли по твою душу. В своё время я знавал парочку, и у каждого были свои моральные принципы, побольше даже, чем у большинства воров. У них на " +
                    "всё свои правила: кого убивать, а кого нет, что слишком рискованно, что по дешёвке сделать, а за что содрать с клиента последнюю шкуру. Но, так или иначе, " +
                    "зарабатывают они убийством и делают это хорошо. Встречал я одну эльфку, так у неё при себе было шестнадцать ножей. Чёрт знает, где она их все прятала. Стоит " +
                    "упомянуть и профессиональных преступников — вроде лидеров банд, чья профессия — организовывать и совершать преступления. Вот их реально следует опасаться. " +
                    "Среди этих ребят полно дураков-филантропов, которые грабят богачей и раздают деньги своим людям, и хладнокровных садюг-убийц. Они всегда действуют только себе на " +
                    "пользу и выбирают тот путь, который принесёт им больше выгоды. Когда с ними общаешься, невольно ощущаешь себя пешкой в большой игре. ",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 6,
                    SourceId = 1,
                },

                //Ремесленник
                new Class
                {
                    Id = 8,
                    Name = "Ремесленник",
                    Description = "Ремесленник — пожалуй, самаяраспространённая профессия после крестьянина. Ну, на самом деле шлюх тоже немало, но ты меня понял. Ремесленники, или мастера, " +
                    "занимаются всем и вся: и обувь делают, и зелья варят. Но если ремесленник отправляется в какое-нибудь опасное приключение, то это, скорее всего, кузнец или алхимик. " +
                    "Алхимик в любом походе полезен. Наука-то древняя, и хороший алхимик способен много полезностей сделать: кислоту, горючую жидкость, бомбы и всякое такое. Конечно, если у " +
                    "тебя есть нужные инструменты, ты и сам можешь что-нибудь полезное сварганить, но только профессиональный алхимик сделает это идеально. Может, я и предвзято говорю, " +
                    "но как по мне, кузнецы — самые уважаемые ремесленники. Они часами торчат у пылающего горна, работают с самыми твёрдыми материалами и при этом действуют точно и аккуратно. " +
                    "Хороший кузнец способен выковать настолько острый меч, что тот пробьёт доспех самого большого и крепкого врага, или же смастерить броню, которая выдержит удар чёртова тролля. " +
                    "Я и сам какое-то время поработал кузнецом в Ангрене до Второй войны, и честно скажу: работа не из лёгких. Когда я в армии служил и сражался с чёрными, меня с ребятами " +
                    "послали в болота Соддена, отбиваться от отряда нильфов. Мы остановили их по другую сторону реки, но за целый день боя мой арбалет промок, и тетива растянулась. " +
                    "Прямо там, посреди заварушки, пока остальные обстрел вели и сражались по колено в грязи, мастер по имени Клаус мне новую тетиву натянул, и я вновь бросился в бой. " +
                    "Я этому парню жизнью обязан.",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 7,
                    SourceId = 1,
                },

                //Торговец
                new Class
                {
                    Id = 9,
                    Name = "Торговец",
                    Description = "Посмотри вокруг. Пошуруй, что у тебя в заплечном мешке, в поясной сумке да в перемётной суме. Наверняка большую часть скарба ты у торговца прикупил. " +
                    "Ну как, прав я?Дружище, народ не слишком ценит торговцев и попросту не понимает, насколько мы важны. Торговцы привозят то, что людям нужно. Вот нужен мужику из " +
                    "Метинны меч из Редании. Да, он может рискнуть своей шкурой и сам за ним отправиться, а может найти торговца. Ты навряд ли хоть раз в жизни побываешь в Зеррикании, " +
                    "но пока оттуда раз в месяц приходят корабли, ты получишь и кость, и экзотические сабли, и прочую дребедень. У хорошего торговца связи есть по всему миру. " +
                    "Мы знаем, что продать, где это достать и как заплатить подешевле. Ежели тебе нужна какая информация или услуга — найди торговца. Уменя друзья почти в каждом " +
                    "городе, и за пару монет я могу разузнать почти о чём угодно. Кстати, о монетах. Ах, монетки! Если ты не полный дурак, то наваришь прибыль на чём угодно. " +
                    "Прибыль — это деньги, а деньги — это власть. Надо пробраться на пышный приём? Это куда легче сделать, если ты разодет по последней моде и позвякиваешь кошелём " +
                    "размером с краснолюдский кулак. Скажешь, я не хочу руки марать? Всегда есть тот, кто готов за тебя выполнить грязную работёнку за справедливую цену. " +
                    "Сама жизнь торговца зависит от его связей, знаний и товара. Если с этими тремя вещами у тебя всё в порядке, ты точно озолотишься. " +
                    "Только послушай моего совета: под сиденьем повозки держи арбалет. Так, на всякий случай. Вдруг попадутся клиенты, не желающие платить. ",
                    DefaultMagicAbilities = "",
                    Energy = 0,
                    SkillsTreeId = 8,
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
                new Attack
                {
                    Id = 4,
                    Name = "Укус",
                    Description = "",
                    AttackSpeed = 1,
                    AttackType = (int)AttackType.Piercing,
                    BaseAttack = 22,
                    Damage = "5к6",
                    Distance = 0,
                    Reliability = 10,
                    SourceId = 1,
                },
                new Attack
                {
                    Id = 5,
                    Name = "Удар когтями",
                    Description = "",
                    AttackSpeed = 2,
                    AttackType = (int)AttackType.PiercingAndSlashing,
                    BaseAttack = 22,
                    Damage = "4к6",
                    Distance = 0,
                    Reliability = 15,
                    SourceId = 1,
                },
            };

            builder.Entity<Attack>().HasData(attackList);

            var attackEffectList = new AttackEffectList[]
            {
                new AttackEffectList
                {
                    Id = 1,
                    AttackId = 3,
                    EffectId = 50,
                    ChancePercent = 0,
                    Damage = "50м",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 2,
                    AttackId = 3,
                    EffectId = 21,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 3,
                    AttackId = 3,
                    EffectId = 51,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },

                new AttackEffectList
                {
                    Id = 4,
                    AttackId = 4,
                    EffectId = 17,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 5,
                    AttackId = 4,
                    EffectId = 2,
                    ChancePercent = 75,
                    Damage = "",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 6,
                    AttackId = 5,
                    EffectId = 3,
                    ChancePercent = 0,
                    Damage = "",
                    IsDealDamage = false,
                },
                new AttackEffectList
                {
                    Id = 7,
                    AttackId = 5,
                    EffectId = 14,
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

                new StatsList
                {
                    Id = 2,

                    IntellectId = 1,
                    ReactionId = 2,
                    DexterityId = 3,
                    ConstitutionId = 4,
                    SpeedId = 5,
                    EmpathyId = 6,
                    CraftsmanshipId = 7,
                    WillpowerId = 8,
                    LuckId = 9,

                    IntellectValue = 6,
                    ReactionValue = 13,
                    DexterityValue = 13,
                    ConstitutionValue = 10,
                    SpeedValue = 11,
                    EmpathyValue = 7,
                    CraftsmanshipValue = 5,
                    WillpowerValue = 7,
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
                    ResilienceValue = 8,
                    RunningValue = 33,
                    JumpingValue = 6,
                    EnduranceValue = 50,
                    WeightValue = 100,
                    RestValue = 8,
                    HealthPointsValue = 80,
                    HandStrikeValue = 4,
                    KickValue = 8,
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

                new SkillsList
                {
                    Id = 2,

                    #region Инт ID
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
                    #endregion

                    AttentionValue = 10,
                    SurvivalValue = 9,
                    DeductionValue = 0,
                    MonsterologyValue = 0,
                    EducationValue = 0,
                    CityOrientationValue = 0,
                    KnowledgeTransferValue = 0,
                    TacticsValue = 0,
                    TradingValue = 0,
                    EtiquetteValue = 7,
                    LanguageGeneralValue = 0,
                    LanguageHighValue = 0,
                    LanguageDwarfValue = 0,

                    #region Тело ID
                    StrengthId = 27,
                    EnduranceId = 28,
                    #endregion

                    StrengthValue = 5,
                    EnduranceValue = 5,

                    #region Реакция ID
                    MeleeCombatId = 14,
                    WrestlingId = 15,
                    RidingId = 16,
                    PoleWeaponMasteryId = 17,
                    LightBladeMasteryId = 18,
                    SwordsmanshipId = 19,
                    SeamanshipId = 20,
                    EvasionId = 21,
                    #endregion

                    MeleeCombatValue = 9,
                    WrestlingValue = 9,
                    RidingValue = 0,
                    PoleWeaponMasteryValue = 0,
                    LightBladeMasteryValue = 0,
                    SwordsmanshipValue = 0,
                    SeamanshipValue = 0,
                    EvasionValue = 9,

                    #region Лов ID
                    AthleticsId = 22,
                    ManualDexterityId = 23,
                    StealthId = 24,
                    CrossbowMasteryId = 25,
                    ArcheryId = 26,
                    #endregion

                    AthleticsValue = 10,
                    ManualDexterityValue = 0,
                    StealthValue = 4,
                    CrossbowMasteryValue = 0,
                    ArcheryValue = 0,

                    #region Эмпатия ID
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
                    #endregion

                    GamblingValue = 0,
                    AppearanceValue = 0,
                    PublicSpeakingValue = 0,
                    ArtistryValue = 0,
                    LeadershipValue = 0,
                    DeceptionValue = 0,
                    UnderstandingPeopleValue = 0,
                    SeductionValue = 10,
                    PersuasionValue = 9,
                    CharismaValue = 10,

                    #region Ремесло ID
                    AlchemyId = 39,
                    LockpickingId = 40,
                    TrapKnowledgeId = 41,
                    ManufacturingId = 42,
                    CamouflageId = 43,
                    FirstAidId = 44,
                    ForgeryId = 45,
                    #endregion

                    AlchemyValue = 0,
                    LockpickingValue = 0,
                    TrapKnowledgeValue = 0,
                    ManufacturingValue = 0,
                    CamouflageValue = 0,
                    FirstAidValue = 0,
                    ForgeryValue = 0,

                    #region Воля ID
                    IntimidationId = 46,
                    CorruptionId = 47,
                    RitualsId = 48,
                    MagicResistanceId = 49,
                    PersuasionResistanceId = 50,
                    SpellcastingId = 51,
                    CourageId = 52,
                    #endregion

                    IntimidationValue = 9,
                    CorruptionValue = 0,
                    RitualsValue = 0,
                    MagicResistanceValue = 10,
                    PersuasionResistanceValue = 9,
                    SpellcastingValue = 0,
                    CourageValue = 9,
                },
            });

            var creatureRewardList = new Reward[]
            {
                new Reward
                {
                    Id = 1,
                    Amount = "3к10",
                    ItemBaseId = 90,
                },
                new Reward
                {
                    Id = 2,
                    Amount = "1к6/3",
                    ItemBaseId = 92,
                },
                new Reward
                {
                    Id = 3,
                    Amount = "1к6",
                    ItemBaseId = 93,
                },
                new Reward
                {
                    Id = 4,
                    Amount = "2к6",
                    ItemBaseId = 94,
                },
                new Reward
                {
                    Id = 5,
                    Amount = "1к6/2",
                    ItemBaseId = 95,
                },
                new Reward
                {
                    Id = 6,
                    Amount = "1к6",
                    ItemBaseId = 96,
                },
                //92-95 + 96
            };

            builder.Entity<Mutagen>().HasData(new Mutagen[]
            {
                new Mutagen {Id = 1, Complexity = 20, Effect = "+1 Воля", Mutation = "переплетение темно-красных вен под кожей", Name = "Мутаген Альпа", SourceId = 1,},
            });

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
                    " скорее всего, сдадутся, если вы нанесёте им достаточно урона. Однако некоторые разбойники, странствующие крепко сбитыми группами," +
                    " могут начать сражаться яростнее, если убить их товарищей. На истерзанном войной Севере стоит быть осторожнее: нехватка пищи заставила" +
                    " некоторых разбойников стать каннибалами. Каннибалы зачастую сходят с ума и нападают с бешеной яростью — они не сдаются, даже стоя" +
                    " одной ногой в могиле. Если не хотите драться, будьте внимательны на дороге.",
                    EvasionBase = 10,
                    GroupSize = "Банда из 3-15 разбойников",
                    HabitatPlace = "Часто рядом с городами и на трактах",
                    //Resistances = "",
                    //Immunities = "",
                    //Vulnerabilities = "",
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
                },
                new Creature
                {
                    Id = 2,
                    Name = "Альп",
                    Description = "",
                    AdditionalInformation = "",
                    //Abilities = abilityList.ToList(),
                    Armor = 10,
                    AthleticsBase = 23,
                    //Attacks = attackList.ToList(),
                    BlockBase = 22,
                    EvasionBase = 22,
                    SpellResistBase = 17,
                    Complexity = (int)Complexity.HardDifficult,
                    //CreatureRewardList = creatureRewardList.ToList(),
                    EducationSkill = 15,
                    MonsterLoreSkill = 16,
                    SuperstitionsInformation = "Мало какой монстр вдохновляет так много историй, как альп. Эта суккубо-дьяволица может превратиться в чёрную псину или ядовитую жабу. " +
                    "Говорят, что эти распутные бестии любят соблазнять красивых молодых парне. Так же говорят, что их способности очаровывать могут сравниться только с их ненавистью " +
                    "к девственницам. Они двигаются без единого звука и даже ветер не может их коснуться, как и солнечный свет, который сжигает их кожу, даже не успев до неё дотронуться. " +
                    "Однако они до жути боятся кошаков.",
                    MonsterLoreInformation = "Альпы – это вампиры внешне напоминающие брукс. Некоторые называют их фантомами и не попросту, ибо как фантомы они преследуют и мучают " +
                    "люд под женским обликом, хотя также могут прикинуться и животным. Альпы чаще всего встречаются рядом с деревнями, нападая по ночам и наиболее активны в полнолуние. " +
                    "Слюна альпа – мощный анестетик и, будучи скормленной спящему, вызовет у того жуткие кошмары. Некоторые предполагают, что именно альпы стали причиной слухов о людях, " +
                    "найденных на утро белее первого снега, без капли крови в венах. В бою альпы демонстрируют сверхъестественную скорость и необычайную (даже по вампирским меркам) выносливость. " +
                    "Решившийся сразиться с альпом должен тщательно вымерять свои удары, ибо альпам нет равных в изворотливости. Рекомендуется использовать знак Ирден, чтобы замедлить Альпа и " +
                    "ослабить его защиту. Хорошим решением будет выпить эликсир Чёрная Кровь, так как альпы высасывают кровь из своих жертв, чтобы лишить их сил и восполнить собственные. " +
                    "Так же может пригодиться Иволга, которая предоставит защиту от усыпляющей слюны альпа. В отличие от брукс, альпы не могут становиться невидимыми, но уподобляясь своим ещё " +
                    "более жутким сородичам, они могут испускать звуковую волну, обезвреживающую жертву. Их сильная сторона — это их ловкость и прыжки, кои они совершают с невероятной лёгкостью, и " +
                    "их можно сравнить с полетом. Будучи в человеческой форме, они легко замешиваются в местную общину. А там, где человек будет выглядеть слишком подозрительно, " +
                    "они прикидываются зверьём.",
                    GroupSize = "Одиночка",
                    HabitatPlace = "Заброшенные строения, подвалы или пещеры рядом с людскими поселениями",
                    //Resistances = "",
                    //Immunities = "",
                    //Vulnerabilities = "",
                    Height = 175,
                    Intellect = "Разумный",
                    MoneyReward = 2000,
                    RaceId = 16,
                    Regeneration = 0,
                    SkillsListId = 2,
                    SourceId = 1,
                    StatsListId = 2,
                    Weight = 90,
                    
                    MutagenId = 1,
                },
            };

            builder.Entity<Creature>().HasData(creatureList);

            builder.Entity<CreatureAbility>().HasData(new CreatureAbility[]
            {
                new CreatureAbility
                {
                    Id = 1,
                    AbilityId = 14,
                    CreatureId = 2,
                },
                new CreatureAbility
                {
                    Id = 2,
                    AbilityId = 15,
                    CreatureId = 2,
                },
                new CreatureAbility
                {
                    Id = 3,
                    AbilityId = 16,
                    CreatureId = 2,
                },
                new CreatureAbility
                {
                    Id = 4,
                    AbilityId = 17,
                    CreatureId = 2,
                },
                new CreatureAbility
                {
                    Id = 5,
                    AbilityId = 18,
                    CreatureId = 2,
                },
                //14-18
                
            });

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
                new CreatureAttack
                {
                    Id = 4,
                    AttackId = 4,
                    CreatureId = 2,
                },
                new CreatureAttack
                {
                    Id = 5,
                    AttackId = 5,
                    CreatureId = 2,
                },
            });

            builder.Entity<CreatureReward>().HasData(new CreatureReward[]
            {
                new CreatureReward
                {
                    Id = 1,
                    CreatureId = 1,
                    //RewardId = 1,
                    ItemBaseId = 90,
                },
                new CreatureReward
                {
                    Id = 2,
                    CreatureId = 2,
                    ItemBaseId = 92,
                    Amount = "1к6/2"
                },
                new CreatureReward
                {
                    Id = 3,
                    CreatureId = 2,
                    ItemBaseId = 93,
                    Amount = "1к6"
                },
                new CreatureReward
                {
                    Id = 4,
                    CreatureId = 2,
                    ItemBaseId = 94,
                    Amount = "2к6"
                },
                new CreatureReward
                {
                    Id = 5,
                    CreatureId = 2,
                    ItemBaseId = 95,
                    Amount = "1к6/2"
                },
                new CreatureReward
                {
                    Id = 6,
                    CreatureId = 2,
                    ItemBaseId = 96,
                    Amount = "1к6"
                },
            });

            builder.Entity<CreatureEffect>().HasData(new CreatureEffect[]
            {
                new CreatureEffect {Id = 1, CreatureId = 1, Description = "Бей его", Name = "Урон", Type = (int)CreatureEffectType.Vulnerability},

                new CreatureEffect {Id = 2, CreatureId = 2, EffectId = 59, Description = "", Name = "", Type = (int)CreatureEffectType.Passive},    //ДОБАВИТЬ В ЧУВСТВА НА ФРОНТЕ
                new CreatureEffect {Id = 3, CreatureId = 2, EffectId = 40, Description = "", Name = "Кровотечение", Type = (int)CreatureEffectType.Resistance},
                new CreatureEffect {Id = 4, CreatureId = 2, EffectId = 42, Description = "", Name = "Дезориентирование", Type = (int)CreatureEffectType.Resistance},
                new CreatureEffect {Id = 5, CreatureId = 2, Description = "", Name = "Магическое обнаружение", Type = (int)CreatureEffectType.Immunity},
                new CreatureEffect {Id = 6, CreatureId = 2, Description = "", Name = "Масло против вампиров", Type = (int)CreatureEffectType.Vulnerability},
                new CreatureEffect {Id = 7, CreatureId = 2, Description = "", Name = "Эликсир Черная кровь", Type = (int)CreatureEffectType.Vulnerability},
                new CreatureEffect {Id = 8, CreatureId = 2, Description = "", Name = "Бомба лунная пыль", Type = (int)CreatureEffectType.Vulnerability},
                new CreatureEffect {Id = 9, CreatureId = 2, Description = "", Name = "Огонь", Type = (int)CreatureEffectType.Vulnerability},
            });

            #endregion

            #region #Spells Data

            builder.Entity<Spell>().HasData(new Spell[]
            {
                new Spell
                {
                    Id = 1,
                    Name = "Слепящая пыль",
                    Description = "Слепящая пыль позволяет направить в глаза цели горсть магической пыли, которая ослепит её на время действия заклинания.",
                    CheckDC = 0,
                    ConcentrationEnduranceCost = 0,
                    DangerInfo = "",
                    Distance = 4,
                    Duration = "1к10 раундов",
                    EnduranceCost = 3,
                    IsConcentration = false,
                    IsDruidSpell = false,
                    IsPriestSpell = false,
                    PreparationTime = 0,
                    SourceId = 1,
                    SourceType = (int)SpellSource.Mixed,
                    SourceTypeDescription = "",
                    SpellLevel = 1,
                    //SpellSkillProtectionList = spellSkillProtectionList.ToList(),
                    SpellType = (int)SpellType.Spell,
                    SpellTypeDescription = "",
                    WithdrawalCondition = "",
                },
                new Spell
                {
                    Id = 2,
                    Name = "Кипящая кровь",
                    Description = "Кипящая кровь заставляет животное или неразумное чудовище в пределах дистанции заклинания разозлиться на цель." +
                    " Это существо будет пытаться напасть на цель, пока действие заклинания не закончится.",
                    CheckDC = 0,
                    ConcentrationEnduranceCost = 0,
                    DangerInfo = "",
                    Distance = 8,
                    Duration = "1к10 раундов",
                    EnduranceCost = 3,
                    IsConcentration = false,
                    IsDruidSpell = false,
                    IsPriestSpell = true,
                    PreparationTime = 0,
                    SourceId = 1,
                    SourceType = (int)SpellSource.Mixed,
                    SourceTypeDescription = "",
                    SpellLevel = 1,
                    //SpellSkillProtectionList = spellSkillProtectionList.ToList(),
                    SpellType = (int)SpellType.Invocation,
                    SpellTypeDescription = "",
                    WithdrawalCondition = "",
                },
                new Spell
                {
                    Id = 3,
                    Name = "Квен",
                    Description = "Квен создаёт щит с 5 ПЗ за каждое очко Вын, потраченное на защиту." +
                    " Если вы не смогли (или не захотели) защититься от атаки или наносящего урон эффекта, урон сначала применяется к щиту Квен." +
                    " Смертельный и несмертельный урон одинаковым образом уменьшают ПЗ щита Квен." +
                    " Когда ПЗ щита снижаются до 0, оставшийся урон применяется к укрывшемуся за ним персонажу." +
                    " Чтобы повлиять на ваши ПЗ или Вын, урон должен сначала преодолеть ПБ и сопротивление урону, как при любой атаке." +
                    " Квен можно применять против любых заклинаний, которые поддаются блокированию, но против остальных заклинаний он бессилен." +
                    " Также Квен не действует на уже имеющийся урон от отравления, болезней или удушения от нехватки кислорода в воздухе." +
                    " Квен нельзя сотворить снова, пока действует предыдущий такой же знак.",
                    CheckDC = 0,
                    ConcentrationEnduranceCost = 0,
                    DangerInfo = "",
                    Distance = 0,
                    Duration = "10 раундов или пока не истрачен",
                    EnduranceCost = 1,
                    IsConcentration = false,
                    IsDruidSpell = false,
                    IsPriestSpell = false,
                    PreparationTime = 0,
                    SourceId = 1,
                    SourceType = (int)SpellSource.Earth,
                    SourceTypeDescription = "",
                    SpellLevel = 1,
                    //SpellSkillProtectionList = spellSkillProtectionList.ToList(),
                    SpellType = (int)SpellType.Sign,
                    SpellTypeDescription = "",
                    WithdrawalCondition = "",
                },
                new Spell
                {
                    Id = 4,
                    Name = "Пиромантия",
                    Description = "Пиромантия позволяет заглянуть в пламя и увидеть происходящие события." +
                    " Пиромантия несколько опаснее Гидромантии — её тяжелее поддерживать, к тому же огонь не позволяет смотреть в прошлое." +
                    " Зато разглядеть события, происходящие в данный момент, куда проще. Как и в случае с Гидромантией, маг,за которым наблюдает заклинатель," +
                    " может почувствовать слежку, совершив проверку Магических познаний со СЛ, равной результату проверки Проведения ритуалов",
                    CheckDC = 15,
                    ConcentrationEnduranceCost = 5,
                    DangerInfo = "",
                    Distance = 0,
                    Duration = "активный",
                    EnduranceCost = 4,
                    IsConcentration = true,
                    IsDruidSpell = false,
                    IsPriestSpell = false,
                    PreparationTime = 0,
                    SourceId = 1,
                    SourceType = (int)SpellSource.Mixed,
                    SourceTypeDescription = "",
                    SpellLevel = 1,
                    //SpellSkillProtectionList = spellSkillProtectionList.ToList(),
                    SpellType = (int)SpellType.Ritual,
                    SpellTypeDescription = "",
                    WithdrawalCondition = "",

                },
                new Spell
                {
                    Id = 5,
                    Name = "Вечный зуд",
                    Description = "На гениталиях жертвы высыпают воспалённые зудящие прыщи. Вечный зуд не наносит урона, но причиняет жертве постоянный дискомфорт," +
                    " что даёт штраф -1 к любым действиям. Также жертва получает штраф -5 к Соблазнению, когда доходит до раздевания.",
                    CheckDC = 0,
                    ConcentrationEnduranceCost = 0,
                    DangerInfo = "",
                    Distance = 0,
                    Duration = "",
                    EnduranceCost = 5,
                    IsConcentration = false,
                    IsDruidSpell = false,
                    IsPriestSpell = false,
                    PreparationTime = 0,
                    SourceId = 1,
                    SourceType = (int)SpellSource.Mixed,
                    SourceTypeDescription = "",
                    SpellLevel = 1,
                    //SpellSkillProtectionList = spellSkillProtectionList.ToList(),
                    SpellType = (int)SpellType.Hex,
                    SpellTypeDescription = "",
                    WithdrawalCondition = "Жертва должна взять единицу склеродерма, немного собачьей петрушки и переступня," +
                    " затем развести костёр и связать травы в пучок. Как только всё будет готово," +
                    " травы нужно поджечь и пеплом посыпать пострадавший от порчи участок тела, произнося при этом магические слова",
                },
            });

            var spellSkillProtectionList = new SpellSkillProtectionList[]
            {
                new SpellSkillProtectionList
                {
                    Id = 1,
                    SpellId = 1,
                    SkillId = 14,
                },
                new SpellSkillProtectionList
                {
                    Id = 2,
                    SpellId = 1,
                    SkillId = 17,
                },
                new SpellSkillProtectionList
                {
                    Id = 3,
                    SpellId = 1,
                    SkillId = 18,
                },
                new SpellSkillProtectionList
                {
                    Id = 4,
                    SpellId = 1,
                    SkillId = 19,
                },
                new SpellSkillProtectionList
                {
                    Id = 5,
                    SpellId = 1,
                    SkillId = 21,
                },
                new SpellSkillProtectionList
                {
                    Id = 6,
                    SpellId = 2,
                    MoreInfo = "Воля существа x3"
                },
            };

            builder.Entity<SpellSkillProtectionList>().HasData(spellSkillProtectionList);

            var spellComponentList = new SpellComponentList[]
            {
                new SpellComponentList
                {
                    Id = 1,
                    SpellId = 4,
                    ComponentId = 15,
                    Amount = 2
                }
            };

            builder.Entity<SpellComponentList>().HasData(spellComponentList);

            #endregion
        }
    }
}
