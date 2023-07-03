namespace SharedLibrary;

public class Room
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int[] HostIp { get; set; }
    public List<string> Players { get; set; }
}