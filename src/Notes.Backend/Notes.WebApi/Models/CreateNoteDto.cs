﻿using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.CreateNote;
using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace Notes.WebApi.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommand>
    {
        [Required]
        public string Title { get; set; }
        public string Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
                .ForMember(noteCommand => noteCommand.Title,
                    opt => opt.MapFrom(noteDto => noteDto.Title))
                .ForMember(noteCommant => noteCommant.Details,
                    opt => opt.MapFrom(noteDto => noteDto.Details));
        }
    }
}
