using System;
using System.Collections.Generic;
using System.Text;

namespace Flowchart.Resolver.Interfaces
{

    /// <summary>
    /// Evaluator without next step (Represents a Final Step of the Flow)
    /// </summary>
    public interface IGenericConditionEvaluator<P, O>
    where P : class, IConditionEvaluatorParameter, new()
    where O : class, new()
    {
        O Execute(P Parameter);
    }

}
