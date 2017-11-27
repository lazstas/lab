class MainClass
    {
        public static void Main(string[] args)
        {
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            Rectangle rect = new Rectangle(5, 4);
            Square square = new Square(5);
            Circle cir = new Circle(5);
            rect.Print();
            square.Print();
            cir.Print();
            List<Figure> fl = new List<Figure>();
            fl.Add(cir);
            fl.Add(rect);
            fl.Add(square);
            Console.WriteLine("Before sort");
            foreach (var x in fl) Console.WriteLine(x);
            fl.Sort();
            Console.WriteLine("After sort");
            foreach (var x in fl) Console.WriteLine(x);
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = square;
            matrix[2, 2, 2] = cir;
            Console.WriteLine(matrix.ToString());
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(cir);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
