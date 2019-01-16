using System.Collections.Generic;

namespace Ocelot.Configuration.File
{
    public class FileCacheOptions
    {
        public int TtlSeconds { get; set; }
        public string Region { get; set; }
        public List<int> IgnoreHttpStatusCodes { get; set; }
        public List<int> ForceHttpStatusCodes { get; set; }
    }
}
