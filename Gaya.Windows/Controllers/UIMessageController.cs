using System.Windows.Forms;
using Gaya.Windows.Mensagens;

namespace Gaya.Windows.Controllers
{
    public class UIMessageController
    {
        public bool SolicitarCertezaEncerrar()
        {
            var dialogResult = MessageBox.Show(Internal.MSG0002, Internal.MSG0000, MessageBoxButtons.YesNo);

            return dialogResult == DialogResult.Yes;
        }
    }
}