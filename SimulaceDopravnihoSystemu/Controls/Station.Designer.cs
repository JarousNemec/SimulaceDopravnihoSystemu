using System.ComponentModel;

namespace SimulaceDopravnihoSystemu.Controls;

partial class Station
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Station));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        _lblStationName = new System.Windows.Forms.Label();
        _btnOpen = new System.Windows.Forms.Button();
        _lblDelivered = new System.Windows.Forms.Label();
        _lblToGoCount = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(100, 100);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // _lblStationName
        // 
        _lblStationName.BackColor = System.Drawing.Color.Transparent;
        _lblStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        _lblStationName.Location = new System.Drawing.Point(1, 0);
        _lblStationName.Name = "_lblStationName";
        _lblStationName.Size = new System.Drawing.Size(96, 25);
        _lblStationName.TabIndex = 1;
        _lblStationName.Text = "station name";
        _lblStationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // _btnOpen
        // 
        _btnOpen.Location = new System.Drawing.Point(12, 28);
        _btnOpen.Name = "_btnOpen";
        _btnOpen.Size = new System.Drawing.Size(75, 23);
        _btnOpen.TabIndex = 2;
        _btnOpen.Text = "Open";
        _btnOpen.UseVisualStyleBackColor = true;
        _btnOpen.Click += _btnOpen_Click;
        // 
        // _lblDelivered
        // 
        _lblDelivered.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _lblDelivered.ForeColor = System.Drawing.Color.ForestGreen;
        _lblDelivered.Location = new System.Drawing.Point(3, 54);
        _lblDelivered.Name = "_lblDelivered";
        _lblDelivered.Size = new System.Drawing.Size(50, 36);
        _lblDelivered.TabIndex = 3;
        _lblDelivered.Text = "000";
        // 
        // _lblToGoCount
        // 
        _lblToGoCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        _lblToGoCount.ForeColor = System.Drawing.Color.Red;
        _lblToGoCount.Location = new System.Drawing.Point(46, 54);
        _lblToGoCount.Name = "_lblToGoCount";
        _lblToGoCount.Size = new System.Drawing.Size(51, 36);
        _lblToGoCount.TabIndex = 4;
        _lblToGoCount.Text = "000";
        // 
        // Station
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(_lblToGoCount);
        Controls.Add(_lblDelivered);
        Controls.Add(_btnOpen);
        Controls.Add(_lblStationName);
        Controls.Add(pictureBox1);
        Size = new System.Drawing.Size(100, 100);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button _btnOpen;
    private System.Windows.Forms.Label _lblToGoCount;

    private System.Windows.Forms.Label _lblDelivered;
    private System.Windows.Forms.Label _lblStationName;
    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}