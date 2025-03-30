using SimulaceDopravnihoSystemu.Controls;
using SimulaceDopravnihoSystemu.Models;
using SimulaceDopravnihoSystemu.Services;

namespace SimulaceDopravnihoSystemu;

public partial class SimulationForm : Form
{
    private DateTime spaceClockTime = new DateTime(2020, 1, 1, 6, 0, 0);
    private readonly DeliveryService _deliveryService = new ();
    

    public SimulationForm()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        SetupSimulation();
    }

    private void SetupSimulation()
    {
        AddStationToMap("Main", _pos0, true);
        AddStationToMap("Depo1", _pos1);
        AddStationToMap("Depo2", _pos2);
        AddStationToMap("Depo3", _pos3);
        AddStationToMap("Depo4", _pos4);
        AddStationToMap("Depo5", _pos5);
        AddStationToMap("Depo6", _pos6);
        AddStationToMap("Depo7", _pos7);
        AddStationToMap("Depo8", _pos8);
        _deliveryService.SetVanStartMoving(_tpicShiftStart.Value);
    }

    private void AddVanToMap(string vanId, Station homeStation, Station endStation)
    {
        var van = new TransportVan();
        van.Id = vanId;
        van.HomeStation = homeStation;
        van.CentralStation = endStation;
        van.Location = new Point(homeStation.Location.X + homeStation.Size.Width / 2 - van.Size.Width / 2,
            homeStation.Location.Y + homeStation.Size.Height / 2 - van.Size.Height / 2);
        van.HomePosition = van.Location;
        van.EndPosition = new Point(endStation.Location.X + endStation.Size.Width / 2 - van.Size.Width / 2,
            endStation.Location.Y + endStation.Size.Height / 2 - van.Size.Height / 2);
        
        _deliveryService.AddTransportVan(van);
        _map.Controls.Add(van);
    }

    private void AddStationToMap(string name, Label pos, bool isCentral = false)
    {
        var station = new Station();
        var stationInfo = new StationInfo()
        {
            Id = Guid.NewGuid().ToString(),
            IsCentral = isCentral,
            Name = name
        };
        station.SetupStation(stationInfo, _deliveryService);
        station.Location = new Point(pos.Location.X - station.Size.Width / 2, pos.Location.Y - station.Size.Height / 2);
        pos.Visible = false;
        _deliveryService.AddStation(station);
        _map.Controls.Add(station);
        if (!isCentral)
        {
            var endStation = _deliveryService.GetStationByName("Main");
            if (endStation != null)
                AddVanToMap($"{Guid.NewGuid()}_{stationInfo.Id}", station,endStation);
        }
    }
    
    private void _spaceClock_Tick(object sender, EventArgs e)
    {
        if (_chckRun.Checked)
        {
            _lblClock.Text = spaceClockTime.ToString("HH:mm:ss");
            spaceClockTime = spaceClockTime.AddSeconds(1);
            _deliveryService.UpdateState(spaceClockTime);
            Invalidate();
        }
    }

    private void _btnSetShiftStart_Click(object sender, EventArgs e)
    {
        _deliveryService.SetVanStartMoving(_tpicShiftStart.Value);
    }

}