//necesario para usar la estructura Color
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
    //llamadas a las clases
    List<Figura> figuras = new List<Figura>();
    Rectangulo r1 = new Rectangulo(4,4);
    figuras.Add(r1);
    Circulo c1 = new Circulo(4);
    figuras.Add(c1);



    foreach (Figura figura in figuras){
    Console.WriteLine(figura.GetArea());

    }

  }

}