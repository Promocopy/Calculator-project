using System.Xml.Schema;

namespace Calculator
{

    public class calculator
    {
        int num = 0;
        int numb= 0;
        int total = 0;

        public static void Main()
        {

            Console.WriteLine("Enter a number");
            int num =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number");
            int numb = int.Parse(Console.ReadLine());
    
          

             Console.WriteLine("Enter an option:");
            Console.WriteLine("+,Addition");
            Console.WriteLine("-,Subtract");
            Console.WriteLine("*,Multiiply");
            Console.WriteLine("/,Divide");

            switch(Console.ReadLine())
            {

                case "+":
                    var total = num + numb;
                    Console.WriteLine("Your total is num + numb =", +  total);
                    break;
                case "-":
                    var total = num - numb;
                    Console.WriteLine("Your total is num - numb =", +total);
                    break;
                case "*":
                    var total = num * numb;
                    Console.WriteLine("Your total is num * numb =", +total);
                    break;
                case "/":
                    var total = num / numb;
                    Console.WriteLine("Your total is num / numb =", +total);
                    break;
               default:
                    Console.WriteLine("Your total {0} is invalid", total);
                    break;
            }



        }
    }
}