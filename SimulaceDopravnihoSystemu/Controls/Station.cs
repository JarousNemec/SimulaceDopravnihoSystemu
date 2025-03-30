using SimulaceDopravnihoSystemu.Forms;
using SimulaceDopravnihoSystemu.Models;
using SimulaceDopravnihoSystemu.Services;

namespace SimulaceDopravnihoSystemu.Controls;

public partial class Station : UserControl
{
    public StationInfo StationInfo { get; set; } = null!;
    public new string Name => StationInfo.Name;
    private List<Package> DeliveredPackages { get; set; } = new List<Package>();
    private List<Package> ToGoPackages { get; set; } = new List<Package>();

    public delegate void AddPackage(Package package);

    public event AddPackage PackageAdded;

    private DeliveryService _deliveryService = null!;

    public Station()
    {
        InitializeComponent();
    }

    public void SetupStation(StationInfo stationInfo, DeliveryService deliveryService)
    {
        StationInfo = stationInfo;
        _deliveryService = deliveryService;
        UpdateInfo();
    }

    private void UpdateInfo()
    {
        _lblDelivered.Text = DeliveredPackages.Count.ToString();
        _lblStationName.Text = StationInfo.Name;
        _lblToGoCount.Text = ToGoPackages.Count.ToString();
    }

    public void DeliverPackages(List<Package> package)
    {
        if (StationInfo.IsCentral)
            ToGoPackages.AddRange(package);
        else
            DeliveredPackages.AddRange(package);
        UpdateInfo();
    }

    public List<Package> GetVanLoad(string targetStationId, bool transferToCentral = true)
    {
        if (transferToCentral)
        {
            var packagesToCentral = ToGoPackages.FindAll(x => !string.IsNullOrEmpty(x.IdToStation));
            ToGoPackages.Clear();
            UpdateInfo();
            return packagesToCentral;
        }

        var packagesHomeStation = ToGoPackages.FindAll(x => x.IdToStation == targetStationId);
        foreach (var package in packagesHomeStation)
        {
            ToGoPackages.Remove(package);
        }

        UpdateInfo();
        return packagesHomeStation;
    }

    private void _btnOpen_Click(object sender, EventArgs e)
    {
        var packageDialog = new PackageStationDialog();
        packageDialog.SetupDialog(StationInfo, _deliveryService.GetAvailableDestinationStationsForId(StationInfo.Id),
            DeliveredPackages);
        packageDialog.OnPackageAdded += PackageDialogOnPackageAdded;
        packageDialog.OnPackagePickedUp += PackageDialogOnPackagePickedUp;
        packageDialog.Show();
    }

    private void PackageDialogOnPackagePickedUp(Package package)
    {
        var p = DeliveredPackages.FirstOrDefault(p => p.Id == package.Id);
        if (p != null)
            DeliveredPackages.Remove(p);
        UpdateInfo();
    }

    private void PackageDialogOnPackageAdded(Package package)
    {
        ToGoPackages.Add(package);
        PackageAdded?.Invoke(package);
        UpdateInfo();
    }

    public override string ToString()
    {
        return StationInfo.Name;
    }
}