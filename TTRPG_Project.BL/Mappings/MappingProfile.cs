using AutoMapper;
using TTRPG_Project.BL.DTO.UserDTO.Responce;
using TTRPG_Project.DAL.Entities.Database.Users;

namespace Partners.BL.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResponse>().ReverseMap();
        }
    }
}
