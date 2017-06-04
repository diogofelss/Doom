using System;
using System.Windows.Forms;
using Gaya.Windows.Controllers;
using Gaya.Windows.Views.LogOn;

namespace Gaya.Windows.Views
{
    public partial class FrmClientArea : Form
    {
        public FrmClientArea()
        {
            InitializeComponent();
        }

        private bool EncerrarAplicacao()
        {
            var mensagemSistema = new UIMessageController();

            return mensagemSistema.SolicitarCertezaEncerrar();
        }

        #region Eventos

        private void UIClientArea_Load(object sender, EventArgs e)
        {
            var logon = new FrmLogon();

            logon.MdiParent = this;
            logon.Show();
        }

        private void UIClientArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !EncerrarAplicacao();
        }

        #endregion
    }
}