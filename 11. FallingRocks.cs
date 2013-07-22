using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


class FallingRocks
{
    static int playerPadSize = 5;
    static int playfieldWidth = 40;
    static int livesCount;
    static int pointsCount = 0;
    static string[] rocksSymbols = { "^", "@", "*", "++", "&", ";", "%", "$", "#", "!", ".." };
    static int indexRocksSymbols;
    static int difficulty;

    struct Object
    {
        public int x;
        public int y;
        public string c;
        public ConsoleColor color;
    }

    static void RemoveScrollBars()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 60;
    }

    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }


    static void Main()
    {
        RemoveScrollBars();

        Object dwarf = new Object();
        dwarf.x = playfieldWidth / 2 - playerPadSize / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = "(O)";
        dwarf.color = ConsoleColor.White;

        Random randomGenerator = new Random();
        List<Object> rocks = new List<Object>();

        string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        Console.WriteLine("You are about to start the outstanding game 'Falling Rocks' ");
        Console.WriteLine("Please, enter your name here: ");
        string PlayerName = Console.ReadLine();
        Console.WriteLine("\nSo {0}, you have decided to avoid the rocks!",PlayerName);
        Thread.Sleep(1000);
        Console.WriteLine("How many lives do you think you need?");
        livesCount = int.Parse(Console.ReadLine());
        Console.WriteLine("What are you going to do with {0} lives!\nActually I am a good guy and I will give you twice more :)",livesCount);
        livesCount = livesCount * 2;
        Thread.Sleep(1000);
        Console.WriteLine("So you will start with {0} lives!", livesCount);
        Thread.Sleep(1000);
        Console.WriteLine("I am generous!\n");
        Thread.Sleep(1000);
        Console.WriteLine("So be generous as well at the homework evaluation, {0}!",PlayerName);
        Thread.Sleep(3000);
        Console.WriteLine("Hey {0}, I know your name!", PlayerName);
        Console.WriteLine("How about level of difficulty? You have the following three levels to choose from:\n     Insane(1)\n     Moderate(2)\n     Easy(3)\n");
        Thread.Sleep(2000);
        Console.WriteLine("Write 1, 2 or 3 for the difficulty of the level");
        Thread.Sleep(2000);
        Console.WriteLine("So, what is your decision?");
        difficulty = int.Parse(Console.ReadLine());
        if (difficulty == 1)
        {
            Console.WriteLine("You have chosen Insane Level! Bravo, you are probably a master!");
        }
        if (difficulty == 2)
        {
            Console.WriteLine("You have chose Modarate level. Good choice, indeed! :D");
        }
        if (difficulty > 2 || difficulty <1 )
        {
            Console.WriteLine("You have chosen the easiest level!\nThe best option for a homework check!\n");
        }
        Thread.Sleep(300);
        Console.WriteLine("Please, wait while the game is loading\n");
        Thread.Sleep(300);
        Console.WriteLine("It will take up to 10 seconds\n");
        Thread.Sleep(300);
        Console.WriteLine("In the mean time you may visit the web site of our sponsors - www.telerik.bg \n\n\n\n" );
        Thread.Sleep(300);
        Console.WriteLine("                  L O A D I N G ... ");
        Thread.Sleep(15000);
        Console.WriteLine("Actually it takes a little bit more");
        Thread.Sleep(2000);
        Console.WriteLine("Get Ready!");
        Thread.Sleep(300);
        Console.WriteLine("    9");
        Thread.Sleep(300);
        Console.WriteLine("    8");
        Thread.Sleep(300);
        Console.WriteLine("    7");
        Thread.Sleep(300);
        Console.WriteLine("    6");
        Thread.Sleep(300);
        Console.WriteLine("    5");
        Thread.Sleep(300);
        Console.WriteLine("    4");
        Thread.Sleep(300);
        Console.WriteLine("    3");
        Thread.Sleep(300);
        Console.WriteLine("    2");
        Thread.Sleep(300);
        Console.WriteLine("    2");
        Thread.Sleep(300);
        Console.WriteLine("    2");
        Thread.Sleep(300);
        Console.WriteLine("    2");
        Thread.Sleep(300);
        Console.WriteLine("    1");
        Thread.Sleep(300);
        Console.WriteLine(" Now you go!:D");

        Console.Clear();

        
 
        while (true)
        {

            bool hitted = false;
            indexRocksSymbols = randomGenerator.Next(0, rocksSymbols.Length);
            ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorNames[randomGenerator.Next(0, colorNames.Length)]);

            Object newRock = new Object();
            newRock.color = color;
            newRock.c = rocksSymbols[indexRocksSymbols];
            newRock.x = randomGenerator.Next(0, playfieldWidth);
            newRock.y = 0;
            rocks.Add(newRock);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldObject = rocks[i];
                Object newObject = new Object();
                newObject.x = oldObject.x;
                newObject.y = oldObject.y + 1;
                newObject.c = oldObject.c;
                newObject.color = oldObject.color;
                rocks.Remove(oldObject);

                if (newObject.y == Console.WindowHeight)
                {
                    pointsCount++;
                }

                if ((newObject.y == dwarf.y && newObject.x == dwarf.x)
                        || (newObject.y == dwarf.y && newObject.x == dwarf.x + 1)
                        || (newObject.y == dwarf.y && newObject.x == dwarf.x + 2))
                {
                    livesCount--;
                    hitted = true;

                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(47, 5, "GAME OVER", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (newObject.y < Console.WindowHeight)
                {
                    rocks.Add(newObject);
                }
            }

            Console.Clear();

            if (hitted)
            {
                rocks.Clear();
                PrintStringOnPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
            }
            else
            {
                PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            }


            foreach (Object rock in rocks)
            {
                PrintStringOnPosition(rock.x, rock.y, rock.c, rock.color);
            }

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                PrintOnPosition(42, i, '|');
            }
            PrintStringOnPosition(44, 1, "*FALLING ROCKS*", ConsoleColor.Magenta);
            PrintStringOnPosition(45, 3, "Score: " + pointsCount);
            PrintStringOnPosition(45, 5, "Lives: " + livesCount);
            PrintStringOnPosition(45, 7, "Player: " + PlayerName);
            if (difficulty == 1)
            {
            Thread.Sleep(350);
            }
            if (difficulty == 2)
            {
            Thread.Sleep(250);
            }
                else
            {
                Thread.Sleep(200);
            }
            }

        }
}
