namespace SimulaceDopravnihoSystemu.Models;

public class Package
{
    public string Id { get; set; }
    public string IdFromStation { get; set; }
    public string IdToStation { get; set; }
    public string Content { get; set; }

    public override string ToString()
    {
        return Id;
    }
}
