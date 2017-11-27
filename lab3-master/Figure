 abstract class Figure : IComparable
    {

        public string Type
        { get; set; }
        public abstract double Area();

        public override string ToString()
        {
            return this.Type + "area " + this.Area().ToString();
        }
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1;
        }
    }
    /// <summary>
    /// Print.
    /// </summary>
    interface IPrint
    {
        void Print();
    }
    /// <summary>
    /// Rectangle.
    /// </summary>
    class Rectangle : Figure, IPrint
    {
        double height;
        double width;
        public Rectangle(double ph, double pw)
        {
            this.height = ph;
            this.width = pw;
            this.Type = " rectangle ";
        }
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
    /// <summary>
    /// Square.
    /// </summary>
    class Square : Rectangle, IPrint
    {
        public Square(double size)
            : base(size, size)
        {
            this.Type = " square ";
        }
    }
    /// <summary>
    /// Circle.
    /// </summary>
    class Circle : Figure, IPrint
    {
        double rad;
        public Circle(double pr)
        {
            this.rad = pr;
            this.Type = " Circle ";
        }
        public override double Area()
        {
            double Result = Math.PI * this.rad * this.rad;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
