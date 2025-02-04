//Calculadora basica en consola 
//Ing. Francisco Guerrero Ferrusca

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora en C#");
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el operador (+, -, *, /): ");
        char operador = Convert.ToChar(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;
        bool operacionValida = true;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Error: Operador no válido.");
                operacionValida = false;
                break;
        }

        if (operacionValida)
            Console.WriteLine($"Resultado: {resultado}");
    }
}
