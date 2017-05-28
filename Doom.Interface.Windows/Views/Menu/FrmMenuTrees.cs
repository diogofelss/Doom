using Doom.Interface.Windows.Views.Configuracoes_Gerais;
using Doom.Interface.Windows.Views.Inicializacao.Cadastros;
using Doom.Interface.Windows.Views.LogOn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom.Interface.Windows.Views.Menu
{
    public partial class FrmMenuTrees : Form
    {
        public FrmMenuTrees()
        {
            InitializeComponent();
        }

        private void treeViewMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                #region Log On / Log Off

                case "MnuLogOff":

                    var ParentMDI = this.MdiParent;

                    foreach (var parent in MdiParent.MdiChildren)
                    {
                        parent.Close();
                    }

                    var logoff = new FrmLogon();
                    logoff.MdiParent = ParentMDI;

                    this.Close();
                    logoff.Show();

                    break;

                #endregion

                #region Configuracoes Gerais

                case "MnuUsuarios":

                    var usuario = new FrmUsuario();
                    usuario.MdiParent = this.MdiParent;
                    usuario.Show();

                    break;

                #endregion

                #region Inicialização

                #region Cadastros

                #region Empresa

                case "MnuEmpresa":

                    var empresa = new FrmEmpresa();
                    empresa.MdiParent = this.MdiParent;
                    empresa.Show();

                    break;

                    #endregion

                    #endregion

                    #endregion
            }
        }
    }
}
