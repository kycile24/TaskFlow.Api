using TaskFlow.Api.DTOs;
using TaskFlow.Api.Entities;
using TaskFlow.Api.Interfaces;
using AutoMapper;
namespace TaskFlow.Api.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;
    public TaskService(
      ITaskRepository taskRepository,
      IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    public async Task<List<TaskItem>> GetAllAsync(
      string? search,
      bool? isCompleted)
    {
        return await _taskRepository.GetAllAsync(search, isCompleted);
    }

    public async Task<TaskItem?> GetByIdAsync(int id)
    {
        return await _taskRepository.GetByIdAsync(id);
    }

    public async Task<TaskItem> CreateAsync(CreateTaskDto dto)
    {
        var task = _mapper.Map<TaskItem>(dto);

        task.CreatedAt = DateTime.UtcNow;
        task.IsCompleted = false;

        return await _taskRepository.CreateAsync(task);
    }

    public async Task<bool> UpdateAsync(int id, UpdateTaskDto dto)
    {
        var task = await _taskRepository.GetByIdAsync(id);

        if (task is null)
        {
            return false;
        }

        _mapper.Map(dto, task);

        await _taskRepository.UpdateAsync(task);

        return true;
    }
    public async Task<bool> DeleteAsync(int id)
    {
        var task = await _taskRepository.GetByIdAsync(id);

        if (task is null)
        {
            return false;
        }

        await _taskRepository.DeleteAsync(task);

        return true;
    }
}