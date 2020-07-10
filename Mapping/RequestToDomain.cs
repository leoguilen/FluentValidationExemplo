using AutoMapper;
using ServiceExample.Contracts.Request;
using ServiceExample.Domain;

namespace ServiceExample.Mapping
{
    public class RequestToDomain : Profile
    {
        public RequestToDomain()
        {
            CreateMap<CreateUserRequest, User>();
        }
    }
}
