using System.ComponentModel;

namespace SimulaceDopravnihoSystemu.Forms;

partial class PackageStationDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        _lblFromStationName = new System.Windows.Forms.Label();
        _cmbDestinationStation = new System.Windows.Forms.ComboBox();
        _txtContent = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        _btnAddPackage = new System.Windows.Forms.Button();
        _cmbDelivered = new System.Windows.Forms.ComboBox();
        _btnPickup = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(10, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(81, 20);
        label1.TabIndex = 0;
        label1.Text = "From station:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(10, 39);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(81, 20);
        label2.TabIndex = 1;
        label2.Text = "To station:";
        // 
        // _lblFromStationName
        // 
        _lblFromStationName.Location = new System.Drawing.Point(97, 10);
        _lblFromStationName.Name = "_lblFromStationName";
        _lblFromStationName.Size = new System.Drawing.Size(203, 20);
        _lblFromStationName.TabIndex = 2;
        _lblFromStationName.Text = "From station name";
        // 
        // _cmbDestinationStation
        // 
        _cmbDestinationStation.FormattingEnabled = true;
        _cmbDestinationStation.Location = new System.Drawing.Point(97, 33);
        _cmbDestinationStation.Name = "_cmbDestinationStation";
        _cmbDestinationStation.Size = new System.Drawing.Size(203, 23);
        _cmbDestinationStation.TabIndex = 3;
        // 
        // _txtContent
        // 
        _txtContent.Location = new System.Drawing.Point(97, 70);
        _txtContent.Multiline = true;
        _txtContent.Name = "_txtContent";
        _txtContent.Size = new System.Drawing.Size(203, 188);
        _txtContent.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 70);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(81, 20);
        label3.TabIndex = 5;
        label3.Text = "Content:";
        // 
        // _btnAddPackage
        // 
        _btnAddPackage.Location = new System.Drawing.Point(12, 264);
        _btnAddPackage.Name = "_btnAddPackage";
        _btnAddPackage.Size = new System.Drawing.Size(288, 23);
        _btnAddPackage.TabIndex = 6;
        _btnAddPackage.Text = "Add package\r\n";
        _btnAddPackage.UseVisualStyleBackColor = true;
        _btnAddPackage.Click += _btnAddPackage_Click;
        // 
        // _cmbDelivered
        // 
        _cmbDelivered.FormattingEnabled = true;
        _cmbDelivered.Location = new System.Drawing.Point(12, 331);
        _cmbDelivered.Name = "_cmbDelivered";
        _cmbDelivered.Size = new System.Drawing.Size(288, 23);
        _cmbDelivered.TabIndex = 7;
        // 
        // _btnPickup
        // 
        _btnPickup.Location = new System.Drawing.Point(12, 365);
        _btnPickup.Name = "_btnPickup";
        _btnPickup.Size = new System.Drawing.Size(288, 23);
        _btnPickup.TabIndex = 8;
        _btnPickup.Text = "Pickup package";
        _btnPickup.UseVisualStyleBackColor = true;
        _btnPickup.Click += _btnPickup_Click;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 308);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(290, 20);
        label4.TabIndex = 9;
        label4.Text = "Select package to pickup:";
        // 
        // PackageStationDialog
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(314, 402);
        Controls.Add(label4);
        Controls.Add(_btnPickup);
        Controls.Add(_cmbDelivered);
        Controls.Add(_btnAddPackage);
        Controls.Add(label3);
        Controls.Add(_txtContent);
        Controls.Add(_cmbDestinationStation);
        Controls.Add(_lblFromStationName);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "Station package dialog";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox _cmbDelivered;
    private System.Windows.Forms.Button _btnPickup;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button _btnAddPackage;

    private System.Windows.Forms.ComboBox _cmbDestinationStation;
    private System.Windows.Forms.TextBox _txtContent;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label _lblFromStationName;

    #endregion
}