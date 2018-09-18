using Abletech.Arxivar.Client;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using IO.Swagger.Client;
using log4net;

namespace Abletech.ArxMetric.ArxOperations.Operations.WebApi
{
    public class F2OperationWebApi : ArxOperationBase
    {
        public F2OperationWebApi(ILog logger, WCFConnectorManager wcf) : base(logger, wcf)
        {
        }

        public F2OperationWebApi(ILog logger, Configuration configuration) : base(logger, configuration)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (DocnumberParameter)parameter;

            var profileApi = new IO.Swagger.Api.ProfilesApi(ApiConfiguration);
            profileApi.ProfilesGet(p.Docnumber);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "F2Operation WCF"; }
        }
    }
}