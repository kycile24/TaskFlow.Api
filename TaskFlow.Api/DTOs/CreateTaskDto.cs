using System.ComponentModel.DataAnnotations;

namespace TaskFlow.Api.DTOs;

public class CreateTaskDto
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }
}