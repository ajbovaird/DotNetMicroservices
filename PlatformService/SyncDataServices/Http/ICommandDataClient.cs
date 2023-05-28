using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http;

public interface ICommandDataClient
{
    Task SendPlaformToCommand(PlatformReadDto plat);
}