using System;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities.Enums;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using log4net;


namespace Abletech.ArxMetric.ArxOperations.Operations.Wcf
{
    public class SearchDocumentOperationWcf : ArxOperationBase
    {
        public SearchDocumentOperationWcf(ILog logger, WCFConnectorManager wcf) : base(logger, wcf)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (DocnumberParameter) parameter;

            string idView = "be0a7be3c7f041bdabf4f53f04c66703";

            var search = Wcf.ARX_SEARCH.Dm_Profile_Search_Get_New_Instance_From_ElencoRicerche_CampiDef(idView);
            search.DocNumber.SetFilter(Dm_Base_Search_Operatore_Numerico.Uguale, p.Docnumber);

            Wcf.ARX_SEARCH.Dm_Profile_GetData_For_Viste(search, idView);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "SearchDocumentOperation WCF"; }
        }
    }
}