using System.Drawing;

namespace p2_2_Maranhas_Carmen
{
    internal class Circulo : Figura
    {
        protected double _radio;

        public Circulo(double radio, Color color)
        {
            this._radio = radio;
            this._color = color;

        }
        public override double GetArea()
        {
            return Math.PI * (this._radio * this._radio);

        }
        public double GetRadio() => this._radio;
        public void SetRadio(int radio) => this._radio = radio;
        public override string ToString()
        {
            return $"FIGURA CIRCULO Radio: {_radio}, Color: {_color}";
        }


    }
}