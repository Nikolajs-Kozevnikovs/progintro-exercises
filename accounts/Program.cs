int[] accounts = { 903, 716, 67 };

int GetAccountNumber ()
{
  Console.WriteLine("\nEnter an account number: ");
  return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId)
{
  Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}

while (true) {
  try
  {
    int accountId = GetAccountNumber();
    PrintAccountState(accountId);
  }
  catch (IndexOutOfRangeException e)
  {
    Console.WriteLine("Specfied id not found within accounts!");
  } catch (FormatException e)
  {
    Console.WriteLine("Wrong input, try again!");
  }
}