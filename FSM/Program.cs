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
            S0,
            S1,
            S2,
            Error
        }
        static void Main(string[] args)
        {
            // set the starting state
            State machine = State.S0;
            State accept = State.S2;
            bool control = true;
            while (control)
            {
                Console.WriteLine("You are currenty on state: " + machine.ToString());
                Console.WriteLine("Please enter an input:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "a":
                        if (machine == State.S0)
                        {
                            machine = State.S2;
                        }
                        else if (machine == State.S1)
                        {
                            machine = State.S0;
                        }
                        else if (machine == State.S2)
                        {
                            machine = State.Error;
                            control = false;
                        }

                        if (machine==accept)
                        {
                            Console.WriteLine("You are now on the accept state");
                        }
                        break;
                    case "b":

                        break;

                    default:
                        Console.WriteLine("Value not valid");
                        control = false;
                        break;
                
                }


            }
            Console.ReadLine();
        }
    }
}
