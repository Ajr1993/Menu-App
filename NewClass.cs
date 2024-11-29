using System.Security.Cryptography.X509Certificates;

namespace MyProject;

public class NewClass{
    public static void main(string[] args){
        Console.WriteLine("PLease enter a number: ");
        int num1;
        if(int.TryParse(Console.ReadLine(), out num1)){
            Console.WriteLine("You entered:" + num1);
        }
        Console.WriteLine("PLease enter a second number: ");
        int num2;
        if(int.TryParse(Console.ReadLine(), out num2)){
            Console.WriteLine("You have entered " + num2);
        }

        Console.WriteLine("Please choose from the following options: ");
        Console.WriteLine("Option 1 = plus, Option 2 = minus, Option 3 = times and option 4 = divide ");
        string options = Console.ReadLine();
    }

        public static int Calculation(int num1, int num2, string options){
        switch(options){
            case "1": 
            Console.WriteLine("+");
            return num1 + num2;
            case "2":
            Console.WriteLine("-");
            return num1 - num2;
            case "3":
            Console.WriteLine("*");
            return num1 * num2;
            case "4":
            Console.WriteLine("/");
            return num1 / num2;
            default:
            Console.WriteLine("Invalid number");
            return -1;
        }
        }


    }

