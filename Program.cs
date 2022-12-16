namespace ConsoleApp1
{
    class Program

    {
        // Ожидаем нажатия кнопки
        static void Wait()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
        static void Check(Boolean result)
        {
            if (result == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы победили!");
                Wait();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы проиграли!");
                Wait();
            }
        }
        // Тут программа считает кто выиграл и возвращает либо true - победа, либо false - проигрышь.
        static Boolean Game(int choice)
        {
            Boolean result;
            Random rnd = new Random();
            string[] bot = { "Камень", "Ножницы", "Бумага" };
            string botchoice = bot[rnd.Next(0, 2)];
            if (botchoice == bot[0])
            {
                switch (choice)
                {
                    case 1:
                        result = false;
                        return result;
                    case 2:
                        result = false;
                        return result;
                    case 3:
                        result = true;
                        return result;
                }
            }
            if (botchoice == bot[1])
            {
                switch (choice)
                {
                    case 1:
                        result = true;
                        return result;
                    case 2:
                        result = false;
                        return result;
                    case 3:
                        result = false;
                        return result;
                }
            }
            if (botchoice == bot[2])
            {
                switch (choice)
                {
                    case 1:
                        result = false;
                        return result;
                    case 2:
                        result = true;
                        return result;
                    case 3:
                        result = false;
                        return result;
                }
            }
            return result = false;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Добро пожаловать в игру << Камень, ножницы, бумага >>");
                Wait();
                Console.Clear();
                Console.WriteLine("Выберите один из вариантов: Z - Камень, X - Ножницы, Y - Бумага");
                ConsoleKeyInfo ans = Console.ReadKey();
                switch (ans.Key)
                {
                    case ConsoleKey.Z:
                        int choice = 1;
                        Wait();
                        Console.Clear();
                        Check(Game(choice));
                        break;
                    case ConsoleKey.X:
                        choice = 2;
                        Wait();
                        Console.Clear();
                        Check(Game(choice));
                        break;
                    case ConsoleKey C:
                        choice = 3;
                        Wait();
                        Console.Clear();
                        Check(Game(choice));
                        break;
                }
                Console.Clear();
            } while (true);
        }
    }
}