using SimulaceDopravnihoSystemu.Controls;
using SimulaceDopravnihoSystemu.Models;

namespace SimulaceDopravnihoSystemu.Forms;

public partial class PackageStationDialog : Form
{
    private StationInfo _fromStation;

    public delegate void PackageOperation(Package package);

    public event PackageOperation OnPackageAdded;

    public event PackageOperation OnPackagePickedUp;

    public PackageStationDialog()
    {
        InitializeComponent();
    }

    public void SetupDialog(StationInfo fromStation, List<StationInfo> toStations, List<Package> deliveredPackages)
    {
        _fromStation = fromStation;
        _lblFromStationName.Text = _fromStation.Name;
        _cmbDelivered.DataSource = deliveredPackages;
        _cmbDelivered.DisplayMember = "Id";
        _cmbDelivered.ValueMember = "Id";
        _cmbDestinationStation.DataSource = toStations;
        _cmbDestinationStation.DisplayMember = "Name";
        _cmbDestinationStation.ValueMember = "Id";
        _cmbDestinationStation.Refresh();
        Invalidate();
    }


    private void _btnAddPackage_Click(object sender, EventArgs e)
    {
        var destionation = _cmbDestinationStation.SelectedItem as StationInfo;
        if (destionation == null)
            return;
        var newPackage = new Package()
        {
            Id = Guid.NewGuid().ToString(),
            Content = _txtContent.Text,
            IdFromStation = _fromStation.Id,
            IdToStation = destionation.Id
        };
        OnPackageAdded?.Invoke(newPackage);
    }

    private void _btnPickup_Click(object sender, EventArgs e)
    {
        if (_cmbDelivered.SelectedItem is Package selectedPackage)
            OnPackagePickedUp?.Invoke(selectedPackage);
    }

}