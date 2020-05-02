using System;
using System.Collections.Generic;
using System.Threading;

namespace CashMachine
{
    class Program
    {
        static double balance = 1000;
        static int pinCode = 1234;
        static List<Transactions> transactionList = new List<Transactions>();
        static int language;

        static void Main(string[] args)   
        {
            ChooseLanguage();
        }

        static void ChooseLanguage()
        {
            try
            {
                Console.WriteLine("Choose your language: \n 1 - EN, \n 2 - LT, \n 3 - RUS");
                int chosenLanguage = Convert.ToInt32(Console.ReadLine());
                language = chosenLanguage;
                SayHello(chosenLanguage);
            }
            catch (Exception ex)
            {
                ChooseLanguage();
            }

        }

        private static void SayHello(int chosenLanguage)
        {
            try
            {
                switch (chosenLanguage)
                {
                    case 1:
                        Console.WriteLine("Hello");
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        Console.WriteLine("Laba diena");
                        Thread.Sleep(1000);
                        break;
                    case 3:
                        Console.WriteLine("Добрый день");
                        Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("Wrong input format");
                        Thread.Sleep(1000);
                        Console.Clear();
                        ChooseLanguage();
                        break;
                }
                EnterPinCode();
            }
            catch (Exception ex)
            {
                Console.Clear();
                ChooseLanguage();
            }
        }

        private static void EnterPinCode()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter PIN code");

                        int enteredPin = Convert.ToInt32(Console.ReadLine());

                        int attemptNum = 1;

                        while (enteredPin != pinCode && attemptNum < 3)
                        {
                            if (enteredPin != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"Wrong PIN. Try again. Number of attempts left: {3 - attemptNum}");
                            }
                            attemptNum++;
                            enteredPin = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Your card is blocked");
                            Environment.Exit(0);
                        }

                        if (enteredPin == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("Correct PIN");
                            Thread.Sleep(1000);
                            Menu();
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Įveskite PIN kodą");

                        int enteredPinLt = Convert.ToInt32(Console.ReadLine());

                        int attemptNumLt = 1;

                        while (enteredPinLt != pinCode && attemptNumLt < 3)
                        {
                            if (enteredPinLt != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"Neteisingas PIN. Bandykite vėl. Liko bandymų: {3 - attemptNumLt}");
                            }
                            attemptNumLt++;
                            enteredPinLt = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNumLt == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Jūsų kortelė užblokuota");
                            Environment.Exit(0);
                        }

                        if (enteredPinLt == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("Teisingas PIN");
                            Thread.Sleep(1000);
                            Menu();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите ПИН код");

                        int enteredPinRu = Convert.ToInt32(Console.ReadLine());

                        int attemptNumRu = 1;

                        while (enteredPinRu != pinCode && attemptNumRu < 3)
                        {
                            if (enteredPinRu != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"Неверный ПИН. Попробуйте снова. Осталось попыток: {3 - attemptNumRu}");
                            }
                            attemptNumRu++;
                            enteredPinRu = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNumRu == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Ваша карточка заблокирована");
                            Environment.Exit(0);

                        }

                        if (enteredPinRu == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("Верный ПИН код");
                            Thread.Sleep(1000);
                            Menu();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                switch(language)
                    {
                    case 1:
                        Console.WriteLine($"Incorrect PIN format: {ex.Message}");
                        Thread.Sleep(1000);
                        EnterPinCode();
                        break;
                    case 2:
                        Console.WriteLine($"Neteisingas PIN kodo formatas: {ex.Message}");
                        Thread.Sleep(1000);
                        EnterPinCode();
                        break;
                    case 3:
                        Console.WriteLine($"Неверный формат ПИН кода: {ex.Message}");
                        Thread.Sleep(1000);
                        EnterPinCode();
                        break;
                }
            }
        }

        private static void Menu()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--------- MENU ---------");
                        Console.WriteLine("1 - Change Language");
                        Console.WriteLine("2 - Change PIN");
                        Console.WriteLine("3 - Check my Balance");
                        Console.WriteLine("4 - Transactions List");
                        Console.WriteLine("5 - Make Deposit");
                        Console.WriteLine("6 - Payments and Transfer");
                        Console.WriteLine("7 - End Work");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--------- MENIU ---------");
                        Console.WriteLine("1 - Keisti kalbą");
                        Console.WriteLine("2 - Keisti PIN kodą");
                        Console.WriteLine("3 - Sąskaitos likutis");
                        Console.WriteLine("4 - Sąskaitos išrasas");
                        Console.WriteLine("5 - Inešti pinigus");
                        Console.WriteLine("6 - Pervesti pinigus");
                        Console.WriteLine("7 - Baigti darbą");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--------- МЕНЮ ---------");
                        Console.WriteLine("1 - Изменить язык");
                        Console.WriteLine("2 - Изменить ПИН код");
                        Console.WriteLine("3 - Остаток на счету");
                        Console.WriteLine("4 - Список операций");
                        Console.WriteLine("5 - Внести деньги");
                        Console.WriteLine("6 - Переводы и оплаты");
                        Console.WriteLine("7 - Завершить работу");
                        break;
                }

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ChangeLanguage();
                        break;
                    case 2:
                        ChangePinCode();
                        break;
                    case 3:
                        AccountInvoice();
                        break;
                    case 4:
                        Invoice();
                        break;
                    case 5:
                        InsertMoney();
                        break;
                    case 6:
                        TransferMoney();
                        break;
                    case 7:
                        EndWork();
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Menu();
            }
        }

        private static void Invoice()
        {
            switch (language)
            {
                case 1:
                    Console.WriteLine("List of Your operations:");
                    foreach (var transaction in transactionList)
                    {
                        Console.WriteLine($"\n {transaction.TransactionPurpose} \n {transaction.Sum} {transaction.Currency} \n {transaction.Date}.");
                    }
                    Thread.Sleep(2000);
                    MenuOrFinish();

                    break;

                case 2:
                    Console.WriteLine("Jūsų atliktos operacijos:");
                    foreach (var transaction in transactionList)
                    {
                        Console.WriteLine($"\n {transaction.TransactionPurpose} \n {transaction.Sum} {transaction.Currency} \n {transaction.Date}.");
                    }
                    Thread.Sleep(2000);
                    MenuOrFinish();

                    break;

                case 3:
                    Console.WriteLine("Список Ваших операций:");
                    foreach (var transaction in transactionList)
                    {
                        Console.WriteLine($"\n {transaction.TransactionPurpose} \n {transaction.Sum} {transaction.Currency} \n {transaction.Date}.");
                    }
                    Thread.Sleep(2000);
                    MenuOrFinish();

                    break;
            }
        }

        private static void ChangePinCode()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter Your PIN");

                        int enteredPin = Convert.ToInt32(Console.ReadLine());

                        int attemptNum = 1;

                        while (enteredPin != pinCode && attemptNum < 3)
                        {
                            if (enteredPin != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"Wrong PIN. Try again. Number of attempts left: {3 - attemptNum}");
                            }
                            attemptNum++;
                            enteredPin = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNum == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Your card is blocked");
                            Environment.Exit(0);
                        }

                        if (enteredPin == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("PIN correct");
                            Thread.Sleep(1000);

                            Console.Clear();
                            Console.WriteLine("Enter NEW 4 digits PIN");
                            int newPin = Convert.ToInt32(Console.ReadLine());

                            if (newPin > 9999 || newPin < 999)
                            {
                                Console.WriteLine("Wrong PIN format. Try again");
                                newPin = Convert.ToInt32(Console.ReadLine());
                            }
                            if (newPin < 9999 || newPin > 999)
                            {
                                Console.WriteLine("New PIN is saved");
                                pinCode = newPin;
                            }
                        }
                        Thread.Sleep(2000);
                        MenuOrFinish();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Įveskite PIN kodą");

                        int enteredPinLt = Convert.ToInt32(Console.ReadLine());

                        int attemptNumLt = 1;

                        while (enteredPinLt != pinCode && attemptNumLt < 3)
                        {
                            if (enteredPinLt != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"PIN neteisingas. Bandykite dar. Liko bandymu: {3 - attemptNumLt}");
                            }
                            attemptNumLt++;
                            enteredPinLt = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNumLt == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Jūsų kortelė užblokuota");
                            Environment.Exit(0);
                        }

                        if (enteredPinLt == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("PIN teisingas");
                            Thread.Sleep(1000);

                            Console.Clear();
                            Console.WriteLine("Įveskite NAUJĄ 4 skaičių PIN kodą");
                            int newPin = Convert.ToInt32(Console.ReadLine());

                            if (newPin > 9999 || newPin < 999)
                            {
                                Console.WriteLine("PIN formatas neteisingas. Įveskite iš naujo");
                                newPin = Convert.ToInt32(Console.ReadLine());
                            }
                            if (newPin < 9999 || newPin > 999)
                            {
                                Console.WriteLine("Naujas PIN išsaugotas");
                                pinCode = newPin;
                            }
                        }
                        Thread.Sleep(2000);
                        MenuOrFinish();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите ПИН код");

                        int enteredPinRu = Convert.ToInt32(Console.ReadLine());

                        int attemptNumRu = 1;

                        while (enteredPinRu != pinCode && attemptNumRu < 3)
                        {
                            if (enteredPinRu != pinCode)
                            {
                                Console.Clear();
                                Console.WriteLine($"Неверный ПИН. Попробуйте снова. Осталось попыток: {3 - attemptNumRu}");
                            }
                            attemptNumRu++;
                            enteredPinRu = Convert.ToInt32(Console.ReadLine());
                        }

                        if (attemptNumRu == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Ваша карточка заблокирована");
                            Environment.Exit(0);
                        }

                        if (enteredPinRu == pinCode)
                        {
                            Console.Clear();
                            Console.WriteLine("Верный ПИН код");
                            Thread.Sleep(1000);

                            Console.Clear();
                            Console.WriteLine("Введите НОВЫЙ 4-х значный ПИН код");
                            int newPin = Convert.ToInt32(Console.ReadLine());

                            if (newPin > 9999 || newPin < 999)
                            {
                                Console.WriteLine("Неверный формат ПИН. Повторите попытку");
                                newPin = Convert.ToInt32(Console.ReadLine());
                            }
                            if (newPin < 9999 || newPin > 999)
                            {
                                Console.WriteLine("Новый ПИН сохранён");
                                pinCode = newPin;
                            }
                        }
                        Thread.Sleep(2000);
                        MenuOrFinish();
                        break;
                }
            }
            catch (Exception ex)
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine($"Wrong input format");
                        Thread.Sleep(1000);
                        ChangePinCode();

                        break;

                    case 2:
                        Console.WriteLine($"Neteisingas įvedimo formatas");
                        Thread.Sleep(1000);
                        ChangePinCode();

                        break;

                    case 3:
                        Console.WriteLine($"Неверный формат ввода");
                        Thread.Sleep(1000);
                        ChangePinCode();
                        break;
                }
            }
        }

        private static void InsertMoney()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine("Choose currency: 1 - EUR, 2 - USD.");
                        string chosenCurrency = Console.ReadLine();

                        switch (chosenCurrency)
                        {
                            case "1":
                                chosenCurrency = "EUR";
                                break;
                            case "2":
                                chosenCurrency = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("How much do you want to deposit?");
                        int insertedSum = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Your current balance is: {balance = balance + insertedSum}");

                        Transactions tranzakcija = new Transactions() { TransactionPurpose = "Deposit", Sum = insertedSum, Currency = chosenCurrency, Date = $"Data: {DateTime.Now}" };
                        transactionList.Add(tranzakcija);
                        break;

                    case 2:
                        Console.WriteLine("Pasirinkite valiutą: 1 - EUR, 2 - USD.");
                        string chosenCurrencyLt = Console.ReadLine();

                        switch (chosenCurrencyLt)
                        {
                            case "1":
                                chosenCurrencyLt = "EUR";
                                break;
                            case "2":
                                chosenCurrencyLt = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Kiek pinigų norite įnešti?");
                        int insertedSumLt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Jūsų sąskaitos likutis yra: {balance = balance + insertedSumLt}");

                        Transactions tranzakcijaLt = new Transactions() { TransactionPurpose = "Sąskaitos papildymas", Sum = insertedSumLt, Currency = chosenCurrencyLt, Date = $"Data: {DateTime.Now}" };
                        transactionList.Add(tranzakcijaLt);
                        break;

                    case 3:
                        Console.WriteLine("Выберите валюту: 1 - EUR, 2 - USD.");
                        string chosenCurrencyRu = Console.ReadLine();

                        switch (chosenCurrencyRu)
                        {
                            case "1":
                                chosenCurrencyRu = "EUR";
                                break;
                            case "2":
                                chosenCurrencyRu = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Какую сумму хотите внести?");
                        int insertedSumRu = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Ваш остаток на счету: {balance = balance + insertedSumRu}");

                        Transactions tranzakcijaRu = new Transactions() {TransactionPurpose = "Пополнение счёта", Sum = insertedSumRu, Currency = chosenCurrencyRu, Date = $"Data: {DateTime.Now}" };
                        transactionList.Add(tranzakcijaRu);
                        break;
                }

            }
            catch (Exception ex)
            {
                InsertMoney();
            }
            Thread.Sleep(2000);
            MenuOrFinish();
        }

        private static void TransferMoney()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine("Choose currency: 1 - EUR, 2 - USD.");
                        string chosenCurrency = Console.ReadLine();

                        switch (chosenCurrency)
                        {
                            case "1":
                                chosenCurrency = "EUR";
                                break;
                            case "2":
                                chosenCurrency = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("How much do you want to transfer?");
                        double takenSum = Convert.ToDouble(Console.ReadLine());

                        if (takenSum > balance)
                        {
                            Console.WriteLine("Ammount is bigger than your current balance");
                            Thread.Sleep(1000);
                            TransferMoney();
                        }

                        Console.WriteLine("Enter purpose of transaction");
                        string transferPurpose = Console.ReadLine();

                        if (takenSum < balance)
                        {
                            Console.WriteLine($"Your current balance is: {balance = balance - takenSum}");
                            Transactions tranzakcija = new Transactions() { TransactionPurpose = transferPurpose, Sum = takenSum, Currency = chosenCurrency, Date = $"Data: {DateTime.Now}" };
                            transactionList.Add(tranzakcija);
                        }

                        break;

                    case 2:
                        Console.WriteLine("Pasirinkite valiutą: 1 - EUR, 2 - USD.");
                        string chosenCurrencyLt = Console.ReadLine();

                        switch (chosenCurrencyLt)
                        {
                            case "1":
                                chosenCurrencyLt = "EUR";
                                break;
                            case "2":
                                chosenCurrencyLt = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Kiek pinigų norite pervesti?");
                        double takenSumLt = Convert.ToDouble(Console.ReadLine());

                        if (takenSumLt > balance)
                        {
                            Console.WriteLine("Suma viršyja sąskaitos likutį");
                            Thread.Sleep(1000);
                            TransferMoney();
                        }

                        Console.WriteLine("Įveskite mokėjimo paskirtį");
                        string transferPurposeLt = Console.ReadLine();

                        if (takenSumLt < balance)
                        {
                            Console.WriteLine($"Jūsų sąskaitos likutis yra: {balance = balance - takenSumLt}");
                            Transactions tranzakcija = new Transactions() { TransactionPurpose = transferPurposeLt, Sum = takenSumLt, Currency = chosenCurrencyLt, Date = $"Data: {DateTime.Now}" };
                            transactionList.Add(tranzakcija);
                        }

                        break;

                    case 3:
                        Console.WriteLine("Выберите валюту: 1 - EUR, 2 - USD.");
                        string chosenCurrencyRu = Console.ReadLine();

                        switch (chosenCurrencyRu)
                        {
                            case "1":
                                chosenCurrencyRu = "EUR";
                                break;
                            case "2":
                                chosenCurrencyRu = "USD";
                                break;
                            default:
                                break;
                        }

                        Console.WriteLine("Какую сумму хотите перевести?");
                        double takenSumRu = Convert.ToDouble(Console.ReadLine());

                        if (takenSumRu > balance)
                        {
                            Console.WriteLine("Сумма превышает остаток на счету");
                            Thread.Sleep(1000);
                            TransferMoney();
                        }

                        Console.WriteLine("Введите цель перевода");
                        string transferPurposeRu = Console.ReadLine();

                        if (takenSumRu < balance)
                        {
                            Console.WriteLine($"Ваш остаток на счету: {balance = balance - takenSumRu}");
                            Transactions tranzakcija = new Transactions() { TransactionPurpose = transferPurposeRu, Sum = takenSumRu, Currency = chosenCurrencyRu, Date = $"Data: {DateTime.Now}" };
                            transactionList.Add(tranzakcija);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                TransferMoney();
            }
            Thread.Sleep(2000);
            MenuOrFinish();
        }

        private static void ChangeLanguage()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine("Choose language: \n 1 - EN, \n 2 - LT, \n 3 - RUS");
                        int newLanguage = Convert.ToInt32(Console.ReadLine());

                        switch (newLanguage)
                        {
                            case 1:
                                Console.WriteLine("ENGLISH language chosen");
                                break;
                            case 2:
                                Console.WriteLine("Pasirinkta LIETUVIŲ kalba");
                                break;
                            case 3:
                                Console.WriteLine("Выбран РУССКИЙ язык");
                                break;
                            default:
                                Console.WriteLine("Wrong input format");
                                Thread.Sleep(1000);
                                ChangeLanguage();
                                break;
                        }
                        language = newLanguage;
                        break;

                    case 2:
                        Console.WriteLine("Pasirinkite kalba: \n 1 - EN, \n 2 - LT, \n 3 - RUS");
                        int newLanguageLt = Convert.ToInt32(Console.ReadLine());

                        switch (newLanguageLt)
                        {
                            case 1:
                                Console.WriteLine("ENGLISH language chosen");
                                break;
                            case 2:
                                Console.WriteLine("Pasirinkta LIETUVIŲ kalba");
                                break;
                            case 3:
                                Console.WriteLine("Выбран РУССКИЙ язык");
                                break;
                            default:
                                Console.WriteLine("Neteisingas įvedimo formatas");
                                Thread.Sleep(1000);
                                ChangeLanguage();
                                break;
                        }
                        language = newLanguageLt;
                        break;

                    case 3:
                        Console.WriteLine("Выберите НОВЫЙ язык: \n 1 - EN, \n 2 - LT, \n 3 - RUS");
                        int newLanguageRu = Convert.ToInt32(Console.ReadLine());

                        switch (newLanguageRu)
                        {
                            case 1:
                                Console.WriteLine("ENGLISH language chosen");
                                break;
                            case 2:
                                Console.WriteLine("Pasirinkta LIETUVIŲ kalba");
                                break;
                            case 3:
                                Console.WriteLine("Выбран РУССКИЙ язык");
                                break;
                            default:
                                Console.WriteLine("Неверный формат ввода");
                                Thread.Sleep(1000);
                                ChangeLanguage();
                                break;
                        }
                        language = newLanguageRu;
                        break;
                }
            }
            catch (Exception ex)
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine($"Wrong input format");
                        Thread.Sleep(1000);
                        ChangeLanguage();
                        break;

                    case 2:
                        Console.WriteLine($"Neteisingas įvedimo formatas");
                        Thread.Sleep(1000);
                        ChangeLanguage();
                        break;

                    case 3:
                        Console.WriteLine($"Неверный формат ввода");
                        Thread.Sleep(1000);
                        ChangeLanguage();
                        break;

                }
            }
            Thread.Sleep(2000);
            Menu();
        }

        private static void AccountInvoice()
        {
            switch (language)
            {
                case 1:
                    Console.WriteLine($"Your current balance is {balance}");

                    Thread.Sleep(2000);
                    MenuOrFinish();
                    break;

                case 2:
                    Console.WriteLine($"Jūsų sąskaitos likutis yra {balance}");

                    Thread.Sleep(2000);
                    MenuOrFinish();
                    break;

                case 3:
                    Console.WriteLine($"Ваш остаток на счету {balance}");

                    Thread.Sleep(2000);
                    MenuOrFinish();
                    break;
            }
        }

        private static void MenuOrFinish()
        {
            try
            {
                switch (language)
                {
                    case 1:
                        Console.WriteLine("What to do next? \n 1 - Go back to Menu. \n 2 - End work.");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Menu();
                                break;
                            case 2:
                                EndWork();
                                break;
                            default:
                                Console.WriteLine("Wrong input format");
                                Thread.Sleep(1000);
                                MenuOrFinish();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ka norite daryti toliau? \n 1 - Grįžti i Menių. \n 2 - Baigti darbą.");
                        int choiceLt = Convert.ToInt32(Console.ReadLine());

                        switch (choiceLt)
                        {
                            case 1:
                                Menu();
                                break;
                            case 2:
                                EndWork();
                                break;
                            default:
                                Console.WriteLine("Neteisingas įvedimo formatas");
                                Thread.Sleep(1000);
                                MenuOrFinish();
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Что хотите делать дальше? \n 1 - Вернуться в Меню. \n 2 - Завершить работу.");
                        int choiceRu = Convert.ToInt32(Console.ReadLine());

                        switch (choiceRu)
                        {
                            case 1:
                                Menu();
                                break;
                            case 2:
                                EndWork();
                                break;
                            default:
                                Console.WriteLine("Неверный формат ввода");
                                Thread.Sleep(1000);
                                MenuOrFinish();
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MenuOrFinish();
            }
        }

        private static void EndWork()
        {
            switch (language)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Thank you for using our services.");
                    Environment.Exit(0);

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ačiū, kad naudojatės mūsų paslaugomis.");
                    Environment.Exit(0);

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Спасибо, что пользуетесь нашими услугами.");
                    Environment.Exit(0);

                    break;
            }
        }

    }
}