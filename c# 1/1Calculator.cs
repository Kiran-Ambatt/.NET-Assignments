/* 1.	Write a Simple console Application Calculator with the help of Visual Studio .NET IDE which will perform following operations on two numbers:
a.	Addition.
b.	Subtraction.
c.	Multiplication.
d.	Division
Accept input from user and display results on console. Make use of loops, switch case wherever required
 */
class Calculator
{
    static void Main(string[] args)
    {
        int n1;
        int n2;
        string operand;
        ConsoleKeyInfo status;
        float answer;

        while (true)
        {
            Console.Write("Please enter the first integer: ");//Reading first number from user
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second integer: ");//Reading second number from user
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter an operand (+, -, /, *): ");//Reading operand from user
            operand = Console.ReadLine();

            switch (operand)//switch statement is used for the operations
            {
                case "-":
                    answer = n1 - n2;
                    break;
                case "+":
                    answer = n1 + n2;
                    break;
                case "/":
                    answer = n1 / n2;
                    break;
                case "*":
                    answer = n1 * n2;
                    break;
                default:
                    answer = 0;
                    break;
            }

            Console.WriteLine(n1.ToString() + " " + operand + " " + n2.ToString() + " = " + answer.ToString());
            Console.WriteLine("\n\n Do You Want To Break (y/n)");
            status = Console.ReadKey();//it will take the status from the user that is y/n
            if (status.Key == ConsoleKey.Y)//if yes then it will break
            {
                break;
            }
            Console.Clear();//for clearing fields
        }
    }
}
