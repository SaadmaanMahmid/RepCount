using System;
using System.Collections.Generic;

namespace WorkoutLog.Data.Models;

public partial class ExerciseEntry
{
    public int ExerciseEntryId { get; set; }

    public int WorkoutId { get; set; }

    public string ExerciseName { get; set; } = null!;

    public int Sets { get; set; }

    public int Reps { get; set; }

    public decimal Weight { get; set; }

    public virtual Workout Workout { get; set; } = null!;
}
