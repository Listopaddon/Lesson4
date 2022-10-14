using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Menu
    {
        public void MenuUser()
        {
            OperationsWithArray operations = new OperationsWithArray();
            Console.WriteLine("1 - Enter rows and columns array manual");
            Console.WriteLine("2 - Leave the size of the array by default");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.Write("Enter quantity rows - ");
                        string number1 = Console.ReadLine();
                        int rows = CheckStringOnNumber(number1);
                        Console.WriteLine();
                        Console.Write("Enter quantity columns - ");
                        string number2 = Console.ReadLine();
                        int columns = CheckStringOnNumber(number2);
                        OperationsWithArray operationsWithArray = new OperationsWithArray(rows, columns);
                        operations = operationsWithArray;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    goto case 2;
                case 2:
                    for (; ; )
                    {
                        Console.WriteLine("Chose action");
                        Console.WriteLine();
                        Console.WriteLine("1 - Filling array manual");
                        Console.WriteLine("2 - Filling array random");
                        Console.WriteLine("3 - Sort array ascending");
                        Console.WriteLine("4 - Sort array descending");
                        Console.WriteLine("5 - Search all positive numbers");
                        Console.WriteLine("6 - Search all negative numbers");
                        Console.WriteLine("7 - Inversion array");
                        Console.WriteLine("8 - Output matrix");
                        Console.WriteLine("0 - Exit");

                        int action = int.Parse(Console.ReadLine());

                        switch (action)
                        {
                            case 1:
                                operations.FillingArrayManually();
                                break;
                            case 2:
                                operations.FillingArrayRandom();
                                break;
                            case 3:
                                operations.SortArrayAscending();
                                break;
                            case 4:
                                operations.SortArrayDescending();
                                break;
                            case 5:
                                Console.WriteLine($"Result = {operations.SearchPositiveNumbers()}");
                                break;
                            case 6:
                                Console.WriteLine($"Result = {operations.SearchNegativeNumbers()}");
                                break;
                            case 7:
                                operations.InversionArray();
                                break;
                            case 8:
                                operations.OutputMatrix();
                                break;
                            case 0:
                                Console.WriteLine("Good buy");
                                return;
                            default:
                                break;
                        }
                    };
                    break;
                default:
                    break;
            }
        }

        private int CheckStringOnNumber(string number)
        {
            int result;
            if (int.TryParse(number, out int numberCheck))
            {
                result = int.Parse(number);
                return result;
            }

            throw new Exception("Wrong enterd symbols");
        }
    }
}
