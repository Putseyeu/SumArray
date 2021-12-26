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
            int sum = 0;            
            int tempNumber;
            string userInput = "";
            bool exit = false;
            Console.WriteLine($"Введите числа от {int.MinValue} до {int.MaxValue}." +
                $" Sum - ввывод суммы введеных чисел. Exit - выйти из программы");            

            while (exit == false)
            {                
                Console.Write("Введите число или команду: ");
                userInput = Console.ReadLine();
                if (userInput == "exit")
                {                    
                    break;
                }

                if (userInput == "sum")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine("Сумма равна " + sum);
                    userInput = "";
                    sum = 0;
                }
                else
                {
                    int intValue;
                    if (int.TryParse(userInput, out intValue))
                    {
                        tempNumber = Convert.ToInt32(userInput);                        
                        int[] tempNumbers = new int[numbers.Length + 1];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }
                        tempNumbers[tempNumbers.Length - 1] = tempNumber;
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
