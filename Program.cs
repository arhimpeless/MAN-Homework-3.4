namespace Задание_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int book_1;
            int book_2;
            int book_3;
            decimal book_kit;
            decimal book_set;
            decimal book_All;
            Random rndBook = new Random();
            book_1 = rndBook.Next(50, 200);
            book_2 = rndBook.Next(50, 200);
            book_3 = rndBook.Next(50, 200);
            book_All = rndBook.Next(8000, 10000);
            Console.WriteLine("Количество страниц в книге 1: " + book_1);
            Console.WriteLine("Количество страниц в книге 2: " + book_2);
            Console.WriteLine("Количество страниц в книге 3: " + book_3);
            Console.WriteLine("Общее количество страниц: " + book_All);
            book_kit = book_1 + book_2 + book_3;
            Console.WriteLine("В наборе из 3-х книг страниц: " + book_kit);
            book_set = Math.Truncate(book_All / book_kit);
            Console.WriteLine("Количество целых наборов: " + book_set);
            decimal lost = book_All - (book_set * book_kit);
            Console.WriteLine("Оставшееся количество страниц: " + lost);
            decimal book_lost;
            book_lost = NewMethod(book_1, book_2, book_3, lost);
        }
        private static decimal NewMethod(int book_1, int book_2, int book_3, decimal lost)
        {
            decimal book_lost = 0;
            if (lost >= book_1 ^ lost < book_2 ^ lost < book_3)
            {
                book_lost = Math.Truncate(lost / book_1);
                Console.WriteLine("Первых книг можно добавить: " + book_lost);
            }
            if (lost < book_1 ^ lost >= book_2 ^ lost < book_3)
            {
                book_lost = Math.Truncate(lost / book_2);
                Console.WriteLine("Вторых книг можно добавить: " + book_lost);
            }
            if (lost < book_1 ^ lost < book_2 ^ lost >= book_3)
            {
                book_lost = Math.Truncate(lost / book_3);
                Console.WriteLine("Третьих книг можно добавить: " + book_lost);
            }
            Console.ReadLine();
            return book_lost;
        }
    }
}