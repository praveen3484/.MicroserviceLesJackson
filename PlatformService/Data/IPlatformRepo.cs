namespace PlatformService.Data
{
    using PlatformService.Models;
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}