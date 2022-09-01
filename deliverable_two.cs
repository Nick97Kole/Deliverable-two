using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
                int customers = Convert.ToInt32(Console.ReadLine());
                int w = 0;
                int c = 0;

            while (customers == 1) //first
                {
                
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + " buffets " + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;  
                }

                while (customers == 2) //second
            {
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 2, water or coffee");
                string customer2 = Console.ReadLine();
                if (customer2 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer2 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + " buffets " + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;
            }

                while (customers == 3)
            {
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 2, water or coffee");
                string customer2 = Console.ReadLine();
                if (customer2 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer2 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 3, water or coffee");
                string customer3 = Console.ReadLine();
                if (customer3 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer3 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + " buffets " + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;
            }
                while (customers == 4)
            {
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 2, water or coffee");
                string customer2 = Console.ReadLine();
                if (customer2 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer2 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 3, water or coffee");
                string customer3 = Console.ReadLine();
                if (customer3 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer3 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 4, water or coffee");
                string customer4 = Console.ReadLine();
                if (customer4 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer4 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + "buffets" + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;
            }

                while (customers == 5)
            {
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 2, water or coffee");
                string customer2 = Console.ReadLine();
                if (customer2 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer2 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 3, water or coffee");
                string customer3 = Console.ReadLine();
                if (customer3 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer3 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 4, water or coffee");
                string customer4 = Console.ReadLine();
                if (customer4 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer4 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 5, water or coffee");
                string customer5 = Console.ReadLine();
                if (customer5 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer5 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + " buffets " + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;
            }

                while (customers == 6)
            {
                Console.WriteLine("Alright, person number 1, water or coffee");
                string customer1 = Console.ReadLine();
                if (customer1 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer1 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 2, water or coffee");
                string customer2 = Console.ReadLine();
                if (customer2 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer2 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 3, water or coffee");
                string customer3 = Console.ReadLine();
                if (customer3 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer3 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 4, water or coffee");
                string customer4 = Console.ReadLine();
                if (customer4 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer4 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 5, water or coffee");
                string customer5 = Console.ReadLine();
                if (customer5 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer5 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }

                Console.WriteLine("Alright, person number 6, water or coffee");
                string customer6 = Console.ReadLine();
                if (customer6 == "water")
                {
                    Console.WriteLine("water good choice!");
                    w++;
                }
                else if (customer6 == "coffee")
                {
                    Console.WriteLine("coffee, Okay!");
                    c++;
                }
                else
                {
                    Console.WriteLine("We dont have that. No drink for you");
                }
                Console.WriteLine("ok, so thats " + c + " coffees and " + w + " waters, Ill be right back. Feel free to grab your food");
                Console.WriteLine("");
                Console.WriteLine(customers + " buffets " + customers * 9.99);
                Console.WriteLine(c + " Coffees " + c * 2);
                Console.WriteLine(w + " waters " + "Free");
                break;
            }













        }
    }
}
