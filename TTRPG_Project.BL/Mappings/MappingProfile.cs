using AutoMapper;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Entities.Additional.Responce;
using TTRPG_Project.BL.DTO.Entities.Spells.Request;
using TTRPG_Project.BL.DTO.Entities.UserDTO.Responce;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;
using TTRPG_Project.DAL.Entities.Database.Spells;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace Partners.BL.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EffectRequest, Effect>().ReverseMap();
            CreateMap<Effect, EffectResponce>();


            CreateMap<AlchemicalItemRequest, AlchemicalItem>().ReverseMap();
            CreateMap<ArmorRequest, Armor>().ReverseMap();
            CreateMap<BlueprintRequest, Blueprint>().ReverseMap();
            CreateMap<ComponentRequest, Component>().ReverseMap();
            CreateMap<FormulaRequest, Formula>().ReverseMap();
            CreateMap<ItemBaseRequest, ItemBase>().ReverseMap();
            CreateMap<ItemRequest, Item>().ReverseMap();
            CreateMap<ToolRequest, Tool>().ReverseMap();
            CreateMap<WeaponRequest, Weapon>().ReverseMap();
            //Вопрос в целесообразности. Либо всю мешанину в ItemResponce, либо создавать на каждый как: AlchemicalItemResponce, ...Responce, ...

            CreateMap<AbilitiyRequest, Abilitiy>().ReverseMap();
            CreateMap<AttackRequest, Attack>().ReverseMap();
            CreateMap<ClassRequest, Class>().ReverseMap();
            CreateMap<CreatureRequest, Creature>().ReverseMap();
            CreateMap<RaceRequest, Race>().ReverseMap();
            CreateMap<SkillRequest, Skill>().ReverseMap();
            CreateMap<SkillsListRequest, SkillsList>().ReverseMap();
            CreateMap<SkillsTreeRequest, SkillsTree>().ReverseMap();
            CreateMap<StatRequest, Stat>().ReverseMap();
            CreateMap<StatsListRequest, StatsList>().ReverseMap();

            CreateMap<SpellRequest, Spell>().ReverseMap();

            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
