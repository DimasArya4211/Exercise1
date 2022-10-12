using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_1
{
    class Program
{
    private int[] Dimasarya = new int[84];

    private int n;

    public void read()
    {
        while (true)
        {
            Console.Write("Silahkan Masukkan Banyaknya elemen pada array: ");
            string s = Console.ReadLine();
            n = Int32.Parse(s);
            if (n <= 84) 
            break;
            else
                Console.WriteLine("\nArray Dapat Mempunyai maksimal 84 elemen.\n");
        }
        Console.WriteLine("");
        Console.WriteLine("----------------------");
        Console.WriteLine("Masukkan Elemen Array: ");
        Console.WriteLine("----------------------");

        for (int j = 0; j < n; j++) 
        {
            Console.Write("<" + (j + 1) + ">");
            string s1 = Console.ReadLine();
            Dimasarya[j] = Int32.Parse(s1);
        }

    }
    public void display()
    {
        Console.WriteLine("");
        Console.WriteLine("----------------------");
        Console.WriteLine("Element Array yang telah tersusun");
        Console.WriteLine("----------------------");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(Dimasarya[j]);
        }
        Console.WriteLine("");
    }

    public void BubbleShortArray()
    {
        for(int j = 1; j < n; j++)
        {
            for (int DA = 0; DA < n - j; DA++)
            {
            if (Dimasarya[DA] > Dimasarya[DA + 1])
                {
                        int temp;
                        temp = Dimasarya[DA];
                        Dimasarya[DA] = Dimasarya[DA + 1];
                        Dimasarya[DA + 1] = temp;

                }
            }
        }
    }
        static void Main(string[] args)
        {
            Program myList = new Program();
            myList.read();
            myList.BubbleShortArray();
            myList.display();
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}