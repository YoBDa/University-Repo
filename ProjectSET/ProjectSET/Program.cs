using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectSET
{
   
    class Program
    {
        static List<MySet<int>> Sets = new List<MySet<int>>();
        static void Main(string[] args)
        {
            while (!CommandHandler(Console.ReadLine()));
            BruteForce();
            Console.ReadKey();
        }

        static void BruteForce(int Count = 100)
        {
            MySet<int> OpenedDoors = new MySet<int>();
            MySet<int> ClosedDoors = new MySet<int>();
            for (int i = 1; i <= Count; i++)
                ClosedDoors.Add(i);
            for (int i = 1; i <= Count; i++)
            {
                //firstly buffering sets
                MySet<int> OpenedDoorsBuffer = new MySet<int>();
                MySet<int> ClosedDoorsBuffer = new MySet<int>();
                foreach (var door in OpenedDoors)
                    if (door % i == 0) ClosedDoorsBuffer.Add(door);
                    else OpenedDoorsBuffer.Add(door);
                foreach (var door in ClosedDoors)
                    if (door % i == 0) OpenedDoorsBuffer.Add(door);
                    else ClosedDoorsBuffer.Add(door);
                ClosedDoors = ClosedDoorsBuffer;
                OpenedDoors = OpenedDoorsBuffer;
            }

            Console.WriteLine(OpenedDoors.ToString() + '\n');
            Console.WriteLine(ClosedDoors.ToString());

        }

        
        static bool CommandHandler(string Command)
        {
            if (Command.Trim().Length == 0) { Console.WriteLine(Error(1)); return false; }
            string[] Words = Command.Split(' ');
            if (Words[0].Length != 3 || Words.Length > 3) { Console.WriteLine(Error(1)); return false; }
            if (Words.Length == 1)
                switch (Words[0])
                {
                    case "sup": Console.WriteLine(Help()); return false;
                    case "cre": Console.WriteLine(Create()); return false; 
                    case "lis": Console.WriteLine(PrintList()); return false; 
                    case "ext": Console.WriteLine("Exiting...");return true;
                    default: Console.WriteLine(Error(1));return false;
                }
            else if (Words.Length == 2)
            {
                int arg = 0;
                if (!int.TryParse(Words[1], out arg)) { Error(0); return false; }
                switch (Words[0])
                {
                    case "str": Console.WriteLine(PrintSet(arg));return false;
                    default: Console.WriteLine(Error(1)); return false;
                }
            }
            else if (Words.Length == 3)
            {
                if (Words[0] == "str")
                {
                    int argI = 0;
                    char argC = ',';
                    if (!int.TryParse(Words[1], out argI) || !char.TryParse(Words[2], out argC)) { Error(0); return false; }
                    Console.WriteLine(PrintSet(argI, argC));
                    return false;

                }
                int arg1 = 0;
                int arg2 = 0;
                if (!int.TryParse(Words[1], out arg1) || !int.TryParse(Words[2], out arg2)) { Error(0); return false; }

                switch (Words[0])
                {
                    case "add": Console.WriteLine(Add(arg1, arg2)); return false;
                    case "rem": Console.WriteLine(Remove(arg1, arg2)); return false;
                    case "dif": Console.WriteLine(Difference(arg1, arg2)); return false;
                    case "uni": Console.WriteLine(Union(arg1, arg2)); return false;
                    case "int": Console.WriteLine(Intersection(arg1, arg2)); return false;
                    case "sub": Console.WriteLine(Subset(arg1, arg2)); return false;
                    default: Console.WriteLine(Error(1)); return false;

                }
            }
            else
            {
                Console.WriteLine(Error(0));
                return false;
            }
            

        }
        static string Create()
        {
            Sets.Add(new MySet<int>());
            return "Create set #" + (Sets.Count - 1).ToString();
        }
        static string PrintList()
        {
            if (Sets.Count == 0) return "You haven't created any sets.";
            StringBuilder sb = new StringBuilder();
            sb.Append("#\t\tSize\n");
            int index = 0;
            foreach (var Set in Sets)
            {
                sb.Append($"{index}\t\t{Set.Count}\n");
                index++;
            }
            return sb.ToString();
        }
        static string PrintSet(int SetN, char Delimiter = ',')
        {
            if (Sets.Count < SetN + 1) return Error(0);
            return Sets[SetN].ToString(Delimiter);
        }
        static string Add(int SetN, int Item)
        {
            if (Sets.Count < SetN + 1) return Error(0);
            Sets[SetN].Add(Item);
            return $"Add {Item} to #{SetN} set";
        }
        static string Remove(int SetN, int Item)
        {
            if (Sets.Count < SetN + 1) return Error(0);
            try
            {
                Sets[SetN].Remove(Item);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
            return $"Remove {Item} from #{SetN} set";
        }
        static string Difference(int SetN, int SetM)
        {
            if (Sets.Count < SetN + 1 || Sets.Count < SetM + 1) return Error(0);
            return MySet<int>.Difference(Sets[SetN], Sets[SetM]).ToString();
        }
        static string Union(int SetN, int SetM)
        {
            if (Sets.Count < SetN + 1 || Sets.Count < SetM + 1) return Error(0);
            return MySet<int>.Union(Sets[SetN], Sets[SetM]).ToString();
        }
        static string Intersection(int SetN, int SetM)
        {
            if (Sets.Count < SetN + 1 || Sets.Count < SetM + 1) return Error(0);
            return MySet<int>.Intersection(Sets[SetN], Sets[SetM]).ToString();
        }
        static string Subset(int SetN, int SetM)
        {
            if (Sets.Count < SetN + 1 || Sets.Count < SetM + 1) return Error(0);
            return MySet<int>.Subset(Sets[SetN], Sets[SetM]).ToString();
        }
        static string Help()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("help page for MySet.\n" +
                "Available commands:\n" +
                "cre - create an instance of set, returns its Number\n" +
                "lis - return list of all created sets\n" +
                "add N I - add Item to setN\n" +
                "rem N I - remove Item from setN\n" +
                "dif N M - return difference between setN & setM\n" +
                "uni N M - return union between setN & setM\n" +
                "int N M - return unio between setN & setM\n" +
                "sub N M - return true if setN is subset of setM" +
                "str N - print setN\n" +
                "str N D - print setN with 'D' delimiters\n" +
                "sup - show this page\n" +
                "ext - exit app\n");
            return sb.ToString();

        }
        static string Error(int n)
        {
            switch (n)
            {
                case 0: return "Argument error";
                case 1: return "invalid command";
                    
                default: return "Undefined Error";
            }
        }
    }
}
