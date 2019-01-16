namespace Ocelot.Configuration.Creator
{
    using Ocelot.Configuration.Builder;
    using Ocelot.Configuration.File;

    public class CacheOptionsCreator : ICacheOptionsCreator
    {
        public CacheOptions Create(FileCacheOptions cacheOptions)
        {
            return new CacheOptionsBuilder()
                        .WithTtl(cacheOptions.TtlSeconds)
                        .WithRegion(cacheOptions.Region)
                        .WithForcedHttpStatusCodes(cacheOptions.ForceHttpStatusCodes)
                        .WithIgnoredHttpStatusCodes(cacheOptions.IgnoreHttpStatusCodes)
                        .Build();
        }
    }    
}
