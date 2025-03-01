class BadEmailService
{
  public void SendEmail()
  {
    Console.WriteLine("Sending email...");
  }

/*
  All the methods below are public and exposed to other classes. 
  These methods must be called manually after instantiating this class.
*/

  public void Connect()
  {
    Console.WriteLine("Connecting to email server...");
  }

  public void Authenticate()
  {
    Console.WriteLine("Authenticating...");
  }

  public void Disconnect()
  {
    Console.WriteLine("Disconnecting from email server...");
  }
}
