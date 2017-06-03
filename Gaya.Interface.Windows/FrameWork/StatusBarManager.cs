using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Gaya.Windows.FrameWork
{
    public class StatusBarManager
    {
        private TextBox _textStatus;
        private ProgressBar _progressStatus;

        public StatusBarManager(TextBox textstatus, ProgressBar progStatus)
        {
            _textStatus = textstatus;
            _progressStatus = progStatus;
        }

        #region Mensagens

        public void ShowMessageError(string message)
        {
            Thread t2 = new Thread(delegate ()
            {
                var cororiginal = _textStatus.BackColor;

                setMessage(message);
                setColor(Color.IndianRed);

                Thread.Sleep(5000);

                setMessage(string.Empty);
                setColor(cororiginal);
            });
            t2.Start();
        }

        public void ShowMessageSucess(string message)
        {
            Thread t2 = new Thread(delegate ()
            {
                var cororiginal = _textStatus.BackColor;

                setMessage(message);
                setColor(Color.LightGreen);

                Thread.Sleep(5000);

                setMessage(string.Empty);
                setColor(cororiginal);
            });
            t2.Start();
        }

        public void ShowMessageWarning(string message)
        {
            Thread t2 = new Thread(delegate ()
            {
                var cororiginal = _textStatus.BackColor;

                setMessage(message);
                setColor(Color.LightYellow);

                Thread.Sleep(5000);

                setMessage(string.Empty);
                setColor(cororiginal);
            });
            t2.Start();
        }

        #endregion

        #region Progresso

        public void SetProgressMaximo(int maximo)
        {
            Thread t2 = new Thread(delegate ()
            {
                setTotal(maximo);
            });
            t2.Start();
        }

        public void AddProgresso(int value)
        {
            Thread t2 = new Thread(delegate ()
            {
                setProgress(value);
            });
            t2.Start();
        }

        public void LimparProgresso()
        {
            Thread t2 = new Thread(delegate ()
            {
                setRefresh();
            });
            t2.Start();
        }

        #endregion

        #region Controles TextBox

        delegate void SetTextCallback(string texto);
        delegate void SetBackColorCallback(Color color);

        private void DefinirTexto(string texto)
        {
            this._textStatus.Text = texto;
        }

        private void DefinirCor(Color color)
        {
            this._textStatus.BackColor = color;
        }

        private void setMessage(string message)
        {
            if (this._textStatus.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(DefinirTexto);
                _textStatus.Invoke(d, new object[] { message });
            }
            else
            {
                _textStatus.Text = message;
            }
        }

        private void setColor(Color color)
        {
            if (this._textStatus.InvokeRequired)
            {
                SetBackColorCallback d = new SetBackColorCallback(DefinirCor);
                _textStatus.Invoke(d, new object[] { color });
            }
            else
            {
                _textStatus.BackColor = color;
            }
        }

        #endregion

        #region Controles ProgressBar

        delegate void SetProgressCallback(int progress);
        delegate void SetTotalCallback(int total);
        delegate void SetCleanCallback();
        
        private void AddProgress(int progress)
        {
            _progressStatus.Increment(progress);
        }

        private void DefinirTotal(int total)
        {
            _progressStatus.Maximum = total;
        }

        private void RestartProgress()
        {
            _progressStatus.Refresh();
        }

        private void setProgress(int progress)
        {
            if (this._progressStatus.InvokeRequired)
            {
                SetProgressCallback d = new SetProgressCallback(AddProgress);
                _progressStatus.Invoke(d, new object[] { progress });
            }
            else
            {
                _progressStatus.Increment(progress);
            }
        }

        private void setTotal(int total)
        {
            if (this._progressStatus.InvokeRequired)
            {
                SetTotalCallback d = new SetTotalCallback(DefinirTotal);
                _progressStatus.Invoke(d, new object[] { total });
            }
            else
            {
                _progressStatus.Maximum = total;
            }
        }

        private void setRefresh()
        {
            if (this._progressStatus.InvokeRequired)
            {
                SetCleanCallback d = new SetCleanCallback(RestartProgress);
                _progressStatus.Invoke(d, new object[] { });
            }
            else
            {
                _progressStatus.Refresh();
            }
        }

        #endregion
    }
}
