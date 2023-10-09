using System.Drawing;
namespace p2_2_Maranhas_Carmen{


internal class Rectangulo : Figura{
    protected double _lado1;
    protected double _lado2;

    public Rectangulo( double lado1, double lado2, Color color){
        _lado1 = lado1;
        _lado2 = lado2;
        this._color = color;
        //_color = color;
    }

    public override double GetArea(){
        return this._lado1 * this._lado2;
    }

    public double GetLado1() => this._lado1;
    public double GetLado2() => this._lado2;
    public void SetLado1(int lado1) => this._lado1 = lado1;
    public void SetLado2(int lado2) => this._lado2 = lado2;
    public override string ToString()
        {
            return $"FIGURA RECTANGULO Alto: {_lado1}, Ancho: {_lado2}, Color: {_color}";
        }

}
}