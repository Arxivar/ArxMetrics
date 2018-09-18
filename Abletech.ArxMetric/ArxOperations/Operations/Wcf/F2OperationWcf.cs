using System;
using Abletech.Arxivar.Client;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using log4net;



namespace Abletech.ArxMetric.ArxOperations.Operations.Wcf
{
    public class F2OperationWcf : ArxOperationBase
    {
        public F2OperationWcf(ILog logger, WCFConnectorManager wcf) : base(logger, wcf)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (DocnumberParameter) parameter;

            Wcf.ARX_DATI.Dm_Profile_MV_GetData_By_Docnumber(p.Docnumber, string.Empty, true);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "F2Operation WCF"; }
        }
    }
}