using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace QueueExample
{
    class Program
    {
        public struct Cust
        {
            public string name;
            public DateTime entered;
        }

        static public Queue<Cust> till = new Queue<Cust>();

        static public Timer intervalTimer = new Timer();

        static public Timer serveTimer = new Timer();

        static public void AddToQueue()
        {
            Cust customer;

            Console.WriteLine("Enter Name: ");
            customer.name = Console.ReadLine();
            customer.entered = DateTime.Now;

            till.Enqueue(customer);
        }

        static void DisplayQueueInfo()
        {
            Console.WriteLine("Queue size: " + till.Count());
            foreach (Cust c in till)
            {
                Console.WriteLine(c.name + " " + c.entered);
            }
        }

        static void OnIntervalEvent(object source, ElapsedEventArgs e)
        {
            intervalTimer.Enabled = false;
            AddToQueue();
            DisplayQueueInfo();
            
        }

        static void OnServeEvent(object source, ElapsedEventArgs e)
        {
            serveTimer.Enabled = false;
            till.Dequeue();
            Console.WriteLine("Customer Served, " + DateTime.Now);
            DisplayQueueInfo();
        }


        static void Main(string[] args)
        {

            while (true)
            {
                if (!intervalTimer.Enabled)
                {
                    intervalTimer = new Timer();
                    intervalTimer.Elapsed += new ElapsedEventHandler(OnIntervalEvent);
                    intervalTimer.Interval = 10000;
                    intervalTimer.Enabled = true;
                }
                if (!serveTimer.Enabled)
                {
                    serveTimer = new Timer();
                    serveTimer.Elapsed += new ElapsedEventHandler(OnServeEvent);
                    serveTimer.Interval = 30000;
                    serveTimer.Enabled = true;
                }
            }
        }
    }
}
