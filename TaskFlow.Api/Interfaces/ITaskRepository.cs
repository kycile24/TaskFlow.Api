using TaskFlow.Api.Entities;

namespace TaskFlow.Api.Interfaces;

public interface ITaskRepository
{
    Task<List<TaskItem>> GetAllAsync(string? search, bool? isCompleted);

    Task<TaskItem?> GetByIdAsync(int id);

    Task<TaskItem> CreateAsync(TaskItem task);

    Task UpdateAsync(TaskItem task);

    Task DeleteAsync(TaskItem task);
}