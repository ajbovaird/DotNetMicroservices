namespace PlatformService.Dtos;

public class PlatformPublishedDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Event { get; set; } = "Platform_Published";
}