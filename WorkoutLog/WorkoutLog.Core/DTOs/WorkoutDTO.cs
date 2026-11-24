
namespace WorkoutLog.Core.DTOs
{
    public class WorkoutDTO
    {
        public int WorkoutId { get; set; }

        public DateOnly WorkoutDate { get; set; }

        public string WorkoutName { get; set; } = String.Empty;

        public string? Notes { get; set; }
    }
}
