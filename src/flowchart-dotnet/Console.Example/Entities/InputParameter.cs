using Flowchart.Resolver.Interfaces;

namespace Console.Example.Entities
{
    public class InputParameter : IConditionEvaluatorParameter
    {
        public int Temperature { get; set; }
    }
}
