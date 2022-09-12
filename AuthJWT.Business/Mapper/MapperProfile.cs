using AuthJWT.Business.Models;
using AuthJWT.Business.Models.Register;
using AuthJWT.Entites.Identity;
using AutoMapper;

namespace AuthJWT.Business.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserEntity, UserModel>();
            CreateMap<RegisterRequestModel, UserEntity>();
        }
    }
}
