namespace WorkoutLog.WinForms.Forms
{
    partial class WorkoutLogForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlSideBar = new Panel();
            tlpSidebar = new TableLayoutPanel();
            lblAppName = new Label();
            btnDashboard = new Button();
            btnWorkouts = new Button();
            btnExercises = new Button();
            lblSidebarFooter = new Label();
            pnlContent = new Panel();
            tlpContent = new TableLayoutPanel();
            pnlHeader = new Panel();
            lblWelcomeMessage = new Label();
            lblDashboardTitle = new Label();
            pnlStats = new Panel();
            tlpStats = new TableLayoutPanel();
            pnlTotalWorkoutsCard = new Panel();
            lblTotalWorkoutsDescription = new Label();
            lblTotalWorkoutsValue = new Label();
            lblTotalWorkoutsTitle = new Label();
            pnlExerciseEntriesCard = new Panel();
            lblExerciseEntriesDescription = new Label();
            lblExerciseEntriesValue = new Label();
            lblExerciseEntriesTitle = new Label();
            pnlRecent = new Panel();
            tlpRecent = new TableLayoutPanel();
            lblRecentWorkoutsTitle = new Label();
            dgvRecentWorkouts = new DataGridView();
            colWorkoutDate = new DataGridViewTextBoxColumn();
            colWorkoutName = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            tlpMain.SuspendLayout();
            pnlSideBar.SuspendLayout();
            tlpSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            tlpContent.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            tlpStats.SuspendLayout();
            pnlTotalWorkoutsCard.SuspendLayout();
            pnlExerciseEntriesCard.SuspendLayout();
            pnlRecent.SuspendLayout();
            tlpRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentWorkouts).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlSideBar, 0, 0);
            tlpMain.Controls.Add(pnlContent, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1182, 753);
            tlpMain.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(23, 36, 58);
            pnlSideBar.Controls.Add(tlpSidebar);
            pnlSideBar.Dock = DockStyle.Fill;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Margin = new Padding(0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Padding = new Padding(16, 20, 0, 20);
            pnlSideBar.Size = new Size(220, 753);
            pnlSideBar.TabIndex = 0;
            // 
            // tlpSidebar
            // 
            tlpSidebar.ColumnCount = 1;
            tlpSidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSidebar.Controls.Add(lblAppName, 0, 0);
            tlpSidebar.Controls.Add(btnDashboard, 0, 1);
            tlpSidebar.Controls.Add(btnWorkouts, 0, 2);
            tlpSidebar.Controls.Add(btnExercises, 0, 3);
            tlpSidebar.Controls.Add(lblSidebarFooter, 0, 5);
            tlpSidebar.Dock = DockStyle.Fill;
            tlpSidebar.Location = new Point(16, 20);
            tlpSidebar.Margin = new Padding(0);
            tlpSidebar.Name = "tlpSidebar";
            tlpSidebar.RowCount = 6;
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSidebar.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpSidebar.Size = new Size(204, 713);
            tlpSidebar.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.BackColor = Color.Transparent;
            lblAppName.Dock = DockStyle.Fill;
            lblAppName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(0, 0);
            lblAppName.Margin = new Padding(0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(204, 80);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "WorkoutLog";
            lblAppName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(22, 166, 161);
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 58, 85);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 80);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(204, 48);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnWorkouts
            // 
            btnWorkouts.Dock = DockStyle.Fill;
            btnWorkouts.FlatAppearance.BorderSize = 0;
            btnWorkouts.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 58, 85);
            btnWorkouts.FlatStyle = FlatStyle.Flat;
            btnWorkouts.Font = new Font("Segoe UI", 10F);
            btnWorkouts.ForeColor = Color.FromArgb(185, 197, 213);
            btnWorkouts.Location = new Point(3, 131);
            btnWorkouts.Name = "btnWorkouts";
            btnWorkouts.Size = new Size(198, 42);
            btnWorkouts.TabIndex = 2;
            btnWorkouts.Text = "Workouts";
            btnWorkouts.TextAlign = ContentAlignment.MiddleLeft;
            btnWorkouts.UseVisualStyleBackColor = true;
            // 
            // btnExercises
            // 
            btnExercises.Dock = DockStyle.Fill;
            btnExercises.FlatAppearance.BorderSize = 0;
            btnExercises.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 58, 85);
            btnExercises.FlatStyle = FlatStyle.Flat;
            btnExercises.Font = new Font("Segoe UI", 10F);
            btnExercises.ForeColor = Color.FromArgb(185, 197, 213);
            btnExercises.Location = new Point(3, 179);
            btnExercises.Name = "btnExercises";
            btnExercises.Size = new Size(198, 42);
            btnExercises.TabIndex = 3;
            btnExercises.Text = "Exercises";
            btnExercises.TextAlign = ContentAlignment.MiddleLeft;
            btnExercises.UseVisualStyleBackColor = true;
            // 
            // lblSidebarFooter
            // 
            lblSidebarFooter.AutoSize = true;
            lblSidebarFooter.BackColor = Color.Transparent;
            lblSidebarFooter.Dock = DockStyle.Fill;
            lblSidebarFooter.Font = new Font("Segoe UI", 7F);
            lblSidebarFooter.ForeColor = Color.FromArgb(185, 197, 213);
            lblSidebarFooter.Location = new Point(0, 668);
            lblSidebarFooter.Margin = new Padding(0);
            lblSidebarFooter.Name = "lblSidebarFooter";
            lblSidebarFooter.Size = new Size(204, 45);
            lblSidebarFooter.TabIndex = 4;
            lblSidebarFooter.Text = "PERSONAL FITNESS TRACKER";
            lblSidebarFooter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(tlpContent);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Margin = new Padding(0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(28);
            pnlContent.Size = new Size(962, 753);
            pnlContent.TabIndex = 1;
            // 
            // tlpContent
            // 
            tlpContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpContent.ColumnCount = 1;
            tlpContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContent.Controls.Add(pnlHeader, 0, 0);
            tlpContent.Controls.Add(pnlStats, 0, 1);
            tlpContent.Controls.Add(pnlRecent, 0, 2);
            tlpContent.Location = new Point(28, 28);
            tlpContent.Margin = new Padding(0);
            tlpContent.Name = "tlpContent";
            tlpContent.RowCount = 3;
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContent.Size = new Size(906, 697);
            tlpContent.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcomeMessage);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(906, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.BackColor = Color.Transparent;
            lblWelcomeMessage.Font = new Font("Segoe UI", 10F);
            lblWelcomeMessage.ForeColor = Color.FromArgb(123, 135, 148);
            lblWelcomeMessage.Location = new Point(0, 52);
            lblWelcomeMessage.Margin = new Padding(0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(420, 23);
            lblWelcomeMessage.TabIndex = 1;
            lblWelcomeMessage.Text = "Welcome back! Here's your fitness activity at a glance.";
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.BackColor = Color.Transparent;
            lblDashboardTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.FromArgb(32, 43, 60);
            lblDashboardTitle.Location = new Point(0, 8);
            lblDashboardTitle.Margin = new Padding(0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(236, 31);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Dashboard Overview";
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(tlpStats);
            pnlStats.Dock = DockStyle.Fill;
            pnlStats.Location = new Point(0, 90);
            pnlStats.Margin = new Padding(0);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(906, 150);
            pnlStats.TabIndex = 1;
            // 
            // tlpStats
            // 
            tlpStats.ColumnCount = 2;
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStats.Controls.Add(pnlTotalWorkoutsCard, 0, 0);
            tlpStats.Controls.Add(pnlExerciseEntriesCard, 1, 0);
            tlpStats.Dock = DockStyle.Fill;
            tlpStats.Location = new Point(0, 0);
            tlpStats.Margin = new Padding(0);
            tlpStats.Name = "tlpStats";
            tlpStats.RowCount = 1;
            tlpStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStats.Size = new Size(906, 150);
            tlpStats.TabIndex = 0;
            // 
            // pnlTotalWorkoutsCard
            // 
            pnlTotalWorkoutsCard.BackColor = Color.White;
            pnlTotalWorkoutsCard.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalWorkoutsCard.Controls.Add(lblTotalWorkoutsDescription);
            pnlTotalWorkoutsCard.Controls.Add(lblTotalWorkoutsValue);
            pnlTotalWorkoutsCard.Controls.Add(lblTotalWorkoutsTitle);
            pnlTotalWorkoutsCard.Dock = DockStyle.Fill;
            pnlTotalWorkoutsCard.Location = new Point(0, 5);
            pnlTotalWorkoutsCard.Margin = new Padding(0, 5, 8, 5);
            pnlTotalWorkoutsCard.Name = "pnlTotalWorkoutsCard";
            pnlTotalWorkoutsCard.Padding = new Padding(18, 12, 18, 12);
            pnlTotalWorkoutsCard.Size = new Size(445, 140);
            pnlTotalWorkoutsCard.TabIndex = 0;
            // 
            // lblTotalWorkoutsDescription
            // 
            lblTotalWorkoutsDescription.AutoSize = true;
            lblTotalWorkoutsDescription.BackColor = Color.Transparent;
            lblTotalWorkoutsDescription.ForeColor = Color.FromArgb(123, 135, 148);
            lblTotalWorkoutsDescription.Location = new Point(18, 105);
            lblTotalWorkoutsDescription.Name = "lblTotalWorkoutsDescription";
            lblTotalWorkoutsDescription.Size = new Size(139, 20);
            lblTotalWorkoutsDescription.TabIndex = 2;
            lblTotalWorkoutsDescription.Text = "Recorded Workouts";
            // 
            // lblTotalWorkoutsValue
            // 
            lblTotalWorkoutsValue.AutoSize = true;
            lblTotalWorkoutsValue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTotalWorkoutsValue.Location = new Point(18, 40);
            lblTotalWorkoutsValue.Name = "lblTotalWorkoutsValue";
            lblTotalWorkoutsValue.Size = new Size(43, 60);
            lblTotalWorkoutsValue.TabIndex = 1;
            lblTotalWorkoutsValue.Text = "-";
            // 
            // lblTotalWorkoutsTitle
            // 
            lblTotalWorkoutsTitle.AutoSize = true;
            lblTotalWorkoutsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalWorkoutsTitle.ForeColor = Color.FromArgb(123, 135, 148);
            lblTotalWorkoutsTitle.Location = new Point(18, 20);
            lblTotalWorkoutsTitle.Name = "lblTotalWorkoutsTitle";
            lblTotalWorkoutsTitle.Size = new Size(143, 20);
            lblTotalWorkoutsTitle.TabIndex = 0;
            lblTotalWorkoutsTitle.Text = "TOTAL WORKOUTS";
            // 
            // pnlExerciseEntriesCard
            // 
            pnlExerciseEntriesCard.BackColor = Color.White;
            pnlExerciseEntriesCard.BorderStyle = BorderStyle.FixedSingle;
            pnlExerciseEntriesCard.Controls.Add(lblExerciseEntriesDescription);
            pnlExerciseEntriesCard.Controls.Add(lblExerciseEntriesValue);
            pnlExerciseEntriesCard.Controls.Add(lblExerciseEntriesTitle);
            pnlExerciseEntriesCard.Dock = DockStyle.Fill;
            pnlExerciseEntriesCard.Location = new Point(453, 5);
            pnlExerciseEntriesCard.Margin = new Padding(0, 5, 0, 5);
            pnlExerciseEntriesCard.Name = "pnlExerciseEntriesCard";
            pnlExerciseEntriesCard.Padding = new Padding(18, 12, 18, 12);
            pnlExerciseEntriesCard.Size = new Size(453, 140);
            pnlExerciseEntriesCard.TabIndex = 1;
            // 
            // lblExerciseEntriesDescription
            // 
            lblExerciseEntriesDescription.AutoSize = true;
            lblExerciseEntriesDescription.ForeColor = Color.FromArgb(123, 135, 148);
            lblExerciseEntriesDescription.Location = new Point(18, 105);
            lblExerciseEntriesDescription.Name = "lblExerciseEntriesDescription";
            lblExerciseEntriesDescription.Size = new Size(136, 20);
            lblExerciseEntriesDescription.TabIndex = 2;
            lblExerciseEntriesDescription.Text = "Recorded Exercises";
            // 
            // lblExerciseEntriesValue
            // 
            lblExerciseEntriesValue.AutoSize = true;
            lblExerciseEntriesValue.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblExerciseEntriesValue.ForeColor = Color.FromArgb(32, 43, 60);
            lblExerciseEntriesValue.Location = new Point(18, 40);
            lblExerciseEntriesValue.Name = "lblExerciseEntriesValue";
            lblExerciseEntriesValue.Size = new Size(43, 60);
            lblExerciseEntriesValue.TabIndex = 1;
            lblExerciseEntriesValue.Text = "-";
            // 
            // lblExerciseEntriesTitle
            // 
            lblExerciseEntriesTitle.AutoSize = true;
            lblExerciseEntriesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExerciseEntriesTitle.ForeColor = Color.FromArgb(123, 135, 148);
            lblExerciseEntriesTitle.Location = new Point(18, 20);
            lblExerciseEntriesTitle.Name = "lblExerciseEntriesTitle";
            lblExerciseEntriesTitle.Size = new Size(139, 20);
            lblExerciseEntriesTitle.TabIndex = 0;
            lblExerciseEntriesTitle.Text = "EXERCISE ENTRIES";
            // 
            // pnlRecent
            // 
            pnlRecent.Controls.Add(tlpRecent);
            pnlRecent.Dock = DockStyle.Fill;
            pnlRecent.Location = new Point(0, 240);
            pnlRecent.Margin = new Padding(0);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Size = new Size(906, 457);
            pnlRecent.TabIndex = 2;
            // 
            // tlpRecent
            // 
            tlpRecent.ColumnCount = 1;
            tlpRecent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRecent.Controls.Add(lblRecentWorkoutsTitle, 0, 0);
            tlpRecent.Controls.Add(dgvRecentWorkouts, 0, 1);
            tlpRecent.Dock = DockStyle.Fill;
            tlpRecent.Location = new Point(0, 0);
            tlpRecent.Margin = new Padding(0);
            tlpRecent.Name = "tlpRecent";
            tlpRecent.RowCount = 2;
            tlpRecent.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpRecent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecent.Size = new Size(906, 457);
            tlpRecent.TabIndex = 0;
            // 
            // lblRecentWorkoutsTitle
            // 
            lblRecentWorkoutsTitle.AutoSize = true;
            lblRecentWorkoutsTitle.BackColor = Color.Transparent;
            lblRecentWorkoutsTitle.Dock = DockStyle.Fill;
            lblRecentWorkoutsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecentWorkoutsTitle.ForeColor = Color.FromArgb(32, 43, 60);
            lblRecentWorkoutsTitle.Location = new Point(0, 0);
            lblRecentWorkoutsTitle.Margin = new Padding(0);
            lblRecentWorkoutsTitle.Name = "lblRecentWorkoutsTitle";
            lblRecentWorkoutsTitle.Size = new Size(906, 45);
            lblRecentWorkoutsTitle.TabIndex = 0;
            lblRecentWorkoutsTitle.Text = "Recent Workouts";
            lblRecentWorkoutsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvRecentWorkouts
            // 
            dgvRecentWorkouts.AllowUserToAddRows = false;
            dgvRecentWorkouts.AllowUserToDeleteRows = false;
            dgvRecentWorkouts.AllowUserToResizeRows = false;
            dgvRecentWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentWorkouts.BackgroundColor = Color.White;
            dgvRecentWorkouts.BorderStyle = BorderStyle.None;
            dgvRecentWorkouts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentWorkouts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 241, 245);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(82, 97, 118);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(237, 241, 245);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(82, 97, 118);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentWorkouts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentWorkouts.ColumnHeadersHeight = 40;
            dgvRecentWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecentWorkouts.Columns.AddRange(new DataGridViewColumn[] { colWorkoutDate, colWorkoutName, colNotes });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(32, 43, 60);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(226, 243, 242);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(32, 43, 60);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRecentWorkouts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRecentWorkouts.Dock = DockStyle.Fill;
            dgvRecentWorkouts.EnableHeadersVisualStyles = false;
            dgvRecentWorkouts.GridColor = Color.FromArgb(235, 239, 243);
            dgvRecentWorkouts.Location = new Point(0, 45);
            dgvRecentWorkouts.Margin = new Padding(0);
            dgvRecentWorkouts.MultiSelect = false;
            dgvRecentWorkouts.Name = "dgvRecentWorkouts";
            dgvRecentWorkouts.ReadOnly = true;
            dgvRecentWorkouts.RowHeadersVisible = false;
            dgvRecentWorkouts.RowHeadersWidth = 51;
            dgvRecentWorkouts.RowTemplate.Height = 38;
            dgvRecentWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentWorkouts.Size = new Size(906, 412);
            dgvRecentWorkouts.TabIndex = 1;
            // 
            // colWorkoutDate
            // 
            colWorkoutDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colWorkoutDate.DataPropertyName = "WorkoutDate";
            dataGridViewCellStyle2.Format = "MMM dd, yyyy";
            dataGridViewCellStyle2.NullValue = null;
            colWorkoutDate.DefaultCellStyle = dataGridViewCellStyle2;
            colWorkoutDate.FillWeight = 30F;
            colWorkoutDate.HeaderText = "DATE";
            colWorkoutDate.MinimumWidth = 6;
            colWorkoutDate.Name = "colWorkoutDate";
            colWorkoutDate.ReadOnly = true;
            // 
            // colWorkoutName
            // 
            colWorkoutName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colWorkoutName.DataPropertyName = "WorkoutName";
            colWorkoutName.FillWeight = 35F;
            colWorkoutName.HeaderText = "WORKOUT";
            colWorkoutName.MinimumWidth = 6;
            colWorkoutName.Name = "colWorkoutName";
            colWorkoutName.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNotes.DataPropertyName = "Notes";
            colNotes.FillWeight = 35F;
            colNotes.HeaderText = "NOTES";
            colNotes.MinimumWidth = 6;
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            // 
            // WorkoutLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1182, 753);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(1000, 650);
            Name = "WorkoutLogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutLog \\| Fitness Tracker";
            Load += WorkoutLogForm_Load;
            tlpMain.ResumeLayout(false);
            pnlSideBar.ResumeLayout(false);
            tlpSidebar.ResumeLayout(false);
            tlpSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            tlpContent.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStats.ResumeLayout(false);
            tlpStats.ResumeLayout(false);
            pnlTotalWorkoutsCard.ResumeLayout(false);
            pnlTotalWorkoutsCard.PerformLayout();
            pnlExerciseEntriesCard.ResumeLayout(false);
            pnlExerciseEntriesCard.PerformLayout();
            pnlRecent.ResumeLayout(false);
            tlpRecent.ResumeLayout(false);
            tlpRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentWorkouts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlSideBar;
        private Panel pnlContent;
        private TableLayoutPanel tlpSidebar;
        private Label lblAppName;
        private Button btnDashboard;
        private Button btnWorkouts;
        private Button btnExercises;
        private Label lblSidebarFooter;
        private TableLayoutPanel tlpContent;
        private Panel pnlHeader;
        private Panel pnlStats;
        private Panel pnlRecent;
        private Label lblDashboardTitle;
        private Label lblWelcomeMessage;
        private TableLayoutPanel tlpStats;
        private Panel pnlTotalWorkoutsCard;
        private Label lblTotalWorkoutsDescription;
        private Label lblTotalWorkoutsValue;
        private Label lblTotalWorkoutsTitle;
        private Panel pnlExerciseEntriesCard;
        private Label lblExerciseEntriesDescription;
        private Label lblExerciseEntriesValue;
        private Label lblExerciseEntriesTitle;
        private TableLayoutPanel tlpRecent;
        private Label lblRecentWorkoutsTitle;
        private DataGridView dgvRecentWorkouts;
        private DataGridViewTextBoxColumn colWorkoutDate;
        private DataGridViewTextBoxColumn colWorkoutName;
        private DataGridViewTextBoxColumn colNotes;
    }
}
