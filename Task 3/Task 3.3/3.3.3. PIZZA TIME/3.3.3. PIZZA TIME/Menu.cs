using System;
using System.Collections.Generic;
using System.Text;

namespace _3._3._3._PIZZA_TIME
{
    class Menu
    {
        private enum MenuPizza
        {
            Pepperoni = 1,
            Mexican,
            Hawaiian,
            Double_Pepperoni,
            Meat,
            Sicilian,
            Cheesy,
            Ham_and_Cheese,
            Margarita,
            BBQ,
            Mushroom,
            Clear,
            Complete_order,
            Exit
        }

        public void addPizza()
        {
            List<string> food = new List<string>();
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("*** Menu ***");
                Console.Write("Choose pizza:" + Environment.NewLine +
                   "1: Pepperoni" + Environment.NewLine +
                   "2: Mexican" + Environment.NewLine +
                   "3: Hawaiian" + Environment.NewLine +
                   "4: Double_Pepperoni" + Environment.NewLine +
                   "5: Meat" + Environment.NewLine +
                   "6: Sicilian" + Environment.NewLine +
                   "7: Cheesy" + Environment.NewLine +
                   "8: Ham_and_Cheese" + Environment.NewLine +
                   "9: Margarita" + Environment.NewLine +
                   "10: BBQ" + Environment.NewLine +
                   "11: Mushroom" + Environment.NewLine +
                   "12: Clear" + Environment.NewLine +
                   "13: Complete_order" + Environment.NewLine +
                   "14: Exit");
                Console.WriteLine();

                MenuPizza pizza = (MenuPizza)Int32.Parse(Console.ReadLine());

                switch (pizza)
                {
                    case MenuPizza.Pepperoni:
                        if (!food.Contains("Pepperoni"))
                        {
                            food.Add("Pepperoni");
                        }
                        else
                        {
                            food.Remove("Pepperoni");
                        }
                        break;
                    case MenuPizza.Mexican:
                        if (!food.Contains("Mexican"))
                        {
                            food.Add("Mexican");
                        }
                        else
                        {
                            food.Remove("Mexican");
                        }
                        break;
                    case MenuPizza.Hawaiian:
                        if (!food.Contains("Hawaiian"))
                        {
                            food.Add("Hawaiian");
                        }
                        else
                        {
                            food.Remove("Hawaiian");
                        }
                        break;
                    case MenuPizza.Double_Pepperoni:
                        if (!food.Contains("Double_Pepperoni"))
                        {
                            food.Add("Double_Pepperoni");
                        }
                        else
                        {
                            food.Remove("Double_Pepperoni");
                        }
                        break;
                    case MenuPizza.Meat:
                        if (!food.Contains("Meat"))
                        {
                            food.Add("Meat");
                        }
                        else
                        {
                            food.Remove("Meat");
                        }
                        break;
                    case MenuPizza.Sicilian:
                        if (!food.Contains("Sicilian"))
                        {
                            food.Add("Sicilian");
                        }
                        else
                        {
                            food.Remove("Sicilian");
                        }
                        break;
                    case MenuPizza.Cheesy:
                        if (!food.Contains("Cheesy"))
                        {
                            food.Add("Cheesy");
                        }
                        else
                        {
                            food.Remove("Cheesy");
                        }
                        break;
                    case MenuPizza.Ham_and_Cheese:
                        if (!food.Contains("Ham_and_Cheese"))
                        {
                            food.Add("Ham_and_Cheese");
                        }
                        else
                        {
                            food.Remove("Ham_and_Cheese");
                        }
                        break;
                    case MenuPizza.Margarita:
                        if (!food.Contains("Margarita"))
                        {
                            food.Add("Margarita");
                        }
                        else
                        {
                            food.Remove("Margarita");
                        }
                        break;
                    case MenuPizza.BBQ:
                        if (!food.Contains("BBQ"))
                        {
                            food.Add("BBQ");
                        }
                        else
                        {
                            food.Remove("BBQ");
                        }
                        break;
                    case MenuPizza.Mushroom:
                        if (!food.Contains("Mushroom"))
                        {
                            food.Add("Mushroom");
                        }
                        else
                        {
                            food.Remove("Mushroom");
                        }
                        break;
                    case MenuPizza.Clear:
                        if (!food.Contains("Choose pizza:"))
                        {
                            food.Clear();
                        }
                        Console.WriteLine("Choose pizza:");
                        break;
                    case MenuPizza.Complete_order:
                        return;                
                    case MenuPizza.Exit:
                        return;
                }
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.WriteLine("You chose pizza:" + string.Join(", ", food));
            } while (true);
        }
    }
}
