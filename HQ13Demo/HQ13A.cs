namespace HQ13Demo
{
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
