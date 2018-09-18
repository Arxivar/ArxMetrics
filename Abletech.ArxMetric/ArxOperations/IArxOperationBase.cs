using System.Collections.Generic;
using Abletech.ArxMetric.ArxOperations.Models;
using log4net;

namespace Abletech.ArxMetric.ArxOperations
{
    public interface IArxOperationBase
    {
        ResultBase Execute(ParameterBase parameter);

        ILog Logger { get; }

        List<double> ExcuteDurationMsList { get; set; }
    }
}