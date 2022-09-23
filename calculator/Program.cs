using System;

namespace CalculatorJastin;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        Console.WriteLine("Enter the action to be performed");
        Console.WriteLine("Press 0 to quit the calculator");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division \n");
        while (true)
        {
            string? command = Console.ReadLine();
            if (command == null){
                continue;
            }
            if (command.Equals("0")) {
                Environment.Exit(0);
            }
            else if (command.Equals("1") || command.Equals("2") || command.Equals("3") || command.Equals("4")) {
                Console.WriteLine("enter first number:");
                int input1 = numberInput();
                Console.WriteLine("enter second number:");
                int input2 = numberInput();
                if (command.Equals("1")){
                    result = Addition(input1, input2);
                    break;
                }
                if (command.Equals("2")){
                    result = Subtraction(input1, input2);
                    break;
                }
                if (command.Equals("3")){
                    result = Multiplication(input1, input2);
                    break;
                }
                if (command.Equals("4")){
                    result = Division(input1, input2);
                    break;
                }
            }
            else{
                Console.WriteLine("wrong command");
                continue;
            }
        }
    Console.WriteLine("The result is " + result);  
    }
    //number inputing   
    public static int numberInput()
    {
        try{
            int numberInput = Convert.ToInt32(Console.ReadLine());
            return numberInput;
        }
        catch (ArgumentException e) {
            throw e;
        }
    }
    //Addition  
    public static int Addition(int input1, int input2)
    {
        int result = input1 + input2;
        return result;
    }
    //Substraction  
    public static int Subtraction(int input1, int input2)
    {
        int result = input1 - input2;
        return result;
    }
    //Multiplication  
    public static int Multiplication(int input1, int input2)
    {
        int result = input1 * input2;
        return result;
    }
    //Division  
    public static int Division(int input1, int input2)
    {
        int result = input1 / input2;
        return result;
    }  
    }

