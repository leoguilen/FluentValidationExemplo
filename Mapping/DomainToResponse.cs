using AutoMapper;
using ServiceExample.Contracts.Response;
using ServiceExample.Domain;

namespace ServiceExample.Mapping
{
    public class DomainToResponse : Profile
    {
        public DomainToResponse()
        {
            CreateMap<User, UserResponse>();
        }
    }
}
