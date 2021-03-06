using Console.Example.Entities;
using Flowchart.Resolver;

namespace Console.Example.FlowCharts_Items
{
    public class Temp32_Smaller_FinalItem : BasicFlowChartEndItem<InputParameter, OutputClass>
    {

        public override string FlowItemDesc { get { return nameof(Temp32_Smaller_FinalItem); } }
        public override OutputClass Execute(InputParameter Parameter)
        {
            return new OutputClass() { Message = "Below Freezing", FinalItemDesc = FlowItemDesc };
        }

    }
}
