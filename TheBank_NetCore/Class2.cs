using System;
using System.Collections.Generic;
using System.Text;

namespace TheBank_NetCore
{
    using System;
    using System.Collections.Generic;

        public class TheBankHong : IBank
        {
            List<Balance> listOfAccounts = new List<Balance>();
            public TheBankHong()
            {
            }

            public bool AccountExists(string accountHolder)
            {
                foreach (Balance account in listOfAccounts)
                {
                    if (account.AccountHolder.Equals(accountHolder))
                    {
                        Console.WriteLine("Account exist");
                        return true;

                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                        return false;
                    }
                }
                return false;
            }

            public void CreateAccount(string accountHolder)
            {
                Balance newAccount = new Balance(accountHolder);
                listOfAccounts.Add(newAccount);
            }

            public void Deposit(string accountHolder, decimal amount)
            {
                if (amount > 0)
                {
                    foreach (Balance account in listOfAccounts)
                    {
                        if (account.AccountHolder.Equals(account.AccountHolder))
                        {
                            account.Deposit(amount);
                        }
                        else { Console.WriteLine($"{accountHolder} does not exist"); }
                    }
                }
                else
                {
                    Console.WriteLine("Can not deposit less than zero");
                }
            }

            public decimal GetBalance(string accountHolder)
            {
                foreach (Balance account in listOfAccounts)
                {
                    if (accountHolder.Equals(account.AccountHolder))
                    {
                        return account.GetBalance;
                    }
                    else { Console.WriteLine($"{accountHolder} does not exist"); }
                }

                return GetBalance(accountHolder);
            }

            public bool Transfer(string fromAccount, string toAccount, decimal amount)
            {

                if (AccountExists(fromAccount) == true && AccountExists(toAccount) == true)
                {
                    foreach (Balance account in listOfAccounts)
                    {
                        if (account.Equals(fromAccount))
                        {
                            if (account.GetBalance < amount)
                            {
                                account.Withdraw(amount);
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Can not transfer greater than account balance");
                                return false;
                            }
                        }

                    }
                    foreach (Balance account in listOfAccounts)
                    {
                        if (account.Equals(toAccount))
                        {
                            account.Deposit(amount);
                            return true;
                        }
                    }
                }
                return false;
            }

            public bool Withdraw(string accountHolder, decimal amount)
            {


                foreach (Balance account in listOfAccounts)
                {
                    if (account.AccountHolder.Equals(accountHolder))
                    {
                        if (amount > account.GetBalance)
                        {
                            Console.WriteLine("Can not withdraw");
                        }
                        else
                        {
                            account.Withdraw(amount);
                            return true;
                        }
                    }
                }
                return false;

            }
        }
    }