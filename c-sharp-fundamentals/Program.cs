// *ABSTRACTION: Reduce complexity by hiding unecessarry details

// !BAD: Because all the method are exposed and need to invoke once the class is used 

BadEmailService badEmailService = new();
badEmailService.Connect();
badEmailService.Authenticate();
badEmailService.SendEmail();
badEmailService.Disconnect();

// *GOOD: Because without abstraction user doesn't need to know all the internal logic invlove in sending email

EmailService emailService = new();
emailService.SendEmail();

// *NOTE: It simplifies the process by hiding the complex details of connecting to the mail server, authenticating, and disconnecting.
