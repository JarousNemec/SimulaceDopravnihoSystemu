namespace SimulaceDopravnihoSystemu;

partial class SimulationForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
        _map = new System.Windows.Forms.PictureBox();
        _pos8 = new System.Windows.Forms.Label();
        _pos2 = new System.Windows.Forms.Label();
        _pos3 = new System.Windows.Forms.Label();
        _pos4 = new System.Windows.Forms.Label();
        _pos5 = new System.Windows.Forms.Label();
        _pos0 = new System.Windows.Forms.Label();
        _pos6 = new System.Windows.Forms.Label();
        _pos7 = new System.Windows.Forms.Label();
        _pos1 = new System.Windows.Forms.Label();
        _spaceClock = new System.Windows.Forms.Timer(components);
        _lblClock = new System.Windows.Forms.Label();
        _tpicShiftStart = new System.Windows.Forms.DateTimePicker();
        label1 = new System.Windows.Forms.Label();
        _btnSetShiftStart = new System.Windows.Forms.Button();
        _chckRun = new System.Windows.Forms.CheckBox();
        ((System.ComponentModel.ISupportInitialize)_map).BeginInit();
        SuspendLayout();
        // 
        // _map
        // 
        _map.Image = ((System.Drawing.Image)resources.GetObject("_map.Image"));
        _map.Location = new System.Drawing.Point(12, 41);
        _map.Name = "_map";
        _map.Size = new System.Drawing.Size(1044, 695);
        _map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        _map.TabIndex = 0;
        _map.TabStop = false;
        // 
        // _pos8
        // 
        _pos8.BackColor = System.Drawing.Color.DarkOrange;
        _pos8.Location = new System.Drawing.Point(931, 431);
        _pos8.Name = "_pos8";
        _pos8.Size = new System.Drawing.Size(22, 19);
        _pos8.TabIndex = 1;
        _pos8.Text = "P8";
        // 
        // _pos2
        // 
        _pos2.BackColor = System.Drawing.Color.DarkOrange;
        _pos2.Location = new System.Drawing.Point(668, 571);
        _pos2.Name = "_pos2";
        _pos2.Size = new System.Drawing.Size(22, 19);
        _pos2.TabIndex = 2;
        _pos2.Text = "P2";
        // 
        // _pos3
        // 
        _pos3.BackColor = System.Drawing.Color.DarkOrange;
        _pos3.Location = new System.Drawing.Point(500, 471);
        _pos3.Name = "_pos3";
        _pos3.Size = new System.Drawing.Size(22, 19);
        _pos3.TabIndex = 3;
        _pos3.Text = "P3";
        // 
        // _pos4
        // 
        _pos4.BackColor = System.Drawing.Color.DarkOrange;
        _pos4.Location = new System.Drawing.Point(216, 431);
        _pos4.Name = "_pos4";
        _pos4.Size = new System.Drawing.Size(22, 19);
        _pos4.TabIndex = 4;
        _pos4.Text = "P4";
        // 
        // _pos5
        // 
        _pos5.BackColor = System.Drawing.Color.DarkOrange;
        _pos5.Location = new System.Drawing.Point(130, 236);
        _pos5.Name = "_pos5";
        _pos5.Size = new System.Drawing.Size(22, 19);
        _pos5.TabIndex = 5;
        _pos5.Text = "P5";
        // 
        // _pos0
        // 
        _pos0.BackColor = System.Drawing.Color.DarkOrange;
        _pos0.Location = new System.Drawing.Point(416, 290);
        _pos0.Name = "_pos0";
        _pos0.Size = new System.Drawing.Size(22, 19);
        _pos0.TabIndex = 6;
        _pos0.Text = "P0";
        // 
        // _pos6
        // 
        _pos6.BackColor = System.Drawing.Color.DarkOrange;
        _pos6.Location = new System.Drawing.Point(585, 168);
        _pos6.Name = "_pos6";
        _pos6.Size = new System.Drawing.Size(22, 19);
        _pos6.TabIndex = 7;
        _pos6.Text = "P6";
        // 
        // _pos7
        // 
        _pos7.BackColor = System.Drawing.Color.DarkOrange;
        _pos7.Location = new System.Drawing.Point(772, 311);
        _pos7.Name = "_pos7";
        _pos7.Size = new System.Drawing.Size(22, 19);
        _pos7.TabIndex = 8;
        _pos7.Text = "P7";
        // 
        // _pos1
        // 
        _pos1.BackColor = System.Drawing.Color.DarkOrange;
        _pos1.Location = new System.Drawing.Point(844, 529);
        _pos1.Name = "_pos1";
        _pos1.Size = new System.Drawing.Size(22, 19);
        _pos1.TabIndex = 9;
        _pos1.Text = "P1";
        // 
        // _spaceClock
        // 
        _spaceClock.Enabled = true;
        _spaceClock.Interval = 1;
        _spaceClock.Tick += _spaceClock_Tick;
        // 
        // _lblClock
        // 
        _lblClock.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _lblClock.Location = new System.Drawing.Point(1, 2);
        _lblClock.Name = "_lblClock";
        _lblClock.Size = new System.Drawing.Size(318, 37);
        _lblClock.TabIndex = 10;
        _lblClock.Text = "12:10:26 1.2.2002";
        // 
        // _tpicShiftStart
        // 
        _tpicShiftStart.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _tpicShiftStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _tpicShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        _tpicShiftStart.Location = new System.Drawing.Point(780, 2);
        _tpicShiftStart.Name = "_tpicShiftStart";
        _tpicShiftStart.Size = new System.Drawing.Size(200, 35);
        _tpicShiftStart.TabIndex = 11;
        _tpicShiftStart.Value = new System.DateTime(2025, 12, 25, 6, 2, 0, 0);
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(635, 2);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(139, 37);
        label1.TabIndex = 12;
        label1.Text = "Shift start:";
        // 
        // _btnSetShiftStart
        // 
        _btnSetShiftStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _btnSetShiftStart.Location = new System.Drawing.Point(986, 2);
        _btnSetShiftStart.Name = "_btnSetShiftStart";
        _btnSetShiftStart.Size = new System.Drawing.Size(75, 35);
        _btnSetShiftStart.TabIndex = 13;
        _btnSetShiftStart.Text = "Set";
        _btnSetShiftStart.UseVisualStyleBackColor = true;
        _btnSetShiftStart.Click += _btnSetShiftStart_Click;
        // 
        // _chckRun
        // 
        _chckRun.Location = new System.Drawing.Point(388, 11);
        _chckRun.Name = "_chckRun";
        _chckRun.Size = new System.Drawing.Size(134, 24);
        _chckRun.TabIndex = 14;
        _chckRun.Text = "Run simulation";
        _chckRun.UseVisualStyleBackColor = true;
        // 
        // SimulationForm
        // 
        AllowDrop = true;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(1441, 781);
        Controls.Add(_chckRun);
        Controls.Add(_btnSetShiftStart);
        Controls.Add(label1);
        Controls.Add(_tpicShiftStart);
        Controls.Add(_lblClock);
        Controls.Add(_pos1);
        Controls.Add(_pos7);
        Controls.Add(_pos6);
        Controls.Add(_pos0);
        Controls.Add(_pos5);
        Controls.Add(_pos4);
        Controls.Add(_pos3);
        Controls.Add(_pos2);
        Controls.Add(_pos8);
        Controls.Add(_map);
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)_map).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.CheckBox _chckRun;

    private System.Windows.Forms.Button _btnSetShiftStart;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DateTimePicker _tpicShiftStart;

    private System.Windows.Forms.Label _lblClock;

    private System.Windows.Forms.Timer _spaceClock;

    private System.Windows.Forms.Label _pos8;
    private System.Windows.Forms.Label _pos3;
    private System.Windows.Forms.Label _pos4;
    private System.Windows.Forms.Label _pos5;
    private System.Windows.Forms.Label _pos0;
    private System.Windows.Forms.Label _pos6;
    private System.Windows.Forms.Label _pos7;
    private System.Windows.Forms.Label _pos1;

    private System.Windows.Forms.Label _pos2;

    private System.Windows.Forms.PictureBox _map;

    #endregion
}