using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {
        public void AddClient(Client client)
        {
            Console.WriteLine(client.Name + " isimli müşteri eklendi." + "|" + " Müşterinin Id'si : " + client.Id + "|" + " Müşterinin yaşı : " + client.Age + "|" +  " Müşterinin cinsiyeti : " + client.Gender);
                     
        }


        public void DeleteClient(Client client)
        {
            Console.WriteLine(client.Name + " isimli kullanıcı silindi." );
        }

        //bunu bir arkadaştan gördüm ve denemek istedim.
        public void ListTheClients(params Client[] clients)
        {
            foreach (Client client in clients)
            {
                Console.WriteLine("Client Details; ");
                Console.WriteLine("İsmi : " + client.Name);
                Console.WriteLine("Id : " + client.Id);
                Console.WriteLine("Yaşı : " + client.Age);
                Console.WriteLine("Cinsiyeti : " + client.Gender);
            }
        }

    }
}
