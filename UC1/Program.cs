using System;

namespace InventoryDataManagementUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            Rice ricedata = fetchJsonForRice.Read("C:/Users/Akshay Somwanshi/Rice.json");

            for (int i = 0; i < ricedata.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfPulses[i].name);
                Console.WriteLine(ricedata.TypesOfPulses[i].Price);
                Console.WriteLine(ricedata.TypesOfPulses[i].weight);
                Console.WriteLine("------");
            }

            for (int i = 0; i < ricedata.TypesOfRice.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfRice[i].name);
                Console.WriteLine(ricedata.TypesOfRice[i].Price);
                Console.WriteLine(ricedata.TypesOfRice[i].weight);
                Console.WriteLine("------");
            }
            for (int i = 0; i < ricedata.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(ricedata.TypesOfWheats[i].name);
                Console.WriteLine(ricedata.TypesOfWheats[i].Price);
                Console.WriteLine(ricedata.TypesOfWheats[i].weight);
                Console.WriteLine("------");
            }

        }
    }
}
