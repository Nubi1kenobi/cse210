namespace Learning05
{
    public class Square : Shape
        {
            private double _side;

            public Square(string color, double sided) : base(color)
                {
                    _side = sided;
                }

            public override double GetArea()
                {
                    return (_side * _side);
                }
        }
}