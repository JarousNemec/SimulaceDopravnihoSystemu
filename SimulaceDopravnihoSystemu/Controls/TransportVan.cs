using SimulaceDopravnihoSystemu.Enums;
using SimulaceDopravnihoSystemu.Models;
using SimulaceDopravnihoSystemu.Services;

namespace SimulaceDopravnihoSystemu.Controls;

public partial class TransportVan : UserControl
{
    public const double VanSpeed = 50f;
    public const double DimensionsMetersPerPoint = 1000f;
    public readonly TimeSpan OnePackageAvarageLoadTime = new TimeSpan(0, 0, 45);
    public readonly TimeSpan OnePackageAvarageUnLoadTime = new TimeSpan(0, 0, 30);
    public TimeSpan PreparingBeforeDrive { get; set; } = new TimeSpan(0, 0, 0);
    public string Id { get; set; }
    public Station HomeStation { get; set; }
    public Station CentralStation { get; set; }
    public Point HomePosition { get; set; }
    public Point EndPosition { get; set; }

    public List<Package> Packages { get; set; } = new List<Package>();

    public delegate void DestinationReachedDelegate(string vanId);

    public event DestinationReachedDelegate DestinationReached;


    public TransportVan()
    {
        InitializeComponent();
    }

    private VanState _state = VanState.Ready;
    public VanState State => _state;
    public VanDirection Direction = VanDirection.HomeStation;
    public bool CommandedToWork { get; set; } = false;
    private double TickStepX = 0f;
    private double TickStepY = 0f;
    private double PositionX = 0f;
    private double PositionY = 0f;
    private Point DestinationPosition;

    public void StartMovingHome()
    {
        PositionX = EndPosition.X;
        PositionY = EndPosition.Y;
        Calculate(EndPosition, HomePosition);
        DestinationPosition = HomePosition;
        _state = VanState.Driving;
        Direction = VanDirection.HomeStation;
    }

    private void Calculate(Point start, Point end)
    {
        double VectorX = end.X - start.X;
        double VectorY = (end.Y - start.Y);

        double distance = Math.Sqrt(VectorX * VectorX + VectorY * VectorY);

        TickStepX = (VectorX / distance) * (VanSpeed / DimensionsMetersPerPoint);
        TickStepY = (VectorY / distance) * (VanSpeed / DimensionsMetersPerPoint);
    }

    public void StartMovingToCentralStation()
    {
        PositionX = HomePosition.X;
        PositionY = HomePosition.Y;
        Calculate(HomePosition, EndPosition);
        DestinationPosition = EndPosition;
        _state = VanState.Driving;
        Direction = VanDirection.CentralStation;
    }

    public void Stop()
    {
        if (Direction == VanDirection.CentralStation)
            _state = VanState.WaitingForPackage;
        else if (Direction == VanDirection.HomeStation)
        {
            _state = VanState.Ready;
            CommandedToWork = false;
        }
    }

    public void UpdateState(bool waitingForPackage)
    {
        if (CommandedToWork && PreparingBeforeDrive.TotalSeconds != 0)
            PreparingBeforeDrive = TimeSpan.FromSeconds(PreparingBeforeDrive.TotalSeconds - 1);
        else if (CommandedToWork && PreparingBeforeDrive.TotalSeconds == 0 && !waitingForPackage && _state == VanState.WaitingForPackage)
            _state = VanState.Ready;
        if (_state != VanState.Driving)
            return;

        PositionX += TickStepX;
        PositionY += TickStepY;
        Location = new Point((int)PositionX, (int)PositionY);
        if ((DestinationPosition.X + 20 > PositionX && DestinationPosition.X - 20 < PositionX) &&
            (DestinationPosition.Y + 20 > PositionY && DestinationPosition.Y - 20 < PositionY))
        {
            Stop();
            DestinationReached?.Invoke(Id);
        }
    }
}