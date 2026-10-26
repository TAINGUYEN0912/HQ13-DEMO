namespace HQ13Demo
{
    /// <summary>
    /// Màn hình HQ13A: Kế thừa HQ13Base.
    /// Ghi đè DUY NHẤT 1 hàm GetCustom() để đổi thông báo sang câu có mã ISO.
    /// </summary>
    public partial class HQ13A : HQ13Base
    {
        public HQ13A() : base()
        {
            InitializeComponent();
            this.Text = "HQ13A - Thông quan có mã ISO";
        }

        public override string GetCustom()
        {
            return "Cont A ISO 2300 đã thông quan";
        }
    }
}
