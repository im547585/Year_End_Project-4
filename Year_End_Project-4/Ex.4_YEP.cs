namespace Year_End_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравейте, моля изберете една от следните опции: \n\t" +
                "1. Добавяне на книга/и\n\t" +
                "2. Търсене на книга\n\t"+
                "3. Редактиране на книга/и\n\t" +
                "4. Изтриване на книга/и \n\t" +
                "5. Сортиране на книга/и\n\t" +
                "6. Създаване на личен картон \n\t" +
                "7. Регистриране на заета книга\n\t" +
                "8. Преглед на личен картон\n\t" +
                "9. Изтриване на личен картон\n\t" +
                "0. ИЗХОД ОТ ПРОГРАМАТА\n\t");
            Console.Write("ИЗБОР: ");
            int Choice = int.Parse(Console.ReadLine());
        }
    }
}
