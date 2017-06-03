using System;
using System.Windows.Forms;
using Gaya.Interface.Windows.Controllers;
using Gaya.Interface.Windows.Views.Configuracoes_Gerais;
using Gaya.Interface.Windows.Views.Inicializacao.Cadastros;
using Gaya.Interface.Windows.Views.LogOn;

namespace Gaya.Interface.Windows.Views.Menu
{
    public partial class FrmMenuTrees : Form
    {
        public FrmMenuTrees()
        {
            InitializeComponent();
        }

        #region Métodos

        private void ControlarMenus(string menuName)
        {
            switch (menuName)
            {
                case "MnuLogOff":

                    var mensagemsistema = new UIMessageController();

                    if (mensagemsistema.SolicitarCertezaEncerrar())
                    {
                        var ParentMDI = MdiParent;

                        foreach (var parent in MdiParent.MdiChildren)
                        {
                            parent.Close();
                        }

                        var logoff = new FrmLogon();
                        logoff.MdiParent = ParentMDI;

                        Close();
                        logoff.Show();
                    }

                    break;

                case "MnuUsuarios":

                    var usuario = new FrmUsuario();
                    usuario.MdiParent = MdiParent;
                    usuario.Show();

                    break;

                case "MnuEmpresa":

                    var empresa = new FrmEmpresa();
                    empresa.MdiParent = MdiParent;
                    empresa.Show();

                    break;
            }
        }

        #endregion

        #region Eventos

        private void treeViewMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                ControlarMenus(e.Node.Name);
            }
            catch (Exception ex)
            {
                Globals.TratamentoErro.TratarErro(ex);
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion
    }
}