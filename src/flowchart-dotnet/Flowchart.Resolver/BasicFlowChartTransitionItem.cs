using Flowchart.Resolver.Interfaces;

namespace Flowchart.Resolver
{

    /// <summary>
    /// Flowchart -> Base class for flowchart transition item
    /// </summary>
    /// <typeparam name="P">input parameter</typeparam>
    /// <typeparam name="O">output</typeparam>
    /// <typeparam name="T">class to continue on LogicToEvaluate is true</typeparam>
    /// <typeparam name="F">class to continue on LogicToEvaluate is false</typeparam>
    public abstract class BasicFlowChartTransitionItem<P, O, T, F> : IGenericStateConditionEvaluator<P, O>
    where P : class, IConditionEvaluatorParameter, new()
    where O : class, new()
    where T : class, IGenericConditionEvaluator<P, O>, new()
    where F : class, IGenericConditionEvaluator<P, O>, new()
    {
        public virtual IGenericConditionEvaluator<P, O> OnTrue { get; set; } = new T();
        public virtual IGenericConditionEvaluator<P, O> OnFalse { get; set; } = new F();

        public virtual O Execute(P Parameter)
        {
            var EvaluateResult = this.LogicToEvaluate(Parameter);
            if (EvaluateResult)
            {
                return OnTrue.Execute(Parameter);
            }
            else
            {
                return OnFalse.Execute(Parameter);
            }
        }

        /// <summary>
        /// Evaluate if goes to generic T or F
        /// </summary>
        /// <param name="Parameter"></param>
        /// <returns></returns>
        public abstract bool LogicToEvaluate(P Parameter);
    }
}
