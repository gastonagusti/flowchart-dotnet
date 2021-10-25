using Console.Example.Entities;
using Flowchart.Resolver;

namespace Console.Example.FlowCharts_Items
{
    /// <summary>
    /// Start and Transition Item 
    /// </summary>
    public class ReadTemp_StartItem : BasicFlowChartTransitionItem<InputParameter, OutputClass, Temp32_Smaller_FinalItem, Temp32_Greater_FinalItem>
    {

        const int TEMPERATURE_TO_EVALUATE = 32;

        public override bool LogicToEvaluate(InputParameter Parameter)
        {
            return (Parameter.Temperature < TEMPERATURE_TO_EVALUATE);
        }
    }
}
