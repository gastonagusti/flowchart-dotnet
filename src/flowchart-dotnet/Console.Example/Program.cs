
using Console.Example.FlowCharts_Items;
using System;

namespace Console.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            // -- Using Example (flowchart_example.png)
            ReadTemp_StartItem FlowchartStartItem = new ReadTemp_StartItem();

            System.Console.WriteLine("Enter a Temperature (< 32 OR > 32)");
            var temp = Convert.ToInt32(System.Console.ReadLine());

            var Output = FlowchartStartItem.Execute(new Entities.InputParameter() { Temperature = temp });

            System.Console.WriteLine($"Flowchart Output Message: {Output.Message} - Current EndItem {Output.FinalItemDesc}");
            System.Console.WriteLine($"Press a key to close");
            System.Console.ReadKey();
        }
    }
}
