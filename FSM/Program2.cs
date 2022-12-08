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
            State machine = State.S1;
            State accept = State.S2;
            bool control = true;
            while (control)
            {
                Console.WriteLine("You are currenty on state: " + machine.ToString());
                Console.WriteLine("Please enter an input:");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
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
