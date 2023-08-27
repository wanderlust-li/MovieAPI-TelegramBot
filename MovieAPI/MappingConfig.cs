﻿using AutoMapper;
using MovieAPI.Models;
using MovieAPI.Models.DTO;

namespace MovieAPI;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<Movie, MovieDTO>();
        CreateMap<MovieDTO, Movie>();
        
        CreateMap<CreateMovieDTO, Movie>(); 
        CreateMap<Movie, UpdateMovieDTO>().ReverseMap();
        
        
        CreateMap<Actor, ActorDTO>();
        CreateMap<ActorDTO, Actor>();
        
        CreateMap<ActorCreateDTO, Actor>(); 
        CreateMap<Actor, UpdateMovieDTO>().ReverseMap();
        
        CreateMap<ApplicationUser, UserDTO>().ReverseMap();
    }
}