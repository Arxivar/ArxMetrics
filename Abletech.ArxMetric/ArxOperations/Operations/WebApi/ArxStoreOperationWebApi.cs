using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Abletech.Arxivar.Client;
using Abletech.ArxMetric.ArxOperations.Models;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using log4net;

namespace Abletech.ArxMetric.ArxOperations.Operations.WebApi
{
    public class ArxStoreOperationWebApi : ArxOperationBase
    {
        public ArxStoreOperationWebApi(ILog logger, WCFConnectorManager wcf) : base(logger, wcf)
        {
        }

        public ArxStoreOperationWebApi(ILog logger, Configuration configuration) : base(logger, configuration)
        {
        }

        internal override ResultBase ExcuteImplementation(ParameterBase parameter)
        {
            MaskParameter p = (MaskParameter)parameter;
            MasksApi maskApi = new IO.Swagger.Api.MasksApi(ApiConfiguration);
            BufferApi bufferApi = new IO.Swagger.Api.BufferApi(ApiConfiguration);

            var bufferResponse = bufferApi.BufferInsertAdvanced(1, "Test File", new MemoryStream(Encoding.UTF8.GetBytes("FILE DI TEST RANDOM " + Guid.NewGuid())));

            var maskSchema = maskApi.MasksGetProfileSchemaByMaskId(p.MaskId);
            // Completo i campi

            var fieldDocname = (SubjectFieldDTO) maskSchema.Fields.First(x => x is SubjectFieldDTO);
            fieldDocname.Value = "Test performance WEB API";

            var combo39_9 = (AdditionalFieldComboDTO) maskSchema.Fields.First(x => string.Equals(x.Name, "COMBO39_9"));
            var combo40_9 = (AdditionalFieldComboDTO)maskSchema.Fields.First(x => string.Equals(x.Name, "COMBO40_9"));
            var testo22_5 = (AdditionalFieldStringDTO)maskSchema.Fields.First(x => string.Equals(x.Name, "TESTO22_5"));
            var testo21_5 = (AdditionalFieldStringDTO)maskSchema.Fields.First(x => string.Equals(x.Name, "TESTO21_5"));

            combo39_9.Value = "PRATICHE";
            combo40_9.Value = "E";
            testo22_5.Value = Guid.NewGuid().ToString("N");
            testo21_5.Value = testo22_5.Value.Substring(2, 5);

            var profileDto = new ProfileDTO{Fields = maskSchema.Fields, Document = new FileDTO(new List<string>(), bufferResponse)};

            ProfileResultDTO result = maskApi.MasksPost(p.MaskId, profileDto);
            return new DocnumberResult {Docnumber = result .DocNumber.Value};
        }

        internal override string OperationName
        {
            get { return "ArxStoreOperation WebApi"; }
        }
    }
}