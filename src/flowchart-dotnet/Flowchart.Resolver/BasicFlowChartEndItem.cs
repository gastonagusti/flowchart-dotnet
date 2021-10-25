using Flowchart.Resolver.Interfaces;

namespace Flowchart.Resolver
{

    /// <summary>
    /// Flowchart -> Base class for flowchart final item
    /// </summary>
    public abstract class BasicFlowChartEndItem<P, O> : IGenericConditionEvaluator<P, O>
    where P : class, IConditionEvaluatorParameter, new()
    where O : class, new()
    {
        public abstract string FlowItemDesc { get; }
        public abstract O Execute(P Parameter);
    }
}
