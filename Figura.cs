using System.Drawing;
using System.Dynamic;

namespace p2_2_Maranhas_Carmen;

internal abstract class Figura
{
  protected Color _color;

  public abstract double GetArea();

  public void SetColor(byte alpha, byte red, byte green, byte blue){
      this._color = Color.FromArgb(alpha, red, green, blue);
    }

}
 


