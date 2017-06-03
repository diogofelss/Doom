using System;
using System.Windows.Forms;
using Gaya.Windows.Views.Menu;

namespace Gaya.Windows.Views.LogOn
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        #region Métodos

        private bool RealizarLogOn()
        {
            var logon = new Domain.Entities.LogOn();

            logon.IdEmpresa = cbEmpresa.SelectedIndex;
            logon.Usuario = txtUsuario.Text;
            logon.Senha = txtSenha.Text;

            var valido = logon.Valido();

            if (valido.Id != 0)
            {
                Globals.Mensagens.ShowMessageError(valido.Mensagem);
                return false;
            }

            return true;
        }

        #endregion

        #region Eventos

        private void FormLogon_Load(object sender, EventArgs e)
        {
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RealizarLogOn())
                {
                    var arvoresmenus = new FrmMenuTrees();

                    arvoresmenus.MdiParent = MdiParent;
                    Close();

                    arvoresmenus.Show();
                }
            }
            catch (Exception ex)
            {
                Globals.TratamentoErro.TratarErro(ex);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            MdiParent.Close();
        }

        #endregion
    }
}