using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("123456789", "Iphone 12", "123456789", 128);
            Console.WriteLine("Iphone 12");
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine("\n--------------------------------\n");
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321", 4);
            Console.WriteLine("Nokia 3310");
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");
        }
    }
}