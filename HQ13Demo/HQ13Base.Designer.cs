namespace HQ13Demo
{
    partial class HQ13Base
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblSoCont = new System.Windows.Forms.Label();
            this.txtSoCont = new System.Windows.Forms.TextBox();
            this.btnThongQuan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblSoCont
            //
            this.lblSoCont.AutoSize = true;
            this.lblSoCont.Location = new System.Drawing.Point(25, 28);
            this.lblSoCont.Name = "lblSoCont";
            this.lblSoCont.Size = new System.Drawing.Size(48, 13);
            this.lblSoCont.TabIndex = 0;
            this.lblSoCont.Text = "Số cont:";
            //
            // txtSoCont
            //
            this.txtSoCont.Location = new System.Drawing.Point(90, 25);
            this.txtSoCont.Name = "txtSoCont";
            this.txtSoCont.Size = new System.Drawing.Size(220, 20);
            this.txtSoCont.TabIndex = 1;
            //
            // btnThongQuan
            //
            this.btnThongQuan.Location = new System.Drawing.Point(90, 65);
            this.btnThongQuan.Name = "btnThongQuan";
            this.btnThongQuan.Size = new System.Drawing.Size(110, 35);
            this.btnThongQuan.TabIndex = 2;
            this.btnThongQuan.Text = "Thông quan";
            this.btnThongQuan.UseVisualStyleBackColor = true;
            this.btnThongQuan.Click += new System.EventHandler(this.btnThongQuan_Click);
            //
            // btnDong
            //
            this.btnDong.Location = new System.Drawing.Point(210, 65);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            //
            // HQ13Base
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 125);
            this.Controls.Add(this.lblSoCont);
            this.Controls.Add(this.txtSoCont);
            this.Controls.Add(this.btnThongQuan);
            this.Controls.Add(this.btnDong);
            this.Name = "HQ13Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HQ13Base";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        // protected: để form con (HQ13, HQ13A) truy cập / chỉnh được trong Designer
        protected System.Windows.Forms.Label lblSoCont;
        protected System.Windows.Forms.TextBox txtSoCont;
        protected System.Windows.Forms.Button btnThongQuan;
        protected System.Windows.Forms.Button btnDong;
    }
}
