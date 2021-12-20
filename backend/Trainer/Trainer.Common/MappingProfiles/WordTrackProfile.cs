﻿using AutoMapper;
using Trainer.Common.DTO;
using Trainer.Domain.Models;

namespace Trainer.Common.MappingProfiles
{
    public sealed class WordTrackProfile : Profile
    {
        public WordTrackProfile()
        {
            CreateMap<WordTrack, WordTrackReadDTO>().ReverseMap();
            CreateMap<WordTrack, WordTrackWriteDTO>().ReverseMap();
        }
    }
}
