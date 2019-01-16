namespace Ocelot.Configuration.Creator
{
    using Ocelot.Configuration.File;

    public interface ICacheOptionsCreator
    {
        CacheOptions Create(FileCacheOptions cacheOptions);
    }
}
