using System.Windows.Forms;
using Microsoft.Deployment.WindowsInstaller;

namespace MyCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult ShowLicenseInfo(Session session)
        {
            LicenseInfoForm frmInfo = new LicenseInfoForm(session);
            if (frmInfo.ShowDialog() == DialogResult.Cancel)
            {
                return ActionResult.UserExit;
            }

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult RemoveTools(Session session)
        {
            session.Log("Removing tools...");
            var result = MessageBox.Show("Do you want to remove tools");
            if(result == DialogResult.OK)
            {
                return ActionResult.Success;
            }

            return ActionResult.UserExit;
        }
    }
}
