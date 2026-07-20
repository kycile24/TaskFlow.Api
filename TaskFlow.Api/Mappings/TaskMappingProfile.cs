using AutoMapper;
using TaskFlow.Api.DTOs;
using TaskFlow.Api.Entities;

namespace TaskFlow.Api.Mappings;

public class TaskMappingProfile : Profile
{
    public TaskMappingProfile()
    {
        CreateMap<CreateTaskDto, TaskItem>();

        CreateMap<UpdateTaskDto, TaskItem>();
    }
}