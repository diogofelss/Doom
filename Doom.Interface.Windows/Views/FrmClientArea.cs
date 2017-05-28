using Doom.Interface.Windows.Views.LogOn;
using Doom.Interface.Windows.Views.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doom.Interface.Windows.Views
{
    public partial class FrmClientArea : Form
    {
        public FrmClientArea()
        {
            InitializeComponent();
        }

        private void UIClientArea_Load(object sender, EventArgs e)
        {
            var logon = new FrmLogon();

            logon.MdiParent = this;
            logon.Show();
        }

        #region Eventos dos Menus


        #endregion

        private void UIClientArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
