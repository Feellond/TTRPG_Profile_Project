using AutoMapper;
using TTRPG_Project.BL.DTO.Additional.Request;
using TTRPG_Project.BL.DTO.Additional.Responce;
using TTRPG_Project.BL.DTO.Creatures.Request;
using TTRPG_Project.BL.DTO.Creatures.Responce;
using TTRPG_Project.BL.DTO.Items.Request;
using TTRPG_Project.BL.DTO.Items.Responce;
using TTRPG_Project.BL.DTO.UserDTO.Responce;
using TTRPG_Project.DAL.Entities.Database.Additional;
using TTRPG_Project.DAL.Entities.Database.Creatures;
using TTRPG_Project.DAL.Entities.Database.Items;
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
            CreateMap<AlchemicalItem, ItemResponce>();
            //Вопрос в целесообразности. Либо всю мешанину в ItemResponce, либо создавать на каждый как: AlchemicalItemResponce, ...Responce, ...

            CreateMap<SkillRequest, Skill>().ReverseMap();
            CreateMap<SkillRequest, SkillResponce>().ReverseMap();

            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
