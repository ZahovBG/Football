using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public abstract class FootbalPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public FootbalPlayer(string name, int age,int number, double height) : base(name,age)
        {
            Number = number;
            Height = height;
        }
    }
}
