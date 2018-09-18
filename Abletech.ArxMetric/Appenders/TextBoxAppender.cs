using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using GalaSoft.MvvmLight.Threading;
using log4net;
using log4net.Appender;
using log4net.Repository.Hierarchy;

namespace Abletech.ArxMetric.Appenders
{
    public class TextBoxAppender : IAppender
    {
        private TextBox _textBox;
        private readonly object _lockObj = new object();

        public TextBoxAppender(TextBox textBox)
        {
            _textBox = textBox;
            Name = "TextBlockAppender";
        }

        public string Name { get; set; }

        public static void ConfigureAppender(TextBox textBox)
        {
            var hierarchy = (Hierarchy)LogManager.GetRepository();
            var appender = new TextBoxAppender(textBox);
            hierarchy.Root.AddAppender(appender);
        }

        public void Close()
        {
        }

        public void DoAppend(log4net.Core.LoggingEvent loggingEvent)
        {
            try
            {
                if (_textBox == null)
                {
                    return;
                }

                var msg = string.Concat(loggingEvent.TimeStamp.ToString("G"), " - ", loggingEvent.Level.DisplayName, " - ", loggingEvent.RenderedMessage, "\r\n");

                lock (_lockObj)
                {
                    if (_textBox == null)
                    {
                        return;
                    }

                    try
                    {
                        DispatcherHelper.UIDispatcher.VerifyAccess();
                        DispatcherHelper.UIDispatcher.Invoke(() =>
                        {
                            try
                            {
                                _textBox.Text = _textBox.Text + msg;
                                _textBox.ScrollToEnd();
                            }
                            catch (Exception e)
                            {
                                var error = e.Message;
                            }
                        });
                    }
                    catch (Exception e)
                    {
                        var error = e.Message;
                    }
                }
            }
            catch{}
        }
    }
}
