namespace CommandsService.Profiles
{
    using AutoMapper;
    using CommandsService.Dtos;
    using CommandsService.Models;

    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
            CreateMap<PlatformPublishedDto, Platform>()
                .ForMember(dest => dest.ExternalId, memberOptions => memberOptions.MapFrom(src => src.Id));
        }
    }
}