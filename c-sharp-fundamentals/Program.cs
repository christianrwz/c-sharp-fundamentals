// Instruction: Uncomment the code enclosed by region to make it work

#region -- ENCAPSULATION USAGE --

/*  Bad Approach
    Path: OopPrinciples/Encapsulation/Bad
*/

BadBankAccount badBankAccount = new BadBankAccount();
badBankAccount.balance = 100;

Console.WriteLine(badBankAccount.balance);

/* Good Approach
Path: OopPrinciples/Encapsulation/Good

*Explaination: 
- 'balance' is not directly accessed because its private so the data is encapsulated within the class and method dictates the rules of how it can be accessed and modified ensuring that our programs rules and logic can't be violated.
- Encapsulation abstracts away the complexity of implementation details and allowing users to focus on higher level functionality provided by 'BankAccount' class.
*/

BankAccount bankAccount = new BankAccount(100);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(150);
Console.WriteLine(bankAccount.GetBalance());

// TODO: You can experiment with various scenarios here, such as depositing or withdrawing negative amounts, and more.

#endregion