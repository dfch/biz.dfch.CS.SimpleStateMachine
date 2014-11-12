// Based on an idea by "Juliet" (http://stackoverflow.com/users/40516/juliet)
// http://stackoverflow.com/questions/5923767/simple-state-machine-example-in-c

using System;

namespace SimpleStateMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Execute standard process
            var p = new ProcessBase();
            Console.WriteLine(p.GetStateMachine()); 
            while (!p.IsFinalState)
            {
                Console.WriteLine("Previous State = " + p.PreviousState);
                Console.WriteLine("Current State = " + p.CurrentState);
                Console.WriteLine("Condition.Begin: Current State = " + p.Continue());
            }

            // Load a FSM and save its configuration ...
            var p2 = new StatusEnum();
            Console.WriteLine(p2.GetStateMachine());
            var config = p2.GetStateMachine();

            // ... and load it into a new FSM instance.
            var p3 = new StatusEnum();
            p3.SetStateMachine(config);
            Console.WriteLine(p3.GetStateMachine());

            // Modulate command state machine from Juliet.
            var cmd = new ProcessCommand();
            Console.WriteLine(cmd.GetStateMachine());
            Console.WriteLine("Previous State = " + cmd.PreviousState);
            Console.WriteLine("Current State = " + cmd.CurrentState);
            Console.WriteLine("Condition.Continue: Current State = " + cmd.Continue());
            Console.WriteLine("Previous State = " + cmd.PreviousState);
            Console.WriteLine("Condition.Cancel: Current State = " + cmd.Cancel());
            Console.WriteLine("Previous State = " + cmd.PreviousState);
            Console.WriteLine("Condition.Cancel: Current State = " + cmd.Cancel());
            Console.WriteLine("Previous State = " + cmd.PreviousState);
            Console.WriteLine("Condition.Cancel: Current State = " + cmd.Cancel());
            Console.WriteLine("Previous State = " + cmd.PreviousState);
            Console.WriteLine("IsFinalState = " + cmd.IsFinalState);

            Console.ReadLine();
        }
    }
}