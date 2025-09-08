namespace SOLID.S.BetterExample
{
    public class EmailSender
    {
        public void SendEmail(string message, string recipient)
        {
            Console.WriteLine($"Sending email to {recipient}: {message}");
        }
    }
}