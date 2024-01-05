internal class Program
{
    private static void Main(string[] args)
    {
        //  Array Definition

        string[] colors = new string[5];

        string[] animals = { "cat", "dog", "bird", "monkey" };

        int[] arry;
        arry = new int[5];

        // 

        colors[0] = "Blue";
        arry[3] = 10;
        Console.WriteLine(animals[0]);
        Console.WriteLine(arry[3]);
        Console.WriteLine(colors[0]);

        // Using Arrays with Loops
        // enter a value then n count average value calculation

        Console.WriteLine("Lütfen Dizinin eleman sayısını giriniz.");
        int arryLength = int.Parse(Console.ReadLine());

        int[] numberArry = new int[arryLength];

        for (int i = 0; i < arryLength; i++)
        {
            Console.Write("Lütfen {0}. sayiyi giriniz", i + 1);
            numberArry[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;


        foreach (var number in numberArry)
        {
            toplam += number;
        }

        Console.WriteLine("ortalama : " + toplam / arryLength);


    }
}