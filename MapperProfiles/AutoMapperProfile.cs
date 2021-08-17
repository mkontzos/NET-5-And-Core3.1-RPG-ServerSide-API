using AutoMapper;
using DotNet_Rpg.Dtos.Character;
using DotNet_Rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet_Rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<GetCharacterDto, Character>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Character, AddCharacterDto>();
        }
    }
}
