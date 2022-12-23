using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace AutomatKonsol
{
    public class Application 
    {
        private bool loopIsRuning = true; // To stop the loop if its nedded.

        private Coffee coffee = new Coffee("Coffee", 99.00, "Original Blend Coffee, Medium Roast Coffee");
        private Milk milk = new Milk("Milk", 19.00, "100% Lactose Free 2% Reduced Fat Milk");
        private Pepsi pepsi = new Pepsi("Pepsi", 35.00, "Pepsi is a cola that contains caffeine. Classic taste.");

        private Burger burger = new Burger("Burger", 100.00, "Grilled beef patty topped tomatoes, lettuce, mayonnaise, ketchup.");
        private Pizza pizza= new Pizza("Pizza", 145.00, "Grilled Chicken, Green Peppers, Onions, Savoury BBQ Sauce.");
        private Sandwich sandwich = new Sandwich("sandwich", 85.00, "Delicious sandwich with irresistible ingredients.");

        private RainJacket rainJacket = new RainJacket("RainJacket", 1500.00, "Waterproof Rain Jacket, Lightweight, Outdoor Raincoat.");
        private RainShoe rainShoe = new RainShoe("RainShoe", 900.00, "Rain Boots Waterproof, Anti-Slip Rain Shoes. ");
        private Umbrella umbrella = new Umbrella("Umbrella", 200.00, "Compact Travel Umbrella, Pocket Portable Folding Windproof Mini Umbrella.");

        private AutomatBank automatBank = new AutomatBank();

        // List to save the purchased products
        private List<Product> ProductList = new List<Product>();


        public void Run()
        {
            TakeDeposit();
            Console.Clear();

           while (loopIsRuning)
           {
                ShowMenu();

                var input = ReadInput();

                if (IsQuitCommand(input))
                    return;

                ProcessInput(input);

           }


        }

        private string ReadInput()
        {

            return Console.ReadLine() ?? string.Empty;

        }

        private void ShowMenu()
        {
            Console.WriteLine("Choose the product type :");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Liquid Product");
            Console.WriteLine("2. Meal Product");
            Console.WriteLine("3. Rough Weather Products");
            Console.WriteLine();
            Console.WriteLine("Write 'Quit' To quit the program!");

        }


        private bool IsQuitCommand(string input)
        {
            return input.Equals("quit", StringComparison.InvariantCultureIgnoreCase);

        }

       

        private void ProcessInput(string input)
        {
 
            var newInput = input;


             switch (newInput)
             {
                     case "1":
                         Console.Clear();
                         LiquidProduct(input);
                         break;
                     case "2":
                         Console.Clear();
                         MealProduct(input);
                         break;
                     case "3":
                         Console.Clear();
                         RoughWeather(input);
                         break;
                     case "4":
                          Console.Clear();
                          break;
                     default:
                         Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                         Console.ReadKey();
                         Console.Clear();
                         break;

             } 



        }

        //Menu and alternatives for Liquid Products
        private void LiquidProduct(string input)
        {
            Console.WriteLine("Choose Desired Product :");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Milk");
            Console.WriteLine("3. Pepsi");
            Console.WriteLine();
            Console.WriteLine("4. Return to the principle menu");
          

            var newInput = ReadInput();


            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    coffee.Description(coffee.Name, coffee.Price, coffee.Informations);
                    BuyOrReturn(newInput, coffee, coffee);
                    break;
                case "2":
                    Console.Clear();
                    milk.Description(milk.Name, milk.Price, milk.Informations);
                    BuyOrReturn(newInput, milk, milk);
                    break;
                case "3":
                    Console.Clear();
                    pepsi.Description(pepsi.Name, pepsi.Price, pepsi.Informations);
                    BuyOrReturn(newInput, pepsi, pepsi);
                    break;
                case "4":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }


        }

        //Menu and alternatives for Meal Products
        private void MealProduct(string input)
        {
            Console.WriteLine("Choose Desired Product :");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Burger");
            Console.WriteLine("2. Pizza");
            Console.WriteLine("3. Sandwich");
            Console.WriteLine();
            Console.WriteLine("4. Return to the principle menu");


            var newInput = ReadInput();


            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    burger.Description(burger.Name, burger.Price, burger.Informations);
                    BuyOrReturn(newInput, burger, burger);
                    break;
                case "2":
                    Console.Clear();
                    pizza.Description(pizza.Name, pizza.Price, pizza.Informations);
                    BuyOrReturn(newInput, pizza, pizza);
                    break;
                case "3":
                    Console.Clear();
                    sandwich.Description(sandwich.Name, sandwich.Price, sandwich.Informations);
                    BuyOrReturn(newInput, sandwich, sandwich);
                    break;
                case "4":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }


        }

        //Menu and alternatives for Rough Weather Products
        private void RoughWeather(string input)
        {
            Console.WriteLine("Choose Desired Product :");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Rain Jacket");
            Console.WriteLine("2. Rain Shoe");
            Console.WriteLine("3. Umbrella");
            Console.WriteLine();
            Console.WriteLine("4. Return to the principle menu");


            var newInput = ReadInput();


            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    rainJacket.Description(rainJacket.Name, rainJacket.Price, rainJacket.Informations);
                    BuyOrReturn(newInput, rainJacket, rainJacket);
                    break;
                case "2":
                    Console.Clear();
                    rainShoe.Description(rainShoe.Name, rainShoe.Price, rainShoe.Informations);
                    BuyOrReturn(newInput, rainShoe, rainShoe);
                    break;
                case "3":
                    Console.Clear();
                    umbrella.Description(umbrella.Name, umbrella.Price, umbrella.Informations);
                    BuyOrReturn(newInput, umbrella, umbrella);
                    break;
                case "4":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }


        }

        // Ask the user if he wants to buy the product or he wants return to the principle Menu
        private void BuyOrReturn(string input, Product prd, IUsable iprd)
        {
            

            Console.WriteLine();
            Console.WriteLine("1- Buy the product");
            Console.WriteLine("2- Return to the principle Menu");

            var newInput = ReadInput();

            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    AddToShoppingList(prd);
                    iprd.Buy(prd.Name);
                    BuyMoreOrCheckout(prd);
                    break;
                case "2":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }


        }

        // Ask the user if he wants to buy more products or he wants to checkout
        private void BuyMoreOrCheckout(Product prd)
        {
            Console.WriteLine();
            Console.WriteLine("1- Buy more");
            Console.WriteLine("2- Checkout");
            Console.WriteLine("3- Cancel the operation");

            var newInput = ReadInput();

            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Checkout(CountChange());
                    Console.WriteLine();
                    UseProduct();
                    Console.ReadKey();
                    QuitProgramOrStartNewOperation();
                    break;
                case "3":
                    Console.Clear();
                    CancelPayment();
                    Run();
                    break;
                default:
                    Console.WriteLine("You entered an invalid input. (Press any key to continue...)");
                    Console.ReadKey();
                    Console.Clear();
                    break;

            }
        }

        // Allow the user to Quit the program if wanted or start New Operation
        private void QuitProgramOrStartNewOperation()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to quit the Program");
            Console.WriteLine("Press any key then Enter to start a new Operation");
            

            var newInput = ReadInput();

            switch (newInput)
            {
                case "1":
                    Console.Clear();
                    loopIsRuning = false;
                    break;
               
                default:
                    Console.Clear();
                    CancelPayment();
                    Run();
                    break;

            }

        }


        public double Change(double amount)
        {
            if (amount > automatBank.Saldo)
                throw new InvalidOperationException("Your money is not enough to pay for the products");

            double change = automatBank.Saldo - amount;

            return change;
        }

        public double CountChange()
        {
            double sum = 0;

            foreach (var item in automatBank.ProductPrice)
            {
                sum += item;
            }

            return Change(sum);
        }

        // Take deposit from the user
        public void TakeDeposit()
        {
            Console.WriteLine("Write your deposit amount : ");
            double deposit = double.Parse(ReadInput());

            if (deposit <= 0)
                throw new ArgumentException("Invalid deposite");

            automatBank.Saldo += deposit;

        }

        // Count change and show information about deposit, change and change form 
        public void Checkout(double change)
        {

            int hundraKronor = (int) change / 100;
            change = change % 100;
            int femtioKronor = (int)change / 50;
            change = change % 50;
            int tjugoKronor = (int)change / 20;
            change = change % 20;
            int tioKronor = (int)change / 10;
            change = change % 10;
            int femKronor = (int)change / 5;
            change = change % 5;
            int Kronor = (int)change / 1;

            int[] arr = { hundraKronor, femtioKronor, tjugoKronor, tioKronor, femKronor, Kronor };
            string[] arrStr = { "100 Kr", "50 kr", "20 Kr", "10 kr", "5 Kr", "1 kr" };

            Console.WriteLine("Thank you for buying from us!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"You paid {automatBank.Saldo} kr \nAfter deducting the cost of your purchases, You are left with {CountChange()} kr");
            Console.WriteLine("You can take your change as : ");

            for (int i = 0, j = 0; i < arr.Length; i++, j++)
            {
                if (arr[i] > 0)
                    Console.WriteLine($"{arr[i]} ---> {arrStr[j]}");

            }
        }

        private void AddToShoppingList(Product prd)
        {

            automatBank.ProductPrice.Add(prd.Price);
            ProductList.Add(prd);

        }

        private void CancelPayment()
        {

            automatBank.ProductPrice.Clear();
            ProductList.Clear();
            automatBank.Saldo = 0;
        }

        // Show the user that he can use his product depending on the type of product
        private void UseProduct()
        {
            

            foreach (var item in ProductList)
            {
                if (item is IUsableLiquid)
                {
                    var liquid = (IUsableLiquid)item;
                    liquid.Use(item.Name);
                }

                else if (item is IUsablaMeal)
                {
                    var meal = (IUsablaMeal)item;
                    meal.Use(item.Name);
                }

                else if (item is IUsableRoughWeather)
                {
                    var roughWeather = (IUsableRoughWeather)item;
                    roughWeather.Use(item.Name);
                }

            }
        }
    }

}

