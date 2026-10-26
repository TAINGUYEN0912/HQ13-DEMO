using System.Windows.Forms;
using HQ13Demo.Interfaces;

namespace HQ13Demo.Services.Notifications
{
    public class MessageBoxNotificationChannel : INotificationChannel
    {
        public void Notify(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
