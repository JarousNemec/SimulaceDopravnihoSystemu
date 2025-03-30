namespace SimulaceDopravnihoSystemu.Models;

public class StationInfo
{
    public string Id { get; set; }
    public string Name { get; set; }

    public bool IsCentral { get; set; }

    public override string ToString()
    {
        return Name;
    }
}