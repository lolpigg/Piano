using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пианиноблин
{
    internal class Program
    {
        
        static int OctavaNum = 0;
        static void Main()
        {
            bool FirstTime = true;
            if (FirstTime)
            {
                Console.WriteLine("Выбор октав - F1, F2, F3.");
                Console.WriteLine($"Текущая октава - {OctavaNum+1}");
                FirstTime = false;
            }
            PlayingKey();
        }
        static void PlayingKey()
        {
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);
                switch (Key.Key)
                {
                    case ConsoleKey.A:  //белые
                        Clavisha(0);
                        break;
                    case ConsoleKey.S:
                        Clavisha(1);
                        break;
                    case ConsoleKey.D:
                        Clavisha(2);
                        break;
                    case ConsoleKey.F:
                        Clavisha(3);
                        break;
                    case ConsoleKey.G:
                        Clavisha(4);
                        break;
                    case ConsoleKey.H:
                        Clavisha(5);
                        break;
                    case ConsoleKey.J:
                        Clavisha(6);
                        break;
                    case ConsoleKey.Q: //тут ниже чёрные
                        Clavisha(7);
                        break;
                    case ConsoleKey.W:
                        Clavisha(8);
                        break;
                    case ConsoleKey.E: 
                        Clavisha(9);
                        break;
                    case ConsoleKey.R:
                        Clavisha(10);
                        break;
                    case ConsoleKey.Y:
                        Clavisha(11);
                        break;
                    case ConsoleKey.F1: //смена октав
                        OctavaNum = 0;
                        break;
                    case ConsoleKey.F2:
                        OctavaNum = 1;
                        break;
                    case ConsoleKey.F3:
                        OctavaNum = 2;
                        break;
                    case ConsoleKey.Escape: // выход
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
                Console.WriteLine("Выбор октав - F1, F2, F3.");
                Console.WriteLine($"Текущая октава - {OctavaNum+1}");
            }
        }
        
        static void Octava(int NumClavisha)
        {
            int[] FirstOctave = new int[] { 16, 18, 21, 22, 24, 28, 31, 17, 19, 23, 26, 29 };
            int[] SecondOctave = new int[] { 33, 37, 41, 44, 49, 55, 62, 35, 39, 46, 52, 58 };
            int[] ThirdOctave = new int[] { 65, 73, 82, 87, 98, 110, 123, 69, 78, 92, 104, 116 };
            switch (OctavaNum)
            {
                case 0:
                FinalPlay(ref FirstOctave, NumClavisha);
                    break;
                case 1:
                FinalPlay(ref SecondOctave, NumClavisha);
                    break;
                case 2:
                FinalPlay(ref ThirdOctave, NumClavisha);
                    break;
            }
        }
        static int[] FinalPlay(ref int[] CurrentOctave, int CurrentKey)
        {
            Console.Beep((CurrentOctave[CurrentKey]*20), 100);
            return CurrentOctave;
        }
        static void Clavisha(int NumClavisha)
        {
            Octava(NumClavisha);
        }
    }
}
