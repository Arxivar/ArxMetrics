using Abletech.Arxivar.Entities.Enums;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using IO.Swagger.Client;
using IO.Swagger.Model;
using log4net;

namespace Abletech.ArxMetric.ArxOperations.Operations.WebApi
{
    public class SearchDocumentOperationWebApi : ArxOperationBase
    {
        public SearchDocumentOperationWebApi(
            ILog logger,
            Configuration configuration) :
            base(logger, configuration)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (DocnumberParameter)parameter;

            string idView = "be0a7be3c7f041bdabf4f53f04c66703";

            var apiSearch = new IO.Swagger.Api.ViewsApi(ApiConfiguration);
            var viewDto = apiSearch.ViewsGetView(idView);
            var f = (FieldBaseForSearchIntDto) viewDto.SearchFilterDto.Fields[0];
            f._Operator = 3;
            f.Valore1 = p.Docnumber;
            
            var resultView= apiSearch.ViewsGetResult(viewDto);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "SearchDocumentOperation WCF"; }
        }
    }
}