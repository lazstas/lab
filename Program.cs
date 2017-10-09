using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks; using System; namespace ConsoleApp2 {
	class Program
	{
		static double readIntFromConsole()
		{
			while (true)
			{
				string keyboardInput = Console.ReadLine();

				int result;
				if (int.TryParse(keyboardInput, out result))
				{
					return result;
				}
				else
				{
					Console.WriteLine("Неправильный ввод, попробуй еще раз");
				}
			}
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			Double A, B, C;
			Double D, d;
			while (0 != 1)
			{
				Console.WriteLine("Уравнение имеет вид A*x^2+B*x+C=0");
				Console.WriteLine("Введите А:");                 A = 0;                 while (A <= 0)
                {
                    A = readIntFromConsole();                     if (A <= 0)                         Console.WriteLine("Уравнение не квадратное, введите A больше 0");                 }
				Console.WriteLine("Введите B:");
				B = readIntFromConsole();
				Console.WriteLine("Введите C:");
				C = readIntFromConsole();
				Console.WriteLine("Ваше yравнение имеет вид " + A.ToString() + "*x^2+" + B.ToString() + "*x+" + C.ToString() + "=0");

				D = (B * B) - (4 * A * C);
				d = Math.Sqrt(D);
				if (D == 0)
				{
					double x;
					x = ((-1) * B + d) / (2 * A);
					Console.WriteLine("Корень x= " + x.ToString());
				}
				if (D > 0)
				{
					double x1, x2;
					x1 = ((-1) * B + d) / (2 * A);
					x2 = ((-1) * B - d) / (2 * A);

					if (x1 != x2)
					{
						Console.WriteLine("Корень x1= " + x1.ToString());
						Console.WriteLine("Корень x2= " + x2.ToString());
					}
					else
						Console.WriteLine("Корень x= " + x1.ToString());
				}
				if (D < 0)
				{
					Console.WriteLine("Уравнение не имеет корней!");
				}
				Console.WriteLine("Для продолжения нажмите любую клавишу...");
				Console.ReadKey();
				Console.WriteLine();
			}
		}
	} }
 