namespace ConsoleApp1
{
    public interface ILoggerFactory
    {
        ILogger Create(string componentCode);
        void Release(ILogger logger);
    }
}
