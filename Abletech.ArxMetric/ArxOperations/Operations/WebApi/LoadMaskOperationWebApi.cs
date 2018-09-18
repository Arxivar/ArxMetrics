using System.Threading.Tasks;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using IO.Swagger.Client;
using IO.Swagger.Model;
using log4net;

namespace Abletech.ArxMetric.ArxOperations.Operations.WebApi
{
    public class LoadMaskOperationWebApi : ArxOperationBase
    {
        public LoadMaskOperationWebApi(
            ILog logger,
            Configuration configuration) :
            base(logger, configuration)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (MaskParameter)parameter;

            var apiMask = new IO.Swagger.Api.MasksApi(ApiConfiguration);

            MaskDTO maskDto = apiMask.MasksGetById(p.MaskId);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "ExecuteLoadMask WEBAPI"; }
        }
    }
}
