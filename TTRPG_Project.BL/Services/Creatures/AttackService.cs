using AutoMapper;
using Azure;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Creatures.Responce;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Base;
using TTRPG_Project.DAL.Const;
using TTRPG_Project.DAL.Data;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;

namespace TTRPG_Project.BL.Services.Creatures
{
    public class AttackService : BaseService<Attack, int>
    {
        public AttackService(ApplicationDbContext dbContext) : base(dbContext) { }

        public async Task<AttackResponce> GetAllAsync()
        {
            var attacks = await _dbContext.Attacks.AsNoTracking()
                .Include(s => s.Source)
                .Include(e => e.AttackEffectList)
                    .ThenInclude(e => e.Effect)
                .ToListAsync();

            AttackResponce responce = new()
            {
                Count = attacks.Count(),
                Attacks = attacks,
            };

            return responce;
        }

        public async Task<AttackResponce> GetByIdAsync(int id)
        {
            var attack = await _dbContext.Attacks.AsNoTracking()
                .Where(x => x.Id == id)
                .Include(s => s.Source)
                .Include(e => e.AttackEffectList)
                    .ThenInclude(e => e.Effect)
                .FirstOrDefaultAsync();

            if (attack is null)
                throw new CustomException("Существа с таким id не существует");

            AttackResponce responce = new()
            {
                Count = 1,
                Attacks = new List<Attack>() { attack },
            };

            return responce;
        }

        public async Task<bool> CreateAsync(AttackRequest request)
        {
            Attack attack = new()
            {
                AttackSpeed = request.AttackSpeed,
                AttackType = request.AttackType,
                BaseAttack = request.BaseAttack,
                CreatureId = request.CreatureId ?? request.Creature?.Id,
                Damage = request.Damage,
                Description = request.Description,
                Distance = request.Distance,
                Name = request.Name,
                Reliability = request.Reliability,
                SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2,
                AttackEffectList = request.AttackEffectList.Select(dto => new AttackEffectList
                {
                    ChancePercent = dto.ChancePercent,
                    Damage = dto.Damage,
                    EffectId = dto.EffectId,
                    IsDealDamage = dto.IsDealDamage,
                }).ToList(),
            };

            await _dbContext.Attacks.AddAsync(attack);
            return await SaveAsync();
        }

        public async Task<bool> UpdateAsync(AttackRequest request)
        {
            var attack = await _dbContext.Attacks.Where(x => x.Id == request.Id).FirstOrDefaultAsync();
            if (attack is null)
                throw new CustomException("Существо не найдено!");

            attack.AttackSpeed = request.AttackSpeed;
            attack.AttackType = request.AttackType;
            attack.BaseAttack = request.BaseAttack;
            attack.CreatureId = request.CreatureId ?? request.Creature?.Id;
            attack.Damage = request.Damage;
            attack.Description = request.Description;
            attack.Distance = request.Distance;
            attack.Name = request.Name;
            attack.Reliability = request.Reliability;
            attack.SourceId = _dbContext.Sources.Where(x => x.Name == request.Source).FirstOrDefault()?.Id ?? 2;
            attack.UpdateDate = DateTime.Now;

            var aeList = await _dbContext.AttackEffectList.Where(x => x.AttackId == attack.Id).ToListAsync();
            _dbContext.RemoveRange(aeList);

            attack.AttackEffectList = request.AttackEffectList.Select(dto => new AttackEffectList
            {
                Id = dto.Id ?? 0,
                AttackId = dto.AttackId,
                ChancePercent = dto.ChancePercent,
                Damage = dto.Damage,
                EffectId = dto.Effect?.Id ?? 0,
                IsDealDamage = dto.IsDealDamage,
            }).ToList();

            _dbContext.Entry(attack).State = EntityState.Modified;
            return await SaveAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var attack = await _dbContext.Attacks.FindAsync(id);
            if (attack is null)
                throw new CustomException("Существо не найдено!");

            _dbContext.Remove(attack);
            return await SaveAsync();
        }
    }
}
