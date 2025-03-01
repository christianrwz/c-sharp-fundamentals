class EmailService
{
  public void SendEmail()
  {
    Connect();
    Authenticate();
    Console.WriteLine("Sending email...");
    Disconnect();
  }

/* 
  All the methods below are private and not exposed to other classes. 
  Other classes only need to send emails, 
  so there's no need for them to deal with the complexities of connecting to the mail server, 
  authenticating, or disconnecting. 
*/

  private void Connect()
  {
    Console.WriteLine("Connecting to email server...");
  }

  private void Authenticate()
  {
    Console.WriteLine("Authenticating...");
  }

  private void Disconnect()
  {
    Console.WriteLine("Disconnecting from email server...");
  }
}
