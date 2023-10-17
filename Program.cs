using System;

//Exercício 1: Classe Mensagem
// public class Program
// {
//     public static void BemVindo()
//     {
//         Console.WriteLine("Bem-vindo ao C#");
//     }

//     public static void Main()
//     {
//         BemVindo();
//     }
// }


//Exercício 2: Classe Quadrado
// public class MinhaClasse
// {
//     private int numero;

//     public MinhaClasse(int numero)
//     {
//         this.numero = numero;
//     }

//     public void ImprimirQuadradoDoNumero()
//     {
//         int quadrado = numero * numero;
//         Console.WriteLine($"O quadrado do número {numero} é: {quadrado}");
//     }

//     public static void Main()
//     {
//         MinhaClasse minhaInstancia = new MinhaClasse(5);

//         minhaInstancia.ImprimirQuadradoDoNumero();
//     }
// }


//Exercício 3: Classe CalculadoraSimples
// public class Calculadora
// {
//     public static int Soma(int a, int b)
//     {
//         return a + b;
//     }

//     public static double Soma(double a, double b)
//     {
//         return a + b;
//     }

//     public static decimal Soma(decimal a, decimal b)
//     {
//         return a + b;
//     }

//     public static void Main()
//     {
//         int resultadoInt = Soma(5, 3);
//         Console.WriteLine("Soma de inteiros: " + resultadoInt);

//         double resultadoDouble = Soma(4.5, 2.7);
//         Console.WriteLine("Soma de doubles: " + resultadoDouble);

//         decimal resultadoDecimal = Soma(10.25m, 5.75m);
//         Console.WriteLine("Soma de decimais: " + resultadoDecimal);
//     }
// }


//Exercício 4: Classe Concatenador
// public class MinhaClasse
// {
//     public static string Concatenar(string str1, string str2)
//     {
//         return str1 + str2;
//     }

//     public static string Concatenar(string str1, string str2, string str3)
//     {
//         return str1 + str2 + str3;
//     }

//     public static string Concatenar(string str1, string str2, string str3, string str4)
//     {
//         return str1 + str2 + str3 + str4;
//     }

//     public static void Main()
//     {
//         string resultado1 = Concatenar("Olá, ", "Mundo!");
//         Console.WriteLine("Concatenação 1: " + resultado1);

//         string resultado2 = Concatenar("O", "lá, ", "Meu ", "Amigo!");
//         Console.WriteLine("Concatenação 2: " + resultado2);
//     }
// }


//Exercício 5: Classe ConversorTemperatura
// public class ConversorDeTemperatura
// {
//     public static double CelsiusParaFahrenheit(double temperaturaCelsius)
//     {
//         double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;
//         return temperaturaFahrenheit;
//     }

//     public static void Main()
//     {
//         double temperaturaCelsius = 25.0;
//         double temperaturaFahrenheit = CelsiusParaFahrenheit(temperaturaCelsius);

//         Console.WriteLine($"{temperaturaCelsius} graus Celsius são equivalentes a {temperaturaFahrenheit} graus Fahrenheit.");
//     }
// }


//Exercício 6: Classe Data
// public class MinhaClasse
// {
//     private DateTime data;

//     public MinhaClasse(DateTime data)
//     {
//         this.data = data;
//     }

//     public void ImprimirDataFormatada()
//     {
//         Console.WriteLine("Data formatada: " + data.ToString("dd/MM/yyyy"));
//     }

//     public static void Main()
//     {
//         DateTime data = DateTime.Now; // Exemplo de data atual

//         MinhaClasse minhaInstancia = new MinhaClasse(data);
//         minhaInstancia.ImprimirDataFormatada();
//     }
// }


//Exercício 7: Classe CalculadoraArea
// public class FormaGeometrica
// {
//     public double CalcularArea(double raio)
//     {
//         return Math.PI * raio * raio; // Área do círculo
//     }

//     public double CalcularArea(double largura, double altura)
//     {
//         return largura * altura; // Área do retângulo
//     }

//     public double CalcularArea(double baseMaior, double baseMenor, double altura)
//     {
//         return (baseMaior + baseMenor) * altura / 2.0; // Área do trapézio
//     }

//     public static void Main()
//     {
//         FormaGeometrica forma = new FormaGeometrica();

//         double areaCirculo = forma.CalcularArea(5.0);
//         Console.WriteLine("Área do círculo: " + areaCirculo);

//         double areaRetangulo = forma.CalcularArea(4.0, 6.0);
//         Console.WriteLine("Área do retângulo: " + areaRetangulo);

//         double areaTrapezio = forma.CalcularArea(2.0, 4.0, 3.0);
//         Console.WriteLine("Área do trapézio: " + areaTrapezio);
//     }
// }


//Exercício 8: Classe Tabuada
// public class Tabuada
// {
//     public static void ImprimirTabuada(int numeroBase)
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             int resultado = numeroBase * i;
//             Console.WriteLine($"{numeroBase} x {i} = {resultado}");
//         }
//     }

//     public static void Main()
//     {
//         int numeroBase = 7; // Número base para a tabuada

//         Console.WriteLine($"Tabuada do {numeroBase}:");

//         ImprimirTabuada(numeroBase);
//     }
// }