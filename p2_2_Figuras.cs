﻿//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
using p2_2_Maranhas_Carmen;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
    double suma = 0;

    //llamadas a las clases
    List<Figura> lista_figuras = new List<Figura>();
    Rectangulo r1 = new Rectangulo(4,5);
    lista_figuras.Add(r1);
    Circulo c1 = new Circulo(4);
    lista_figuras.Add(c1);
    Triangulo t1 = new Triangulo(4);
    lista_figuras.Add(t1);
    t1 = new Triangulo(5);
    lista_figuras.Add(t1);
    Triangulo t2 = new Triangulo(5);
    lista_figuras.Add(t2);
    Rectangulo r2 = new Rectangulo(5,6);
    lista_figuras.Add(r2);
    Circulo c2 = new Circulo(5);
    lista_figuras.Add(c2);
    



    foreach (Figura figura in lista_figuras){
    Console.WriteLine(figura.ToString());
    Console.WriteLine($"El area es: {figura.GetArea()}");
    Console.WriteLine();
    suma += figura.GetArea();

    }
    Console.WriteLine($"La suma total del area es: {suma}");


  }

}