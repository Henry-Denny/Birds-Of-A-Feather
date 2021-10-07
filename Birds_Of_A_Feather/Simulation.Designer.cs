namespace Birds_Of_A_Feather
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulation));
            this.glControl = new OpenTK.GLControl();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.GraphicsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PbxBoidColour = new System.Windows.Forms.PictureBox();
            this.PbxPredatorColour = new System.Windows.Forms.PictureBox();
            this.PbxObstacleColour = new System.Windows.Forms.PictureBox();
            this.PbxBackgroundColour = new System.Windows.Forms.PictureBox();
            this.PbxConnectionLineColour = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMaxLineLength = new System.Windows.Forms.Label();
            this.SldMaxLineLength = new Birds_Of_A_Feather.CustomTrackbar();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.ChbxConnectionLines = new System.Windows.Forms.CheckBox();
            this.EnvironmentPage = new System.Windows.Forms.TabPage();
            this.EnvironmentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.RadObstacle = new System.Windows.Forms.RadioButton();
            this.RadPredator = new System.Windows.Forms.RadioButton();
            this.RadBoid = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.LblMaxSpeed = new System.Windows.Forms.Label();
            this.SldMaxSpeed = new Birds_Of_A_Feather.CustomTrackbar();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BoidPage = new System.Windows.Forms.TabPage();
            this.BoidPropertiesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AlignmentBox = new System.Windows.Forms.GroupBox();
            this.AlignmentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AlignmentRadiusBox = new System.Windows.Forms.GroupBox();
            this.AlignmentRadiusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblAlignmentRadius = new System.Windows.Forms.Label();
            this.SldAlignmentRadius = new Birds_Of_A_Feather.CustomTrackbar();
            this.AlignmentStrengthBox = new System.Windows.Forms.GroupBox();
            this.AlignmentStrengthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblAlignmentStrength = new System.Windows.Forms.Label();
            this.SldAlignmentStrength = new Birds_Of_A_Feather.CustomTrackbar();
            this.AlignmentPeripheralsBox = new System.Windows.Forms.GroupBox();
            this.AlignmentPeripheralsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblAlignmentPeripherals = new System.Windows.Forms.Label();
            this.SldAlignmentPeripherals = new Birds_Of_A_Feather.CustomTrackbar();
            this.CohesionBox = new System.Windows.Forms.GroupBox();
            this.CohesionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CohesionRadiusBox = new System.Windows.Forms.GroupBox();
            this.CohesionRadiusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblCohesionRadius = new System.Windows.Forms.Label();
            this.SldCohesionRadius = new Birds_Of_A_Feather.CustomTrackbar();
            this.CohesionStrengthBox = new System.Windows.Forms.GroupBox();
            this.CohesionStrengthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblCohesionStrength = new System.Windows.Forms.Label();
            this.SldCohesionStrength = new Birds_Of_A_Feather.CustomTrackbar();
            this.CohesionPeripheralsBox = new System.Windows.Forms.GroupBox();
            this.CohesionPeripheralsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblCohesionPeripherals = new System.Windows.Forms.Label();
            this.SldCohesionPeripherals = new Birds_Of_A_Feather.CustomTrackbar();
            this.BoidAvoidanceBox = new System.Windows.Forms.GroupBox();
            this.BoidAvoidancePanel = new System.Windows.Forms.TableLayoutPanel();
            this.BoidAvoidanceRadiusBox = new System.Windows.Forms.GroupBox();
            this.BoidAvoidanceRadiusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblBoidAvoidanceRadius = new System.Windows.Forms.Label();
            this.SldBoidAvoidanceRadius = new Birds_Of_A_Feather.CustomTrackbar();
            this.BoidAvoidanceStrengthBox = new System.Windows.Forms.GroupBox();
            this.BoidAvoidanceStrengthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblBoidAvoidanceStrength = new System.Windows.Forms.Label();
            this.SldBoidAvoidanceStrength = new Birds_Of_A_Feather.CustomTrackbar();
            this.BoidAvoidancePeripheralsBox = new System.Windows.Forms.GroupBox();
            this.BoidAvoidancePeripheralsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblBoidAvoidancePeripherals = new System.Windows.Forms.Label();
            this.SldBoidAvoidancePeripherals = new Birds_Of_A_Feather.CustomTrackbar();
            this.PredatorAvoidanceBox = new System.Windows.Forms.GroupBox();
            this.PredatorAvoidancePanel = new System.Windows.Forms.TableLayoutPanel();
            this.PredatorAvoidanceRadiusBox = new System.Windows.Forms.GroupBox();
            this.PredatorAvoidanceRadiusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblPredatorAvoidanceRadius = new System.Windows.Forms.Label();
            this.SldPredatorAvoidanceRadius = new Birds_Of_A_Feather.CustomTrackbar();
            this.PredatorAvoidanceStrengthBox = new System.Windows.Forms.GroupBox();
            this.PredatorAvoidanceStrengthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblPredatorAvoidanceStrength = new System.Windows.Forms.Label();
            this.SldPredatorAvoidanceStrength = new Birds_Of_A_Feather.CustomTrackbar();
            this.PredatorAvoidancePeripheralsBox = new System.Windows.Forms.GroupBox();
            this.PredatorAvoidancePeripheralsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblPredatorAvoidancePeripherals = new System.Windows.Forms.Label();
            this.SldPredatorAvoidancePeripherals = new Birds_Of_A_Feather.CustomTrackbar();
            this.ObstacleAvoidanceBox = new System.Windows.Forms.GroupBox();
            this.ObstacleAvoidancePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObstacleAvoidanceRadiusBox = new System.Windows.Forms.GroupBox();
            this.ObstacleAvoidanceRadiusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblObstacleAvoidanceRadius = new System.Windows.Forms.Label();
            this.SldObstacleAvoidanceRadius = new Birds_Of_A_Feather.CustomTrackbar();
            this.ObstacleAvoidanceStrengthBox = new System.Windows.Forms.GroupBox();
            this.ObstacleAvoidanceStrengthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblObstacleAvoidanceStrength = new System.Windows.Forms.Label();
            this.SldObstacleAvoidanceStrength = new Birds_Of_A_Feather.CustomTrackbar();
            this.ObstacleAvoidancePeripheralsBox = new System.Windows.Forms.GroupBox();
            this.ObstacleAvoidancePeripheralsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LblObstacleAvoidancePeripherals = new System.Windows.Forms.Label();
            this.SldObstacleAvoidancePeripherals = new Birds_Of_A_Feather.CustomTrackbar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.GraphicsPage.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBoidColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPredatorColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxObstacleColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBackgroundColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxConnectionLineColour)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldMaxLineLength)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.EnvironmentPage.SuspendLayout();
            this.EnvironmentLayoutPanel.SuspendLayout();
            this.AddBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldMaxSpeed)).BeginInit();
            this.BoidPage.SuspendLayout();
            this.BoidPropertiesPanel.SuspendLayout();
            this.AlignmentBox.SuspendLayout();
            this.AlignmentPanel.SuspendLayout();
            this.AlignmentRadiusBox.SuspendLayout();
            this.AlignmentRadiusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentRadius)).BeginInit();
            this.AlignmentStrengthBox.SuspendLayout();
            this.AlignmentStrengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentStrength)).BeginInit();
            this.AlignmentPeripheralsBox.SuspendLayout();
            this.AlignmentPeripheralsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentPeripherals)).BeginInit();
            this.CohesionBox.SuspendLayout();
            this.CohesionPanel.SuspendLayout();
            this.CohesionRadiusBox.SuspendLayout();
            this.CohesionRadiusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionRadius)).BeginInit();
            this.CohesionStrengthBox.SuspendLayout();
            this.CohesionStrengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionStrength)).BeginInit();
            this.CohesionPeripheralsBox.SuspendLayout();
            this.CohesionPeripheralsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionPeripherals)).BeginInit();
            this.BoidAvoidanceBox.SuspendLayout();
            this.BoidAvoidancePanel.SuspendLayout();
            this.BoidAvoidanceRadiusBox.SuspendLayout();
            this.BoidAvoidanceRadiusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidanceRadius)).BeginInit();
            this.BoidAvoidanceStrengthBox.SuspendLayout();
            this.BoidAvoidanceStrengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidanceStrength)).BeginInit();
            this.BoidAvoidancePeripheralsBox.SuspendLayout();
            this.BoidAvoidancePeripheralsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidancePeripherals)).BeginInit();
            this.PredatorAvoidanceBox.SuspendLayout();
            this.PredatorAvoidancePanel.SuspendLayout();
            this.PredatorAvoidanceRadiusBox.SuspendLayout();
            this.PredatorAvoidanceRadiusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidanceRadius)).BeginInit();
            this.PredatorAvoidanceStrengthBox.SuspendLayout();
            this.PredatorAvoidanceStrengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidanceStrength)).BeginInit();
            this.PredatorAvoidancePeripheralsBox.SuspendLayout();
            this.PredatorAvoidancePeripheralsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidancePeripherals)).BeginInit();
            this.ObstacleAvoidanceBox.SuspendLayout();
            this.ObstacleAvoidancePanel.SuspendLayout();
            this.ObstacleAvoidanceRadiusBox.SuspendLayout();
            this.ObstacleAvoidanceRadiusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidanceRadius)).BeginInit();
            this.ObstacleAvoidanceStrengthBox.SuspendLayout();
            this.ObstacleAvoidanceStrengthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidanceStrength)).BeginInit();
            this.ObstacleAvoidancePeripheralsBox.SuspendLayout();
            this.ObstacleAvoidancePeripheralsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidancePeripherals)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Location = new System.Drawing.Point(15, 15);
            this.glControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(1500, 1500);
            this.glControl.TabIndex = 0;
            this.glControl.VSync = false;
            // 
            // GraphicsPage
            // 
            this.GraphicsPage.Controls.Add(this.tableLayoutPanel7);
            this.GraphicsPage.Location = new System.Drawing.Point(8, 39);
            this.GraphicsPage.Name = "GraphicsPage";
            this.GraphicsPage.Padding = new System.Windows.Forms.Padding(3);
            this.GraphicsPage.Size = new System.Drawing.Size(1214, 1453);
            this.GraphicsPage.TabIndex = 3;
            this.GraphicsPage.Text = "Graphics";
            this.GraphicsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox7, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1208, 1447);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(598, 394);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Colours";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.PbxBoidColour, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.PbxPredatorColour, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.PbxObstacleColour, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.PbxBackgroundColour, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.PbxConnectionLineColour, 1, 4);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(592, 364);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Boid";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Predator";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "Obstacle";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 50);
            this.label8.TabIndex = 3;
            this.label8.Text = "Background";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 50);
            this.label9.TabIndex = 4;
            this.label9.Text = "Connection line";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PbxBoidColour
            // 
            this.PbxBoidColour.BackColor = System.Drawing.Color.White;
            this.PbxBoidColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxBoidColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxBoidColour.Location = new System.Drawing.Point(269, 3);
            this.PbxBoidColour.Name = "PbxBoidColour";
            this.PbxBoidColour.Size = new System.Drawing.Size(53, 44);
            this.PbxBoidColour.TabIndex = 5;
            this.PbxBoidColour.TabStop = false;
            this.PbxBoidColour.Click += new System.EventHandler(this.PbxBoidColour_Click);
            // 
            // PbxPredatorColour
            // 
            this.PbxPredatorColour.BackColor = System.Drawing.Color.Red;
            this.PbxPredatorColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxPredatorColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxPredatorColour.Location = new System.Drawing.Point(269, 53);
            this.PbxPredatorColour.Name = "PbxPredatorColour";
            this.PbxPredatorColour.Size = new System.Drawing.Size(53, 44);
            this.PbxPredatorColour.TabIndex = 6;
            this.PbxPredatorColour.TabStop = false;
            this.PbxPredatorColour.Click += new System.EventHandler(this.PbxPredatorColour_Click);
            // 
            // PbxObstacleColour
            // 
            this.PbxObstacleColour.BackColor = System.Drawing.Color.Orange;
            this.PbxObstacleColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxObstacleColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxObstacleColour.Location = new System.Drawing.Point(269, 103);
            this.PbxObstacleColour.Name = "PbxObstacleColour";
            this.PbxObstacleColour.Size = new System.Drawing.Size(53, 44);
            this.PbxObstacleColour.TabIndex = 7;
            this.PbxObstacleColour.TabStop = false;
            this.PbxObstacleColour.Click += new System.EventHandler(this.PbxObstacleColour_Click);
            // 
            // PbxBackgroundColour
            // 
            this.PbxBackgroundColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PbxBackgroundColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxBackgroundColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxBackgroundColour.Location = new System.Drawing.Point(269, 153);
            this.PbxBackgroundColour.Name = "PbxBackgroundColour";
            this.PbxBackgroundColour.Size = new System.Drawing.Size(53, 44);
            this.PbxBackgroundColour.TabIndex = 8;
            this.PbxBackgroundColour.TabStop = false;
            this.PbxBackgroundColour.Click += new System.EventHandler(this.PbxBackgroundColour_Click);
            // 
            // PbxConnectionLineColour
            // 
            this.PbxConnectionLineColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PbxConnectionLineColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxConnectionLineColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxConnectionLineColour.Location = new System.Drawing.Point(269, 203);
            this.PbxConnectionLineColour.Name = "PbxConnectionLineColour";
            this.PbxConnectionLineColour.Size = new System.Drawing.Size(53, 44);
            this.PbxConnectionLineColour.TabIndex = 9;
            this.PbxConnectionLineColour.TabStop = false;
            this.PbxConnectionLineColour.Click += new System.EventHandler(this.PbxConnectionLineColour_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel9);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(607, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(598, 394);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Connection Lines";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox8, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.34F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(592, 364);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel10);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(3, 69);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(586, 151);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Maximum line length";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel10.Controls.Add(this.LblMaxLineLength, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.SldMaxLineLength, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(580, 117);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // LblMaxLineLength
            // 
            this.LblMaxLineLength.AutoSize = true;
            this.LblMaxLineLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMaxLineLength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxLineLength.ForeColor = System.Drawing.Color.White;
            this.LblMaxLineLength.Location = new System.Drawing.Point(496, 0);
            this.LblMaxLineLength.Name = "LblMaxLineLength";
            this.LblMaxLineLength.Size = new System.Drawing.Size(81, 117);
            this.LblMaxLineLength.TabIndex = 0;
            this.LblMaxLineLength.Text = "0";
            this.LblMaxLineLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldMaxLineLength
            // 
            this.SldMaxLineLength.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldMaxLineLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldMaxLineLength.Enabled = false;
            this.SldMaxLineLength.Increment = 0.01D;
            this.SldMaxLineLength.LargeChange = 0.05D;
            this.SldMaxLineLength.Location = new System.Drawing.Point(3, 3);
            this.SldMaxLineLength.Maximum = 2D;
            this.SldMaxLineLength.Minimum = 0D;
            this.SldMaxLineLength.Name = "SldMaxLineLength";
            this.SldMaxLineLength.Size = new System.Drawing.Size(487, 111);
            this.SldMaxLineLength.SmallChange = 0.01D;
            this.SldMaxLineLength.TabIndex = 0;
            this.SldMaxLineLength.TickFrequency = 8;
            this.SldMaxLineLength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldMaxLineLength.Value = 0.2D;
            this.SldMaxLineLength.Scroll += new System.EventHandler(this.SldMaxLineLength_Scroll);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel11.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.ChbxConnectionLines, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(586, 42);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 42);
            this.label11.TabIndex = 0;
            this.label11.Text = "Connection lines";
            // 
            // ChbxConnectionLines
            // 
            this.ChbxConnectionLines.AutoSize = true;
            this.ChbxConnectionLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChbxConnectionLines.Location = new System.Drawing.Point(243, 3);
            this.ChbxConnectionLines.Name = "ChbxConnectionLines";
            this.ChbxConnectionLines.Size = new System.Drawing.Size(34, 36);
            this.ChbxConnectionLines.TabIndex = 1;
            this.ChbxConnectionLines.Text = "checkBox1";
            this.ChbxConnectionLines.UseVisualStyleBackColor = true;
            this.ChbxConnectionLines.CheckedChanged += new System.EventHandler(this.ChbxConnectionLines_CheckedChanged);
            // 
            // EnvironmentPage
            // 
            this.EnvironmentPage.Controls.Add(this.EnvironmentLayoutPanel);
            this.EnvironmentPage.Location = new System.Drawing.Point(8, 39);
            this.EnvironmentPage.Name = "EnvironmentPage";
            this.EnvironmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnvironmentPage.Size = new System.Drawing.Size(1214, 1453);
            this.EnvironmentPage.TabIndex = 1;
            this.EnvironmentPage.Text = "Environment";
            this.EnvironmentPage.UseVisualStyleBackColor = true;
            // 
            // EnvironmentLayoutPanel
            // 
            this.EnvironmentLayoutPanel.ColumnCount = 1;
            this.EnvironmentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnvironmentLayoutPanel.Controls.Add(this.AddBox, 0, 1);
            this.EnvironmentLayoutPanel.Controls.Add(this.groupBox5, 0, 0);
            this.EnvironmentLayoutPanel.Controls.Add(this.BtnReset, 0, 2);
            this.EnvironmentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnvironmentLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnvironmentLayoutPanel.Name = "EnvironmentLayoutPanel";
            this.EnvironmentLayoutPanel.RowCount = 4;
            this.EnvironmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.EnvironmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EnvironmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.EnvironmentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.5F));
            this.EnvironmentLayoutPanel.Size = new System.Drawing.Size(1208, 1447);
            this.EnvironmentLayoutPanel.TabIndex = 0;
            // 
            // AddBox
            // 
            this.AddBox.Controls.Add(this.RadObstacle);
            this.AddBox.Controls.Add(this.RadPredator);
            this.AddBox.Controls.Add(this.RadBoid);
            this.AddBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBox.Location = new System.Drawing.Point(3, 198);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(1202, 211);
            this.AddBox.TabIndex = 4;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "Add / Remove";
            // 
            // RadObstacle
            // 
            this.RadObstacle.AutoSize = true;
            this.RadObstacle.Location = new System.Drawing.Point(6, 143);
            this.RadObstacle.Name = "RadObstacle";
            this.RadObstacle.Size = new System.Drawing.Size(128, 29);
            this.RadObstacle.TabIndex = 2;
            this.RadObstacle.Text = "Obstacle";
            this.RadObstacle.UseVisualStyleBackColor = true;
            this.RadObstacle.CheckedChanged += new System.EventHandler(this.RadObstacle_CheckedChanged);
            // 
            // RadPredator
            // 
            this.RadPredator.AutoSize = true;
            this.RadPredator.Location = new System.Drawing.Point(6, 100);
            this.RadPredator.Name = "RadPredator";
            this.RadPredator.Size = new System.Drawing.Size(125, 29);
            this.RadPredator.TabIndex = 1;
            this.RadPredator.Text = "Predator";
            this.RadPredator.UseVisualStyleBackColor = true;
            this.RadPredator.CheckedChanged += new System.EventHandler(this.RadPredator_CheckedChanged);
            // 
            // RadBoid
            // 
            this.RadBoid.AutoSize = true;
            this.RadBoid.Checked = true;
            this.RadBoid.Location = new System.Drawing.Point(6, 57);
            this.RadBoid.Name = "RadBoid";
            this.RadBoid.Size = new System.Drawing.Size(86, 29);
            this.RadBoid.TabIndex = 0;
            this.RadBoid.TabStop = true;
            this.RadBoid.Text = "Boid";
            this.RadBoid.UseVisualStyleBackColor = true;
            this.RadBoid.CheckedChanged += new System.EventHandler(this.RadBoid_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel5);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1202, 189);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "General Options";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1196, 155);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel12);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(592, 149);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Maximum Speed";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel12.Controls.Add(this.LblMaxSpeed, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.SldMaxSpeed, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(586, 115);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // LblMaxSpeed
            // 
            this.LblMaxSpeed.AutoSize = true;
            this.LblMaxSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMaxSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxSpeed.ForeColor = System.Drawing.Color.White;
            this.LblMaxSpeed.Location = new System.Drawing.Point(501, 0);
            this.LblMaxSpeed.Name = "LblMaxSpeed";
            this.LblMaxSpeed.Size = new System.Drawing.Size(82, 115);
            this.LblMaxSpeed.TabIndex = 0;
            this.LblMaxSpeed.Text = "0";
            this.LblMaxSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldMaxSpeed
            // 
            this.SldMaxSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldMaxSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldMaxSpeed.Increment = 0.01D;
            this.SldMaxSpeed.LargeChange = 0.05D;
            this.SldMaxSpeed.Location = new System.Drawing.Point(3, 3);
            this.SldMaxSpeed.Maximum = 2D;
            this.SldMaxSpeed.Minimum = 0D;
            this.SldMaxSpeed.Name = "SldMaxSpeed";
            this.SldMaxSpeed.Size = new System.Drawing.Size(492, 109);
            this.SldMaxSpeed.SmallChange = 0.01D;
            this.SldMaxSpeed.TabIndex = 0;
            this.SldMaxSpeed.TickFrequency = 8;
            this.SldMaxSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldMaxSpeed.Value = 0.46D;
            this.SldMaxSpeed.Scroll += new System.EventHandler(this.SldMaxSpeed_Scroll);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Firebrick;
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReset.Location = new System.Drawing.Point(3, 415);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(262, 71);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BoidPage
            // 
            this.BoidPage.Controls.Add(this.BoidPropertiesPanel);
            this.BoidPage.Location = new System.Drawing.Point(8, 39);
            this.BoidPage.Name = "BoidPage";
            this.BoidPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoidPage.Size = new System.Drawing.Size(1214, 1453);
            this.BoidPage.TabIndex = 0;
            this.BoidPage.Text = "Boid";
            this.BoidPage.UseVisualStyleBackColor = true;
            // 
            // BoidPropertiesPanel
            // 
            this.BoidPropertiesPanel.ColumnCount = 2;
            this.BoidPropertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BoidPropertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BoidPropertiesPanel.Controls.Add(this.AlignmentBox, 0, 0);
            this.BoidPropertiesPanel.Controls.Add(this.CohesionBox, 1, 0);
            this.BoidPropertiesPanel.Controls.Add(this.BoidAvoidanceBox, 0, 1);
            this.BoidPropertiesPanel.Controls.Add(this.PredatorAvoidanceBox, 1, 1);
            this.BoidPropertiesPanel.Controls.Add(this.ObstacleAvoidanceBox, 0, 2);
            this.BoidPropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidPropertiesPanel.Location = new System.Drawing.Point(3, 3);
            this.BoidPropertiesPanel.Name = "BoidPropertiesPanel";
            this.BoidPropertiesPanel.RowCount = 3;
            this.BoidPropertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidPropertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidPropertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidPropertiesPanel.Size = new System.Drawing.Size(1208, 1447);
            this.BoidPropertiesPanel.TabIndex = 0;
            // 
            // AlignmentBox
            // 
            this.AlignmentBox.Controls.Add(this.AlignmentPanel);
            this.AlignmentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentBox.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentBox.Location = new System.Drawing.Point(3, 3);
            this.AlignmentBox.Name = "AlignmentBox";
            this.AlignmentBox.Size = new System.Drawing.Size(598, 476);
            this.AlignmentBox.TabIndex = 0;
            this.AlignmentBox.TabStop = false;
            this.AlignmentBox.Text = "Alignment";
            // 
            // AlignmentPanel
            // 
            this.AlignmentPanel.ColumnCount = 1;
            this.AlignmentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.AlignmentPanel.Controls.Add(this.AlignmentRadiusBox, 0, 0);
            this.AlignmentPanel.Controls.Add(this.AlignmentStrengthBox, 0, 1);
            this.AlignmentPanel.Controls.Add(this.AlignmentPeripheralsBox, 0, 2);
            this.AlignmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentPanel.Location = new System.Drawing.Point(3, 31);
            this.AlignmentPanel.Name = "AlignmentPanel";
            this.AlignmentPanel.RowCount = 3;
            this.AlignmentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AlignmentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AlignmentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AlignmentPanel.Size = new System.Drawing.Size(592, 442);
            this.AlignmentPanel.TabIndex = 0;
            // 
            // AlignmentRadiusBox
            // 
            this.AlignmentRadiusBox.Controls.Add(this.AlignmentRadiusPanel);
            this.AlignmentRadiusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentRadiusBox.Location = new System.Drawing.Point(3, 3);
            this.AlignmentRadiusBox.Name = "AlignmentRadiusBox";
            this.AlignmentRadiusBox.Size = new System.Drawing.Size(586, 141);
            this.AlignmentRadiusBox.TabIndex = 0;
            this.AlignmentRadiusBox.TabStop = false;
            this.AlignmentRadiusBox.Text = "Radius";
            // 
            // AlignmentRadiusPanel
            // 
            this.AlignmentRadiusPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.AlignmentRadiusPanel.ColumnCount = 2;
            this.AlignmentRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.AlignmentRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AlignmentRadiusPanel.Controls.Add(this.LblAlignmentRadius, 1, 0);
            this.AlignmentRadiusPanel.Controls.Add(this.SldAlignmentRadius, 0, 0);
            this.AlignmentRadiusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentRadiusPanel.Location = new System.Drawing.Point(3, 31);
            this.AlignmentRadiusPanel.Name = "AlignmentRadiusPanel";
            this.AlignmentRadiusPanel.RowCount = 1;
            this.AlignmentRadiusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlignmentRadiusPanel.Size = new System.Drawing.Size(580, 107);
            this.AlignmentRadiusPanel.TabIndex = 0;
            // 
            // LblAlignmentRadius
            // 
            this.LblAlignmentRadius.AutoSize = true;
            this.LblAlignmentRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAlignmentRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlignmentRadius.ForeColor = System.Drawing.Color.White;
            this.LblAlignmentRadius.Location = new System.Drawing.Point(496, 0);
            this.LblAlignmentRadius.Name = "LblAlignmentRadius";
            this.LblAlignmentRadius.Size = new System.Drawing.Size(81, 107);
            this.LblAlignmentRadius.TabIndex = 0;
            this.LblAlignmentRadius.Text = "0";
            this.LblAlignmentRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldAlignmentRadius
            // 
            this.SldAlignmentRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldAlignmentRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldAlignmentRadius.Increment = 0.01D;
            this.SldAlignmentRadius.LargeChange = 0.05D;
            this.SldAlignmentRadius.Location = new System.Drawing.Point(3, 3);
            this.SldAlignmentRadius.Maximum = 2D;
            this.SldAlignmentRadius.Minimum = 0D;
            this.SldAlignmentRadius.Name = "SldAlignmentRadius";
            this.SldAlignmentRadius.Size = new System.Drawing.Size(487, 101);
            this.SldAlignmentRadius.SmallChange = 0.01D;
            this.SldAlignmentRadius.TabIndex = 0;
            this.SldAlignmentRadius.TickFrequency = 8;
            this.SldAlignmentRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldAlignmentRadius.Value = 0.15D;
            this.SldAlignmentRadius.Scroll += new System.EventHandler(this.SldAlignmentRadius_Scroll);
            // 
            // AlignmentStrengthBox
            // 
            this.AlignmentStrengthBox.Controls.Add(this.AlignmentStrengthPanel);
            this.AlignmentStrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentStrengthBox.Location = new System.Drawing.Point(3, 150);
            this.AlignmentStrengthBox.Name = "AlignmentStrengthBox";
            this.AlignmentStrengthBox.Size = new System.Drawing.Size(586, 141);
            this.AlignmentStrengthBox.TabIndex = 1;
            this.AlignmentStrengthBox.TabStop = false;
            this.AlignmentStrengthBox.Text = "Strength";
            // 
            // AlignmentStrengthPanel
            // 
            this.AlignmentStrengthPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.AlignmentStrengthPanel.ColumnCount = 2;
            this.AlignmentStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.AlignmentStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AlignmentStrengthPanel.Controls.Add(this.LblAlignmentStrength, 1, 0);
            this.AlignmentStrengthPanel.Controls.Add(this.SldAlignmentStrength, 0, 0);
            this.AlignmentStrengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentStrengthPanel.Location = new System.Drawing.Point(3, 31);
            this.AlignmentStrengthPanel.Name = "AlignmentStrengthPanel";
            this.AlignmentStrengthPanel.RowCount = 1;
            this.AlignmentStrengthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlignmentStrengthPanel.Size = new System.Drawing.Size(580, 107);
            this.AlignmentStrengthPanel.TabIndex = 1;
            // 
            // LblAlignmentStrength
            // 
            this.LblAlignmentStrength.AutoSize = true;
            this.LblAlignmentStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAlignmentStrength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlignmentStrength.ForeColor = System.Drawing.Color.White;
            this.LblAlignmentStrength.Location = new System.Drawing.Point(496, 0);
            this.LblAlignmentStrength.Name = "LblAlignmentStrength";
            this.LblAlignmentStrength.Size = new System.Drawing.Size(81, 107);
            this.LblAlignmentStrength.TabIndex = 0;
            this.LblAlignmentStrength.Text = "0";
            this.LblAlignmentStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldAlignmentStrength
            // 
            this.SldAlignmentStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldAlignmentStrength.Increment = 0.01D;
            this.SldAlignmentStrength.LargeChange = 0.05D;
            this.SldAlignmentStrength.Location = new System.Drawing.Point(3, 3);
            this.SldAlignmentStrength.Maximum = 2D;
            this.SldAlignmentStrength.Minimum = 0D;
            this.SldAlignmentStrength.Name = "SldAlignmentStrength";
            this.SldAlignmentStrength.Size = new System.Drawing.Size(487, 101);
            this.SldAlignmentStrength.SmallChange = 0.01D;
            this.SldAlignmentStrength.TabIndex = 1;
            this.SldAlignmentStrength.TickFrequency = 8;
            this.SldAlignmentStrength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldAlignmentStrength.Value = 0.6D;
            this.SldAlignmentStrength.Scroll += new System.EventHandler(this.SldAlignmentStrength_Scroll);
            // 
            // AlignmentPeripheralsBox
            // 
            this.AlignmentPeripheralsBox.Controls.Add(this.AlignmentPeripheralsPanel);
            this.AlignmentPeripheralsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentPeripheralsBox.Location = new System.Drawing.Point(3, 297);
            this.AlignmentPeripheralsBox.Name = "AlignmentPeripheralsBox";
            this.AlignmentPeripheralsBox.Size = new System.Drawing.Size(586, 142);
            this.AlignmentPeripheralsBox.TabIndex = 2;
            this.AlignmentPeripheralsBox.TabStop = false;
            this.AlignmentPeripheralsBox.Text = "Peripheral Vision";
            // 
            // AlignmentPeripheralsPanel
            // 
            this.AlignmentPeripheralsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.AlignmentPeripheralsPanel.ColumnCount = 2;
            this.AlignmentPeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.AlignmentPeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.AlignmentPeripheralsPanel.Controls.Add(this.LblAlignmentPeripherals, 1, 0);
            this.AlignmentPeripheralsPanel.Controls.Add(this.SldAlignmentPeripherals, 0, 0);
            this.AlignmentPeripheralsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentPeripheralsPanel.Location = new System.Drawing.Point(3, 31);
            this.AlignmentPeripheralsPanel.Name = "AlignmentPeripheralsPanel";
            this.AlignmentPeripheralsPanel.RowCount = 1;
            this.AlignmentPeripheralsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AlignmentPeripheralsPanel.Size = new System.Drawing.Size(580, 108);
            this.AlignmentPeripheralsPanel.TabIndex = 1;
            // 
            // LblAlignmentPeripherals
            // 
            this.LblAlignmentPeripherals.AutoSize = true;
            this.LblAlignmentPeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblAlignmentPeripherals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlignmentPeripherals.ForeColor = System.Drawing.Color.White;
            this.LblAlignmentPeripherals.Location = new System.Drawing.Point(496, 0);
            this.LblAlignmentPeripherals.Name = "LblAlignmentPeripherals";
            this.LblAlignmentPeripherals.Size = new System.Drawing.Size(81, 108);
            this.LblAlignmentPeripherals.TabIndex = 0;
            this.LblAlignmentPeripherals.Text = "0";
            this.LblAlignmentPeripherals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldAlignmentPeripherals
            // 
            this.SldAlignmentPeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldAlignmentPeripherals.Increment = 0.01D;
            this.SldAlignmentPeripherals.LargeChange = 0.05D;
            this.SldAlignmentPeripherals.Location = new System.Drawing.Point(3, 3);
            this.SldAlignmentPeripherals.Maximum = 6.3D;
            this.SldAlignmentPeripherals.Minimum = 0D;
            this.SldAlignmentPeripherals.Name = "SldAlignmentPeripherals";
            this.SldAlignmentPeripherals.Size = new System.Drawing.Size(487, 102);
            this.SldAlignmentPeripherals.SmallChange = 0.01D;
            this.SldAlignmentPeripherals.TabIndex = 1;
            this.SldAlignmentPeripherals.TickFrequency = 30;
            this.SldAlignmentPeripherals.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldAlignmentPeripherals.Value = 6.3D;
            this.SldAlignmentPeripherals.Scroll += new System.EventHandler(this.SldAlignmentPeripherals_Scroll);
            // 
            // CohesionBox
            // 
            this.CohesionBox.Controls.Add(this.CohesionPanel);
            this.CohesionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionBox.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CohesionBox.Location = new System.Drawing.Point(607, 3);
            this.CohesionBox.Name = "CohesionBox";
            this.CohesionBox.Size = new System.Drawing.Size(598, 476);
            this.CohesionBox.TabIndex = 1;
            this.CohesionBox.TabStop = false;
            this.CohesionBox.Text = "Cohesion";
            // 
            // CohesionPanel
            // 
            this.CohesionPanel.ColumnCount = 1;
            this.CohesionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.CohesionPanel.Controls.Add(this.CohesionRadiusBox, 0, 0);
            this.CohesionPanel.Controls.Add(this.CohesionStrengthBox, 0, 1);
            this.CohesionPanel.Controls.Add(this.CohesionPeripheralsBox, 0, 2);
            this.CohesionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionPanel.Location = new System.Drawing.Point(3, 31);
            this.CohesionPanel.Name = "CohesionPanel";
            this.CohesionPanel.RowCount = 3;
            this.CohesionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CohesionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CohesionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CohesionPanel.Size = new System.Drawing.Size(592, 442);
            this.CohesionPanel.TabIndex = 1;
            // 
            // CohesionRadiusBox
            // 
            this.CohesionRadiusBox.Controls.Add(this.CohesionRadiusPanel);
            this.CohesionRadiusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionRadiusBox.Location = new System.Drawing.Point(3, 3);
            this.CohesionRadiusBox.Name = "CohesionRadiusBox";
            this.CohesionRadiusBox.Size = new System.Drawing.Size(586, 141);
            this.CohesionRadiusBox.TabIndex = 0;
            this.CohesionRadiusBox.TabStop = false;
            this.CohesionRadiusBox.Text = "Radius";
            // 
            // CohesionRadiusPanel
            // 
            this.CohesionRadiusPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.CohesionRadiusPanel.ColumnCount = 2;
            this.CohesionRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.CohesionRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CohesionRadiusPanel.Controls.Add(this.LblCohesionRadius, 1, 0);
            this.CohesionRadiusPanel.Controls.Add(this.SldCohesionRadius, 0, 0);
            this.CohesionRadiusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionRadiusPanel.Location = new System.Drawing.Point(3, 31);
            this.CohesionRadiusPanel.Name = "CohesionRadiusPanel";
            this.CohesionRadiusPanel.RowCount = 1;
            this.CohesionRadiusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CohesionRadiusPanel.Size = new System.Drawing.Size(580, 107);
            this.CohesionRadiusPanel.TabIndex = 0;
            // 
            // LblCohesionRadius
            // 
            this.LblCohesionRadius.AutoSize = true;
            this.LblCohesionRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCohesionRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCohesionRadius.ForeColor = System.Drawing.Color.White;
            this.LblCohesionRadius.Location = new System.Drawing.Point(496, 0);
            this.LblCohesionRadius.Name = "LblCohesionRadius";
            this.LblCohesionRadius.Size = new System.Drawing.Size(81, 107);
            this.LblCohesionRadius.TabIndex = 0;
            this.LblCohesionRadius.Text = "0";
            this.LblCohesionRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldCohesionRadius
            // 
            this.SldCohesionRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldCohesionRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldCohesionRadius.Increment = 0.01D;
            this.SldCohesionRadius.LargeChange = 0.05D;
            this.SldCohesionRadius.Location = new System.Drawing.Point(3, 3);
            this.SldCohesionRadius.Maximum = 2D;
            this.SldCohesionRadius.Minimum = 0D;
            this.SldCohesionRadius.Name = "SldCohesionRadius";
            this.SldCohesionRadius.Size = new System.Drawing.Size(487, 101);
            this.SldCohesionRadius.SmallChange = 0.01D;
            this.SldCohesionRadius.TabIndex = 0;
            this.SldCohesionRadius.TickFrequency = 8;
            this.SldCohesionRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldCohesionRadius.Value = 0.38D;
            this.SldCohesionRadius.Scroll += new System.EventHandler(this.SldCohesionRadius_Scroll);
            // 
            // CohesionStrengthBox
            // 
            this.CohesionStrengthBox.Controls.Add(this.CohesionStrengthPanel);
            this.CohesionStrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionStrengthBox.Location = new System.Drawing.Point(3, 150);
            this.CohesionStrengthBox.Name = "CohesionStrengthBox";
            this.CohesionStrengthBox.Size = new System.Drawing.Size(586, 141);
            this.CohesionStrengthBox.TabIndex = 1;
            this.CohesionStrengthBox.TabStop = false;
            this.CohesionStrengthBox.Text = "Strength";
            // 
            // CohesionStrengthPanel
            // 
            this.CohesionStrengthPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.CohesionStrengthPanel.ColumnCount = 2;
            this.CohesionStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.CohesionStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CohesionStrengthPanel.Controls.Add(this.LblCohesionStrength, 1, 0);
            this.CohesionStrengthPanel.Controls.Add(this.SldCohesionStrength, 0, 0);
            this.CohesionStrengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionStrengthPanel.Location = new System.Drawing.Point(3, 31);
            this.CohesionStrengthPanel.Name = "CohesionStrengthPanel";
            this.CohesionStrengthPanel.RowCount = 1;
            this.CohesionStrengthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CohesionStrengthPanel.Size = new System.Drawing.Size(580, 107);
            this.CohesionStrengthPanel.TabIndex = 1;
            // 
            // LblCohesionStrength
            // 
            this.LblCohesionStrength.AutoSize = true;
            this.LblCohesionStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCohesionStrength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCohesionStrength.ForeColor = System.Drawing.Color.White;
            this.LblCohesionStrength.Location = new System.Drawing.Point(496, 0);
            this.LblCohesionStrength.Name = "LblCohesionStrength";
            this.LblCohesionStrength.Size = new System.Drawing.Size(81, 107);
            this.LblCohesionStrength.TabIndex = 0;
            this.LblCohesionStrength.Text = "0";
            this.LblCohesionStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldCohesionStrength
            // 
            this.SldCohesionStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldCohesionStrength.Increment = 0.01D;
            this.SldCohesionStrength.LargeChange = 0.05D;
            this.SldCohesionStrength.Location = new System.Drawing.Point(3, 3);
            this.SldCohesionStrength.Maximum = 2D;
            this.SldCohesionStrength.Minimum = 0D;
            this.SldCohesionStrength.Name = "SldCohesionStrength";
            this.SldCohesionStrength.Size = new System.Drawing.Size(487, 101);
            this.SldCohesionStrength.SmallChange = 0.01D;
            this.SldCohesionStrength.TabIndex = 1;
            this.SldCohesionStrength.TickFrequency = 8;
            this.SldCohesionStrength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldCohesionStrength.Value = 1D;
            this.SldCohesionStrength.Scroll += new System.EventHandler(this.SldCohesionStrength_Scroll);
            // 
            // CohesionPeripheralsBox
            // 
            this.CohesionPeripheralsBox.Controls.Add(this.CohesionPeripheralsPanel);
            this.CohesionPeripheralsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionPeripheralsBox.Location = new System.Drawing.Point(3, 297);
            this.CohesionPeripheralsBox.Name = "CohesionPeripheralsBox";
            this.CohesionPeripheralsBox.Size = new System.Drawing.Size(586, 142);
            this.CohesionPeripheralsBox.TabIndex = 2;
            this.CohesionPeripheralsBox.TabStop = false;
            this.CohesionPeripheralsBox.Text = "Peripheral Vision";
            // 
            // CohesionPeripheralsPanel
            // 
            this.CohesionPeripheralsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.CohesionPeripheralsPanel.ColumnCount = 2;
            this.CohesionPeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.CohesionPeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.CohesionPeripheralsPanel.Controls.Add(this.LblCohesionPeripherals, 1, 0);
            this.CohesionPeripheralsPanel.Controls.Add(this.SldCohesionPeripherals, 0, 0);
            this.CohesionPeripheralsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CohesionPeripheralsPanel.Location = new System.Drawing.Point(3, 31);
            this.CohesionPeripheralsPanel.Name = "CohesionPeripheralsPanel";
            this.CohesionPeripheralsPanel.RowCount = 1;
            this.CohesionPeripheralsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CohesionPeripheralsPanel.Size = new System.Drawing.Size(580, 108);
            this.CohesionPeripheralsPanel.TabIndex = 1;
            // 
            // LblCohesionPeripherals
            // 
            this.LblCohesionPeripherals.AutoSize = true;
            this.LblCohesionPeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCohesionPeripherals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCohesionPeripherals.ForeColor = System.Drawing.Color.White;
            this.LblCohesionPeripherals.Location = new System.Drawing.Point(496, 0);
            this.LblCohesionPeripherals.Name = "LblCohesionPeripherals";
            this.LblCohesionPeripherals.Size = new System.Drawing.Size(81, 108);
            this.LblCohesionPeripherals.TabIndex = 0;
            this.LblCohesionPeripherals.Text = "0";
            this.LblCohesionPeripherals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldCohesionPeripherals
            // 
            this.SldCohesionPeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldCohesionPeripherals.Increment = 0.01D;
            this.SldCohesionPeripherals.LargeChange = 0.05D;
            this.SldCohesionPeripherals.Location = new System.Drawing.Point(3, 3);
            this.SldCohesionPeripherals.Maximum = 6.3D;
            this.SldCohesionPeripherals.Minimum = 0D;
            this.SldCohesionPeripherals.Name = "SldCohesionPeripherals";
            this.SldCohesionPeripherals.Size = new System.Drawing.Size(487, 102);
            this.SldCohesionPeripherals.SmallChange = 0.01D;
            this.SldCohesionPeripherals.TabIndex = 1;
            this.SldCohesionPeripherals.TickFrequency = 30;
            this.SldCohesionPeripherals.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldCohesionPeripherals.Value = 6.3D;
            this.SldCohesionPeripherals.Scroll += new System.EventHandler(this.SldCohesionPeripherals_Scroll);
            // 
            // BoidAvoidanceBox
            // 
            this.BoidAvoidanceBox.Controls.Add(this.BoidAvoidancePanel);
            this.BoidAvoidanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidanceBox.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoidAvoidanceBox.Location = new System.Drawing.Point(3, 485);
            this.BoidAvoidanceBox.Name = "BoidAvoidanceBox";
            this.BoidAvoidanceBox.Size = new System.Drawing.Size(598, 476);
            this.BoidAvoidanceBox.TabIndex = 2;
            this.BoidAvoidanceBox.TabStop = false;
            this.BoidAvoidanceBox.Text = "Boid Avoidance";
            // 
            // BoidAvoidancePanel
            // 
            this.BoidAvoidancePanel.ColumnCount = 1;
            this.BoidAvoidancePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BoidAvoidancePanel.Controls.Add(this.BoidAvoidanceRadiusBox, 0, 0);
            this.BoidAvoidancePanel.Controls.Add(this.BoidAvoidanceStrengthBox, 0, 1);
            this.BoidAvoidancePanel.Controls.Add(this.BoidAvoidancePeripheralsBox, 0, 2);
            this.BoidAvoidancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidancePanel.Location = new System.Drawing.Point(3, 31);
            this.BoidAvoidancePanel.Name = "BoidAvoidancePanel";
            this.BoidAvoidancePanel.RowCount = 3;
            this.BoidAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.BoidAvoidancePanel.Size = new System.Drawing.Size(592, 442);
            this.BoidAvoidancePanel.TabIndex = 1;
            // 
            // BoidAvoidanceRadiusBox
            // 
            this.BoidAvoidanceRadiusBox.Controls.Add(this.BoidAvoidanceRadiusPanel);
            this.BoidAvoidanceRadiusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidanceRadiusBox.Location = new System.Drawing.Point(3, 3);
            this.BoidAvoidanceRadiusBox.Name = "BoidAvoidanceRadiusBox";
            this.BoidAvoidanceRadiusBox.Size = new System.Drawing.Size(586, 141);
            this.BoidAvoidanceRadiusBox.TabIndex = 0;
            this.BoidAvoidanceRadiusBox.TabStop = false;
            this.BoidAvoidanceRadiusBox.Text = "Radius";
            // 
            // BoidAvoidanceRadiusPanel
            // 
            this.BoidAvoidanceRadiusPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.BoidAvoidanceRadiusPanel.ColumnCount = 2;
            this.BoidAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BoidAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BoidAvoidanceRadiusPanel.Controls.Add(this.LblBoidAvoidanceRadius, 1, 0);
            this.BoidAvoidanceRadiusPanel.Controls.Add(this.SldBoidAvoidanceRadius, 0, 0);
            this.BoidAvoidanceRadiusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidanceRadiusPanel.Location = new System.Drawing.Point(3, 31);
            this.BoidAvoidanceRadiusPanel.Name = "BoidAvoidanceRadiusPanel";
            this.BoidAvoidanceRadiusPanel.RowCount = 1;
            this.BoidAvoidanceRadiusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoidAvoidanceRadiusPanel.Size = new System.Drawing.Size(580, 107);
            this.BoidAvoidanceRadiusPanel.TabIndex = 0;
            // 
            // LblBoidAvoidanceRadius
            // 
            this.LblBoidAvoidanceRadius.AutoSize = true;
            this.LblBoidAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBoidAvoidanceRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoidAvoidanceRadius.ForeColor = System.Drawing.Color.White;
            this.LblBoidAvoidanceRadius.Location = new System.Drawing.Point(496, 0);
            this.LblBoidAvoidanceRadius.Name = "LblBoidAvoidanceRadius";
            this.LblBoidAvoidanceRadius.Size = new System.Drawing.Size(81, 107);
            this.LblBoidAvoidanceRadius.TabIndex = 0;
            this.LblBoidAvoidanceRadius.Text = "0";
            this.LblBoidAvoidanceRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldBoidAvoidanceRadius
            // 
            this.SldBoidAvoidanceRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldBoidAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldBoidAvoidanceRadius.Increment = 0.01D;
            this.SldBoidAvoidanceRadius.LargeChange = 0.05D;
            this.SldBoidAvoidanceRadius.Location = new System.Drawing.Point(3, 3);
            this.SldBoidAvoidanceRadius.Maximum = 2D;
            this.SldBoidAvoidanceRadius.Minimum = 0D;
            this.SldBoidAvoidanceRadius.Name = "SldBoidAvoidanceRadius";
            this.SldBoidAvoidanceRadius.Size = new System.Drawing.Size(487, 101);
            this.SldBoidAvoidanceRadius.SmallChange = 0.01D;
            this.SldBoidAvoidanceRadius.TabIndex = 0;
            this.SldBoidAvoidanceRadius.TickFrequency = 8;
            this.SldBoidAvoidanceRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldBoidAvoidanceRadius.Value = 0.1D;
            this.SldBoidAvoidanceRadius.Scroll += new System.EventHandler(this.SldBoidAvoidanceRadius_Scroll);
            // 
            // BoidAvoidanceStrengthBox
            // 
            this.BoidAvoidanceStrengthBox.Controls.Add(this.BoidAvoidanceStrengthPanel);
            this.BoidAvoidanceStrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidanceStrengthBox.Location = new System.Drawing.Point(3, 150);
            this.BoidAvoidanceStrengthBox.Name = "BoidAvoidanceStrengthBox";
            this.BoidAvoidanceStrengthBox.Size = new System.Drawing.Size(586, 141);
            this.BoidAvoidanceStrengthBox.TabIndex = 1;
            this.BoidAvoidanceStrengthBox.TabStop = false;
            this.BoidAvoidanceStrengthBox.Text = "Strength";
            // 
            // BoidAvoidanceStrengthPanel
            // 
            this.BoidAvoidanceStrengthPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.BoidAvoidanceStrengthPanel.ColumnCount = 2;
            this.BoidAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BoidAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BoidAvoidanceStrengthPanel.Controls.Add(this.LblBoidAvoidanceStrength, 1, 0);
            this.BoidAvoidanceStrengthPanel.Controls.Add(this.SldBoidAvoidanceStrength, 0, 0);
            this.BoidAvoidanceStrengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidanceStrengthPanel.Location = new System.Drawing.Point(3, 31);
            this.BoidAvoidanceStrengthPanel.Name = "BoidAvoidanceStrengthPanel";
            this.BoidAvoidanceStrengthPanel.RowCount = 1;
            this.BoidAvoidanceStrengthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoidAvoidanceStrengthPanel.Size = new System.Drawing.Size(580, 107);
            this.BoidAvoidanceStrengthPanel.TabIndex = 1;
            // 
            // LblBoidAvoidanceStrength
            // 
            this.LblBoidAvoidanceStrength.AutoSize = true;
            this.LblBoidAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBoidAvoidanceStrength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoidAvoidanceStrength.ForeColor = System.Drawing.Color.White;
            this.LblBoidAvoidanceStrength.Location = new System.Drawing.Point(496, 0);
            this.LblBoidAvoidanceStrength.Name = "LblBoidAvoidanceStrength";
            this.LblBoidAvoidanceStrength.Size = new System.Drawing.Size(81, 107);
            this.LblBoidAvoidanceStrength.TabIndex = 0;
            this.LblBoidAvoidanceStrength.Text = "0";
            this.LblBoidAvoidanceStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldBoidAvoidanceStrength
            // 
            this.SldBoidAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldBoidAvoidanceStrength.Increment = 0.01D;
            this.SldBoidAvoidanceStrength.LargeChange = 0.05D;
            this.SldBoidAvoidanceStrength.Location = new System.Drawing.Point(3, 3);
            this.SldBoidAvoidanceStrength.Maximum = 2D;
            this.SldBoidAvoidanceStrength.Minimum = 0D;
            this.SldBoidAvoidanceStrength.Name = "SldBoidAvoidanceStrength";
            this.SldBoidAvoidanceStrength.Size = new System.Drawing.Size(487, 101);
            this.SldBoidAvoidanceStrength.SmallChange = 0.01D;
            this.SldBoidAvoidanceStrength.TabIndex = 1;
            this.SldBoidAvoidanceStrength.TickFrequency = 8;
            this.SldBoidAvoidanceStrength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldBoidAvoidanceStrength.Value = 1.14D;
            this.SldBoidAvoidanceStrength.Scroll += new System.EventHandler(this.SldBoidAvoidanceStrength_Scroll);
            // 
            // BoidAvoidancePeripheralsBox
            // 
            this.BoidAvoidancePeripheralsBox.Controls.Add(this.BoidAvoidancePeripheralsPanel);
            this.BoidAvoidancePeripheralsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidancePeripheralsBox.Location = new System.Drawing.Point(3, 297);
            this.BoidAvoidancePeripheralsBox.Name = "BoidAvoidancePeripheralsBox";
            this.BoidAvoidancePeripheralsBox.Size = new System.Drawing.Size(586, 142);
            this.BoidAvoidancePeripheralsBox.TabIndex = 2;
            this.BoidAvoidancePeripheralsBox.TabStop = false;
            this.BoidAvoidancePeripheralsBox.Text = "Peripheral Vision";
            // 
            // BoidAvoidancePeripheralsPanel
            // 
            this.BoidAvoidancePeripheralsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.BoidAvoidancePeripheralsPanel.ColumnCount = 2;
            this.BoidAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.BoidAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.BoidAvoidancePeripheralsPanel.Controls.Add(this.LblBoidAvoidancePeripherals, 1, 0);
            this.BoidAvoidancePeripheralsPanel.Controls.Add(this.SldBoidAvoidancePeripherals, 0, 0);
            this.BoidAvoidancePeripheralsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoidAvoidancePeripheralsPanel.Location = new System.Drawing.Point(3, 31);
            this.BoidAvoidancePeripheralsPanel.Name = "BoidAvoidancePeripheralsPanel";
            this.BoidAvoidancePeripheralsPanel.RowCount = 1;
            this.BoidAvoidancePeripheralsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BoidAvoidancePeripheralsPanel.Size = new System.Drawing.Size(580, 108);
            this.BoidAvoidancePeripheralsPanel.TabIndex = 1;
            // 
            // LblBoidAvoidancePeripherals
            // 
            this.LblBoidAvoidancePeripherals.AutoSize = true;
            this.LblBoidAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBoidAvoidancePeripherals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBoidAvoidancePeripherals.ForeColor = System.Drawing.Color.White;
            this.LblBoidAvoidancePeripherals.Location = new System.Drawing.Point(496, 0);
            this.LblBoidAvoidancePeripherals.Name = "LblBoidAvoidancePeripherals";
            this.LblBoidAvoidancePeripherals.Size = new System.Drawing.Size(81, 108);
            this.LblBoidAvoidancePeripherals.TabIndex = 0;
            this.LblBoidAvoidancePeripherals.Text = "0";
            this.LblBoidAvoidancePeripherals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldBoidAvoidancePeripherals
            // 
            this.SldBoidAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldBoidAvoidancePeripherals.Increment = 0.01D;
            this.SldBoidAvoidancePeripherals.LargeChange = 0.05D;
            this.SldBoidAvoidancePeripherals.Location = new System.Drawing.Point(3, 3);
            this.SldBoidAvoidancePeripherals.Maximum = 6.3D;
            this.SldBoidAvoidancePeripherals.Minimum = 0D;
            this.SldBoidAvoidancePeripherals.Name = "SldBoidAvoidancePeripherals";
            this.SldBoidAvoidancePeripherals.Size = new System.Drawing.Size(487, 102);
            this.SldBoidAvoidancePeripherals.SmallChange = 0.01D;
            this.SldBoidAvoidancePeripherals.TabIndex = 1;
            this.SldBoidAvoidancePeripherals.TickFrequency = 30;
            this.SldBoidAvoidancePeripherals.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldBoidAvoidancePeripherals.Value = 6.3D;
            this.SldBoidAvoidancePeripherals.Scroll += new System.EventHandler(this.SldBoidAvoidancePeripherals_Scroll);
            // 
            // PredatorAvoidanceBox
            // 
            this.PredatorAvoidanceBox.Controls.Add(this.PredatorAvoidancePanel);
            this.PredatorAvoidanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidanceBox.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredatorAvoidanceBox.Location = new System.Drawing.Point(607, 485);
            this.PredatorAvoidanceBox.Name = "PredatorAvoidanceBox";
            this.PredatorAvoidanceBox.Size = new System.Drawing.Size(598, 476);
            this.PredatorAvoidanceBox.TabIndex = 3;
            this.PredatorAvoidanceBox.TabStop = false;
            this.PredatorAvoidanceBox.Text = "Predator Avoidance";
            // 
            // PredatorAvoidancePanel
            // 
            this.PredatorAvoidancePanel.ColumnCount = 1;
            this.PredatorAvoidancePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PredatorAvoidancePanel.Controls.Add(this.PredatorAvoidanceRadiusBox, 0, 0);
            this.PredatorAvoidancePanel.Controls.Add(this.PredatorAvoidanceStrengthBox, 0, 1);
            this.PredatorAvoidancePanel.Controls.Add(this.PredatorAvoidancePeripheralsBox, 0, 2);
            this.PredatorAvoidancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidancePanel.Location = new System.Drawing.Point(3, 31);
            this.PredatorAvoidancePanel.Name = "PredatorAvoidancePanel";
            this.PredatorAvoidancePanel.RowCount = 3;
            this.PredatorAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PredatorAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PredatorAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PredatorAvoidancePanel.Size = new System.Drawing.Size(592, 442);
            this.PredatorAvoidancePanel.TabIndex = 1;
            // 
            // PredatorAvoidanceRadiusBox
            // 
            this.PredatorAvoidanceRadiusBox.Controls.Add(this.PredatorAvoidanceRadiusPanel);
            this.PredatorAvoidanceRadiusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidanceRadiusBox.Location = new System.Drawing.Point(3, 3);
            this.PredatorAvoidanceRadiusBox.Name = "PredatorAvoidanceRadiusBox";
            this.PredatorAvoidanceRadiusBox.Size = new System.Drawing.Size(586, 141);
            this.PredatorAvoidanceRadiusBox.TabIndex = 0;
            this.PredatorAvoidanceRadiusBox.TabStop = false;
            this.PredatorAvoidanceRadiusBox.Text = "Radius";
            // 
            // PredatorAvoidanceRadiusPanel
            // 
            this.PredatorAvoidanceRadiusPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.PredatorAvoidanceRadiusPanel.ColumnCount = 2;
            this.PredatorAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PredatorAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PredatorAvoidanceRadiusPanel.Controls.Add(this.LblPredatorAvoidanceRadius, 1, 0);
            this.PredatorAvoidanceRadiusPanel.Controls.Add(this.SldPredatorAvoidanceRadius, 0, 0);
            this.PredatorAvoidanceRadiusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidanceRadiusPanel.Location = new System.Drawing.Point(3, 31);
            this.PredatorAvoidanceRadiusPanel.Name = "PredatorAvoidanceRadiusPanel";
            this.PredatorAvoidanceRadiusPanel.RowCount = 1;
            this.PredatorAvoidanceRadiusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PredatorAvoidanceRadiusPanel.Size = new System.Drawing.Size(580, 107);
            this.PredatorAvoidanceRadiusPanel.TabIndex = 0;
            // 
            // LblPredatorAvoidanceRadius
            // 
            this.LblPredatorAvoidanceRadius.AutoSize = true;
            this.LblPredatorAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPredatorAvoidanceRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPredatorAvoidanceRadius.ForeColor = System.Drawing.Color.White;
            this.LblPredatorAvoidanceRadius.Location = new System.Drawing.Point(496, 0);
            this.LblPredatorAvoidanceRadius.Name = "LblPredatorAvoidanceRadius";
            this.LblPredatorAvoidanceRadius.Size = new System.Drawing.Size(81, 107);
            this.LblPredatorAvoidanceRadius.TabIndex = 0;
            this.LblPredatorAvoidanceRadius.Text = "0";
            this.LblPredatorAvoidanceRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldPredatorAvoidanceRadius
            // 
            this.SldPredatorAvoidanceRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldPredatorAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldPredatorAvoidanceRadius.Increment = 0.01D;
            this.SldPredatorAvoidanceRadius.LargeChange = 0.05D;
            this.SldPredatorAvoidanceRadius.Location = new System.Drawing.Point(3, 3);
            this.SldPredatorAvoidanceRadius.Maximum = 2D;
            this.SldPredatorAvoidanceRadius.Minimum = 0D;
            this.SldPredatorAvoidanceRadius.Name = "SldPredatorAvoidanceRadius";
            this.SldPredatorAvoidanceRadius.Size = new System.Drawing.Size(487, 101);
            this.SldPredatorAvoidanceRadius.SmallChange = 0.01D;
            this.SldPredatorAvoidanceRadius.TabIndex = 0;
            this.SldPredatorAvoidanceRadius.TickFrequency = 8;
            this.SldPredatorAvoidanceRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldPredatorAvoidanceRadius.Value = 0.29D;
            this.SldPredatorAvoidanceRadius.Scroll += new System.EventHandler(this.SldPredatorAvoidanceRadius_Scroll);
            // 
            // PredatorAvoidanceStrengthBox
            // 
            this.PredatorAvoidanceStrengthBox.Controls.Add(this.PredatorAvoidanceStrengthPanel);
            this.PredatorAvoidanceStrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidanceStrengthBox.Location = new System.Drawing.Point(3, 150);
            this.PredatorAvoidanceStrengthBox.Name = "PredatorAvoidanceStrengthBox";
            this.PredatorAvoidanceStrengthBox.Size = new System.Drawing.Size(586, 141);
            this.PredatorAvoidanceStrengthBox.TabIndex = 1;
            this.PredatorAvoidanceStrengthBox.TabStop = false;
            this.PredatorAvoidanceStrengthBox.Text = "Strength";
            // 
            // PredatorAvoidanceStrengthPanel
            // 
            this.PredatorAvoidanceStrengthPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.PredatorAvoidanceStrengthPanel.ColumnCount = 2;
            this.PredatorAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PredatorAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PredatorAvoidanceStrengthPanel.Controls.Add(this.LblPredatorAvoidanceStrength, 1, 0);
            this.PredatorAvoidanceStrengthPanel.Controls.Add(this.SldPredatorAvoidanceStrength, 0, 0);
            this.PredatorAvoidanceStrengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidanceStrengthPanel.Location = new System.Drawing.Point(3, 31);
            this.PredatorAvoidanceStrengthPanel.Name = "PredatorAvoidanceStrengthPanel";
            this.PredatorAvoidanceStrengthPanel.RowCount = 1;
            this.PredatorAvoidanceStrengthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PredatorAvoidanceStrengthPanel.Size = new System.Drawing.Size(580, 107);
            this.PredatorAvoidanceStrengthPanel.TabIndex = 1;
            // 
            // LblPredatorAvoidanceStrength
            // 
            this.LblPredatorAvoidanceStrength.AutoSize = true;
            this.LblPredatorAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPredatorAvoidanceStrength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPredatorAvoidanceStrength.ForeColor = System.Drawing.Color.White;
            this.LblPredatorAvoidanceStrength.Location = new System.Drawing.Point(496, 0);
            this.LblPredatorAvoidanceStrength.Name = "LblPredatorAvoidanceStrength";
            this.LblPredatorAvoidanceStrength.Size = new System.Drawing.Size(81, 107);
            this.LblPredatorAvoidanceStrength.TabIndex = 0;
            this.LblPredatorAvoidanceStrength.Text = "0";
            this.LblPredatorAvoidanceStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldPredatorAvoidanceStrength
            // 
            this.SldPredatorAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldPredatorAvoidanceStrength.Increment = 0.01D;
            this.SldPredatorAvoidanceStrength.LargeChange = 0.05D;
            this.SldPredatorAvoidanceStrength.Location = new System.Drawing.Point(3, 3);
            this.SldPredatorAvoidanceStrength.Maximum = 3D;
            this.SldPredatorAvoidanceStrength.Minimum = 0D;
            this.SldPredatorAvoidanceStrength.Name = "SldPredatorAvoidanceStrength";
            this.SldPredatorAvoidanceStrength.Size = new System.Drawing.Size(487, 101);
            this.SldPredatorAvoidanceStrength.SmallChange = 0.01D;
            this.SldPredatorAvoidanceStrength.TabIndex = 1;
            this.SldPredatorAvoidanceStrength.TickFrequency = 12;
            this.SldPredatorAvoidanceStrength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldPredatorAvoidanceStrength.Value = 1.9D;
            this.SldPredatorAvoidanceStrength.Scroll += new System.EventHandler(this.SldPredatorAvoidanceStrength_Scroll);
            // 
            // PredatorAvoidancePeripheralsBox
            // 
            this.PredatorAvoidancePeripheralsBox.Controls.Add(this.PredatorAvoidancePeripheralsPanel);
            this.PredatorAvoidancePeripheralsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidancePeripheralsBox.Location = new System.Drawing.Point(3, 297);
            this.PredatorAvoidancePeripheralsBox.Name = "PredatorAvoidancePeripheralsBox";
            this.PredatorAvoidancePeripheralsBox.Size = new System.Drawing.Size(586, 142);
            this.PredatorAvoidancePeripheralsBox.TabIndex = 2;
            this.PredatorAvoidancePeripheralsBox.TabStop = false;
            this.PredatorAvoidancePeripheralsBox.Text = "Peripheral Vision";
            // 
            // PredatorAvoidancePeripheralsPanel
            // 
            this.PredatorAvoidancePeripheralsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.PredatorAvoidancePeripheralsPanel.ColumnCount = 2;
            this.PredatorAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.PredatorAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.PredatorAvoidancePeripheralsPanel.Controls.Add(this.LblPredatorAvoidancePeripherals, 1, 0);
            this.PredatorAvoidancePeripheralsPanel.Controls.Add(this.SldPredatorAvoidancePeripherals, 0, 0);
            this.PredatorAvoidancePeripheralsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PredatorAvoidancePeripheralsPanel.Location = new System.Drawing.Point(3, 31);
            this.PredatorAvoidancePeripheralsPanel.Name = "PredatorAvoidancePeripheralsPanel";
            this.PredatorAvoidancePeripheralsPanel.RowCount = 1;
            this.PredatorAvoidancePeripheralsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PredatorAvoidancePeripheralsPanel.Size = new System.Drawing.Size(580, 108);
            this.PredatorAvoidancePeripheralsPanel.TabIndex = 1;
            // 
            // LblPredatorAvoidancePeripherals
            // 
            this.LblPredatorAvoidancePeripherals.AutoSize = true;
            this.LblPredatorAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPredatorAvoidancePeripherals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPredatorAvoidancePeripherals.ForeColor = System.Drawing.Color.White;
            this.LblPredatorAvoidancePeripherals.Location = new System.Drawing.Point(496, 0);
            this.LblPredatorAvoidancePeripherals.Name = "LblPredatorAvoidancePeripherals";
            this.LblPredatorAvoidancePeripherals.Size = new System.Drawing.Size(81, 108);
            this.LblPredatorAvoidancePeripherals.TabIndex = 0;
            this.LblPredatorAvoidancePeripherals.Text = "0";
            this.LblPredatorAvoidancePeripherals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldPredatorAvoidancePeripherals
            // 
            this.SldPredatorAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldPredatorAvoidancePeripherals.Increment = 0.01D;
            this.SldPredatorAvoidancePeripherals.LargeChange = 0.05D;
            this.SldPredatorAvoidancePeripherals.Location = new System.Drawing.Point(3, 3);
            this.SldPredatorAvoidancePeripherals.Maximum = 6.3D;
            this.SldPredatorAvoidancePeripherals.Minimum = 0D;
            this.SldPredatorAvoidancePeripherals.Name = "SldPredatorAvoidancePeripherals";
            this.SldPredatorAvoidancePeripherals.Size = new System.Drawing.Size(487, 102);
            this.SldPredatorAvoidancePeripherals.SmallChange = 0.01D;
            this.SldPredatorAvoidancePeripherals.TabIndex = 1;
            this.SldPredatorAvoidancePeripherals.TickFrequency = 30;
            this.SldPredatorAvoidancePeripherals.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldPredatorAvoidancePeripherals.Value = 6.3D;
            this.SldPredatorAvoidancePeripherals.Scroll += new System.EventHandler(this.SldPredatorAvoidancePeripherals_Scroll);
            // 
            // ObstacleAvoidanceBox
            // 
            this.ObstacleAvoidanceBox.Controls.Add(this.ObstacleAvoidancePanel);
            this.ObstacleAvoidanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidanceBox.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObstacleAvoidanceBox.Location = new System.Drawing.Point(3, 967);
            this.ObstacleAvoidanceBox.Name = "ObstacleAvoidanceBox";
            this.ObstacleAvoidanceBox.Size = new System.Drawing.Size(598, 477);
            this.ObstacleAvoidanceBox.TabIndex = 4;
            this.ObstacleAvoidanceBox.TabStop = false;
            this.ObstacleAvoidanceBox.Text = "Obstacle Avoidance";
            // 
            // ObstacleAvoidancePanel
            // 
            this.ObstacleAvoidancePanel.ColumnCount = 1;
            this.ObstacleAvoidancePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ObstacleAvoidancePanel.Controls.Add(this.ObstacleAvoidanceRadiusBox, 0, 0);
            this.ObstacleAvoidancePanel.Controls.Add(this.ObstacleAvoidanceStrengthBox, 0, 1);
            this.ObstacleAvoidancePanel.Controls.Add(this.ObstacleAvoidancePeripheralsBox, 0, 2);
            this.ObstacleAvoidancePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidancePanel.Location = new System.Drawing.Point(3, 31);
            this.ObstacleAvoidancePanel.Name = "ObstacleAvoidancePanel";
            this.ObstacleAvoidancePanel.RowCount = 3;
            this.ObstacleAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ObstacleAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ObstacleAvoidancePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ObstacleAvoidancePanel.Size = new System.Drawing.Size(592, 443);
            this.ObstacleAvoidancePanel.TabIndex = 1;
            // 
            // ObstacleAvoidanceRadiusBox
            // 
            this.ObstacleAvoidanceRadiusBox.Controls.Add(this.ObstacleAvoidanceRadiusPanel);
            this.ObstacleAvoidanceRadiusBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidanceRadiusBox.Location = new System.Drawing.Point(3, 3);
            this.ObstacleAvoidanceRadiusBox.Name = "ObstacleAvoidanceRadiusBox";
            this.ObstacleAvoidanceRadiusBox.Size = new System.Drawing.Size(586, 141);
            this.ObstacleAvoidanceRadiusBox.TabIndex = 0;
            this.ObstacleAvoidanceRadiusBox.TabStop = false;
            this.ObstacleAvoidanceRadiusBox.Text = "Radius";
            // 
            // ObstacleAvoidanceRadiusPanel
            // 
            this.ObstacleAvoidanceRadiusPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.ObstacleAvoidanceRadiusPanel.ColumnCount = 2;
            this.ObstacleAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ObstacleAvoidanceRadiusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ObstacleAvoidanceRadiusPanel.Controls.Add(this.LblObstacleAvoidanceRadius, 1, 0);
            this.ObstacleAvoidanceRadiusPanel.Controls.Add(this.SldObstacleAvoidanceRadius, 0, 0);
            this.ObstacleAvoidanceRadiusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidanceRadiusPanel.Location = new System.Drawing.Point(3, 31);
            this.ObstacleAvoidanceRadiusPanel.Name = "ObstacleAvoidanceRadiusPanel";
            this.ObstacleAvoidanceRadiusPanel.RowCount = 1;
            this.ObstacleAvoidanceRadiusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ObstacleAvoidanceRadiusPanel.Size = new System.Drawing.Size(580, 107);
            this.ObstacleAvoidanceRadiusPanel.TabIndex = 0;
            // 
            // LblObstacleAvoidanceRadius
            // 
            this.LblObstacleAvoidanceRadius.AutoSize = true;
            this.LblObstacleAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblObstacleAvoidanceRadius.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObstacleAvoidanceRadius.ForeColor = System.Drawing.Color.White;
            this.LblObstacleAvoidanceRadius.Location = new System.Drawing.Point(496, 0);
            this.LblObstacleAvoidanceRadius.Name = "LblObstacleAvoidanceRadius";
            this.LblObstacleAvoidanceRadius.Size = new System.Drawing.Size(81, 107);
            this.LblObstacleAvoidanceRadius.TabIndex = 0;
            this.LblObstacleAvoidanceRadius.Text = "0";
            this.LblObstacleAvoidanceRadius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldObstacleAvoidanceRadius
            // 
            this.SldObstacleAvoidanceRadius.Cursor = System.Windows.Forms.Cursors.Default;
            this.SldObstacleAvoidanceRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldObstacleAvoidanceRadius.Increment = 0.01D;
            this.SldObstacleAvoidanceRadius.LargeChange = 0.05D;
            this.SldObstacleAvoidanceRadius.Location = new System.Drawing.Point(3, 3);
            this.SldObstacleAvoidanceRadius.Maximum = 2D;
            this.SldObstacleAvoidanceRadius.Minimum = 0D;
            this.SldObstacleAvoidanceRadius.Name = "SldObstacleAvoidanceRadius";
            this.SldObstacleAvoidanceRadius.Size = new System.Drawing.Size(487, 101);
            this.SldObstacleAvoidanceRadius.SmallChange = 0.01D;
            this.SldObstacleAvoidanceRadius.TabIndex = 0;
            this.SldObstacleAvoidanceRadius.TickFrequency = 8;
            this.SldObstacleAvoidanceRadius.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldObstacleAvoidanceRadius.Value = 0.15D;
            this.SldObstacleAvoidanceRadius.Scroll += new System.EventHandler(this.SldObstacleAvoidanceRadius_Scroll);
            // 
            // ObstacleAvoidanceStrengthBox
            // 
            this.ObstacleAvoidanceStrengthBox.Controls.Add(this.ObstacleAvoidanceStrengthPanel);
            this.ObstacleAvoidanceStrengthBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidanceStrengthBox.Location = new System.Drawing.Point(3, 150);
            this.ObstacleAvoidanceStrengthBox.Name = "ObstacleAvoidanceStrengthBox";
            this.ObstacleAvoidanceStrengthBox.Size = new System.Drawing.Size(586, 141);
            this.ObstacleAvoidanceStrengthBox.TabIndex = 1;
            this.ObstacleAvoidanceStrengthBox.TabStop = false;
            this.ObstacleAvoidanceStrengthBox.Text = "Strength";
            // 
            // ObstacleAvoidanceStrengthPanel
            // 
            this.ObstacleAvoidanceStrengthPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.ObstacleAvoidanceStrengthPanel.ColumnCount = 2;
            this.ObstacleAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ObstacleAvoidanceStrengthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ObstacleAvoidanceStrengthPanel.Controls.Add(this.LblObstacleAvoidanceStrength, 1, 0);
            this.ObstacleAvoidanceStrengthPanel.Controls.Add(this.SldObstacleAvoidanceStrength, 0, 0);
            this.ObstacleAvoidanceStrengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidanceStrengthPanel.Location = new System.Drawing.Point(3, 31);
            this.ObstacleAvoidanceStrengthPanel.Name = "ObstacleAvoidanceStrengthPanel";
            this.ObstacleAvoidanceStrengthPanel.RowCount = 1;
            this.ObstacleAvoidanceStrengthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ObstacleAvoidanceStrengthPanel.Size = new System.Drawing.Size(580, 107);
            this.ObstacleAvoidanceStrengthPanel.TabIndex = 1;
            // 
            // LblObstacleAvoidanceStrength
            // 
            this.LblObstacleAvoidanceStrength.AutoSize = true;
            this.LblObstacleAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblObstacleAvoidanceStrength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObstacleAvoidanceStrength.ForeColor = System.Drawing.Color.White;
            this.LblObstacleAvoidanceStrength.Location = new System.Drawing.Point(496, 0);
            this.LblObstacleAvoidanceStrength.Name = "LblObstacleAvoidanceStrength";
            this.LblObstacleAvoidanceStrength.Size = new System.Drawing.Size(81, 107);
            this.LblObstacleAvoidanceStrength.TabIndex = 0;
            this.LblObstacleAvoidanceStrength.Text = "0";
            this.LblObstacleAvoidanceStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldObstacleAvoidanceStrength
            // 
            this.SldObstacleAvoidanceStrength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldObstacleAvoidanceStrength.Increment = 0.01D;
            this.SldObstacleAvoidanceStrength.LargeChange = 0.05D;
            this.SldObstacleAvoidanceStrength.Location = new System.Drawing.Point(3, 3);
            this.SldObstacleAvoidanceStrength.Maximum = 2D;
            this.SldObstacleAvoidanceStrength.Minimum = 0D;
            this.SldObstacleAvoidanceStrength.Name = "SldObstacleAvoidanceStrength";
            this.SldObstacleAvoidanceStrength.Size = new System.Drawing.Size(487, 101);
            this.SldObstacleAvoidanceStrength.SmallChange = 0.01D;
            this.SldObstacleAvoidanceStrength.TabIndex = 1;
            this.SldObstacleAvoidanceStrength.TickFrequency = 8;
            this.SldObstacleAvoidanceStrength.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldObstacleAvoidanceStrength.Value = 2D;
            this.SldObstacleAvoidanceStrength.Scroll += new System.EventHandler(this.SldObstacleAvoidanceStrength_Scroll);
            // 
            // ObstacleAvoidancePeripheralsBox
            // 
            this.ObstacleAvoidancePeripheralsBox.Controls.Add(this.ObstacleAvoidancePeripheralsPanel);
            this.ObstacleAvoidancePeripheralsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidancePeripheralsBox.Location = new System.Drawing.Point(3, 297);
            this.ObstacleAvoidancePeripheralsBox.Name = "ObstacleAvoidancePeripheralsBox";
            this.ObstacleAvoidancePeripheralsBox.Size = new System.Drawing.Size(586, 143);
            this.ObstacleAvoidancePeripheralsBox.TabIndex = 2;
            this.ObstacleAvoidancePeripheralsBox.TabStop = false;
            this.ObstacleAvoidancePeripheralsBox.Text = "Peripheral Vision";
            // 
            // ObstacleAvoidancePeripheralsPanel
            // 
            this.ObstacleAvoidancePeripheralsPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.ObstacleAvoidancePeripheralsPanel.ColumnCount = 2;
            this.ObstacleAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.ObstacleAvoidancePeripheralsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.ObstacleAvoidancePeripheralsPanel.Controls.Add(this.LblObstacleAvoidancePeripherals, 1, 0);
            this.ObstacleAvoidancePeripheralsPanel.Controls.Add(this.SldObstacleAvoidancePeripherals, 0, 0);
            this.ObstacleAvoidancePeripheralsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObstacleAvoidancePeripheralsPanel.Location = new System.Drawing.Point(3, 31);
            this.ObstacleAvoidancePeripheralsPanel.Name = "ObstacleAvoidancePeripheralsPanel";
            this.ObstacleAvoidancePeripheralsPanel.RowCount = 1;
            this.ObstacleAvoidancePeripheralsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ObstacleAvoidancePeripheralsPanel.Size = new System.Drawing.Size(580, 109);
            this.ObstacleAvoidancePeripheralsPanel.TabIndex = 1;
            // 
            // LblObstacleAvoidancePeripherals
            // 
            this.LblObstacleAvoidancePeripherals.AutoSize = true;
            this.LblObstacleAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblObstacleAvoidancePeripherals.Font = new System.Drawing.Font("Segoe UI Semibold", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObstacleAvoidancePeripherals.ForeColor = System.Drawing.Color.White;
            this.LblObstacleAvoidancePeripherals.Location = new System.Drawing.Point(496, 0);
            this.LblObstacleAvoidancePeripherals.Name = "LblObstacleAvoidancePeripherals";
            this.LblObstacleAvoidancePeripherals.Size = new System.Drawing.Size(81, 109);
            this.LblObstacleAvoidancePeripherals.TabIndex = 0;
            this.LblObstacleAvoidancePeripherals.Text = "0";
            this.LblObstacleAvoidancePeripherals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SldObstacleAvoidancePeripherals
            // 
            this.SldObstacleAvoidancePeripherals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SldObstacleAvoidancePeripherals.Increment = 0.01D;
            this.SldObstacleAvoidancePeripherals.LargeChange = 0.05D;
            this.SldObstacleAvoidancePeripherals.Location = new System.Drawing.Point(3, 3);
            this.SldObstacleAvoidancePeripherals.Maximum = 6.3D;
            this.SldObstacleAvoidancePeripherals.Minimum = 0D;
            this.SldObstacleAvoidancePeripherals.Name = "SldObstacleAvoidancePeripherals";
            this.SldObstacleAvoidancePeripherals.Size = new System.Drawing.Size(487, 103);
            this.SldObstacleAvoidancePeripherals.SmallChange = 0.01D;
            this.SldObstacleAvoidancePeripherals.TabIndex = 1;
            this.SldObstacleAvoidancePeripherals.TickFrequency = 30;
            this.SldObstacleAvoidancePeripherals.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SldObstacleAvoidancePeripherals.Value = 6.3D;
            this.SldObstacleAvoidancePeripherals.Scroll += new System.EventHandler(this.SldObstacleAvoidancePeripherals_Scroll);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.BoidPage);
            this.tabControl.Controls.Add(this.EnvironmentPage);
            this.tabControl.Controls.Add(this.GraphicsPage);
            this.tabControl.Location = new System.Drawing.Point(1524, 15);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1230, 1500);
            this.tabControl.TabIndex = 1;
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2774, 1529);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.glControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.GraphicsPage.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBoidColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPredatorColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxObstacleColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBackgroundColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxConnectionLineColour)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldMaxLineLength)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.EnvironmentPage.ResumeLayout(false);
            this.EnvironmentLayoutPanel.ResumeLayout(false);
            this.AddBox.ResumeLayout(false);
            this.AddBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldMaxSpeed)).EndInit();
            this.BoidPage.ResumeLayout(false);
            this.BoidPropertiesPanel.ResumeLayout(false);
            this.AlignmentBox.ResumeLayout(false);
            this.AlignmentPanel.ResumeLayout(false);
            this.AlignmentRadiusBox.ResumeLayout(false);
            this.AlignmentRadiusPanel.ResumeLayout(false);
            this.AlignmentRadiusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentRadius)).EndInit();
            this.AlignmentStrengthBox.ResumeLayout(false);
            this.AlignmentStrengthPanel.ResumeLayout(false);
            this.AlignmentStrengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentStrength)).EndInit();
            this.AlignmentPeripheralsBox.ResumeLayout(false);
            this.AlignmentPeripheralsPanel.ResumeLayout(false);
            this.AlignmentPeripheralsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldAlignmentPeripherals)).EndInit();
            this.CohesionBox.ResumeLayout(false);
            this.CohesionPanel.ResumeLayout(false);
            this.CohesionRadiusBox.ResumeLayout(false);
            this.CohesionRadiusPanel.ResumeLayout(false);
            this.CohesionRadiusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionRadius)).EndInit();
            this.CohesionStrengthBox.ResumeLayout(false);
            this.CohesionStrengthPanel.ResumeLayout(false);
            this.CohesionStrengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionStrength)).EndInit();
            this.CohesionPeripheralsBox.ResumeLayout(false);
            this.CohesionPeripheralsPanel.ResumeLayout(false);
            this.CohesionPeripheralsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldCohesionPeripherals)).EndInit();
            this.BoidAvoidanceBox.ResumeLayout(false);
            this.BoidAvoidancePanel.ResumeLayout(false);
            this.BoidAvoidanceRadiusBox.ResumeLayout(false);
            this.BoidAvoidanceRadiusPanel.ResumeLayout(false);
            this.BoidAvoidanceRadiusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidanceRadius)).EndInit();
            this.BoidAvoidanceStrengthBox.ResumeLayout(false);
            this.BoidAvoidanceStrengthPanel.ResumeLayout(false);
            this.BoidAvoidanceStrengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidanceStrength)).EndInit();
            this.BoidAvoidancePeripheralsBox.ResumeLayout(false);
            this.BoidAvoidancePeripheralsPanel.ResumeLayout(false);
            this.BoidAvoidancePeripheralsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldBoidAvoidancePeripherals)).EndInit();
            this.PredatorAvoidanceBox.ResumeLayout(false);
            this.PredatorAvoidancePanel.ResumeLayout(false);
            this.PredatorAvoidanceRadiusBox.ResumeLayout(false);
            this.PredatorAvoidanceRadiusPanel.ResumeLayout(false);
            this.PredatorAvoidanceRadiusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidanceRadius)).EndInit();
            this.PredatorAvoidanceStrengthBox.ResumeLayout(false);
            this.PredatorAvoidanceStrengthPanel.ResumeLayout(false);
            this.PredatorAvoidanceStrengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidanceStrength)).EndInit();
            this.PredatorAvoidancePeripheralsBox.ResumeLayout(false);
            this.PredatorAvoidancePeripheralsPanel.ResumeLayout(false);
            this.PredatorAvoidancePeripheralsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldPredatorAvoidancePeripherals)).EndInit();
            this.ObstacleAvoidanceBox.ResumeLayout(false);
            this.ObstacleAvoidancePanel.ResumeLayout(false);
            this.ObstacleAvoidanceRadiusBox.ResumeLayout(false);
            this.ObstacleAvoidanceRadiusPanel.ResumeLayout(false);
            this.ObstacleAvoidanceRadiusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidanceRadius)).EndInit();
            this.ObstacleAvoidanceStrengthBox.ResumeLayout(false);
            this.ObstacleAvoidanceStrengthPanel.ResumeLayout(false);
            this.ObstacleAvoidanceStrengthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidanceStrength)).EndInit();
            this.ObstacleAvoidancePeripheralsBox.ResumeLayout(false);
            this.ObstacleAvoidancePeripheralsPanel.ResumeLayout(false);
            this.ObstacleAvoidancePeripheralsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SldObstacleAvoidancePeripherals)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TabPage GraphicsPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PbxBoidColour;
        private System.Windows.Forms.PictureBox PbxPredatorColour;
        private System.Windows.Forms.PictureBox PbxObstacleColour;
        private System.Windows.Forms.PictureBox PbxBackgroundColour;
        private System.Windows.Forms.PictureBox PbxConnectionLineColour;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label LblMaxLineLength;
        private CustomTrackbar SldMaxLineLength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ChbxConnectionLines;
        private System.Windows.Forms.TabPage EnvironmentPage;
        private System.Windows.Forms.TableLayoutPanel EnvironmentLayoutPanel;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.RadioButton RadObstacle;
        private System.Windows.Forms.RadioButton RadPredator;
        private System.Windows.Forms.RadioButton RadBoid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label LblMaxSpeed;
        private CustomTrackbar SldMaxSpeed;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.TabPage BoidPage;
        private System.Windows.Forms.TableLayoutPanel BoidPropertiesPanel;
        private System.Windows.Forms.GroupBox AlignmentBox;
        private System.Windows.Forms.TableLayoutPanel AlignmentPanel;
        private System.Windows.Forms.GroupBox AlignmentRadiusBox;
        private System.Windows.Forms.TableLayoutPanel AlignmentRadiusPanel;
        private System.Windows.Forms.Label LblAlignmentRadius;
        private CustomTrackbar SldAlignmentRadius;
        private System.Windows.Forms.GroupBox AlignmentStrengthBox;
        private System.Windows.Forms.TableLayoutPanel AlignmentStrengthPanel;
        private System.Windows.Forms.Label LblAlignmentStrength;
        private CustomTrackbar SldAlignmentStrength;
        private System.Windows.Forms.GroupBox AlignmentPeripheralsBox;
        private System.Windows.Forms.TableLayoutPanel AlignmentPeripheralsPanel;
        private System.Windows.Forms.Label LblAlignmentPeripherals;
        private CustomTrackbar SldAlignmentPeripherals;
        private System.Windows.Forms.GroupBox CohesionBox;
        private System.Windows.Forms.TableLayoutPanel CohesionPanel;
        private System.Windows.Forms.GroupBox CohesionRadiusBox;
        private System.Windows.Forms.TableLayoutPanel CohesionRadiusPanel;
        private System.Windows.Forms.Label LblCohesionRadius;
        private CustomTrackbar SldCohesionRadius;
        private System.Windows.Forms.GroupBox CohesionStrengthBox;
        private System.Windows.Forms.TableLayoutPanel CohesionStrengthPanel;
        private System.Windows.Forms.Label LblCohesionStrength;
        private CustomTrackbar SldCohesionStrength;
        private System.Windows.Forms.GroupBox CohesionPeripheralsBox;
        private System.Windows.Forms.TableLayoutPanel CohesionPeripheralsPanel;
        private System.Windows.Forms.Label LblCohesionPeripherals;
        private CustomTrackbar SldCohesionPeripherals;
        private System.Windows.Forms.GroupBox BoidAvoidanceBox;
        private System.Windows.Forms.TableLayoutPanel BoidAvoidancePanel;
        private System.Windows.Forms.GroupBox BoidAvoidanceRadiusBox;
        private System.Windows.Forms.TableLayoutPanel BoidAvoidanceRadiusPanel;
        private System.Windows.Forms.Label LblBoidAvoidanceRadius;
        private CustomTrackbar SldBoidAvoidanceRadius;
        private System.Windows.Forms.GroupBox BoidAvoidanceStrengthBox;
        private System.Windows.Forms.TableLayoutPanel BoidAvoidanceStrengthPanel;
        private System.Windows.Forms.Label LblBoidAvoidanceStrength;
        private CustomTrackbar SldBoidAvoidanceStrength;
        private System.Windows.Forms.GroupBox BoidAvoidancePeripheralsBox;
        private System.Windows.Forms.TableLayoutPanel BoidAvoidancePeripheralsPanel;
        private System.Windows.Forms.Label LblBoidAvoidancePeripherals;
        private CustomTrackbar SldBoidAvoidancePeripherals;
        private System.Windows.Forms.GroupBox PredatorAvoidanceBox;
        private System.Windows.Forms.TableLayoutPanel PredatorAvoidancePanel;
        private System.Windows.Forms.GroupBox PredatorAvoidanceRadiusBox;
        private System.Windows.Forms.TableLayoutPanel PredatorAvoidanceRadiusPanel;
        private System.Windows.Forms.Label LblPredatorAvoidanceRadius;
        private CustomTrackbar SldPredatorAvoidanceRadius;
        private System.Windows.Forms.GroupBox PredatorAvoidanceStrengthBox;
        private System.Windows.Forms.TableLayoutPanel PredatorAvoidanceStrengthPanel;
        private System.Windows.Forms.Label LblPredatorAvoidanceStrength;
        private CustomTrackbar SldPredatorAvoidanceStrength;
        private System.Windows.Forms.GroupBox PredatorAvoidancePeripheralsBox;
        private System.Windows.Forms.TableLayoutPanel PredatorAvoidancePeripheralsPanel;
        private System.Windows.Forms.Label LblPredatorAvoidancePeripherals;
        private CustomTrackbar SldPredatorAvoidancePeripherals;
        private System.Windows.Forms.GroupBox ObstacleAvoidanceBox;
        private System.Windows.Forms.TableLayoutPanel ObstacleAvoidancePanel;
        private System.Windows.Forms.GroupBox ObstacleAvoidanceRadiusBox;
        private System.Windows.Forms.TableLayoutPanel ObstacleAvoidanceRadiusPanel;
        private System.Windows.Forms.Label LblObstacleAvoidanceRadius;
        private CustomTrackbar SldObstacleAvoidanceRadius;
        private System.Windows.Forms.GroupBox ObstacleAvoidanceStrengthBox;
        private System.Windows.Forms.TableLayoutPanel ObstacleAvoidanceStrengthPanel;
        private System.Windows.Forms.Label LblObstacleAvoidanceStrength;
        private CustomTrackbar SldObstacleAvoidanceStrength;
        private System.Windows.Forms.GroupBox ObstacleAvoidancePeripheralsBox;
        private System.Windows.Forms.TableLayoutPanel ObstacleAvoidancePeripheralsPanel;
        private System.Windows.Forms.Label LblObstacleAvoidancePeripherals;
        private CustomTrackbar SldObstacleAvoidancePeripherals;
        private System.Windows.Forms.TabControl tabControl;
    }
}