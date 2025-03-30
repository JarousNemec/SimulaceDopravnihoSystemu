using SimulaceDopravnihoSystemu.Controls;
using SimulaceDopravnihoSystemu.Enums;
using SimulaceDopravnihoSystemu.Models;

namespace SimulaceDopravnihoSystemu.Services;

public class DeliveryService
{
    private List<Station> StationsInSystem { get; set; } = new List<Station>();
    public List<TransportVan> TransportVans { get; set; } = new List<TransportVan>();
    
    public List<TransportVan> TransportVansWaiting { get; set; } = new List<TransportVan>();

    private DateTime _vanStartMovingTime = new DateTime(2020, 1, 1, 6, 0, 0);

    public void SetVanStartMoving(DateTime vanStartMovingTime)
    {
        _vanStartMovingTime = vanStartMovingTime;
    }

    public void AddStation(Station station)
    {
        StationsInSystem.Add(station);
    }

    public void AddTransportVan(TransportVan transportVan)
    {
        transportVan.DestinationReached += HandleVanArrival;
        TransportVans.Add(transportVan);
    }

    private void HandleVanArrival(string vanId)
    {
        var van = TransportVans.FirstOrDefault(x => x.Id == vanId);
        
        var packagesToUnload = 0;

        if (van == null)
            return;
        packagesToUnload = van.Packages.Count;
        UnloadVan(van);
        TransportVansWaiting.Add(van);
        
        van.PreparingBeforeDrive = new TimeSpan(0, 0, 0);

        var timeOfUnload = new TimeSpan(packagesToUnload * van.OnePackageAvarageUnLoadTime.Hours,
            packagesToUnload * van.OnePackageAvarageUnLoadTime.Minutes,
            packagesToUnload * van.OnePackageAvarageUnLoadTime.Seconds);
        van.PreparingBeforeDrive = van.PreparingBeforeDrive.Add(timeOfUnload);

        
            
    }

    private void HandleVanLoad(TransportVan van)
    {
        LoadVan(van);
        var packagesToLoad = 0;
        packagesToLoad = van.Packages.Count;
        
        var timeOfLoad = new TimeSpan(packagesToLoad * van.OnePackageAvarageLoadTime.Hours,
            packagesToLoad * van.OnePackageAvarageLoadTime.Minutes,
            packagesToLoad * van.OnePackageAvarageLoadTime.Seconds);
        van.PreparingBeforeDrive = van.PreparingBeforeDrive.Add(timeOfLoad);
        
        if (van.Packages.Count > 0)
        {
            int fds = 0;
        }
    }

    private static void UnloadVan(TransportVan van)
    {
        if (van.Packages.Count > 0)
        {
            if (van.Direction == VanDirection.CentralStation)
            {
                van.CentralStation.DeliverPackages(van.Packages);
                
            }
            else if (van.Direction == VanDirection.HomeStation)
            {
                van.HomeStation.DeliverPackages(van.Packages);
            }
            van.Packages.Clear();
        }
    }

    private static void LoadVan(TransportVan van)
    {
        if (van.Direction == VanDirection.CentralStation)
        {
            van.Packages = van.CentralStation.GetVanLoad(van.HomeStation.StationInfo.Id, false);
        }

        else if (van.Direction == VanDirection.HomeStation)
        {
            van.Packages = van.HomeStation.GetVanLoad(van.CentralStation.StationInfo.Id);
        }
    }

    public List<StationInfo> GetAvailableDestinationStationsForId(string stationId)
    {
        return StationsInSystem.Where(x => x.StationInfo.Id != stationId && !x.StationInfo.Name.Contains("Main"))
            .Select(x => x.StationInfo).ToList();
    }

    public Station? GetStationByName(string stationName)
    {
        return StationsInSystem.FirstOrDefault(x => x.Name == stationName);
    }

    public void UpdateState(DateTime spaceClockTime)
    {
        if (spaceClockTime.Minute == _vanStartMovingTime.Minute && spaceClockTime.Hour == _vanStartMovingTime.Hour &&
            spaceClockTime.Second == _vanStartMovingTime.Second)
            foreach (var van in TransportVans)
            {
                HandleVanLoad(van);
                if (van.Direction == VanDirection.HomeStation && van.State == VanState.Ready)
                    van.CommandedToWork = true;
                
            }

        foreach (var van in TransportVans)
        {
            if (TransportVansWaiting.Contains(van) && TransportVans.Where(x => x.Id != van.Id).All(y => y.Packages.All(j =>j.IdToStation != van.HomeStation.StationInfo.Id)))
            {
                HandleVanLoad(van);
                TransportVansWaiting.Remove(van);
            }
        }
        
        foreach (var van in TransportVans)
        {
            van.UpdateState(TransportVansWaiting.Any(x => x.Id == van.Id));
            if (van.PreparingBeforeDrive.TotalSeconds == 0 && van.State == VanState.Ready && van.CommandedToWork )
            {
                if (van.Direction == VanDirection.CentralStation)
                    van.StartMovingHome();
                else if (van.Direction == VanDirection.HomeStation)
                    van.StartMovingToCentralStation();
            }
        }
    }
}