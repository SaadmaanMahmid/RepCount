using WorkoutLog.Core.DTOs;

namespace WorkoutLog.Core.Services
{
    public class WorkoutStreakCalculator
    {
        private const int MotivationalMessageThreshold = 5; // Number of consecutive days to trigger motivational message

        public WorkoutStreakDTO Calculate(IEnumerable<DateOnly> workoutDates,
            DateOnly today)
        {
            var dates = workoutDates
                .Where(date => date <= today)
                .Distinct()
                .OrderByDescending(date => date)
                .ToList();

            if (dates == null || dates.Count == 0)
            {
                return new WorkoutStreakDTO();
            }

            DateOnly latestWorkoutDate = dates[0];

            // A streak remains active if the latest workout
            // was today or yesterday.
            if (latestWorkoutDate < today.AddDays(-1))
            {
                return new WorkoutStreakDTO();
            }

            // Count consecutive calendar dates backwards.
            int streak = 1;
            for (int i = 1; i < dates.Count; i++)
            {
                if (dates[i] == dates[i - 1].AddDays(-1))
                {
                    streak++;
                }
                else
                {
                    break;
                }
            }
            bool shouldShowMotivationalMessage = streak >= MotivationalMessageThreshold;
            return new WorkoutStreakDTO
            {
                CurrentStreak = streak,
                ShouldShowMotivationalMessage = shouldShowMotivationalMessage
            };
        }
    }
}
