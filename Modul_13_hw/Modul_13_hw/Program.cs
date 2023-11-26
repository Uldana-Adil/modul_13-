using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_13_hw
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Client(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Client {Id}: {Name}";
        }
    }

    class BankQueue
    {
        private Queue<Client> clientsQueue = new Queue<Client>();

        
        public void EnqueueClient(Client client)
        {
            clientsQueue.Enqueue(client);
            Console.WriteLine($"Клиент {client.Name} добавлен в очередь.");
        }

        
        public void DequeueClient()
        {
            if (clientsQueue.Count > 0)
            {
                Client removedClient = clientsQueue.Dequeue();
                Console.WriteLine($"Клиент {removedClient.Name} обслужен и удален из очереди.");
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
            }
        }

       
        public void DisplayQueue()
        {
            Console.WriteLine("\nТекущая очередь:");

            foreach (var client in clientsQueue)
            {
                Console.WriteLine(client);
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
           
            BankQueue bankQueue = new BankQueue();

           
            bankQueue.EnqueueClient(new Client(1, "Адил"));
            bankQueue.EnqueueClient(new Client(2, "Болатбек"));
            bankQueue.EnqueueClient(new Client(3, "Кошекова"));
           
            bankQueue.DisplayQueue();            
            bankQueue.DequeueClient();
            bankQueue.DisplayQueue();
            bankQueue.DequeueClient();
            bankQueue.DisplayQueue();
            bankQueue.DequeueClient();
            bankQueue.DisplayQueue();
        }
    }
}
