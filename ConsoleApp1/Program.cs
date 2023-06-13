using System.Linq.Expressions;
using System.Xml.Schema;

namespace ConsoleApp1
{
   
internal class Program
    {
        static void Gitd(int firstNumber, int secondNumber)
        {
            int total = firstNumber - secondNumber;
            Console.WriteLine($"{firstNumber} - {secondNumber} = {total}");
        }

        static void Main(string[] args)
        {
            //welcoming massege
            Console.WriteLine("welcom to my game! Let's do some Math!");
            Console.WriteLine("Pleace enter number greater than 0");
            int[] arr;
            try { 
                // read length of array

               int firstNumber = Convert.ToInt32(Console.ReadLine());
               arr = new int[firstNumber];
                for(int i = 0; i < firstNumber; i++)
                {
                    Console.WriteLine($"Pleace enter number :{i+1} of {firstNumber}");
                    int key = Convert.ToInt32(Console.ReadLine());
                    if (key > 0)
                    {
                        arr[i] = key;
                    }
                    else
                    {
                        Console.WriteLine("You should Enter Number Greater Than zero");
                    }
                   

                }
                GitSum(arr);
                // summation for all array
                static void GitSum(int [] arr)
                {
                    int total2 =1;
                    int total = 0;
                   for(int i=0; i < arr.Length; i++)
                    {
                       total=total + arr[i];
                    }
                    Console.WriteLine($"please select random Number between 1 and {arr.Length}");
                    int number = Convert.ToInt32(Console.ReadLine());
                   
                    if (number > 0 && number <= arr.Length )
                    {
                         total2 = total * arr[number];
                    }
                    else { Console.WriteLine("wrong input"); }

                    Console.WriteLine($"please select number to divid your product {total} by");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    double number1 = total2 / number2;

                    Console.WriteLine($"your array saiz: {arr.Length+1}");
                    Console.Write("the numbers in the array:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]} ,");
                    }
                    Console.WriteLine($"the sum of the array: {total}");
                    Console.WriteLine($"{total} * {arr[number]} = {total2}");
                    Console.WriteLine($"{total2} / {number2} = {number1}");
                   
                }
                


            }
            catch(OverflowException ex){
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
           
            finally { Console.WriteLine("The app is completed"); }
        }
    }
}