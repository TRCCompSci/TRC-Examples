using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    internal class Program
    {
        enum State
        {
            S1,
            S2,
            S3,
            Error
        }
        static void Main(string[] args)
        {
            // set the starting state
            State machine = State.S1;
            State accept = State.S3;
            bool control = true;
            while (control)
            {
                Console.WriteLine("You are currenty on state: " + machine.ToString());
                Console.WriteLine("Please enter an input:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        if (machine == State.S1)
                        {
                            machine = State.S1;
                        }
                        else if (machine == State.S2)
                        {
                            machine = State.S3;
                        }
                        else if (machine == State.S3)
                        {
                            machine = State.Error;
                            control = false;
                        }

                        if (machine==accept)
                        {
                            Console.WriteLine("You are now on the accept state");
                        }
                        break;
                    case "0":

                        break;
                }


            }
        }
    }
}
