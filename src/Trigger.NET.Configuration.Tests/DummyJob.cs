namespace Trigger.NET.Configuration.Tests
{
    internal class DummyJob : IJob
    {
        public void Execute(JobContext context)
        {
            // NOP
        }
    }
}