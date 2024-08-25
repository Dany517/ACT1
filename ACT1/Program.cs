using System;

class Program
{
    static void Main()
    {
        int numero = 25;
        double decimalNum = 3.14;
        char letra = 'A';
        string texto = "Hola";
        bool esVerdadero = true;


        Console.WriteLine("Suma (int + double): " + (numero + decimalNum));
        Console.WriteLine("Resta (int - double): " + (numero - decimalNum));
        Console.WriteLine("Multiplicación (int * double): " + (numero * decimalNum));
        Console.WriteLine("División (int / double): " + (numero / decimalNum));

        Console.WriteLine("Suma (char + string): " + (letra + texto));
        Console.WriteLine("Suma (string + char): " + (texto + letra));


        Console.WriteLine("Suma (string + double): " + (texto + decimalNum));

        Console.WriteLine("Suma (char + int): " + (letra + numero));
        Console.WriteLine("Resta (char - int): " + (letra - numero));
        Console.WriteLine("Multiplicación (char * int): " + (letra * numero));
        Console.WriteLine("División (char / int): " + (letra / numero));

        Console.WriteLine("Suma (bool + int): " + ((esVerdadero ? 1 : 0) + numero));
        Console.WriteLine("Multiplicación (bool * double): " + ((esVerdadero ? 1 : 0) * decimalNum));

        Console.WriteLine("Entero: " + numero);
        Console.WriteLine("Decimal: " + decimalNum);
        Console.WriteLine("Caracter: " + letra);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Booleano: " + esVerdadero);
    }
}
