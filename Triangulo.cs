using System.Drawing;
using System.Reflection;
namespace p2_2_Maranhas_Carmen{


internal class Triangulo : Figura{
    protected double _lado;
    

    public Triangulo( double lado, Color color){
        _lado = lado;
        this._color = color;

        //_color = color;
    }

    public override double GetArea(){
        double altura = Math.Sqrt(_lado*_lado-((_lado/2)*(_lado/2)));

        return this._lado * altura/2;
    }

    public double GetLado() => this._lado;
    public void SetLado(int lado) => this._lado = lado;
    public override string ToString()
        {
            return $"FIGURA TRIANGULO Lado: {_lado}, Color: {_color}";
        }


}
}