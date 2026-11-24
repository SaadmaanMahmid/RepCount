using WorkoutLog.Core.DTOs;

namespace WorkoutLog.Core.Interfaces
{
    public interface IWorkoutRepository
    {
        Task<List<WorkoutDTO>> GetAllWorkoutsAsync();
        Task<WorkoutDTO?> GetWorkoutByIdAsync(int workoutId);
        Task AddWorkoutAsync(WorkoutDTO workout);
        Task<bool> UpdateWorkoutAsync(WorkoutDTO workout);
        Task<bool> DeleteWorkoutAsync(int workoutId);
        Task<int> GetWorkoutCountAsync();
        Task<int> GetExerciseEntryCountAsync();
    }
}
