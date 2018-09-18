using System;
using Abletech.Arxivar.Client;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using log4net;
namespace Abletech.ArxMetric.ArxOperations.Operations.Wcf
{
    public class LoadMaskOperationWcf : ArxOperationBase
    {
        public LoadMaskOperationWcf(
            ILog logger,
            WCFConnectorManager wcf) : 
                base(logger, wcf)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (MaskParameter) parameter;

            // The mask
            Wcf.ARX_DATI.Dm_Mask_GetData_By_Id(p.MaskId);

            // The mask detail
            Wcf.ARX_DATI.Dm_MaskDetail_GetData_By_DmMaskId(p.MaskId);

            return new VoidResult();
        }

        internal override string OperationName
        {
            get { return "ExecuteLoadMask WCF"; }
        }
    }
}