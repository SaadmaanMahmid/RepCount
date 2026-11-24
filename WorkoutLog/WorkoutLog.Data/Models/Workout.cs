using System;
using System.Collections.Generic;

namespace WorkoutLog.Data.Models;

public partial class Workout
{
    public int WorkoutId { get; set; }

    public DateOnly WorkoutDate { get; set; }

    public string WorkoutName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ICollection<ExerciseEntry> ExerciseEntries { get; set; } = new List<ExerciseEntry>();
}
