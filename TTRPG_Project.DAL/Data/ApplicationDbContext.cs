using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
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
        public DbSet<FormulaComponentList> FormulaComponentList { get; set; }
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

            CreateDefaultData(builder);
            base.OnModelCreating(builder);
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
                new Stat{Id = 1, Name = "Интеллект", Description = "", SourceId = 1},
                new Stat{Id = 2, Name = "Реакция", Description = "", SourceId = 1},
                new Stat{Id = 3, Name = "Ловкость", Description = "", SourceId = 1},
                new Stat{Id = 4, Name = "Телосложение", Description = "", SourceId = 1},
                new Stat{Id = 5, Name = "Скорость", Description = "", SourceId = 1},
                new Stat{Id = 6, Name = "Эмпатия", Description = "", SourceId = 1},
                new Stat{Id = 7, Name = "Ремесло", Description = "", SourceId = 1},
                new Stat{Id = 8, Name = "Воля", Description = "", SourceId = 1},
                new Stat{Id = 9, Name = "Удача", Description = "", SourceId = 1},
                new Stat{Id = 10, Name = "Энергия", Description = "", SourceId = 1},
                new Stat{Id = 11, Name = "Устойчивость", Description = "", SourceId = 1},
                new Stat{Id = 12, Name = "Бег", Description = "", SourceId = 1},
                new Stat{Id = 13, Name = "Прыжок", Description = "", SourceId = 1},
                new Stat{Id = 14, Name = "Пункты Здоровья", Description = "", SourceId = 1},
                new Stat{Id = 15, Name = "Выносливость", Description = "", SourceId = 1},
                new Stat{Id = 16, Name = "Переносимый вес", Description = "", SourceId = 1},
                new Stat{Id = 17, Name = "Отдых", Description = "", SourceId = 1},
                new Stat{Id = 18, Name = "Удар рукой", Description = "", SourceId = 1},
                new Stat{Id = 19, Name = "Удар ногой", Description = "", SourceId = 1},
            });

            builder.Entity<Skill>().HasData(new Skill[]{
                    //Навыки Интеллекта
                    new Skill{Id = 1, StatId = 1, Name = "Внимание", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 2, StatId = 1, Name = "Выживание в дикой природе", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 3, StatId = 1, Name = "Дедукция", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 4, StatId = 1, Name = "Монстрология", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 5, StatId = 1, Name = "Образование", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 6, StatId = 1, Name = "Ориентирование в городе", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 7, StatId = 1, Name = "Передача знаний", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 8, StatId = 1, Name = "Тактика", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 9, StatId = 1, Name = "Торговля", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 10, StatId = 1, Name = "Этикет", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 11, StatId = 1, Name = "Язык всеобщий", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 12, StatId = 1, Name = "Язык Старшей Речи", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 13, StatId = 1, Name = "Язык краснолюдов", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},

                    //Навыки Реакции
                    new Skill{Id = 14, StatId = 2, Name = "Ближний бой", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 15, StatId = 2, Name = "Борьба", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 16, StatId = 2, Name = "Верховая езда", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 17, StatId = 2, Name = "Владение древковым оружием", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 18, StatId = 2, Name = "Владение легкими клинками", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 19, StatId = 2, Name = "Владение мечом", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 20, StatId = 2, Name = "Мореходство", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 21, StatId = 2, Name = "Уклонение/Изворотливость", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Ловкости
                    new Skill{Id = 22, StatId = 3, Name = "Атлетика", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 23, StatId = 3, Name = "Ловкость рук", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 24, StatId = 3, Name = "Скрытность", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 25, StatId = 3, Name = "Стрельба из арбалета", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 26, StatId = 3, Name = "Стрельба из лука", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Телосложения
                    new Skill{Id = 27, StatId = 4, Name = "Сила", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 28, StatId = 4, Name = "Стойкость", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Эмпатии
                    new Skill{Id = 29, StatId = 6, Name = "Азартные игры", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 30, StatId = 6, Name = "Внешний вид", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 31, StatId = 6, Name = "Выступление", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 32, StatId = 6, Name = "Искусство", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 33, StatId = 6, Name = "Лидерство", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 34, StatId = 6, Name = "Обман", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 35, StatId = 6, Name = "Понимание людей", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 36, StatId = 6, Name = "Соблазнение", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 37, StatId = 6, Name = "Убеждение", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 38, StatId = 6, Name = "Харизма", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Ремесла
                    new Skill{Id = 39, StatId = 7, Name = "Алхимия", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 40, StatId = 7, Name = "Взлом замков", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 41, StatId = 7, Name = "Знание ловушек", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 42, StatId = 7, Name = "Изготовление", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 43, StatId = 7, Name = "Маскировка", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 44, StatId = 7, Name = "Первая помощь", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 45, StatId = 7, Name = "Подделывание", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Навыки Воли
                    new Skill{Id = 46, StatId = 8, Name = "Запугивание", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 47, StatId = 8, Name = "Наведение порчи", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 48, StatId = 8, Name = "Проведение ритуалов", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 49, StatId = 8, Name = "Сопротивление магии", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 50, StatId = 8, Name = "Сопротивление убеждению", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},
                    new Skill{Id = 51, StatId = 8, Name = "Сотворение заклинаний", Description = "", IsClassSkill = false, IsDifficult = true, SourceId = 1},
                    new Skill{Id = 52, StatId = 8, Name = "Храбрость", Description = "", IsClassSkill = false, IsDifficult = false, SourceId = 1},

                    //Далее должны идти классовые навыки
                });

            builder.Entity<Effect>().HasData(new Effect[]
            {
                //Эффекты предметов
                new Effect{Id = 1, Name = "Незаметное", Description = "", SourceId = 1},
                new Effect{Id = 2, Name = "Кровопускающее", Description = "", SourceId = 1},
                new Effect{Id = 3, Name = "Пробивающее броню", Description = "", SourceId = 1},
                new Effect{Id = 4, Name = "Дезориентирующее(1)", Description = "", SourceId = 1},
                new Effect{Id = 5, Name = "Дезориентирующее(2)", Description = "", SourceId = 1},
                new Effect{Id = 6, Name = "Дезориентирующее(3)", Description = "", SourceId = 1},
                new Effect{Id = 7, Name = "Метеоритное", Description = "", SourceId = 1},
                new Effect{Id = 8, Name = "Длинное", Description = "", SourceId = 1},
                new Effect{Id = 9, Name = "Фокусирующее(1)", Description = "", SourceId = 1},
                new Effect{Id = 10, Name = "Фокусирующее(2)", Description = "", SourceId = 1},
                new Effect{Id = 11, Name = "Фокусирующее(3)", Description = "", SourceId = 1},
                new Effect{Id = 12, Name = "Сокрушающая сила", Description = "", SourceId = 1},
                new Effect{Id = 13, Name = "Серебрянное", Description = "", SourceId = 1},
                new Effect{Id = 14, Name = "Сбалансированное(1)", Description = "", SourceId = 1},
                new Effect{Id = 15, Name = "Сбалансированное(2)", Description = "", SourceId = 1},
                new Effect{Id = 16, Name = "Сбалансированное(3)", Description = "", SourceId = 1},
                new Effect{Id = 17, Name = "Улучшенное пробивание брони", Description = "", SourceId = 1},
                new Effect{Id = 18, Name = "Захватное", Description = "", SourceId = 1},
                new Effect{Id = 19, Name = "Ловящий лезвия", Description = "", SourceId = 1},
                new Effect{Id = 20, Name = "Магические путы", Description = "", SourceId = 1},
                new Effect{Id = 21, Name = "Медленно перезаряжающееся", Description = "", SourceId = 1},
                new Effect{Id = 22, Name = "Несмертельное", Description = "", SourceId = 1},
                new Effect{Id = 23, Name = "Опутывающее", Description = "", SourceId = 1},
                new Effect{Id = 24, Name = "Парирующее", Description = "", SourceId = 1},
                new Effect{Id = 25, Name = "Разрушающее", Description = "", SourceId = 1},
                new Effect{Id = 26, Name = "Рукопашное", Description = "", SourceId = 1},
                new Effect{Id = 27, Name = "Расчетная перезарядка", Description = "", SourceId = 1},
                new Effect{Id = 28, Name = "Улучшенное фокусирующее", Description = "", SourceId = 1},
                new Effect{Id = 29, Name = "Устанавливаемое", Description = "", SourceId = 1},
                new Effect{Id = 30, Name = "Шприц", Description = "", SourceId = 1},
                new Effect{Id = 31, Name = "Закрывает все тело", Description = "", SourceId = 1},
                new Effect{Id = 32, Name = "Огнеупорный", Description = "", SourceId = 1},
                new Effect{Id = 33, Name = "Ограничение зрения", Description = "", SourceId = 1},
                new Effect{Id = 34, Name = "Полное укрытие", Description = "", SourceId = 1},
                new Effect{Id = 35, Name = "Сопротивление(Д)", Description = "", SourceId = 1},
                new Effect{Id = 36, Name = "Сопротивление(Р)", Description = "", SourceId = 1},
                new Effect{Id = 37, Name = "Сопротивление(К)", Description = "", SourceId = 1},
                new Effect{Id = 38, Name = "Сопротивление(С)", Description = "", SourceId = 1},

                //Эффекты в целом
                new Effect{Id = 39, Name = "Горение", Description = "", SourceId = 1},
                new Effect{Id = 40, Name = "Дезориентация", Description = "", SourceId = 1},
                new Effect{Id = 41, Name = "Отравление", Description = "", SourceId = 1},
                new Effect{Id = 42, Name = "Кровотечение", Description = "", SourceId = 1},
                new Effect{Id = 43, Name = "Замораживание", Description = "", SourceId = 1},
                new Effect{Id = 44, Name = "Ошеломление", Description = "", SourceId = 1},
                new Effect{Id = 45, Name = "Опьянение", Description = "", SourceId = 1},
                new Effect{Id = 46, Name = "Галлюцинации", Description = "", SourceId = 1},
                new Effect{Id = 47, Name = "Тошнота", Description = "", SourceId = 1},
                new Effect{Id = 48, Name = "Удушье", Description = "", SourceId = 1},
                new Effect{Id = 49, Name = "Слепота", Description = "", SourceId = 1},
            });
        }
    }
}
