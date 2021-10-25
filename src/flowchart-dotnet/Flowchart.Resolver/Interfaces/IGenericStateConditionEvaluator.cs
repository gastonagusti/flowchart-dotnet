namespace Flowchart.Resolver.Interfaces
{
    /// <summary>
    /// Transition Evaluator (have a next step)
    /// </summary>
    public interface IGenericStateConditionEvaluator<P, O> : IGenericConditionEvaluator<P, O>
    where P : class, IConditionEvaluatorParameter, new()
    where O : class, new()
    {
        IGenericConditionEvaluator<P, O> OnTrue { get; set; }
        IGenericConditionEvaluator<P, O> OnFalse { get; set; }

        /// <summary>
        /// Evaluate the logic and goes to OnTrue/OnFalse
        /// </summary>
        bool LogicToEvaluate(P Parameter);
    }
}
