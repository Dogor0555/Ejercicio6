using System;

void ConvertirYRedondear(string numeroStr)
{
    double numero = double.Parse(numeroStr); // Convertir string a double
    int redondeado = (int)Math.Round(numero); // Redondear al entero más cercano

    Console.WriteLine("Númeroo redondeado: " + redondeado);
}

ConvertirYRedondear("12.5");
