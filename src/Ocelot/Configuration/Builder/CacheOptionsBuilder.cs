using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Configuration.Builder
{
    public class CacheOptionsBuilder : IBuilder<CacheOptions>
    {
        private int _ttl;
        private string _region;
        private IEnumerable<int> _ignoredHttpStatusCodes;
        private IEnumerable<int> _forcedHttpStatusCodes;

        public CacheOptionsBuilder WithTtl(int ttl)
        {
            _ttl = ttl;
            return this;
        }

        public CacheOptionsBuilder WithRegion(string region)
        {
            _region = region;
            return this;
        }

        public CacheOptionsBuilder WithIgnoredHttpStatusCodes(IEnumerable<int> ignoredHttpStatusCodes)
        {
            _ignoredHttpStatusCodes = ignoredHttpStatusCodes;
            return this;
        }

        public CacheOptionsBuilder WithForcedHttpStatusCodes(IEnumerable<int> forcedHttpStatusCodes)
        {
            _forcedHttpStatusCodes = forcedHttpStatusCodes;
            return this;
        }

        public CacheOptions Build()
        {
            return new CacheOptions(_ttl, _region);
        }
    }
}
