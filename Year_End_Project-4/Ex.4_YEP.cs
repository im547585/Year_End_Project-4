namespace Year_End_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравейте, моля изберете една от следните опции: \n\t" +
                "1. Добавяне на книга/и;\n\t" +
                "2. Търсене на книга;\n\t"+
                "3. Редактиране на книга/и;\n\t" +
                "4. Изтриване на книга/и; \n\t" +
                "5. Сортиране на книга/и.");
            Console.Write("ИЗБОР: ");
            Console.WriteLine();
            int Choice = int.Parse(Console.ReadLine());
        }
    }
}
