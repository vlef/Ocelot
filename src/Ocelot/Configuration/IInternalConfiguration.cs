namespace Ocelot.Configuration
{
    using System.Collections.Generic;

    public interface IInternalConfiguration
    {
        List<ReRoute> ReRoutes { get; }

        string AdministrationPath { get; }

        ServiceProviderConfiguration ServiceProviderConfiguration { get; }

        string RequestId { get; }

        LoadBalancerOptions LoadBalancerOptions { get; }

        string DownstreamScheme { get; }

        QoSOptions QoSOptions { get; }

        HttpHandlerOptions HttpHandlerOptions { get; }

        CacheOptions CacheOptions { get; }
    }
}
