using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Index1 = 0;
            //int Index2 = 0;
            string Choise = "";
            String UserChoise = "";
            Console.WriteLine("PLZ Enter The Length Of The Array  !?");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
          Start:  Console.WriteLine("Enter 1 to insert index and value to array");
            Console.WriteLine("Enter 2 to Print elements of array");
            Console.WriteLine("Enter 3 To Do Mathimatical process");
            int Process = int.Parse(Console.ReadLine());
            if (Process == 1)
            {
            enterArray: Console.Write("enter index that you want insert value it : ");
                int index = int.Parse(Console.ReadLine());
                if (index < 0 || index >= arr.Length)
                {
                    Console.WriteLine("try again !");
                    goto enterArray;
                }

                Console.Write("enter value that in index #No \'{0}\' : ", index);
                int value = int.Parse(Console.ReadLine());
                arr[index] = value;
                goto Start;
            }
            else if (Process == 2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "     ");
                }
                Console.WriteLine("");
                goto Start;
            }
            else if (Process == 3)
            {
                do
                {
                    Console.WriteLine("Enter the Index Of  Element You Want To process ");
                    Result = arr[int.Parse(Console.ReadLine())];
                    Console.WriteLine("Choose The Operation  ");
                    Console.WriteLine("1) + " + "      2) - ");
                    Console.WriteLine("3) * " + "      4) / ");
                    for (int i = 0; ; i++)
                    {
                    Ch: Choise = Console.ReadLine();
                        if (Choise == "+")
                        {
                            Index1 = int.Parse(Console.ReadLine());
                            if (Index1 <= arr.Length)
                                Result = Result + arr[Index1];
                            else
                            {
                                Console.WriteLine("Error !!");
                                Console.WriteLine("Choose Again");
                                goto Ch;
                            }
                        }
                        else if (Choise == "-")
                        {
                            Index1 = int.Parse(Console.ReadLine());
                            if (Index1 <= arr.Length)
                                Result = Result - arr[Index1];
                            else
                            {
                                Console.WriteLine("Error !!");
                                Console.WriteLine("Choose Again");
                                goto Ch;
                            }
                        }
                        else if (Choise == "*")
                        {
                            Index1 = int.Parse(Console.ReadLine());
                            if (Index1 <= arr.Length)
                                Result = Result * arr[Index1];
                            else
                            {
                                Console.WriteLine("Error !!");
                                Console.WriteLine("Choose Again");
                                goto Ch;
                            }
                        }
                        else if (Choise == "/")
                        {
                            Index1 = int.Parse(Console.ReadLine());
                            if (Index1 <= arr.Length)
                                Result = Result / arr[Index1];
                            else
                            {
                                Console.WriteLine("Error !!");
                                Console.WriteLine("Choose Again");
                                goto Ch;
                            }
                        }
                        else if (Choise == "=")
                        {
                            Console.WriteLine(Result);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choise");
                        }

                    }

                    do
                    {
                        Console.WriteLine("DO You Want To Continue - YES Or NO");
                        UserChoise = Console.ReadLine().ToUpper();
                        if (UserChoise != "YES" && UserChoise != "NO")
                        {
                            Console.WriteLine("InValid Choice , PLZ Enter YES Or No !!");
                        }
                    }
                    while (UserChoise != "YES" && UserChoise != "NO");
                }
                while (UserChoise == "YES");
                Console.WriteLine("Result =" + Result);
            }
            else
            {
                Console.WriteLine("Invalid Choise");
                goto Start;

            }
        }
    }
}
