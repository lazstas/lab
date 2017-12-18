using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab7
{
    class Program
    {
        public class Worker
        {
            public int id;
            public string name;
            public int unit_id;
            
            public Worker(int i, string n, int u_id)
            {
                this.id = i;
                this.name = n;
                this.unit_id = u_id;
            }
            public override string ToString()
            {
                return "(id=" + this.id.ToString() + "; name=" + this.name + "; place id=" + this.unit_id + ")";
            }
        }
        public class Unit
        {
            public int id;
            public string name;
            
            public Unit(int i, string n)
            {
                this.id = i;
                this.name = n;
            }
            public override string ToString()
            {
                return "(id=" + this.id.ToString() + "; name=" + this.name + ")";
            }
        }
        public class WorkersOfUnit
        {
            public int worker;
            public int unit;
            public WorkersOfUnit(int i1, int i2)
            {
                this.worker = i1;
                this.unit = i2;
            }
        }
        static List<Worker> worker = new List<Worker>(){
            new Worker(1,"Oleg",1),
            new Worker(2,"Kolya",2),
            new Worker(3,"BOrya",3),
            new Worker(4,"Pasha",2),
            new Worker(5,"Savveliy",2),
            new Worker(6,"Rokesh",4),
            new Worker(7,"Alin",6),
            new Worker(8,"Alex",6),
            new Worker(9,"Hackerman",3),
            new Worker(10,"Inga",4),
            new Worker(11,"Gorshok",2),
            new Worker(12,"Ira",4),
            new Worker(13,"GUDBOI",4),
            new Worker(14,"Kolbasa",5),
            new Worker(15,"Bono",3),
            new Worker(16,"Mono",5),
        };
        static List<Unit> unit = new List<Unit>(){
            new Unit(1,"CEO"),
            new Unit(2,"SMM"),
            new Unit(3,"Dev"),
            new Unit(4,"Support"),
            new Unit(5,"PR"),
            new Unit(6,"HR"),
        };
        static List<WorkersOfUnit> wou = new List<WorkersOfUnit>()
        {
            new WorkersOfUnit(1,1),
            new WorkersOfUnit(2,2),
            new WorkersOfUnit(3,3),
            new WorkersOfUnit(4,4),
            new WorkersOfUnit(5,5),
            new WorkersOfUnit(6,6),
        };
        
        static void Main(string[] args)
        {
            Console.Title = "База сотрудников";
            Console.WriteLine("Список всех сотрудников и отделов, отсортированный по отделам:\n");
            var q1 = from x in unit
            join y in worker on x.id equals y.unit_id into temp
            select new { id = x.id, name = x.name, d2Group = temp };
            foreach (var x in q1)
            {
                Console.WriteLine(x.id + " " + x.name);
                foreach (var y in x.d2Group)
                Console.WriteLine("   " + y);
            }
            Regex regex = new Regex("A");
            Console.WriteLine("\nCписок всех сотрудников, у которых фамилия начинается на букву A \n");
            var q2 = from x in worker
            where regex.IsMatch(x.name)
            select x;
            foreach (var x in q2) Console.WriteLine(x);
            Console.WriteLine("\nВыведите список всех отделов и количество сотрудников в каждом отделе. \n");
            var q3 = from x in unit
            select new { uid = x.id, uname = x.name, ucount = worker.Count(z => z.unit_id == x.id) };
            foreach (var x in q3)
            Console.WriteLine(x);
            Console.WriteLine("\nВыведите список отделов, в которых у всех сотрудников фамилия начинается с буквы «A» \n");
            var q4 = worker.GroupBy(x => x.unit_id);
            foreach (var x in q4.Where(z => z.All(p => regex.IsMatch(p.name))))
            Console.WriteLine("{0}", x.Key);
            Console.WriteLine("Отделы, в которых хотя бы у одного сотрудника фамилия начинается с буквы 'A'");
            foreach (var x in q4.Where(z => z.Any(p => regex.IsMatch(p.name))))
            Console.WriteLine("{0}", x.Key);
            Console.WriteLine("\nСписок всех отделов и список сотрудников в каждом отделе. \n");
            var wou1 = from x in worker
            join l in wou on x.id equals l.worker into temp
            from t1 in temp
            join y in unit on t1.unit equals y.id into temp2
            from t2 in temp2
            select new {unit = t2.name, name = x.name};
            foreach (var x in wou1) Console.WriteLine(x);
            Console.WriteLine("\nСписок всех отделов и количество сотрудников в каждом отделе. \n");
            var wou2 = from x in worker
            join l in wou on x.id equals l.worker into temp
            from t1 in temp
            join y in unit on t1.unit equals y.id into temp2
            from t2 in temp2
            select new { unit = t2.name, ucount = worker.Count(z => z.unit_id == x.id) };
            foreach (var x in wou2) Console.WriteLine(x);
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
