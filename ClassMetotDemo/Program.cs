using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            Client client2 = new Client();
            Client client3 = new Client();
            Client client4 = new Client();

            client1.Id = "01";
            client1.Name = "Mustafa Derin";
            client1.Age = 17;
            client1.Gender = "Erkek";

            client2.Id = "02";
            client2.Name = "Ege Güner";
            client2.Age = 17;
            client2.Gender = "Erkek";

            client3.Id = "03";
            client3.Name = "Berke Utku";
            client3.Age = 17;
            client3.Gender = "Erkek";

            client4.Id = "01";
            client4.Name = "Senih Kırmaç";
            client4.Age = 17;
            client4.Gender = "Erkek";

            ClientManager clientManager = new ClientManager();

            clientManager.AddClient(client1);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            clientManager.AddClient(client2);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            clientManager.AddClient(client3);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            clientManager.AddClient(client4);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            clientManager.DeleteClient(client1);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            clientManager.ListTheClients(client1);


        }
    }
}
