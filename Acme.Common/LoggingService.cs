namespace Acme.Common
{
    public class LoggingService
    {
        public static void WriteTextToFile(List<ILoggable> itemsToLog)
        {
            foreach (var log in itemsToLog)
            {
                Console.WriteLine(log.Log());
            }
        }
    }
}
