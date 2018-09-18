using System;
using System.Linq;
using System.Text;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities;
using Abletech.Arxivar.Entities.Enums;
using Abletech.Arxivar.Entities.Libraries;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using log4net;


namespace Abletech.ArxMetric.ArxOperations.Operations.Wcf
{
    public class ArxStoreOperationWcf : ArxOperationBase
    {

        public ArxStoreOperationWcf(ILog logger, WCFConnectorManager wcf) : base(logger, wcf)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            var p = (MaskParameter) parameter;

            Dm_Profile_Insert_MV forInsert = Wcf.ARX_DATI.Dm_Profile_Insert_MV_GetNewInstance_From_DmMaskId(p.MaskId);
            var insertMask = forInsert.DmProfileDefault.Dm_Profile_Insert_Base.To_Dm_Profile_Insert_For_Mask();

            insertMask.DmMaskId = p.MaskId;
            insertMask.DocName = "Test performance WCF";
            insertMask.File = new Arx_File(Encoding.UTF8.GetBytes("FILE DI TEST RANDOM " + Guid.NewGuid()), "Test.txt", DateTime.Now);
            insertMask.DataDoc = DateTime.Now.Date;

            var combo39_9 = (Aggiuntivo_String)insertMask.Aggiuntivi.First(x => string.Equals(x.Nome, "COMBO39_9"));
            var combo40_9 = (Aggiuntivo_String)insertMask.Aggiuntivi.First(x => string.Equals(x.Nome, "COMBO40_9")); 
            var testo22_5 = (Aggiuntivo_String)insertMask.Aggiuntivi.First(x => string.Equals(x.Nome, "TESTO22_5"));
            var testo21_5 = (Aggiuntivo_String)insertMask.Aggiuntivi.First(x => string.Equals(x.Nome, "TESTO21_5"));

            combo39_9.Valore = "PRATICHE";
            combo40_9.Valore = "E";
            testo22_5.Valore = Guid.NewGuid().ToString("N");
            testo21_5.Valore = testo22_5.Valore.Substring(2, 5);

            var result = Wcf.ARX_DATI.Dm_Profile_Insert_For_Mask(insertMask);

            if (result.EXCEPTION != Security_Exception.Nothing)
            {
                throw new Exception(result.EXCEPTION.ToString());
            }

            return new DocnumberResult{Docnumber = result.PROFILE.DOCNUMBER};
        }

        internal override string OperationName
        {
            get { return "ArxStoreOperation WCF"; }
        }
    }
}