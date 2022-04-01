using System;

namespace Converter{
    class Program
    {
        // Main Method
        static public void Main(String[] args)
        {
            Measure m = new Measure();
            Money y = new Money();
            Temperature t = new Temperature();
            int menu = 0;
            int submenu = 0;
            
            do
            {
                //Main Menu
                Console.WriteLine("Welcome to the Multifunction Menu!");
                Console.WriteLine("1 - Measure Converter");
                Console.WriteLine("2 - Money Converter");
                Console.WriteLine("3 - Temperature Converter");
                Console.WriteLine("4 - Exit");
                Console.WriteLine();
                Console.Write("Select a number to continue: ");
                menu = Convert.ToInt32(Console.ReadLine());

                //Main menu error handling
                while (menu < 1 || menu > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option!");
                    Console.Write("Please, choose again: ");
                    menu = Convert.ToInt32(Console.ReadLine());
                }

                //If measurement
                if(menu == 1)
                {
                    do
                    {
                        //Measurement submenu
                        Console.Clear();
                        Console.WriteLine("You chose the measurement option!");
                        Console.WriteLine("1 - CM to M");
                        Console.WriteLine("2 - M to CM");
                        Console.WriteLine("3 - Return to lest menu");
                        Console.Write("Please, choose your measurement option: ");
                        submenu = Convert.ToInt32(Console.ReadLine());

                        //Submenu error handling
                        while (submenu < 1 || submenu > 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid option!");
                            Console.Write("Please, choose again: ");
                            submenu = Convert.ToInt32(Console.ReadLine());
                        }

                        //If cm to m
                        if(submenu == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the measurement in centimeters to convert: ");
                            m.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine(m.varNumb + "CM are equivalent to " + m.centimeters() + "M.");
                            
                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }

                        //if m to cm
                        if(submenu == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the measurement in meters to convert: ");
                            m.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine(m.varNumb + "M are equivalent to " + m.meters() + "CM.");
                            
                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }

                    } while (submenu != 3);
                }

                //If money
                if (menu == 2)
                {
                    do
                    {
                        //Money submenu
                        Console.Clear();
                        Console.WriteLine("You chose the money option!");
                        Console.WriteLine("1 - Real to Dollar");
                        Console.WriteLine("2 - Dollar to Real");
                        Console.WriteLine("3 - Return to lest menu");
                        Console.Write("Please, choose your measurement option: ");
                        submenu = Convert.ToInt32(Console.ReadLine());

                        //Submenu error handling
                        while (submenu < 1 || submenu > 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid option!");
                            Console.Write("Please, choose again: ");
                            submenu = Convert.ToInt32(Console.ReadLine());
                        }

                        //if real to dollar
                        if (submenu == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the amount of Reais to convert: ");
                            y.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("R$" + y.varNumb + " are equivalent to $" + y.reais());

                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }

                        //if dollar to real
                        if (submenu == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the amount of Dollar to convert: ");
                            y.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine("$" + y.varNumb + " are equivalent to R$" + y.dollar());

                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }
                    } while (submenu != 3);
                }

                //If temperature
                if (menu == 3)
                {
                    do
                    {
                        //Temperature submenu
                        Console.Clear();
                        Console.WriteLine("You chose the temperature option!");
                        Console.WriteLine("1 - ºC to ºF");
                        Console.WriteLine("2 - ºF to ºC");
                        Console.WriteLine("3 - Return to lest menu");
                        Console.Write("Please, choose your measurement option: ");
                        submenu = Convert.ToInt32(Console.ReadLine());

                        //Submenu error handling
                        while (submenu < 1 || submenu > 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid option!");
                            Console.Write("Please, choose again: ");
                            submenu = Convert.ToInt32(Console.ReadLine());
                        }

                        //If ºC to ºF
                        if (submenu == 1)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the temperature in Celsius to convert: ");
                            t.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine(t.varNumb + "ºC are equivalent to " + t.celcius() + "ºF.");

                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }

                        //If ºF to ºC
                        if (submenu == 2)
                        {
                            Console.WriteLine();
                            Console.Write("Choose the temperature in Fahrenheit to convert: ");
                            t.varNumb = Convert.ToSingle(Console.ReadLine());

                            Console.WriteLine(t.varNumb + "ºF are equivalent to " + t.fahreinheit() + "ºC.");

                            submenu = 3;
                            Console.WriteLine();
                            Console.Write("Press 'Enter' to continue");
                            Console.ReadKey();
                        }
                    } while (submenu != 3);
                }

                Console.Clear();
            } while (menu != 4);
        }
    }
}
