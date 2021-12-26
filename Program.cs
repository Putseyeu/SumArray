using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0];
            string userInput;
            bool exit = false;
            Console.WriteLine($"Введите числа от {int.MinValue} до {int.MaxValue}." +
                $" sum - ввывод суммы введеных чисел. exit - выйти из программы");            

            while (exit != true)
            {                
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine();
                if (userInput == "exit")
                {
                    exit = true;
                }

                else if (userInput == "sum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine("Сумма равна " + sum);                    
                }
                else
                {
                    int intValue;
                    if (int.TryParse(userInput, out intValue))
                    {                      
                        int[] tempNumbers = new int[numbers.Length + 1];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }
                        tempNumbers[tempNumbers.Length - 1] = intValue;
                        numbers = tempNumbers;                                       
                    }
                    else
                    {
                        Console.WriteLine("Не известная команада.");
                    }
                } 
            }
        }
    }
}
