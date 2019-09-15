using System;


namespace Figures
{
    public class Rectangle : Figure
    {
        double SideA { get; set; }
        double SideB { get; set; }

        public Rectangle(double SideA, double SideB)
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }
        public override double CalcP()
        {
            return (SideA + SideB) * 2;
        }

        public override double CalcS()
        {
            return SideA * SideB;
        }
        public override string ToString()
        {
            return "Rectangle : SideA=" + Convert.ToString(SideA)
                + " SideB =" + Convert.ToString(SideB)
                + " S=" + Convert.ToString(CalcS())
                + " P=" + Convert.ToString(CalcP());
        }
    }
}
