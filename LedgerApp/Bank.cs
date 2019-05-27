using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace LedgerApp
{
    class Bank
    {
        //Create a new list of Account objects.
        private Dictionary<String, Account> accountDict = new Dictionary<String, Account>();


        //Constructor, initalized to handle output of a negative balance.
        public Bank()
        {
            //Format output for balance if balance is negative.
            //Source: https://dzone.com/articles/display-and-format-negative
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo newCulture = new CultureInfo(currentCulture.Name);
            newCulture.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulture;
        }


        //Main.
        static void Main(string[] args)
        {
            //Create Bank object and run program.
            Bank bank = new Bank();
            bank.runProg();
        }


        //Runs the program by showing menu options.
        private void runProg()
        {
            int userInput = 0;
            greetUser();

            //Loop to show menu contents and get user input until user exits.
            do
            {
                showMenu();
                userInput = getInput(new List<int> { 1, 2, 3 });
                menuChoices(userInput);
            } while (userInput != 3);
        }


        //Greets the user with a brief message.
        private void greetUser()
        {
            string greeting = "Welcome to the World's Best Bank Ledger Program.\n";
            Console.WriteLine(greeting);
        }


        //Shows the user the main console menu.
        private void showMenu()
        {
            string menu = "\n------ Menu ------\n" +
              "1. Login\n" +
              "2. Create account\n" +
              "3. Exit program \n" +
              "------------------\n";
            Console.WriteLine(menu);
        }


        //Gets and validates user input for ALL menu options.
        private int getInput(List<int> validInputs)
        {
            var validInput = false;
            var userInput = "";
            int value = 0;

            //Loop until user chooses a valid menu option.
            do
            {
                //Print correct menu options to console.
                Console.WriteLine(String.Format("\nPlease choose a menu option ({0}): \n", String.Join(", ", validInputs.ToArray())));
                userInput = Console.ReadLine();

                //Check if input is an integer and then valid integer.
                if (int.TryParse(userInput, out value))
                {
                    if (validInputs.Contains(value))
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                }
            } while (validInput == false);

            return value;
        }


        //Takes in user's main menu choice and performs corresponding actions.
        private void menuChoices(int userInput)
        {

            //User chooses to login with an existing account.
            if (userInput == 1)
            {

                Console.WriteLine("\nPlease enter your account username and password.\n");

                //Get user's username.
                Console.Write("Username: ");
                string username = Console.ReadLine();

                //Get user's password and mask input in console.
                //Source at Stack Overflow: https://cutt.ly/wyMWWk
                Console.Write("Password: ");

                string password = "";

                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    password += key.KeyChar;
                }

                //Check that account exists.
                if (!accountDict.ContainsKey(username))
                {
                    Console.WriteLine("\nI'm sorry, there is no account associated with that username.\n");
                    return;
                }

                //Gets the user's account and logs in.
                accountDict[username].logIn(username, password);

                if (!accountDict[username].isAccountLoggedIn())
                {
                    Console.WriteLine("\nError. Your username and password combination is incorrect.\n");
                }
                else
                {
                    Console.WriteLine("\nYou are now logged in!\n");
                    runLoggedInProg(accountDict[username]);
                }

                Console.WriteLine();
                return;
            }

            //User chooses to create a new account.
            else if (userInput == 2)
            {

                Console.WriteLine("\nThank you for creating an account. You will need to enter some information.\n");
                Console.WriteLine("\nPlease enter your first and last name.\n");

                //Get user's first name.
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                //Get user's last name.
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nPlease enter a username and password to finish creating your account.\n");

                //Get user's username.
                Console.Write("Username: ");
                string username = Console.ReadLine();

                //Get user's password and mask input in console.
                //Source at Stack Overflow: https://cutt.ly/wyMWWk
                Console.Write("Password: ");

                string password = "";

                while (true)
                {
                    var key = System.Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    password += key.KeyChar;
                }

                //Check that account doesn't already exist.
                if (accountDict.ContainsKey(username))
                {
                    Console.WriteLine("\nI'm sorry, that username is already taken. Please choosen another.\n");
                    return;
                }

                //Create Account object with user input.
                Account acct = new Account(username, password, firstName, lastName);
                accountDict.Add(username, acct);

                Console.WriteLine("\n\nYour account has been created. You may now log in.\n");
                return;
            }

            else
                Environment.Exit(0);
        }


        //Logged in user menu.
        private void loggedInMenu()
        {
            string menu = "\n-------- User Menu --------\n" +
              "1. Check balance\n" +
              "2. Record deposit\n" +
              "3. Record withdrawal\n" +
              "4. View transaction history\n" +
              "5. Log out \n" +
              "----------------------------";
            Console.WriteLine(menu);
        }


        //Runs portion of program for logged in users.
        private void runLoggedInProg(Account acct)
        {
            int userInput = 0;

            //Loop to show menu contents and get user input until user exits.
            do
            {
                loggedInMenu();
                userInput = getInput(new List<int> { 1, 2, 3, 4, 5 });
                loggedInMenuChoices(acct, userInput);
            } while (userInput != 5);
        }


        //Takes in user's logged in menu choice and performs corresponding actions.
        private void loggedInMenuChoices(Account acct, int userInput)
        {
            switch (userInput)
            {
                //Check account balance.
                case 1:
                    Console.WriteLine("\nYou have a balance of {0:C}.", acct.checkBalance());
                    break;
                //Record deposit.
                case 2:
                    double depositAmount = getValidAmount("deposit");
                    acct.recordDeposit(depositAmount);
                    Console.WriteLine("\nSuccess. {0:c} has been recorded as deposited into your account.\n", depositAmount);
                    break;
                //Record withdrawal.
                case 3:
                    double withdrawalAmount = getValidAmount("withdraw");

                    acct.recordWithdrawal(withdrawalAmount);
                    Console.WriteLine("\nSuccess. {0:C} has been recorded as withdrawn from your account.\n", withdrawalAmount);
                    break;
                //View transaction history.
                case 4:
                    Console.WriteLine("\nYour Transaction History:\n");
                    Console.WriteLine(acct.getTransactionHistoryString());
                    break;
                //Log out.
                case 5:
                    acct.logOut();
                    break;

            }

        }


        //Checks that user has entered a valid dollar amount.
        private double getValidAmount(string operation)
        {
            var validInput = false;
            var userInput = "";
            double amount = 0.0;

            //Loop until user enters a valid amount.
            do
            {
                //Print correct menu options to console.
                Console.WriteLine(String.Format("\nPlease enter the amount you'd like to {0}:\n", operation));
                userInput = Console.ReadLine();

                //Check if input is an double and then valid integer.
                if (double.TryParse(userInput, out amount))
                {
                    if (amount >= 0.0 && (Math.Round(amount, 2) == amount))
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                    }
                }
            } while (validInput == false);

            return amount;
        }




    }


}
