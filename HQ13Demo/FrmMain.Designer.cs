namespace HQ13Demo
{
    partial class FrmMain
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
            this.btnOpenHQ13 = new System.Windows.Forms.Button();
            this.btnOpenHQ13A = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHQ13
            // 
            this.btnOpenHQ13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHQ13.Location = new System.Drawing.Point(40, 31);
            this.btnOpenHQ13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenHQ13.Name = "btnOpenHQ13";
            this.btnOpenHQ13.Size = new System.Drawing.Size(373, 55);
            this.btnOpenHQ13.TabIndex = 0;
            this.btnOpenHQ13.Text = "1. Mở MH HQ13 (Thông quan chuẩn)";
            this.btnOpenHQ13.UseVisualStyleBackColor = true;
            this.btnOpenHQ13.Click += new System.EventHandler(this.btnOpenHQ13_Click);
            // 
            // btnOpenHQ13A
            // 
            this.btnOpenHQ13A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHQ13A.Location = new System.Drawing.Point(40, 101);
            this.btnOpenHQ13A.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenHQ13A.Name = "btnOpenHQ13A";
            this.btnOpenHQ13A.Size = new System.Drawing.Size(373, 55);
            this.btnOpenHQ13A.TabIndex = 1;
            this.btnOpenHQ13A.Text = "2. Mở MH HQ13A (Thông quan có ISO)";
            this.btnOpenHQ13A.UseVisualStyleBackColor = true;
            this.btnOpenHQ13A.Click += new System.EventHandler(this.btnOpenHQ13A_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 181);
            this.Controls.Add(this.btnOpenHQ13);
            this.Controls.Add(this.btnOpenHQ13A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HQ13 Demo - OOP & SOLID";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnOpenHQ13;
        private System.Windows.Forms.Button btnOpenHQ13A;
    }
}
