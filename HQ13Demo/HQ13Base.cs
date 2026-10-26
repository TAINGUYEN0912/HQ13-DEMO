using System;
using System.Windows.Forms;
using HQ13Demo.Interfaces;
using HQ13Demo.Services;
using HQ13Demo.Services.Notifications;

namespace HQ13Demo
{
    public partial class HQ13Base : Form
    {
        public ICustomsService CustomsService { get; set; }
        public INotificationChannel NotificationChannel { get; set; }

        public HQ13Base()
        {
            InitializeComponent();

            CustomsService = new CustomsService();
            NotificationChannel = new MessageBoxNotificationChannel();
        }

        public HQ13Base(ICustomsService customsService, INotificationChannel notificationChannel)
        {
            InitializeComponent();
            CustomsService = customsService ?? new CustomsService();
            NotificationChannel = notificationChannel ?? new MessageBoxNotificationChannel();
        }

        public void ExecuteClearanceProcess()
        {
            string containerNo = txtSoCont.Text.Trim();
            if (string.IsNullOrEmpty(containerNo))
            {
                NotificationChannel.Notify(this.Text, "Vui lòng nhập số container!");
                txtSoCont.Focus();
                return;
            }

            var result = CustomsService.CheckClearance(containerNo);
            if (!result.IsSuccess)
            {
                NotificationChannel.Notify(this.Text, result.Message);
                return;
            }

            string message = GetCustom();

            ShowMessage(message);
        }

        public virtual string GetCustom()
        {
            return "Cont A đã thông quan";
        }

        protected void ShowMessage(string message)
        {
            NotificationChannel.Notify(this.Text, message);
        }

        private void btnThongQuan_Click(object sender, EventArgs e)
        {
            ExecuteClearanceProcess();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
