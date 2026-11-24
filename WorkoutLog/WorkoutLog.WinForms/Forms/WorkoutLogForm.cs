using WorkoutLog.Core.Interfaces;

namespace WorkoutLog.WinForms.Forms
{
    public partial class WorkoutLogForm : Form
    {
        private readonly IWorkoutService _workoutService;
        public WorkoutLogForm(IWorkoutService workoutService)
        {
            InitializeComponent();
            _workoutService = workoutService;
        }
        private void ConfigureDashboard()
        {
            dgvRecentWorkouts.AutoGenerateColumns = false;
        }

        private async void WorkoutLogForm_Load(object sender, EventArgs e)
        {
            ConfigureDashboard();
            await LoadDashBoardDataAsync();
        }
        private async Task LoadDashBoardDataAsync()
        {
            try
            {
                //Load dashboard statistics
                int totalWorkouts = await _workoutService.GetWorkoutCountAsync();
                int totalExerciseEntries = await _workoutService.GetExerciseEntryCountAsync();

                //Load the ten most recent exercises
                var recentWorkouts = (await _workoutService.GetAllWorkoutsAsync())
                    .OrderByDescending(w => w.WorkoutDate)
                    .ThenByDescending(w => w.WorkoutId)
                    .Take(10)
                    .ToList();

                //Update dashboard statistics
                lblTotalWorkoutsValue.Text = totalWorkouts.ToString();
                lblExerciseEntriesValue.Text = totalExerciseEntries.ToString();

                //Populate the recent workouts DataGridView
                dgvRecentWorkouts.DataSource = recentWorkouts;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    $"Unable to load dashboard data.\n\n{e.Message}",
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
