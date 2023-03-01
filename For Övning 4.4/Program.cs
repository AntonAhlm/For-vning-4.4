using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett tal : ");
            string text = Console.ReadLine();
            int summa = 0;  
            for(int i=0; i<text.Length;i++)
            {
                string textString = text[i].ToString();
                int tal=Convert.ToInt32(textString);
                summa += tal;

            }
            Console.WriteLine(summa);
        }
    }
}
