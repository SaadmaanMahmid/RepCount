using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WorkoutLog.Core.DTOs;
using WorkoutLog.Core.Interfaces;
using WorkoutLog.Data.Models;
using WorkoutLog.Data.Context;

namespace WorkoutLog.Data.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private readonly WorkoutLogDbContext _context;
        public WorkoutRepository(WorkoutLogDbContext context)
        {
            _context = context;
        }
        public async Task<List<WorkoutDTO>> GetAllWorkoutsAsync()
        {
            return await _context.Workouts
                .AsNoTracking()
                .Select(w => new WorkoutDTO
                {
                    WorkoutId = w.WorkoutId,
                    WorkoutDate = w.WorkoutDate,
                    WorkoutName = w.WorkoutName,
                    Notes = w.Notes
                })
                .ToListAsync();
        }
        public async Task<WorkoutDTO?> GetWorkoutByIdAsync(int workoutId)
        {
            return await _context.Workouts
                .AsNoTracking()
                .Where(w => w.WorkoutId == workoutId)
                .Select(w => new WorkoutDTO
                {
                    WorkoutId = w.WorkoutId,
                    WorkoutDate = w.WorkoutDate,
                    WorkoutName = w.WorkoutName,
                    Notes = w.Notes
                })
                .FirstOrDefaultAsync();
        }
        public async Task AddWorkoutAsync(WorkoutDTO workout)
        {
            var newWorkout = new Workout
            {
                WorkoutDate = workout.WorkoutDate,
                WorkoutName = workout.WorkoutName,
                Notes = workout.Notes
            };

            await _context.Workouts.AddAsync(newWorkout);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdateWorkoutAsync(WorkoutDTO workout)
        {
            //what happens if we use FindAsync instead of FirstOrDefaultAsync?
            var existingWorkout = await _context.Workouts
                .FirstOrDefaultAsync(w => w.WorkoutId == workout.WorkoutId);

            if (existingWorkout == null)
            {
                return false;
            }

            existingWorkout.WorkoutDate = workout.WorkoutDate;
            existingWorkout.WorkoutName = workout.WorkoutName;
            existingWorkout.Notes = workout.Notes;

            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteWorkoutAsync(int workoutId)
        {
            var existingWorkout = await _context.Workouts
                .FindAsync(workoutId);

            if (existingWorkout == null)
            {
                return false;
            }

            bool hasExerciseEntries = await _context.ExerciseEntries
                .AnyAsync(e => e.WorkoutId == workoutId);

            if (hasExerciseEntries)
            {
                return false;
            }

            _context.Workouts.Remove(existingWorkout);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<int> GetWorkoutCountAsync()
        {
            return await _context.Workouts.CountAsync();
        }
        public async Task<int> GetExerciseEntryCountAsync()
        {
            return await _context.ExerciseEntries.CountAsync();
        }
        public async Task<List<DateOnly>> GetWorkoutDatesAsync()
        {
            return await _context.Workouts
                .Select(w => w.WorkoutDate)
                .ToListAsync();
        }
    }
}
