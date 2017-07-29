namespace ConsoleApp1
{
    public class ComplexComponent : IComplexComponent
    {
        public ILoggerFactory LoggerFactory { get; set; }

        public void DoJob()
        {
            var factory = this.LoggerFactory.Create("Console");
            factory.Log("Extremely Important Job is being done and logged");

            var factory1 = this.LoggerFactory.Create("Debug");
            factory1.Log("Extremely Important Job is being done and logged");
        }
    }
}
