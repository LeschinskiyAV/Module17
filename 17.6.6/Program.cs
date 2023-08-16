using _17._6._6;

SimpleAccount simpleAccount = new SimpleAccount();
simpleAccount.Balance = 999;
simpleAccount.CalculateInterest();
ShowAccInfo(simpleAccount);
simpleAccount.Balance = 1001;
simpleAccount.CalculateInterest();
ShowAccInfo(simpleAccount);

Console.WriteLine("---------------------------------");

SalaryAccount salaryAccount = new SalaryAccount();
salaryAccount.Balance = 999;
salaryAccount.CalculateInterest();
ShowAccInfo(salaryAccount);
salaryAccount.Balance = 1001;
salaryAccount.CalculateInterest();
ShowAccInfo(salaryAccount);

static void ShowAccInfo(Account account)
{
    Console.WriteLine($"{account} \n Balance: {account.Balance} \n Interest: {account.Interest}");
}