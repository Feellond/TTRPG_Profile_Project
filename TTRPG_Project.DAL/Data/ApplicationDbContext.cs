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
        public DbSet<CreatureSpellsList> CreatureSpellsList { get; set; }
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
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
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

        public void CreateDefaultData(ModelBuilder builder)
        {

        }
    }
}
