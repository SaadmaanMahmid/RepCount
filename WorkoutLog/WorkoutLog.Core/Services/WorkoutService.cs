using WorkoutLog.Core.DTOs;
using WorkoutLog.Core.Interfaces;

namespace WorkoutLog.Core.Services
{
    public class WorkoutService : IWorkoutService
    {
        private readonly IWorkoutRepository _workoutRepository;
        private readonly WorkoutStreakCalculator _streakCalculator;

        public WorkoutService(IWorkoutRepository workoutRepository, WorkoutStreakCalculator streakCalculator)
        {
            _workoutRepository = workoutRepository;
            _streakCalculator = streakCalculator;
        }
        public async Task<List<WorkoutDTO>> GetAllWorkoutsAsync()
        {
            return await _workoutRepository.GetAllWorkoutsAsync();
        }
        public async Task<WorkoutDTO?> GetWorkoutByIdAsync(int workoutId)
        {
            return await _workoutRepository.GetWorkoutByIdAsync(workoutId);
        }
        public async Task AddWorkoutAsync(WorkoutDTO workout)
        {
            ArgumentNullException.ThrowIfNull(workout);

            if (string.IsNullOrWhiteSpace(workout.WorkoutName))
            {
                throw new ArgumentException("Workout name is required.");
            }

            await _workoutRepository.AddWorkoutAsync(workout);
        }
        public async Task<bool> UpdateWorkoutAsync(WorkoutDTO workout)
        {
            ArgumentNullException.ThrowIfNull(workout);

            if (string.IsNullOrWhiteSpace(workout.WorkoutName))
            {
                throw new ArgumentException("Workout name is required.");
            }

            return await _workoutRepository.UpdateWorkoutAsync(workout);
        }
        public async Task<bool> DeleteWorkoutAsync(int workoutId)
        {
            return await _workoutRepository.DeleteWorkoutAsync(workoutId);
        }
        public async Task<int> GetWorkoutCountAsync()
        {
            return await _workoutRepository.GetWorkoutCountAsync();
        }
        public async Task<int> GetExerciseEntryCountAsync()
        {
            return await _workoutRepository.GetExerciseEntryCountAsync();
        }
        public async Task<WorkoutStreakDTO> GetCurrentWorkoutStreakAsync()
        {
            List<DateOnly> workoutDates =
                await _workoutRepository.GetWorkoutDatesAsync();

            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            return _streakCalculator.Calculate(workoutDates, today);
        }
    }
}
