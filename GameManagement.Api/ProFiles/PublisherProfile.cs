﻿using AutoMapper;
using GameManagement.Shared.Entities;
using GameManagement.Shared.Models;

namespace GameManagement.Api.ProFiles
{
    public class PublisherProfile : MapperConfigurationExpression
    {
        public PublisherProfile()
        {
            CreateMap<Publisher, PublisherDto>()
                .ReverseMap()
                .ForMember(dest =>,
                opt =>);

        }



    }
}
