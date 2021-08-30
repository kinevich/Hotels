﻿using AutoMapper;
using Hotels.Data;
using Hotels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Configuration
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, HotelDTO>().ReverseMap();
            CreateMap<Country, CreateHotelDTO>().ReverseMap();
        }
    }
}
