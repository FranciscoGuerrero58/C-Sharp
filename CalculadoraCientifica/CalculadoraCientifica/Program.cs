//Calculadora con + - * / y ^2 


class Program
{
    static void Main()
    {
        Console.WriteLine("Lee correctamente las instrucciones");
        Console.WriteLine("Ingresa el primer número");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("¿Qué operación deseas elegir? +, -, *, /, ^ ");
        char oper = Convert.ToChar(Console.ReadLine());

        double result = 0;
        bool validOperation = true;

        if (oper == '^')
        { result = Math.Pow(num1, 2); }
        else
        {
            Console.WriteLine("Ingresa el segundo número");
            double num2 = Convert.ToDouble(Console.ReadLine());



            switch (oper)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num1 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error, división entre 0");
                        validOperation = false;
                    }
                    break;


                default:
                    Console.WriteLine("Error: operador no valido");
                    validOperation = false;
                    break;

            }
        }
        if (validOperation)
        {
            Console.WriteLine($"El resultado es: {result}");
        }
    }
}