using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abletech.Arxivar.Client;
using Abletech.ArxMetric.ArxOperations.Models;
using IO.Swagger.Client;
using log4net;

namespace Abletech.ArxMetric.ArxOperations
{
    public abstract class ArxOperationBase : IArxOperationBase
    {
        private readonly ILog _logger;
        private readonly Configuration _configuration;
        private readonly WCFConnectorManager _wcf;

        public ArxOperationBase(ILog logger, WCFConnectorManager wcf)
        {
            _logger = logger;
            _wcf = wcf;

            ExcuteDurationMsList = new List<double>();
        }


        public ArxOperationBase(ILog logger, IO.Swagger.Client.Configuration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            _wcf = null;
            

            ExcuteDurationMsList = new List<double>();
        }

        public ILog Logger
        {
            get { return _logger; }
        }

        public WCFConnectorManager Wcf
        {
            get { return _wcf; }
        }

        public Configuration ApiConfiguration
        {
            get { return _configuration; }
        }

        public List<double> ExcuteDurationMsList { get; set; }

        public ResultBase Execute(ParameterBase parameter)
        {
            var dtStart = DateTime.Now;

            var result = ExcuteImplementation(parameter);

            var dtStop = DateTime.Now;

            ExcuteDurationMsList.Add((dtStop-dtStart).TotalMilliseconds);

            return result;
        }


        internal abstract ResultBase ExcuteImplementation(ParameterBase parameter);

        internal abstract string OperationName { get; }
    }
}
