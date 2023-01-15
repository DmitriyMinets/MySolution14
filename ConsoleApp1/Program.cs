using ConsoleApp1;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        Kinder kinder = new Kinder("Паша", 7);

        static void k_TresholderReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"{e.Name} - возраст {e.Age} принят в школу");
        }
    }
}

public class ThresholdReachedEventArgs : EventArgs
{
    public int Age { get; set;}
    public string Name { get; set;}
}