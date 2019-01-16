namespace Ocelot.Configuration.Builder
{
    public interface IBuilder<T>
        where T : class
    {
        T Build();
    }
}
