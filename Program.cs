using System;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            Produtos[] vect = new Produtos[N];



            for (int i = 0; i < N; i++) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produtos {Name = name, Price = price};

           
            }

            double sum = 0.0;
            for (int i = 0; i < N;i++) {
                sum += vect[i].Price;
            }

            double avg = sum / N;  
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }  
    }
}