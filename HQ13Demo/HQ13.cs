namespace HQ13Demo
{
    /// <summary>
    /// Màn hình HQ13: Kế thừa HQ13Base.
    /// Không cần override GetCustom() -> tự động dùng câu mặc định của cha: "Cont A đã thông quan".
    /// </summary>
    public partial class HQ13 : HQ13Base
    {
        public HQ13() : base()
        {
            InitializeComponent();
            this.Text = "HQ13 - Thông quan chuẩn";
        }
    }
}
