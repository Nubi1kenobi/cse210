using System;
using System.Drawing;

namespace Learning05
{
    // public class Shape
    public abstract class Shape
        {
            private string _color;

            public Shape(string color)
                {
                    _color = color;
                }

            public string GetColor()
                {
                    return _color;
                }

            public void SetColor(string color)
                {
                    _color = color;
                }

            // public virtual double GetArea()
            // {
            //     return -1;
            // }
             public abstract double GetArea();
        }
}