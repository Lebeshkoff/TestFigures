using System;

namespace Figures
{
    public class Circle : Figure
    {
        public double R { get; set; } //поле класса напрямую обращаться нельзя, обращение через get set

        public Circle(double R)
        {
            this.R = R;
        }

        public override double CalcP()
        {
            return 2 * Math.PI * R;
        }

        public override double CalcS()
        {
            return Math.PI * R * R;
        }

        public override string ToString()
        {
            return "Circle : R=" + Convert.ToString(R)
                + " S=" + Convert.ToString(CalcS())
                + " P=" + Convert.ToString(CalcP());
        }

    }
}
