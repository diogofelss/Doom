using Doom.Interface.Windows.Views.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom.Interface.Windows.Views.LogOn
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (RealizarLogOn())
                {
                    var arvoresmenus = new FrmMenuTrees();

                    arvoresmenus.MdiParent = this.MdiParent;
                    this.Close();

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
            this.MdiParent.Close();
        }

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

        private void FormLogon_Load(object sender, EventArgs e)
        {

        }
    }
}
