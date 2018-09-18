using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Abletech.Arxivar.Entities;
using Abletech.Arxivar.Client;
using Abletech.Arxivar.Entities.Enums;
using GalaSoft.MvvmLight.Threading;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Abletech.ArxMetric.ArxOperations.Operations;
using log4net;
using Abletech.ArxMetric.ArxOperations;
using Abletech.ArxMetric.ArxOperations.Models.Parameters;
using Abletech.ArxMetric.ArxOperations.Models.Results;
using Abletech.ArxMetric.Calculators;
using System.ComponentModel;
using Abletech.ArxMetric.ArxOperations.Operations.Wcf;
using Abletech.ArxMetric.ArxOperations.Operations.WebApi;
using IO.Swagger.Model;

namespace Abletech.ArxMetric.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ILog _logger;

        private const string CLIENTSECRET = "6B2F4647A2D24692";
        private const string CLIENTID = "ArxMetricSoftware";
        private const string DEFAULTLOGINPROVIDER = "00000000000000000000000000000000";

        private readonly List<double> _timeMask = new List<double>();
        private readonly List<double> _timeSearch = new List<double>();
        private readonly List<double> _timeStore = new List<double>();
        private readonly List<double> _timeF2 = new List<double>();
        private readonly List<double> _timeTestProcedure = new List<double>();


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            //Url = "net.tcp://localhost:8740/Arxivar/Push";
            Url = "http://localhost/ARXivarResourceServer/";
            Username = "Admin";
            Lang = "IT";
            Password = "123";

            ThreadCount = 1;
            RepeatCount = 20;

            ServerModeSource = new ObservableCollection<string>(){"WCF", "WEBAPI"};

            //SelectedServerMode = "WCF";
            SelectedServerMode = "WEBAPI";

            _logger = LogManager.GetLogger(this.GetType().FullName);
        }

        #region Properties

        #region ServerModeSource


        #endregion ServerModeSource

        private ObservableCollection<string> _ServerModeSource;

        public ObservableCollection<string> ServerModeSource
        {
            get { return _ServerModeSource; }
            set
            {
                _ServerModeSource = value;
                RaisePropertyChanged("ServerModeSource");
            }
        }

        #region SelectedServerMode

        private string _selectedServerMode;

        public string SelectedServerMode
        {
            get { return _selectedServerMode; }
            set
            {
                _selectedServerMode = value;
                RaisePropertyChanged("SelectedServerMode");
            }
        }

        #endregion 

        #region Url

        private string _url;

        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                RaisePropertyChanged("Url");
            }
        }

        #endregion Url

        #region Username

        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChanged("Username");
            }
        }

        #endregion Username

        #region Password

        private string __password;

        public string Password
        {
            get { return __password; }
            set
            {
                __password = value;
                RaisePropertyChanged("Password");
            }
        }

        #endregion Password

        #region Lang

        private string _lang;

        public string Lang
        {
            get { return _lang; }
            set
            {
                _lang = value;
                RaisePropertyChanged("Lang");
            }
        }

        #endregion Lang

        #region ThreadCount

        private int _thCount;

        public int ThreadCount
        {
            get { return _thCount; }
            set
            {
                _thCount = value;
                RaisePropertyChanged("ThreadCount");
            }
        }

        #endregion ThreadCount

        #region RepeatCount

        private int _rpCount;

        public int RepeatCount
        {
            get { return _rpCount; }
            set
            {
                _rpCount = value;
                RaisePropertyChanged("RepeatCount");
            }
        }

        #endregion RepeatCount

        #region IsBusy

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }

        #endregion IsBusy

        #endregion

        #region Commands

        #region ExecuteCmd

        private RelayCommand _executeCmd;
        

        public ICommand ExecuteCmd
        {
            get
            {
                return _executeCmd ?? (_executeCmd = new RelayCommand(ExecuteCmd_Execute, ExecuteCmd_CanExecute));
            }
        }

        private bool ExecuteCmd_CanExecute()
        {
            if (string.IsNullOrEmpty(Username))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Password))
            {
                return false;
            }

            if (string.IsNullOrEmpty(Url))
            {
                return false;
            }

            return true;
        }


        private void ExecuteCmd_Execute()
        {
            _timeMask.Clear();
            _timeSearch.Clear();
            _timeStore.Clear();
            _timeF2.Clear();
            _timeTestProcedure.Clear();

            Task task;
            if (string.Equals(SelectedServerMode, "WCF"))
            {
                task = TaskWcf();
            }
            else
            {
                task = TaskWebApi();
            }
            
            task.Start();
        }

        private Task TaskWcf()
        {
            var task = new Task(() =>
            {
                DispatcherHelper.UIDispatcher.Invoke(() => IsBusy = true);

                var wcfConnectorList = new List<WCFConnectorManager>();
                var listTaskTest = new List<Task>();
                try
                {
                    DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() => { _logger.Info("Execute login test"); }));

                    var arxLogonRequest = new ArxLogonRequest
                    {
                        Username = Username,
                        Password = Password,
                        LogonProviderId = DEFAULTLOGINPROVIDER, // Default ARXivar
                        ClientId = CLIENTID, // Configured in AUTH service
                        ClientSecret = CLIENTSECRET // Configured in AUTH service
                    };

                    using (var wcfConn = new WCFConnectorManager(Url, new ArxAccessTokenLogonRequest()))
                    {
                        var logon = wcfConn.Logon(Url, arxLogonRequest);
                        if (logon.LogOnError != ArxLogOnErrorType.None)
                        {
                            throw new Exception("Test login error: " + logon.LogOnError);
                        }

                        DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                        {
                            _logger.Info("Create wcf connections..");
                        }));

                        for (int i = 0; i < ThreadCount; i++)
                        {
                            DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                            {
                                _logger.Info(string.Format(" - Create wcf connection {0} of {1}", (i + 1), ThreadCount));
                            }));

                            var wcfConnThread = new WCFConnectorManager(Url, new ArxAccessTokenLogonRequest());
                            var logonThread = wcfConnThread.Logon(Url, arxLogonRequest);
                            if (logonThread.LogOnError != ArxLogOnErrorType.None)
                            {
                                throw new Exception("Test login error: " + logon.LogOnError);
                            }

                            wcfConnectorList.Add(wcfConnThread);
                        }

                        DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                        {
                            _logger.Info("Create procedure test");
                        }));

                        for (int i = 0; i < ThreadCount; i++)
                        {
                            DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                            {
                                _logger.Info(string.Format(" - Create procedure connection {0} of {1}", (i + 1), ThreadCount));
                            }));

                            var taskClient = new Task(() => TestProcedureWcf(wcfConnectorList[i], string.Format("Thread{0}", i + 1)),
                                TaskCreationOptions.LongRunning);

                            taskClient.Start();
                            listTaskTest.Add(taskClient);

                            Thread.Sleep(1000);
                        }

                        listTaskTest.ForEach(x => x.Wait());

                        DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() => {
                            _logger.Info(string.Format("REPORT\r\nMASK\r\n{0}\r\nSTORE\r\n{1}\r\nSEARCH\r\n{2}\r\nF2\r\n{3}\r\nCycle\r\n{4}",
                                TimeCalculator.EvaluateTime(_timeMask.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeStore.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeSearch.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeF2.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeTestProcedure.ToArray()).ToString()
                            ));
                        }));

                        MessageBox.Show("Test procedure completed", "Execute completed", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception exception)
                {
                    DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                    {
                        _logger.Error(exception.Message);
                    }));

                    MessageBox.Show(exception.Message, "Execute error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    foreach (var item in wcfConnectorList)
                    {
                        item.Dispose();
                    }
                    DispatcherHelper.UIDispatcher.Invoke(() => IsBusy = false);
                }
            });
            return task;
        }

        private Task TaskWebApi()
        {
            var task = new Task(() =>
                {
                    DispatcherHelper.UIDispatcher.Invoke(() => IsBusy = true);

                    var listTaskTest = new List<Task>();

                    DispatcherHelper.UIDispatcher.BeginInvoke((Action) (() => { _logger.Info("Execute login test"); }));


                    try
                    {
                        var authApi = new IO.Swagger.Api.AuthenticationApi(Url);

                        var tokenRequestDto = new AuthenticationTokenRequestDTO(Username, Password, CLIENTID, CLIENTSECRET, null, null, null, null, null, null, null);
                        var tokenResponse = authApi.AuthenticationGetToken(tokenRequestDto);

                        var configuration = new IO.Swagger.Client.Configuration()
                        {
                            ApiKey = new Dictionary<string, string>() { { "Authorization", tokenResponse.AccessToken } },
                            ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } },
                            BasePath = Url
                        };

                        for (int i = 0; i < ThreadCount; i++)
                        {
                            DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() => { _logger.Info(string.Format(" - Create procedure connection {0} of {1}", (i + 1), ThreadCount)); }));

                            var taskClient = new Task(() => TestProcedureApi(configuration, string.Format("Thread{0}", i + 1)), TaskCreationOptions.LongRunning);

                            taskClient.Start();
                            listTaskTest.Add(taskClient);

                            Thread.Sleep(1000);
                        }

                        listTaskTest.ForEach(x => x.Wait());

                        DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                        {
                            _logger.Info(string.Format("REPORT\r\nMASK\r\n{0}\r\nSTORE\r\n{1}\r\nSEARCH\r\n{2}\r\nF2\r\n{3}\r\nCycle\r\n{4}",
                                TimeCalculator.EvaluateTime(_timeMask.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeStore.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeSearch.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeF2.ToArray()).ToString(),
                                TimeCalculator.EvaluateTime(_timeTestProcedure.ToArray()).ToString()
                            ));
                        }));

                        MessageBox.Show("Test procedure completed", "Execute completed", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception exception)
                    {
                        DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
                        {
                            _logger.Error(exception.Message);
                        }));

                        MessageBox.Show(exception.Message, "Execute error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    finally
                    {
                        DispatcherHelper.UIDispatcher.Invoke(() => IsBusy = false);
                    }

                    
                }
            );
            return task;
        }

        private void TestProcedureWcf(WCFConnectorManager wcf, string threadName)
        {
            IArxOperationBase maskOperation = new  LoadMaskOperationWcf(_logger, wcf);
            IArxOperationBase searchDocOperation = new SearchDocumentOperationWcf(_logger, wcf);
            IArxOperationBase storeOperation = new ArxStoreOperationWcf(_logger, wcf);
            IArxOperationBase f2Operation = new F2OperationWcf(_logger, wcf);

            for (int i = 0; i < RepeatCount; i++)
            {
                var dtStart = DateTime.Now;

                string msgLog = string.Format("<{2}> Execution {0} of {1}", (i + 1), RepeatCount, threadName);

                DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() => { _logger.Info(msgLog); }));

                var mp = new MaskParameter{MaskId = "84e5ea23a77f482883c663d6900546cf" };
                var maskResult = maskOperation.Execute(mp);

                var storeResult = (DocnumberResult)storeOperation.Execute(mp);

                var sdp = new DocnumberParameter { Docnumber = storeResult.Docnumber };
                var searchDocResult = searchDocOperation.Execute(sdp);

                var f2p = new DocnumberParameter{Docnumber = storeResult.Docnumber};
                var f2Result = f2Operation.Execute(f2p);

                _timeTestProcedure.Add((DateTime.Now - dtStart).TotalMilliseconds);
            }

            _timeMask.AddRange(maskOperation.ExcuteDurationMsList);
            _timeSearch.AddRange(searchDocOperation.ExcuteDurationMsList);
            _timeStore.AddRange(storeOperation.ExcuteDurationMsList);
            _timeF2.AddRange(f2Operation.ExcuteDurationMsList);

            DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
            {
                _logger.Info(string.Format("REPORT <{0}>\r\nMASK\r\n{1}\r\nSTORE\r\n{2}\r\nSEARCH\r\n{3}\r\nF2\r\n{4}",
                    threadName,
                    TimeCalculator.EvaluateTime(maskOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(storeOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(searchDocOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(f2Operation.ExcuteDurationMsList.ToArray()).ToString()
                ));
            }));
        }

        private void TestProcedureApi(IO.Swagger.Client.Configuration configuration, string threadName)
        {
            IArxOperationBase maskOperation = new LoadMaskOperationWebApi(_logger, configuration);
            IArxOperationBase searchDocOperation = new SearchDocumentOperationWebApi(_logger, configuration);
            IArxOperationBase storeOperation = new ArxStoreOperationWebApi(_logger, configuration);
            IArxOperationBase f2Operation = new F2OperationWebApi(_logger, configuration);

            for (int i = 0; i < RepeatCount; i++)
            {
                var dtStart = DateTime.Now;

                string msgLog = string.Format("<{2}> Execution {0} of {1}", (i + 1), RepeatCount, threadName);

                DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() => { _logger.Info(msgLog); }));

                var mp = new MaskParameter { MaskId = "84e5ea23a77f482883c663d6900546cf" };
                var maskResult = maskOperation.Execute(mp);

                var storeResult = (DocnumberResult)storeOperation.Execute(mp);

                var sdp = new DocnumberParameter { Docnumber = storeResult.Docnumber };
                var searchDocResult = searchDocOperation.Execute(sdp);

                var f2p = new DocnumberParameter { Docnumber = storeResult.Docnumber };
                var f2Result = f2Operation.Execute(f2p);

                _timeTestProcedure.Add((DateTime.Now - dtStart).TotalMilliseconds);
            }

            _timeMask.AddRange(maskOperation.ExcuteDurationMsList);
            _timeSearch.AddRange(searchDocOperation.ExcuteDurationMsList);
            _timeStore.AddRange(storeOperation.ExcuteDurationMsList);
            _timeF2.AddRange(f2Operation.ExcuteDurationMsList);

            DispatcherHelper.UIDispatcher.BeginInvoke((Action)(() =>
            {
                _logger.Info(string.Format("REPORT <{0}>\r\nMASK\r\n{1}\r\nSTORE\r\n{2}\r\nSEARCH\r\n{3}\r\nF2\r\n{4}",
                    threadName,
                    TimeCalculator.EvaluateTime(maskOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(storeOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(searchDocOperation.ExcuteDurationMsList.ToArray()).ToString(),
                    TimeCalculator.EvaluateTime(f2Operation.ExcuteDurationMsList.ToArray()).ToString()
                ));
            }));
        }

        #endregion ExecuteCmd

        #endregion
    }
}